namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class iPhone : Smartphone
    {
        // TODO: Sobrescrever o método "InstalarAplicativo"
        public iPhone(string numero,string modelo,string imei,int memoria) : base(numero, modelo, imei, memoria)
        {
        }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o aplicativo {nomeApp}  no iPhone");
        }
    }
}