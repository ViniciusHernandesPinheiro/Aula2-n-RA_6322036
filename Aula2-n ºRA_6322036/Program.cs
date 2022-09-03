using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula2_n_ºRA_6322036
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // RA:6322036
            // Vinícius Hernandes Pinheiro

            string titulo, sinopse, genero, classificacao;

            Filme caracteristicas = new Filme();
            Entrada ticket = new Entrada();

            Console.Write("Digite o titulo do filme: ");
            titulo = Console.ReadLine();

            Console.Write("Digite a sinopse do filme: ");
            sinopse = Console.ReadLine();

            Console.Write("Digite o gênero do filme: ");
            genero = Console.ReadLine();

            Console.Write("Digite a classificação etária do filme : ");
            classificacao = Console.ReadLine();

            Console.Write("Digite o valor do ingresso: ");
            ticket.SetValor(Convert.ToDouble(Console.ReadLine()));

            Console.Write("Digite o N° da poltrona: ");
            ticket.SetPoltrona(Console.ReadLine());

            Console.Write("Digite a data e hora da sessão(dd/mm/aaaa hh:mm:ss): ");
            ticket.SetHorario(Convert.ToDateTime(Console.ReadLine()));

            caracteristicas.Receber(titulo, sinopse, genero, classificacao); 
            Console.WriteLine(caracteristicas.Mostrar());

            Console.WriteLine("\nValor: " + ticket.GetValor().ToString("C") + "\nN° da poltrona: " + ticket.GetPoltronar() + "\nHorário: " + ticket.GetHorario());

            Console.ReadKey();
        }
    }
}
