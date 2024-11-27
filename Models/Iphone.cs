namespace DesafioPOO.Models
{
    // Herda da classe Smartphone
    public class Iphone : Smartphone
    {
        // Construtor que inicializa as propriedades da classe base
        public Iphone(string numero, string modelo, string sistemaOperacional)
            : base(numero, "Apple", modelo, sistemaOperacional)
        {
        }

        // Sobrescreve o método InstalarAplicativo para o Iphone
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando {nomeApp} no iPhone {Modelo} através da App Store.");
        }
    }
}
