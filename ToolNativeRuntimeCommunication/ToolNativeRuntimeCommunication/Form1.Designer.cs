namespace ToolNativeRuntimeCommunication
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.shapeView = new System.Windows.Forms.ListBox();
			this.objectName = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.boxPanel = new System.Windows.Forms.Panel();
			this.maxY = new System.Windows.Forms.NumericUpDown();
			this.maxX = new System.Windows.Forms.NumericUpDown();
			this.minY = new System.Windows.Forms.NumericUpDown();
			this.minX = new System.Windows.Forms.NumericUpDown();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.circlePanel = new System.Windows.Forms.Panel();
			this.radius = new System.Windows.Forms.NumericUpDown();
			this.centerY = new System.Windows.Forms.NumericUpDown();
			this.centerX = new System.Windows.Forms.NumericUpDown();
			this.label7 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveAsXMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.addCircle = new System.Windows.Forms.Button();
			this.addBox = new System.Windows.Forms.Button();
			this.saveXmlDialog = new System.Windows.Forms.SaveFileDialog();
			this.boxPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.maxY)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.maxX)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.minY)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.minX)).BeginInit();
			this.circlePanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.radius)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.centerY)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.centerX)).BeginInit();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// shapeView
			// 
			this.shapeView.FormattingEnabled = true;
			this.shapeView.ItemHeight = 16;
			this.shapeView.Location = new System.Drawing.Point(12, 60);
			this.shapeView.Name = "shapeView";
			this.shapeView.Size = new System.Drawing.Size(518, 388);
			this.shapeView.TabIndex = 11;
			this.shapeView.SelectedIndexChanged += new System.EventHandler(this.shapeView_SelectedIndexChanged);
			this.shapeView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.shapeView_KeyDown);
			// 
			// objectName
			// 
			this.objectName.AcceptsReturn = true;
			this.objectName.Location = new System.Drawing.Point(545, 57);
			this.objectName.MaxLength = 50;
			this.objectName.Name = "objectName";
			this.objectName.Size = new System.Drawing.Size(150, 22);
			this.objectName.TabIndex = 1;
			this.objectName.TextChanged += new System.EventHandler(this.objectName_TextChanged);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(542, 37);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(45, 17);
			this.label4.TabIndex = 10;
			this.label4.Text = "Name";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(178, 10);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(43, 17);
			this.label3.TabIndex = 5;
			this.label3.Text = "Min Y";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(5, 10);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(43, 17);
			this.label1.TabIndex = 3;
			this.label1.Text = "Min X";
			// 
			// boxPanel
			// 
			this.boxPanel.Controls.Add(this.maxY);
			this.boxPanel.Controls.Add(this.maxX);
			this.boxPanel.Controls.Add(this.minY);
			this.boxPanel.Controls.Add(this.minX);
			this.boxPanel.Controls.Add(this.label5);
			this.boxPanel.Controls.Add(this.label6);
			this.boxPanel.Controls.Add(this.label1);
			this.boxPanel.Controls.Add(this.label3);
			this.boxPanel.Location = new System.Drawing.Point(545, 94);
			this.boxPanel.Name = "boxPanel";
			this.boxPanel.Size = new System.Drawing.Size(333, 72);
			this.boxPanel.TabIndex = 11;
			// 
			// maxY
			// 
			this.maxY.Location = new System.Drawing.Point(227, 39);
			this.maxY.Maximum = new decimal(new int[] {
            1080,
            0,
            0,
            0});
			this.maxY.Name = "maxY";
			this.maxY.Size = new System.Drawing.Size(96, 22);
			this.maxY.TabIndex = 9;
			this.maxY.ValueChanged += new System.EventHandler(this.maxY_ValueChanged);
			// 
			// maxX
			// 
			this.maxX.Location = new System.Drawing.Point(54, 42);
			this.maxX.Maximum = new decimal(new int[] {
            1920,
            0,
            0,
            0});
			this.maxX.Name = "maxX";
			this.maxX.Size = new System.Drawing.Size(96, 22);
			this.maxX.TabIndex = 8;
			this.maxX.ValueChanged += new System.EventHandler(this.maxX_ValueChanged);
			// 
			// minY
			// 
			this.minY.Location = new System.Drawing.Point(227, 8);
			this.minY.Maximum = new decimal(new int[] {
            1080,
            0,
            0,
            0});
			this.minY.Name = "minY";
			this.minY.Size = new System.Drawing.Size(96, 22);
			this.minY.TabIndex = 7;
			this.minY.ValueChanged += new System.EventHandler(this.minY_ValueChanged);
			// 
			// minX
			// 
			this.minX.Location = new System.Drawing.Point(54, 8);
			this.minX.Maximum = new decimal(new int[] {
            1920,
            0,
            0,
            0});
			this.minX.Name = "minX";
			this.minX.Size = new System.Drawing.Size(96, 22);
			this.minX.TabIndex = 6;
			this.minX.ValueChanged += new System.EventHandler(this.minX_ValueChanged);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(5, 44);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(46, 17);
			this.label5.TabIndex = 8;
			this.label5.Text = "Max X";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(178, 44);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(46, 17);
			this.label6.TabIndex = 9;
			this.label6.Text = "Max Y";
			// 
			// circlePanel
			// 
			this.circlePanel.Controls.Add(this.radius);
			this.circlePanel.Controls.Add(this.centerY);
			this.circlePanel.Controls.Add(this.centerX);
			this.circlePanel.Controls.Add(this.label7);
			this.circlePanel.Controls.Add(this.label9);
			this.circlePanel.Controls.Add(this.label10);
			this.circlePanel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.circlePanel.Location = new System.Drawing.Point(545, 217);
			this.circlePanel.Name = "circlePanel";
			this.circlePanel.Size = new System.Drawing.Size(333, 71);
			this.circlePanel.TabIndex = 12;
			// 
			// radius
			// 
			this.radius.DecimalPlaces = 1;
			this.radius.Location = new System.Drawing.Point(74, 39);
			this.radius.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
			this.radius.Name = "radius";
			this.radius.Size = new System.Drawing.Size(76, 22);
			this.radius.TabIndex = 4;
			this.radius.ValueChanged += new System.EventHandler(this.radius_ValueChanged);
			// 
			// centerY
			// 
			this.centerY.Location = new System.Drawing.Point(247, 8);
			this.centerY.Maximum = new decimal(new int[] {
            1080,
            0,
            0,
            0});
			this.centerY.Name = "centerY";
			this.centerY.Size = new System.Drawing.Size(76, 22);
			this.centerY.TabIndex = 3;
			this.centerY.ValueChanged += new System.EventHandler(this.centerY_ValueChanged);
			// 
			// centerX
			// 
			this.centerX.Location = new System.Drawing.Point(74, 8);
			this.centerX.Maximum = new decimal(new int[] {
            1920,
            0,
            0,
            0});
			this.centerX.Name = "centerX";
			this.centerX.Size = new System.Drawing.Size(76, 22);
			this.centerX.TabIndex = 2;
			this.centerX.ValueChanged += new System.EventHandler(this.centerX_ValueChanged);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(5, 41);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(52, 17);
			this.label7.TabIndex = 8;
			this.label7.Text = "Radius";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(3, 10);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(63, 17);
			this.label9.TabIndex = 3;
			this.label9.Text = "Center X";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(178, 10);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(63, 17);
			this.label10.TabIndex = 5;
			this.label10.Text = "Center Y";
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(894, 28);
			this.menuStrip1.TabIndex = 13;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveAsXMLToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
			this.fileToolStripMenuItem.Text = "File";
			// 
			// saveAsXMLToolStripMenuItem
			// 
			this.saveAsXMLToolStripMenuItem.Name = "saveAsXMLToolStripMenuItem";
			this.saveAsXMLToolStripMenuItem.Size = new System.Drawing.Size(162, 24);
			this.saveAsXMLToolStripMenuItem.Text = "Save As XML";
			this.saveAsXMLToolStripMenuItem.Click += new System.EventHandler(this.saveAsXMLToolStripMenuItem_Click);
			// 
			// editToolStripMenuItem
			// 
			this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem,
            this.redoToolStripMenuItem});
			this.editToolStripMenuItem.Name = "editToolStripMenuItem";
			this.editToolStripMenuItem.Size = new System.Drawing.Size(47, 24);
			this.editToolStripMenuItem.Text = "Edit";
			// 
			// undoToolStripMenuItem
			// 
			this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
			this.undoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
			this.undoToolStripMenuItem.Size = new System.Drawing.Size(165, 24);
			this.undoToolStripMenuItem.Text = "Undo";
			// 
			// redoToolStripMenuItem
			// 
			this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
			this.redoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
			this.redoToolStripMenuItem.Size = new System.Drawing.Size(165, 24);
			this.redoToolStripMenuItem.Text = "Redo";
			// 
			// addCircle
			// 
			this.addCircle.Location = new System.Drawing.Point(12, 31);
			this.addCircle.Name = "addCircle";
			this.addCircle.Size = new System.Drawing.Size(150, 23);
			this.addCircle.TabIndex = 5;
			this.addCircle.Text = "Add Circle";
			this.addCircle.UseVisualStyleBackColor = true;
			this.addCircle.Click += new System.EventHandler(this.addCircle_Click);
			// 
			// addBox
			// 
			this.addBox.Location = new System.Drawing.Point(168, 31);
			this.addBox.Name = "addBox";
			this.addBox.Size = new System.Drawing.Size(150, 23);
			this.addBox.TabIndex = 10;
			this.addBox.Text = "Add Box";
			this.addBox.UseVisualStyleBackColor = true;
			this.addBox.Click += new System.EventHandler(this.addBox_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(894, 508);
			this.Controls.Add(this.addBox);
			this.Controls.Add(this.addCircle);
			this.Controls.Add(this.circlePanel);
			this.Controls.Add(this.boxPanel);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.objectName);
			this.Controls.Add(this.shapeView);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "Form1";
			this.Text = "Tool-native-Runtime-Communication";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.boxPanel.ResumeLayout(false);
			this.boxPanel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.maxY)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.maxX)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.minY)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.minX)).EndInit();
			this.circlePanel.ResumeLayout(false);
			this.circlePanel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.radius)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.centerY)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.centerX)).EndInit();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListBox shapeView;
		private System.Windows.Forms.TextBox objectName;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel boxPanel;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Panel circlePanel;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.NumericUpDown centerX;
		private System.Windows.Forms.NumericUpDown radius;
		private System.Windows.Forms.NumericUpDown centerY;
		private System.Windows.Forms.NumericUpDown maxY;
		private System.Windows.Forms.NumericUpDown maxX;
		private System.Windows.Forms.NumericUpDown minY;
		private System.Windows.Forms.NumericUpDown minX;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem saveAsXMLToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
		private System.Windows.Forms.Button addCircle;
		private System.Windows.Forms.Button addBox;
		private System.Windows.Forms.SaveFileDialog saveXmlDialog;
	}
}

