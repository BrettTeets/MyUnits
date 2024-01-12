namespace BUnits.Distance;

public struct Meter
{
    public double units;

    public Meter(double m){
        units = m;
    }

    public static Meter operator +(Meter a, Meter b){
        return new(a.units + b.units);
    }
    public static Meter operator +(Meter a, double b){
        return new(a.units + b);
    }
    public static Meter operator +(Meter a, int b){
        return new(a.units + b);
    }

    public static Meter operator -(Meter a, Meter b){
        return new(a.units - b.units);
    }
    public static Meter operator -(Meter a, double b){
        return new(a.units - b);
    }
    public static Meter operator -(Meter a, int b){
        return new(a.units - b);
    }

    public static Meter operator /(Meter a, Meter b){
        return new(a.units / b.units);
    }
    public static Meter operator /(Meter a, double b){
        return new(a.units / b);
    }
    public static Meter operator /(Meter a, int b){
        return new(a.units / b);
    }


    public static Meter operator *(Meter a, Meter b){
        return new(a.units * b.units);
    }
    public static Meter operator *(Meter a, double b){
        return new(a.units * b);
    }
    public static Meter operator *(Meter a, int b){
        return new(a.units * b);
    }

    public static bool operator >(Meter a, Meter b){
        return a.units > b.units;
    }
    public static bool operator >(Meter a, double b){
        return a.units > b;
    }
    public static bool operator >(Meter a, int b){
        return a.units > b;
    }

    public static bool operator <(Meter a, Meter b){
        return a.units < b.units;
    }
    public static bool operator <(Meter a, double b){
        return a.units < b;
    }
    public static bool operator <(Meter a, int b){
        return a.units < b;
    }

    public static implicit operator Meter(double b){
        return new Meter(b);
    }
    public static implicit operator Meter(int b){
        return new Meter(b);
    }

    public static explicit operator Meter(Kilometer b){
        return new Meter(b.units*1000);
    }
    public static explicit operator Meter(Centimeter b){
        return new Meter(b.units/100);
    }
    public static explicit operator Meter(Millimeter b){
        return new Meter(b.units/1000);
    }
    public static explicit operator Meter(Micrometer b){
        return new Meter(b.units/1000000);
    }

}



