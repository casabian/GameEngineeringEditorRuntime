using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Windows.Forms;

namespace ToolNativeRuntimeCommunication
{
	public interface IShape
	{
		void Serialize(ref XmlWriter xmlWriter);

		GroupBox GetView();

		void UpdateView();

		void RegisterView(ref GroupBox view);
	}

	public abstract class Shape : IShape
	{
		public Shape(string name)
		{
			Name = name;
		}

		public Shape(Shape other)
		{
			Name = other.Name;
		}
		
		public override string ToString()
		{
			return Name;
		}

		public virtual GroupBox GetView()
		{
			return view;
		}

		public virtual void RegisterView(ref GroupBox view)
		{
			this.view = view;
		}

		public abstract void Serialize(ref XmlWriter xmlWriter);

		public abstract void UpdateView();



		public string Name { get; set; }
		protected GroupBox view { get; set; }
	}

	public class Box : Shape
	{
		public Box(string name) :
			base(name)
		{

		}
		
		public Box(
			string name, 
			int minX, int minY, 
			int maxX, int maxY)
			: base(name)
		{
			MinX = minX;
			MinY = minY;
			MaxX = maxX;
			MaxY = maxY;
		}

		public Box(Box other) : base(other)
		{
			MinX = other.MinX;
			MinY = other.MinY;
			MaxX = other.MaxX;
			MaxY = other.MaxY;
		}

		public override string ToString()
		{
			return base.ToString() + " MinX: " + MinX + " MinY: " + MinY +
				" MaxX: " + MaxX + " MaxY: " + MaxY;
		}

		public override void Serialize(ref XmlWriter xmlWriter)
		{
			xmlWriter.WriteStartElement("Box");
			xmlWriter.WriteAttributeString("Name", Name);
			xmlWriter.WriteAttributeString("MinX", MinX.ToString());
			xmlWriter.WriteAttributeString("MinY", MinY.ToString());
			xmlWriter.WriteAttributeString("MaxX", MaxX.ToString());
			xmlWriter.WriteAttributeString("MaxY", MaxY.ToString());
			xmlWriter.WriteEndElement();
		}

		public override void UpdateView()
		{
			MinX = (int)(view.Controls.Find("minX", false).First() as NumericUpDown).Value;
			MinY = (int)(view.Controls.Find("minY", false).First() as NumericUpDown).Value;
			MaxX = (int)(view.Controls.Find("maxX", false).First() as NumericUpDown).Value;
			MaxY = (int)(view.Controls.Find("maxY", false).First() as NumericUpDown).Value;
		}

		public int MinX;
		public int MinY;
		public int MaxX;
		public int MaxY;
	}

	public class Circle : Shape
	{
		public Circle(string name) : 
			base(name)
		{

		}

		public Circle(string name, 
			int centerX, 
			int centerY, 
			float radius)
			: base(name)
		{
			CenterX = centerX;
			CenterY = centerY;
			Radius = radius;
		}

		public Circle(Circle other) : base(other)
		{
			CenterX = other.CenterX;
			CenterY = other.CenterY;
			Radius = other.Radius;
		}

		public override string ToString()
		{
			return base.ToString() + " CenterX: " + CenterX +
				" CenterY: " + CenterY + " Radius: " + Radius;
		}

		public override void Serialize(ref XmlWriter xmlWriter)
		{
			xmlWriter.WriteStartElement("Circle");
			xmlWriter.WriteAttributeString("Name", Name);
			xmlWriter.WriteAttributeString("CenterX", CenterX.ToString());
			xmlWriter.WriteAttributeString("CenterY", CenterY.ToString());
			xmlWriter.WriteAttributeString("Radius", Radius.ToString());
			xmlWriter.WriteEndElement();
		}

		public override void UpdateView()
		{
			CenterX = (int)(view.Controls.Find("centerX", false).First() as NumericUpDown).Value;
			CenterY = (int)(view.Controls.Find("centerY", false).First() as NumericUpDown).Value;
			Radius = (float)(view.Controls.Find("radius", false).First() as NumericUpDown).Value;
		}

		public int CenterX;
		public int CenterY;
		public float Radius;
	}
}
