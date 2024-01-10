namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        // TODO: Implementar as propriedades faltantes de acordo com o diagrama (OK)
        private string Modelo { get; set; }

        private string IMEI { get; set; }

        private string Memoria { get; set; }

        public Smartphone(string numero, string modelo, string imei, string memoria)
        {
            // TODO: Passar os parâmetros do construtor para as propriedades (OK)
            Numero = numero;
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}