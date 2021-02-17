using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula17_02
{
    class Program
    {
        static void Main(string[] args)
        {
            int menu = 0, cont = 0;
            pilhaDinamicaLivro minha_pilha = new pilhaDinamicaLivro { Topo = null };
            Livro l = new Livro();
            
            while (true)
            {
                Console.Clear();
                Console.WriteLine("<==Biblioteca meu livro==> ");
                Console.WriteLine("1-) Inserir livro: ");
                Console.WriteLine("2-) Remover livro: ");
                Console.WriteLine("3-) Imprimir Pilha: ");
                Console.WriteLine("4-) Quantidade de elementos na pilha: ");
                Console.WriteLine("5-) Busca de Livro por titulo: ");
                menu = int.Parse(Console.ReadLine());

                switch (menu)
                {
                    case 1:
                        inserirLivro(l, minha_pilha, ref cont);
                        Console.ReadKey();
                        break;

                    case 2:
                        Console.WriteLine("Digite quantos livros voce quer remover: ");
                        int remove = int.Parse(Console.ReadLine());
                        Console.WriteLine(removerLivro(minha_pilha, remove, ref cont));
                        Console.ReadKey();
                        break;

                    case 3:
                        minha_pilha.Imprimir();
                        Console.ReadKey();
                        break;

                    case 4:
                        Console.WriteLine("A pilha tem " + cont + " elementos");
                        Console.ReadKey();
                        break;
                    
                    case 5:
                        Console.WriteLine("Digite o nome do titulo a ser encontrado: ");
                        string titulo = Console.ReadLine();
                        Console.WriteLine(minha_pilha.procura(titulo));
                        Console.ReadKey();

                        break;

                }
            }
        }

        static void inserirLivro(Livro l, pilhaDinamicaLivro p, ref int cont)
        {
            Console.WriteLine("\nTitulo do livro: ");
            String titulo = Console.ReadLine();
            Console.WriteLine("Autor: ");
            String autor = Console.ReadLine();
            Console.WriteLine("Numero ISBN: ");
            int isbn = int.Parse(Console.ReadLine());

            l = new Livro
            {
                Titulo = titulo,
                Autor = autor,
                Isbn = isbn,

            };
            p.Push(l);
            cont++;
        }

        static string removerLivro(pilhaDinamicaLivro p, int remove, ref int cont)
        {
            for (int i=0; i < remove; i++)
            {
                if (remove > cont)
                {
                    return "Operação não realizada\nValor maior que a pilha";
                }
                cont--;
                p.Pop();
                
            }
            return "Operação realizada\n";
        }

    }
}
