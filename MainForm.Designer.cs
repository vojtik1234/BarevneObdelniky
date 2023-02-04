/*
 * Created by SharpDevelop.
 * User: student
 * Date: 08.10.2022
 * Time: 18:13
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Rectangles_vlakna
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button redButton;
		private System.Windows.Forms.Button blueButton;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.redButton = new System.Windows.Forms.Button();
			this.blueButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// redButton
			// 
			this.redButton.Location = new System.Drawing.Point(12, 12);
			this.redButton.Name = "redButton";
			this.redButton.Size = new System.Drawing.Size(110, 44);
			this.redButton.TabIndex = 0;
			this.redButton.Text = "cervene";
			this.redButton.UseVisualStyleBackColor = true;
			this.redButton.Click += new System.EventHandler(this.RedButtonClick);
			// 
			// blueButton
			// 
			this.blueButton.Location = new System.Drawing.Point(128, 12);
			this.blueButton.Name = "blueButton";
			this.blueButton.Size = new System.Drawing.Size(110, 44);
			this.blueButton.TabIndex = 1;
			this.blueButton.Text = "modre";
			this.blueButton.UseVisualStyleBackColor = true;
			this.blueButton.Click += new System.EventHandler(this.BlueButtonClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(682, 339);
			this.Controls.Add(this.blueButton);
			this.Controls.Add(this.redButton);
			this.Name = "MainForm";
			this.Text = "Rectangles_vlakna";
			this.ResumeLayout(false);

		}
	}
}
