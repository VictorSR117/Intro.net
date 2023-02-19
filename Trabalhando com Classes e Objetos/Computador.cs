namespace Trabalhando_com_Classes_e_Objetos
{
    public class Computador
    {
        public string tipo;
        public string modelo;
        public string categoria;
        public double vidaUtil;

        public Computador() {
            
        }

        public Computador(string tipo, string modelo, string categoria, double vidaUtil) {
            this.tipo = tipo;
            this.modelo = modelo;
            this.categoria = categoria;
            this.vidaUtil = vidaUtil;
        }

        public Computador(string tipo, string categoria) {
            this.tipo = tipo;
            this.categoria = categoria;
        }
    }
}