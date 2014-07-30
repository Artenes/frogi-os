using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FirebirdSql.Data.FirebirdClient;

namespace FROGI_OS
{
    public partial class formServicoPesquisa : Form {

        private GerServico servicoAtual;


        public formServicoPesquisa() {
            InitializeComponent();
            servicoAtual = new GerServico();
            pesquisar();
        }

        private void pesquisar() {
            tabPai.SelectedTab = tabPesquisa;
            controles(true, false, false, false, false);
            campos(false);
            dsFROGIOS.SERVICO.Clear();
            dsFROGIOS.TIPO.Clear();
            labelCodigo.Visible = false;
            labelCodigoLabel.Visible = false;
            this.ActiveControl = comboCampoPesquisa;
        }

        private void pictureFechar_Click(object sender, EventArgs e) {
            Close();
        }

        private void controles(bool novo, bool editar, bool excluir, bool salvar, bool pesquisar) {
            pictureNovo.Visible = novo;
            pictureEditar.Visible = editar;
            pictureExcluir.Visible = excluir;
            pictureSalvar.Visible = salvar;
            picturePesquisar.Visible = pesquisar;
        }

        private void campos(bool estaDisponivel) {
            textDesc.Enabled = estaDisponivel;
            textValor.Enabled = estaDisponivel;
            buttonAdicionar.Enabled = estaDisponivel;
            buttonNovoTipo.Enabled = estaDisponivel;
            dgvTipo.Enabled = estaDisponivel;
        }

        private void comboCampoPesquisa_SelectedIndexChanged(object sender, EventArgs e) {
            textCampoPesquisa.Enabled = true;
            buttonPesquisar.Enabled = true;
        }

        private void buttonPesquisar_Click(object sender, EventArgs e) {
            dsFROGIOS.SERVICO.Clear();
            dsFROGIOS.TIPO.Clear();
            string coluna = comboCampoPesquisa.SelectedItem.ToString();
            string valor = textCampoPesquisa.Text;
            try {
                //TblServico.selecionar(dsFROGIOS.SERVICO, coluna, valor);
                ActiveControl = gvServico;
            } catch (Exception erro) {
                formDialogo dialogo = new formDialogo("Essa não! Tivemos um pequeno problema", erro.Message, formDialogo.TipoExpressao.AvisoTriste);
                dialogo.ShowDialog();
                dialogo.Dispose();
            }
        }

        private void visualizarServico() {
            int indiceLinha = gvServico.SelectedCells[0].RowIndex;
            //servicoAtual.compactar((dsFROGIOS.SERVICORow)dsFROGIOS.SERVICO.Rows[indiceLinha],dsFROGIOS.TIPO);
            tabPai.SelectedTab = tabServ;
            labelCodigoLabel.Visible = true;
            labelCodigo.Visible = true;
            controles(false, true, true, false, true);
            ActiveControl = textDesc;
        }

        private void gvServico_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
            visualizarServico();
        }

