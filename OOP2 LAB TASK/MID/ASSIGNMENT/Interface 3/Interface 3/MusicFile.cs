using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_3
{
    class MusicFile
    {
        private string title;
        private string artist;
        private int yearOfRelease;
        private int durationInSeconds;

        public MusicFile()
        {
            title = "Amon jodi hoto";
            artist = "Joler gan";
            yearOfRelease = 2013;
            durationInSeconds = 6;
        }
        public MusicFile(string title, string artist, int yearOfRelease, int durationInSeconds)
        {
            this.title = title;
            this.artist = artist;
            this.yearOfRelease = yearOfRelease;
            this.durationInSeconds = durationInSeconds;
        }
        public void changeTitle(string title)
        {
            this.title = title;
        }
        public void display()
        {
            Console.WriteLine(title);
        }
      
    }
}
