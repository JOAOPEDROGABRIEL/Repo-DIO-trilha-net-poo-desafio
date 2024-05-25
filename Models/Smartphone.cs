namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        private string Modelo { get; set; }
        private string IMEI_Number { get; set; }
        private int Memory { get; set; }	

        public Smartphone() {}
        public Smartphone(string numero, string modelo, string IMEI, int Memoria)
        {
            Numero = numero;
            this.Modelo = modelo;
            this.IMEI_Number = IMEI;
            this.Memory = Memoria;
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