        private void gvServico_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                visualizarServico();
                e.SuppressKeyPress = true;
            }
        }

        private void novoRegistro() {
            formDialogo dialogo = new formDialogo("Quer cadastrar um novo serviço?", "", formDialogo.TipoExpressao.Pergunta);
            DialogResult resultado = dialogo.ShowDialog();
            dialogo.Dispose();
            if (resultado == System.Windows.Forms.DialogResult.No) {
                return;
            }
            dsFROGIOS.SERVICO.Clear();
            tabPai.SelectedTab = tabServ;
            controles(false, false, false, true, true);
            campos(true);
            labelCodigoLabel.Visible = false;
            labelCodigo.Visible = false;
            ActiveControl = textDesc;
        }
        private void editarRegistro() {
            campos(true);
            controles(false, false, false, true, true);
            ActiveControl = textDesc;
        }
        private void excluirRegistro() {
            formDialogo dialogo;
            dialogo = new formDialogo("Tem certeza que quer excluir este serviço?", "Não vai dar pra recuperar este depois!", formDialogo.TipoExpressao.Pergunta);
            DialogResult resultado = dialogo.ShowDialog();
            dialogo.Dispose();
            if (resultado == System.Windows.Forms.DialogResult.No) {
                return;
            }
            try {
                //servicoAtual.deletar();
                dialogo = new formDialogo("Serviço excluido com sucesso", "Vai fazer falta...", formDialogo.TipoExpressao.AvisoTriste);
                dialogo.ShowDialog();
                dialogo.Dispose();
            } catch (Exception erro) {
                dialogo = new formDialogo("Essa não! Tivemos um pequeno problema", erro.Message, formDialogo.TipoExpressao.AvisoTriste);
            }
            pesquisar();
        }
        private void salvarRegistro() {
            formDialogo dialogo;

            string validacao = validarCampos();
            if (validacao != "") {
                dialogo = new formDialogo(validacao, "", formDialogo.TipoExpressao.AvisoTriste);
                dialogo.ShowDialog();
                dialogo.Dispose();
                return;
            }

            dialogo = new formDialogo("Quer salvar as informações deste serviço?", "", formDialogo.TipoExpressao.Pergunta);
            DialogResult resultado = dialogo.ShowDialog();
            dialogo.Dispose();
            if (resultado == System.Windows.Forms.DialogResult.No) {
                return;
            }

            dsFROGIOS.TIPO.AcceptChanges();
            if (true) {
                try {
                    //servicoAtual.inserir(
                    //textDesc.Text,
                    //Convert.ToDecimal(textValor.Text),
                    //servicoAtual.compactar(dsFROGIOS.TIPO)
                    //);
                    pesquisar();
                } catch (Exception erro) {
                    dialogo = new formDialogo("Essa não! Tivemos um pequeno problema", erro.Message, formDialogo.TipoExpressao.AvisoTriste);
                    dialogo.ShowDialog();
                    dialogo.Dispose();   
                }
                
            } else {
                try {
                    //servicoAtual.atualizar(
                    //textDesc.Text,
                    //Convert.ToDecimal(textValor.Text),
                    //dsFROGIOS.TIPO
                    //);
                    pesquisar();
                } catch (Exception erro) {
                    dialogo = new formDialogo("Essa não! Tivemos um pequeno problema", erro.Message, formDialogo.TipoExpressao.AvisoTriste);
                    dialogo.ShowDialog();
                    dialogo.Dispose();
                }
                
            }
        }

        private void adicionarTipo() {
            tabPai.SelectedTab = tabTipoServico;
            ActiveControl = dgvTipoPesquisa;
            if (dsTipoPesquisa.TIPO.Rows.Count <= 0) {
                taTipo.Fill(dsTipoPesquisa.TIPO);
            }
        }


        private void tabPai_KeyDown(object sender, KeyEventArgs e) {
            if ((e.Control && e.KeyCode == Keys.N) && (pictureNovo.Visible)) {
                novoRegistro();
            } else if ((e.Control && e.KeyCode == Keys.E) && pictureEditar.Visible) {
                editarRegistro();
            } else if ((e.Control && e.KeyCode == Keys.D) && pictureExcluir.Visible) {
                excluirRegistro();
            } else if ((e.Control && e.KeyCode == Keys.S) && pictureSalvar.Visible) {
                salvarRegistro();
            } else if ((e.Control && e.KeyCode == Keys.P) && picturePesquisar.Visible) {
                formDialogo dialogo = new formDialogo("Deseja pesquisar outro serviço?", "O que não foi salvo será perdido!", formDialogo.TipoExpressao.Pergunta);
                DialogResult resultado = dialogo.ShowDialog();
                if (resultado == System.Windows.Forms.DialogResult.Yes) {
                    pesquisar();
                }
            }
        }

        private void buttonPesquisarTipo_Click(object sender, EventArgs e) {
            bsTipoPesquisa.Filter = "TIPO_DESCRICAO LIKE '%"+textTipoDescricao.Text+"%'";
        }

        private void buttonVoltar_Click(object sender, EventArgs e) {
            tabPai.SelectedTab = tabServ;
        }

        private void pictureNovo_Click(object sender, EventArgs e) {
            novoRegistro();
        }

        private void pictureEditar_Click(object sender, EventArgs e) {
            editarRegistro();
        }

        private void pictureExcluir_Click(object sender, EventArgs e) {
            excluirRegistro();
        }

        private void pictureSalvar_Click(object sender, EventArgs e) {
            salvarRegistro();
        }

        private void picturePesquisar_Click(object sender, EventArgs e) {
            formDialogo dialogo = new formDialogo("Deseja pesquisar outro serviço?", "O que não foi salvo será perdido!", formDialogo.TipoExpressao.Pergunta);
            DialogResult resultado = dialogo.ShowDialog();
            if (resultado == System.Windows.Forms.DialogResult.Yes) {
                pesquisar();
            }
        }

        private string validarCampos() {
            return "";
        }

        private void buttonAdicionar_Click(object sender, EventArgs e) {
            adicionarTipo();
        }

        private void dgvTipoPesquisa_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
            transferirTipo();
        }

        private void transferirTipo() {
            int indiceLinha = dgvTipoPesquisa.SelectedCells[0].RowIndex;
            try {
                dsFROGIOS.TIPO.ImportRow((dsFROGIOS.TIPORow)dsTipoPesquisa.TIPO.Rows[indiceLinha]);
                tabPai.SelectedTab = tabServ;
            } catch (ConstraintException) {
                formDialogo dialogo = new formDialogo("Você já escolheu este tipo", "Escolha outro tipo", formDialogo.TipoExpressao.AvisoFeliz);
                dialogo.ShowDialog();
                dialogo.Dispose();
            }
        }

        private void dgvTipoPesquisa_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                transferirTipo();
                e.SuppressKeyPress = true;
            }
        }

       

    }
}
