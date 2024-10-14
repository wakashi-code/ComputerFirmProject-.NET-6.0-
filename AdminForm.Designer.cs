namespace ComputerFirmProject_.NET_6._0_
{
    partial class AdminForm
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
            AddPC_button = new Button();
            BuyComponents_button = new Button();
            button3 = new Button();
            button4 = new Button();
            SuspendLayout();
            // 
            // AddPC_button
            // 
            AddPC_button.Location = new Point(301, 140);
            AddPC_button.Name = "AddPC_button";
            AddPC_button.Size = new Size(155, 23);
            AddPC_button.TabIndex = 0;
            AddPC_button.Text = "Добавить сборку";
            AddPC_button.UseVisualStyleBackColor = true;
            // 
            // BuyComponents_button
            // 
            BuyComponents_button.Location = new Point(301, 188);
            BuyComponents_button.Name = "BuyComponents_button";
            BuyComponents_button.Size = new Size(155, 23);
            BuyComponents_button.TabIndex = 1;
            BuyComponents_button.Text = "Заказать компоненты";
            BuyComponents_button.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(301, 236);
            button3.Name = "button3";
            button3.Size = new Size(155, 41);
            button3.TabIndex = 2;
            button3.Text = "Произвести отчисление налогов";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(301, 297);
            button4.Name = "button4";
            button4.Size = new Size(155, 45);
            button4.TabIndex = 3;
            button4.Text = "Произвести отчисление налогов";
            button4.UseVisualStyleBackColor = true;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(BuyComponents_button);
            Controls.Add(AddPC_button);
            Name = "AdminForm";
            Text = "AdminForm";
            ResumeLayout(false);
        }

        #endregion

        private Button AddPC_button;
        private Button BuyComponents_button;
        private Button button3;
        private Button button4;
    }
}