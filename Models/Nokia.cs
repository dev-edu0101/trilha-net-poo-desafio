namespace DesafioPOO.Models
{
    // Herda da classe Smartphone
    public class Nokia : Smartphone
    {
        // Construtor que inicializa as propriedades da classe base
        public Nokia(string numero, string modelo, string sistemaOperacional)
            : base(numero, "Nokia", modelo, sistemaOperacional)
        {
        }

        // Sobrescreve o método InstalarAplicativo para o Nokia
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando {nomeApp} no Nokia {Modelo} através da loja Nokia Store.");
        }
    }
}
