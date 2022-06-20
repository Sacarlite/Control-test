using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace GB1
{
    internal class Program
    {
        static void Main(string[] args)
        {
             String[] text = Array.Empty<string>();
             text = AddText();
        }
        static string[] AddText(){
            Console.WriteLine("Введите текст.По окончание ввода введите пустую строку");
            var listOfStrings = new List<string>();
            string sent;
            do
            {
                sent = Console.ReadLine();
                if (sent != "")
                {
                    listOfStrings.Add(sent);
                }

            } while (sent != "");

            string[] arrayOfStrings = listOfStrings.ToArray();
            return arrayOfStrings;
        }
           static string[] Filter(ref string[] text)
        {
            var listOfStrings = new List<string>();
            for (int i = 0; i < text.GetLength(0); i++) {
                if (text[i].Length <= 3)
                {
                    listOfStrings.Add(text[i]);
                }
            
            }
            return listOfStrings.ToArray();
        }
     }
 }