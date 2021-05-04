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
        Tickets ticket = new Tickets();
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

        }
        //adds 10c as payed money.
        private void btn10c_Click(object sender, EventArgs e)
        {
            einTicket.EingabeGeld += 0.10m;
            einTicket.GeldeingabeBerechnung();
            txtRestlicherBetrag.Text = einTicket.GeldeingabeBerechnung().ToString();
            if  (einTicket.GenugGezahlt == true)
            {
                lblNichtGenug.Visible = false;
                lblTicketDrucken.Visible = true;
            }
            else
            {
                lblNichtGenug.Visible = true;
                lblTicketDrucken.Visible = false;
            }
        }
        //adds 20c as payed money.
        private void btn20c_Click(object sender, EventArgs e)
        {
            einTicket.EingabeGeld = einTicket.EingabeGeld + 0.20m;
            einTicket.GeldeingabeBerechnung();
            txtRestlicherBetrag.Text = einTicket.GeldeingabeBerechnung().ToString();
            if (einTicket.GenugGezahlt == true)
            {
                lblNichtGenug.Visible = false;
                lblTicketDrucken.Visible = true;
            }
            else
            {
                lblNichtGenug.Visible = true;
                lblTicketDrucken.Visible = false;
            }
        }
        //adds 50c as payed money.
        private void btn50c_Click(object sender, EventArgs e)
        {
            einTicket.EingabeGeld = einTicket.EingabeGeld + 0.50m;
            einTicket.GeldeingabeBerechnung();
            txtRestlicherBetrag.Text = einTicket.GeldeingabeBerechnung().ToString();
            if (einTicket.GenugGezahlt == true)
            {
                lblNichtGenug.Visible = false;
                lblTicketDrucken.Visible = true;
            }
            else
            {
                lblNichtGenug.Visible = true;
                lblTicketDrucken.Visible = false;
            }
        }
        //adds 1€ as payed money.
        private void btn1E_Click(object sender, EventArgs e)
        {
            einTicket.EingabeGeld = einTicket.EingabeGeld + 1.00m;
            einTicket.GeldeingabeBerechnung();
            txtRestlicherBetrag.Text = einTicket.GeldeingabeBerechnung().ToString();
            if (einTicket.GenugGezahlt == true)
            {
                lblNichtGenug.Visible = false;
                lblTicketDrucken.Visible = true;
            }
            else
            {
                lblNichtGenug.Visible = true;
                lblTicketDrucken.Visible = false;
            }
        }

        private void btn2E_Click(object sender, EventArgs e)
        {

        }

        private void btn5E_Click(object sender, EventArgs e)
        {

        }

        private void btn10E_Click(object sender, EventArgs e)
        {

        }

        private void btn20E_Click(object sender, EventArgs e)
        {

        }

        private void btnAbbruch_Click(object sender, EventArgs e)
        {
           
        }

        private void btnTicket1_Click(object sender, EventArgs e)
        {
            ticket.Ticket1();
            //Show ticketdescription
            txtTicketbezeichnung.Text = einTicket.TicketBeschreibungsAusgabe();
            txtTicketpreis.Text = einTicket.TicketpreisAusgeben().ToString();

        }

        private void btnTicket2_Click(object sender, EventArgs e)
        {

        }
    }
}
