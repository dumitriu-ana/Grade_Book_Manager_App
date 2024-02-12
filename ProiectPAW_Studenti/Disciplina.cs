using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectPAW_Studenti
{
    [Serializable]
    public class Disciplina
    {
       private string denumire;
       private int numarCredite;

        public string Denumire { get => denumire; set => denumire = value; }
        public int NumarCredite { get => numarCredite; set => numarCredite = value; }

        public Disciplina() { }

        public Disciplina(string denumire, int numarCredite)
        {
            this.Denumire = denumire;
            this.NumarCredite = numarCredite;
        }

       public void setDenumire(string denumire)
        {
            this.Denumire = denumire;
        }

        public string getDenumire()
        {
            return Denumire;
        }
        public  void setNumarCredite( int numarCredite)
        {
            this.NumarCredite = numarCredite;
        }

        public int getNumarCredite()
        {
            return NumarCredite;
        }

        public override string ToString()
        {
            string m = Denumire + " cu " + NumarCredite + " credite:   ";
            return m;
        }
    }

}
