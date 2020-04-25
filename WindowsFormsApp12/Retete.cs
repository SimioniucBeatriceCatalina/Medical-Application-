using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp12
{
    class Retete 
    {
        private int codRetete;
        private Medici medic;
        private Pacienti pacient;
        string diagnostic;
        private string data;

        public Retete(int codReteta, Medici medic, Pacienti pacient, string diagnostic, string data)
        {
            this.codRetete = codReteta;
            this.medic = medic;
            this.pacient = pacient;
            this.diagnostic = diagnostic;
            this.data = data;
        }
        public int CodReteta
        {
            get { return this.codRetete; }
            set { if (value > 0) this.CodReteta = value; }
        }
        public Medici Medic
        {
            get { return this.medic; }
            set { if (value != null) this.medic = value; }
        }
        public Pacienti Pacient
        {
            get { return this.pacient; }
            set { if (value != null) this.pacient = value; }

        }
        public string Diagnostic
        {
            get { return this.diagnostic; }
            set { if (value != null) this.diagnostic = value; }
        }
        public string Data
        {
            get { return this.data; }
            set { if (value != null) this.data = value; }
        }
        public override string ToString()
        {
            return this.medic.Nume + " " + this.pacient.Nume + " " + this.diagnostic + " " + this.data;
        }
       

    }
}
