class Rectangle : Shape {
    private double l;
    private double w;

    public Rectangle(string color, double l, double w) : base(color)
    {
        this.l = l;
        this.w = w;
    }

    public override double GetArea()
    {
        return l*w;
    }
}