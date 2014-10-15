using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FROGI_OS.CamadaAcessoDados;

namespace FROGI_OS.CamadaEnlaceDados {
    class GerFuncionario {

        public void inserir(dsFROGIOS.FUNCIONARIORow funcionario) {
                TblFuncionario funcionarioSQL = new TblFuncionario();
                funcionarioSQL.inserir(funcionario);
        }

        public void atualizar(dsFROGIOS.FUNCIONARIORow funcionario) {
            TblFuncionario funcionarioSQL = new TblFuncionario();
            funcionarioSQL.atualizar(funcionario);
        }

        public void selecionar(
            int codigo, 
            dsFROGIOS.FUNCIONARIODataTable funcionario,
            dsFROGIOS.CATEGORIADataTable categoria) {

            funcionario.Clear();
            //categoria.Clear();

            TblFuncionario funcionarioSQL = new TblFuncionario();
            //TblCategoria categoriaSQL = new TblCategoria();
            funcionario.Load(
                funcionarioSQL.selecionar(
                funcionario.FUNCIONARIO_CODIGOColumn.ColumnName,
                codigo.ToString(),
                true
                )
            );

            /*dsFROGIOS.FUNCIONARIORow funcionarioLinha = (dsFROGIOS.FUNCIONARIORow) funcionario.Rows[0];
            categoria.Load(
                categoriaSQL.selecionar(
                categoria.CATEGORIA_CODIGOColumn.ColumnName,
                funcionarioLinha.FUNCIONARIO_CATEGORIA.ToString(),
                true
                )    
            );*/
        }

        public void deletar(dsFROGIOS.FUNCIONARIORow funcionario) {
            TblFuncionario funcionarioSQL = new TblFuncionario();
            funcionarioSQL.deletar(funcionario);
        }


    }
}
