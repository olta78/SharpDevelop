/*
 * Created by SharpDevelop.
 * User: oleg-
 * Date: 06.05.2021
 * Time: 1:56
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace Example
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		[DllImport("user32.dll")]
 		public static extern IntPtr GetForegroundWindow();
 		[DllImport("user32.dll")]
 		public static extern UInt32 GetWindowThreadProcessId(IntPtr hwnd, ref Int32 pid);
 		[DllImport("user32.dll")]
		public static extern IntPtr GetActiveWindow();
		
		public MainForm()
		{
			
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}		
		
		void Button1Click(object sender, EventArgs e)
		{
			Thread.Sleep(2000);
			//IntPtr h = GetForegroundWindow();
			IntPtr h = GetActiveWindow();
			int pid = 0;
			GetWindowThreadProcessId(h, ref pid);
			Process p = Process.GetProcessById(pid);
			MessageBox.Show(h.ToString(), pid.ToString());
			//this.Close();
		}
	}
}
