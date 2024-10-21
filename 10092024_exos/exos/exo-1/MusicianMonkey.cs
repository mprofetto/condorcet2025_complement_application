namespace Circus
{
    public class MusicianMonkey : Monkey
    {
        public MusicianMonkey(List<string> trickList) : base(trickList){}

        public override int doATrick()
        {
            if (this.trickList != null)
            {
                Random  rand = new Random();
                int     index = rand.Next(0, this.trickList.Count);

                Console.WriteLine("Le singe chante une chanson: " + this.trickList[index]);
            }
            return (1);
        }
    } 
}


