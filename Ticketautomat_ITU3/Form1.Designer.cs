
namespace Ticketautomat_ITU3
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTicketbezeichnung = new System.Windows.Forms.Label();
            this.txtTicketbezeichnung = new System.Windows.Forms.TextBox();
            this.btnTicketanzeigen = new System.Windows.Forms.Button();
            this.txtTicketpreis = new System.Windows.Forms.TextBox();
            this.lblticketpreis = new System.Windows.Forms.Label();
            this.btn10c = new System.Windows.Forms.Button();
            this.btn20c = new System.Windows.Forms.Button();
            this.btn50c = new System.Windows.Forms.Button();
            this.btn1E = new System.Windows.Forms.Button();
            this.btn2E = new System.Windows.Forms.Button();
            this.btn5E = new System.Windows.Forms.Button();
            this.btn10E = new System.Windows.Forms.Button();
            this.btn20E = new System.Windows.Forms.Button();
            this.txtRestlicherBetrag = new System.Windows.Forms.TextBox();
            this.lblrestlicherbetrag = new System.Windows.Forms.Label();
            this.btnAbbruch = new System.Windows.Forms.Button();
            this.txtEingeworfenesGeld = new System.Windows.Forms.TextBox();
            this.lblEingeworfenesGeld = new System.Windows.Forms.Label();
            this.txtRückgeld = new System.Windows.Forms.TextBox();
            this.lblRückgeld = new System.Windows.Forms.Label();
            this.lblTicketDrucken = new System.Windows.Forms.Label();
            this.lblNichtGenug = new System.Windows.Forms.Label();
            this.btnTicket1 = new System.Windows.Forms.Button();
            this.btnTicket2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTicketbezeichnung
            // 
            this.lblTicketbezeichnung.AutoSize = true;
            this.lblTicketbezeichnung.Font = new System.Drawing.Font("Bernard MT Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTicketbezeichnung.Location = new System.Drawing.Point(17, 43);
            this.lblTicketbezeichnung.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTicketbezeichnung.Name = "lblTicketbezeichnung";
            this.lblTicketbezeichnung.Size = new System.Drawing.Size(115, 18);
            this.lblTicketbezeichnung.TabIndex = 0;
            this.lblTicketbezeichnung.Text = "Ticketbezeichnung";
            this.lblTicketbezeichnung.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtTicketbezeichnung
            // 
            this.txtTicketbezeichnung.Font = new System.Drawing.Font("Bernard MT Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTicketbezeichnung.Location = new System.Drawing.Point(20, 63);
            this.txtTicketbezeichnung.Margin = new System.Windows.Forms.Padding(2);
            this.txtTicketbezeichnung.Name = "txtTicketbezeichnung";
            this.txtTicketbezeichnung.Size = new System.Drawing.Size(193, 26);
            this.txtTicketbezeichnung.TabIndex = 1;
            this.txtTicketbezeichnung.TextChanged += new System.EventHandler(this.txtTicketbezeichnung_TextChanged);
            // 
            // btnTicketanzeigen
            // 
            this.btnTicketanzeigen.Location = new System.Drawing.Point(20, 399);
            this.btnTicketanzeigen.Margin = new System.Windows.Forms.Padding(2);
            this.btnTicketanzeigen.Name = "btnTicketanzeigen";
            this.btnTicketanzeigen.Size = new System.Drawing.Size(137, 43);
            this.btnTicketanzeigen.TabIndex = 2;
            this.btnTicketanzeigen.Text = "Ticket anzeigen";
            this.btnTicketanzeigen.UseVisualStyleBackColor = true;
            this.btnTicketanzeigen.Click += new System.EventHandler(this.btnTicketanzeigen_Click);
            // 
            // txtTicketpreis
            // 
            this.txtTicketpreis.Font = new System.Drawing.Font("Bernard MT Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTicketpreis.Location = new System.Drawing.Point(422, 63);
            this.txtTicketpreis.Name = "txtTicketpreis";
            this.txtTicketpreis.Size = new System.Drawing.Size(186, 26);
            this.txtTicketpreis.TabIndex = 3;
            // 
            // lblticketpreis
            // 
            this.lblticketpreis.AutoSize = true;
            this.lblticketpreis.Font = new System.Drawing.Font("Bernard MT Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblticketpreis.Location = new System.Drawing.Point(419, 42);
            this.lblticketpreis.Name = "lblticketpreis";
            this.lblticketpreis.Size = new System.Drawing.Size(72, 18);
            this.lblticketpreis.TabIndex = 4;
            this.lblticketpreis.Text = "Ticketpreis";
            this.lblticketpreis.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // btn10c
            // 
            this.btn10c.Font = new System.Drawing.Font("Bernard MT Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn10c.Location = new System.Drawing.Point(422, 157);
            this.btn10c.Name = "btn10c";
            this.btn10c.Size = new System.Drawing.Size(42, 43);
            this.btn10c.TabIndex = 5;
            this.btn10c.Text = "10 c";
            this.btn10c.UseVisualStyleBackColor = true;
            this.btn10c.Click += new System.EventHandler(this.btn10c_Click);
            // 
            // btn20c
            // 
            this.btn20c.Font = new System.Drawing.Font("Bernard MT Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn20c.Location = new System.Drawing.Point(470, 157);
            this.btn20c.Name = "btn20c";
            this.btn20c.Size = new System.Drawing.Size(42, 43);
            this.btn20c.TabIndex = 6;
            this.btn20c.Text = "20 c";
            this.btn20c.UseVisualStyleBackColor = true;
            this.btn20c.Click += new System.EventHandler(this.btn20c_Click);
            // 
            // btn50c
            // 
            this.btn50c.Font = new System.Drawing.Font("Bernard MT Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn50c.Location = new System.Drawing.Point(518, 157);
            this.btn50c.Name = "btn50c";
            this.btn50c.Size = new System.Drawing.Size(42, 43);
            this.btn50c.TabIndex = 7;
            this.btn50c.Text = "50 c";
            this.btn50c.UseVisualStyleBackColor = true;
            this.btn50c.Click += new System.EventHandler(this.btn50c_Click);
            // 
            // btn1E
            // 
            this.btn1E.Font = new System.Drawing.Font("Bernard MT Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1E.Location = new System.Drawing.Point(566, 157);
            this.btn1E.Name = "btn1E";
            this.btn1E.Size = new System.Drawing.Size(42, 43);
            this.btn1E.TabIndex = 8;
            this.btn1E.Text = "1 €";
            this.btn1E.UseVisualStyleBackColor = true;
            this.btn1E.Click += new System.EventHandler(this.btn1E_Click);
            // 
            // btn2E
            // 
            this.btn2E.Font = new System.Drawing.Font("Bernard MT Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2E.Location = new System.Drawing.Point(422, 206);
            this.btn2E.Name = "btn2E";
            this.btn2E.Size = new System.Drawing.Size(42, 43);
            this.btn2E.TabIndex = 9;
            this.btn2E.Text = "2 €";
            this.btn2E.UseVisualStyleBackColor = true;
            this.btn2E.Click += new System.EventHandler(this.btn2E_Click);
            // 
            // btn5E
            // 
            this.btn5E.Font = new System.Drawing.Font("Bernard MT Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5E.Location = new System.Drawing.Point(470, 206);
            this.btn5E.Name = "btn5E";
            this.btn5E.Size = new System.Drawing.Size(42, 43);
            this.btn5E.TabIndex = 10;
            this.btn5E.Text = "5 €";
            this.btn5E.UseVisualStyleBackColor = true;
            this.btn5E.Click += new System.EventHandler(this.btn5E_Click);
            // 
            // btn10E
            // 
            this.btn10E.Font = new System.Drawing.Font("Bernard MT Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn10E.Location = new System.Drawing.Point(518, 206);
            this.btn10E.Name = "btn10E";
            this.btn10E.Size = new System.Drawing.Size(42, 43);
            this.btn10E.TabIndex = 11;
            this.btn10E.Text = "10 €";
            this.btn10E.UseVisualStyleBackColor = true;
            this.btn10E.Click += new System.EventHandler(this.btn10E_Click);
            // 
            // btn20E
            // 
            this.btn20E.Font = new System.Drawing.Font("Bernard MT Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn20E.Location = new System.Drawing.Point(566, 206);
            this.btn20E.Name = "btn20E";
            this.btn20E.Size = new System.Drawing.Size(42, 43);
            this.btn20E.TabIndex = 12;
            this.btn20E.Text = "20 €";
            this.btn20E.UseVisualStyleBackColor = true;
            this.btn20E.Click += new System.EventHandler(this.btn20E_Click);
            // 
            // txtRestlicherBetrag
            // 
            this.txtRestlicherBetrag.Font = new System.Drawing.Font("Bernard MT Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRestlicherBetrag.Location = new System.Drawing.Point(422, 125);
            this.txtRestlicherBetrag.Name = "txtRestlicherBetrag";
            this.txtRestlicherBetrag.Size = new System.Drawing.Size(186, 26);
            this.txtRestlicherBetrag.TabIndex = 13;
            // 
            // lblrestlicherbetrag
            // 
            this.lblrestlicherbetrag.AutoSize = true;
            this.lblrestlicherbetrag.Font = new System.Drawing.Font("Bernard MT Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblrestlicherbetrag.Location = new System.Drawing.Point(419, 104);
            this.lblrestlicherbetrag.Name = "lblrestlicherbetrag";
            this.lblrestlicherbetrag.Size = new System.Drawing.Size(107, 18);
            this.lblrestlicherbetrag.TabIndex = 14;
            this.lblrestlicherbetrag.Text = "Restlicher Betrag";
            // 
            // btnAbbruch
            // 
            this.btnAbbruch.Location = new System.Drawing.Point(518, 399);
            this.btnAbbruch.Margin = new System.Windows.Forms.Padding(2);
            this.btnAbbruch.Name = "btnAbbruch";
            this.btnAbbruch.Size = new System.Drawing.Size(137, 43);
            this.btnAbbruch.TabIndex = 15;
            this.btnAbbruch.Text = "Vorgang Abbrechen";
            this.btnAbbruch.UseVisualStyleBackColor = true;
            this.btnAbbruch.Click += new System.EventHandler(this.btnAbbruch_Click);
            // 
            // txtEingeworfenesGeld
            // 
            this.txtEingeworfenesGeld.Font = new System.Drawing.Font("Bernard MT Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEingeworfenesGeld.Location = new System.Drawing.Point(18, 125);
            this.txtEingeworfenesGeld.Name = "txtEingeworfenesGeld";
            this.txtEingeworfenesGeld.Size = new System.Drawing.Size(193, 26);
            this.txtEingeworfenesGeld.TabIndex = 16;
            // 
            // lblEingeworfenesGeld
            // 
            this.lblEingeworfenesGeld.AutoSize = true;
            this.lblEingeworfenesGeld.Font = new System.Drawing.Font("Bernard MT Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEingeworfenesGeld.Location = new System.Drawing.Point(17, 104);
            this.lblEingeworfenesGeld.Name = "lblEingeworfenesGeld";
            this.lblEingeworfenesGeld.Size = new System.Drawing.Size(121, 18);
            this.lblEingeworfenesGeld.TabIndex = 17;
            this.lblEingeworfenesGeld.Text = "Eingeworfenes Geld";
            // 
            // txtRückgeld
            // 
            this.txtRückgeld.Location = new System.Drawing.Point(422, 285);
            this.txtRückgeld.Name = "txtRückgeld";
            this.txtRückgeld.Size = new System.Drawing.Size(54, 20);
            this.txtRückgeld.TabIndex = 18;
            // 
            // lblRückgeld
            // 
            this.lblRückgeld.AutoSize = true;
            this.lblRückgeld.Font = new System.Drawing.Font("Bernard MT Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRückgeld.Location = new System.Drawing.Point(419, 264);
            this.lblRückgeld.Name = "lblRückgeld";
            this.lblRückgeld.Size = new System.Drawing.Size(62, 18);
            this.lblRückgeld.TabIndex = 19;
            this.lblRückgeld.Text = "Rückgeld";
            // 
            // lblTicketDrucken
            // 
            this.lblTicketDrucken.AutoSize = true;
            this.lblTicketDrucken.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblTicketDrucken.Font = new System.Drawing.Font("Bernard MT Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTicketDrucken.Location = new System.Drawing.Point(12, 285);
            this.lblTicketDrucken.Name = "lblTicketDrucken";
            this.lblTicketDrucken.Size = new System.Drawing.Size(235, 31);
            this.lblTicketDrucken.TabIndex = 20;
            this.lblTicketDrucken.Text = "Ticket wird gedruckt ";
            this.lblTicketDrucken.Visible = false;
            // 
            // lblNichtGenug
            // 
            this.lblNichtGenug.AutoSize = true;
            this.lblNichtGenug.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblNichtGenug.Font = new System.Drawing.Font("Bernard MT Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNichtGenug.Location = new System.Drawing.Point(12, 285);
            this.lblNichtGenug.Name = "lblNichtGenug";
            this.lblNichtGenug.Size = new System.Drawing.Size(320, 31);
            this.lblNichtGenug.TabIndex = 21;
            this.lblNichtGenug.Text = "Nicht genug Geld eingeworfen";
            // 
            // btnTicket1
            // 
            this.btnTicket1.Font = new System.Drawing.Font("Bernard MT Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTicket1.Location = new System.Drawing.Point(20, 157);
            this.btnTicket1.Name = "btnTicket1";
            this.btnTicket1.Size = new System.Drawing.Size(75, 26);
            this.btnTicket1.TabIndex = 22;
            this.btnTicket1.Text = "Ticket 1";
            this.btnTicket1.UseVisualStyleBackColor = true;
            this.btnTicket1.Click += new System.EventHandler(this.btnTicket1_Click);
            // 
            // btnTicket2
            // 
            this.btnTicket2.Font = new System.Drawing.Font("Bernard MT Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTicket2.Location = new System.Drawing.Point(20, 189);
            this.btnTicket2.Name = "btnTicket2";
            this.btnTicket2.Size = new System.Drawing.Size(75, 26);
            this.btnTicket2.TabIndex = 23;
            this.btnTicket2.Text = "Ticket 2";
            this.btnTicket2.UseVisualStyleBackColor = true;
            this.btnTicket2.Click += new System.EventHandler(this.btnTicket2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 453);
            this.Controls.Add(this.btnTicket2);
            this.Controls.Add(this.btnTicket1);
            this.Controls.Add(this.lblNichtGenug);
            this.Controls.Add(this.lblTicketDrucken);
            this.Controls.Add(this.lblRückgeld);
            this.Controls.Add(this.txtRückgeld);
            this.Controls.Add(this.lblEingeworfenesGeld);
            this.Controls.Add(this.txtEingeworfenesGeld);
            this.Controls.Add(this.btnAbbruch);
            this.Controls.Add(this.lblrestlicherbetrag);
            this.Controls.Add(this.txtRestlicherBetrag);
            this.Controls.Add(this.btn20E);
            this.Controls.Add(this.btn10E);
            this.Controls.Add(this.btn5E);
            this.Controls.Add(this.btn2E);
            this.Controls.Add(this.btn1E);
            this.Controls.Add(this.btn50c);
            this.Controls.Add(this.btn20c);
            this.Controls.Add(this.btn10c);
            this.Controls.Add(this.lblticketpreis);
            this.Controls.Add(this.txtTicketpreis);
            this.Controls.Add(this.btnTicketanzeigen);
            this.Controls.Add(this.txtTicketbezeichnung);
            this.Controls.Add(this.lblTicketbezeichnung);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTicketbezeichnung;
        private System.Windows.Forms.TextBox txtTicketbezeichnung;
        private System.Windows.Forms.Button btnTicketanzeigen;
        private System.Windows.Forms.TextBox txtTicketpreis;
        private System.Windows.Forms.Label lblticketpreis;
        private System.Windows.Forms.Button btn10c;
        private System.Windows.Forms.Button btn20c;
        private System.Windows.Forms.Button btn50c;
        private System.Windows.Forms.Button btn1E;
        private System.Windows.Forms.Button btn2E;
        private System.Windows.Forms.Button btn5E;
        private System.Windows.Forms.Button btn10E;
        private System.Windows.Forms.Button btn20E;
        private System.Windows.Forms.TextBox txtRestlicherBetrag;
        private System.Windows.Forms.Label lblrestlicherbetrag;
        private System.Windows.Forms.Button btnAbbruch;
        private System.Windows.Forms.TextBox txtEingeworfenesGeld;
        private System.Windows.Forms.Label lblEingeworfenesGeld;
        private System.Windows.Forms.TextBox txtRückgeld;
        private System.Windows.Forms.Label lblRückgeld;
        private System.Windows.Forms.Label lblTicketDrucken;
        private System.Windows.Forms.Label lblNichtGenug;
        private System.Windows.Forms.Button btnTicket1;
        private System.Windows.Forms.Button btnTicket2;
    }
}

