using System.Drawing;

public abstract class Shape{ // Abstract = things can be empty in this class

    private string color;

    public Shape(string shapeColor){
        color = shapeColor;
    }

    public string GetColor(){
        return color;
    }

    public void SetColor(string newColor){
        color = newColor;
    }

    public abstract double GetArea(); // All children should have this function, so expect it.
}