using System;

public class Fraction {
    private int _top;
    private int _bottom;

    public Fraction() {
        _top= 1;
        _bottom= 1;
        Console.WriteLine($"{_top}/{_bottom}");
    }
    public Fraction(int wholeNumber) {
        _top = wholeNumber;
        _bottom= 1;

    }
    public Fraction(int numerator, int denominator) {
        _top = numerator;
        _bottom = denominator;
    }

    public string GetFractionString() {
        string text = ($"{_top}/{_bottom}");
        return text;
    }

    public double GetDecimalValue() {
        return (double) _top / (double) _bottom;
    }

    // public void SetTop(int top) {
    //     _top= top;
    // }
    // public int GetTop() {
    //     return _top;
    // }   
    // public void SetBottom(int bottom) {
    //     _bottom= bottom;
    // }
    // public int GetBottom() {
    //     return _bottom;
    // }

}
