namespace BUnits.Mass;

public struct MetricTon
{
    public double units;

    public MetricTon(double m){
        units = m;
    }

    public static MetricTon operator +(MetricTon a, MetricTon b){
        return new(a.units + b.units);
    }
    public static MetricTon operator +(MetricTon a, double b){
        return new(a.units + b);
    }
    public static MetricTon operator +(MetricTon a, int b){
        return new(a.units + b);
    }

    public static MetricTon operator -(MetricTon a, MetricTon b){
        return new(a.units - b.units);
    }
    public static MetricTon operator -(MetricTon a, double b){
        return new(a.units - b);
    }
    public static MetricTon operator -(MetricTon a, int b){
        return new(a.units - b);
    }

    public static MetricTon operator /(MetricTon a, MetricTon b){
        return new(a.units / b.units);
    }
    public static MetricTon operator /(MetricTon a, double b){
        return new(a.units / b);
    }
    public static MetricTon operator /(MetricTon a, int b){
        return new(a.units / b);
    }


    public static MetricTon operator *(MetricTon a, MetricTon b){
        return new(a.units * b.units);
    }
    public static MetricTon operator *(MetricTon a, double b){
        return new(a.units * b);
    }
    public static MetricTon operator *(MetricTon a, int b){
        return new(a.units * b);
    }

    public static bool operator >(MetricTon a, MetricTon b){
        return a.units > b.units;
    }
    public static bool operator >(MetricTon a, double b){
        return a.units > b;
    }
    public static bool operator >(MetricTon a, int b){
        return a.units > b;
    }

    public static bool operator <(MetricTon a, MetricTon b){
        return a.units < b.units;
    }
    public static bool operator <(MetricTon a, double b){
        return a.units < b;
    }
    public static bool operator <(MetricTon a, int b){
        return a.units < b;
    }

    public static implicit operator MetricTon(double b){
        return new MetricTon(b);
    }
    public static implicit operator MetricTon(int b){
        return new MetricTon(b);
    }
}







