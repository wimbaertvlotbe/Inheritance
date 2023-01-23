using System;

namespace Inheritance
{

	public abstract class Shape
	{
		Color shapeColor;
		int width;
		List<Point> vertices;
		string name;


		public Shape(Color color, int width, params Point[] vertices)
		{
			this.shapeColor = color;
			this.width = width;
			this.vertices = vertices;
			this.name = "shape";
		}

		public virtual void Draw(Graphics g)
		{
			foreach (Point p in vertices)
			{
				Console.WriteLine($"{p.X},{p.Y}");
			}
		}

		public abstract double Area()
		{
			return 0;
		}

		public virtual new ToString()
		{
			return this.name;
		}

		public Color ShapeColor
		{
			get { return color}
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

