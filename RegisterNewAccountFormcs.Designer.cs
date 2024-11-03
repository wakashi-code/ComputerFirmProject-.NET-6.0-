namespace ComputerFirmProject_.NET_6._0_
{
    partial class RegisterNewAccountForm
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
            CreateNewAccount_button = new Button();
            LoginRegisterInput_label = new Label();
            InputRegisterPassword_label = new Label();
            Login_TextBox = new TextBox();
            Password_TextBox = new TextBox();
            SuspendLayout();
            // 
            // CreateNewAccount_button
            // 
            CreateNewAccount_button.Location = new Point(105, 207);
            CreateNewAccount_button.Name = "CreateNewAccount_button";
            CreateNewAccount_button.Size = new Size(126, 23);
            CreateNewAccount_button.TabIndex = 0;
            CreateNewAccount_button.Text = "Создать аккаунт";
            CreateNewAccount_button.UseVisualStyleBackColor = true;
            CreateNewAccount_button.Click += CreateNewAccount_button_Click;
            // 
            // LoginRegisterInput_label
            // 
            LoginRegisterInput_label.AutoSize = true;
            LoginRegisterInput_label.Location = new Point(12, 52);
            LoginRegisterInput_label.Name = "LoginRegisterInput_label";
            LoginRegisterInput_label.Size = new Size(41, 15);
            LoginRegisterInput_label.TabIndex = 1;
            LoginRegisterInput_label.Text = "Логин";
            // 
            // InputRegisterPassword_label
            // 
            InputRegisterPassword_label.AutoSize = true;
            InputRegisterPassword_label.Location = new Point(12, 128);
            InputRegisterPassword_label.Name = "InputRegisterPassword_label";
            InputRegisterPassword_label.Size = new Size(49, 15);
            InputRegisterPassword_label.TabIndex = 2;
            InputRegisterPassword_label.Text = "Пароль";
            // 
            // Login_TextBox
            // 
            Login_TextBox.Location = new Point(12, 70);
            Login_TextBox.Name = "Login_TextBox";
            Login_TextBox.Size = new Size(322, 23);
            Login_TextBox.TabIndex = 3;
            // 
            // Password_TextBox
            // 
            Password_TextBox.Location = new Point(12, 146);
            Password_TextBox.Name = "Password_TextBox";
            Password_TextBox.Size = new Size(322, 23);
            Password_TextBox.TabIndex = 4;
            // 
            // RegisterNewAccountForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(346, 263);
            Controls.Add(Password_TextBox);
            Controls.Add(Login_TextBox);
            Controls.Add(InputRegisterPassword_label);
            Controls.Add(LoginRegisterInput_label);
            Controls.Add(CreateNewAccount_button);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "RegisterNewAccountForm";
            Text = "Регистрация";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button CreateNewAccount_button;
        private Label LoginRegisterInput_label;
        private Label InputRegisterPassword_label;
        private TextBox Login_TextBox;
        private TextBox Password_TextBox;
    }
}