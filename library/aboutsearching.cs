using System;

namespace library
{
    public partial class aboutsearching : MetroFramework.Forms.MetroForm
    {
        public aboutsearching()
        {
            InitializeComponent();
        }

        private void aboutsearching_Load(object sender, EventArgs e)
        {
            lblinfosearch.Text = Localization.metrolabel1_aboutsearching;
            this.Text = Localization.lbl_searchinfo;
            this.Refresh();
        }
    }
}
