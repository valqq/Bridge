namespace Bridge
{
    public class LG : TV
    {
        int station = 0;

        public override int getChannel()
        {
            return station;
        }

        public override void off()
        {
            Console.WriteLine("Turning oFF the LG TV");
        }

        public override void on()
        {
            Console.WriteLine("Turning on the LG TV");
        }

        public override void tuneChannel(int channel)
        {
            this.station = channel;
            Console.WriteLine("Set the LG TV station to " + this.station);
        }
    }
}