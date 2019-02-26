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
            request.AddHeader("postman-token", "4ca0cc13-c7f3-42c7-b3cc-e6e24dc0045a");
            request.AddHeader("cache-control", "no-cache");
            IRestResponse response = client.Execute(request);

            Console.WriteLine(response.Content);
            Console.ReadKey();
        }
    }
}
