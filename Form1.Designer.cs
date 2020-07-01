using System;
using System.Windows.Forms;

namespace WindowsForms
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
            this.menuBar = new System.Windows.Forms.MenuStrip();
            this.settings = new System.Windows.Forms.ToolStripMenuItem();
            this.function = new System.Windows.Forms.ToolStripMenuItem();
            this.help = new System.Windows.Forms.ToolStripMenuItem();
            this.importFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuBar
            // 
            this.menuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settings,
            this.function,
            this.help});
            this.menuBar.Location = new System.Drawing.Point(0, 0);
            this.menuBar.Name = "menuBar";
            this.menuBar.Size = new System.Drawing.Size(800, 25);
            this.menuBar.TabIndex = 0;
            this.menuBar.Text = "主菜单栏";
            // 
            // settings
            // 
            this.settings.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importFile});
            this.settings.Name = "settings";
            this.settings.Size = new System.Drawing.Size(44, 21);
            this.settings.Text = "选项";
            this.settings.Click += new System.EventHandler(this.selectFunction);
            // 
            // function
            // 
            this.function.Name = "function";
            this.function.Size = new System.Drawing.Size(44, 21);
            this.function.Text = "功能";
            this.function.Click += new System.EventHandler(this.selectFunction);
            // 
            // help
            // 
            this.help.Name = "help";
            this.help.Size = new System.Drawing.Size(44, 21);
            this.help.Text = "帮助";
            this.help.Click += new System.EventHandler(this.selectFunction);
            // 
            // importFile
            // 
            this.importFile.Name = "importFile";
            this.importFile.Size = new System.Drawing.Size(180, 22);
            this.importFile.Text = "导入文件";
            this.importFile.Click += new System.EventHandler(this.selectFunction);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuBar);
            this.MainMenuStrip = this.menuBar;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "文件测试窗口";
            this.Click += new System.EventHandler(this.selectFunction);
            this.menuBar.ResumeLayout(false);
            this.menuBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuBar;
        private System.Windows.Forms.ToolStripMenuItem settings;
        private System.Windows.Forms.ToolStripMenuItem function;
        private System.Windows.Forms.ToolStripMenuItem help;
        private System.Windows.Forms.ToolStripMenuItem importFile;

        public void selectFunction(object sender, EventArgs e){
            Console.WriteLine("你点击了{0}按钮，触发了{1}事件",sender,e);
            if (sender.Equals(this)) {
                Console.WriteLine("SOS!");

            } else if (sender.Equals(settings))
            {
                Console.WriteLine("settings!");
            } else if (sender.Equals(help))
            {
                Console.WriteLine("help!");
            } else if (sender.Equals(function))
            {
                Console.WriteLine("function!");
            } else if (sender.Equals(importFile))
            {
                Console.WriteLine("importFile!");
                Form sForm = new Form();
                sForm.Name = "sFrom";
                sForm.Text = "选择文件";
                sForm.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
                sForm.ShowDialog();
                
            }
        }

        
    }
}

