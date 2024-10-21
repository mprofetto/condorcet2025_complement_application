namespace Circus
{
    public class Trainer
    {
        Monkey trainersMonkey;

        public Trainer(Monkey monkey)
        {
            if (monkey == null)
                throw new Exception("No Monkey Given to the Trainer");
            this.trainersMonkey = monkey;
        }

        public int showAMonkeyTrick()
        {
            Console.WriteLine("Le dresseur de singe demande à son singe d'effectuer un tour.");
            return (this.trainersMonkey.doATrick());
        }
    }
}