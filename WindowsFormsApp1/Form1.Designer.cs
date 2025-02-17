using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.alltap = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.listBoxSelectedFiles = new System.Windows.Forms.ListBox();
            this.buttonGetSubtitleFiles = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnConvert = new System.Windows.Forms.Button();
            this.alltap.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // alltap
            // 
            this.alltap.Controls.Add(this.tabPage1);
            this.alltap.Controls.Add(this.tabPage2);
            this.alltap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.alltap.Location = new System.Drawing.Point(0, 0);
            this.alltap.Name = "alltap";
            this.alltap.SelectedIndex = 0;
            this.alltap.Size = new System.Drawing.Size(800, 450);
            this.alltap.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnConvert);
            this.tabPage1.Controls.Add(this.listBoxSelectedFiles);
            this.tabPage1.Controls.Add(this.buttonGetSubtitleFiles);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 424);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // listBoxSelectedFiles
            // 
            this.listBoxSelectedFiles.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listBoxSelectedFiles.FormattingEnabled = true;
            this.listBoxSelectedFiles.ItemHeight = 12;
            this.listBoxSelectedFiles.Location = new System.Drawing.Point(3, 6);
            this.listBoxSelectedFiles.Name = "listBoxSelectedFiles";
            this.listBoxSelectedFiles.Size = new System.Drawing.Size(226, 412);
            this.listBoxSelectedFiles.TabIndex = 1;
            this.listBoxSelectedFiles.SelectedIndexChanged += new System.EventHandler(this.buttonGetSubtitleFiles_SelectedIndexChanged);
            // 
            // buttonGetSubtitleFiles
            // 
            this.buttonGetSubtitleFiles.Location = new System.Drawing.Point(287, 125);
            this.buttonGetSubtitleFiles.Name = "buttonGetSubtitleFiles";
            this.buttonGetSubtitleFiles.Size = new System.Drawing.Size(75, 23);
            this.buttonGetSubtitleFiles.TabIndex = 0;
            this.buttonGetSubtitleFiles.Text = "获取字幕文件";
            this.buttonGetSubtitleFiles.UseVisualStyleBackColor = true;
            this.buttonGetSubtitleFiles.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 424);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "TxtFusion";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "SRT Files|*.srt";
            this.openFileDialog1.Multiselect = true;
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(287, 249);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(85, 23);
            this.btnConvert.TabIndex = 2;
            this.btnConvert.Text = "字幕文件转换";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.alltap);
            this.Name = "Form1";
            this.Text = "Form1";
            this.alltap.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);

        }



        #endregion

        private System.Windows.Forms.TabControl alltap;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private ListBox listBoxSelectedFiles;
        private Button buttonGetSubtitleFiles;
        private OpenFileDialog openFileDialog1;
        private Button btnConvert;
    }
}

