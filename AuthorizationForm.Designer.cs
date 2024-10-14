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
            SuspendLayout();
            // 
            // EnterInAccount_button
            // 
            EnterInAccount_button.Location = new Point(167, 296);
            EnterInAccount_button.Name = "EnterInAccount_button";
            EnterInAccount_button.Size = new Size(75, 23);
            EnterInAccount_button.TabIndex = 0;
            EnterInAccount_button.Text = "Войти";
            EnterInAccount_button.UseVisualStyleBackColor = true;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(167, 337);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(83, 15);
            linkLabel1.TabIndex = 2;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Нет аккаунта?";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // AuthorizationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(407, 412);
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
    }
}