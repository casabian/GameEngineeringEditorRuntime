using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace ToolNativeRuntimeCommunication
{
	public enum ShapeType { Circle = 0, Box };

	public partial class Form1 : Form
	{
		private BindingList<Shape> shapesList = new BindingList<Shape>();

		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
		}

		private void objectName_TextChanged(object sender, EventArgs e)
		{
			if (shapeView.SelectedIndex > -1)
			{
				shapesList[shapeView.SelectedIndex].Name = objectName.Text;
				UpdateShapeView();
			}
		}

		private void shapeView_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (shapeView.SelectedIndex > -1)
			{
				Shape shape = shapesList[shapeView.SelectedIndex];

				objectName.Text = shape.Name;
				if (shape.GetType() == typeof(Box))
				{
					minX.Value = (shape as Box).MinX;
					minY.Value = (shape as Box).MinY;
					maxX.Value = (shape as Box).MaxX;
					maxY.Value = (shape as Box).MaxY;
				}
				else if (shapesList[shapeView.SelectedIndex].GetType() == typeof(Circle))
				{
					centerX.Value = (shape as Circle).CenterX;
					centerY.Value = (shape as Circle).CenterY;
					radius.Value = (decimal)(shape as Circle).Radius;
				}
			}
		}

		private void shapeView_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Delete)
			{
				shapesList.RemoveAt(shapeView.SelectedIndex);
				UpdateShapeView();
			}
		}

		private void centerX_ValueChanged(object sender, EventArgs e)
		{
			if (shapeView.SelectedIndex > -1 && shapesList[shapeView.SelectedIndex] is Circle)
			{
				(shapesList[shapeView.SelectedIndex] as Circle).CenterX = (int)centerX.Value;
				UpdateShapeView();
			}
		}

		private void centerY_ValueChanged(object sender, EventArgs e)
		{
			if (shapeView.SelectedIndex > -1 && shapesList[shapeView.SelectedIndex] is Circle)
			{
				(shapesList[shapeView.SelectedIndex] as Circle).CenterY = (int)centerY.Value;
				UpdateShapeView();
			}
		}

		private void radius_ValueChanged(object sender, EventArgs e)
		{
			if (shapeView.SelectedIndex > -1 && shapesList[shapeView.SelectedIndex] is Circle)
			{
				(shapesList[shapeView.SelectedIndex] as Circle).Radius = (float)radius.Value;
				UpdateShapeView();
			}
		}

		private void minX_ValueChanged(object sender, EventArgs e)
		{
			if (shapeView.SelectedIndex > -1 && shapesList[shapeView.SelectedIndex] is Box)
			{
				(shapesList[shapeView.SelectedIndex] as Box).MinX = (int)minX.Value;
				UpdateShapeView();
			}
		}

		private void minY_ValueChanged(object sender, EventArgs e)
		{
			if (shapeView.SelectedIndex > -1 && shapesList[shapeView.SelectedIndex] is Box)
			{
				(shapesList[shapeView.SelectedIndex] as Box).MinY = (int)minY.Value;
				UpdateShapeView();
			}
		}

		private void maxX_ValueChanged(object sender, EventArgs e)
		{
			if (shapeView.SelectedIndex > -1 && shapesList[shapeView.SelectedIndex] is Box)
			{
				(shapesList[shapeView.SelectedIndex] as Box).MaxX = (int)maxX.Value;
				UpdateShapeView();
			}
		}

		private void maxY_ValueChanged(object sender, EventArgs e)
		{
			if (shapeView.SelectedIndex > -1 && shapesList[shapeView.SelectedIndex] is Box)
			{
				(shapesList[shapeView.SelectedIndex] as Box).MaxY = (int)maxX.Value;
				UpdateShapeView();
			}
		}

		private void addCircle_Click(object sender, EventArgs e)
		{
			shapesList.Add(new Circle(
					objectName.Text,
					(int)centerX.Value,
					(int)centerY.Value,
					(float)radius.Value
				)
			);
			UpdateShapeView();
			shapeView.SelectedIndex = shapeView.Items.Count - 1;
		}

		private void addBox_Click(object sender, EventArgs e)
		{
			shapesList.Add(
				new Box(
					objectName.Text,
					(int)minX.Value,
					(int)minY.Value,
					(int)maxX.Value,
					(int)maxY.Value
				)
			);
			UpdateShapeView();
			shapeView.SelectedIndex = shapeView.Items.Count - 1;
		}

		private void UpdateShapeView()
		{
			shapeView.DataSource = null;
			shapeView.DataSource = shapesList;
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
	}
}