using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BSS;
using DAL;
using ENTIDADES;
namespace VISTA.IngresoForms
{
    public partial class FormIngresoAgregar : MaterialSkin.Controls.MaterialForm
    {
        public FormIngresoAgregar()
        {
            InitializeComponent();
        }
        public static int IdSleccionado = 0;
        IngresoBSS IngresoBSS=new IngresoBSS();
        ProveedorBSS ProveedorBSS=new ProveedorBSS();
        private void FormIngresoAgregar_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = IngresoBSS.ListarIngresos();
        }

        private void materialRaisedButton3_Click(object sender, EventArgs e)
        {
            ProveedorForms.FormProveedorListar frm = new ProveedorForms.FormProveedorListar();
            if(frm.ShowDialog() == DialogResult.OK)
            {
                /*string query= "select * from proveedor where IDPROVEEDOR=" + IdSleccionado + "";*/
                DataTable resultado = ProveedorBSS.ListarProveedorSeleccionado(IdSleccionado);
                string nombreProv=resultado.Rows[0]["Nombre"].ToString();
                txtProveedor.Text = nombreProv;
            }
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            
            Ingreso i=new Ingreso();
            i.Fecha = txtFecha.Text;
            i.Total = txtTotal.Text;
            i.idProveedor = IdSleccionado.ToString();
            i.Estado = "activo";

            IngresoBSS.InsertarIngreso(i);
            MessageBox.Show("Agregado con exito!");
            
        }
    }
}
