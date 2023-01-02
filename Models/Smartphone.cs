namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero;
        private string Modelo;
        private string Imai;
        private string Memoria;
        public Smartphone(string numero, string modelo, string imai, string memoria)
        {
            Numero = numero;
            Modelo = modelo;
            Imai = imai;
            Memoria = memoria;
        }
        public virtual void Ligar()
        {
            Console.WriteLine("Ligando...");
        }
        public virtual void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }
        public abstract void InstalarAplicativo(string nomeApp);
    }
}