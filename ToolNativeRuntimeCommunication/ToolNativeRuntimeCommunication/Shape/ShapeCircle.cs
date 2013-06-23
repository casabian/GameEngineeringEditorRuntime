using System.Linq;
using System.Windows.Forms;
using System.Xml;

namespace ToolNativeRuntimeCommunication
{
	public class ShapeCircle : Shape
	{
		public int CenterX;

		public int CenterY;

		public float Radius;

		public ShapeCircle( string name )
			: base( name )
		{
			CenterX = 0;
			CenterY = 0;
			Radius = 0.0f;
		}

		public ShapeCircle( string name,
			int centerX,
			int centerY,
			float radius )
			: base( name )
		{
			CenterX = centerX;
			CenterY = centerY;
			Radius = radius;
		}

		public ShapeCircle( ShapeCircle other )
			: base( other )
		{
			CenterX = other.CenterX;
			CenterY = other.CenterY;
			Radius = other.Radius;
		}

		public override Shape Clone()
		{
			return new ShapeCircle( this );
		}

		public override void Serialize( ref XmlWriter xmlWriter )
		{
			xmlWriter.WriteStartElement( "Circle" );
			xmlWriter.WriteAttributeString( "Name", Name );
			xmlWriter.WriteAttributeString( "CenterX", CenterX.ToString() );
			xmlWriter.WriteAttributeString( "CenterY", CenterY.ToString() );
			xmlWriter.WriteAttributeString( "Radius", Radius.ToString() );
			xmlWriter.WriteEndElement();
		}

		public override string ToString()
		{
			return base.ToString() + " CenterX: " + CenterX +
				" CenterY: " + CenterY + " Radius: " + Radius;
		}
		public override void UpdateAttributes()
		{
			CenterX = (int)(view.Controls.Find( "centerX", false ).First() as NumericUpDown).Value;
			CenterY = (int)(view.Controls.Find( "centerY", false ).First() as NumericUpDown).Value;
			Radius = (float)(view.Controls.Find( "radius", false ).First() as NumericUpDown).Value;
		}

		public override void UpdateView()
		{
			(view.Controls.Find( "centerX", false ).First() as NumericUpDown).Value = CenterX;
			(view.Controls.Find( "centerY", false ).First() as NumericUpDown).Value = CenterY;
			(view.Controls.Find( "radius", false ).First() as NumericUpDown).Value = (decimal)Radius;
		}
	}
}