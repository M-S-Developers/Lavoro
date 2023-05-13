/*
 * Created by SharpDevelop.
 * User: mspma
 * Date: 5/13/2023
 * Time: 8:20 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Security.Permissions;
using System.IO;
using System.Text;

namespace LavoroNET
{
	/// <summary>
	/// The web OS main window.
	/// </summary>
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public partial class MainForm : Form
	{
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
		
		public string FilesPath = @"files.js";
		
		public string BrowserPath = @"browser.html";
		
		public void UpdateFiles(String s) {
			File.WriteAllText(FilesPath, "var files = [" + s + "];", Encoding.UTF8);
			
			this.webBrowserFile.Navigate(new Uri(BrowserPath));	
		}
		
		public void PreviewFile(String url, String cookie) {
			this.webBrowserPreview.Url = new Uri(url);
			
			this.webBrowserPreview.Document.Cookie = cookie;
			
			this.webBrowserPreview.Navigate(new Uri(url));

			this.tabControlMain.SelectedTab = this.tabPagePreview;
		}
		
		public void AddFile(String url, String cookie) {
			this.webBrowserFile.Document.InvokeScript("addFileNET", new string[] { url, cookie });
			
			this.webBrowserFile.Document.InvokeScript("updateFilesNET");
			
			this.webBrowserFile.Navigate(new Uri(BrowserPath));
		}
		
		public void AddFileFromInput() {
			this.webBrowserFile.Document.InvokeScript("updateFilesNET");

			this.webBrowserFile.Navigate(new Uri(BrowserPath));			
		}
		
		void MainFormLoad(object sender, EventArgs e)
		{
			this.FilesPath = System.Environment.CurrentDirectory + @"\" + this.FilesPath;
			
			this.BrowserPath = System.Environment.CurrentDirectory + @"\" + this.BrowserPath;
			
			this.webBrowserFile.ScriptErrorsSuppressed = true;
			
			this.webBrowserPreview.ScriptErrorsSuppressed = true;
			
			this.webBrowserFile.ObjectForScripting = this.webBrowserPreview.ObjectForScripting = this;
			
			this.webBrowserFile.Url = new Uri(BrowserPath);
			
			this.MainFormResize(this, null);
		}
		
		void ButtonNavigateClick(object sender, EventArgs e)
		{
			this.webBrowserPreview.Url = new Uri(this.textBoxNavigate.Text);
		}
		
		void WebBrowserPreviewDocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
		{
			this.textBoxPreviewTitle.Text = this.webBrowserPreview.DocumentTitle;
		}
		
		void ButtonAddFileClick(object sender, EventArgs e)
		{
			this.webBrowserFile.Document.InvokeScript("addFileNET", new string[] { this.webBrowserPreview.Url.AbsoluteUri.ToString(), this.webBrowserPreview.Document.Cookie != null ? this.webBrowserPreview.Document.Cookie.ToString() : "" });
			
			this.webBrowserFile.Document.InvokeScript("updateFilesNET");
			
			this.webBrowserFile.Navigate(new Uri(BrowserPath));
		}
		
		void WebBrowserPreviewNavigated(object sender, WebBrowserNavigatedEventArgs e)
		{
			this.textBoxNavigate.Text = this.webBrowserPreview.Url.AbsoluteUri;
			
			this.textBoxPreviewTitle.Text = this.webBrowserPreview.DocumentTitle;
		}
		
		void MainFormResize(object sender, EventArgs e)
		{
			this.tabControlMain.Width = this.Width;
			
			this.tabControlMain.Height = this.Height;
			
			this.tabPageFileBrowser.Width = this.tabControlMain.Width;

			this.tabPageFileBrowser.Height = this.tabControlMain.Height;
			
			this.webBrowserFile.Width = this.tabPageFileBrowser.Width;
			
			this.webBrowserFile.Height = this.tabPageFileBrowser.Height;
			
			this.tabPagePreview.Width = this.tabControlMain.Width;
			
			this.tabPagePreview.Height = this.tabControlMain.Height;
			
			this.webBrowserPreview.Width = this.tabPagePreview.Width;
			
			this.webBrowserPreview.Height = this.tabPagePreview.Height - 108;
		}
	}
}
