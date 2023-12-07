using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Nokia: ");
Smartphone nokia = new Nokia(numero:"91358750", modelo:"S10", imei:"2586654977", memoria:32);
nokia.Ligar();
nokia.InstalarAplicativo("Pinterest");

Console.WriteLine("\n");

Console.WriteLine("Smartphone iPhone: ");
Smartphone iPhone = new iPhone(numero:"88256991", modelo:"Pro", imei:"52666328994", memoria:64);
iPhone.ReceberLigacao();
iPhone.InstalarAplicativo("Waze");