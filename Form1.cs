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
            MessageBox.Show("�� ������� ������� �� ���.�������� ������ ��� ����������� ��������� ������������");
        }

        private void CheckLoginAndPassword()
        {
            AuthorizationForm authForm = new AuthorizationForm();
            authForm.Show();
        }

        private void Service_button_Click(object sender, EventArgs e)
        {
            /*��� ������� �� "��������� �����" ������ �������� ���������,��� ��� ������� ����� � ����� �����-�� ���������� ������(������� 5) ������ �����
                ��������� ����, ������� � �����-�� ������ ������ ������� ������� ��� ���.
                ��� ����� ����� Random.range(0,10). ���� ������� ������ �����- ������ �������.
                �����, ���� ������� ��������,�� ������� �� �������� �������.*/
        }
    }
}
