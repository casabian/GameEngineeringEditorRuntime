using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.Linq;

namespace ToolNativeRuntimeCommunication
{
	public enum ShapeType { Circle = 0, Box };

	public partial class Form1 : Form
	{
		private BindingList<Shape> shapesList = new BindingList<Shape>();

		public Form1()
		{
			InitializeComponent();

			// box handler
			minX.Validated += new EventHandler(UpdateShapeView);
			minY.Validated += new EventHandler(UpdateShapeView);
			maxX.Validated += new EventHandler(UpdateShapeView);
			maxY.Validated += new EventHandler(UpdateShapeView);

			// circle handler
			centerX.Validated += new EventHandler(UpdateShapeView);
			centerY.Validated += new EventHandler(UpdateShapeView);
			radius.Validated += new EventHandler(UpdateShapeView);

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
				if (shape is Box)
				{
					minX.Value = (shape as Box).MinX;
					minY.Value = (shape as Box).MinY;
					maxX.Value = (shape as Box).MaxX;
					maxY.Value = (shape as Box).MaxY;
				}
				else if (shape is Circle)
				{
					centerX.Value = (shape as Circle).CenterX;
					centerY.Value = (shape as Circle).CenterY;
					radius.Value = (decimal)(shape as Circle).Radius;
				}
				SetVisibilityOfAllGroupBoxesExcept(false, shape.GetView().Name);
			}
		}

		private void shapeView_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Delete)
			{
				shapesList.RemoveAt(shapeView.SelectedIndex);
				UpdateShapeView(this, EventArgs.Empty);
			}
		}

		private void addCircle_Click(object sender, EventArgs e)
		{
			Shape shape = new Circle(
					objectName.Text,
					(int)centerX.Value,
					(int)centerY.Value,
					(float)radius.Value
				);
			shape.RegisterView(ref circleView);
			shapesList.Add(shape);
			UpdateShapeView(this, EventArgs.Empty);
			SetVisibilityOfAllGroupBoxesExcept(true, boxView.Name);
			shapeView.SelectedIndex = shapeView.Items.Count - 1;
		}

		private void addBox_Click(object sender, EventArgs e)
		{
			Shape shape = new Box(
					objectName.Text,
					(int)minX.Value,
					(int)minY.Value,
					(int)maxX.Value,
					(int)maxY.Value
				);
			shape.RegisterView(ref boxView);
			shapesList.Add(shape);
			UpdateShapeView(this, EventArgs.Empty);
			SetVisibilityOfAllGroupBoxesExcept(true, circleView.Name);
			shapeView.SelectedIndex = shapeView.Items.Count - 1;
		}

		private void SetVisibilityOfAllGroupBoxesExcept(bool visibility, string except)
		{
			foreach (Control control in Controls.OfType<GroupBox>())
			{
				control.Visible = (except != null && control.Name == except) ? !visibility : visibility;
			}
		}

		private void saveAsXMLToolStripMenuItem_Click(object sender, EventArgs e)
		{
			saveXmlDialog = new SaveFileDialog();
			saveXmlDialog.Filter = "XML (*.xml)|*.xml";
			saveXmlDialog.FilterIndex = 1;
			saveXmlDialog.RestoreDirectory = true;
			saveXmlDialog.InitialDirectory = Application.ExecutablePath;

			if (saveXmlDialog.ShowDialog() == DialogResult.OK)
			{
				XMLFileWriter.WriteData(shapesList, saveXmlDialog.FileName);
			}
		}

		private void objectName_TextChanged(object sender, EventArgs e)
		{
			if (shapeView.SelectedIndex > -1)
			{
				shapesList[shapeView.SelectedIndex].Name = objectName.Text;
				UpdateShapeView(this, EventArgs.Empty);
			}
		}

		private void UpdateShapeView(object sender, EventArgs e)
		{
			if (shapeView.Items.Count > 0)
				shapesList[shapeView.SelectedIndex].UpdateView();
			shapeView.DataSource = null;
			shapeView.DataSource = shapesList;
		}
	}
}