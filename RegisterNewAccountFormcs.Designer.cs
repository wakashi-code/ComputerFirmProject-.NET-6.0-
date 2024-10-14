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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
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
            // textBox1
            // 
            textBox1.Location = new Point(12, 70);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(322, 23);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(12, 146);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(322, 23);
            textBox2.TabIndex = 4;
            // 
            // RegisterNewAccountFormcs
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(346, 263);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(InputRegisterPassword_label);
            Controls.Add(LoginRegisterInput_label);
            Controls.Add(CreateNewAccount_button);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "RegisterNewAccountFormcs";
            Text = "Регистрация";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button CreateNewAccount_button;
        private Label LoginRegisterInput_label;
        private Label InputRegisterPassword_label;
        private TextBox textBox1;
        private TextBox textBox2;
    }
}