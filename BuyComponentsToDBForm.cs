using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComputerFirmProject_.NET_6._0_
{
    public partial class BuyComponentsToDBForm : Form
    {
        ComputerFirmDb computerFirmDb = new ComputerFirmDb();
        public BuyComponentsToDBForm()
        {
            InitializeComponent();
            
            AutoCompleteStringCollection sourceType = new AutoCompleteStringCollection()
            {
                "Процессор",
                "ОЗУ",
                "Видеокарта"
            };
            EnterTypeOfComponentToBuy_textBox.AutoCompleteCustomSource = sourceType;
            EnterTypeOfComponentToBuy_textBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            EnterTypeOfComponentToBuy_textBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        private void BuyComponent_button_Click(object sender, EventArgs e)
        {
           // computerFirmDb.AddComputerComponentToDB(string price)
          /* Здесь надо сделать компонент со списком,который будет находить компоненты из базы данных и выдавать их в виде выпадающего списка.
                Эти компоненты можно будет выбрать и заказать.*/
        }
    }
}
