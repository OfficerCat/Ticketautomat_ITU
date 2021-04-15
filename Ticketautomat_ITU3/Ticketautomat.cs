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
        private double Ticketpreis;
        private string Beschreibung;
        private int Ticketnummer;
        private double BezahlterBetrag;

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
        public void EingabebezahlterBetrag(double P_Bezahlbetrag)
        {
            BezahlterBetrag += P_Bezahlbetrag;
            return;
        }
    }
}
