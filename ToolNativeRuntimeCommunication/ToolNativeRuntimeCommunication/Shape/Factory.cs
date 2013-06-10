using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ToolNativeRuntimeCommunication
{
	public class ShapeFactory
	{
		public static Shape Create(string typeString, string name)
		{
			Type type = Type.GetType("ToolNativeRuntimeCommunication." + typeString);
			return (Shape)Activator.CreateInstance( type, name );
		}
	}
}
