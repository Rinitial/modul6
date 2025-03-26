using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul6
{
    class SayaTubeUser
    {
        private int id;
        private List<SayaTubeVideo> uploadVideos;
        private string Username;

        private static Random random = new Random();

        public SayaTubeUser(string username)
        {
            if (username == "" || username.Length > 100)
                throw new Exception("Judul video tidak valid");

            this.id = random.Next(00000, 99999);
            this.Username = username;
            this.uploadVideos = new List<SayaTubeVideo>();

        }

        public int getTotalVideoPlayCount()
        {
            int count = 0;

            for (int i = 0; i < uploadVideos.Count; i++)
            {
                count += uploadVideos[i].getplayCount();
            }
            return count;
        }

        public void addVideo(SayaTubeVideo video)
        {
            try
            {
                Debug.Assert(video != null && video.getplayCount() < int.MaxValue);
                uploadVideos.Add(video);
            }
            catch(OverflowException)
            {
                throw new OverflowException("Jumlah play count melebihi batas");
            }
        }

        public void printAllVideoPlayCount()
        {
            Console.WriteLine("User : " + Username);
            for (int i = 0; i < 8; i++)
            {
                Console.WriteLine("Video Ke - " + i + " " +  uploadVideos[i].getTitle());
            }
        }

    }
}
