using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Windows.Forms;

namespace ToolNativeRuntimeCommunication
{
	class ShapeRectangle : Shape
	{
        public ShapeRectangle(string name)
            : base(name)
        {
            MinX = 0;
            MinY = 0;
            MaxX = 0;
            MaxY = 0;
        }
       
		public ShapeRectangle(
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

		public ShapeRectangle(ShapeRectangle other)
			: base(other)
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
			(view.Controls.Find("minX", false).First() as NumericUpDown).Value = MinX;
			(view.Controls.Find("minY", false).First() as NumericUpDown).Value = MinY;
			(view.Controls.Find("maxX", false).First() as NumericUpDown).Value = MaxX;
			(view.Controls.Find("maxY", false).First() as NumericUpDown).Value = MaxY;
		}

		public override void UpdateAttributes()
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
}
