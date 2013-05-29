using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ToolNativeRuntimeCommunication
{
	public interface IFactory
	{
		Shape Create(string Type);
	}

	public class Factory
	{
		public Shape Create(string Type)
		{
			if (Type == "Circle")
			{

			}
			else if (Type == "Box")
			{
			}
		}
	}
}
