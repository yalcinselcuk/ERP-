using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Manav.Controls
{
    internal class _combobox : ComboBox
    {
        public _combobox()
        {
        }

        #region Events
        protected override void OnDropDown(EventArgs e)
        {
            Form parent = this.FindForm();

            popup _popup = new popup(this.Name);
            this.DroppedDown = false;
            _popup.Show();
            _popup.FormBorderStyle = FormBorderStyle.None;
            _popup.Location = new Point(parent.Left + this.Left + 5, parent.Top + this.Bottom + this.Height + 2);

            _popup.Width = 409;
            _popup.Height = 248;
            _popup.AfterRowSelectEvent += new AfterRowSelectEventHandler(p_AfterRowSelectEvent);
            base.OnDropDown(e);
        }
        protected override void OnDropDownClosed(EventArgs e)
        {
            base.OnDropDownClosed(e);
        }
        protected override void OnMouseClick(MouseEventArgs e)
        {
            this.DroppedDown = false;
        }

        void p_AfterRowSelectEvent(object sender, string selectedvalue, string selectedid)
        {
            SetText(selectedvalue, selectedid);

        }
        #endregion

        #region Public
        public void SetText(string value, string selectedid)
        {
            this.Text = value;
            this.ValueMember = selectedid;
            this.DisplayMember = value;


        }
        //protected override void OnClick(EventArgs e)
        //{
        //    Form parent = this.FindForm();

        //    popup _popup = new popup(this.Name);
        //    this.DroppedDown = false;
        //    _popup.Show();
        //    _popup.FormBorderStyle = FormBorderStyle.None;
        //    _popup.Location = new Point(parent.Left + this.Left + 5, parent.Top + this.Bottom + this.Height + 2);

        //    _popup.Width = 409;
        //    _popup.Height = 248;
        //    _popup.AfterRowSelectEvent += new AfterRowSelectEventHandler(p_AfterRowSelectEvent);
        //    base.OnClick(e);
        //}

        
        #endregion
    }
}
