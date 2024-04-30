using DesafioPOO.Models;

Console.WriteLine("Teste de entrada Iphone: ");
Iphone ip = new Iphone(numero: "99999-9999", modelo: "c3po",
                       imei: "666666", memoria: 4 );

Console.WriteLine(ip.ToString());
ip.Ligar();
ip.ReceberLigacao();
ip.InstalarAplicativo("Subway Surfers");

Console.WriteLine("\nTeste de entrada Nokia: ");
Nokia nok = new Nokia(numero: "98888-8888", modelo: "r2d2",
                       imei: "99999", memoria: 2 );

Console.WriteLine(nok.ToString());
nok.Ligar();
nok.ReceberLigacao();
nok.InstalarAplicativo("Minecraft APK");


