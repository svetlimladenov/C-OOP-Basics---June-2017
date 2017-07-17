﻿public class Rectangle : Shape
{
    private double height;
    private double width;

    public Rectangle(double height, double width)
    {
        this.Height = height;
        this.Width = width;
    }
    public double Width
    {
        get { return this.width; }
        set { this.width = value; }
    }

    public double Height
    {
        get { return this.height; }
        set { this.height = value; }
    }


    public sealed override double CalculatePerimeter()
    {
        return this.height * 2 + this.width * 2;
    }

    public sealed override double CalculateArea()
    {
        return this.height * this.width;
    }

    public override string Draw()
    {
        return base.Draw() + "Rectangle";
    }
}

