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
    public partial class frmMant_Table : Form
    {
        DataSet dts;
        SdsTextBox CSDStxtBox;
        ClassDB CDB;
        public frmMant_Table()
        {
            InitializeComponent();
            Inicializaciones();
        }
        private bool EsNou = false;

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
            foreach (Control sdsControl in this.Controls)
            {
                if (sdsControl is SdsTextBox)
                {
                    ((SdsTextBox)sdsControl).DataBindings.Clear();
                    ((SdsTextBox)sdsControl).DataBindings.Add("Text", dts.Tables[0], ((SdsTextBox)sdsControl).ColumnName.ToString());
                    ((SdsTextBox)sdsControl).Validated += new EventHandler(validar);
                }
                dgvMant_table.DataSource = dts.Tables[0];
            }
        }
        private void QuitarBindDades()
        {
            foreach (Control sdsControl in this.Controls)
            {
                if (sdsControl is SdsTextBox)
                {
                    ((SdsTextBox)sdsControl).DataBindings.Clear();
                    sdsControl.Text = "";
                        
                }
            }
        }
        private void AñadirFila()
        {

            
            DataTable dt = dts.Tables[0];
            DataRow dr = dt.NewRow();
            dt.Rows.Add();
            dt.AcceptChanges();

        }
        private void validar(object sender, EventArgs e)
        {
            ((TextBox)sender).DataBindings[0].BindingManagerBase.EndCurrentEdit();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if(!EsNou)
            {
                CDB.Actualitzar(dts, "select * from UserTypes");
            
            }
            else
            {

            }
            
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            QuitarBindDades();
            EsNou = true;
            //AñadirFila();
            //BindDades();
            //var dg_r = dgvMant_table.Rows.Count;

        }
    }
}
