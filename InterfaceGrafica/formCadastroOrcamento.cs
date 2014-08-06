using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FROGI_OS.InterfaceGrafica
{
    public partial class formCadastroOrcamento : formOSBaseCadastro
    {
        public formCadastroOrcamento() : base ()
        {
            InitializeComponent();
            
        }

        public override void salvar()
        {
            base.salvar();
        }

        public override void preencher(int codigo)
        {
            base.preencher(codigo);
        }
        
    }
}
