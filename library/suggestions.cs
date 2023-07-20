using System;
using System.Drawing;

namespace library
{
    public partial class suggestions : MetroFramework.Forms.MetroForm
    {
        public suggestions()
        {
            InitializeComponent();
        }

        private void suggestions_Load(object sender, EventArgs e)
        {
            lblsuggestioninfo.Text = Localization.metrolabel1_suggestions;
            this.Text = Localization.lbl_otherissuesinfo;
            this.Refresh();

            if (lang.Default.language == Localization.turkce)
            {
                lblsuggestioninfo.Size = new Size(746, 626);
                this.Size = new Size(792, 709);
                this.Refresh();
            }
            else if (lang.Default.language == Localization.english)
            {
                lblsuggestioninfo.Size = new Size(746, 465);
                this.Size = new Size(792, 534);
                this.Refresh();
            }
        }
    }
}
