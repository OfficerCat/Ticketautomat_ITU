
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
            this.SuspendLayout();
            // 
            // lblTicketbezeichnung
            // 
            this.lblTicketbezeichnung.AutoSize = true;
            this.lblTicketbezeichnung.Location = new System.Drawing.Point(17, 20);
            this.lblTicketbezeichnung.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTicketbezeichnung.Name = "lblTicketbezeichnung";
            this.lblTicketbezeichnung.Size = new System.Drawing.Size(98, 13);
            this.lblTicketbezeichnung.TabIndex = 0;
            this.lblTicketbezeichnung.Text = "Ticketbezeichnung";
            this.lblTicketbezeichnung.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtTicketbezeichnung
            // 
            this.txtTicketbezeichnung.Location = new System.Drawing.Point(20, 63);
            this.txtTicketbezeichnung.Margin = new System.Windows.Forms.Padding(2);
            this.txtTicketbezeichnung.Name = "txtTicketbezeichnung";
            this.txtTicketbezeichnung.Size = new System.Drawing.Size(199, 20);
            this.txtTicketbezeichnung.TabIndex = 1;
            this.txtTicketbezeichnung.TextChanged += new System.EventHandler(this.txtTicketbezeichnung_TextChanged);
            // 
            // btnTicketanzeigen
            // 
            this.btnTicketanzeigen.Location = new System.Drawing.Point(20, 110);
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
            this.txtTicketpreis.Location = new System.Drawing.Point(293, 63);
            this.txtTicketpreis.Name = "txtTicketpreis";
            this.txtTicketpreis.Size = new System.Drawing.Size(148, 20);
            this.txtTicketpreis.TabIndex = 3;
            // 
            // lblticketpreis
            // 
            this.lblticketpreis.AutoSize = true;
            this.lblticketpreis.Location = new System.Drawing.Point(290, 20);
            this.lblticketpreis.Name = "lblticketpreis";
            this.lblticketpreis.Size = new System.Drawing.Size(59, 13);
            this.lblticketpreis.TabIndex = 4;
            this.lblticketpreis.Text = "Ticketpreis";
            this.lblticketpreis.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 454);
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
    }
}

