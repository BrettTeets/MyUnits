namespace BUnits.Mass;

public struct Microgram
{
    public double units;

    public Microgram(double m){
        units = m;
    }

    public static Microgram operator +(Microgram a, Microgram b){
        return new(a.units + b.units);
    }
    public static Microgram operator +(Microgram a, double b){
        return new(a.units + b);
    }
    public static Microgram operator +(Microgram a, int b){
        return new(a.units + b);
    }

    public static Microgram operator -(Microgram a, Microgram b){
        return new(a.units - b.units);
    }
    public static Microgram operator -(Microgram a, double b){
        return new(a.units - b);
    }
    public static Microgram operator -(Microgram a, int b){
        return new(a.units - b);
    }

    public static Microgram operator /(Microgram a, Microgram b){
        return new(a.units / b.units);
    }
    public static Microgram operator /(Microgram a, double b){
        return new(a.units / b);
    }
    public static Microgram operator /(Microgram a, int b){
        return new(a.units / b);
    }


    public static Microgram operator *(Microgram a, Microgram b){
        return new(a.units * b.units);
    }
    public static Microgram operator *(Microgram a, double b){
        return new(a.units * b);
    }
    public static Microgram operator *(Microgram a, int b){
        return new(a.units * b);
    }

    public static bool operator >(Microgram a, Microgram b){
        return a.units > b.units;
    }
    public static bool operator >(Microgram a, double b){
        return a.units > b;
    }
    public static bool operator >(Microgram a, int b){
        return a.units > b;
    }

    public static bool operator <(Microgram a, Microgram b){
        return a.units < b.units;
    }
    public static bool operator <(Microgram a, double b){
        return a.units < b;
    }
    public static bool operator <(Microgram a, int b){
        return a.units < b;
    }

    public static implicit operator Microgram(double b){
        return new Microgram(b);
    }
    public static implicit operator Microgram(int b){
        return new Microgram(b);
    }

    public static explicit operator Microgram(MetricTon b){
        return new Microgram(b.units*1_000_000_000_000);
    }
    public static explicit operator Microgram(Kilogram b){
        return new Microgram(b.units*1_000_000_000);
    }
    public static explicit operator Microgram(Gram b){
        return new Microgram(b.units*1_000_000);
    }
    public static explicit operator Microgram(Milligram b){
        return new Microgram(b.units*1_000);
    }
    
}







