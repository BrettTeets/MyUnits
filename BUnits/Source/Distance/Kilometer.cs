namespace BUnits.Distance;

public struct Kilometer
{
    public double units;

    public Kilometer(double m){
        units = m;
    }

    public static Kilometer operator +(Kilometer a, Kilometer b){
        return new(a.units + b.units);
    }
    public static Kilometer operator +(Kilometer a, double b){
        return new(a.units + b);
    }
    public static Kilometer operator +(Kilometer a, int b){
        return new(a.units + b);
    }

    public static Kilometer operator -(Kilometer a, Kilometer b){
        return new(a.units - b.units);
    }
    public static Kilometer operator -(Kilometer a, double b){
        return new(a.units - b);
    }
    public static Kilometer operator -(Kilometer a, int b){
        return new(a.units - b);
    }

    public static Kilometer operator /(Kilometer a, Kilometer b){
        return new(a.units / b.units);
    }
    public static Kilometer operator /(Kilometer a, double b){
        return new(a.units / b);
    }
    public static Kilometer operator /(Kilometer a, int b){
        return new(a.units / b);
    }


    public static Kilometer operator *(Kilometer a, Kilometer b){
        return new(a.units * b.units);
    }
    public static Kilometer operator *(Kilometer a, double b){
        return new(a.units * b);
    }
    public static Kilometer operator *(Kilometer a, int b){
        return new(a.units * b);
    }

    public static bool operator >(Kilometer a, Kilometer b){
        return a.units > b.units;
    }
    public static bool operator >(Kilometer a, double b){
        return a.units > b;
    }
    public static bool operator >(Kilometer a, int b){
        return a.units > b;
    }

    public static bool operator <(Kilometer a, Kilometer b){
        return a.units < b.units;
    }
    public static bool operator <(Kilometer a, double b){
        return a.units < b;
    }
    public static bool operator <(Kilometer a, int b){
        return a.units < b;
    }

    public static implicit operator Kilometer(double b){
        return new Kilometer(b);
    }
    public static implicit operator Kilometer(int b){
        return new Kilometer(b);
    }

    public static explicit operator Kilometer(Meter b){
        return new Kilometer(b.units/1000);
    }
    public static explicit operator Kilometer(Centimeter b){
        return new Kilometer(b.units/100_000);
    }
    public static explicit operator Kilometer(Millimeter b){
        return new Kilometer(b.units/1_000_000);
    }
    public static explicit operator Kilometer(Micrometer b){
        return new Kilometer(b.units/1_000_000_000);
    }
}

