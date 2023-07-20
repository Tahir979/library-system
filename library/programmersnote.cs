using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace library
{
    public partial class programmersnote : MetroFramework.Forms.MetroForm
    {
        public programmersnote()
        {
            InitializeComponent();
        }

        private void programmersnote_Load(object sender, EventArgs e)
        {
            lblprogrammerinfo.Text = Localization.metrolabel1_programmersnote;
            this.Text = Localization.lbl_programmeinfo;
            this.Refresh();
        }
    }
}
