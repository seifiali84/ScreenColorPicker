
namespace ScreenColorPicker
{
	partial class MainForm
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
			this.components = new System.ComponentModel.Container();
			System.Windows.Forms.Label labelRgbR;
			System.Windows.Forms.Panel PanelRGB;
			System.Windows.Forms.Label labelRGB;
			System.Windows.Forms.Label labelRgbB;
			System.Windows.Forms.Label labelRgbG;
			System.Windows.Forms.Panel panelHSB;
			System.Windows.Forms.Label labelHSL;
			System.Windows.Forms.Label labelHslL;
			System.Windows.Forms.Label labelHslS;
			System.Windows.Forms.Label labelHslH;
			System.Windows.Forms.Panel panelHEX;
			System.Windows.Forms.Label labelHEX;
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.textBoxRgbB = new System.Windows.Forms.TextBox();
			this.textBoxRgbG = new System.Windows.Forms.TextBox();
			this.textBoxRgbR = new System.Windows.Forms.TextBox();
			this.textBoxHslL = new System.Windows.Forms.TextBox();
			this.textBoxHslS = new System.Windows.Forms.TextBox();
			this.textBoxHslH = new System.Windows.Forms.TextBox();
			this.textBoxHEX = new System.Windows.Forms.TextBox();
			this.sampleColorPictureBox = new System.Windows.Forms.PictureBox();
			this.mousePositionTimer = new System.Windows.Forms.Timer(this.components);
			this.keysTimer = new System.Windows.Forms.Timer(this.components);
			this.label1 = new System.Windows.Forms.Label();
			this.toolTip = new System.Windows.Forms.ToolTip(this.components);
			this.label2 = new System.Windows.Forms.Label();
			labelRgbR = new System.Windows.Forms.Label();
			PanelRGB = new System.Windows.Forms.Panel();
			labelRGB = new System.Windows.Forms.Label();
			labelRgbB = new System.Windows.Forms.Label();
			labelRgbG = new System.Windows.Forms.Label();
			panelHSB = new System.Windows.Forms.Panel();
			labelHSL = new System.Windows.Forms.Label();
			labelHslL = new System.Windows.Forms.Label();
			labelHslS = new System.Windows.Forms.Label();
			labelHslH = new System.Windows.Forms.Label();
			panelHEX = new System.Windows.Forms.Panel();
			labelHEX = new System.Windows.Forms.Label();
			PanelRGB.SuspendLayout();
			panelHSB.SuspendLayout();
			panelHEX.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.sampleColorPictureBox)).BeginInit();
			this.SuspendLayout();
			// 
			// labelRgbR
			// 
			labelRgbR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			labelRgbR.Location = new System.Drawing.Point(3, 33);
			labelRgbR.Name = "labelRgbR";
			labelRgbR.Size = new System.Drawing.Size(30, 23);
			labelRgbR.TabIndex = 2;
			labelRgbR.Text = "R: ";
			// 
			// PanelRGB
			// 
			PanelRGB.Controls.Add(labelRGB);
			PanelRGB.Controls.Add(labelRgbB);
			PanelRGB.Controls.Add(this.textBoxRgbB);
			PanelRGB.Controls.Add(labelRgbG);
			PanelRGB.Controls.Add(this.textBoxRgbG);
			PanelRGB.Controls.Add(labelRgbR);
			PanelRGB.Controls.Add(this.textBoxRgbR);
			PanelRGB.Location = new System.Drawing.Point(11, 53);
			PanelRGB.Name = "PanelRGB";
			PanelRGB.Size = new System.Drawing.Size(78, 112);
			PanelRGB.TabIndex = 3;
			// 
			// labelRGB
			// 
			labelRGB.AutoSize = true;
			labelRGB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			labelRGB.Location = new System.Drawing.Point(3, 4);
			labelRGB.Name = "labelRGB";
			labelRGB.Size = new System.Drawing.Size(52, 24);
			labelRGB.TabIndex = 9;
			labelRGB.Text = "RGB";
			// 
			// labelRgbB
			// 
			labelRgbB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			labelRgbB.Location = new System.Drawing.Point(3, 83);
			labelRgbB.Name = "labelRgbB";
			labelRgbB.Size = new System.Drawing.Size(30, 23);
			labelRgbB.TabIndex = 7;
			labelRgbB.Text = "B: ";
			// 
			// textBoxRgbB
			// 
			this.textBoxRgbB.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBoxRgbB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxRgbB.Location = new System.Drawing.Point(30, 83);
			this.textBoxRgbB.MaxLength = 3;
			this.textBoxRgbB.Name = "textBoxRgbB";
			this.textBoxRgbB.ReadOnly = true;
			this.textBoxRgbB.Size = new System.Drawing.Size(31, 19);
			this.textBoxRgbB.TabIndex = 8;
			this.textBoxRgbB.TabStop = false;
			this.textBoxRgbB.Text = "255";
			this.textBoxRgbB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// labelRgbG
			// 
			labelRgbG.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			labelRgbG.Location = new System.Drawing.Point(3, 58);
			labelRgbG.Name = "labelRgbG";
			labelRgbG.Size = new System.Drawing.Size(30, 23);
			labelRgbG.TabIndex = 5;
			labelRgbG.Text = "G: ";
			// 
			// textBoxRgbG
			// 
			this.textBoxRgbG.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBoxRgbG.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxRgbG.Location = new System.Drawing.Point(30, 58);
			this.textBoxRgbG.MaxLength = 3;
			this.textBoxRgbG.Name = "textBoxRgbG";
			this.textBoxRgbG.ReadOnly = true;
			this.textBoxRgbG.Size = new System.Drawing.Size(31, 19);
			this.textBoxRgbG.TabIndex = 6;
			this.textBoxRgbG.TabStop = false;
			this.textBoxRgbG.Text = "255";
			this.textBoxRgbG.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// textBoxRgbR
			// 
			this.textBoxRgbR.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBoxRgbR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxRgbR.Location = new System.Drawing.Point(30, 33);
			this.textBoxRgbR.MaxLength = 3;
			this.textBoxRgbR.Name = "textBoxRgbR";
			this.textBoxRgbR.ReadOnly = true;
			this.textBoxRgbR.Size = new System.Drawing.Size(31, 19);
			this.textBoxRgbR.TabIndex = 4;
			this.textBoxRgbR.TabStop = false;
			this.textBoxRgbR.Text = "255";
			this.textBoxRgbR.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// panelHSB
			// 
			panelHSB.Controls.Add(labelHSL);
			panelHSB.Controls.Add(labelHslL);
			panelHSB.Controls.Add(this.textBoxHslL);
			panelHSB.Controls.Add(labelHslS);
			panelHSB.Controls.Add(this.textBoxHslS);
			panelHSB.Controls.Add(labelHslH);
			panelHSB.Controls.Add(this.textBoxHslH);
			panelHSB.Location = new System.Drawing.Point(95, 53);
			panelHSB.Name = "panelHSB";
			panelHSB.Size = new System.Drawing.Size(78, 112);
			panelHSB.TabIndex = 10;
			// 
			// labelHSL
			// 
			labelHSL.AutoSize = true;
			labelHSL.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			labelHSL.Location = new System.Drawing.Point(3, 4);
			labelHSL.Name = "labelHSL";
			labelHSL.Size = new System.Drawing.Size(49, 24);
			labelHSL.TabIndex = 9;
			labelHSL.Text = "HSL";
			// 
			// labelHslL
			// 
			labelHslL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			labelHslL.Location = new System.Drawing.Point(3, 83);
			labelHslL.Name = "labelHslL";
			labelHslL.Size = new System.Drawing.Size(30, 23);
			labelHslL.TabIndex = 7;
			labelHslL.Text = "B: ";
			// 
			// textBoxHslL
			// 
			this.textBoxHslL.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBoxHslL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxHslL.Location = new System.Drawing.Point(30, 83);
			this.textBoxHslL.MaxLength = 3;
			this.textBoxHslL.Name = "textBoxHslL";
			this.textBoxHslL.ReadOnly = true;
			this.textBoxHslL.Size = new System.Drawing.Size(31, 19);
			this.textBoxHslL.TabIndex = 8;
			this.textBoxHslL.TabStop = false;
			this.textBoxHslL.Text = "100";
			this.textBoxHslL.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// labelHslS
			// 
			labelHslS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			labelHslS.Location = new System.Drawing.Point(3, 58);
			labelHslS.Name = "labelHslS";
			labelHslS.Size = new System.Drawing.Size(30, 23);
			labelHslS.TabIndex = 5;
			labelHslS.Text = "S: ";
			// 
			// textBoxHslS
			// 
			this.textBoxHslS.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBoxHslS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxHslS.Location = new System.Drawing.Point(30, 58);
			this.textBoxHslS.MaxLength = 3;
			this.textBoxHslS.Name = "textBoxHslS";
			this.textBoxHslS.ReadOnly = true;
			this.textBoxHslS.Size = new System.Drawing.Size(31, 19);
			this.textBoxHslS.TabIndex = 6;
			this.textBoxHslS.TabStop = false;
			this.textBoxHslS.Text = "100";
			this.textBoxHslS.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// labelHslH
			// 
			labelHslH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			labelHslH.Location = new System.Drawing.Point(3, 33);
			labelHslH.Name = "labelHslH";
			labelHslH.Size = new System.Drawing.Size(30, 23);
			labelHslH.TabIndex = 2;
			labelHslH.Text = "H: ";
			// 
			// textBoxHslH
			// 
			this.textBoxHslH.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBoxHslH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxHslH.Location = new System.Drawing.Point(30, 33);
			this.textBoxHslH.MaxLength = 3;
			this.textBoxHslH.Name = "textBoxHslH";
			this.textBoxHslH.ReadOnly = true;
			this.textBoxHslH.Size = new System.Drawing.Size(31, 19);
			this.textBoxHslH.TabIndex = 4;
			this.textBoxHslH.TabStop = false;
			this.textBoxHslH.Text = "360";
			this.textBoxHslH.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// panelHEX
			// 
			panelHEX.Controls.Add(this.textBoxHEX);
			panelHEX.Controls.Add(labelHEX);
			panelHEX.Location = new System.Drawing.Point(20, 157);
			panelHEX.Name = "panelHEX";
			panelHEX.Size = new System.Drawing.Size(138, 34);
			panelHEX.TabIndex = 11;
			// 
			// textBoxHEX
			// 
			this.textBoxHEX.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBoxHEX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxHEX.Location = new System.Drawing.Point(55, 7);
			this.textBoxHEX.MaxLength = 3;
			this.textBoxHEX.Name = "textBoxHEX";
			this.textBoxHEX.ReadOnly = true;
			this.textBoxHEX.Size = new System.Drawing.Size(92, 19);
			this.textBoxHEX.TabIndex = 10;
			this.textBoxHEX.TabStop = false;
			this.textBoxHEX.Text = "#AAFFAA";
			// 
			// labelHEX
			// 
			labelHEX.AutoSize = true;
			labelHEX.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			labelHEX.Location = new System.Drawing.Point(3, 3);
			labelHEX.Name = "labelHEX";
			labelHEX.Size = new System.Drawing.Size(54, 24);
			labelHEX.TabIndex = 10;
			labelHEX.Text = "Hex:";
			// 
			// sampleColorPictureBox
			// 
			this.sampleColorPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.sampleColorPictureBox.Location = new System.Drawing.Point(17, 25);
			this.sampleColorPictureBox.Name = "sampleColorPictureBox";
			this.sampleColorPictureBox.Size = new System.Drawing.Size(148, 29);
			this.sampleColorPictureBox.TabIndex = 0;
			this.sampleColorPictureBox.TabStop = false;
			// 
			// mousePositionTimer
			// 
			this.mousePositionTimer.Enabled = true;
			this.mousePositionTimer.Tick += new System.EventHandler(this.MousePositionTimer_Tick);
			// 
			// keysTimer
			// 
			this.keysTimer.Enabled = true;
			this.keysTimer.Interval = 1;
			this.keysTimer.Tick += new System.EventHandler(this.KeysTimer_Tick);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(14, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(45, 13);
			this.label1.TabIndex = 12;
			this.label1.Text = "Sample:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.DimGray;
			this.label2.Location = new System.Drawing.Point(14, 193);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(154, 13);
			this.label2.TabIndex = 13;
			this.label2.Text = "F10: to lock && unlock the color.";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.toolTip.SetToolTip(this.label2, "Press F10 to lock the color under the mouse pointer.\r\nPress F10 again to unlock t" +
        "he color.");
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(184, 216);
			this.Controls.Add(this.sampleColorPictureBox);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(panelHEX);
			this.Controls.Add(panelHSB);
			this.Controls.Add(PanelRGB);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "MainForm";
			this.Text = "Screen Color Picker";
			this.TopMost = true;
			PanelRGB.ResumeLayout(false);
			PanelRGB.PerformLayout();
			panelHSB.ResumeLayout(false);
			panelHSB.PerformLayout();
			panelHEX.ResumeLayout(false);
			panelHEX.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.sampleColorPictureBox)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox sampleColorPictureBox;
		private System.Windows.Forms.Timer mousePositionTimer;
		private System.Windows.Forms.Timer keysTimer;
		private System.Windows.Forms.TextBox textBoxRgbR;
		private System.Windows.Forms.TextBox textBoxRgbB;
		private System.Windows.Forms.TextBox textBoxRgbG;
		private System.Windows.Forms.TextBox textBoxHslL;
		private System.Windows.Forms.TextBox textBoxHslS;
		private System.Windows.Forms.TextBox textBoxHslH;
		private System.Windows.Forms.TextBox textBoxHEX;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ToolTip toolTip;
		private System.Windows.Forms.Label label2;
	}
}

