
namespace ivifb.Forms
{
    partial class ShowCarti
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
            this.showTitluLbl = new System.Windows.Forms.Label();
            this.showAutorLbl = new System.Windows.Forms.Label();
            this.showIndexLbl = new System.Windows.Forms.Label();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // showTitluLbl
            // 
            this.showTitluLbl.AutoSize = true;
            this.showTitluLbl.Location = new System.Drawing.Point(47, 66);
            this.showTitluLbl.Name = "showTitluLbl";
            this.showTitluLbl.Size = new System.Drawing.Size(51, 20);
            this.showTitluLbl.TabIndex = 0;
            this.showTitluLbl.Text = "label1";
            // 
            // showAutorLbl
            // 
            this.showAutorLbl.AutoSize = true;
            this.showAutorLbl.Location = new System.Drawing.Point(47, 210);
            this.showAutorLbl.Name = "showAutorLbl";
            this.showAutorLbl.Size = new System.Drawing.Size(51, 20);
            this.showAutorLbl.TabIndex = 1;
            this.showAutorLbl.Text = "label1";
            // 
            // showIndexLbl
            // 
            this.showIndexLbl.AutoSize = true;
            this.showIndexLbl.Location = new System.Drawing.Point(47, 357);
            this.showIndexLbl.Name = "showIndexLbl";
            this.showIndexLbl.Size = new System.Drawing.Size(51, 20);
            this.showIndexLbl.TabIndex = 2;
            this.showIndexLbl.Text = "label1";
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(142, 12);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(646, 426);
            this.webBrowser1.TabIndex = 3;
            // 
            // ShowCarti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.showIndexLbl);
            this.Controls.Add(this.showAutorLbl);
            this.Controls.Add(this.showTitluLbl);
            this.Name = "ShowCarti";
            this.Text = "Carti";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.WebBrowser webBrowser1;
        public System.Windows.Forms.Label showAutorLbl;
        public System.Windows.Forms.Label showIndexLbl;
        public System.Windows.Forms.Label showTitluLbl;
    }
}