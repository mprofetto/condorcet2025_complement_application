namespace Circus
{
    public class AcrobaticMonkey : Monkey
    {
        public AcrobaticMonkey(List<string> trickList) : base(trickList){}

        public override int doATrick()
        {
            if (this.trickList != null)
            {
                Random  rand = new Random();
                int     index = rand.Next(0, this.trickList.Count);

                Console.WriteLine("Le singe effectue une acrobatie: " + this.trickList[index]);
            }
            return (0);
        }
    } 
}


