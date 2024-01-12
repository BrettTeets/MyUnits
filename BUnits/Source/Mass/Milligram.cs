namespace BUnits.Mass;

public struct Milligram
{
    public double units;

    public Milligram(double m){
        units = m;
    }

    public static Milligram operator +(Milligram a, Milligram b){
        return new(a.units + b.units);
    }
    public static Milligram operator +(Milligram a, double b){
        return new(a.units + b);
    }
    public static Milligram operator +(Milligram a, int b){
        return new(a.units + b);
    }

    public static Milligram operator -(Milligram a, Milligram b){
        return new(a.units - b.units);
    }
    public static Milligram operator -(Milligram a, double b){
        return new(a.units - b);
    }
    public static Milligram operator -(Milligram a, int b){
        return new(a.units - b);
    }

    public static Milligram operator /(Milligram a, Milligram b){
        return new(a.units / b.units);
    }
    public static Milligram operator /(Milligram a, double b){
        return new(a.units / b);
    }
    public static Milligram operator /(Milligram a, int b){
        return new(a.units / b);
    }


    public static Milligram operator *(Milligram a, Milligram b){
        return new(a.units * b.units);
    }
    public static Milligram operator *(Milligram a, double b){
        return new(a.units * b);
    }
    public static Milligram operator *(Milligram a, int b){
        return new(a.units * b);
    }

    public static bool operator >(Milligram a, Milligram b){
        return a.units > b.units;
    }
    public static bool operator >(Milligram a, double b){
        return a.units > b;
    }
    public static bool operator >(Milligram a, int b){
        return a.units > b;
    }

    public static bool operator <(Milligram a, Milligram b){
        return a.units < b.units;
    }
    public static bool operator <(Milligram a, double b){
        return a.units < b;
    }
    public static bool operator <(Milligram a, int b){
        return a.units < b;
    }

    public static implicit operator Milligram(double b){
        return new Milligram(b);
    }
    public static implicit operator Milligram(int b){
        return new Milligram(b);
    }

    public static explicit operator Milligram(MetricTon b){
        return new Milligram(b.units*1_000_000_000);
    }
    public static explicit operator Milligram(Kilogram b){
        return new Milligram(b.units*1_000_000);
    }
    public static explicit operator Milligram(Gram b){
        return new Milligram(b.units*1_000);
    }
    public static explicit operator Milligram(Microgram b){
        return new Milligram(b.units/1_000);
    }
}







