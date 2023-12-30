
using System.Windows.Forms;

namespace DownloadVideoYoutubeTool
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.link_lbl = new System.Windows.Forms.Label();
            this.txtLink = new System.Windows.Forms.TextBox();
            this.btn_download = new System.Windows.Forms.Button();
            this.lblPercent = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cobResolution = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.get_btn = new System.Windows.Forms.Button();
            this.empty_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // link_lbl
            // 
            this.link_lbl.AutoSize = true;
            this.link_lbl.BackColor = System.Drawing.Color.Transparent;
            this.link_lbl.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.link_lbl.Location = new System.Drawing.Point(25, 30);
            this.link_lbl.Name = "link_lbl";
            this.link_lbl.Size = new System.Drawing.Size(95, 18);
            this.link_lbl.TabIndex = 0;
            this.link_lbl.Text = "Video Link:";
            // 
            // txtLink
            // 
            this.txtLink.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLink.ForeColor = System.Drawing.Color.Red;
            this.txtLink.Location = new System.Drawing.Point(126, 27);
            this.txtLink.Multiline = true;
            this.txtLink.Name = "txtLink";
            this.txtLink.Size = new System.Drawing.Size(326, 24);
            this.txtLink.TabIndex = 1;
            this.txtLink.WordWrap = false;
            // 
            // btn_download
            // 
            this.btn_download.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_download.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_download.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_download.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_download.Location = new System.Drawing.Point(28, 135);
            this.btn_download.Name = "btn_download";
            this.btn_download.Size = new System.Drawing.Size(424, 40);
            this.btn_download.TabIndex = 5;
            this.btn_download.Text = "Download";
            this.btn_download.UseVisualStyleBackColor = false;
            this.btn_download.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // lblPercent
            // 
            this.lblPercent.AutoSize = true;
            this.lblPercent.BackColor = System.Drawing.Color.Transparent;
            this.lblPercent.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPercent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblPercent.Location = new System.Drawing.Point(122, 106);
            this.lblPercent.Name = "lblPercent";
            this.lblPercent.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblPercent.Size = new System.Drawing.Size(0, 16);
            this.lblPercent.TabIndex = 7;
            this.lblPercent.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblPercent.UseMnemonic = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 18);
            this.label1.TabIndex = 8;
            this.label1.Text = "Resolution:";
            // 
            // cobResolution
            // 
            this.cobResolution.AccessibleRole = System.Windows.Forms.AccessibleRole.ComboBox;
            this.cobResolution.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cobResolution.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cobResolution.FormattingEnabled = true;
            this.cobResolution.Items.AddRange(new object[] {
            "Select Resolution",
            "360",
            "480",
            "720"});
            this.cobResolution.Location = new System.Drawing.Point(126, 67);
            this.cobResolution.Name = "cobResolution";
            this.cobResolution.Size = new System.Drawing.Size(326, 24);
            this.cobResolution.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(316, 281);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Developed by @IT810";
            // 
            // get_btn
            // 
            this.get_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.get_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.get_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.get_btn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.get_btn.Location = new System.Drawing.Point(28, 181);
            this.get_btn.Name = "get_btn";
            this.get_btn.Size = new System.Drawing.Size(424, 40);
            this.get_btn.TabIndex = 11;
            this.get_btn.Text = "Get Info";
            this.get_btn.UseVisualStyleBackColor = false;
            // 
            // empty_btn
            // 
            this.empty_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.empty_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.empty_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.empty_btn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empty_btn.Location = new System.Drawing.Point(28, 227);
            this.empty_btn.Name = "empty_btn";
            this.empty_btn.Size = new System.Drawing.Size(424, 40);
            this.empty_btn.TabIndex = 12;
            this.empty_btn.Text = "Empty";
            this.empty_btn.UseVisualStyleBackColor = false;
            this.empty_btn.Click += new System.EventHandler(this.empty_btn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(484, 311);
            this.Controls.Add(this.empty_btn);
            this.Controls.Add(this.get_btn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cobResolution);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblPercent);
            this.Controls.Add(this.btn_download);
            this.Controls.Add(this.txtLink);
            this.Controls.Add(this.link_lbl);
            this.Font = new System.Drawing.Font("Candara", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Download Video Youtube Tool - v1.0.0.0";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label link_lbl;
        private System.Windows.Forms.TextBox txtLink;
        private System.Windows.Forms.Button btn_download;
        private System.Windows.Forms.Label lblPercent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cobResolution;
        private Label label2;
        private Button get_btn;
        private Button empty_btn;
    }
}