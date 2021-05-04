using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ticketautomat_ITU3
{
    class Ticketautomat
    {
        //Attribute
        public static decimal Ticketpreis = 0;      
        public static string Beschreibung= "Bitte Ticket auswählen";
        private decimal BezahlterBetrag;
        private decimal FehlenderBetrag;
        //it's alot simpler to add something to a public variable
        public decimal EingabeGeld;
        //if statement does not like Methodes so i use a public variable
        public bool GenugGezahlt = false;
        //Methoden
        public decimal TicketpreisAusgeben()
        {
            return Ticketpreis;
        }
        public string TicketBeschreibungsAusgabe()
        {
            return Beschreibung;
        }
        public decimal bezahlterbetragAusgabe()
        {
            return BezahlterBetrag;
        }
        public void EingabebezahlterBetrag(int P_Bezahlbetrag)
        {
            BezahlterBetrag += P_Bezahlbetrag;
            return;
        }
        public decimal EingabegeldAusabe()
        {
            return EingabeGeld;
        }
        //Calculates the amount left to print a ticket
        public decimal GeldeingabeBerechnung()
        {
            FehlenderBetrag = Ticketpreis - EingabeGeld;
            if (EingabeGeld >= Ticketpreis)
            {
                GenugGezahlt = true;
            }
            else
            {
                GenugGezahlt = false;
            }
            return FehlenderBetrag;
        }
        //Resets the whole Programm, back to normal
        public void Reset()
        {
            Beschreibung = "Bitte Ticket auswählen";
            Ticketpreis = 0m;
        }
    }
}
