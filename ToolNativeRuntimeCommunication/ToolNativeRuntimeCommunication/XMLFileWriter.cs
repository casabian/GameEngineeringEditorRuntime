using System.ComponentModel;
using System.IO;
using System.Xml;

namespace ToolNativeRuntimeCommunication
{
	/// <summary>
	/// XML writing class for writing game and level data
	/// </summary>
	public static class XMLFileWriter
	{
		public static void WriteData(BindingList<Shape> data, string filePath)
		{
			XmlWriterSettings settings = new XmlWriterSettings { Indent = true };
			if (!File.Exists(filePath))
				File.Create(filePath);
			XmlWriter writer = XmlWriter.Create(filePath, settings);
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