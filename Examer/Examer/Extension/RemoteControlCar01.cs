namespace Examer.Extension;

public class RemoteControlCar01
{
    public int Speed { get; set; } // 速度
    public int Battery { get; set; } // 電量
    public int BatteryDrain { get; set; } // 電量消耗
    public int DistanceDrivenValue { get; set; } // 行駛距離

    public RemoteControlCar01(int speed, int batteryDrain)
    {
        this.Speed = speed;
        this.Battery = 100;
        this.BatteryDrain = batteryDrain;
        this.DistanceDrivenValue = 0;
    }

    public static RemoteControlCar01 Nitro()
    {
        return new RemoteControlCar01(50, 4);
    }

    public bool BatteryDrained()
    {
        if (this.Battery > 0)
        {
            if (Battery < BatteryDrain)
            {
                return true;
            }

            return false;
        }
        else if (this.Battery == 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    
    public int DistanceDriven()
    {
        return this.DistanceDrivenValue;
    }

    public void Drive()
    {
        if (Battery > 0 && Battery >= BatteryDrain)
        {
            DistanceDrivenValue += Speed;
            Battery -= BatteryDrain;
        }
    }
}

class RaceTrack
{
    // TODO: define the constructor for the 'RaceTrack' class
    public int Distance { get; set; }

    public RaceTrack(int distance)
    {
        this.Distance = distance;
    }

    public bool TryFinishTrack(RemoteControlCar01 car)
    {
        if ((this.Distance % car.Speed) != 0)
        {
            int count = (this.Distance / car.Speed) + 1;
            if (count * car.BatteryDrain > 100)
            {
                return false;
            }

            return true;
        }
        else
        {
            int count = this.Distance / car.Speed;
            if (count * car.BatteryDrain > 100)
            {
                return false;
            }
            
            return true;
        }
    }
}