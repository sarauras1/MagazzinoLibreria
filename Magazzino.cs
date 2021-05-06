using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagazzinoLibreria
{
    class Magazzino
    {
        //Inizializzo lista
        List<Libro> libriMagazzino = new List<Libro>();

        //Aggiungi libro  
        public Libro AggiungiLibro()
        {
            Console.WriteLine("Inserisci il titolo: ");
            string titolo = Console.ReadLine(); //ciò che scrive l'utente finisce in titolo

            Console.WriteLine("Inserisci l'autore: ");
            string autore = Console.ReadLine();

            //Creo nuovo
            Libro nuovoLibro = new Libro(titolo, autore);

            //Aggiungo libro alla lista libri
            libriMagazzino.Add(nuovoLibro);

            return nuovoLibro;
        }

        //Per recuperare lista di libri aggiornata
        public List<Libro> OttieniListaAgg()
        {
            return libriMagazzino;
        }

    }
}
