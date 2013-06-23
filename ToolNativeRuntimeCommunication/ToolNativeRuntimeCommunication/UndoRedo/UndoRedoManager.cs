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

		private Stack<Action> undoStack = new Stack<Action>();
		private Stack<Action> redoStack = new Stack<Action>();

		public bool HasUndo { get { return undoStack.Count > 0; } }

		public bool HasRedo { get { return redoStack.Count > 0; } }

		public void AddAction( Action action )
		{
			redoStack.Clear();

			undoStack.Push( action );

			UpdateNotifier();
		}

		public void Undo()
		{
			if ( !HasUndo )
				return;
			
			Action action = undoStack.Pop();
			action.Undo();
			redoStack.Push( action );
			UpdateNotifier();
		}

		public void Redo()
		{
			if ( !HasRedo )
				return;
			
			Action action = redoStack.Pop();
			action.Redo();
			undoStack.Push( action );
			UpdateNotifier();
		}

		private void UpdateNotifier()
		{
			RedoNotifier( HasRedo );
			UndoNotifier( HasUndo );
		}
	}
}