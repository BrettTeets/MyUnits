namespace BUnits.Tempature;

public struct Celcius
{
    public double units;

    public Celcius(double m){
        units = m;
    }

    public static Celcius operator +(Celcius a, Celcius b){
        return new(a.units + b.units);
    }
    public static Celcius operator +(Celcius a, double b){
        return new(a.units + b);
    }
    public static Celcius operator +(Celcius a, int b){
        return new(a.units + b);
    }

    public static Celcius operator -(Celcius a, Celcius b){
        return new(a.units - b.units);
    }
    public static Celcius operator -(Celcius a, double b){
        return new(a.units - b);
    }
    public static Celcius operator -(Celcius a, int b){
        return new(a.units - b);
    }

    public static Celcius operator /(Celcius a, Celcius b){
        return new(a.units / b.units);
    }
    public static Celcius operator /(Celcius a, double b){
        return new(a.units / b);
    }
    public static Celcius operator /(Celcius a, int b){
        return new(a.units / b);
    }


    public static Celcius operator *(Celcius a, Celcius b){
        return new(a.units * b.units);
    }
    public static Celcius operator *(Celcius a, double b){
        return new(a.units * b);
    }
    public static Celcius operator *(Celcius a, int b){
        return new(a.units * b);
    }

    public static bool operator >(Celcius a, Celcius b){
        return a.units > b.units;
    }
    public static bool operator >(Celcius a, double b){
        return a.units > b;
    }
    public static bool operator >(Celcius a, int b){
        return a.units > b;
    }

    public static bool operator <(Celcius a, Celcius b){
        return a.units < b.units;
    }
    public static bool operator <(Celcius a, double b){
        return a.units < b;
    }
    public static bool operator <(Celcius a, int b){
        return a.units < b;
    }

    public static implicit operator Celcius(double b){
        return new Celcius(b);
    }
    public static implicit operator Celcius(int b){
        return new Celcius(b);
    }
}









