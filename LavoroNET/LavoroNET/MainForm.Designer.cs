/*
 * Created by SharpDevelop.
 * User: mspma
 * Date: 5/13/2023
 * Time: 8:20 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace LavoroNET
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.TabControl tabControlMain;
		private System.Windows.Forms.TabPage tabPageFileBrowser;
		private System.Windows.Forms.WebBrowser webBrowserFile;
		private System.Windows.Forms.TabPage tabPagePreview;
		private System.Windows.Forms.WebBrowser webBrowserPreview;
		private System.Windows.Forms.Label labelPreviewTitle;
		private System.Windows.Forms.TextBox textBoxPreviewTitle;
		private System.Windows.Forms.Label labelNavigate;
		private System.Windows.Forms.TextBox textBoxNavigate;
		private System.Windows.Forms.Button buttonNavigate;
		private System.Windows.Forms.Button buttonAddFile;
		
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
			this.tabControlMain = new System.Windows.Forms.TabControl();
			this.tabPageFileBrowser = new System.Windows.Forms.TabPage();
			this.webBrowserFile = new System.Windows.Forms.WebBrowser();
			this.tabPagePreview = new System.Windows.Forms.TabPage();
			this.buttonAddFile = new System.Windows.Forms.Button();
			this.buttonNavigate = new System.Windows.Forms.Button();
			this.textBoxNavigate = new System.Windows.Forms.TextBox();
			this.labelNavigate = new System.Windows.Forms.Label();
			this.textBoxPreviewTitle = new System.Windows.Forms.TextBox();
			this.webBrowserPreview = new System.Windows.Forms.WebBrowser();
			this.labelPreviewTitle = new System.Windows.Forms.Label();
			this.tabControlMain.SuspendLayout();
			this.tabPageFileBrowser.SuspendLayout();
			this.tabPagePreview.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabControlMain
			// 
			this.tabControlMain.Controls.Add(this.tabPageFileBrowser);
			this.tabControlMain.Controls.Add(this.tabPagePreview);
			this.tabControlMain.Location = new System.Drawing.Point(0, 0);
			this.tabControlMain.Name = "tabControlMain";
			this.tabControlMain.SelectedIndex = 0;
			this.tabControlMain.Size = new System.Drawing.Size(758, 430);
			this.tabControlMain.TabIndex = 0;
			// 
			// tabPageFileBrowser
			// 
			this.tabPageFileBrowser.Controls.Add(this.webBrowserFile);
			this.tabPageFileBrowser.Location = new System.Drawing.Point(4, 25);
			this.tabPageFileBrowser.Name = "tabPageFileBrowser";
			this.tabPageFileBrowser.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageFileBrowser.Size = new System.Drawing.Size(750, 401);
			this.tabPageFileBrowser.TabIndex = 1;
			this.tabPageFileBrowser.Text = "File Browser";
			this.tabPageFileBrowser.UseVisualStyleBackColor = true;
			// 
			// webBrowserFile
			// 
			this.webBrowserFile.Dock = System.Windows.Forms.DockStyle.Fill;
			this.webBrowserFile.Location = new System.Drawing.Point(3, 3);
			this.webBrowserFile.MinimumSize = new System.Drawing.Size(20, 20);
			this.webBrowserFile.Name = "webBrowserFile";
			this.webBrowserFile.Size = new System.Drawing.Size(744, 395);
			this.webBrowserFile.TabIndex = 0;
			// 
			// tabPagePreview
			// 
			this.tabPagePreview.Controls.Add(this.buttonAddFile);
			this.tabPagePreview.Controls.Add(this.buttonNavigate);
			this.tabPagePreview.Controls.Add(this.textBoxNavigate);
			this.tabPagePreview.Controls.Add(this.labelNavigate);
			this.tabPagePreview.Controls.Add(this.textBoxPreviewTitle);
			this.tabPagePreview.Controls.Add(this.webBrowserPreview);
			this.tabPagePreview.Controls.Add(this.labelPreviewTitle);
			this.tabPagePreview.Location = new System.Drawing.Point(4, 25);
			this.tabPagePreview.Name = "tabPagePreview";
			this.tabPagePreview.Padding = new System.Windows.Forms.Padding(3);
			this.tabPagePreview.Size = new System.Drawing.Size(750, 401);
			this.tabPagePreview.TabIndex = 2;
			this.tabPagePreview.Text = "Preview";
			// 
			// buttonAddFile
			// 
			this.buttonAddFile.Location = new System.Drawing.Point(628, 57);
			this.buttonAddFile.Name = "buttonAddFile";
			this.buttonAddFile.Size = new System.Drawing.Size(79, 23);
			this.buttonAddFile.TabIndex = 6;
			this.buttonAddFile.Text = "Add file";
			this.buttonAddFile.UseVisualStyleBackColor = true;
			this.buttonAddFile.Click += new System.EventHandler(this.ButtonAddFileClick);
			// 
			// buttonNavigate
			// 
			this.buttonNavigate.Location = new System.Drawing.Point(628, 20);
			this.buttonNavigate.Name = "buttonNavigate";
			this.buttonNavigate.Size = new System.Drawing.Size(79, 23);
			this.buttonNavigate.TabIndex = 5;
			this.buttonNavigate.Text = "Navigate";
			this.buttonNavigate.UseVisualStyleBackColor = true;
			this.buttonNavigate.Click += new System.EventHandler(this.ButtonNavigateClick);
			// 
			// textBoxNavigate
			// 
			this.textBoxNavigate.Location = new System.Drawing.Point(97, 20);
			this.textBoxNavigate.Name = "textBoxNavigate";
			this.textBoxNavigate.Size = new System.Drawing.Size(516, 22);
			this.textBoxNavigate.TabIndex = 4;
			// 
			// labelNavigate
			// 
			this.labelNavigate.Location = new System.Drawing.Point(16, 20);
			this.labelNavigate.Name = "labelNavigate";
			this.labelNavigate.Size = new System.Drawing.Size(70, 23);
			this.labelNavigate.TabIndex = 3;
			this.labelNavigate.Text = "Navigate:";
			// 
			// textBoxPreviewTitle
			// 
			this.textBoxPreviewTitle.Location = new System.Drawing.Point(95, 57);
			this.textBoxPreviewTitle.Name = "textBoxPreviewTitle";
			this.textBoxPreviewTitle.ReadOnly = true;
			this.textBoxPreviewTitle.Size = new System.Drawing.Size(518, 22);
			this.textBoxPreviewTitle.TabIndex = 2;
			// 
			// webBrowserPreview
			// 
			this.webBrowserPreview.Location = new System.Drawing.Point(0, 108);
			this.webBrowserPreview.MinimumSize = new System.Drawing.Size(20, 20);
			this.webBrowserPreview.Name = "webBrowserPreview";
			this.webBrowserPreview.Size = new System.Drawing.Size(747, 293);
			this.webBrowserPreview.TabIndex = 1;
			this.webBrowserPreview.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.WebBrowserPreviewDocumentCompleted);
			this.webBrowserPreview.Navigated += new System.Windows.Forms.WebBrowserNavigatedEventHandler(this.WebBrowserPreviewNavigated);
			// 
			// labelPreviewTitle
			// 
			this.labelPreviewTitle.Location = new System.Drawing.Point(16, 57);
			this.labelPreviewTitle.Name = "labelPreviewTitle";
			this.labelPreviewTitle.Size = new System.Drawing.Size(49, 23);
			this.labelPreviewTitle.TabIndex = 0;
			this.labelPreviewTitle.Text = "Title:";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(762, 426);
			this.Controls.Add(this.tabControlMain);
			this.Name = "MainForm";
			this.Text = "LavoroNET";
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.Resize += new System.EventHandler(this.MainFormResize);
			this.tabControlMain.ResumeLayout(false);
			this.tabPageFileBrowser.ResumeLayout(false);
			this.tabPagePreview.ResumeLayout(false);
			this.tabPagePreview.PerformLayout();
			this.ResumeLayout(false);

		}
	}
}
