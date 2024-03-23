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
            Debug.Assert(title.Length <= 100 && title != null,"jumlah kata melebihi batas");
            this.title = title;
            id = random.idrandom();
            playcount = 0;

        }

        public void increasePlaycount(int playcount)
        {
            Debug.Assert(playcount <= 10000000, "Jumlah playcount melebihi batas");
            try
            {
                checked
                {
                    this.playcount = playcount;
                }
            }
            catch (OverflowException)
            {
                Console.WriteLine("Terjadi overflow pada penambahan play count.");
            }
        }
        public void printVideoDetail()
        {
            Console.WriteLine($"id :  {id}");
            Console.WriteLine($"judul : {this.title}");
            Console.WriteLine($"Play count : {this.playcount} ");
        }

    }
    private static void Main(string[] args)
    {

        sayaTubeVideo video = new sayaTubeVideo("Tutorial Design by contract - Hafid al akhyar");
        //sayaTubeVideo video = new sayaTubeVideo("Tutorial Design by contract - Hafid al akhyar Tutorial Design by contract - Hafid al akhyar Tutorial Design by contract - Hafid al akhyar Tutorial Design by contract - Hafid al akhyar Tutorial Design by contract - Hafid al akhyar Tutorial Design by contract - Hafid al akhyar Tutorial Design by contract - Hafid al akhyar Tutorial Design by contract - Hafid al akhyarTutorial Design by contract - Hafid al akhyar");
        video.increasePlaycount(123456);
        //video.increasePlaycount(int.MaxValue);
        video.printVideoDetail();


    }
}