namespace Lab4_3
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            txtUrl = new TextBox();
            btnLoad = new Button();
            btnDownloadHtml = new Button();
            btnDownloadResources = new Button();
            webBrowser = new WebBrowser();
            SuspendLayout();
            // 
            // txtUrl
            // 
            txtUrl.Location = new Point(21, 26);
            txtUrl.Margin = new Padding(5, 6, 5, 6);
            txtUrl.Name = "txtUrl";
            txtUrl.Size = new Size(1257, 39);
            txtUrl.TabIndex = 0;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(21, 84);
            btnLoad.Margin = new Padding(5, 6, 5, 6);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(122, 46);
            btnLoad.TabIndex = 1;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // btnDownloadHtml
            // 
            btnDownloadHtml.Location = new Point(154, 84);
            btnDownloadHtml.Margin = new Padding(5, 6, 5, 6);
            btnDownloadHtml.Name = "btnDownloadHtml";
            btnDownloadHtml.Size = new Size(194, 46);
            btnDownloadHtml.TabIndex = 2;
            btnDownloadHtml.Text = "Down HTML";
            btnDownloadHtml.UseVisualStyleBackColor = true;
            btnDownloadHtml.Click += btnDownloadHtml_Click;
            // 
            // btnDownloadResources
            // 
            btnDownloadResources.Location = new Point(385, 84);
            btnDownloadResources.Margin = new Padding(5, 6, 5, 6);
            btnDownloadResources.Name = "btnDownloadResources";
            btnDownloadResources.Size = new Size(236, 46);
            btnDownloadResources.TabIndex = 3;
            btnDownloadResources.Text = "Down Resources\r\n";
            btnDownloadResources.UseVisualStyleBackColor = true;
            btnDownloadResources.Click += btnDownloadResources_Click;
            // 
            // webBrowser
            // 
            webBrowser.Location = new Point(21, 144);
            webBrowser.Margin = new Padding(5, 6, 5, 6);
            webBrowser.MinimumSize = new Size(32, 40);
            webBrowser.Name = "webBrowser";
            webBrowser.Size = new Size(1259, 732);
            webBrowser.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1300, 900);
            Controls.Add(webBrowser);
            Controls.Add(btnDownloadResources);
            Controls.Add(btnDownloadHtml);
            Controls.Add(btnLoad);
            Controls.Add(txtUrl);
            Margin = new Padding(5, 6, 5, 6);
            Name = "Form1";
            Text = "Basic Web Browser";
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnDownloadHtml;
        private System.Windows.Forms.Button btnDownloadResources;
        private System.Windows.Forms.WebBrowser webBrowser;
    }
}
