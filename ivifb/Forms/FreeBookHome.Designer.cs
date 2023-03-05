
namespace ivifb
{
    partial class FreeBookHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FreeBookHome));
            this.libraryLoad = new System.Windows.Forms.PictureBox();
            this.loginText = new System.Windows.Forms.TextBox();
            this.loginBTN = new System.Windows.Forms.Button();
            this.inregBTN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.libraryLoad)).BeginInit();
            this.SuspendLayout();
            // 
            // libraryLoad
            // 
            this.libraryLoad.Image = ((System.Drawing.Image)(resources.GetObject("libraryLoad.Image")));
            this.libraryLoad.Location = new System.Drawing.Point(12, 12);
            this.libraryLoad.Name = "libraryLoad";
            this.libraryLoad.Size = new System.Drawing.Size(587, 355);
            this.libraryLoad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.libraryLoad.TabIndex = 0;
            this.libraryLoad.TabStop = false;
            // 
            // loginText
            // 
            this.loginText.BackColor = System.Drawing.Color.Wheat;
            this.loginText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.loginText.Enabled = false;
            this.loginText.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginText.Location = new System.Drawing.Point(12, 387);
            this.loginText.Multiline = true;
            this.loginText.Name = "loginText";
            this.loginText.Size = new System.Drawing.Size(587, 170);
            this.loginText.TabIndex = 1;
            this.loginText.Text = resources.GetString("loginText.Text");
            // 
            // loginBTN
            // 
            this.loginBTN.BackColor = System.Drawing.Color.Tan;
            this.loginBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginBTN.Font = new System.Drawing.Font("Microsoft YaHei", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginBTN.ForeColor = System.Drawing.Color.Black;
            this.loginBTN.Location = new System.Drawing.Point(750, 91);
            this.loginBTN.Name = "loginBTN";
            this.loginBTN.Size = new System.Drawing.Size(171, 71);
            this.loginBTN.TabIndex = 2;
            this.loginBTN.Tag = "";
            this.loginBTN.Text = "Login";
            this.loginBTN.UseVisualStyleBackColor = false;
            this.loginBTN.Click += new System.EventHandler(this.loginBTN_Click);
            // 
            // inregBTN
            // 
            this.inregBTN.BackColor = System.Drawing.Color.Tan;
            this.inregBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.inregBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.inregBTN.Font = new System.Drawing.Font("Microsoft YaHei", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inregBTN.ForeColor = System.Drawing.Color.Black;
            this.inregBTN.Location = new System.Drawing.Point(750, 362);
            this.inregBTN.Name = "inregBTN";
            this.inregBTN.Size = new System.Drawing.Size(171, 71);
            this.inregBTN.TabIndex = 3;
            this.inregBTN.Tag = "";
            this.inregBTN.Text = "Inregistrare";
            this.inregBTN.UseVisualStyleBackColor = false;
            this.inregBTN.Click += new System.EventHandler(this.inregBTN_Click);
            // 
            // FreeBookHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(1020, 587);
            this.Controls.Add(this.inregBTN);
            this.Controls.Add(this.loginBTN);
            this.Controls.Add(this.loginText);
            this.Controls.Add(this.libraryLoad);
            this.Name = "FreeBookHome";
            this.Text = "FreeBook";
            ((System.ComponentModel.ISupportInitialize)(this.libraryLoad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox libraryLoad;
        private System.Windows.Forms.TextBox loginText;
        private System.Windows.Forms.Button loginBTN;
        private System.Windows.Forms.Button inregBTN;
    }
}

