using DesafioPOO.Models;

bool exibirMenu = true;

// TODO: Realizar os testes com as classes Nokia e Iphone(OK)
Console.WriteLine("Informe o número do seu Smartphone: ");
string numero = Console.ReadLine();

Console.WriteLine("Informe o modelo do seu Smartphone: ");
string modelo = Console.ReadLine();

Console.WriteLine("Informe o IMEI do seu Smartphone: ");
string imei = Console.ReadLine();

Console.WriteLine("Informe quanto de memoria tem disponível no seu Smartphone: ");
string memoria = Console.ReadLine();

if(modelo.ToLower() == "iphone") {
    Iphone i = new Iphone(numero, modelo, imei, memoria);
    while (exibirMenu) {
        Console.WriteLine("Digite a sua opção:");
        Console.WriteLine("1 - Ligar");
        Console.WriteLine("2 - Instalar aplicativo");
        Console.WriteLine("3 - Receber Ligação");
        Console.WriteLine("4 - Desligar smartphone");

        switch (Console.ReadLine())
        {
            case "1":
                i.Ligar();
                break;

            case "2":
                Console.WriteLine("Informe o nome do App que deseja instalar");
                string nomeApp = Console.ReadLine();
                i.InstalarAplicativo(nomeApp);
                break;
            case "3": 
                i.ReceberLigacao();
                break;
            case "4": 
                exibirMenu = false;
                break;
            
            default:
                Console.WriteLine("Opção inválida");
                break;
    }

    }
}

else if(modelo.ToLower() == "nokia") {
    Nokia n = new Nokia(numero, modelo, imei, memoria);
    while (exibirMenu) {
        
        Console.WriteLine("-------------------");
        Console.WriteLine("Digite a sua opção:");
        Console.WriteLine("1 - Ligar");
        Console.WriteLine("2 - Instalar aplicativo");
        Console.WriteLine("3 - Receber Ligação");
        Console.WriteLine("4 - Desligar smartphone");
        switch (Console.ReadLine())
        {
            case "1":
                n.Ligar();
                break;
            case "2":
                Console.WriteLine("Informe o nome do App que deseja instalar");
                string nomeApp = Console.ReadLine();
                n.InstalarAplicativo(nomeApp);
                break;
            case "3": 
                n.ReceberLigacao();
                break;
            case "4":
                exibirMenu = false;
                Console.WriteLine("Até Logo!");
                break;
            default:
                Console.WriteLine("Opção inválida");
                break;


        }
    }
}

else {
    Console.WriteLine("Modelo de smartphone não reconhecido.");
}

