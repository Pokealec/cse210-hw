public class Circle : Shape{

    private double radius;

    public Circle(double circRadius, string shapeColor) : base(shapeColor){
        radius = circRadius;
    }

    public override double GetArea(){
        return Math.PI * (radius * radius);
    }

}