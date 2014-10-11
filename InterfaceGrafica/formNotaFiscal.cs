using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace FROGI_OS.InterfaceGrafica
{
    public partial class formNotaFiscal : Form
    {
        public formNotaFiscal()
        {
            InitializeComponent();
        }

        private void pictureFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSelecionarDiretorio_Click(object sender, EventArgs e) {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK) {
                textDiretorio.Text = fbd.SelectedPath;
                listarDiretorio(treePastas, fbd.SelectedPath);
            }
                
        }

        private void listarDiretorio(TreeView treeView, string diretorio) {
            treeView.Nodes.Clear();
            DirectoryInfo raiz = new DirectoryInfo(diretorio);
            treeView.Nodes.Add(criarNo(raiz));
        }

        private TreeNode criarNo(DirectoryInfo info) {
            TreeNode no = new TreeNode(info.Name);
            foreach (DirectoryInfo diretorio in info.GetDirectories())
                no.Nodes.Add(criarNo(diretorio));
            foreach (FileInfo arquivo in info.GetFiles())
                no.Nodes.Add(new TreeNode(arquivo.Name));
            return no;
        }

    }
}
