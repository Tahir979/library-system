using System;

namespace library
{
    public partial class aboutediting : MetroFramework.Forms.MetroForm
    {
        public aboutediting()
        {
            InitializeComponent();
        }

        private void aboutediting_Load(object sender, EventArgs e)
        {
            lbleditinfo.Text = Localization.metrolabel1_aboutediting;
            this.Text = Localization.lbl_orderinfo;
            this.Refresh();
        }
    }
}
