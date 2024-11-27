using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Smartphone nokia = new Nokia("123456789", "3310", "Nokia OS");
        Smartphone iphone = new Iphone("987654321", "iPhone 12", "iOS");

        // Testando métodos comuns (Ligar e ReceberLigacao)
        Console.WriteLine("Testando o Nokia:");
        nokia.Ligar();
        nokia.ReceberLigacao();
        nokia.InstalarAplicativo("WhatsApp");

        Console.WriteLine();

        Console.WriteLine("Testando o iPhone:");
        iphone.Ligar();
        iphone.ReceberLigacao();
        iphone.InstalarAplicativo("WhatsApp");

        // Exibindo as informações dos smartphones
        Console.WriteLine("\nInformações dos Smartphones:");
        Console.WriteLine($"Nokia - Número: {nokia.Numero}, Modelo: {nokia.Modelo}, SO: {nokia.SistemaOperacional}");
        Console.WriteLine($"iPhone - Número: {iphone.Numero}, Modelo: {iphone.Modelo}, SO: {iphone.SistemaOperacional}");