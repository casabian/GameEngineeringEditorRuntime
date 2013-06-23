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
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveAsXMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ShapeCircle = new System.Windows.Forms.Button();
			this.ShapeRectangle = new System.Windows.Forms.Button();
			this.saveXmlDialog = new System.Windows.Forms.SaveFileDialog();
			this.circleView = new System.Windows.Forms.GroupBox();
			this.radius = new System.Windows.Forms.NumericUpDown();
			this.centerY = new System.Windows.Forms.NumericUpDown();
			this.centerX = new System.Windows.Forms.NumericUpDown();
			this.label7 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.boxView = new System.Windows.Forms.GroupBox();
			this.maxY = new System.Windows.Forms.NumericUpDown();
			this.maxX = new System.Windows.Forms.NumericUpDown();
			this.minY = new System.Windows.Forms.NumericUpDown();
			this.minX = new System.Windows.Forms.NumericUpDown();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.useTcp = new System.Windows.Forms.CheckBox();
			this.menuStrip1.SuspendLayout();
			this.circleView.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.radius)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.centerY)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.centerX)).BeginInit();
			this.boxView.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.maxY)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.maxX)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.minY)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.minX)).BeginInit();
			this.SuspendLayout();
			// 
			// shapeView
			// 
			this.shapeView.FormattingEnabled = true;
			this.shapeView.Location = new System.Drawing.Point( 9, 49 );
			this.shapeView.Margin = new System.Windows.Forms.Padding( 2 );
			this.shapeView.Name = "shapeView";
			this.shapeView.Size = new System.Drawing.Size( 390, 316 );
			this.shapeView.TabIndex = 11;
			this.shapeView.SelectedIndexChanged += new System.EventHandler( this.shapeView_SelectedIndexChanged );
			this.shapeView.KeyDown += new System.Windows.Forms.KeyEventHandler( this.shapeView_KeyDown );
			// 
			// objectName
			// 
			this.objectName.AcceptsReturn = true;
			this.objectName.Location = new System.Drawing.Point( 409, 46 );
			this.objectName.Margin = new System.Windows.Forms.Padding( 2 );
			this.objectName.MaxLength = 50;
			this.objectName.Name = "objectName";
			this.objectName.Size = new System.Drawing.Size( 251, 20 );
			this.objectName.TabIndex = 1;
			this.objectName.TextChanged += new System.EventHandler( this.objectName_TextChanged );
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point( 406, 30 );
			this.label4.Margin = new System.Windows.Forms.Padding( 2, 0, 2, 0 );
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size( 35, 13 );
			this.label4.TabIndex = 10;
			this.label4.Text = "Name";
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange( new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem} );
			this.menuStrip1.Location = new System.Drawing.Point( 0, 0 );
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Padding = new System.Windows.Forms.Padding( 4, 2, 0, 2 );
			this.menuStrip1.Size = new System.Drawing.Size( 670, 24 );
			this.menuStrip1.TabIndex = 13;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange( new System.Windows.Forms.ToolStripItem[] {
            this.saveAsXMLToolStripMenuItem} );
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size( 37, 20 );
			this.fileToolStripMenuItem.Text = "File";
			// 
			// saveAsXMLToolStripMenuItem
			// 
			this.saveAsXMLToolStripMenuItem.Name = "saveAsXMLToolStripMenuItem";
			this.saveAsXMLToolStripMenuItem.Size = new System.Drawing.Size( 141, 22 );
			this.saveAsXMLToolStripMenuItem.Text = "Save As XML";
			this.saveAsXMLToolStripMenuItem.Click += new System.EventHandler( this.saveAsXMLToolStripMenuItem_Click );
			// 
			// editToolStripMenuItem
			// 
			this.editToolStripMenuItem.DropDownItems.AddRange( new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem,
            this.redoToolStripMenuItem} );
			this.editToolStripMenuItem.Name = "editToolStripMenuItem";
			this.editToolStripMenuItem.Size = new System.Drawing.Size( 39, 20 );
			this.editToolStripMenuItem.Text = "Edit";
			// 
			// undoToolStripMenuItem
			// 
			this.undoToolStripMenuItem.Enabled = false;
			this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
			this.undoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
			this.undoToolStripMenuItem.Size = new System.Drawing.Size( 152, 22 );
			this.undoToolStripMenuItem.Text = "Undo";
			this.undoToolStripMenuItem.Click += new System.EventHandler( this.undoToolStripMenuItem_Click );
			// 
			// redoToolStripMenuItem
			// 
			this.redoToolStripMenuItem.Enabled = false;
			this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
			this.redoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
			this.redoToolStripMenuItem.Size = new System.Drawing.Size( 152, 22 );
			this.redoToolStripMenuItem.Text = "Redo";
			this.redoToolStripMenuItem.Click += new System.EventHandler( this.redoToolStripMenuItem_Click );
			// 
			// ShapeCircle
			// 
			this.ShapeCircle.Location = new System.Drawing.Point( 9, 25 );
			this.ShapeCircle.Margin = new System.Windows.Forms.Padding( 2 );
			this.ShapeCircle.Name = "ShapeCircle";
			this.ShapeCircle.Size = new System.Drawing.Size( 112, 19 );
			this.ShapeCircle.TabIndex = 5;
			this.ShapeCircle.Text = "Add Circle";
			this.ShapeCircle.UseVisualStyleBackColor = true;
			this.ShapeCircle.Click += new System.EventHandler( this.addCircle_Click );
			// 
			// ShapeRectangle
			// 
			this.ShapeRectangle.Location = new System.Drawing.Point( 126, 25 );
			this.ShapeRectangle.Margin = new System.Windows.Forms.Padding( 2 );
			this.ShapeRectangle.Name = "ShapeRectangle";
			this.ShapeRectangle.Size = new System.Drawing.Size( 112, 19 );
			this.ShapeRectangle.TabIndex = 10;
			this.ShapeRectangle.Text = "Add Box";
			this.ShapeRectangle.UseVisualStyleBackColor = true;
			this.ShapeRectangle.Click += new System.EventHandler( this.addBox_Click );
			// 
			// circleView
			// 
			this.circleView.Controls.Add( this.radius );
			this.circleView.Controls.Add( this.centerY );
			this.circleView.Controls.Add( this.centerX );
			this.circleView.Controls.Add( this.label7 );
			this.circleView.Controls.Add( this.label9 );
			this.circleView.Controls.Add( this.label10 );
			this.circleView.Location = new System.Drawing.Point( 409, 78 );
			this.circleView.Margin = new System.Windows.Forms.Padding( 2 );
			this.circleView.Name = "circleView";
			this.circleView.Padding = new System.Windows.Forms.Padding( 2 );
			this.circleView.Size = new System.Drawing.Size( 250, 70 );
			this.circleView.TabIndex = 14;
			this.circleView.TabStop = false;
			this.circleView.Text = "Circle Attributes";
			// 
			// radius
			// 
			this.radius.DecimalPlaces = 1;
			this.radius.Location = new System.Drawing.Point( 58, 45 );
			this.radius.Margin = new System.Windows.Forms.Padding( 2 );
			this.radius.Maximum = new decimal( new int[] {
            10000,
            0,
            0,
            0} );
			this.radius.Name = "radius";
			this.radius.Size = new System.Drawing.Size( 57, 20 );
			this.radius.TabIndex = 12;
			// 
			// centerY
			// 
			this.centerY.Location = new System.Drawing.Point( 188, 20 );
			this.centerY.Margin = new System.Windows.Forms.Padding( 2 );
			this.centerY.Maximum = new decimal( new int[] {
            1080,
            0,
            0,
            0} );
			this.centerY.Name = "centerY";
			this.centerY.Size = new System.Drawing.Size( 57, 20 );
			this.centerY.TabIndex = 10;
			// 
			// centerX
			// 
			this.centerX.Location = new System.Drawing.Point( 58, 20 );
			this.centerX.Margin = new System.Windows.Forms.Padding( 2 );
			this.centerX.Maximum = new decimal( new int[] {
            1920,
            0,
            0,
            0} );
			this.centerX.Name = "centerX";
			this.centerX.Size = new System.Drawing.Size( 57, 20 );
			this.centerX.TabIndex = 9;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point( 6, 46 );
			this.label7.Margin = new System.Windows.Forms.Padding( 2, 0, 2, 0 );
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size( 40, 13 );
			this.label7.TabIndex = 14;
			this.label7.Text = "Radius";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point( 4, 21 );
			this.label9.Margin = new System.Windows.Forms.Padding( 2, 0, 2, 0 );
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size( 48, 13 );
			this.label9.TabIndex = 11;
			this.label9.Text = "Center X";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point( 136, 21 );
			this.label10.Margin = new System.Windows.Forms.Padding( 2, 0, 2, 0 );
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size( 48, 13 );
			this.label10.TabIndex = 13;
			this.label10.Text = "Center Y";
			// 
			// boxView
			// 
			this.boxView.Controls.Add( this.maxY );
			this.boxView.Controls.Add( this.maxX );
			this.boxView.Controls.Add( this.minY );
			this.boxView.Controls.Add( this.minX );
			this.boxView.Controls.Add( this.label5 );
			this.boxView.Controls.Add( this.label6 );
			this.boxView.Controls.Add( this.label1 );
			this.boxView.Controls.Add( this.label3 );
			this.boxView.Location = new System.Drawing.Point( 409, 78 );
			this.boxView.Margin = new System.Windows.Forms.Padding( 2 );
			this.boxView.Name = "boxView";
			this.boxView.Padding = new System.Windows.Forms.Padding( 2 );
			this.boxView.Size = new System.Drawing.Size( 250, 72 );
			this.boxView.TabIndex = 15;
			this.boxView.TabStop = false;
			this.boxView.Text = "Box Attributes";
			// 
			// maxY
			// 
			this.maxY.Location = new System.Drawing.Point( 172, 43 );
			this.maxY.Margin = new System.Windows.Forms.Padding( 2 );
			this.maxY.Maximum = new decimal( new int[] {
            1080,
            0,
            0,
            0} );
			this.maxY.Name = "maxY";
			this.maxY.Size = new System.Drawing.Size( 72, 20 );
			this.maxY.TabIndex = 16;
			// 
			// maxX
			// 
			this.maxX.Location = new System.Drawing.Point( 42, 46 );
			this.maxX.Margin = new System.Windows.Forms.Padding( 2 );
			this.maxX.Maximum = new decimal( new int[] {
            1920,
            0,
            0,
            0} );
			this.maxX.Name = "maxX";
			this.maxX.Size = new System.Drawing.Size( 72, 20 );
			this.maxX.TabIndex = 14;
			// 
			// minY
			// 
			this.minY.Location = new System.Drawing.Point( 172, 18 );
			this.minY.Margin = new System.Windows.Forms.Padding( 2 );
			this.minY.Maximum = new decimal( new int[] {
            1080,
            0,
            0,
            0} );
			this.minY.Name = "minY";
			this.minY.Size = new System.Drawing.Size( 72, 20 );
			this.minY.TabIndex = 13;
			// 
			// minX
			// 
			this.minX.Location = new System.Drawing.Point( 42, 18 );
			this.minX.Margin = new System.Windows.Forms.Padding( 2 );
			this.minX.Maximum = new decimal( new int[] {
            1920,
            0,
            0,
            0} );
			this.minX.Name = "minX";
			this.minX.Size = new System.Drawing.Size( 72, 20 );
			this.minX.TabIndex = 12;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point( 5, 47 );
			this.label5.Margin = new System.Windows.Forms.Padding( 2, 0, 2, 0 );
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size( 37, 13 );
			this.label5.TabIndex = 15;
			this.label5.Text = "Max X";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point( 135, 47 );
			this.label6.Margin = new System.Windows.Forms.Padding( 2, 0, 2, 0 );
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size( 37, 13 );
			this.label6.TabIndex = 17;
			this.label6.Text = "Max Y";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point( 5, 20 );
			this.label1.Margin = new System.Windows.Forms.Padding( 2, 0, 2, 0 );
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size( 34, 13 );
			this.label1.TabIndex = 10;
			this.label1.Text = "Min X";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point( 135, 20 );
			this.label3.Margin = new System.Windows.Forms.Padding( 2, 0, 2, 0 );
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size( 34, 13 );
			this.label3.TabIndex = 11;
			this.label3.Text = "Min Y";
			// 
			// useTcp
			// 
			this.useTcp.AutoSize = true;
			this.useTcp.Location = new System.Drawing.Point( 243, 27 );
			this.useTcp.Margin = new System.Windows.Forms.Padding( 2 );
			this.useTcp.Name = "useTcp";
			this.useTcp.Size = new System.Drawing.Size( 69, 17 );
			this.useTcp.TabIndex = 16;
			this.useTcp.Text = "Use TCP";
			this.useTcp.UseVisualStyleBackColor = true;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size( 670, 413 );
			this.Controls.Add( this.useTcp );
			this.Controls.Add( this.boxView );
			this.Controls.Add( this.circleView );
			this.Controls.Add( this.ShapeRectangle );
			this.Controls.Add( this.ShapeCircle );
			this.Controls.Add( this.label4 );
			this.Controls.Add( this.objectName );
			this.Controls.Add( this.shapeView );
			this.Controls.Add( this.menuStrip1 );
			this.MainMenuStrip = this.menuStrip1;
			this.Margin = new System.Windows.Forms.Padding( 2 );
			this.Name = "Form1";
			this.Text = "Tool-native-Runtime-Communication";
			this.Load += new System.EventHandler( this.Form1_Load );
			this.menuStrip1.ResumeLayout( false );
			this.menuStrip1.PerformLayout();
			this.circleView.ResumeLayout( false );
			this.circleView.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.radius)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.centerY)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.centerX)).EndInit();
			this.boxView.ResumeLayout( false );
			this.boxView.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.maxY)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.maxX)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.minY)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.minX)).EndInit();
			this.ResumeLayout( false );
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListBox shapeView;
		private System.Windows.Forms.TextBox objectName;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem saveAsXMLToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
		private System.Windows.Forms.Button ShapeCircle;
		private System.Windows.Forms.Button ShapeRectangle;
		private System.Windows.Forms.SaveFileDialog saveXmlDialog;
		private System.Windows.Forms.GroupBox circleView;
		private System.Windows.Forms.NumericUpDown radius;
		private System.Windows.Forms.NumericUpDown centerY;
		private System.Windows.Forms.NumericUpDown centerX;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.GroupBox boxView;
		private System.Windows.Forms.NumericUpDown maxY;
		private System.Windows.Forms.NumericUpDown maxX;
		private System.Windows.Forms.NumericUpDown minY;
		private System.Windows.Forms.NumericUpDown minX;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.CheckBox useTcp;
	}
}

