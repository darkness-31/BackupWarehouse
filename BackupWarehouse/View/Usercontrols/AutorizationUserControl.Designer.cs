using System.ComponentModel;

namespace BackupWarehouse.View.Usercontrols
{
    partial class AutorizationUserControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ButtonAutorization = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TextBoxAutorizationPassword = new System.Windows.Forms.TextBox();
            this.TextBoxAutorizationLogin = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ButtonRegistration = new System.Windows.Forms.Button();
            this.TextBoxRegistrationPasswordAgain = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TextBoxRegistrationPassword = new System.Windows.Forms.TextBox();
            this.TextBoxRegistrationLogin = new System.Windows.Forms.TextBox();
            this.LinkLabelLosePassword = new System.Windows.Forms.LinkLabel();
            this.TextBoxName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.ButtonAutorization);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.TextBoxAutorizationPassword);
            this.groupBox1.Controls.Add(this.TextBoxAutorizationLogin);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(155, 150);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Авторизация";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(15, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Пароль";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ButtonAutorization
            // 
            this.ButtonAutorization.Location = new System.Drawing.Point(42, 112);
            this.ButtonAutorization.Name = "ButtonAutorization";
            this.ButtonAutorization.Size = new System.Drawing.Size(75, 23);
            this.ButtonAutorization.TabIndex = 1;
            this.ButtonAutorization.Text = "Войти";
            this.ButtonAutorization.UseVisualStyleBackColor = true;
            this.ButtonAutorization.Click += new System.EventHandler(this.ButtonAutorization_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(15, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Логин";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TextBoxAutorizationPassword
            // 
            this.TextBoxAutorizationPassword.Location = new System.Drawing.Point(15, 86);
            this.TextBoxAutorizationPassword.Name = "TextBoxAutorizationPassword";
            this.TextBoxAutorizationPassword.Size = new System.Drawing.Size(129, 20);
            this.TextBoxAutorizationPassword.TabIndex = 0;
            // 
            // TextBoxAutorizationLogin
            // 
            this.TextBoxAutorizationLogin.Location = new System.Drawing.Point(15, 44);
            this.TextBoxAutorizationLogin.Name = "TextBoxAutorizationLogin";
            this.TextBoxAutorizationLogin.Size = new System.Drawing.Size(129, 20);
            this.TextBoxAutorizationLogin.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ButtonRegistration);
            this.groupBox2.Controls.Add(this.TextBoxRegistrationPasswordAgain);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.TextBoxRegistrationPassword);
            this.groupBox2.Controls.Add(this.TextBoxName);
            this.groupBox2.Controls.Add(this.TextBoxRegistrationLogin);
            this.groupBox2.Location = new System.Drawing.Point(164, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(155, 245);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Регистрация";
            // 
            // ButtonRegistration
            // 
            this.ButtonRegistration.Location = new System.Drawing.Point(15, 197);
            this.ButtonRegistration.Name = "ButtonRegistration";
            this.ButtonRegistration.Size = new System.Drawing.Size(129, 23);
            this.ButtonRegistration.TabIndex = 1;
            this.ButtonRegistration.Text = "Зарегистрироваться";
            this.ButtonRegistration.UseVisualStyleBackColor = true;
            this.ButtonRegistration.Click += new System.EventHandler(this.ButtonRegistration_Click);
            // 
            // TextBoxRegistrationPasswordAgain
            // 
            this.TextBoxRegistrationPasswordAgain.Location = new System.Drawing.Point(15, 171);
            this.TextBoxRegistrationPasswordAgain.Name = "TextBoxRegistrationPasswordAgain";
            this.TextBoxRegistrationPasswordAgain.Size = new System.Drawing.Size(129, 20);
            this.TextBoxRegistrationPasswordAgain.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(15, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 15);
            this.label5.TabIndex = 2;
            this.label5.Text = "Повторить пароль";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(15, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "Пароль";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(15, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Логин";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TextBoxRegistrationPassword
            // 
            this.TextBoxRegistrationPassword.Location = new System.Drawing.Point(15, 129);
            this.TextBoxRegistrationPassword.Name = "TextBoxRegistrationPassword";
            this.TextBoxRegistrationPassword.Size = new System.Drawing.Size(129, 20);
            this.TextBoxRegistrationPassword.TabIndex = 0;
            // 
            // TextBoxRegistrationLogin
            // 
            this.TextBoxRegistrationLogin.Location = new System.Drawing.Point(15, 88);
            this.TextBoxRegistrationLogin.Name = "TextBoxRegistrationLogin";
            this.TextBoxRegistrationLogin.Size = new System.Drawing.Size(129, 20);
            this.TextBoxRegistrationLogin.TabIndex = 0;
            // 
            // LinkLabelLosePassword
            // 
            this.LinkLabelLosePassword.Location = new System.Drawing.Point(18, 155);
            this.LinkLabelLosePassword.Name = "LinkLabelLosePassword";
            this.LinkLabelLosePassword.Size = new System.Drawing.Size(140, 23);
            this.LinkLabelLosePassword.TabIndex = 1;
            this.LinkLabelLosePassword.TabStop = true;
            this.LinkLabelLosePassword.Text = "Забыли пароль?";
            this.LinkLabelLosePassword.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.LinkLabelLosePassword.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabelLosePassword_LinkClicked);
            // 
            // TextBoxName
            // 
            this.TextBoxName.Location = new System.Drawing.Point(15, 44);
            this.TextBoxName.Name = "TextBoxName";
            this.TextBoxName.Size = new System.Drawing.Size(129, 20);
            this.TextBoxName.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(15, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 15);
            this.label6.TabIndex = 2;
            this.label6.Text = "ФИО";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AutorizationUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.LinkLabelLosePassword);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "AutorizationUserControl";
            this.Size = new System.Drawing.Size(324, 232);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.LinkLabel LinkLabelLosePassword;

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TextBoxAutorizationLogin;
        private System.Windows.Forms.TextBox TextBoxAutorizationPassword;
        private System.Windows.Forms.Button ButtonAutorization;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button ButtonRegistration;
        private System.Windows.Forms.TextBox TextBoxRegistrationPasswordAgain;
        private System.Windows.Forms.TextBox TextBoxRegistrationLogin;
        private System.Windows.Forms.TextBox TextBoxRegistrationPassword;

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TextBoxName;
    }
}