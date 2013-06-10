using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Text;

namespace ToolNativeRuntimeCommunication
{
	/// <summary>
	/// XML writing class for writing game and level data
	/// </summary>
	public static class XMLTextWriter
	{
		public static void AsFile(BindingList<Shape> data, string filePath)
		{
			XmlWriterSettings settings = new XmlWriterSettings { Indent = false, NewLineHandling = NewLineHandling.None };
			if (!File.Exists(filePath))
				File.Create(filePath);
			XmlWriter writer = XmlWriter.Create(filePath, settings);

			writeData(ref data, ref writer);
		}

		public static void AsString(BindingList<Shape> data, ref string output)
		{
			XmlWriterSettings settings = new XmlWriterSettings { Indent = false, NewLineHandling = NewLineHandling.None };

			StringBuilder sb = new StringBuilder();
			XmlWriter writer = XmlWriter.Create(sb, settings);

			writeData(ref data, ref writer);
			output = sb.ToString();
		}

		
		private static void writeData(ref BindingList<Shape> data, ref XmlWriter writer)
		{
			writer.WriteStartDocument();
			{
				writer.WriteStartElement("Shapes");
				{
					foreach (Shape shape in data)
						shape.Serialize(ref writer);
				}
				writer.WriteEndElement();
			}
			writer.Close();
		}
	}
}