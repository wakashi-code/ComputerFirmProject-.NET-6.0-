namespace ComputerFirmProject_.NET_6._0_
{
    partial class BuyComponentsToDBForm
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
            NameOfComponent_label = new Label();
            EnterComponentNameToBuy_textBox = new TextBox();
            label1 = new Label();
            EnterTypeOfComponentToBuy_textBox = new TextBox();
            BuyComponent_button = new Button();
            SuspendLayout();
            // 
            // NameOfComponent_label
            // 
            NameOfComponent_label.AutoSize = true;
            NameOfComponent_label.Location = new Point(12, 79);
            NameOfComponent_label.Name = "NameOfComponent_label";
            NameOfComponent_label.Size = new Size(413, 15);
            NameOfComponent_label.TabIndex = 0;
            NameOfComponent_label.Text = "Сделать здесь огромный выпадающик список с компонентами на выбор";
            // 
            // EnterComponentNameToBuy_textBox
            // 
            EnterComponentNameToBuy_textBox.Location = new Point(12, 97);
            EnterComponentNameToBuy_textBox.Name = "EnterComponentNameToBuy_textBox";
            EnterComponentNameToBuy_textBox.Size = new Size(191, 23);
            EnterComponentNameToBuy_textBox.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 143);
            label1.Name = "label1";
            label1.Size = new Size(128, 15);
            label1.TabIndex = 2;
            label1.Text = "Тип комплектующего";
            // 
            // EnterTypeOfComponentToBuy_textBox
            // 
            EnterTypeOfComponentToBuy_textBox.Location = new Point(14, 161);
            EnterTypeOfComponentToBuy_textBox.Name = "EnterTypeOfComponentToBuy_textBox";
            EnterTypeOfComponentToBuy_textBox.Size = new Size(189, 23);
            EnterTypeOfComponentToBuy_textBox.TabIndex = 3;
            // 
            // BuyComponent_button
            // 
            BuyComponent_button.Location = new Point(128, 250);
            BuyComponent_button.Name = "BuyComponent_button";
            BuyComponent_button.Size = new Size(75, 23);
            BuyComponent_button.TabIndex = 4;
            BuyComponent_button.Text = "Закупить";
            BuyComponent_button.UseVisualStyleBackColor = true;
            BuyComponent_button.Click += BuyComponent_button_Click;
            // 
            // BuyComponentsToDBForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(470, 450);
            Controls.Add(BuyComponent_button);
            Controls.Add(EnterTypeOfComponentToBuy_textBox);
            Controls.Add(label1);
            Controls.Add(EnterComponentNameToBuy_textBox);
            Controls.Add(NameOfComponent_label);
            Name = "BuyComponentsToDBForm";
            Text = "Закупка компонента";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label NameOfComponent_label;
        private TextBox EnterComponentNameToBuy_textBox;
        private Label label1;
        private TextBox EnterTypeOfComponentToBuy_textBox;
        private Button BuyComponent_button;
    }
}