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
    public partial class AuthorizationForm : Form
    {
        public AuthorizationForm()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegisterNewAccountForm registerNewAccountForm = new RegisterNewAccountForm();
            registerNewAccountForm.Show();
        }

        private void EnterInAccount_button_Click(object sender, EventArgs e)
        {
            if(EnterTheLoginToEnterInAccount_textBox.Text == "admin" && EnterThePasswordToEnterInAccount_textBox.Text == "admin")
            {
                AdminForm adminForm = new AdminForm();
                adminForm.Show();
            }
            //else if() Сделать проверку на логин из базы данных
        }
    }
}
