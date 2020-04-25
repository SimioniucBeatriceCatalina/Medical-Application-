using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp12
{
    abstract class Persoana
    {
        private string nume;
        private string prenume;
        private int varsta;
        private string sex;

        public Persoana(string nume, string prenume, int varsta, string sex)
        {
            this.nume = nume;
            this.prenume = prenume;
            this.varsta = varsta;
            this.sex = sex;
        }
        public string Nume
        {
            get { return this.nume; }
            set { if (value != null) this.nume = value; }
        }
        public string Prenume
        {
            get { return this.prenume; }
            set { if (value != null) this.prenume = value; }
        }
        public int Varsta
        {
            get { return this.varsta; }
            set { if (value > 0) this.varsta = value; }
        }
        public string Sex
        {
            get { return this.sex; }
            set { if (value != null) this.sex = value; }

        }
        public abstract float met1();
    }
}
