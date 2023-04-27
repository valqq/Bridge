namespace Bridge
{
    public class Sony : TV
    {
        int station = 0;

        public override int getChannel()
        {
            return station;
        }

        public override void off()
        {
            Console.WriteLine("Turning oFF the Sony TV");
        }

        public override void on()
        {
            Console.WriteLine("Turning on the Sony TV");
        }

        public override void tuneChannel(int channel)
        {
            this.station = channel;
            Console.WriteLine("Set the Sony TV station to " + this.station);
        }
    }
}