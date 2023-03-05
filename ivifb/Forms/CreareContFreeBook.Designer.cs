
namespace ivifb.Forms
{
    partial class CreareContFreeBook
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
            this.emailCreate = new System.Windows.Forms.TextBox();
            this.numeCreate = new System.Windows.Forms.TextBox();
            this.prenumeCreate = new System.Windows.Forms.TextBox();
            this.passCreate = new System.Windows.Forms.TextBox();
            this.numeCTXT = new System.Windows.Forms.Label();
            this.prenumeCTXT = new System.Windows.Forms.Label();
            this.emailCTXT = new System.Windows.Forms.Label();
            this.passCTXT = new System.Windows.Forms.Label();
            this.conpassCreate = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.InregCreate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // emailCreate
            // 
            this.emailCreate.BackColor = System.Drawing.Color.Linen;
            this.emailCreate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.emailCreate.Location = new System.Drawing.Point(340, 171);
            this.emailCreate.Name = "emailCreate";
            this.emailCreate.Size = new System.Drawing.Size(244, 26);
            this.emailCreate.TabIndex = 1;
            // 
            // numeCreate
            // 
            this.numeCreate.BackColor = System.Drawing.Color.Linen;
            this.numeCreate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numeCreate.Location = new System.Drawing.Point(340, 19);
            this.numeCreate.Name = "numeCreate";
            this.numeCreate.Size = new System.Drawing.Size(244, 26);
            this.numeCreate.TabIndex = 2;
            // 
            // prenumeCreate
            // 
            this.prenumeCreate.BackColor = System.Drawing.Color.Linen;
            this.prenumeCreate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.prenumeCreate.Location = new System.Drawing.Point(340, 92);
            this.prenumeCreate.Name = "prenumeCreate";
            this.prenumeCreate.Size = new System.Drawing.Size(244, 26);
            this.prenumeCreate.TabIndex = 3;
            // 
            // passCreate
            // 
            this.passCreate.BackColor = System.Drawing.Color.Linen;
            this.passCreate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passCreate.Location = new System.Drawing.Point(340, 248);
            this.passCreate.Name = "passCreate";
            this.passCreate.PasswordChar = '*';
            this.passCreate.Size = new System.Drawing.Size(244, 26);
            this.passCreate.TabIndex = 4;
            // 
            // numeCTXT
            // 
            this.numeCTXT.AutoSize = true;
            this.numeCTXT.Location = new System.Drawing.Point(193, 21);
            this.numeCTXT.Name = "numeCTXT";
            this.numeCTXT.Size = new System.Drawing.Size(55, 20);
            this.numeCTXT.TabIndex = 5;
            this.numeCTXT.Text = "Nume:";
            // 
            // prenumeCTXT
            // 
            this.prenumeCTXT.AutoSize = true;
            this.prenumeCTXT.Location = new System.Drawing.Point(193, 98);
            this.prenumeCTXT.Name = "prenumeCTXT";
            this.prenumeCTXT.Size = new System.Drawing.Size(68, 20);
            this.prenumeCTXT.TabIndex = 6;
            this.prenumeCTXT.Text = "Preume:";
            // 
            // emailCTXT
            // 
            this.emailCTXT.AutoSize = true;
            this.emailCTXT.Location = new System.Drawing.Point(193, 173);
            this.emailCTXT.Name = "emailCTXT";
            this.emailCTXT.Size = new System.Drawing.Size(52, 20);
            this.emailCTXT.TabIndex = 7;
            this.emailCTXT.Text = "Email:";
            // 
            // passCTXT
            // 
            this.passCTXT.AutoSize = true;
            this.passCTXT.Location = new System.Drawing.Point(187, 250);
            this.passCTXT.Name = "passCTXT";
            this.passCTXT.Size = new System.Drawing.Size(58, 20);
            this.passCTXT.TabIndex = 8;
            this.passCTXT.Text = "Parola:";
            // 
            // conpassCreate
            // 
            this.conpassCreate.BackColor = System.Drawing.Color.Linen;
            this.conpassCreate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.conpassCreate.Location = new System.Drawing.Point(340, 324);
            this.conpassCreate.Name = "conpassCreate";
            this.conpassCreate.PasswordChar = '*';
            this.conpassCreate.Size = new System.Drawing.Size(244, 26);
            this.conpassCreate.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(187, 324);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Confirmare Parola:";
            // 
            // InregCreate
            // 
            this.InregCreate.BackColor = System.Drawing.Color.Tan;
            this.InregCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InregCreate.Font = new System.Drawing.Font("Microsoft YaHei", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InregCreate.Location = new System.Drawing.Point(291, 384);
            this.InregCreate.Name = "InregCreate";
            this.InregCreate.Size = new System.Drawing.Size(183, 54);
            this.InregCreate.TabIndex = 11;
            this.InregCreate.Text = "Inregistreaza!";
            this.InregCreate.UseVisualStyleBackColor = false;
            this.InregCreate.Click += new System.EventHandler(this.InregCreate_Click_1);
            // 
            // CreareContFreeBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.InregCreate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.conpassCreate);
            this.Controls.Add(this.passCTXT);
            this.Controls.Add(this.emailCTXT);
            this.Controls.Add(this.prenumeCTXT);
            this.Controls.Add(this.numeCTXT);
            this.Controls.Add(this.passCreate);
            this.Controls.Add(this.prenumeCreate);
            this.Controls.Add(this.numeCreate);
            this.Controls.Add(this.emailCreate);
            this.Name = "CreareContFreeBook";
            this.Text = "Creare Cont FreeBook";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox emailCreate;
        private System.Windows.Forms.TextBox numeCreate;
        private System.Windows.Forms.TextBox prenumeCreate;
        private System.Windows.Forms.TextBox passCreate;
        private System.Windows.Forms.Label numeCTXT;
        private System.Windows.Forms.Label prenumeCTXT;
        private System.Windows.Forms.Label emailCTXT;
        private System.Windows.Forms.Label passCTXT;
        private System.Windows.Forms.TextBox conpassCreate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button InregCreate;
    }
}