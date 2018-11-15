using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConnectionClass;


namespace MantenimientoTest
{
    public partial class Form1 : Form
    {
        DataSet dts;
        SdsTextBox CSDStxtBox;
        ClassDB CDB;
        public Form1()
        {
            InitializeComponent();
            Inicializaciones();
        }
        private void Inicializaciones()
        {
            CDB = new ClassDB();
            CSDStxtBox = new SdsTextBox();
            dts = CDB.portaPerConsulta("select * from UserTypes");
            RellenarDataGrid(dts);
            dgvMant_table.AllowUserToAddRows = false;
        }
        private void RellenarDataGrid(DataSet dataset)
        {
            dgvMant_table.DataSource = dataset.Tables[0];
            BindDades();
        }
        private void BindDades()
        {
            foreach (Control control in this.Controls)
            {
                if (control is SdsTextBox)
                {
                    ((SdsTextBox)control).DataBindings.Clear();
                    ((SdsTextBox)control).DataBindings.Add("Text", dts.Tables[0], ((SdsTextBox)control).ColumnName.ToString());
                    ((SdsTextBox)control).Validated += new EventHandler(validar);
                }
                dgvMant_table.DataSource = dts.Tables[0];
            }
        }
        private void QuitarBindDades()
        {
            foreach (Control control in this.Controls)
            {
                if (control is SdsTextBox)
                {
                    ((SdsTextBox)control).DataBindings.Clear();
                }
            }
        }
        private void AñadirFila()
        {

            
            DataTable table = dts.Tables[0];
            DataRow row = table.NewRow();


        }
        private void validar(object sender, EventArgs e)
        {
            ((TextBox)sender).DataBindings[0].BindingManagerBase.EndCurrentEdit();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            CDB.Actualitzar(dts, "select * from UserTypes");
            BindDades();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            QuitarBindDades();
            AñadirFila();
        }
    }
}
