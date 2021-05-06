using System;
using System.Collections.Generic;

namespace MagazzinoLibreria
{
    class Program
    {   
        //Magazzino
        private static Magazzino magazzino = new Magazzino();
        static void Main(string[] args)
        {
            ////Inizializzo lista libri
            //List<Libro> libri = new List<Libro>();

            ////Creiamo un libro
            //Libro libro1 = new Libro("I promessi sposi", "Manzoni");
            //Libro libro2 = new Libro("La divina commedia", "Alighieri");

            ////Aggiungiamo i libri alla lista
            //libri.Add(libro1);
            //libri.Add(libro2);

            Console.WriteLine("Gestione magazzino");

            do
            {
                Console.WriteLine("Scegli un'opzione: \n 1 Visualizzare la lista dei libri \n 2 Aggiungere un nuovo libro \n 0 Esci");
                char sceltaMenu = Console.ReadKey().KeyChar;

                //lista aggiornata
                List<Libro> listaAgg = magazzino.OttieniListaAgg();

                switch (sceltaMenu)
                {
                    case '1':
                        //Visualizzare lista
                        //Scorro sulla lista con un foreach (per es.)
                        //Per ogni libro nella lista libri, ...

                        if (listaAgg.Count > 0)
                        {
                            foreach (Libro libro in listaAgg)
                            {
                                //Visualizzare sulla console i dati dei libri
                                Console.WriteLine(libro.OttieniDati);
                            }
                        }
                        else
                            Console.WriteLine("Lista vuota");

                        break;

                    case '2':
                        //Aggiungere un nuovo libro alla lista
                        Libro nuovoLibro = magazzino.AggiungiLibro();

                        break;

                    case '0':
                        return;
                }
                continue;

            }
            while (true);
        }
    }
}
