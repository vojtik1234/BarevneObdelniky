using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Threading; //prace s vlakny
using System.Diagnostics; //prace s caosvaci a stopkami

namespace Rectangles_vlakna
{

	public partial class MainForm : Form
	{	
		
		Random rnd = new Random();
		
		public MainForm()
		{

			InitializeComponent();
			//Thread.Sleep(500);
			
			
			
		}
		void RedButtonClick(object sender, EventArgs e)
		{
			Thread tA = new Thread(DrawRed); //predani odkazu na vlaknem vykonavanou metodu - nejsou zavorky
			tA.Start(); // start vlakna
		}
		
		void DrawRed(){
			Stopwatch stopky = new Stopwatch(); //pouziti stopek
			stopky.Start();
					for (int i = 0; i < 10; i++) {
				this.CreateGraphics().DrawRectangle(new Pen(Color.Red, 2),
				                                    rnd.Next(0,this.Width),
				                                    rnd.Next(0, this.Height),
				                                    20, 10);
				Thread.Sleep(200);
			}
			stopky.Stop();
			MessageBox.Show(String.Format("Completed red! Duration: {0}", stopky.Elapsed.ToString())); //vyppis casu
		}
		
		
		
		void BlueButtonClick(object sender, EventArgs e)
		{
			Thread tB = new Thread(DrawBlue);
			tB.Start();
		}
		
		
		void DrawBlue(){
					for (int i = 0; i < 20; i++) {
				this.CreateGraphics().FillRectangle(new SolidBrush(Color.Blue),
				                                    rnd.Next(0,this.Width),
				                                    rnd.Next(0, this.Height),
				                                    20, 10);
				Thread.Sleep(200);
			}
			MessageBox.Show("Completed blue");
		}
	}
}
