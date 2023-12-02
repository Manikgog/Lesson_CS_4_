using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Lesson_CS_4
{
    public class Text
    {
        private string title;
        public string Title
        {
            get { return title; }
        }

        private string lead;

        public  string Lead
        {
            get { return lead; }
            set { lead = value; }
        }

        public string Article{ get; set; }

        private static uint counter  = 0;
        public static uint Counter { get { return counter; } }

        public Text(string title)
        {
            counter++;
            this.title = title;
        }

        public void Print()
        {
            Console.WriteLine($"Заголовок : {this.Title}\n\n" +
                              $"Введение : {this.Lead}\n\n" +
                              $"Текст :  {this.Article}");
        }
    }

    internal class Program
    {
        static void Print(string Title, string Lead)
        {
            Text text= new Text(Title);
            text.Lead = Lead;
            //Console.WriteLine("Заголовок : {0}\n\nВведение : {1}\n\nТекст : {2}", text.Title, text.Lead, text.Article);
            Console.WriteLine($"Заголовок : {text.Title}\n\n" +
                              $"Введение : {text.Lead}\n\n" +
                              $"Текст :  {text.Article}");
        }


        static void Main(string[] args)
        {
            //Program.Print(args[0], args[1]);
            //Console.WriteLine(args[1]);
            //if (args.Length > 0)
            //{
            //    Console.WriteLine(args[0]);
            //    switch (args[0])
            //    {
            //        case "1":
            //            {
            //                Console.WriteLine("Один");
            //            }
            //            break;
            //        case "2":
            //            Console.WriteLine("Два");
            //            break;
            //        default:
            //            Console.WriteLine(args[0]);
            //            break;
            //    }
            //}
            //else
            //{
            //}

            int count = args.Length/3;
            Console.WriteLine("Количество троек - " + count);
            int counter = 0;
            for (int i = count; i > 0; i--)
            {
                Text text = new Text(args[counter]);
                text.Lead = args[++counter];
                text.Article = args[++counter];
                counter++;
                Console.WriteLine("----------------------------\nСтатья номер {0}\n", Text.Counter);
                text.Print();
            }
            //if(count > 0) 
            //{
            //    Text text = new Text(args[0]);
            //    text.Lead = args[1];
            //    text.Article = args[2];
            //    text.Print();
            //}
            
            

        }
    }
}
