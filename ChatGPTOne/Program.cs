using System;

namespace ChatGPTOne
{
    public class Program
    {
        private static void Main(string[] args)
        {
            string questao;
            do
            {
                Console.Write("Coloque uma questão: ");
                questao = Console.ReadLine();
                string resposta;

                DateTime dateTime = DateTime.Now;
                switch (questao)
                {
                    case "esta a chover ?":
                        resposta = "não";
                        break;
                    case "que dia é hoje ?":
                        resposta = DateTime.Now.ToString("dd");
                        break;
                    case "que ano é ?":
                        resposta = DateTime.Now.ToString("yyyy");
                        break;
                    case "que horas sao ?":
                        resposta = dateTime.ToString("HH:mm:ss");
                        break;
                    case "EXIT":

                        continue;
                    default:
                        resposta = "nao tenho resposta para essa questão";
                        break;
                }
                Console.WriteLine(resposta);
            } while (questao != "EXIT");
        }
    }
}
