namespace BUnits.Volume;

public struct Milliliter
{
    public double units;

    public Milliliter(double m){
        units = m;
    }

    public static Milliliter operator +(Milliliter a, Milliliter b){
        return new(a.units + b.units);
    }
    public static Milliliter operator +(Milliliter a, double b){
        return new(a.units + b);
    }
    public static Milliliter operator +(Milliliter a, int b){
        return new(a.units + b);
    }

    public static Milliliter operator -(Milliliter a, Milliliter b){
        return new(a.units - b.units);
    }
    public static Milliliter operator -(Milliliter a, double b){
        return new(a.units - b);
    }
    public static Milliliter operator -(Milliliter a, int b){
        return new(a.units - b);
    }

    public static Milliliter operator /(Milliliter a, Milliliter b){
        return new(a.units / b.units);
    }
    public static Milliliter operator /(Milliliter a, double b){
        return new(a.units / b);
    }
    public static Milliliter operator /(Milliliter a, int b){
        return new(a.units / b);
    }


    public static Milliliter operator *(Milliliter a, Milliliter b){
        return new(a.units * b.units);
    }
    public static Milliliter operator *(Milliliter a, double b){
        return new(a.units * b);
    }
    public static Milliliter operator *(Milliliter a, int b){
        return new(a.units * b);
    }

    public static bool operator >(Milliliter a, Milliliter b){
        return a.units > b.units;
    }
    public static bool operator >(Milliliter a, double b){
        return a.units > b;
    }
    public static bool operator >(Milliliter a, int b){
        return a.units > b;
    }

    public static bool operator <(Milliliter a, Milliliter b){
        return a.units < b.units;
    }
    public static bool operator <(Milliliter a, double b){
        return a.units < b;
    }
    public static bool operator <(Milliliter a, int b){
        return a.units < b;
    }

    public static implicit operator Milliliter(double b){
        return new Milliliter(b);
    }
    public static implicit operator Milliliter(int b){
        return new Milliliter(b);
    }

    public static explicit operator Milliliter(Liter b){
        return new Milliliter(b.units*1_000);
    }
    public static explicit operator Milliliter(Microliter b){
        return new Milliliter(b.units/1_000);
    }
}







