namespace ToolNativeRuntimeCommunication.ShapeControl
{
	partial class ShapeCircleControl
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
			this.circleView = new System.Windows.Forms.GroupBox();
			this.radius = new System.Windows.Forms.NumericUpDown();
			this.centerY = new System.Windows.Forms.NumericUpDown();
			this.centerX = new System.Windows.Forms.NumericUpDown();
			this.label7 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.circleView.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.radius)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.centerY)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.centerX)).BeginInit();
			this.SuspendLayout();
			// 
			// circleView
			// 
			this.circleView.Controls.Add( this.radius );
			this.circleView.Controls.Add( this.centerY );
			this.circleView.Controls.Add( this.centerX );
			this.circleView.Controls.Add( this.label7 );
			this.circleView.Controls.Add( this.label9 );
			this.circleView.Controls.Add( this.label10 );
			this.circleView.Location = new System.Drawing.Point( 2, 2 );
			this.circleView.Margin = new System.Windows.Forms.Padding( 2 );
			this.circleView.Name = "circleView";
			this.circleView.Padding = new System.Windows.Forms.Padding( 2 );
			this.circleView.Size = new System.Drawing.Size( 250, 70 );
			this.circleView.TabIndex = 15;
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
			// ShapeCircleControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add( this.circleView );
			this.Name = "ShapeCircleControl";
			this.Size = new System.Drawing.Size( 256, 77 );
			this.circleView.ResumeLayout( false );
			this.circleView.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.radius)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.centerY)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.centerX)).EndInit();
			this.ResumeLayout( false );

		}

		#endregion

		private System.Windows.Forms.GroupBox circleView;
		private System.Windows.Forms.NumericUpDown radius;
		private System.Windows.Forms.NumericUpDown centerY;
		private System.Windows.Forms.NumericUpDown centerX;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
	}
}
