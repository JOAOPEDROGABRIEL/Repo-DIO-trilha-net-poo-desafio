using System.ComponentModel;
using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Smartphone Nokia = new Nokia(numero: "00123456789", modelo: "ModeloEx1", IMEI: "000000000001", Memoria: 128);
Nokia.Ligar();
Nokia.InstalarAplicativo("Whatsapp");

Smartphone Iphone = new Iphone(numero: "00987654321", modelo: "15ProMax", IMEI: "000000000001", Memoria: 64);
Iphone.Ligar();
Iphone.InstalarAplicativo("Telegram");