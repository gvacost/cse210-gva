using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shapes> shape = new List<Shapes>();

        Square nsq = new Square("red", 5);
        shape.Add(nsq);

        Rectangle nrec = new Rectangle("blue", 2, 4);
        shape.Add(nrec);

        Circle ncir = new Circle("yellow", 2);
        shape.Add(ncir);

        foreach (Shapes shap in shape)
        {
            string color = shap.GetColor();
            double area = shap.GetArea();
            
            Console.WriteLine($"The {color} shape has an area of {area}");
        }
    }
}