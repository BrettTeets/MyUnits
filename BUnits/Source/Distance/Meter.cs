namespace BUnits.Distance;

public struct Meter
{
    public double meter;

    public Meter(double m){
        meter = m;
    }

    public static Meter operator +(Meter a, Meter b){
        return new(a.meter + b.meter);
    }
    public static Meter operator +(Meter a, double b){
        return new(a.meter + b);
    }
    public static Meter operator +(Meter a, int b){
        return new(a.meter + b);
    }

    public static Meter operator -(Meter a, Meter b){
        return new(a.meter - b.meter);
    }
    public static Meter operator -(Meter a, double b){
        return new(a.meter - b);
    }
    public static Meter operator -(Meter a, int b){
        return new(a.meter - b);
    }

    public static Meter operator /(Meter a, Meter b){
        return new(a.meter / b.meter);
    }
    public static Meter operator /(Meter a, double b){
        return new(a.meter / b);
    }
    public static Meter operator /(Meter a, int b){
        return new(a.meter / b);
    }


    public static Meter operator *(Meter a, Meter b){
        return new(a.meter * b.meter);
    }
    public static Meter operator *(Meter a, double b){
        return new(a.meter * b);
    }
    public static Meter operator *(Meter a, int b){
        return new(a.meter * b);
    }

    public static bool operator >(Meter a, Meter b){
        return a.meter > b.meter;
    }
    public static bool operator >(Meter a, double b){
        return a.meter > b;
    }
    public static bool operator >(Meter a, int b){
        return a.meter > b;
    }

    public static bool operator <(Meter a, Meter b){
        return a.meter < b.meter;
    }
    public static bool operator <(Meter a, double b){
        return a.meter < b;
    }
    public static bool operator <(Meter a, int b){
        return a.meter < b;
    }

    public static implicit operator Meter(double b){
        return new Meter(b);
    }
    public static implicit operator Meter(int b){
        return new Meter(b);
    }

    public static explicit operator Meter(Kilometer b){
        return new Meter(b.meter*1000);
    }
    public static explicit operator Meter(Centimeter b){
        return new Meter(b.meter/100);
    }
    public static explicit operator Meter(Millimeter b){
        return new Meter(b.meter/1000);
    }
    public static explicit operator Meter(Micrometer b){
        return new Meter(b.meter/1000000);
    }

}



