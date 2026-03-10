namespace Домашня_робота
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnCreateAbonent_Click(object sender, EventArgs e)
        {
            AbonentCreateForm createForm = new AbonentCreateForm();
            createForm.ShowDialog();
        }
    }
}
