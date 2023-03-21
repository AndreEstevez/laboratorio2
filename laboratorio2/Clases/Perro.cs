using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace laboratorio2.Clases
{
    internal class Perro
    {
        private string color;
        private string Raza;
        private string Sexo;
        private decimal Edad;
        private decimal Peso;


        public static string NOMBRE = "bobby";

        public Perro() 
        {
            this.color = "";
            this.Raza = "";
            this.Sexo = "";
            this.Edad = 0;
            this.Peso = 0;

        }

        public Perro(string _color,
                     string _raza,
                     string _sexo,
                     decimal _edad,
                     decimal _peso)

        {
            this.color = _color;
            this.Raza = _raza;
            this.Sexo = _sexo;
            this.Edad = _edad;
            this.Peso = _peso;

         


            

        }

        // metodos set y get

        public void setcolor(string _color) 
        {
            this.color = _color;
        }

        public string getcolor() 
        {
            return this.color;
        }

        public void setraza(string _raza) 
        {
            this.Raza = _raza;
        }

        public string getRaza() 
        {
            return this.Raza;
        }

        public void setsexo(string _sexo) 
        {
            this.Sexo = _sexo;
        }
        public string getsexo() 
        {
            return this.Sexo;
        }

        public void setedad(decimal _edad) 
        {
            this.Edad = _edad;
        }
        public decimal getedad() 
        {
            return this.Edad;
        }

        public void setpeso(decimal _peso) 
        {
            this.Peso = _peso;   
        }
        public decimal getpeso() 
        {
            return this.Peso;
        }

        public string comer() 
        {
            return "el perro de raza" + this.Raza + "esta comiendo";
        }

        public string respirar(string _respirar)// responder si o no 
        {
            return "el perro" + _respirar + "esta respirando";
        }
        public string ladrando(string _ladrando) 
        {
            return "el perro" + _ladrando + "esta ladrando";
        }
        public string corriendo(string _corriendo) 
        {
            return "el perro" + _corriendo + "";
        }
    }
}
