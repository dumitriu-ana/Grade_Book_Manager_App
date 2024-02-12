using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectPAW_Studenti
{
    class Facultate
    {
        private string cod;
        private string denumire;
        int numarStudenti;
        float medieBuget;
        float medieBursa;

        public string Cod { get => cod; set => cod = value; }
        public string Denumire { get => denumire; set => denumire = value; }
        public int NumarStudenti { get => numarStudenti; set => numarStudenti = value; }
        public float MedieBuget { get => medieBuget; set => medieBuget = value; }
        public float MedieBursa { get => medieBursa; set => medieBursa = value; }

        public Facultate(string cod, string denumire)
        {
            this.cod = cod;
            this.denumire = denumire;
        }



    }
}
