using Manav.Db_Adress;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Manav.DataSets;
using Manav.MyCommandBuilder;
using System.Windows.Forms;

namespace Manav.StokHar
{
    internal class stokHareketClass
    {
        #region Variables
        SqlDataAdapter adtrdetail = null;
        SqlDataAdapter adtrmain = null;
        SqlDataAdapter adapter = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        SqlConnection conn = Mssql_Manav.GetDBConnection();
        SqlCommandBuilder commandBuilder;
        dsStokHar ds = null;


        int mainid;
        public static int fistype;
        #endregion

        #region Property
        public dsStokHar DS { get { return ds; } }
        public int _MainId
        {
            get { return mainid; }
        }
        #endregion

        #region Constructor
        public stokHareketClass()
        {
            this.ds = new dsStokHar();
        }
        public stokHareketClass(dsStokHar ds)
        {
            this.ds = ds;
        }
        #endregion

        #region Public Methods

        public void Init()
        {

        }

        public void GetMainValues(int fisref)
        {

            try
            {
                adtrmain = new SqlDataAdapter("SELECT a.id, a.fisno, a.fistipi, a.tarih, a.belgeno, a.aciklama, " +
                                              "a.firmaid, a.depoid, firmakod = b.kod, depokod = c.kod FROM stokharmain a " +
                                              "LEFT OUTER JOIN firma b ON b.id = a.firmaid " +
                                              "LEFT OUTER JOIN depo c ON c.id = a.depoid " +
                                              "WHERE a.id = " + fisref, conn);

                conn.Open();

                adtrmain.Fill(ds.stokharmain);

            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            conn.Close();
        }

        public void GetDetailsValues(int fisref)
        {

            try
            {
                adtrdetail = new SqlDataAdapter();
                SqlCommand cmd = new SqlCommand("select a.id, a.mainid, a.urunid, a.renkid, a.birimid, urunkod = b.kod, renkkod = d.kod, birimkod = c.kod, a.miktar from stokhardetail a " +
                                                "left outer join stok b on b.id = a.urunid " +
                                                "left outer join birim c on c.id = a.birimid " +
                                                "left outer join renk d on d.id = a.renkid " +
                                                "WHERE a.mainid =  " + fisref, conn);
                conn.Open();
                adtrdetail.SelectCommand = cmd;
                adtrdetail.Fill(ds.stokhardetail);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            finally
            {
                conn.Close();
            }
        }

        public Result LoadData(int fisref)
        {
            mainid = fisref;

            GetMainValues(mainid);
            GetDetailsValues(mainid);
            if (mainid < 0)
            {
                CreateNew();
                return new Result { resultbool = true, resultmessage = "" };
            }
            return new Result { resultbool = true, resultmessage = "" };
        }


        public Result Validate()
        {
            string tarihsecilen = DS.stokharmain.Rows[0]["tarih"].ToString();
            string şimdikitarih = DateTime.Now.ToString();
            int tarihsonuc = tarihsecilen.CompareTo(şimdikitarih);
            //if (tarihsonuc == 1)
            //{
            //    return new Result { resultbool = false, resultmessage = "Gelecek Tarihe Giriş Yapılamaz" };
            //}
            if (DS.stokharmain.Rows[0]["firmakod"].ToString() == "")
            {
                return new Result { resultbool = false, resultmessage = "Firma Seçilmedi" };
            }
            if (DS.stokharmain.Rows[0]["depokod"].ToString() == "")
            {
                return new Result { resultbool = false, resultmessage = "Depo Seçilmedi" };

            }
            if (DS.stokharmain.Rows[0]["belgeno"].ToString() == "")
            {
                this.ds.stokharmain[0]["belgeno"] = DS.stokharmain.Rows[0]["fisno"];// row["fisNo"];

            }
            return new Result { resultbool = true, resultmessage = "" };
        }
        public Result ValidateDelete()
        {
            return new Result { resultbool = true, resultmessage = "" };
        }


        public Result Save()
        {
            SqlTransaction transaction = null;
            //if (ds.stokharmain.Rows[0]["fistipi"].ToString() == "1")
            //{
            try
            {
                conn.Open();
                adtrmain = new SqlDataAdapter();
                transaction = conn.BeginTransaction();


                cmd = new SqlCommand("select id, fisno, fistipi,  tarih, belgeno, aciklama, firmaid, depoid from stokharmain", conn);
                cmd.Transaction = transaction;
                adtrmain.SelectCommand = cmd;

                commandBuilder = new SqlCommandBuilder(adtrmain);

                DS.stokharmain[0].EndEdit();

                //MyCommandBuilders test = new MyCommandBuilders();
                //adtrmain.InsertCommand = test.GetInsertCommand(ds.stokharmain);
                adtrmain.InsertCommand = commandBuilder.GetInsertCommand(true);
                adtrmain.DeleteCommand = commandBuilder.GetDeleteCommand(true);
                adtrmain.UpdateCommand = commandBuilder.GetUpdateCommand(true);

                adtrmain.Update(DS.stokharmain);


                cmd = new SqlCommand("select id, mainid, urunid, renkid, birimid, miktar from stokhardetail", conn);
                adtrdetail = new SqlDataAdapter();
                cmd.Transaction = transaction;
                adtrdetail.SelectCommand = cmd;

                commandBuilder = new SqlCommandBuilder(adtrdetail);

                adtrdetail.InsertCommand = commandBuilder.GetInsertCommand(true);
                adtrdetail.DeleteCommand = commandBuilder.GetDeleteCommand(true);
                adtrdetail.UpdateCommand = commandBuilder.GetUpdateCommand(true);

                adtrdetail.Update(DS.stokhardetail);

                transaction.Commit();
            }
            catch (Exception ex)
            {
                transaction.Rollback();

                return new Result { resultbool = false, resultmessage = ex.ToString() };

            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
            //}
            return new Result { resultbool = true, resultmessage = "" };
        }

        public Result Delete()
        {
            if (fistype == 1)
            {
                ds.stokharmain.Rows[0].Delete();
                Save();
            }
            return new Result { resultbool = true, resultmessage = "" };
        }
        public void CreateNew()
        {
            mainid = helper.helperclass.GetId("stokharmain");

            DataRow rnew = this.ds.stokharmain.NewRow();
            rnew["id"] = mainid;
            rnew["fisno"] = (mainid).ToString("000000");
            rnew["tarih"] = DateTime.Now;
            rnew["fistipi"] = fistype;
            this.ds.stokharmain.Rows.Add(rnew);

        }

        public void AddDetailsRow(StokHarDetailInfo stokHarDetailInfo)
        {
            int duplicatecontrol = DataGridDuplicateControl(stokHarDetailInfo);

            if (duplicatecontrol == 0)
            {
                DataRow r = this.DS.stokhardetail.NewRow();
                r["id"] = helper.helperclass.GetId("stokhardetail");
                r["mainid"] = mainid;
                r["urunid"] = stokHarDetailInfo.urunid;
                r["urunkod"] = stokHarDetailInfo.urunkod;
                r["renkid"] = stokHarDetailInfo.renkid;
                r["renkkod"] = stokHarDetailInfo.renkkod;
                r["birimid"] = stokHarDetailInfo.birimid;
                r["birimkod"] = stokHarDetailInfo.birimkod;
                r["miktar"] = stokHarDetailInfo.miktar;
                this.DS.stokhardetail.Rows.Add(r);
            }
        }
        public void AddMainRow(StokHarMainInfo stokHarMainInfo)
        {

            DataRow r = this.DS.stokharmain.NewRow();
            r["id"] = helper.helperclass.GetId("stokharmain");
            r["fisno"] = stokHarMainInfo.fisno;
            r["firmaid"] = stokHarMainInfo.firmaid;
            r["depoid"] = stokHarMainInfo.depoid;
            r["firmakod"] = stokHarMainInfo.firmakod;
            r["depokod"] = stokHarMainInfo.depokod;

            this.DS.stokharmain.Rows.Add(r);

        }

        public int DataGridDuplicateControl(StokHarDetailInfo stokHarDetailInfo)
        {
            //foreach (DataRow row in ds.stokhardetail.Rows)
            //{
            //    if (row["urunkod"].ToString() == stokHarDetailInfo.urunkod.ToString()
            //        &&
            //        row["renkkod"].ToString() == stokHarDetailInfo.renkkod.ToString()
            //        &&
            //        row["birimkod"].ToString() == stokHarDetailInfo.birimkod.ToString())
            //    {
            //        MessageBox.Show("Mükerrer Kayıt Girdiniz", "KEY BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //        return 1;
            //    }
            //}
            return 0;
        }
        #endregion
    }
}

public class StokHarDetailInfo
{
    #region Property
    public int id { get; set; }
    public int mainid { get; set; }
    public int urunid { get; set; }
    public int renkid { get; set; }
    public int birimid { get; set; }
    public decimal miktar { get; set; }
    public string urunkod { get; set; }
    public string renkkod { get; set; }
    public string birimkod { get; set; }
    #endregion
}
public class StokHarMainInfo
{
    #region Property
    public int id { get; set; }
    public int fisno { get; set; }
    public int fistipi { get; set; }
    public DateTime tarih { get; set; }
    public int belgeno { get; set; }
    public string aciklama { get; set; }
    public int firmaid { get; set; }
    public int depoid { get; set; }
    public string firmakod { get; set; }
    public string depokod { get; set; }
    #endregion
}
public class Result
{
    #region Properties
    public bool resultbool { get; set; }
    public string resultmessage { get; set; }
    #endregion
}



