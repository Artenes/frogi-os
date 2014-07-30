using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FROGI_OS {
    public static class BD {

        public static readonly string TABELA_CATEGORIA = "CATEGORIA";
        public static readonly string COLUNA_CATEGORIA_CODIGO = "CATEGORIA_CODIGO";
        public static readonly string COLUNA_CATEGORIA_DESCRICAO = "CATEGORIA_DESCRICAO";

        public static readonly string TABELA_CLIENTE = "CLIENTE";
        public static readonly string COLUNA_CLIENTE_CODIGO = "CLIENTE_CODIGO";
        public static readonly string COLUNA_CLIENTE_NOME = "CLIENTE_NOME";
        public static readonly string COLUNA_CLIENTE_TELEFONE = "CLIENTE_TELEFONE";
        public static readonly string COLUNA_CLIENTE_CELULAR = "CLIENTE_CELULAR";
        public static readonly string COLUNA_CLIENTE_EMAIL = "CLIENTE_EMAIL";
        public static readonly string COLUNA_CLIENTE_ENDERECO = "CLIENTE_ENDERECO";
        public static readonly string COLUNA_CLIENTE_BAIRRO = "CLIENTE_BAIRRO";
        public static readonly string COLUNA_CLIENTE_PERIMETRO = "CLIENTE_PERIMETRO";
        public static readonly string COLUNA_CLIENTE_CIDADE = "CLIENTE_CIDADE";
        public static readonly string COLUNA_CLIENTE_UF = "CLIENTE_UF";
        public static readonly string COLUNA_CLIENTE_CEP = "CLIENTE_CEP";
        public static readonly string COLUNA_CLIENTE_DATA_CADASTRO = "CLIENTE_DATA_CADASTRO";

        public static readonly string TABELA_CLIENTE_FISICO = "CLIENTE_FISICO";
        public static readonly string COLUNA_CLIENTE_FISICO_CLIENTE = "CLIENTE_FISICO_CLIENTE";
        public static readonly string COLUNA_CLIENTE_FISICO_CPF = "CLIENTE_FISICO_CPF";
        public static readonly string COLUNA_CLIENTE_FISICO_RG = "CLIENTE_FISICO_RG";
        public static readonly string COLUNA_CLIENTE_FISICO_NASCIMENTO = "CLIENTE_FISICO_NASCIMENTO";
        public static readonly string COLUNA_CLIENTE_FISICO_SEXO = "CLIENTE_FISICO_SEXO";
        public static readonly string COLUNA_CLIENTE_FISICO_ESTADO_CIVIL = "CLIENTE_FISICO_ESTADO_CIVIL";
        public static readonly string COLUNA_CLIENTE_FISICO_PROFISSAO = "CLIENTE_FISICO_PROFISSAO";
        public static readonly string COLUNA_CLIENTE_FISICO_SALARIO = "CLIENTE_FISICO_SALARIO";
        public static readonly string COLUNA_CLIENTE_FISICO_LIMITE = "CLIENTE_FISICO_LIMITE";
        public static readonly string COLUNA_CLIENTE_FISICO_LIMITE_ATUAL = "CLIENTE_FISICO_LIMITE_ATUAL";
        public static readonly string COLUNA_CLIENTE_FISICO_MAE = "CLIENTE_FISICO_MAE";
        public static readonly string COLUNA_CLIENTE_FISICO_PAI = "CLIENTE_FISICO_PAI";
        public static readonly string COLUNA_CLIENTE_FISICO_OBSERVACAO = "CLIENTE_FISICO_OBSERVACAO";

        public static readonly string TABELA_CLIENTE_JURIDICO = "CLIENTE_JURIDICO";
        public static readonly string COLUNA_CLIENTE_JURIDICO_CLIENTE = "CLIENTE_JURIDICO_CLIENTE";
        public static readonly string COLUNA_CLIENTE_JURIDICO_RAZAO_SOCIAL = "CLIENTE_JURIDICO_RAZAO_SOCIAL";
        public static readonly string COLUNA_CLIENTE_JURIDICO_CNPJ = "CLIENTE_JURIDICO_CNPJ";
        public static readonly string COLUNA_CLIENTE_JURIDICO_IE = "CLIENTE_JURIDICO_IE";
        public static readonly string COLUNA_CLIENTE_JURIDICO_FANTASIA = "CLIENTE_JURIDICO_FANTASIA";
        public static readonly string COLUNA_CLIENTE_JURIDICO_ATIVIDADE = "CLIENTE_JURIDICO_ATIVIDADE";
        public static readonly string COLUNA_CLIENTE_JURIDICO_NOME_CONTATO = "CLIENTE_JURIDICO_NOME_CONTATO";

        public static readonly string TABELA_COMPRA = "COMPRA";
        public static readonly string COLUNA_COMPRA_CODIGO = "COMPRA_CODIGO";
        public static readonly string COLUNA_COMPRA_NOTA_FISCAL = "COMPRA_NOTA_FISCAL";
        public static readonly string COLUNA_COMPRA_FUNCIONARIO = "COMPRA_FUNCIONARIO";
        public static readonly string COLUNA_COMPRA_FORNECEDOR = "COMPRA_FORNECEDOR";
        public static readonly string COLUNA_COMPRA_DESCONTO = "COMPRA_DESCONTO";
        public static readonly string COLUNA_COMPRA_ACRESCIMO = "COMPRA_ACRESCIMO";
        public static readonly string COLUNA_COMPRA_TOTAL = "COMPRA_TOTAL";
        public static readonly string COLUNA_COMPRA_DATA = "COMPRA_DATA";

        public static readonly string TABELA_EMPRESA = "EMPRESA";
        public static readonly string COLUNA_EMPRESA_CODIGO = "EMPRESA_CODIGO";
        public static readonly string COLUNA_EMPRESA_RAZAO_SOCIAL = "EMPRESA_RAZAO_SOCIAL";
        public static readonly string COLUNA_EMPRESA_FANTASIA = "EMPRESA_FANTASIA";
        public static readonly string COLUNA_EMPRESA_CNPJ = "EMPRESA_CNPJ";
        public static readonly string COLUNA_EMPRESA_INSCRICAO_ESTADUAL = "EMPRESA_INSCRICAO_ESTADUAL";
        public static readonly string COLUNA_EMPRESA_INSCRICAO_MUNICIPAL = "EMPRESA_INSCRICAO_MUNICIPAL";
        public static readonly string COLUNA_EMPRESA_TIPO_EMPRESA = "EMPRESA_TIPO_EMPRESA";
        public static readonly string COLUNA_EMPRESA_TELEFONE = "EMPRESA_TELEFONE";
        public static readonly string COLUNA_EMPRESA_ENDERECO = "EMPRESA_ENDERECO";
        public static readonly string COLUNA_EMPRESA_COMPLEMENTO = "EMPRESA_COMPLEMENTO";
        public static readonly string COLUNA_EMPRESA_BAIRRO = "EMPRESA_BAIRRO";
        public static readonly string COLUNA_EMPRESA_CEP = "EMPRESA_CEP";
        public static readonly string COLUNA_EMPRESA_CIDADE = "EMPRESA_CIDADE";
        public static readonly string COLUNA_EMPRESA_UF = "EMPRESA_UF";
        public static readonly string COLUNA_EMPRESA_MENSAGEM_PROMOCIONAL = "EMPRESA_MENSAGEM_PROMOCIONAL";
        public static readonly string COLUNA_EMPRESA_LOGO_GRANDE = "EMPRESA_LOGO_GRANDE";
        public static readonly string COLUNA_EMPRESA_LOGO_PEQUENA = "EMPRESA_LOGO_PEQUENA";
        public static readonly string COLUNA_EMPRESA_TIPO_LICENCA = "EMPRESA_TIPO_LICENCA";

        public static readonly string TABELA_FORNECEDOR = "FORNECEDOR";
        public static readonly string COLUNA_FORNECEDOR_CODIGO = "FORNECEDOR_CODIGO";
        public static readonly string COLUNA_FORNECEDOR_ENDERECO = "FORNCEDOR_ENDERECO";
        public static readonly string COLUNA_FORNECEDOR_BAIRRO = "FORNECEDOR_BAIRRO";
        public static readonly string COLUNA_FORNECEDOR_PERIMETRO = "FORNECEDOR_PERIMETRO";
        public static readonly string COLUNA_FORNECEDOR_CIDADE = "FORNECEDOR_CIDADE";
        public static readonly string COLUNA_FORNECEDOR_UF = "FORNECEDOR_UF";
        public static readonly string COLUNA_FORNECEDOR_CEP = "FORNECEDOR_CEP";
        public static readonly string COLUNA_FORNECEDOR_TELEFONE = "FORNCEDOR_TELEFONE";
        public static readonly string COLUNA_FORNECEDOR_CELULAR = "FORNECEDOR_CELULAR";
        public static readonly string COLUNA_FORNECEDOR_EMAIL = "FORNECEDOR_EMAIL";
        public static readonly string COLUNA_FORNECEDOR_OBSERVACOES = "FORNECEDOR_OBSERVACOES";

        public static readonly string TABELA_FORNECEDOR_FISICO = "FORNECEDOR_FISICO";
        public static readonly string COLUNA_FORNECEDOR_FISICO_FORNECEDOR = "FORNECEDOR_FISICO_FORNECEDOR";
        public static readonly string COLUNA_FORNECEDOR_FISICO_NOME = "FORNECEDOR_FISICO_NOME";
        public static readonly string COLUNA_FORNECEDOR_FISICO_CPF = "FORNECEDOR_FISICO_CPF";
        public static readonly string COLUNA_FORNECEDOR_FISICO_RG = "FORNECEDOR_FISICO_RG";

        public static readonly string TABELA_FORNECEDOR_JURIDICO = "FORNECEDOR_JURIDICO";
        public static readonly string COLUNA_FORNECEDOR_JURIDICO_FORNECEDOR = "FORNECEDOR_JURIDICO_FORNECEDOR";
        public static readonly string COLUNA_FORNECEDOR_JURIDICO_RAZ_SOC = "FORNECEDOR_JURIDICO_RAZ_SOC";
        public static readonly string COLUNA_FORNECEDOR_JURIDICO_CNPJ = "FORNECEDOR_JURIDICO_CNPJ";
        public static readonly string COLUNA_FORNECEDOR_JURIDICO_IE = "FORNECEDOR_JURIDICO_IE";
        public static readonly string COLUNA_FORNECEDOR_JURIDICO_FANTASIA = "FORNECEDOR_JURIDICO_FANTASIA";
        public static readonly string COLUNA_FORNECEDOR_JURIDICO_REPRE = "FORNECEDOR_JURIDICO_REPRE";
        public static readonly string COLUNA_FORNECEDOR_JURIDICO_CONTATO = "FORNECEDOR_JURIDICO_CONTATO";

        public static readonly string TABELA_FUNCIONARIO = "FUNCIONARIO";
        public static readonly string COLUNA_FUNCIONARIO_CODIGO = "FUNCIONARIO_CODIGO";
        public static readonly string COLUNA_FUNCIONARIO_NOME = "FUNCIONARIO_NOME";
        public static readonly string COLUNA_FUNCIONARIO_CPF = "FUNCIONARIO_CPF";
        public static readonly string COLUNA_FUNCIONARIO_RG = "FUNCIONARIO_RG";
        public static readonly string COLUNA_FUNCIONARIO_NASCIMENTO = "FUNCIONARIO_NASCIMENTO";
        public static readonly string COLUNA_FUNCIONARIO_PIS = "FUNCIONARIO_PIS";
        public static readonly string COLUNA_FUNCIONARIO_TELEFONE = "FUNCIONARIO_TELEFONE";
        public static readonly string COLUNA_FUNCIONARIO_EMAIL = "FUNCIONARIO_EMAIL";
        public static readonly string COLUNA_FUNCIONARIO_ENDERECO = "FUNCIONARIO_ENDERECO";
        public static readonly string COLUNA_FUNCIONARIO_BAIRRO = "FUNCIONARIO_BAIRRO";
        public static readonly string COLUNA_FUNCIONARIO_CEP = "FUNCIONARIO_CEP";
        public static readonly string COLUNA_FUNCIONARIO_FUNCAO = "FUNCIONARIO_FUNCAO";
        public static readonly string COLUNA_FUNCIONARIO_SETOR = "FUNCIONARIO_SETOR";
        public static readonly string COLUNA_FUNCIONARIO_SALARIO = "FUNCIONARIO_SALARIO";
        public static readonly string COLUNA_FUNCIONARIO_ADMISSAO = "FUNCIONARIO_ADMISSAO";
        public static readonly string COLUNA_FUNCIONARIO_SENHA = "FUNCIONARIO_SENHA";
        public static readonly string COLUNA_FUNCIONARIO_CATEGORIA = "FUNCIONARIO_CATEGORIA";
        public static readonly string COLUNA_FUNCIONARIO_DATA_CADASTRO = "FUNCIONARIO_DATA_CADASTRO";

        public static readonly string TABELA_GRUPO = "GRUPO";
        public static readonly string COLUNA_GRUPO_CODIGO = "GRUPO_CODIGO";
        public static readonly string COLUNA_GRUPO_DESCRICAO = "GRUPO_DESCRICAO";
        public static readonly string COLUNA_GRUPO_DESCONTO = "GRUPO_DESCONTO";

        public static readonly string TABELA_ITEM_COMPRA = "ITEM_COMPRA";
        public static readonly string COLUNA_ITEM_COMPRA_CODIGO = "ITEM_COMPRA_CODIGO";
        public static readonly string COLUNA_ITEM_COMPRA_COMPRA = "ITEM_COMPRA_COMPRA";
        public static readonly string COLUNA_ITEM_COMPRA_PRODUTO = "ITEM_COMPRA_PRODUTO";
        public static readonly string COLUNA_ITEM_COMPRA_PRECO = "ITEM_COMPRA_PRECO";
        public static readonly string COLUNA_ITEM_COMPRA_DESCONTO = "ITEM_COMPRA_DESCONTO";
        public static readonly string COLUNA_ITEM_COMPRA_QUANTIDADE = "ITEM_COMPRA_QUANTIDADE";
        public static readonly string COLUNA_ITEM_COMPRA_PRECO_TOTAL = "ITEM_COMPRA_TOTAL";

        public static readonly string TABELA_MARCA = "MARCA";
        public static readonly string COLUNA_MARCA_CODIGO = "MARCA_CODIGO";
        public static readonly string COLUNA_MARCA_DESCRICAO = "MARCA_DESCRICAO";

        public static readonly string TABELA_ORCAMENTO = "ORCAMENTO";
        public static readonly string COLUNA_ORCAMENTO_CODIGO = "ORCAMENTO_CODIGO";
        public static readonly string COLUNA_ORCAMENTO_CLIENTE = "ORCAMENTO_CLIENTE";
        public static readonly string COLUNA_ORCAMENTO_FUNCIONARIO = "ORCAMENTO_FUNCIONARIO";
        public static readonly string COLUNA_ORCAMENTO_TOTAL_ITEM = "ORCAMENTO_ITEM";
        public static readonly string COLUNA_ORCAMENTO_TOTAL_SERVICO = "ORCAMENTO_SERVICO";
        public static readonly string COLUNA_ORCAMENTO_DESCONTO = "ORCAMENTO_DESCONTO";
        public static readonly string COLUNA_ORCAMENTO_ACRESCIMO = "ORCAMENTO_ACRESCIMO";
        public static readonly string COLUNA_ORCAMENTO_OBSERVACAO = "ORCAMENTO_OBSERVACAO";
        public static readonly string COLUNA_ORCAMENTO_TOTAL = "ORCAMENTO_TOTAL";
        public static readonly string COLUNA_ORCAMENTO_DATA = "ORCAMENTO_DATA";

        public static readonly string TABELA_ORCAMENTO_ITEM = "ORCAMENTO_ITEM";
        public static readonly string COLUNA_ORCAMENTO_ITEM_CODIGO = "ORCAMENTO_ITEM_CODIGO";
        public static readonly string COLUNA_ORCAMENTO_ITEM_ORCAMENTO = "ORCAMENTO_ITEM_ORCAMENTO";
        public static readonly string COLUNA_ORCAMENTO_ITEM_PRODUTO = "ORCAMENTO_ITEM_PRODUTO";
        public static readonly string COLUNA_ORCAMENTO_ITEM_VALOR = "ORCAMENTO_ITEM_VALOR";
        public static readonly string COLUNA_ORCAMENTO_ITEM_DESCRICAO = "ORCAMENTO_ITEM_DESCRICAO";
        public static readonly string COLUNA_ORCAMENTO_ITEM_DESCONTO = "ORCAMENTO_ITEM_DESCONTO";
        public static readonly string COLUNA_ORCAMENTO_ITEM_QUANTIDADE = "ORCAMENTO_ITEM_QUANTIDADE";
        public static readonly string COLUNA_ORCAMENTO_ITEM_TOTAL = "ORCAMENTO_ITEM_TOTAL";

        public static readonly string TABELA_ORCAMENTO_SERVICO = "ORCAMENTO_SERVICO";
        public static readonly string COLUNA_ORCAMENTO_SERVICO_CODIGO = "ORCAMENTO_SERVICO_CODIGO";
        public static readonly string COLUNA_ORCAMENTO_SERVICO_ORCAMENTO = "ORCAMENTO_SERVICO_ORCAMENTO";
        public static readonly string COLUNA_ORCAMENTO_SERVICO_SERVICO = "ORCAMENTO_SERVICO_SERVICO";
        public static readonly string COLUNA_ORCAMENTO_SERVICO_VALOR = "ORCAMENTO_SERVICO_VALOR";
        public static readonly string COLUNA_ORCAMENTO_SERVICO_DESCRICAO = "ORCAMENTO_SERVICO_DESCRICAO";
        public static readonly string COLUNA_ORCAMENTO_SERVICO_DESCONTO = "ORCAMENTO_SERVICO_DESCONTO";
        public static readonly string COLUNA_ORCAMENTO_SERVICO_ACRESCIMO = "ORCAMENTO_SERVICO_ACRESCIMO";
        public static readonly string COLUNA_ORCAMENTO_SERVICO_TOTAL = "ORCAMENTO_SERVICO_TOTAL";

        public static readonly string TABELA_OS = "OS";
        public static readonly string COLUNA_OS_CODIGO = "OS_CODIGO";
        public static readonly string COLUNA_OS_CLIENTE = "OS_CLIENTE";
        public static readonly string COLUNA_OS_FUNCIONARIO = "OS_FUNCIONARIO";
        public static readonly string COLUNA_OS_TOTAL_ITEM = "OS_TOTAL_ITEM";
        public static readonly string COLUNA_OS_TOTAL_SERVICO = "OS_TOTAL_SERVICO";
        public static readonly string COLUNA_OS_DESCONTO = "OS_DESCONTO";
        public static readonly string COLUNA_OS_ACRESCIMO = "OS_ACRESCIMO";
        public static readonly string COLUNA_OS_FORMA_PAGAMENTO = "OS_FORMA_PAGAMENTO";
        public static readonly string COLUNA_OS_TOTAL = "OS_TOTAL";
        public static readonly string COLUNA_OS_DATA = "OS_DATA";

        public static readonly string TABELA_OS_ITEM = "OS_ITEM";
        public static readonly string COLUNA_OS_ITEM_CODIGO = "OS_ITEM_CODIGO";
        public static readonly string COLUNA_OS_ITEM_OS = "OS_ITEM_OS";
        public static readonly string COLUNA_OS_ITEM_PRODUTO = "OS_ITEM_PRODUTO";
        public static readonly string COLUNA_OS_ITEM_DESCRICAO = "OS_ITEM_DESCRICAO";
        public static readonly string COLUNA_OS_ITEM_VALOR = "OS_ITEM_VALOR";
        public static readonly string COLUNA_OS_ITEM_DESCONTO = "OS_ITEM_DESCONTO";
        public static readonly string COLUNA_OS_ITEM_QUANTIDADE = "OS_ITEM_QUANTIDADE";
        public static readonly string COLUNA_OS_ITEM_TOTAL = "OS_ITEM_TOTAL";

        public static readonly string TABELA_OS_SERVICO = "OS_SERVICO";
        public static readonly string COLUNA_OS_SERVICO_CODIGO = "OS_SERVICO_CODIGO";
        public static readonly string COLUNA_OS_SERVICO_OS = "OS_SERVICO_OS";
        public static readonly string COLUNA_OS_SERVICO_SERVICO = "OS_SERVICO_SERVICO";
        public static readonly string COLUNA_OS_SERVICO_VALOR= "OS_SERVICO_VALOR";
        public static readonly string COLUNA_OS_SERVICO_DESCRICAO = "OS_SERVICO_DESCRICAO";
        public static readonly string COLUNA_OS_SERVICO_DESCONTO = "OS_SERVICO_DESCONTO";
        public static readonly string COLUNA_OS_SERVICO_ACRESCIMO = "OS_SERVICO_ACRESCIMO";
        public static readonly string COLUNA_OS_SERVICO_TOTAL = "OS_SERVICO_TOTAL";

        //TABELA DE PERMISSÃO NÃO VAI AGORA, ELA VAI SER IMPLMENTADA AO FINAL DA PRIMEIRA ENTREGA

        public static readonly string TABELA_PRODUTO = "PRODUTO";
        public static readonly string COLUNA_PRODUTO_CODIGO = "PRODUTO_CODIGO";
        public static readonly string COLUNA_PRODUTO_DESCRICAO = "PRODUTO_DESCRICAO";
        public static readonly string COLUNA_PRODUTO_CARACTERISTICA = "PRODUTO_CARACTERISTICA";
        public static readonly string COLUNA_PRODUTO_UNIDADE_COMPRA = "PRODUTO_UNIDADE_COMPRA";
        public static readonly string COLUNA_PRODUTO_UNIDADE_VENDA = "PRODUTO_UNIDADE_VENDA";
        public static readonly string COLUNA_PRODUTO_PESO = "PRODUTO_PESO";
        public static readonly string COLUNA_PRODUTO_NUMERO = "PRODUTO_NUMERO";
        public static readonly string COLUNA_PRODUTO_EAN = "PRODUTO_EAN";
        public static readonly string COLUNA_PRODUTO_NUMERO_SERIE = "PRODUTO_NUMERO_SERIE";
        public static readonly string COLUNA_PRODUTO_MARCA = "PRODUTO_MARCA";
        public static readonly string COLUNA_PRODUTO_GRUPO = "PRODUTO_GRUPO";
        public static readonly string COLUNA_PRODUTO_SECAO = "PRODUTO_SECAO";
        public static readonly string COLUNA_PRODUTO_FORNECEDOR = "PRODUTO_FORNECEDOR";
        public static readonly string COLUNA_PRODUTO_CFOP = "PRODUTO_CFOP";
        public static readonly string COLUNA_PRODUTO_CSOSN = "PRODUTO_CSOSN";
        public static readonly string COLUNA_PRODUTO_NCM = "PRODUTO_NCM";
        public static readonly string COLUNA_PRODUTO_SITUACAO_TRIBUTARIA = "PRODUTO_SITUACAO_TRIBUTARIA";
        public static readonly string COLUNA_PRODUTO_ORIGEM_MERCADORIA = "PRODUTO_ORIGEM_MERCADORIA";
        public static readonly string COLUNA_PRODUTO_ESTOQUE_MINIMO = "PRODUTO_ESTOQUE_MINIMO";
        public static readonly string COLUNA_PRODUTO_ESTOQUE_MAXIMO = "PRODUTO_ESTOQUE_MAXIMO";
        public static readonly string COLUNA_PRODUTO_ESTOQUE_ATUAL = "PRODUTO_ESTOQUE_ATUAL";
        public static readonly string COLUNA_PRODUTO_PRECO_COMPRA = "PRODUTO_PRECO_COMPRA";
        public static readonly string COLUNA_PRODUTO_PRECO_CUSTO = "PRODUTO_PRECO_CUSTO";
        public static readonly string COLUNA_PRODUTO_PRECO_VENDA = "PRODUTO_PRECO_VENDA";
        public static readonly string COLUNA_PRODUTO_DATA_CADASTRO = "PRODUTO_DATA_CADASTRO";

        public static readonly string TABELA_SECAO = "SECAO";
        public static readonly string COLUNA_SECAO_CODIGO = "SECAO_CODIGO";
        public static readonly string COLUNA_SECAO_DESCRICAO = "SECAO_DESCRICAO";

        public static readonly string TABELA_SERVICO = "SERVICO";
        public static readonly string COLUNA_SERVICO_CODIGO = "SERVICO_CODIGO";
        public static readonly string COLUNA_SERVICO_DESCRICAO = "SERVICO_DESCRICAO";
        public static readonly string COLUNA_SERVICO_VALOR = "SERVICO_VALOR";

        public static readonly string TABELA_SERVICO_TIPO = "SERVICO_TIPO";
        public static readonly string COLUNA_SERVICO_TIPO_SERVICO = "SERVICO_TIPO_SERVICO";
        public static readonly string COLUNA_SERVICO_TIPO_TIPO = "SERVICO_TIPO_TIPO";

        public static readonly string TABELA_TIPO = "TIPO";
        public static readonly string COLUNA_TIPO_CODIGO = "TIPO_CODIGO";
        public static readonly string COLUNA_TIPO_DESCRICAO = "TIPO_DESCRICAO";

        public static readonly string TABELA_UF = "UF";
        public static readonly string COLUNA_UF_CODIGO = "UF_CODIGO";
        public static readonly string COLUNA_UF_DESCRICAO = "UF_DESCRICAO";

        public static readonly string TABELA_USUARIO = "USUARIO";
        public static readonly string COLUNA_USUARIO_CODIGO = "USUARIO_CODIGO";
        public static readonly string COLUNA_USUARIO_NOME = "USUARIO_NOME";
        public static readonly string COLUNA_USUARIO_SENHA = "USUARIO_SENHA";
        public static readonly string COLUNA_USUARIO_CATEGORIA = "USUARIO_CATEGORIA";
        public static readonly string COLUNA_USUARIO_DATA_CADASTRO = "USUARIO_DATA_CADASTRO";

    }
}
