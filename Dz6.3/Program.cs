using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz6._3
{
    internal class Program
    {

            static void Main(string[] args)
            {
            Book book = new Book();
            Book.Notes notes = new Book.Notes();
            notes.Add("Первая заметка");
            notes.Add("Вторая заметка");
            notes.Add("Третья заметка");
            notes.Show();
            notes.Remove(1);
            notes.Show();
            Console.ReadKey();
            } 
    }
    public class Book
    {
        public void FindNext(string str)
        {
            Console.WriteLine("Пошук рядка : " + str);
        }
        public class Notes
        {
            private string[] List = new string[0];
            public void Add(string note)
            {
                List = new string[List.Length+1];
                List[List.Length] = note;
            }

            public void Remove(int index)
            {
                List = new string[List.Length - 1];
                for (int i = index; i < List.Length - 1; i++)
                {
                    List[i] = List[i + 1];
                }
            }

            public void Show()
            {
                Console.WriteLine("Замітки:");
                for (int i = 0; i < List.Length; i++)
                {
                    Console.WriteLine(i + 1 + ". " + List[i]);
                }
            }
        }
    }
  }

