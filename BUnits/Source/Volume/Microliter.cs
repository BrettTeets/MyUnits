namespace BUnits.Volume;

public struct Microliter
{
    public double units;

    public Microliter(double m){
        units = m;
    }

    public static Microliter operator +(Microliter a, Microliter b){
        return new(a.units + b.units);
    }
    public static Microliter operator +(Microliter a, double b){
        return new(a.units + b);
    }
    public static Microliter operator +(Microliter a, int b){
        return new(a.units + b);
    }

    public static Microliter operator -(Microliter a, Microliter b){
        return new(a.units - b.units);
    }
    public static Microliter operator -(Microliter a, double b){
        return new(a.units - b);
    }
    public static Microliter operator -(Microliter a, int b){
        return new(a.units - b);
    }

    public static Microliter operator /(Microliter a, Microliter b){
        return new(a.units / b.units);
    }
    public static Microliter operator /(Microliter a, double b){
        return new(a.units / b);
    }
    public static Microliter operator /(Microliter a, int b){
        return new(a.units / b);
    }


    public static Microliter operator *(Microliter a, Microliter b){
        return new(a.units * b.units);
    }
    public static Microliter operator *(Microliter a, double b){
        return new(a.units * b);
    }
    public static Microliter operator *(Microliter a, int b){
        return new(a.units * b);
    }

    public static bool operator >(Microliter a, Microliter b){
        return a.units > b.units;
    }
    public static bool operator >(Microliter a, double b){
        return a.units > b;
    }
    public static bool operator >(Microliter a, int b){
        return a.units > b;
    }

    public static bool operator <(Microliter a, Microliter b){
        return a.units < b.units;
    }
    public static bool operator <(Microliter a, double b){
        return a.units < b;
    }
    public static bool operator <(Microliter a, int b){
        return a.units < b;
    }

    public static implicit operator Microliter(double b){
        return new Microliter(b);
    }
    public static implicit operator Microliter(int b){
        return new Microliter(b);
    }

    public static explicit operator Microliter(Liter b){
        return new Microliter(b.units*1_000_000);
    }
    public static explicit operator Microliter(Milliliter b){
        return new Microliter(b.units*1_000);
    }
    
}







