namespace BUnits.Volume;

public struct Liter
{
    public double units;

    public Liter(double m){
        units = m;
    }

    public static Liter operator +(Liter a, Liter b){
        return new(a.units + b.units);
    }
    public static Liter operator +(Liter a, double b){
        return new(a.units + b);
    }
    public static Liter operator +(Liter a, int b){
        return new(a.units + b);
    }

    public static Liter operator -(Liter a, Liter b){
        return new(a.units - b.units);
    }
    public static Liter operator -(Liter a, double b){
        return new(a.units - b);
    }
    public static Liter operator -(Liter a, int b){
        return new(a.units - b);
    }

    public static Liter operator /(Liter a, Liter b){
        return new(a.units / b.units);
    }
    public static Liter operator /(Liter a, double b){
        return new(a.units / b);
    }
    public static Liter operator /(Liter a, int b){
        return new(a.units / b);
    }


    public static Liter operator *(Liter a, Liter b){
        return new(a.units * b.units);
    }
    public static Liter operator *(Liter a, double b){
        return new(a.units * b);
    }
    public static Liter operator *(Liter a, int b){
        return new(a.units * b);
    }

    public static bool operator >(Liter a, Liter b){
        return a.units > b.units;
    }
    public static bool operator >(Liter a, double b){
        return a.units > b;
    }
    public static bool operator >(Liter a, int b){
        return a.units > b;
    }

    public static bool operator <(Liter a, Liter b){
        return a.units < b.units;
    }
    public static bool operator <(Liter a, double b){
        return a.units < b;
    }
    public static bool operator <(Liter a, int b){
        return a.units < b;
    }

    public static implicit operator Liter(double b){
        return new Liter(b);
    }
    public static implicit operator Liter(int b){
        return new Liter(b);
    }

    public static explicit operator Liter(Milliliter b){
        return new Liter(b.units/1_000);
    }
    public static explicit operator Liter(Microliter b){
        return new Liter(b.units/1_000_000);
    }
}









