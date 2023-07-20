
namespace library
{
    partial class aboutsearching
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(aboutsearching));
            this.lblinfosearch = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // lblinfosearch
            // 
            this.lblinfosearch.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblinfosearch.Location = new System.Drawing.Point(23, 60);
            this.lblinfosearch.Name = "lblinfosearch";
            this.lblinfosearch.Size = new System.Drawing.Size(825, 703);
            this.lblinfosearch.TabIndex = 1;
            this.lblinfosearch.Text = resources.GetString("lblinfosearch.Text");
            this.lblinfosearch.WrapToLine = true;
            // 
            // aboutsearching
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 783);
            this.Controls.Add(this.lblinfosearch);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "aboutsearching";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Style = MetroFramework.MetroColorStyle.Magenta;
            this.Text = "Arama Hk.";
            this.Load += new System.EventHandler(this.aboutsearching_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroLabel lblinfosearch;
    }
}