using System;

//Istruzione per utilizzare i tipi generici
using System.Collections.Generic;

namespace ModelloSimulazionePS
{
    //Classe del flusso principale del programma
    class Program
    {
        static void Main(string[] args)
        {
            InizializzazioneVariabili();
            
            int tre = Costanti.TempoGestioneB;
            Console.WriteLine("Hello World!");
            Console.ReadLine();
        }

        private static void InizializzazioneVariabili()
        {
            List<Paziente> ListaPzInArrivo = new List<Paziente>();
            List<Paziente> ListaPzInAttesa = new List<Paziente>();
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
        List<Paziente> PzInCarico = new List<Paziente>();
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