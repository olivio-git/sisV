using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using BSS;
using VISTA;
namespace VISTA.ProveedorForms
{
    public partial class FormProveedorListar : MaterialSkin.Controls.MaterialForm
    {
        public FormProveedorListar()
        {
            InitializeComponent();
        }
        ProveedorBSS proveedorBSS=new ProveedorBSS();
        private void FormProveedorListar_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = proveedorBSS.ListarProveedor();
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count != 0)
            {
                int FilaId = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                IngresoForms.FormIngresoAgregar.IdSleccionado= FilaId;
            }
            else
            {
                MessageBox.Show("No hay filas");
            }

        }
    }
}
