using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula17_02
{
    class pilhaDinamicaLivro
    {
        public Livro Topo { get; set; }

        public void Push(Livro aux)
        {
            //if (vazia())// verifica se a pilha está vazia
            //{
            //    Topo = aux;
            //}
            //else
            //{
            aux.Anterior = Topo;
            Topo = aux;
            // }
            Console.WriteLine("Elemento inserido com sucesso");
        }

        private bool Vazia()
        {
            if (Topo == null)
                return true;

            return false;
        }

        public void Imprimir()
        {
            if (Vazia())
            {
                Console.WriteLine("Impossível Imprimir! Pilha Vazia!");
                Console.ReadKey();
            }
            else
            {
                Livro aux = Topo;
                Console.WriteLine("Os elementos na pilha são:");
                do
                {
                    Console.WriteLine(aux.ToString());
                    aux = aux.Anterior;
                } while (aux != null);
                Console.WriteLine(">>>FIM<<");
            }
        }

        public void Pop()
        {
            if (Vazia())
            {
                Console.WriteLine("Impossivel Remover");
                Console.ReadKey();
            }

            else
            {
                Topo = Topo.Anterior;
                Console.WriteLine("Elemento Removido");
            }
        }

        public string procura(string procuraTitulo)
        {
                     
            if (Vazia())
            {
                Console.WriteLine("Impossível procurar em Pilha Vazia!");
                Console.ReadKey();
            }
            else
            {
                Livro aux = Topo;
                Console.WriteLine("\nProcurando...\n");
                do
                {
                    
                    if (procuraTitulo == aux.Titulo)
                    {
                        Console.WriteLine("<<--Livro Encontrado--->>");
                        return aux.ToString();
                    }
                     
                    aux = aux.Anterior;
                } while (aux != null);
            }

            return "Livro não encontrado";
        }
    }
}
