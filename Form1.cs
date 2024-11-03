namespace ComputerFirmProject_.NET_6._0_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ComputerFirmDb computerFirmDb = new ComputerFirmDb();
        }

        private void BuyComputerComponents_button_Click(object sender, EventArgs e)
        {
            BuyComponentsToDBForm buyComponentsToDBForm = new BuyComponentsToDBForm();
            buyComponentsToDBForm.Show();
        }

        private void Admin_button_Click(object sender, EventArgs e)
        {

            //AdminForm adminForm = new AdminForm();
            //adminForm.Show();
            CheckLoginAndPassword();
        }

        private void CallBrigade_button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Вы вызвали бригаду на дом.Ожидайте звонка для дальнейшего уточнения подробностей");
        }

        private void CheckLoginAndPassword()
        {
            AuthorizationForm authForm = new AuthorizationForm();
            authForm.Show();
        }

        private void Service_button_Click(object sender, EventArgs e)
        {
            /*При нажатии на "Сервисный отдел" клиент получает сообщение,что его техника сдана и через какое-то количество секунд(условно 5) должно будет
                выскочить окно, которое с каким-то шансом выдаст удачный вариант или нет.
                Для этого юзать Random.range(0,10). Если выпадет чётное число- ремонт успешен.
                Иначе, если выпадет нечётное,то техника не подлежит ремонту.*/
        }
    }
}
