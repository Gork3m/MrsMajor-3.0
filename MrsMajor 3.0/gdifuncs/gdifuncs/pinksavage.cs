using System;
using System.Drawing;
using System.Windows.Forms;

namespace gdifuncs
{
	
	public partial class pinksavage : Form
	{
		public pinksavage()
		{
			InitializeComponent();
			
		
		}
		double cur = .05;
		int akis = 0;
		void Timer1Tick(object sender, EventArgs e)
		{
			
			this.TopMost = false;
			this.TopMost = true;
			
			if (cur > 0.60) {
				akis = 1;
				cur = 0.59;
			}
			if (cur < 0.05) {
				akis = 0;
				
			}
			
			if (akis == 1) {
				cur = cur - 0.01;
			} else {
				cur = cur + 0.01;
			}
			this.Opacity = cur;
		}
			protected override CreateParams CreateParams { get { CreateParams wew = base.CreateParams; wew.ExStyle = base.CreateParams.ExStyle | 0x20; return wew; } }
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
		void PinksavageLoad(object sender, EventArgs e)
		{
			timer1.Start();
		}
	}
}
