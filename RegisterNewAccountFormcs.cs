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
    public partial class RegisterNewAccountForm : Form
    {
        ComputerFirmDb db;

        public RegisterNewAccountForm()
        {
            InitializeComponent();
            db = new ComputerFirmDb();
            Password_TextBox.PasswordChar = '*';
        }

        private void CreateNewAccount_button_Click(object sender, EventArgs e)
        {
            if(db.RegisterNewUserInUsersTable(Login_TextBox.Text, Password_TextBox.Text))
            {
                MessageBox.Show("Аккаунт успешно создан!\nМожете закрыть окно регистрации");
                //"Создать и показать новую форму после входа в логин или при регистрации."
            }
            
        }
    }
}
