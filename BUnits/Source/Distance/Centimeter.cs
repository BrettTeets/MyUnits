namespace BUnits.Distance;

public struct Centimeter
{
    public double units;

    public Centimeter(double m){
        units = m;
    }

    public static Centimeter operator +(Centimeter a, Centimeter b){
        return new(a.units + b.units);
    }
    public static Centimeter operator +(Centimeter a, double b){
        return new(a.units + b);
    }
    public static Centimeter operator +(Centimeter a, int b){
        return new(a.units + b);
    }

    public static Centimeter operator -(Centimeter a, Centimeter b){
        return new(a.units - b.units);
    }
    public static Centimeter operator -(Centimeter a, double b){
        return new(a.units - b);
    }
    public static Centimeter operator -(Centimeter a, int b){
        return new(a.units - b);
    }

    public static Centimeter operator /(Centimeter a, Centimeter b){
        return new(a.units / b.units);
    }
    public static Centimeter operator /(Centimeter a, double b){
        return new(a.units / b);
    }
    public static Centimeter operator /(Centimeter a, int b){
        return new(a.units / b);
    }


    public static Centimeter operator *(Centimeter a, Centimeter b){
        return new(a.units * b.units);
    }
    public static Centimeter operator *(Centimeter a, double b){
        return new(a.units * b);
    }
    public static Centimeter operator *(Centimeter a, int b){
        return new(a.units * b);
    }

    public static bool operator >(Centimeter a, Centimeter b){
        return a.units > b.units;
    }
    public static bool operator >(Centimeter a, double b){
        return a.units > b;
    }
    public static bool operator >(Centimeter a, int b){
        return a.units > b;
    }

    public static bool operator <(Centimeter a, Centimeter b){
        return a.units < b.units;
    }
    public static bool operator <(Centimeter a, double b){
        return a.units < b;
    }
    public static bool operator <(Centimeter a, int b){
        return a.units < b;
    }

    public static implicit operator Centimeter(double b){
        return new Centimeter(b);
    }
    public static implicit operator Centimeter(int b){
        return new Centimeter(b);
    }

    public static explicit operator Centimeter(Kilometer b){
        return new Centimeter(b.units * 100_000);
    }
    public static explicit operator Centimeter(Meter b){
        return new Centimeter(b.units * 100);
    }
    public static explicit operator Centimeter(Millimeter b){
        return new Centimeter(b.units / 10);
    }
    public static explicit operator Centimeter(Micrometer b){
        return new Centimeter(b.units /10_000);
    }
}

