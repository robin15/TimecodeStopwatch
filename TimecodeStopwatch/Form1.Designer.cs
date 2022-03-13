using System.Windows.Forms;

namespace TimecodeStopwatch
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.PictureBox pictureBox1;
            this.label1 = new System.Windows.Forms.Label();
            this.start = new System.Windows.Forms.Button();
            this.stop = new System.Windows.Forms.Button();
            this.reset = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.fps60 = new System.Windows.Forms.RadioButton();
            this.fps30 = new System.Windows.Forms.RadioButton();
            this.fps24 = new System.Windows.Forms.RadioButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            pictureBox1.Image = global::TimecodeStopwatch.Properties.Resources.close;
            pictureBox1.Location = new System.Drawing.Point(822, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(30, 29);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 80F);
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(66, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(674, 134);
            this.label1.TabIndex = 0;
            this.label1.Text = "00:00:00:00";
            // 
            // start
            // 
            this.start.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.start.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start.Location = new System.Drawing.Point(78, 208);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(99, 39);
            this.start.TabIndex = 1;
            this.start.Text = "Start";
            this.start.UseVisualStyleBackColor = false;
            this.start.Click += new System.EventHandler(this.button1_Click);
            // 
            // stop
            // 
            this.stop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.stop.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stop.Location = new System.Drawing.Point(216, 208);
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(99, 39);
            this.stop.TabIndex = 2;
            this.stop.Text = "Stop";
            this.stop.UseVisualStyleBackColor = false;
            this.stop.Click += new System.EventHandler(this.button2_Click);
            // 
            // reset
            // 
            this.reset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.reset.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reset.Location = new System.Drawing.Point(354, 208);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(99, 39);
            this.reset.TabIndex = 3;
            this.reset.Text = "Reset";
            this.reset.UseVisualStyleBackColor = false;
            this.reset.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.fps60);
            this.groupBox1.Controls.Add(this.fps30);
            this.groupBox1.Controls.Add(this.fps24);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.LightGreen;
            this.groupBox1.Location = new System.Drawing.Point(498, 186);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(287, 73);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Format";
            // 
            // fps60
            // 
            this.fps60.AutoSize = true;
            this.fps60.Location = new System.Drawing.Point(194, 30);
            this.fps60.Name = "fps60";
            this.fps60.Size = new System.Drawing.Size(75, 25);
            this.fps60.TabIndex = 2;
            this.fps60.TabStop = true;
            this.fps60.Text = "60fps";
            this.fps60.UseVisualStyleBackColor = true;
            this.fps60.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // fps30
            // 
            this.fps30.AutoSize = true;
            this.fps30.Location = new System.Drawing.Point(108, 30);
            this.fps30.Name = "fps30";
            this.fps30.Size = new System.Drawing.Size(75, 25);
            this.fps30.TabIndex = 1;
            this.fps30.TabStop = true;
            this.fps30.Text = "30fps";
            this.fps30.UseVisualStyleBackColor = true;
            this.fps30.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // fps24
            // 
            this.fps24.AutoSize = true;
            this.fps24.Checked = true;
            this.fps24.Location = new System.Drawing.Point(23, 30);
            this.fps24.Name = "fps24";
            this.fps24.Size = new System.Drawing.Size(75, 25);
            this.fps24.TabIndex = 0;
            this.fps24.TabStop = true;
            this.fps24.Text = "24fps";
            this.fps24.UseVisualStyleBackColor = true;
            this.fps24.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Location = new System.Drawing.Point(0, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(860, 279);
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.pictureBox2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(864, 285);
            this.Controls.Add(pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.stop);
            this.Controls.Add(this.start);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Button stop;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton fps60;
        private System.Windows.Forms.RadioButton fps30;
        private System.Windows.Forms.RadioButton fps24;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

