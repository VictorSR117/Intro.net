namespace Trabalhando_com_Classes_e_Objetos
{
    public class CelularDeBotao:Celular
    {
        public string modelo;
        public double preco;

        public CelularDeBotao() {
            
        }

        public CelularDeBotao() {
            this.modelo = "";
            this.preco = 0;
        }

        public void camera() {
            Console.WriteLine("ligando a camera");
        }

        public override void dispararAlarme() {
            base.dispararAlarme();
        }

        public override void tocarMusica() {
            Console.WriteLine("tocando uma musica")
        }
    }
}