using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp12
{
    class Pacienti : Persoana, ICloneable, IComparable
    {
        private int codPacient;
        private string categorieAsigurat;




        public Pacienti(string nume, string prenume, int varsta, string sex, int codPacient, string categorieAsigurat) : base(nume, prenume, varsta, sex)
        {
            this.codPacient = codPacient;
            this.categorieAsigurat = categorieAsigurat;
        }
        public int CodPacient
        {
            get { return this.CodPacient; }
            set { if (value > 0) this.CodPacient = value; }


        }
        public string CategorieAsigurat

        {
            get { return this.CategorieAsigurat; }
            set { if (value != null) this.categorieAsigurat = value; }
        }
        public object Clone()
        {
            Pacienti p = (Pacienti)this.MemberwiseClone();
            return p;
        }
        public int CompareTo(object obj) {
            Pacienti p1 = (Pacienti)obj;
            return string.Compare(this.Nume, p1.Nume);
        }
        public override string ToString()
        {
            string mesaj = this.Nume + " " + this.Prenume + " " + this.Varsta + " " + this.Sex + " " + Environment.NewLine;
            return mesaj;
        }

        public static explicit operator int(Pacienti p){
            return p.codPacient;

            }
        public override float met1()
        {
            return this.codPacient;
        }
    }
}
