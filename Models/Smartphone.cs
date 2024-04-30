using System.ComponentModel;

namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        private string modelo;
        private string imei;
        private int memoria;

        public string Modelo
        {
            get => modelo;
            
            set
            {
                if(value != "")
                    modelo = value;
                else
                    throw new ArgumentException("O modelo não pode ser nulo");
            }
        }

        public string IMEI
        {
            get => imei;

            set
            {
                if(value != "")
                    imei = value;
                else
                    throw new ArgumentException("O IMEI não pode ser nulo");
            }
        }

        public int Memoria
        {
            get => memoria;
            set
            {
                if(value >= 0)
                    memoria = value;
                else
                    throw new ArgumentException("A memória não pode ser zero ou negativa");
            }
        }

        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
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

        public override string ToString()
        {
            return $"Número: {Numero}\nModelo: {Modelo}\nIMEI: {IMEI}\nMemória: {Memoria}";
        }
    }
}