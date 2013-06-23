using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace ToolNativeRuntimeCommunication.UndoRedo
{
	public delegate void UndoHandler( bool enable );
	public delegate void RedoHandler( bool enable );
	
	public class UndoRedoManager
	{
		public UndoHandler UndoNotifier;
		public RedoHandler RedoNotifier;

		private List<Action> actions = new List<Action>();

		private int currentActionIndex = 0;

		public void AddActionAdd( Shape shape, BindingList<Shape> shapesList, ref GroupBox shapeView, ref ListBox shapesListView )
		{
			actions.Add( new ActionAdd( shape, shapesList, ref shapeView, ref shapesListView ) );
			UpdateValues();
		}

		public void AddActionDelete( Shape shape, BindingList<Shape> shapesList, ref GroupBox shapeView, ref ListBox shapesListView )
		{
			actions.Add( new ActionDelete( shape, shapesList, ref shapeView, ref shapesListView ) );
			UpdateValues();
		}

		public void AddActionEdit( Shape shape, BindingList<Shape> shapesList, Shape shapeBeforeEdit )
		{
			actions.Add( new ActionEdit( shape, shapesList, shapeBeforeEdit ) );
			UpdateValues();
		}

		public void Undo()
		{
			actions[currentActionIndex - 1].Undo();
			
			if ( currentActionIndex == 0 && UndoNotifier != null )
				UndoNotifier( false );

			--currentActionIndex;

			if ( RedoNotifier != null )
				RedoNotifier( true );
		}

		public void Redo()
		{
			++currentActionIndex;
			if ( currentActionIndex == actions.Count - 1 && RedoNotifier != null )
				RedoNotifier( false );
			actions[currentActionIndex - 1].Redo();

			if ( UndoNotifier != null )
				UndoNotifier( true );
		}

		private void UpdateValues()
		{
			if ( currentActionIndex < actions.Count - 1 )
			{
				actions.RemoveRange( currentActionIndex + 1, actions.Count - currentActionIndex - 1 );
				if ( RedoNotifier != null )
					RedoNotifier( false );
			}
			currentActionIndex = actions.Count;
		}
	}
}