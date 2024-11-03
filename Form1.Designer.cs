namespace ComputerFirmProject_.NET_6._0_
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Admin_button = new Button();
            BuyComputerComponents_button = new Button();
            Service_button = new Button();
            CallBrigade_button = new Button();
            SuspendLayout();
            // 
            // Admin_button
            // 
            Admin_button.Location = new Point(50, 388);
            Admin_button.Name = "Admin_button";
            Admin_button.Size = new Size(75, 23);
            Admin_button.TabIndex = 0;
            Admin_button.Text = "Админка";
            Admin_button.UseVisualStyleBackColor = true;
            Admin_button.Click += Admin_button_Click;
            // 
            // BuyComputerComponents_button
            // 
            BuyComputerComponents_button.Location = new Point(229, 205);
            BuyComputerComponents_button.Name = "BuyComputerComponents_button";
            BuyComputerComponents_button.Size = new Size(206, 27);
            BuyComputerComponents_button.TabIndex = 1;
            BuyComputerComponents_button.Text = "Приобрести комплектующие";
            BuyComputerComponents_button.UseVisualStyleBackColor = true;
            BuyComputerComponents_button.Click += BuyComputerComponents_button_Click;
            // 
            // Service_button
            // 
            Service_button.Location = new Point(229, 254);
            Service_button.Name = "Service_button";
            Service_button.Size = new Size(206, 23);
            Service_button.TabIndex = 2;
            Service_button.Text = "Сервисный отдел";
            Service_button.UseVisualStyleBackColor = true;
            Service_button.Click += Service_button_Click;
            // 
            // CallBrigade_button
            // 
            CallBrigade_button.Location = new Point(229, 307);
            CallBrigade_button.Name = "CallBrigade_button";
            CallBrigade_button.Size = new Size(206, 23);
            CallBrigade_button.TabIndex = 3;
            CallBrigade_button.Text = "Вызвать бригаду на дом";
            CallBrigade_button.UseVisualStyleBackColor = true;
            CallBrigade_button.Click += CallBrigade_button_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(800, 450);
            Controls.Add(CallBrigade_button);
            Controls.Add(Service_button);
            Controls.Add(BuyComputerComponents_button);
            Controls.Add(Admin_button);
            Name = "Form1";
            Text = "Главный зал";
            ResumeLayout(false);
        }

        #endregion

        private Button Admin_button;
        private Button BuyComputerComponents_button;
        private Button Service_button;
        private Button CallBrigade_button;
    }


}
