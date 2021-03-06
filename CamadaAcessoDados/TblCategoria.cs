﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirebirdSql.Data.FirebirdClient;

namespace FROGI_OS.CamadaAcessoDados {
    class TblCategoria {
        private string paramCodigo = "@CODIGO";
        private string paramDescricao = "@DESCRICAO";
        private string paramValor = "@VALOR";

        public int inserir(dsFROGIOS.CATEGORIARow categoria) {
            FbCommand comando = null;
            string sql = 
                "INSERT INTO CATEGORIA "
               +"VALUES (NULL, "+paramDescricao+") "
               +"RETURNING CATEGORIA_CODIGO;";

            comando = new FbCommand(sql, Conexao.getConexao, Conexao.getTransacao);
            comando.Parameters.AddWithValue(paramDescricao, categoria.CATEGORIA_DESCRICAO);
            return comando.ExecuteNonQuery();
        }

        public int atualizar(dsFROGIOS.CATEGORIARow categoria) {
            FbCommand comando = null;
            string sql =
                "UPDATE CATEGORIA "
                + "SET CATEGORIA_DESCRICAO = " + paramDescricao + " "
                + "WHERE CATEGORIA_CODIGO = " + paramCodigo + ";";

            comando = new FbCommand(sql, Conexao.getConexao, Conexao.getTransacao);
            comando.Parameters.AddWithValue(paramCodigo, categoria.CATEGORIA_CODIGO);
            comando.Parameters.AddWithValue(paramDescricao, categoria.CATEGORIA_DESCRICAO);

            return comando.ExecuteNonQuery();
        }

        public FbDataReader selecionar(string coluna, string valor, bool comPrecisao) {
            FbCommand comando = null;
            string precisao = comPrecisao ? " = " : " CONTAINING ";
            string sql =
                "SELECT * "
                + "FROM CATEGORIA "
                + "WHERE " + coluna + precisao + paramValor + ";";

            comando = new FbCommand(sql, Conexao.getConexao, Conexao.getTransacao);
            comando.Parameters.AddWithValue(paramValor, valor);
            return comando.ExecuteReader();
        }

        public int deletar(dsFROGIOS.CATEGORIARow categoria) {
            FbCommand comando = null;
            string sql =
                "DELETE FROM CATEGORIA "
                + " WHERE CATEGORIA_CODIGO = " + paramCodigo + ";";

            comando = new FbCommand(sql, Conexao.getConexao, Conexao.getTransacao);
            comando.Parameters.AddWithValue(paramCodigo, categoria.CATEGORIA_CODIGO);

            return comando.ExecuteNonQuery();
        }
    }
}
