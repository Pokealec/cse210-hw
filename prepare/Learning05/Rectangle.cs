public class Rectangle : Shape{

    private double length;
    private double width;
    
    public Rectangle(double recLength, double recWidth, string shapeColor) : base(shapeColor){
        length = recLength;
        width = recWidth;
    }


    public override double GetArea(){
        return length * width;
    }

}