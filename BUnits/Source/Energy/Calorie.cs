namespace BUnits.Energy;

public struct Calorie
{
    public double units;

    public Calorie(double m){
        units = m;
    }

    public static Calorie operator +(Calorie a, Calorie b){
        return new(a.units + b.units);
    }
    public static Calorie operator +(Calorie a, double b){
        return new(a.units + b);
    }
    public static Calorie operator +(Calorie a, int b){
        return new(a.units + b);
    }

    public static Calorie operator -(Calorie a, Calorie b){
        return new(a.units - b.units);
    }
    public static Calorie operator -(Calorie a, double b){
        return new(a.units - b);
    }
    public static Calorie operator -(Calorie a, int b){
        return new(a.units - b);
    }

    public static Calorie operator /(Calorie a, Calorie b){
        return new(a.units / b.units);
    }
    public static Calorie operator /(Calorie a, double b){
        return new(a.units / b);
    }
    public static Calorie operator /(Calorie a, int b){
        return new(a.units / b);
    }


    public static Calorie operator *(Calorie a, Calorie b){
        return new(a.units * b.units);
    }
    public static Calorie operator *(Calorie a, double b){
        return new(a.units * b);
    }
    public static Calorie operator *(Calorie a, int b){
        return new(a.units * b);
    }

    public static bool operator >(Calorie a, Calorie b){
        return a.units > b.units;
    }
    public static bool operator >(Calorie a, double b){
        return a.units > b;
    }
    public static bool operator >(Calorie a, int b){
        return a.units > b;
    }

    public static bool operator <(Calorie a, Calorie b){
        return a.units < b.units;
    }
    public static bool operator <(Calorie a, double b){
        return a.units < b;
    }
    public static bool operator <(Calorie a, int b){
        return a.units < b;
    }

    public static implicit operator Calorie(double b){
        return new Calorie(b);
    }
    public static implicit operator Calorie(int b){
        return new Calorie(b);
    }
}




