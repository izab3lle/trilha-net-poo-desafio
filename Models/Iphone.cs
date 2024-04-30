namespace DesafioPOO.Models
{
    // [x]: Herdar da classe "Smartphone"
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
        
        }

        // [x]: Sobrescrever o método "InstalarAplicativo"
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o aplicativo {nomeApp} no seu dispositivo IOS...");
            Console.WriteLine($"{nomeApp} instalado.");
        }
    }
}