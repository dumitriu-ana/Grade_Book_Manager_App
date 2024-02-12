using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectPAW_Studenti
{
    [Serializable]      //pentru a putea salva in fis binar, clasa trebuie marcata ca serializabila
    public class Student : ICentralizator
    {
        private int id;
        private string nume;
        private bool buget;
        private bool bursa;
        private Disciplina[] materie;
        private int[] note;
        private float medie;

        public int Id { get => id; set => id = value; }
        public string Nume { get => nume; set => nume = value; }
        public bool Buget { get => buget; set => buget = value; }
        public bool Bursa { get => bursa; set => bursa = value; }
        public Disciplina[] Materie { get => materie; set => materie = value; }
        public int[] Note { get => note; set => note = value; }
        public float Medie { get => medie; set => medie = value; }

        public Student()
        {
            this.Id = 0;
            this.Nume = "Necunoascut";
            this.Buget = false;
            this.Bursa = false;
            this.Materie = null;
            this.Note = null;
            this.Medie = 0;
        }
        public Student(int id, string nume, string[] materii, int [] numarCredite, int[] note)
        {
            this.Id = id;
            this.Nume = nume;
            this.Materie = new Disciplina[materii.Length];
            for(int i=0; i<materii.Length; i++)
            {
                // foloseste constructor cu param
                Materie[i] = new Disciplina();
                Materie[i].setDenumire(materii[i]);
                Materie[i].setNumarCredite(numarCredite[i]);
            }
            this.Note = note;
        }

        public int getId()
        {
            return Id;
        }
        public string getNume()
        {
            return Nume;
        }
        public float getMedie()
        {
            return Medie;
        }

        public Student(int id, string nume, bool buget, bool bursa,  Disciplina[] materie, int[] nota, float medie)
        {
            this.Id = id;
            this.Nume = nume;
            this.Buget = buget;
            this.Bursa = bursa;
            this.Materie = materie;
            this.Note = nota;
            this.Medie = medie;
        }

        public Student(int id, string nume,  Disciplina[] materie, int[] nota)
        {
            this.Id = id;
            this.Nume = nume;
            this.Materie = materie;
            this.Note= nota;

        }
        public Student(int id, string nume)
        {
            this.Id = id;
            this.Nume = nume;
        }
        public Student(string nume, float medie)
        {
            this.nume = nume;
            this.medie = medie;
        }

        public void calculMedie()
        {
            float s = 0;
            int nrC = 0;
            int promovat = 0;
            Medie = 0;
            //vector de meterii si vector de note, in materie gasim nr de credite
            if (Materie != null && Note != null)
            {
                for (int i = 0; i <Note.Length; i++)
                {
                    promovat = 0;
                    if (Note[i]>=5)
                    {
                        promovat = Materie[i].getNumarCredite();
                    }
                    s += promovat * Note[i];
                    nrC += Materie[i].getNumarCredite();
                }
                Medie= s / nrC;
            }
        }
        public int calculTaxe()
        {
            
            int restante = 0;
            for(int i=0; i<note.Length; i++)
            {
                if(note[i]<5)
                {
                    restante++;
                }
            }
            return  75 * restante;
        }

        public override string ToString()
        {
            string m = "Studentul " + Id + " cu numele " + Nume + " are urmatoarele note: \n";
            for (int i = 0; i < Note.Length; i++)
            {
                m += "    " + Materie[i] + "    "; 
                m += Note[i].ToString() + " \n";
            }
            m += " Medie = " + Medie;
            return m;
        }

    }


}
