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
            private List<string> notes = new List<string>();
            public void Add(string note)
            {
                notes.Add(note);
            }

            public void Remove(int index)
            {
                notes.RemoveAt(index);
            }

            public void Show()
            {
                Console.WriteLine("Замітки:");
                for (int i = 0; i < notes.Count; i++)
                {
                    Console.WriteLine(i + 1 + ". " + notes[i]);
                }
            }
        }
    }
    }
  

