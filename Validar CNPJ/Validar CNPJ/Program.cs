using System;
using RestSharp;

namespace Validar_CNPJ
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o CNPJ sem ponto");
            string CNPJ = Console.ReadLine();


            var client = new RestClient($"https://receitaws.com.br/v1/cnpj/{CNPJ}");
            Console.WriteLine("resultado da consulta na receita");
            var request = new RestRequest(Method.GET);
            IRestResponse response = client.Execute(request);

            Console.WriteLine(response.Content);
            Console.ReadKey();
        }
    }
}
