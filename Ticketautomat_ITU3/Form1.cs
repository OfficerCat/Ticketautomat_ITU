using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ticketautomat_ITU3
{
    public partial class Form1 : Form
    {
        //veriablen
        
        Ticketautomat einTicket = new Ticketautomat();
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtTicketbezeichnung_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnTicketanzeigen_Click(object sender, EventArgs e)
        {
            //Auf der GUI die Ticketbezeichnung anzeigen.
            txtTicketbezeichnung.Text = einTicket.TicketBeschreibungsAusgabe();
            txtTicketpreis.Text = einTicket.TicketpreisAusgeben().ToString();

        }
        //10c
        private void btn10c_Click(object sender, EventArgs e)
        {
            einTicket.EingabeGeld = einTicket.EingabeGeld +0.10;
            einTicket.GeldeingabeBerechnung();
            txtRestlicherBetrag.Text = einTicket.GeldeingabeBerechnung().ToString();
        }
    }
}
