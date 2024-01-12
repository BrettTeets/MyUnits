namespace BUnits.Mass;

public struct Gram
{
    public double units;

    public Gram(double m){
        units = m;
    }

    public static Gram operator +(Gram a, Gram b){
        return new(a.units + b.units);
    }
    public static Gram operator +(Gram a, double b){
        return new(a.units + b);
    }
    public static Gram operator +(Gram a, int b){
        return new(a.units + b);
    }

    public static Gram operator -(Gram a, Gram b){
        return new(a.units - b.units);
    }
    public static Gram operator -(Gram a, double b){
        return new(a.units - b);
    }
    public static Gram operator -(Gram a, int b){
        return new(a.units - b);
    }

    public static Gram operator /(Gram a, Gram b){
        return new(a.units / b.units);
    }
    public static Gram operator /(Gram a, double b){
        return new(a.units / b);
    }
    public static Gram operator /(Gram a, int b){
        return new(a.units / b);
    }


    public static Gram operator *(Gram a, Gram b){
        return new(a.units * b.units);
    }
    public static Gram operator *(Gram a, double b){
        return new(a.units * b);
    }
    public static Gram operator *(Gram a, int b){
        return new(a.units * b);
    }

    public static bool operator >(Gram a, Gram b){
        return a.units > b.units;
    }
    public static bool operator >(Gram a, double b){
        return a.units > b;
    }
    public static bool operator >(Gram a, int b){
        return a.units > b;
    }

    public static bool operator <(Gram a, Gram b){
        return a.units < b.units;
    }
    public static bool operator <(Gram a, double b){
        return a.units < b;
    }
    public static bool operator <(Gram a, int b){
        return a.units < b;
    }

    public static implicit operator Gram(double b){
        return new Gram(b);
    }
    public static implicit operator Gram(int b){
        return new Gram(b);
    }

    public static explicit operator Gram(MetricTon b){
        return new Gram(b.units*1_000_000);
    }
    public static explicit operator Gram(Kilogram b){
        return new Gram(b.units*1_000);
    }
    public static explicit operator Gram(Milligram b){
        return new Gram(b.units/1_000);
    }
    public static explicit operator Gram(Microgram b){
        return new Gram(b.units/1_000_000);
    }
}







