using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manav.Tanimlar
{
    internal interface ITanımlar
    {
        void LoadData(int fisref);
        void SaveData();
        void EmptyRowControle();
        void SetRowId();
        int RowKodIsNull();
        void CreateNew();
        void RowDelete();
    }
}
