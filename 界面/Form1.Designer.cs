using System.Drawing;

namespace WindowsFormsApp1
{
    partial class WordCount
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
        private void InitializeComponent()

        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WordCount));
            this.count = new System.Windows.Forms.Button();
            this.view = new System.Windows.Forms.Button();
            this.txtFilepath = new System.Windows.Forms.TextBox();
            this.txtOutPutInfo = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.path = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // count
            // 
            this.count.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.count.Location = new System.Drawing.Point(33, 134);
            this.count.Name = "count";
            this.count.Size = new System.Drawing.Size(107, 40);
            this.count.TabIndex = 0;
            this.count.Text = "统计结果";
            this.count.UseVisualStyleBackColor = true;
            this.count.Click += new System.EventHandler(this.count_Click);
            // 
            // view
            // 
            this.view.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.view.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.view.Location = new System.Drawing.Point(266, 90);
            this.view.Name = "view";
            this.view.Size = new System.Drawing.Size(94, 33);
            this.view.TabIndex = 1;
            this.view.Text = "检索";
            this.view.UseVisualStyleBackColor = false;
            this.view.Click += new System.EventHandler(this.view_Click);
            // 
            // txtFilepath
            // 
            this.txtFilepath.Font = new System.Drawing.Font("宋体", 9F);
            this.txtFilepath.Location = new System.Drawing.Point(33, 59);
            this.txtFilepath.Name = "txtFilepath";
            this.txtFilepath.Size = new System.Drawing.Size(327, 25);
            this.txtFilepath.TabIndex = 2;
            this.txtFilepath.TextChanged += new System.EventHandler(this.txtFilepath_TextChanged);
            // 
            // txtOutPutInfo
            // 
            this.txtOutPutInfo.Font = new System.Drawing.Font("宋体", 9F);
            this.txtOutPutInfo.Location = new System.Drawing.Point(33, 180);
            this.txtOutPutInfo.Multiline = true;
            this.txtOutPutInfo.Name = "txtOutPutInfo";
            this.txtOutPutInfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtOutPutInfo.Size = new System.Drawing.Size(327, 134);
            this.txtOutPutInfo.TabIndex = 3;
            this.txtOutPutInfo.TextChanged += new System.EventHandler(this.txtOutPutInfo_TextChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // path
            // 
            this.path.AutoSize = true;
            this.path.BackColor = System.Drawing.Color.Transparent;
            this.path.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.path.Location = new System.Drawing.Point(29, 18);
            this.path.Name = "path";
            this.path.Size = new System.Drawing.Size(90, 24);
            this.path.TabIndex = 4;
            this.path.Text = "文件路径";
            this.path.Click += new System.EventHandler(this.path_Click);
            // 
            // WordCount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = Image.FromFile(@"C:\Users\Destiny\Pictures\background.jpg");
            this.ClientSize = new System.Drawing.Size(640, 323);
            this.Controls.Add(this.path);
            this.Controls.Add(this.txtOutPutInfo);
            this.Controls.Add(this.txtFilepath);
            this.Controls.Add(this.view);
            this.Controls.Add(this.count);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Name = "WordCount";
            this.Text = "Word Count";
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        #endregion



        private System.Windows.Forms.Button count;

        private System.Windows.Forms.Button view;

        private System.Windows.Forms.TextBox txtFilepath;

        private System.Windows.Forms.TextBox txtOutPutInfo;

        private System.Windows.Forms.OpenFileDialog openFileDialog1;

        private System.Windows.Forms.Label path;
    }
}

