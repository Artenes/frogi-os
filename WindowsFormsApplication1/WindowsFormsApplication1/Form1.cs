using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tIPOBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tIPOBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.SERVICO_TIPO' table. You can move, or remove it, as needed.
            this.sERVICO_TIPOTableAdapter.Fill(this.dataSet1.SERVICO_TIPO);
            // TODO: This line of code loads data into the 'dataSet1.TIPO' table. You can move, or remove it, as needed.
            //this.tIPOTableAdapter.Fill(this.dataSet1.TIPO);
            DataSet1.SERVICO_TIPORow row = (DataSet1.SERVICO_TIPORow) dataSet1.SERVICO_TIPO.Rows[0];
            Debug.WriteLine("TESTE de inserção: " + row.TIPORow.TIPO_DESCRICAO);
        }
    }
}
