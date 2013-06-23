using System.ComponentModel;
using System.Threading;

namespace ToolNativeRuntimeCommunication.UndoRedo
{
	public class ActionEdit : Action
	{
		public Shape shapeBeforeEdit;

		public ActionEdit( Shape shape, BindingList<Shape> shapesList, Shape shapeBeforeEdit )
			: base( shape, shapesList )
		{
			this.shapeBeforeEdit = shapeBeforeEdit;
		}

		override public void Redo()
		{
			shapesList[affectedListIndex] = Interlocked.Exchange( ref shapeBeforeEdit, shapesList[affectedListIndex] );
			shapesList[affectedListIndex].UpdateView();
		}

		override public void Undo()
		{
			this.Redo();
		}
	}
}