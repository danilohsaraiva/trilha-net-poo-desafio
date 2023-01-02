using DesafioPOO.Models;

Console.WriteLine("Testando classes\n");

Nokia aparelho1 = new Nokia("9 9999-9999", "Modelo 1", "XXX-XXX.XXX", "64");
aparelho1.Ligar();
aparelho1.InstalarAplicativo("Instagram");
aparelho1.ReceberLigacao();

Console.WriteLine();

Iphone aparelho2 = new Iphone("8 8888-8888", "Modelo 2", "ZZZ-ZZZ.ZZZ", "128");
aparelho2.Ligar();
aparelho2.InstalarAplicativo("FaceTune");
aparelho2.ReceberLigacao();
