public class Square : Shape{

    private int side;

    public Square(int squareSide, string shapeColor) : base(shapeColor){
        side = squareSide;
    }

    public override double GetArea(){
        return side * side;
    }


}