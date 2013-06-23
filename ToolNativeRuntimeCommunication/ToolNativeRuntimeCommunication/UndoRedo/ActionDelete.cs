using System.ComponentModel;
using System.Windows.Forms;

namespace ToolNativeRuntimeCommunication.UndoRedo
{
	public class ActionDelete : ActionAdd
	{
		public ActionDelete( Shape shape, BindingList<Shape> shapesList, ref GroupBox shapeView, ref ListBox shapesListView )
			: base( shape, shapesList, ref shapeView, ref shapesListView )
		{
		}

		override public void Redo()
		{
			base.Undo();
		}

		override public void Undo()
		{
			base.Redo();
		}
	}
}