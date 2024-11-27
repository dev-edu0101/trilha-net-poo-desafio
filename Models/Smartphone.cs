namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        // Propriedades comuns para todos os smartphones
        public string Numero { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string SistemaOperacional { get; set; }

        // Construtor da classe Smartphone
        public Smartphone(string numero, string marca, string modelo, string sistemaOperacional)
        {
            Numero = numero;
            Marca = marca;
            Modelo = modelo;
            SistemaOperacional = sistemaOperacional;
        }

        // Métodos comuns para todos os smartphones
        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        // Método abstrato que será implementado pelas classes filhas
        public abstract void InstalarAplicativo(string nomeApp);
    }
}
