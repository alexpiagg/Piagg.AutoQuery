using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Collections;
using Piagg.AutoQuery.Model;


namespace Piagg.AutoQuery.BLL
{
    public class ArquivoBLL
    {

        private ArquivoTO arquivo {get; set;}


        public ArrayList gerarQuery(ArquivoTO pAarquivo)
        {
            arquivo = pAarquivo;

            ArrayList conteudoArquivo = lerArquivo(arquivo.pathArquivoOrigem, arquivo.nomeArquivo);
            ArrayList linhaQuery = new ArrayList();

            foreach (var item in conteudoArquivo)
            {
                
                linhaQuery.Add(transformaQuery(item.ToString()));
            }

            return linhaQuery;
        }

        public void salvarArquivo(ArrayList listaQuery)
        {
            string nomeArquivo = this.arquivo.pathArquivoDestino + @"\query.sql";
            FileInfo arquivo = new FileInfo(nomeArquivo);

            if (arquivo.Exists)
            {
                arquivo.Delete();           
            }

            StreamWriter wr = new StreamWriter(nomeArquivo);
            wr.WriteLine("start transaction;");

            foreach (var linha in listaQuery) 
            {
                wr.WriteLine(linha.ToString());
            }

            wr.Close();
        }

        public ArrayList lerArquivo(string path, string nome)
        {
            StreamReader objReader = new StreamReader(path + @"\" + nome, System.Text.Encoding.Default);

            string linha = "";
            ArrayList textoLido = new ArrayList ();


            while (linha != null)
            {
                linha = objReader.ReadLine();

                if (linha != null)
                {
                    textoLido.Add(linha);
                }
            }

            return textoLido;
        }

        public string transformaQuery(string linha)
        {
            string[] separar = linha.Split(',');
            string conteudo = "";
            string insert = @"INSERT INTO GASTOS(DATA, LOCAL, VALOR, ID_TIPO_GASTOS) VALUES (";

            foreach (var palavra in separar)
            {
                conteudo += "'" + palavra.ToString().Trim().ToUpper() + "',";
            }

            conteudo = insert + conteudo + ");";

            return conteudo.Replace(",)", ")");;
        }

    }
}
