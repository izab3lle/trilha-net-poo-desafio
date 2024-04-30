namespace DesafioPOO.Models
{
    // [x]: Herdar da classe "Smartphone"
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
            
        }

        // [x]: Sobrescrever o método "InstalarAplicativo"
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando {nomeApp} no seu dispositivo Nokia...");
            Console.WriteLine($"{nomeApp} instalado.");
        }
    }
}