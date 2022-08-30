using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula2_6322063
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Filme fi = new Filme();
            Entrada en = new Entrada();

            Console.Write(">----------------------------<");
            Console.Write("Qual o nome do filme? : ");
            fi.SetTitulo(Console.ReadLine());
            Console.Write("Qual a sinopse do filme? : ");
            fi.SetSinopse(Console.ReadLine());
            Console.Write("Qual o gênero do filme? : ");
            fi.SetGenero(Console.ReadLine());
            Console.Write("Qual a classificação indicativa? : ");
            fi.SetClassif(Convert.ToInt32(Console.ReadLine()));
            Console.Write(">----------------------------<");
            Console.Write("\nValor da entrada? : ");
            en.SetValor(Convert.ToDouble(Console.ReadLine()));
            Console.Write("Qual o número da poltrona? : ");
            en.SetPoltrona(Console.ReadLine());
            Console.Write("Data do filme (DD/MM/AA)? : ");
            en.SetData(Console.ReadLine());
            Console.Write("Qual a horário da sessão? : ");
            en.SetHora(Console.ReadLine());

            Console.WriteLine("\n>----------INGRESSO----------<");
            Console.WriteLine("Titulo: " + fi.GetTitulo() + "\nSinopse: " + fi.GetSinopse() + "\nGênero: " + fi.GetGenero() + "\nClassificação indicativa: " + fi.GetClassif());
            Console.WriteLine("\nValor da entrada: " + en.GetValor().ToString("C") + "\nNúmero da poltrona: " + en.GetPoltrona() + "\nData: " + en.GetDta() + "\nHorário: " + en.GetHora());
            Console.WriteLine(">----------------------------<");
            Console.ReadKey();
        }
    }
}
