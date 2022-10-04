using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using ComboBox = System.Windows.Forms.ComboBox;

namespace Manav.Comp
{
    public partial class comb : ComboBox
    {
        ComboBox combobox;
        public comb()
        {
            InitializeComponent();
            combobox = new ComboBox();
            this.combobox.Name = "firmaCombo";
            this.combobox.Size = new System.Drawing.Size(222, 28);
            this.combobox.TabIndex = 2;
            this.combobox.FlatStyle = FlatStyle.Flat;
            this.combobox.BackColor = System.Drawing.Color.Aqua;
        }
    }
}
