using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Drawing;
using System.Transactions;

namespace InventarioP1
{
    public partial class Form1 : Form
    {
        private DataGridView dgvInventario = new DataGridView();
        private DataGridView dgvResponsable = new DataGridView();
        private BindingSource bsInventario = new BindingSource();
        private BindingSource bsResponsable = new BindingSource();
        public Form1()
        {
            InitializeComponent();

            dgvInventario.Dock = DockStyle.Fill;
            //this.Controls.Add(dgvInventario);
            panelInv.Controls.Add(dgvInventario);
            panelResp.Controls.Add(dgvResponsable);
            ActualizarVentanaInventario();
            ActualizarVentanaResponsable();

        }
        private void ActualizarVentanaInventario()
        {
            //Actualizar Tablas
            bsInventario.DataSource = ObtenerDatos("Select * from dbo.INVENTARIO");
            MostrarTabla(dgvInventario, bsInventario);

            //Actualizar campos
            tbDescrip.Text = "";
            tbMarca.Text = "";
            tbModelo.Text = "";
            tbSerie.Text = "";
            dtIngreso.Value = DateTime.Now;
            cbResponsable.Text = "STOCK";
            tbCodigo.Text = "";
            cbEstatus.Text = "ACTIVO";
            tbNotas.Text = "";
        }
        private void ActualizarVentanaResponsable()
        {
            //Actualizar Tablas
            bsResponsable.DataSource = ObtenerDatos("Select * from dbo.RESPONSABLE");
            MostrarTabla(dgvResponsable, bsResponsable);

            //Actualizar campos
            tbNombre.Text = "";
            tbArea.Text = "";
            cbREstatus.Text = "ACTIVO";
        }

        private void MostrarTabla(DataGridView gvTabla, BindingSource bsTabla)
        {
            try
            {
                gvTabla.Dock = DockStyle.Fill;
                gvTabla.AutoGenerateColumns = true;
                //Inicializar DataSource
                //bsInventario.DataSource = ObtenerDatos("Select * from dbo.INVENTARIO");
                gvTabla.DataSource = bsTabla;

                gvTabla.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
                gvTabla.BorderStyle = BorderStyle.Fixed3D;

                //gvTabla.EditMode = DataGridViewEditMode.EditOnEnter;
            }
            catch (SqlException exSQL)
            {
                MessageBox.Show("Error en consulta o conexión", "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                //Thread.CurrentThread.Abort();
            }
        }
        private static DataTable ObtenerDatos(string sqlCommand)
        {
            SqlConnection conexion = DbCon.ObtenerConexion();
            SqlCommand cmdInv = new SqlCommand(sqlCommand, conexion);
            SqlDataAdapter daInv = new SqlDataAdapter();
            daInv.SelectCommand = cmdInv;

            DataTable dtInv = new DataTable();
            dtInv.Locale = System.Globalization.CultureInfo.InvariantCulture;
            daInv.Fill(dtInv);

            return dtInv;
        }

        private void GenerarCodigo()
        {
            string vCodigo = "";
            vCodigo = vCodigo + tbDescrip.Text.Substring(0,2);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            ActualizarVentanaInventario();
        }

        private void tbRRegistrar_Click(object sender, EventArgs e)
        {
            ActualizarVentanaResponsable();
        }
        private void datos_TextChanged(object sender, EventArgs e)
        {
            if (tbDescrip.Text != "" && tbMarca.Text != "" && tbModelo.Text != "" && tbSerie.Text != "")
            {
                string vCodigo = "";
                int lSerie = tbSerie.Text.Length;
                vCodigo = vCodigo + tbDescrip.Text.Substring(0, 3)
                    + tbMarca.Text.Substring(0, 2)
                    + tbModelo.Text.Substring(0, 2)
                    + tbSerie.Text.Substring(lSerie - 2, 4);
                tbCodigo.Text = vCodigo.ToUpper();
            }
            else
            {
                tbCodigo.Text = "";
            }
        }
    }
}
