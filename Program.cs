using DesafioPOO.Models;

Iphone iphone = new Iphone("65993996655", "Iphone 17", "123456789", 262144);
Nokia nokia = new Nokia("65993225566", "Nokia 3310", "987654321", 131072);

iphone.InstalarAplicativo("Instagram");
iphone.InstalarAplicativo("Facebook");
iphone.InstalarAplicativo("whatsapp");
iphone.Ligar("65993996655");
iphone.ReceberLigacao();


nokia.InstalarAplicativo("Youtube");
nokia.InstalarAplicativo("Instagram");
nokia.InstalarAplicativo("whatsapp");
nokia.Ligar("65993225566");
nokia.ReceberLigacao();