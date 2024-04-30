using System.ComponentModel;

namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        private string modelo;
        private string imei;
        private int memoria;
        // [x]: Implementar as propriedades faltantes de acordo com o diagrama

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
                    modelo = value;
                else
                    throw new ArgumentException("O IMEI não pode ser nulo");
            }
        }

        public int Memoria
        {
            get => memoria;
            set
            {
                if(value <= 0)
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
            // [x]: Passar os parâmetros do construtor para as propriedades
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