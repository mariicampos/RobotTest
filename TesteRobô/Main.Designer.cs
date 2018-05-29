namespace RobotTest
{
    partial class TestForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TestBrowser = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // TestBrowser
            // 
            this.TestBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TestBrowser.Location = new System.Drawing.Point(0, 0);
            this.TestBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.TestBrowser.Name = "TestBrowser";
            this.TestBrowser.ScriptErrorsSuppressed = true;
            this.TestBrowser.Size = new System.Drawing.Size(284, 261);
            this.TestBrowser.TabIndex = 0;
            this.TestBrowser.Url = new System.Uri("http://www.bing.com/", System.UriKind.Absolute);
            this.TestBrowser.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.TestBrowser_DocumentCompleted);
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.TestBrowser);
            this.Name = "TestForm";
            this.Text = "Teste Robô";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser TestBrowser;
    }
}

