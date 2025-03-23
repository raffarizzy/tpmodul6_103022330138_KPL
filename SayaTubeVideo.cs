using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul6_103022330138
{
    class SayaTubeVideo
    {
        private int id;
        private string title;
        private int playCount;
        Random rand = new Random();

        public SayaTubeVideo(string title)
        {
            Debug.Assert(title != null && title != "", "Title tidak boleh kosong!");
            Debug.Assert(title.Length <= 100, "Title maksimal 100 karakter!");

            this.id = rand.Next(10000, 99999);
            this.title = title;
            this.playCount = 0;
        }

        public void IncreasePlayCount(int views)
        {
            Debug.Assert(views <= 10000000, "penambahan play count maksimal 10.000.000");
            try
            {
                checked
                {
                    this.playCount += views;
                }
            }
            catch (OverflowException)
            {
                Console.WriteLine("Terjadi error overflow!");
            }
        }

        public void PrintVideoDetails()
        {
            Console.WriteLine("ID : " + this.id);
            Console.WriteLine("Title : " + this.title);
            Console.WriteLine("Play Count : " + this.playCount);
        }
    }
}
