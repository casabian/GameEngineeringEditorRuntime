namespace ToolNativeRuntimeCommunication.ShapeControl
{
	partial class ShapeRectangleControl
	{
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose( bool disposing )
		{
			if ( disposing && (components != null) )
			{
				components.Dispose();
			}
			base.Dispose( disposing );
		}

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.boxView = new System.Windows.Forms.GroupBox();
			this.maxY = new System.Windows.Forms.NumericUpDown();
			this.maxX = new System.Windows.Forms.NumericUpDown();
			this.minY = new System.Windows.Forms.NumericUpDown();
			this.minX = new System.Windows.Forms.NumericUpDown();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.boxView.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.maxY)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.maxX)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.minY)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.minX)).BeginInit();
			this.SuspendLayout();
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
			this.boxView.Location = new System.Drawing.Point( 2, 2 );
			this.boxView.Margin = new System.Windows.Forms.Padding( 2 );
			this.boxView.Name = "boxView";
			this.boxView.Padding = new System.Windows.Forms.Padding( 2 );
			this.boxView.Size = new System.Drawing.Size( 250, 72 );
			this.boxView.TabIndex = 16;
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
			// ShapeRectangleControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add( this.boxView );
			this.Name = "ShapeRectangleControl";
			this.Size = new System.Drawing.Size( 258, 81 );
			this.boxView.ResumeLayout( false );
			this.boxView.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.maxY)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.maxX)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.minY)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.minX)).EndInit();
			this.ResumeLayout( false );

		}

		#endregion

		private System.Windows.Forms.GroupBox boxView;
		private System.Windows.Forms.NumericUpDown maxY;
		private System.Windows.Forms.NumericUpDown maxX;
		private System.Windows.Forms.NumericUpDown minY;
		private System.Windows.Forms.NumericUpDown minX;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label3;

	}
}
