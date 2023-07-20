
namespace library
{
    partial class aboutediting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(aboutediting));
            this.lbleditinfo = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // lbleditinfo
            // 
            this.lbleditinfo.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lbleditinfo.Location = new System.Drawing.Point(23, 60);
            this.lbleditinfo.Name = "lbleditinfo";
            this.lbleditinfo.Size = new System.Drawing.Size(825, 612);
            this.lbleditinfo.TabIndex = 1;
            this.lbleditinfo.Text = resources.GetString("lbleditinfo.Text");
            this.lbleditinfo.WrapToLine = true;
            // 
            // aboutediting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 681);
            this.Controls.Add(this.lbleditinfo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "aboutediting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Style = MetroFramework.MetroColorStyle.Magenta;
            this.Text = "Düzenleme İşlemleri Hk.";
            this.Load += new System.EventHandler(this.aboutediting_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroLabel lbleditinfo;
    }
}