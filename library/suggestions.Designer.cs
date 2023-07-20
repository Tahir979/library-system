
namespace library
{
    partial class suggestions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(suggestions));
            this.lblsuggestioninfo = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // lblsuggestioninfo
            // 
            this.lblsuggestioninfo.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblsuggestioninfo.Location = new System.Drawing.Point(23, 60);
            this.lblsuggestioninfo.Name = "lblsuggestioninfo";
            this.lblsuggestioninfo.Size = new System.Drawing.Size(746, 465);
            this.lblsuggestioninfo.TabIndex = 117;
            this.lblsuggestioninfo.Text = resources.GetString("lblsuggestioninfo.Text");
            this.lblsuggestioninfo.WrapToLine = true;
            // 
            // suggestions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 534);
            this.Controls.Add(this.lblsuggestioninfo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "suggestions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Style = MetroFramework.MetroColorStyle.Magenta;
            this.Text = "Öneriler ve Diğer Konular Hk.";
            this.Load += new System.EventHandler(this.suggestions_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroLabel lblsuggestioninfo;
    }
}