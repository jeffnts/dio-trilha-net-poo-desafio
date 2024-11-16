using DesafioPOO.Models;

namespace DesafioPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            // Criando instância da classe Nokia
            Nokia nokia = new Nokia("123456789", "ModeloNokia", "111111111111111", 64);
            Console.WriteLine("Testando Nokia:");
            nokia.Ligar();
            nokia.ReceberLigacao();
            nokia.InstalarAplicativo("WhatsApp");

            // Criando instância da classe Iphone
            Iphone iphone = new Iphone("987654321", "ModeloIphone", "222222222222222", 128);
            Console.WriteLine("\nTestando iPhone:");
            iphone.Ligar();
            iphone.ReceberLigacao();
            iphone.InstalarAplicativo("Instagram");
        }
    }
}