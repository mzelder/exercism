class Lasagna
{
    // TODO: define the 'ExpectedMinutesInOven()' method
    public int ExpectedMinutesInOven() {
        return 40;
    }
    // TODO: define the 'RemainingMinutesInOven()' method
    public int RemainingMinutesInOven(int alreadyInOven) {
        return 40 - alreadyInOven;
    }
    // TODO: define the 'PreparationTimeInMinutes()' method
    public int PreparationTimeInMinutes(int layers) {
        return layers * 2;
    }
    // TODO: define the 'ElapsedTimeInMinutes()' method
    public int ElapsedTimeInMinutes(int layers, int alreadyInOven) {
        return PreparationTimeInMinutes(layers) + alreadyInOven;
    }
}
