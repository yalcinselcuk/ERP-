using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace w
{
    public class Comboboxs : ComboBox
    {
        ComboBox combobox;

        public Comboboxs()
        {
            combobox = new ComboBox();
            this.combobox.BackColor = System.Drawing.Color.Aqua;
        }

    }
}
