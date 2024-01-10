namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone" (OK)
    public class Nokia : Smartphone 
    {
        public Nokia(string numero, string modelo, string imei, string memoria) : base(numero, modelo, imei, memoria){

        }
        // TODO: Sobrescrever o método "InstalarAplicativo" (OK)
        public override void InstalarAplicativo(string nomeApp) {
            Console.WriteLine("Abrindo Play Store...");
            Console.WriteLine($"{nomeApp} está sendo instalado");
            Console.WriteLine("...");
            Console.WriteLine("Instalado com sucesso!");

        }


    }
}