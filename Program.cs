using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("*****Smartphone Nokia*****");
Smartphone nokia = new Nokia("(81)9797-8686", "Tijolão", "11111111111", 256);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine("\n");

Console.WriteLine("*****Smartphone Iphone*****");
Smartphone iphone = new Iphone("(81)2525-8787", "Iphone 15", "22222222222", 512);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Cartola F.C.");
