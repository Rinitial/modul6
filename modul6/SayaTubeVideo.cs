using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul6
{
    class SayaTubeVideo
    {
        private int id;
        private string title;
        private int playCount;

        private static Random random = new Random();

        public SayaTubeVideo(string title)
        {
            if (title == "" || title.Length > 200)
                throw new Exception("Judul video tidak valid");

            this.id = random.Next(00000, 99999);
            this.title = title;
            this.playCount = 0;
        }

        public void IncreasePlayCount(int play)
        {
            if (play > 25000000 || play < 0)
                throw new Exception("Playcount tidak valid");
            try
            {
                checked
                {
                    playCount += play;
                }
            }
            catch (OverflowException)
            {
                Console.WriteLine("Playcount melebihi batas tertinggi integer");
            }
        }

        public void printVideoDetails()
        {
            Console.WriteLine("ID : " + id);
            Console.WriteLine("Judul : " + title);
            Console.WriteLine("Play Count : " + playCount);
        }

        public int getplayCount()
        {
            return playCount;
        }

        public string getTitle()
        {
            return title;
        }
    }
}
