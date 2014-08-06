using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirebirdSql.Data.FirebirdClient;

namespace FROGI_OS.CamadaAcessoDados {
    class TblEmpresa {

        private string paramCodigo = "@CODIGO";
        private string paramRazaoSocial = "@RAZAOSOCIAL";
        private string paramFantasia = "@FANTASIA";
        private string paramCnpj = "@CNPJ";
        private string paramInscricaoEstadual = "@INSCRICAOESTADUAL";
        private string paramInscricaoMunicipal = "@INSCRICAOMUNICIPAL";
        private string paramTipoEmpresa = "@TIPOEMPRESA";
        private string paramTelefone = "@TELEFONE";
        private string paramEndereco = "@ENDERECO";
        private string paramComplemento = "@COMPLEMENTO";
        private string paramBairro = "@BAIRRO";
        private string paramCep = "@CEP";
        private string paramCidade = "@CIDADE";
        private string paramUf = "@UF";
        private string paramMensagemPromocional = "@MENSAGEMPROMOCIONAL";
        private string paramLogoGrande = "@LOGOGRANDE";
        private string paramLogoPequena = "@LOGOPEQUENA";
        private string paramTipoLicenca = "@TIPOLICENCA";
        private string paramValor = "@VALOR";

        public int inserir(dsFROGIOS.EMPRESARow empresa) {
            FbCommand comando = null;
            string sql =
                "INSERT INTO CATEGORIA "
               + "VALUES (NULL, "
               + paramRazaoSocial + ", "
               + paramFantasia + ", "
               + paramCnpj + ", "
               + paramInscricaoEstadual + ", "
               + paramInscricaoMunicipal + ", "
               + paramTipoEmpresa + ", "
               + paramTelefone + ", "
               + paramEndereco + ", "
               + paramComplemento + ", "
               + paramBairro + ", "
               + paramCep + ", "
               + paramCidade + ", "
               + paramUf + ", "
               + paramMensagemPromocional + ", "
               + paramLogoGrande + ", "
               + paramLogoPequena + ", "
               + paramTipoLicenca + ") "
               + "RETURNING EMPRESA_CODIGO;";

            comando = new FbCommand(sql, Conexao.getConexao, Conexao.getTransacao);
            comando.Parameters.AddWithValue(paramRazaoSocial, empresa.EMPRESA_RAZAO_SOCIAL);
            comando.Parameters.AddWithValue(paramFantasia, empresa.EMPRESA_FANTASIA);
            comando.Parameters.AddWithValue(paramCnpj, empresa.EMPRESA_CNPJ);
            comando.Parameters.AddWithValue(paramInscricaoEstadual, empresa.EMPRESA_INSCRICAO_ESTADUAL);
            comando.Parameters.AddWithValue(paramInscricaoMunicipal, empresa.EMPRESA_INSCRICAO_MUNICIPAL);
            comando.Parameters.AddWithValue(paramTipoEmpresa, empresa.EMPRESA_TIPO_EMPRESA);
            comando.Parameters.AddWithValue(paramTelefone, empresa.EMPRESA_TELEFONE);
            comando.Parameters.AddWithValue(paramEndereco, empresa.EMPRESA_ENDERECO);
            comando.Parameters.AddWithValue(paramComplemento, empresa.EMPRESA_COMPLEMENTO);
            comando.Parameters.AddWithValue(paramBairro, empresa.EMPRESA_BAIRRO);
            comando.Parameters.AddWithValue(paramCep, empresa.EMPRESA_CEP);
            comando.Parameters.AddWithValue(paramCidade, empresa.EMPRESA_CIDADE);
            comando.Parameters.AddWithValue(paramUf, empresa.EMPRESA_UF);
            comando.Parameters.AddWithValue(paramMensagemPromocional, empresa.EMPRESA_MENSAGEM_PROMOCIONAL);
            comando.Parameters.AddWithValue(paramLogoGrande, empresa.EMPRESA_LOGO_GRANDE);
            comando.Parameters.AddWithValue(paramLogoPequena, empresa.EMPRESA_LOGO_PEQUENA);
            comando.Parameters.AddWithValue(paramTipoLicenca, empresa.EMPRESA_TIPO_LICENCA);
            return (int)comando.ExecuteScalar();
        }

