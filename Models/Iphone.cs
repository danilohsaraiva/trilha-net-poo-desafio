namespace DesafioPOO.Models
{
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, string imai, string memoria) : base(numero, modelo, imai, memoria)
        {

        }
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando aplicativo {nomeApp} em seu Iphone!");
        }

        public override void Ligar()
        {
            Console.WriteLine("Ligando com aparelho Iphone!");
        }
         public override void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação no aparelho Iphone!");
        }
    }
}