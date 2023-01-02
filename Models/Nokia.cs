namespace DesafioPOO.Models
{
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, string imai, string memoria) : base(numero, modelo, imai, memoria)
        {

        }
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando aplicativo {nomeApp} em seu Nokia");
        }

        public override void Ligar()
        {
            Console.WriteLine("Ligando com aparelho Nokia!");
        }

        public override void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação no aparelho Nokia!");
        }
    }
}