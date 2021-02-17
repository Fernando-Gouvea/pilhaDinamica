using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula17_02
{
    class Livro
    {
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public int Isbn { get; set; }
        public Livro Anterior { get; set; }

        public override string ToString()
        {
            return "\n<<<Dados do livro>>>" +
                "\nTitulo: "+Titulo+
                "\nAutor: "+Autor+
                "\nISBN: "+ Isbn;
        }

    }
}
