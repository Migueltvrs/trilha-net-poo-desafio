namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    // Ok
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
            Console.WriteLine($"Número: {numero} \nModelo: {modelo} \nIMEI: {imei} \nMemória: {memoria}");
        }
        // TODO: Sobrescrever o método "InstalarAplicativo"
        // Ok
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o aplicativo: {nomeApp} no Iphone");
        }
    }
}