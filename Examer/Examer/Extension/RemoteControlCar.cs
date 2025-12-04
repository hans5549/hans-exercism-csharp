namespace Examer.Extension
{
    public class RemoteControlCar
    {
        private int Meters { get; set; } = 0;
        private int BatteryPercentage { get; set; } = 100;

        public static RemoteControlCar Buy()
        {
            return new RemoteControlCar();
        }

        public string DistanceDisplay()
        {
            return $"Driven {Meters} meters";
        }

        public string BatteryDisplay()
        {
            if (BatteryPercentage != 0)
            {
                return $"Battery at {BatteryPercentage}%";
            }
            return $"Battery empty";
        }

        public void Drive()
        {
            if (BatteryPercentage != 0)
            {
                Meters += 20;
                BatteryPercentage--;
            }
        }
    }
}
