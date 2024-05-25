namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, string IMEI, int Memoria) : base(numero, modelo, IMEI, Memoria) {}

        // TODO: Sobrescrever o método "InstalarAplicativo"
        public override void InstalarAplicativo(string NomeApp)
        {
            Console.WriteLine($"Instalando aplicativo {NomeApp} no Nokia...");
        }
    }
}