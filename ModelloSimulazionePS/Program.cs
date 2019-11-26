using System;
using System.IO;

//Istruzione per utilizzare i tipi generici
using System.Collections.Generic;

namespace ModelloSimulazionePS
{
    //Classe del flusso principale del programma
    class Program
    {
        static void Main(string[] args)
        {
            //Inizializzazione delle variabili della simulazione
            InizializzazioneVariabili();

            //StreamReader streamReader = new StreamReader("risultatoTesto.txt");

            List<string> stringe = new List<string>();
            stringe.Add("uno");
            stringe.Add("duer");

            //string stringa = "";
            //stringa = streamReader.ReadLine();
            //string[] lines = { "First line", "Second line", "Third line" };
            //System.IO.File.WriteAllLines(@"C:\Users\cesco\Source\repos\SimulazionePSRep\ModelloSimulazionePS\risultatoTesto.txt", lines);

            //Scrive il contenuto della lista (ogni elemento in una riga nuova) nel file messo nel percorso (si deve specificare tutto il percorso
            //se il file non esiste viene creato. tutto quello è scritto viene sovrascitto
            System.IO.File.WriteAllLines(@"C:\Users\cesco\Source\repos\SimulazionePSRep\ModelloSimulazionePS\risultatoTesgto.txt", stringe);



            //int tre = Costanti.TempoGestioneB;
            //Console.WriteLine(stringa);
            Console.ReadLine();
        }

        //Metodo per l'inizializzazione delle variabili usate nella simulazione
        private static void InizializzazioneVariabili()
        {
            Dictionary<int, Paziente> ListaPzInArrivo = new Dictionary<int, Paziente>();
            Dictionary<int, Paziente> ListaPzInAttesa = new Dictionary<int, Paziente>();
            DateTime orarioAttuale = DateTime.Parse("01/01/2018 00:00");
            List<ElementoLista> listaStampaPzAttesa = new List<ElementoLista>();
            List<ElementoLista> listaStampaPzGestione = new List<ElementoLista>();
            List<Medico> ListaMedici = new List<Medico>();
        }
    }

    //Classe che modella un medico
    class Medico
    {
        char tipologia; //'B' 'R'
        bool occupato = false;
        Dictionary<int, Paziente> PzInCarico = new Dictionary<int, Paziente>();
        DateTime orarioFineOccupazione = new DateTime();
    }

    //Classe che modella un paziente
    class Paziente
    {
        char codice; //'B' 'V' 'G' 'R'
        DateTime dataIngresso = new DateTime();
        DateTime dataGestione = new DateTime();
        DateTime dataUscita = new DateTime();
        
        bool dimissibile()
        {
            return false;
        }
    }

    //Classe che modella gli elementi nelle liste di stampa
    class ElementoLista
    {
        DateTime orario = new DateTime();
        int numeroB = 0;
        int numeroV = 0;
        int numeroG = 0;
        int numeroR = 0;

        int numeroTotali()
        {
            return 0;
        }
    }
}