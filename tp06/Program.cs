using System.Diagnostics;
using System.Reflection;
using System.Text;

internal class Program
{

    class random
    {
        public int idrandom()
        {
            Random id = new Random();
            return id.Next(10000, 99999);
        }
    }
    class sayaTubeVideo
    {
        private int id;
        private string title;
        private int playcount;

        public sayaTubeVideo(string title)

        {
            random random = new random();
            this.title = title;
            id = random.idrandom();
            playcount = 0;

        }

        public void increasePlaycount(int playcount)
        {
            this.playcount += playcount;

        }
        public void printVideoDetail()
        {
            Console.WriteLine($"id :  {this.id}");
            Console.WriteLine($"judul : {this.title}");
            Console.WriteLine($"Play count : {this.playcount} ");
        }

    }
    private static void Main(string[] args)
    {

        sayaTubeVideo video = new sayaTubeVideo("Tutorial Design by contract - Hafid al akhyar");
        video.increasePlaycount(123456);
        video.printVideoDetail();

    }
}