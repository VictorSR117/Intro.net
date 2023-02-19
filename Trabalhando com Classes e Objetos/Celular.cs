using System;
namespace Trabalhando_com_Classes_e_Objetos
{
    public class Celular
    {
        public string cor;
        public double altura;
        public double largura;
        public string modelo;

        public Celular() {
            
        }

        public Celular(string _cor, double _altura, double _largura, string _modelo) {
            this.cor = _cor;
            this.altura = _altura;
            this.largura = _largura;
            this.modelo = _modelo;
        }

        public Celular(string _cor, double _altura) {
            this.cor = _cor;
            this.altura = _altura;
        }

        public void fazerChamada(int numero) {
            Console.WriteLine("fazendo chamada para o número: " + numero);
        }

        /*public virtual void dispararAlarme() {
            Console.WriteLine("disparando alarme...");
        }*/

        public static void dispararAlarme() {
            Console.WriteLine("disparando alarme...");
        }
    }
}