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
            this.id = random.Next(00000, 99999);
            this.title = title;
            this.playCount = 0;
        }

        public void IncreasePlayCount(int play)
        {
            playCount += play;
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
