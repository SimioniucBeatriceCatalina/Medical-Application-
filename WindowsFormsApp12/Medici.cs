using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp12
{
    class Medici : Persoana,ICloneable,IComparable,IVarsta
    {
        private int codMedic;
        private string specializare;
        private float pretConsultatie;
        private Pacienti[] vectorPacienti;

        public Medici(string nume, string prenume, int varsta, string sex, int codMedic, string specializare, float pretConsultatie,Pacienti[] vectorPacienti):base(nume,prenume,varsta ,sex)
        {
            this.codMedic = codMedic;
            this.specializare = specializare;
            this.pretConsultatie = pretConsultatie;
            for(int i=0;i<vectorPacienti.Length;i++)
                this.vectorPacienti[i]=(Pacienti)vectorPacienti[i].Clone();

        }
        public int CodMedic
        {
            get { return this.codMedic; }
            set { if (value > 0) this.codMedic = value; }
        }
        public string Specializare
        {
            get { return this.specializare; }
            set { if (value != null) this.specializare = value; }
        }
        public float PretConsultatie
        {
            get { return this.PretConsultatie; }
            set { if (value > 0) this.PretConsultatie = value; }
        }
        public Pacienti[] VectorPacienti
        {
            get { return this.vectorPacienti; }
            set { if (value != null) this.vectorPacienti = value; }
        }

        public override string ToString()
        {
            return "Medicul" + this.Nume + " " + this.Prenume + "are specializarea" + this.specializare + " " + "si pretul consulataiei" + this.PretConsultatie;
        }
        public object Clone()
        {
            Medici m = (Medici)this.MemberwiseClone();
            return m;
        }
        public int CompareTo(object obj)
        {
            Medici m1 = (Medici)obj;
            if ((this.specializare).CompareTo(m1.specializare) == 0) return 0;
            else if ((this.specializare).CompareTo(m1.specializare) == 1) return 1;
            return -1;
        }
        public float majorareConsultatie()
        {
            return (float)1.5 * this.PretConsultatie;
        }

        public override float met1()
        {
            return this.SumaPacienti();
        }
        public static Medici operator+(Medici m,Pacienti p)
        {
            Medici m2 = (Medici)m.Clone();
            Pacienti[] vectorNou = new Pacienti[m.vectorPacienti.Length + 1];
            for (int i = 0; i < m.vectorPacienti.Length; i++)
                vectorNou[i] = (Pacienti)m.vectorPacienti[i].Clone();
            vectorNou[vectorNou.Length] = (Pacienti)p.Clone();
            m2.vectorPacienti = vectorNou;
            return m2;

        }
        public int SumaPacienti()
        {
            int sumaP = 0;
            for (int i = 0; i < vectorPacienti.Length; i++)
                sumaP += (int)vectorPacienti[i];
            return sumaP;
        }
        public int varsta()
        {
            return this.Varsta;
        }
        public Pacienti this[int i]
        {
            get
            {
                if (i >= 0 && i < this.vectorPacienti.Length)
                    return this.vectorPacienti[i];
                else return null;
            }
        }
    }
}
