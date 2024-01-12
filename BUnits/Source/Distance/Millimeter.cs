namespace BUnits.Distance;

public struct Millimeter
{
    public double units;

    public Millimeter(double m){
        units = m;
    }

    public static Millimeter operator +(Millimeter a, Millimeter b){
        return new(a.units + b.units);
    }
    public static Millimeter operator +(Millimeter a, double b){
        return new(a.units + b);
    }
    public static Millimeter operator +(Millimeter a, int b){
        return new(a.units + b);
    }

    public static Millimeter operator -(Millimeter a, Millimeter b){
        return new(a.units - b.units);
    }
    public static Millimeter operator -(Millimeter a, double b){
        return new(a.units - b);
    }
    public static Millimeter operator -(Millimeter a, int b){
        return new(a.units - b);
    }

    public static Millimeter operator /(Millimeter a, Millimeter b){
        return new(a.units / b.units);
    }
    public static Millimeter operator /(Millimeter a, double b){
        return new(a.units / b);
    }
    public static Millimeter operator /(Millimeter a, int b){
        return new(a.units / b);
    }


    public static Millimeter operator *(Millimeter a, Millimeter b){
        return new(a.units * b.units);
    }
    public static Millimeter operator *(Millimeter a, double b){
        return new(a.units * b);
    }
    public static Millimeter operator *(Millimeter a, int b){
        return new(a.units * b);
    }

    public static bool operator >(Millimeter a, Millimeter b){
        return a.units > b.units;
    }
    public static bool operator >(Millimeter a, double b){
        return a.units > b;
    }
    public static bool operator >(Millimeter a, int b){
        return a.units > b;
    }

    public static bool operator <(Millimeter a, Millimeter b){
        return a.units < b.units;
    }
    public static bool operator <(Millimeter a, double b){
        return a.units < b;
    }
    public static bool operator <(Millimeter a, int b){
        return a.units < b;
    }

    public static implicit operator Millimeter(double b){
        return new Millimeter(b);
    }
    public static implicit operator Millimeter(int b){
        return new Millimeter(b);
    }

    public static explicit operator Millimeter(Kilometer b){
        return new Millimeter(b.units * 1_000_000);
    }
    public static explicit operator Millimeter(Meter b){
        return new Millimeter(b.units * 1_000);
    }
    public static explicit operator Millimeter(Centimeter b){
        return new Millimeter(b.units * 10);
    }
    public static explicit operator Millimeter(Micrometer b){
        return new Millimeter(b.units / 1_000);
    }


}

