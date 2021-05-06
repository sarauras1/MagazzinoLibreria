using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagazzinoLibreria
{
    class Libro
    {
        //Costruttore
        public Libro (string titolo, string autore)
        { Titolo = titolo;
            Autore = autore;
        }

        //Proprietà: titolo, autore, categoria, disponibile, codice ISBN...
        public string Titolo { get; set; }
        public string Autore { get; set; }

        public string OttieniDati { 
            get
            {
                return ($"{Titolo}-{Autore}");
            }
        }
        
        //Esempio enum
        //public CategoriaEnum Categoria { get; set; }
    }

    //Esempio enum
    //public enum CategoriaEnum
    //{
    //    Poesia, 
    //    Cucina,
    //    Gialli
    //}
}
