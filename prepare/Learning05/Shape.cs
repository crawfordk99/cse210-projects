public abstract class Shape {
    private string _color;

    public Shape() {

    }
    public Shape(string color) {
        SetColor(color);
    }
    public abstract double GetArea();
    
    public void SetColor(string color) {
        _color = color;
    }
    public string GetColor() {
        return _color;
    }

}