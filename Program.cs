using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Smartphone c1 = new Iphone("12992438225", "modelo1", "11111111", 62);
Console.WriteLine("\nAparelho Iphone: ");
c1.ReceberLigacao();
c1.Ligar();
c1.InstalarAplicativo("Telegram");


Smartphone n1 = new Nokia("12988769627", "Sansung", "222222222", 120);
Console.WriteLine("\nAparelho Nokia: ");
n1.ReceberLigacao();
n1.Ligar();
n1.InstalarAplicativo("Mobile Legends");



