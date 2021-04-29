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
        private double Ticketpreis=2;
        private string Beschreibung="Beschreibung";
        private int Ticketnummer;
        private double BezahlterBetrag;
        private int Geldeingabe;
        private double FehlenderBetrag;
        public double EingabeGeld;
        //Methoden
        public double TicketpreisAusgeben()
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
        public double bezahlterbetragAusgabe()
        {
            return BezahlterBetrag;
        }
        public void EingabebezahlterBetrag(int P_Bezahlbetrag)
        {
            BezahlterBetrag += P_Bezahlbetrag;
            return;
        }
        public double EingabegeldAusabe()
        {
            return EingabeGeld;
        }
        public double GeldeingabeBerechnung()
        {
            FehlenderBetrag = Ticketpreis - EingabeGeld;
            return FehlenderBetrag;
        }
    }
}
