class RemoteControlCar
{
    private int distanceDriven = 0;
    private int battery = 100;
    private int speed;
    private int batteryDrain;
    
    // TODO: define the constructor for the 'RemoteControlCar' class
    public RemoteControlCar(int speed, int batteryDrain) {
        this.speed = speed;
        this.batteryDrain = batteryDrain;
    }
        
    public bool BatteryDrained() => battery - batteryDrain < 0;

    public int DistanceDriven() => distanceDriven;

    public void Drive()
    {
        if (battery - batteryDrain >= 0) {
            distanceDriven += speed;
            battery -= batteryDrain;
        }
    }

    public static RemoteControlCar Nitro() => new RemoteControlCar(50, 4);
}

class RaceTrack
{
    private int distance;
    
    // TODO: define the constructor for the 'RaceTrack' class
    public RaceTrack(int distance) {
        this.distance = distance;
    }
    
    public bool TryFinishTrack(RemoteControlCar car){
        while (!car.BatteryDrained()) {
            car.Drive();
        }
        return car.DistanceDriven() >= distance;
    }
}
