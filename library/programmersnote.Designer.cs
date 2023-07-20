
namespace library
{
    partial class programmersnote
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(programmersnote));
            this.lblprogrammerinfo = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // lblprogrammerinfo
            // 
            this.lblprogrammerinfo.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblprogrammerinfo.Location = new System.Drawing.Point(23, 60);
            this.lblprogrammerinfo.Name = "lblprogrammerinfo";
            this.lblprogrammerinfo.Size = new System.Drawing.Size(619, 330);
            this.lblprogrammerinfo.TabIndex = 3;
            this.lblprogrammerinfo.Text = resources.GetString("lblprogrammerinfo.Text");
            this.lblprogrammerinfo.WrapToLine = true;
            // 
            // programmersnote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 411);
            this.Controls.Add(this.lblprogrammerinfo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "programmersnote";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Style = MetroFramework.MetroColorStyle.Magenta;
            this.Text = "Programcı Notu";
            this.Load += new System.EventHandler(this.programmersnote_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroLabel lblprogrammerinfo;
    }
}