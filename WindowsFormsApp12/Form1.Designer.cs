namespace WindowsFormsApp12
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.listView1 = new System.Windows.Forms.ListView();
            this.mediciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adaugăMedicToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.afișeazăMediciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pretMediuConsultatieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.varstaMaximaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pacientiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adaugaPacientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.afiseazaPacientiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.varstaMediePacientiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reteteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fisiereToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adaugareInFisierTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scriereMediciInFiseirXMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(22, 121);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(263, 177);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // mediciToolStripMenuItem
            // 
            this.mediciToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adaugăMedicToolStripMenuItem,
            this.afișeazăMediciToolStripMenuItem,
            this.pretMediuConsultatieToolStripMenuItem,
            this.varstaMaximaToolStripMenuItem});
            this.mediciToolStripMenuItem.Name = "mediciToolStripMenuItem";
            this.mediciToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.mediciToolStripMenuItem.Text = "Medici";
            // 
            // adaugăMedicToolStripMenuItem
            // 
            this.adaugăMedicToolStripMenuItem.Name = "adaugăMedicToolStripMenuItem";
            this.adaugăMedicToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.adaugăMedicToolStripMenuItem.Text = "Adaugă medic";
            this.adaugăMedicToolStripMenuItem.Click += new System.EventHandler(this.adaugăMedicToolStripMenuItem_Click);
            // 
            // afișeazăMediciToolStripMenuItem
            // 
            this.afișeazăMediciToolStripMenuItem.Name = "afișeazăMediciToolStripMenuItem";
            this.afișeazăMediciToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.afișeazăMediciToolStripMenuItem.Text = "Afișează medici";
            this.afișeazăMediciToolStripMenuItem.Click += new System.EventHandler(this.afișeazăMediciToolStripMenuItem_Click);
            // 
            // pretMediuConsultatieToolStripMenuItem
            // 
            this.pretMediuConsultatieToolStripMenuItem.Name = "pretMediuConsultatieToolStripMenuItem";
            this.pretMediuConsultatieToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.pretMediuConsultatieToolStripMenuItem.Text = "Pret mediu consultatie";
            this.pretMediuConsultatieToolStripMenuItem.Click += new System.EventHandler(this.pretMediuConsultatieToolStripMenuItem_Click);
            // 
            // varstaMaximaToolStripMenuItem
            // 
            this.varstaMaximaToolStripMenuItem.Name = "varstaMaximaToolStripMenuItem";
            this.varstaMaximaToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.varstaMaximaToolStripMenuItem.Text = "Varsta maxima";
            this.varstaMaximaToolStripMenuItem.Click += new System.EventHandler(this.varstaMaximaToolStripMenuItem_Click_1);
            // 
            // pacientiToolStripMenuItem
            // 
            this.pacientiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adaugaPacientToolStripMenuItem,
            this.afiseazaPacientiToolStripMenuItem,
            this.varstaMediePacientiToolStripMenuItem});
            this.pacientiToolStripMenuItem.Name = "pacientiToolStripMenuItem";
            this.pacientiToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.pacientiToolStripMenuItem.Text = "Pacienti";
            // 
            // adaugaPacientToolStripMenuItem
            // 
            this.adaugaPacientToolStripMenuItem.Name = "adaugaPacientToolStripMenuItem";
            this.adaugaPacientToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.adaugaPacientToolStripMenuItem.Text = "Adauga pacient";
            this.adaugaPacientToolStripMenuItem.Click += new System.EventHandler(this.adaugaPacientToolStripMenuItem_Click);
            // 
            // afiseazaPacientiToolStripMenuItem
            // 
            this.afiseazaPacientiToolStripMenuItem.Name = "afiseazaPacientiToolStripMenuItem";
            this.afiseazaPacientiToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.afiseazaPacientiToolStripMenuItem.Text = "Afiseaza pacienti ";
            this.afiseazaPacientiToolStripMenuItem.Click += new System.EventHandler(this.afiseazaPacientiToolStripMenuItem_Click);
            // 
            // varstaMediePacientiToolStripMenuItem
            // 
            this.varstaMediePacientiToolStripMenuItem.Name = "varstaMediePacientiToolStripMenuItem";
            this.varstaMediePacientiToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.varstaMediePacientiToolStripMenuItem.Text = "Varsta medie pacienti";
            this.varstaMediePacientiToolStripMenuItem.Click += new System.EventHandler(this.varstaMediePacientiToolStripMenuItem_Click);
            // 
            // reteteToolStripMenuItem
            // 
            this.reteteToolStripMenuItem.Name = "reteteToolStripMenuItem";
            this.reteteToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.reteteToolStripMenuItem.Text = "Retete";
            this.reteteToolStripMenuItem.Click += new System.EventHandler(this.reteteToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mediciToolStripMenuItem,
            this.pacientiToolStripMenuItem,
            this.reteteToolStripMenuItem,
            this.fisiereToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fisiereToolStripMenuItem
            // 
            this.fisiereToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adaugareInFisierTextToolStripMenuItem,
            this.scriereMediciInFiseirXMLToolStripMenuItem});
            this.fisiereToolStripMenuItem.Name = "fisiereToolStripMenuItem";
            this.fisiereToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.fisiereToolStripMenuItem.Text = "Fisiere";
            // 
            // adaugareInFisierTextToolStripMenuItem
            // 
            this.adaugareInFisierTextToolStripMenuItem.Name = "adaugareInFisierTextToolStripMenuItem";
            this.adaugareInFisierTextToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.adaugareInFisierTextToolStripMenuItem.Text = "Citire Clienti din fisier text";
            this.adaugareInFisierTextToolStripMenuItem.Click += new System.EventHandler(this.adaugareInFisierTextToolStripMenuItem_Click);
            // 
            // scriereMediciInFiseirXMLToolStripMenuItem
            // 
            this.scriereMediciInFiseirXMLToolStripMenuItem.Name = "scriereMediciInFiseirXMLToolStripMenuItem";
            this.scriereMediciInFiseirXMLToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.scriereMediciInFiseirXMLToolStripMenuItem.Text = "Scriere Medici in fiseir XML";
            this.scriereMediciInFiseirXMLToolStripMenuItem.Click += new System.EventHandler(this.scriereMediciInFiseirXMLToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.listView1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ToolStripMenuItem mediciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adaugăMedicToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem afișeazăMediciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pacientiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reteteToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem pretMediuConsultatieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem varstaMaximaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adaugaPacientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem afiseazaPacientiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem varstaMediePacientiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fisiereToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adaugareInFisierTextToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem scriereMediciInFiseirXMLToolStripMenuItem;
    }
}

