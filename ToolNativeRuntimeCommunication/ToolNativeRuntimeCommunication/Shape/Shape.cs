using System;
using System.Windows.Forms;
using System.Xml;

namespace ToolNativeRuntimeCommunication
{
	public interface IShape
	{
		void GetView( ref GroupBox view );

		void RegisterView( ref GroupBox view );

		void Serialize( ref XmlWriter xmlWriter );
		
		void UpdateAttributes();

		void UpdateView();
	}

	public abstract class Shape : IShape
	{
		public Shape( string name )
		{
			Name = name;
		}

		public Shape( Shape other )
		{
			Name = other.Name;
			view = other.view;
		}

		public string Name { get; set; }

		protected GroupBox view { get; set; }

		// copy constructor not working =/
		abstract public Shape Clone();

		public static Shape Create( string typeString, string name )
		{
			Type type = Type.GetType( "ToolNativeRuntimeCommunication." + typeString );
			return (Shape)Activator.CreateInstance( type, name );
		}

		public virtual void GetView( ref GroupBox view )
		{
			view = this.view;
		}

		public virtual void RegisterView( ref GroupBox view )
		{
			this.view = view;
		}

		public abstract void Serialize( ref XmlWriter xmlWriter );

		public override string ToString()
		{
			return Name;
		}
		public abstract void UpdateAttributes();

		public abstract void UpdateView();
	}
}