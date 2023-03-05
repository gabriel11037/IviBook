
namespace ivifb.Forms
{
    partial class LogareFreeBook
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
            this.emailLogin = new System.Windows.Forms.TextBox();
            this.parolaLogin = new System.Windows.Forms.TextBox();
            this.emailLTXT = new System.Windows.Forms.Label();
            this.passLTXT = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // emailLogin
            // 
            this.emailLogin.BackColor = System.Drawing.Color.Linen;
            this.emailLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.emailLogin.Location = new System.Drawing.Point(225, 66);
            this.emailLogin.Name = "emailLogin";
            this.emailLogin.Size = new System.Drawing.Size(244, 26);
            this.emailLogin.TabIndex = 0;
            // 
            // parolaLogin
            // 
            this.parolaLogin.BackColor = System.Drawing.Color.Linen;
            this.parolaLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.parolaLogin.Location = new System.Drawing.Point(225, 135);
            this.parolaLogin.Name = "parolaLogin";
            this.parolaLogin.PasswordChar = '*';
            this.parolaLogin.Size = new System.Drawing.Size(244, 26);
            this.parolaLogin.TabIndex = 1;
            // 
            // emailLTXT
            // 
            this.emailLTXT.AutoSize = true;
            this.emailLTXT.Location = new System.Drawing.Point(157, 68);
            this.emailLTXT.Name = "emailLTXT";
            this.emailLTXT.Size = new System.Drawing.Size(52, 20);
            this.emailLTXT.TabIndex = 2;
            this.emailLTXT.Text = "Email:";
            // 
            // passLTXT
            // 
            this.passLTXT.AutoSize = true;
            this.passLTXT.Location = new System.Drawing.Point(157, 137);
            this.passLTXT.Name = "passLTXT";
            this.passLTXT.Size = new System.Drawing.Size(58, 20);
            this.passLTXT.TabIndex = 3;
            this.passLTXT.Text = "Parola:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Tan;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(215, 233);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(204, 48);
            this.button1.TabIndex = 4;
            this.button1.Text = "Logare";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LogareFreeBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(636, 309);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.passLTXT);
            this.Controls.Add(this.emailLTXT);
            this.Controls.Add(this.parolaLogin);
            this.Controls.Add(this.emailLogin);
            this.Name = "LogareFreeBook";
            this.Text = "Logare";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox emailLogin;
        private System.Windows.Forms.TextBox parolaLogin;
        private System.Windows.Forms.Label emailLTXT;
        private System.Windows.Forms.Label passLTXT;
        private System.Windows.Forms.Button button1;
    }
}