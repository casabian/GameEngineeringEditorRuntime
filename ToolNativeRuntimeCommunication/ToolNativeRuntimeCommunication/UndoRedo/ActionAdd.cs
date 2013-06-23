using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace ToolNativeRuntimeCommunication.UndoRedo
{
	public class ActionAdd : Action
	{
		private GroupBox	shapeView;
		private ListBox		shapesListView;

		public ActionAdd( Shape shape, BindingList<Shape> shapesList, ref GroupBox shapeView, ref ListBox shapesListView )
			: base( shape, shapesList )
		{
			this.shapeView = shapeView;
			this.shapesListView = shapesListView;
		}

		override public void Redo()
		{
			shapesList.Insert( affectedListIndex, shape );
			shapesListView.SelectedIndex = affectedListIndex;
			shapeView.Visible = true;
		}

		override public void Undo()
		{
			shapesList.RemoveAt( affectedListIndex );

			if ( shapesList.Count == 0 )
				shapeView.Visible = false;
		}
	}
}