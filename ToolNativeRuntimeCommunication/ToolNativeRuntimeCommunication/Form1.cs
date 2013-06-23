using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.Linq;

namespace ToolNativeRuntimeCommunication
{
	public partial class Form1 : Form
	{
        private BindingList<Shape> shapesList = new BindingList<Shape>();

		private Server server = new Server();

		private UndoRedo.UndoRedoManager undoRedoManager = new UndoRedo.UndoRedoManager();

		public Form1()
		{
			InitializeComponent();

			// box handler
			minX.Validated += new EventHandler(UpdateShapeAttributes);
			minY.Validated += new EventHandler(UpdateShapeAttributes);
			maxX.Validated += new EventHandler(UpdateShapeAttributes);
			maxY.Validated += new EventHandler(UpdateShapeAttributes);

			// circle handler
			centerX.Validated += new EventHandler(UpdateShapeAttributes);
			centerY.Validated += new EventHandler(UpdateShapeAttributes);
			radius.Validated += new EventHandler(UpdateShapeAttributes);

			server.Start();

			undoRedoManager.RedoNotifier += new UndoRedo.RedoHandler( EnableRedo );
			undoRedoManager.UndoNotifier += new UndoRedo.UndoHandler( EnableUndo );

			SetVisibilityOfAllGroupBoxesExcept(false, null);
		}

		private void Form1_Load(object sender, EventArgs e)
		{
		}

		private void shapeView_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (shapeView.SelectedIndex > -1)
			{
                Shape shape = shapesList[shapeView.SelectedIndex];
				objectName.Text = shape.Name;

				shape.UpdateView();

				SetVisibilityOfAllGroupBoxesExcept(false, shape.GetView().Name);
			}
		}

		private void shapeView_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Delete && shapeView.SelectedIndex > -1)
			{
				Shape shapeToDelete = (shapeView.SelectedItem as Shape);
				GroupBox view = shapeToDelete.GetView();
				undoRedoManager.AddActionDelete( shapeToDelete, shapesList, ref view, ref shapeView );
				
				shapesList.RemoveAt(shapeView.SelectedIndex);
				UpdateShapeAttributes(this, EventArgs.Empty);
			}
		}

		private void addCircle_Click(object sender, EventArgs e)
		{
            Shape shape = Shape.Create(ShapeCircle.Name, objectName.Text);
			shape.RegisterView(ref circleView);
			shapesList.Add(shape);
			UpdateShapeAttributes(this, EventArgs.Empty);
			SetVisibilityOfAllGroupBoxesExcept(true, boxView.Name);
			shapeView.SelectedIndex = shapeView.Items.Count - 1;

			GroupBox view = shape.GetView();
			undoRedoManager.AddActionAdd( shape, shapesList, ref view, ref shapeView );
		}

		private void addBox_Click(object sender, EventArgs e)
		{
            Shape shape = Shape.Create(ShapeRectangle.Name, objectName.Text);
			shape.RegisterView(ref boxView);
			shapesList.Add(shape);
			UpdateShapeAttributes(this, EventArgs.Empty);
			SetVisibilityOfAllGroupBoxesExcept(true, circleView.Name);
			shapeView.SelectedIndex = shapeView.Items.Count - 1;

			GroupBox view = shape.GetView();
			undoRedoManager.AddActionAdd( shape, shapesList, ref view, ref shapeView );
		}

		private void SetVisibilityOfAllGroupBoxesExcept(bool visibility, string except)
		{
			foreach (Control control in Controls.OfType<GroupBox>())
				control.Visible = (except != null && control.Name == except) ? !visibility : visibility;
		}

		private void saveAsXMLToolStripMenuItem_Click(object sender, EventArgs e)
		{
			saveXmlDialog = new SaveFileDialog();
			saveXmlDialog.Filter = "XML (*.xml)|*.xml";
			saveXmlDialog.FilterIndex = 1;
			saveXmlDialog.RestoreDirectory = true;
			saveXmlDialog.InitialDirectory = Application.ExecutablePath;

			if (saveXmlDialog.ShowDialog() == DialogResult.OK)
				XMLTextWriter.AsFile(shapesList, saveXmlDialog.FileName);
		}

		private void objectName_TextChanged(object sender, EventArgs e)
		{
			if (shapeView.SelectedIndex > -1)
			{
				shapesList[shapeView.SelectedIndex].Name = objectName.Text;
				UpdateShapeAttributes(this, EventArgs.Empty);
			}
		}

		private void UpdateShapeAttributes(object sender, EventArgs e)
		{
			if ( shapeView.Items.Count > 0 )
			{
				Shape shapeBeforeEdit = shapesList[shapeView.SelectedIndex];
				shapesList[shapeView.SelectedIndex].UpdateAttributes();

				undoRedoManager.AddActionEdit( shapesList[shapeView.SelectedIndex], shapesList, shapeBeforeEdit );
				
			}
			shapeView.DataSource = null;
			shapeView.DataSource = shapesList;

			if (useTcp.Checked)
			{
				string xmlString = "";
				XMLTextWriter.AsString(shapesList, ref xmlString);

				lock (server.MessageToSend)
				{
					server.MessageToSend = xmlString;
				}
			}
		}

		public void EnableUndo( bool enable )
		{
			undoToolStripMenuItem.Enabled = enable;
		}

		public void EnableRedo( bool enable )
		{
			redoToolStripMenuItem.Enabled = enable;
		}

		private void undoToolStripMenuItem_Click( object sender, EventArgs e )
		{
			undoRedoManager.Undo();
		}

		private void redoToolStripMenuItem_Click( object sender, EventArgs e )
		{
			undoRedoManager.Redo();
		}
	}
}