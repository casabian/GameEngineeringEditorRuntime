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

		void UpdateAttributes();

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

        public static Shape Create(string typeString, string name)
        {
            Type type = Type.GetType("ToolNativeRuntimeCommunication." + typeString);
            return (Shape)Activator.CreateInstance(type, name);
        }
        
        public abstract void Serialize(ref XmlWriter xmlWriter);

		public abstract void UpdateView();

		public abstract void UpdateAttributes();

		public string Name { get; set; }
		protected GroupBox view { get; set; }
	}
}
