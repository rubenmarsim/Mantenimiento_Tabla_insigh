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
        }

        private void RellenarDataGrid(DataSet dataset)
        {

            dgvMant_table.DataSource = dataset.Tables[0];
            BindDades();
        }

        private void BindDades()
        {
            string[] columNames = new string[dts.Tables[0].Columns.Count];
            int i = 0;
            foreach (DataColumn column in dts.Tables[0].Columns)
            {
                columNames[i] = column.ColumnName;
                i++;
            }

            i = 3;
            foreach (Control control in this.Controls)
            {
                if (control is SdsTextBox)
                {
                    ((SdsTextBox)control).DataBindings.Clear();
                    ((SdsTextBox)control).DataBindings.Add("Text", dts.Tables[0], ((SdsTextBox)control).ColumnName.ToString());
                    ((SdsTextBox)control).Validated += new EventHandler(validar);
                    i--;
                }
                dgvMant_table.DataSource = dts.Tables[0];
            }
        }
        private void validar(object sender, EventArgs e)
        {
            ((TextBox)sender).DataBindings[0].BindingManagerBase.EndCurrentEdit();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            CDB.Actualitzar(dts, "select * from UserTypes");
        }
    }
}
