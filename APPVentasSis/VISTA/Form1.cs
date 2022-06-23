using BSS;
using DAL;
namespace VISTA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        PersonaBSS PersonaBSS = new PersonaBSS();
        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = PersonaBSS.ListarPersonas();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}