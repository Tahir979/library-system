
namespace library
{
    partial class aboutfloorsystem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(aboutfloorsystem));
            this.pctfloor = new System.Windows.Forms.PictureBox();
            this.lblaboutfloor = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pctfloor)).BeginInit();
            this.SuspendLayout();
            // 
            // pctfloor
            // 
            this.pctfloor.Location = new System.Drawing.Point(401, 60);
            this.pctfloor.Name = "pctfloor";
            this.pctfloor.Size = new System.Drawing.Size(588, 675);
            this.pctfloor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctfloor.TabIndex = 3;
            this.pctfloor.TabStop = false;
            // 
            // lblaboutfloor
            // 
            this.lblaboutfloor.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblaboutfloor.Location = new System.Drawing.Point(23, 60);
            this.lblaboutfloor.Name = "lblaboutfloor";
            this.lblaboutfloor.Size = new System.Drawing.Size(358, 927);
            this.lblaboutfloor.TabIndex = 2;
            this.lblaboutfloor.Text = resources.GetString("lblaboutfloor.Text");
            this.lblaboutfloor.WrapToLine = true;
            // 
            // aboutfloorsystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 764);
            this.Controls.Add(this.pctfloor);
            this.Controls.Add(this.lblaboutfloor);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "aboutfloorsystem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Style = MetroFramework.MetroColorStyle.Magenta;
            this.Text = "Kat Düzeni Hk.";
            this.Load += new System.EventHandler(this.aboutfloorsystem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctfloor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pctfloor;
        private MetroFramework.Controls.MetroLabel lblaboutfloor;
    }
}