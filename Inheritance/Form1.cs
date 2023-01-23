using System.Drawing;
using System.Text;

namespace Inheritance
{
    public partial class Form1 : Form
    {
        List<Triangle> triangles = new List<Triangle> ();
        Bitmap bmp;
        Graphics g;
        public Form1()
        {
            InitializeComponent();
            bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            g = Graphics.FromImage(bmp);
        }

        //Point p1 = new Point(100, 100);
        //Point p2 = new Point(150, 150);
        //Point p3 = new Point(50, 150);
        //Triangle t = new Triangle(Color.Blue, 2, p1, p2, p3);
        //triangles.Add(t);
        //    toString.Enabled = true;
        private void draw_Click(object sender, EventArgs e)
        {
            foreach (Triangle t in triangles)
              textBox1.Text += t.Draw(g);
        }

        private void toString_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            foreach (Triangle t in triangles)
                textBox1.Text += t.ToString();
        }

        private void createTriangle_Click(object sender, EventArgs e)
        {
            //Hoekpunten van de driehoek
            Point p1 = new Point(100, 100);
            Point p2 = new Point(150, 150);
            Point p3 = new Point(50, 150);

            //Maak driehoek
            Triangle t = new Triangle(Color.Blue, 2, p1, p2, p3);

            //voeg driehoek toe aan list van driehoeken
            triangles.Add(t);

            //enable knoppen
            toString.Enabled = true;
            draw.Enabled = true;
        }
    }

    //class Triangle
    public class Triangle : Shape
    {
        static int volgnummer = 0;
        public Triangle(Color color,int width,Point p1, Point p2, Point p3):
            base(color, width,p1,p2,p3)
        {
            this.Name = "triangle" + volgnummer.ToString();
            volgnummer++;
        }

        public override double Area()
        {
            throw new NotImplementedException();
        }
    }

    //class Square
    //public class Square
    //{

    //}

    //class Shape
    public abstract class Shape
    {
        Color shapeColor;
        int width;
        List<Point> vertices = new List<Point>();
        string name;


        public Shape(Color color, int width, params Point[] vertices)
        {
            this.shapeColor = color;
            this.width = width;
            this.vertices.AddRange(vertices);
            this.name = "shape";
        }

        public virtual string Draw(Graphics g)
        {
            StringBuilder sb = new StringBuilder();
            Point vorigPunt = default(Point);
            Point eerstePunt = default(Point);
            bool start = true;

            sb.AppendLine();
            sb.AppendLine(this.name);
            sb.AppendLine();

            foreach (Point p in vertices)
            {
                if (start)
                {
                    start = false;
                    vorigPunt = p;
                    eerstePunt = p;
                }
                else
                {
                    sb.AppendLine($"Lijn van punt ({vorigPunt.X},{vorigPunt.Y}) naar punt ({p.X},{p.Y})");
                    vorigPunt = p;
                }
            }

            sb.AppendLine($"Lijn van punt ({vorigPunt.X},{vorigPunt.Y}) naar punt ({eerstePunt.X},{eerstePunt.Y})");

            return sb.ToString();
        }

        public abstract double Area();


        public virtual new string ToString()
        {
            StringBuilder sb = new StringBuilder();
            int i = 0;
            sb.AppendLine($"Naam van de polygoon : {this.name}");
            foreach (Point p in vertices)
            {
                i++;
                sb.AppendLine($"punt {i} : ({p.X},{p.Y})");
            }

            return sb.ToString();
        }

        public Color ShapeColor
        {
            get { return this.shapeColor; }
        }

        public int Width
        {
            get { return width; }
            set { width = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public List<Point> Vertices
        {
            get { return vertices; }
            set { vertices = value; }
        }
    }
}