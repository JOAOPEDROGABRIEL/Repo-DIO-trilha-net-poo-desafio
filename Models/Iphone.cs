namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Iphone : Smartphone
    {
        // TODO: Sobrescrever o método "InstalarAplicativo"
        public Iphone(string numero, string modelo, string IMEI, int Memoria) : base(numero, modelo, IMEI, Memoria) {}
        public override void InstalarAplicativo(string NomeApp)
        {
            Console.WriteLine($"Instalando aplicativo {NomeApp} no Iphone...");
        }
    }
}