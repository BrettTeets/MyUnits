namespace BUnits.Distance;

public struct Micrometer
{
    public double units;

    public Micrometer(double m){
        units = m;
    }

    public static Micrometer operator +(Micrometer a, Micrometer b){
        return new(a.units + b.units);
    }
    public static Micrometer operator +(Micrometer a, double b){
        return new(a.units + b);
    }
    public static Micrometer operator +(Micrometer a, int b){
        return new(a.units + b);
    }

    public static Micrometer operator -(Micrometer a, Micrometer b){
        return new(a.units - b.units);
    }
    public static Micrometer operator -(Micrometer a, double b){
        return new(a.units - b);
    }
    public static Micrometer operator -(Micrometer a, int b){
        return new(a.units - b);
    }

    public static Micrometer operator /(Micrometer a, Micrometer b){
        return new(a.units / b.units);
    }
    public static Micrometer operator /(Micrometer a, double b){
        return new(a.units / b);
    }
    public static Micrometer operator /(Micrometer a, int b){
        return new(a.units / b);
    }


    public static Micrometer operator *(Micrometer a, Micrometer b){
        return new(a.units * b.units);
    }
    public static Micrometer operator *(Micrometer a, double b){
        return new(a.units * b);
    }
    public static Micrometer operator *(Micrometer a, int b){
        return new(a.units * b);
    }

    public static bool operator >(Micrometer a, Micrometer b){
        return a.units > b.units;
    }
    public static bool operator >(Micrometer a, double b){
        return a.units > b;
    }
    public static bool operator >(Micrometer a, int b){
        return a.units > b;
    }

    public static bool operator <(Micrometer a, Micrometer b){
        return a.units < b.units;
    }
    public static bool operator <(Micrometer a, double b){
        return a.units < b;
    }
    public static bool operator <(Micrometer a, int b){
        return a.units < b;
    }

    public static implicit operator Micrometer(double b){
        return new Micrometer(b);
    }
    public static implicit operator Micrometer(int b){
        return new Micrometer(b);
    }

    public static explicit operator Micrometer(Kilometer b){
        return new Micrometer(b.units*1_000_000_000);
    }
    public static explicit operator Micrometer(Meter b){
        return new Micrometer(b.units*1_000_000);
    }
    public static explicit operator Micrometer(Centimeter b){
        return new Micrometer(b.units*10_000);
    }
    public static explicit operator Micrometer(Millimeter b){
        return new Micrometer(b.units*1_000);
    }
}

