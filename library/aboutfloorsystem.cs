using System;

namespace library
{
    public partial class aboutfloorsystem : MetroFramework.Forms.MetroForm
    {
        public aboutfloorsystem()
        {
            InitializeComponent();
        }

        private void aboutfloorsystem_Load(object sender, EventArgs e)
        {
            lblaboutfloor.Text = Localization.metrolabel1_aboutfloor;
            this.Text = Localization.lbl_floorinfo;
            this.Refresh();

            if (lang.Default.language == Localization.turkce)
            {
                pctfloor.Image = Properties.Resources.raftr;
                this.Refresh();
            }
            else if (lang.Default.language == Localization.english)
            {
                pctfloor.Image = Properties.Resources.shelfen;
                this.Refresh();
            }
        }
    }
}
