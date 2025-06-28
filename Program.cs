using DesafioPOO.Models;

Console.WriteLine("Testes com Nokia:");
Smartphone nokia = new Nokia(numero: "931234567", modelo: "Nokia 3310", imei: "1234567890", memoria: 64);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Snake");

Console.WriteLine("\nTestes com iPhone:");
Smartphone iphone = new Iphone(numero: "912345678", modelo: "iPhone 14", imei: "0987654321", memoria: 128);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");
