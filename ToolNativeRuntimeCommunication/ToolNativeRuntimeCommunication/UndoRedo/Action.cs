using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace ToolNativeRuntimeCommunication.UndoRedo
{
	abstract public class Action
	{
		protected Shape					shape;
		protected BindingList<Shape>	shapesList;

		protected int					affectedListIndex;

		public Action( Shape shape, BindingList<Shape> shapesList )
		{
			this.shape = shape;
			this.shapesList = shapesList;
			this.affectedListIndex = shapesList.TakeWhile( s => s != shape).Count();
		}

		abstract public void Undo();
		abstract public void Redo();
	}
}
