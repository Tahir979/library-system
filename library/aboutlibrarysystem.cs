using System;

namespace library
{
    public partial class aboutlibrarysystem : MetroFramework.Forms.MetroForm
    {
        public aboutlibrarysystem()
        {
            InitializeComponent();
        }

        private void aboutlibrarysystem_Load(object sender, EventArgs e)
        {
            lbl_libraryinfo.Text = Localization.metrolabel1_aboutlibrarysystem;
            lbl_shelf.Text = Localization.lib_lbl_shelf;
            lbl_floor4.Text = Localization.lib_lbl_floor4;
            lbl_floor3.Text = Localization.lib_lbl_floor3;
            lbl_floor2.Text = Localization.lib_lbl_floor2;
            lbl_floor1.Text = Localization.lib_lbl_floor1;
            lbl_floor0.Text = Localization.lib_lbl_floor0;
            this.Text = Localization.lbl_libraryorderinfo;
            this.Refresh();
        }
    }
}
