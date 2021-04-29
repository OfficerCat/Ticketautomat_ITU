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
        private decimal Ticketpreis=2;
        private string Beschreibung="Beschreibung";
        private int Ticketnummer;
        private decimal BezahlterBetrag;
        private int Geldeingabe;
        private decimal FehlenderBetrag;
        public decimal EingabeGeld;
        //Methoden
        public decimal TicketpreisAusgeben()
        {
            return Ticketpreis;

        }
        public string TicketBeschreibungsAusgabe()
        {
            return Beschreibung;

        }
        public int Ticketnummerausgabe()
        {
            return Ticketnummer;
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
        public decimal GeldeingabeBerechnung()
        {
            FehlenderBetrag = Ticketpreis - EingabeGeld;
            return FehlenderBetrag;
        }
    }
}
