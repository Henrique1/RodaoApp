using Dominio1;
using Repositorio1;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacao2
{
    public class RodaoAplicacao
    {
        private Contexto contexto;

        private void Inserir(Pedidos pedidos)
        {


            var strQuery = "";
            strQuery += "INSERT INTO PEDIDOS (Nome, Endereco, Email, Marca, Modelo, Ano, Peca)";
            strQuery += string.Format("VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}')",
               pedidos.Nome, pedidos.Endereco,  pedidos.Email, pedidos.Marca, pedidos.Modelo, pedidos.Ano, pedidos.Peca
           );
            using (contexto = new Contexto())
            {
                contexto.ExecutaComando(strQuery);
            }
        }
        private void Alterar(Pedidos pedidos)
        {
            var strQuery = "";
            strQuery += " UPDATE PEDIDOS SET ";
            strQuery += string.Format(" Nome = '{0}', ", pedidos.Nome);
            strQuery += string.Format(" Endereco = '{0}', ", pedidos.Endereco);
            strQuery += string.Format(" Email = '{0}', ", pedidos.Email);
            strQuery += string.Format(" Marca = '{0}', ", pedidos.Marca);
            strQuery += string.Format(" Modelo = '{0}', ", pedidos.Modelo);
            strQuery += string.Format(" Ano = '{0}', ", pedidos.Ano);
            strQuery += string.Format(" Peca = '{0}' ", pedidos.Peca);



            strQuery += string.Format(" WHERE PedidosId = '{0}' ", pedidos.Id);
            using (contexto =  new Contexto())
            {
                contexto.ExecutaComando(strQuery);
            }
        }
            public void Salvar (Pedidos pedidos)
              {
            if (pedidos.Id > 0)

                Alterar(pedidos);
            else
                Inserir(pedidos);



        }
        public void Excluir(int id)
        {
            using (contexto = new Contexto())
            {
                var strQuery = string.Format("DELETE FROM PEDIDOS WHERE PedidosId={0}", id);
                contexto.ExecutaComando(strQuery);
            }
        }
        public List<Pedidos> ListarTodos()
        {
            using (contexto = new Contexto())
            {
                var strQuery = " SELECT * FROM PEDIDOS ";
                var retornoDataReader = contexto.ExecutaComandoComRetorno(strQuery);
                return TransformaReaderEmListaDeObjeto(retornoDataReader);
            }
        }
      
             public Pedidos ListarPorId(int id)
        {
            using (contexto = new Contexto())
            {
                var strQuery = string.Format(" SELECT *FROM PEDIDOS WHERE PedidosId = {0} ", id);
                var retornoDataReader = contexto.ExecutaComandoComRetorno(strQuery);
                return TransformaReaderEmListaDeObjeto(retornoDataReader).FirstOrDefault();
            }
        }
         private List<Pedidos> TransformaReaderEmListaDeObjeto(SqlDataReader reader)
        {
            var pedidos = new List<Pedidos>();
            while (reader.Read())
            {   
                var temObjeto = new Pedidos()
                {
                    Id = int.Parse(reader["PedidosId"].ToString()),
                    Nome = reader["Nome"].ToString(),
                    Endereco = reader["Endereco"].ToString(),
                    Email = reader["Email"].ToString(),
                    Marca = reader["Marca"].ToString(),
                    Modelo = reader["Modelo"].ToString(),
                    Ano = reader["Ano"].ToString(),
                    Peca = reader["Peca"].ToString(),



                };

                pedidos.Add(temObjeto);
            }
            reader.Close();
            return pedidos;

        }

         public List<Pedidos> BuscarPorNome(string nome)
         {
             using (contexto = new Contexto())
             {
                 var strQuery = " SELECT * FROM PEDIDOS WHERE Nome LIKE '%Henrique%'";
                 var retornoDataReader = contexto.ExecutaComandoComRetorno(strQuery);
                 return TransformaReaderEmListaDeObjeto(retornoDataReader);
             }
         }





         //public List<Pedidos> BuscaPorNome(string retorno)
         //{
         //    using (contexto = new Contexto())
         //    {
         //        var nome1 = "tutu";
         //        var senha = "tutu";

         //        var Teste = " SELECT * FROM USUARIO WHERE Nome = '" + nome1 + "' AND SENHA = '" + senha + "'";
         //        var retornoDataReader = contexto.ExecutaComandoComRetorno(Teste);
         //        retorno = retornoDataReader;
         //        return (retorno);

         //    }
         //}




        }
    }