        public int atualizar(dsFROGIOS.EMPRESARow empresa) {
            FbCommand comando = null;
            dsFROGIOS.EMPRESADataTable tabela = new dsFROGIOS.EMPRESADataTable();
            string sql =
                "UPDATE EMPRESA "
                + "SET EMPRESA_RAZAO_SOCIAL = " + paramRazaoSocial + ", "
                + "EMPRESA_FANTASIA = " + paramFantasia + ", "
                + "EMPRESA_CNPJ = " + paramCnpj + ", "
                + "EMPRESA_INSCRICAO_ESTADUAL = " + paramInscricaoEstadual + ", "
                + "EMPRESA_INSCRICAO_MUNICIPAL = " + paramInscricaoMunicipal + ", "
                + "EMPRESA_TIPO_EMPRESA = " + paramTipoEmpresa + ", "
                + "EMPRESA_TELEFONE = " + paramTelefone + ", "
                + "EMPRESA_ENDERECO = " + paramEndereco + ", "
                + "EMPRESA_COMPLEMENTO = " + paramComplemento + ", "
                + "EMPRESA_BAIRRO = " + paramBairro + ", "
                + "EMPRESA_CEP = " + paramCep + ", "
                + "EMPRESA_CIDADE = " + paramCidade + ", "
                + "EMPRESA_UF = " + paramUf + ", "
                + "EMPRESA_MENSAGEM_PROMOCIONAL = " + paramMensagemPromocional + ", "
                + "EMPRESA_LOGO_GRANDE = " + paramLogoGrande + ", "
                + "EMPRESA_LOGO_PEQUENA = " + paramLogoPequena + ", "
                + "EMPRESA_TIPO_LICENCA = " + paramTipoLicenca + " "
                + "WHERE EMPRESA_CODIGO = " + paramCodigo + ";";

            comando = new FbCommand(sql, Conexao.getConexao, Conexao.getTransacao);
            comando.Parameters.AddWithValue(paramCodigo, empresa.EMPRESA_CODIGO);
            comando.Parameters.AddWithValue(paramRazaoSocial, empresa.EMPRESA_RAZAO_SOCIAL);
            comando.Parameters.AddWithValue(paramFantasia, empresa.EMPRESA_FANTASIA);
            comando.Parameters.AddWithValue(paramCnpj, empresa.EMPRESA_CNPJ);
            comando.Parameters.AddWithValue(paramInscricaoEstadual, empresa.EMPRESA_INSCRICAO_ESTADUAL);
            comando.Parameters.AddWithValue(paramInscricaoMunicipal, empresa.EMPRESA_INSCRICAO_MUNICIPAL);
            comando.Parameters.AddWithValue(paramTipoEmpresa, empresa.EMPRESA_TIPO_EMPRESA);
            comando.Parameters.AddWithValue(paramTelefone, empresa.EMPRESA_TELEFONE);
            comando.Parameters.AddWithValue(paramEndereco, empresa.EMPRESA_ENDERECO);
            comando.Parameters.AddWithValue(paramComplemento, empresa.EMPRESA_COMPLEMENTO);
            comando.Parameters.AddWithValue(paramBairro, empresa.EMPRESA_BAIRRO);
            comando.Parameters.AddWithValue(paramCep, empresa.EMPRESA_CEP);
            comando.Parameters.AddWithValue(paramCidade, empresa.EMPRESA_CIDADE);
            comando.Parameters.AddWithValue(paramUf, empresa.EMPRESA_UF);
            comando.Parameters.AddWithValue(paramMensagemPromocional, empresa.EMPRESA_MENSAGEM_PROMOCIONAL);
            comando.Parameters.AddWithValue(paramLogoGrande, empresa.EMPRESA_LOGO_GRANDE);
            comando.Parameters.AddWithValue(paramLogoPequena, empresa.EMPRESA_LOGO_PEQUENA);
            comando.Parameters.AddWithValue(paramTipoLicenca, empresa.EMPRESA_TIPO_LICENCA);

            return (int)comando.ExecuteScalar();
        }

        public FbDataReader selecionar(string coluna, string valor, bool comPrecisao) {
            FbCommand comando = null;
            string precisao = comPrecisao ? " = " : " CONTAINING ";
            string sql =
                "SELECT * "
                + "FROM EMPRESA "
                + "WHERE " + coluna + precisao + paramValor + ";";

            comando = new FbCommand(sql, Conexao.getConexao, Conexao.getTransacao);
            comando.Parameters.AddWithValue(paramValor, valor);
            return comando.ExecuteReader();
        }

        public int deletar(dsFROGIOS.EMPRESARow empresa) {
            FbCommand comando = null;
            string sql =
                "DELETE FROM EMPRESA "
                + " WHERE EMPRESA_CODIGO = " + paramCodigo + ";";

            comando = new FbCommand(sql, Conexao.getConexao, Conexao.getTransacao);
            comando.Parameters.AddWithValue(paramCodigo, empresa.EMPRESA_CODIGO);

            return (int)comando.ExecuteScalar();
        }

    }
}
