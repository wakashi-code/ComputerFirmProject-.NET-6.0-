namespace ComputerFirmProject_.NET_6._0_
{
    partial class AuthorizationForm
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
            EnterInAccount_button = new Button();
            linkLabel1 = new LinkLabel();
            EnterTheLoginToEnterInAccount_textBox = new TextBox();
            EnterThePasswordToEnterInAccount_textBox = new TextBox();
            LoginEnter_label = new Label();
            EnterPassword_label = new Label();
            SuspendLayout();
            // 
            // EnterInAccount_button
            // 
            EnterInAccount_button.Location = new Point(135, 263);
            EnterInAccount_button.Name = "EnterInAccount_button";
            EnterInAccount_button.Size = new Size(75, 23);
            EnterInAccount_button.TabIndex = 0;
            EnterInAccount_button.Text = "Войти";
            EnterInAccount_button.UseVisualStyleBackColor = true;
            EnterInAccount_button.Click += EnterInAccount_button_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(135, 334);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(83, 15);
            linkLabel1.TabIndex = 2;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Нет аккаунта?";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // EnterTheLoginToEnterInAccount_textBox
            // 
            EnterTheLoginToEnterInAccount_textBox.Location = new Point(82, 129);
            EnterTheLoginToEnterInAccount_textBox.Name = "EnterTheLoginToEnterInAccount_textBox";
            EnterTheLoginToEnterInAccount_textBox.Size = new Size(168, 23);
            EnterTheLoginToEnterInAccount_textBox.TabIndex = 3;
            // 
            // EnterThePasswordToEnterInAccount_textBox
            // 
            EnterThePasswordToEnterInAccount_textBox.Location = new Point(82, 198);
            EnterThePasswordToEnterInAccount_textBox.Name = "EnterThePasswordToEnterInAccount_textBox";
            EnterThePasswordToEnterInAccount_textBox.Size = new Size(168, 23);
            EnterThePasswordToEnterInAccount_textBox.TabIndex = 4;
            // 
            // LoginEnter_label
            // 
            LoginEnter_label.AutoSize = true;
            LoginEnter_label.Location = new Point(82, 111);
            LoginEnter_label.Name = "LoginEnter_label";
            LoginEnter_label.Size = new Size(41, 15);
            LoginEnter_label.TabIndex = 5;
            LoginEnter_label.Text = "Логин";
            // 
            // EnterPassword_label
            // 
            EnterPassword_label.AutoSize = true;
            EnterPassword_label.Location = new Point(82, 180);
            EnterPassword_label.Name = "EnterPassword_label";
            EnterPassword_label.Size = new Size(49, 15);
            EnterPassword_label.TabIndex = 6;
            EnterPassword_label.Text = "Пароль";
            // 
            // AuthorizationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(352, 412);
            Controls.Add(EnterPassword_label);
            Controls.Add(LoginEnter_label);
            Controls.Add(EnterThePasswordToEnterInAccount_textBox);
            Controls.Add(EnterTheLoginToEnterInAccount_textBox);
            Controls.Add(linkLabel1);
            Controls.Add(EnterInAccount_button);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "AuthorizationForm";
            Text = "Авторизация";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button EnterInAccount_button;
        private LinkLabel linkLabel1;
        private TextBox EnterTheLoginToEnterInAccount_textBox;
        private TextBox EnterThePasswordToEnterInAccount_textBox;
        private Label LoginEnter_label;
        private Label EnterPassword_label;
    }
}