namespace BUnits.Mass;

public struct Kilogram
{
    public double units;

    public Kilogram(double m){
        units = m;
    }

    public static Kilogram operator +(Kilogram a, Kilogram b){
        return new(a.units + b.units);
    }
    public static Kilogram operator +(Kilogram a, double b){
        return new(a.units + b);
    }
    public static Kilogram operator +(Kilogram a, int b){
        return new(a.units + b);
    }

    public static Kilogram operator -(Kilogram a, Kilogram b){
        return new(a.units - b.units);
    }
    public static Kilogram operator -(Kilogram a, double b){
        return new(a.units - b);
    }
    public static Kilogram operator -(Kilogram a, int b){
        return new(a.units - b);
    }

    public static Kilogram operator /(Kilogram a, Kilogram b){
        return new(a.units / b.units);
    }
    public static Kilogram operator /(Kilogram a, double b){
        return new(a.units / b);
    }
    public static Kilogram operator /(Kilogram a, int b){
        return new(a.units / b);
    }


    public static Kilogram operator *(Kilogram a, Kilogram b){
        return new(a.units * b.units);
    }
    public static Kilogram operator *(Kilogram a, double b){
        return new(a.units * b);
    }
    public static Kilogram operator *(Kilogram a, int b){
        return new(a.units * b);
    }

    public static bool operator >(Kilogram a, Kilogram b){
        return a.units > b.units;
    }
    public static bool operator >(Kilogram a, double b){
        return a.units > b;
    }
    public static bool operator >(Kilogram a, int b){
        return a.units > b;
    }

    public static bool operator <(Kilogram a, Kilogram b){
        return a.units < b.units;
    }
    public static bool operator <(Kilogram a, double b){
        return a.units < b;
    }
    public static bool operator <(Kilogram a, int b){
        return a.units < b;
    }

    public static implicit operator Kilogram(double b){
        return new Kilogram(b);
    }
    public static implicit operator Kilogram(int b){
        return new Kilogram(b);
    }
}







