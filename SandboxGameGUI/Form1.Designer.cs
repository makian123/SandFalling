
namespace SandboxGameGUI
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.outPic = new System.Windows.Forms.PictureBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.playBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.increaseRadBtn = new System.Windows.Forms.Button();
            this.reduceRadBtn = new System.Windows.Forms.Button();
            this.radLabel = new System.Windows.Forms.Label();
            this.sandBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.barrierBtn = new System.Windows.Forms.Button();
            this.airBtn = new System.Windows.Forms.Button();
            this.waterBtn = new System.Windows.Forms.Button();
            this.pourableCheck = new System.Windows.Forms.CheckBox();
            this.woodBtn = new System.Windows.Forms.Button();
            this.fireBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.outPic)).BeginInit();
            this.SuspendLayout();
            // 
            // outPic
            // 
            this.outPic.Location = new System.Drawing.Point(9, 9);
            this.outPic.Margin = new System.Windows.Forms.Padding(0);
            this.outPic.Name = "outPic";
            this.outPic.Size = new System.Drawing.Size(315, 300);
            this.outPic.TabIndex = 0;
            this.outPic.TabStop = false;
            this.outPic.MouseDown += new System.Windows.Forms.MouseEventHandler(this.outPic_MouseDown_1);
            this.outPic.MouseMove += new System.Windows.Forms.MouseEventHandler(this.outPic_MouseMove);
            this.outPic.MouseUp += new System.Windows.Forms.MouseEventHandler(this.outPic_MouseUp);
            // 
            // timer
            // 
            this.timer.Interval = 1;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // playBtn
            // 
            this.playBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.playBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playBtn.Location = new System.Drawing.Point(9, 426);
            this.playBtn.Name = "playBtn";
            this.playBtn.Size = new System.Drawing.Size(75, 23);
            this.playBtn.TabIndex = 1;
            this.playBtn.Text = "Play/Pause";
            this.playBtn.UseVisualStyleBackColor = true;
            this.playBtn.Click += new System.EventHandler(this.playBtn_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 392);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Radius:";
            // 
            // increaseRadBtn
            // 
            this.increaseRadBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.increaseRadBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.increaseRadBtn.Location = new System.Drawing.Point(114, 387);
            this.increaseRadBtn.Name = "increaseRadBtn";
            this.increaseRadBtn.Size = new System.Drawing.Size(22, 22);
            this.increaseRadBtn.TabIndex = 3;
            this.increaseRadBtn.Text = "+";
            this.increaseRadBtn.UseVisualStyleBackColor = true;
            this.increaseRadBtn.Click += new System.EventHandler(this.increaseRadBtn_Click);
            // 
            // reduceRadBtn
            // 
            this.reduceRadBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.reduceRadBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reduceRadBtn.Location = new System.Drawing.Point(61, 387);
            this.reduceRadBtn.Name = "reduceRadBtn";
            this.reduceRadBtn.Size = new System.Drawing.Size(22, 22);
            this.reduceRadBtn.TabIndex = 4;
            this.reduceRadBtn.Text = "-";
            this.reduceRadBtn.UseVisualStyleBackColor = true;
            this.reduceRadBtn.Click += new System.EventHandler(this.reduceRadBtn_Click);
            // 
            // radLabel
            // 
            this.radLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.radLabel.AutoSize = true;
            this.radLabel.Location = new System.Drawing.Point(89, 392);
            this.radLabel.Name = "radLabel";
            this.radLabel.Size = new System.Drawing.Size(19, 13);
            this.radLabel.TabIndex = 5;
            this.radLabel.Text = "10";
            // 
            // sandBtn
            // 
            this.sandBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.sandBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sandBtn.Location = new System.Drawing.Point(61, 312);
            this.sandBtn.Name = "sandBtn";
            this.sandBtn.Size = new System.Drawing.Size(55, 23);
            this.sandBtn.TabIndex = 6;
            this.sandBtn.Text = "Sand";
            this.sandBtn.UseVisualStyleBackColor = true;
            this.sandBtn.Click += new System.EventHandler(this.sandBtn_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 317);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Type:";
            // 
            // barrierBtn
            // 
            this.barrierBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.barrierBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.barrierBtn.Location = new System.Drawing.Point(122, 312);
            this.barrierBtn.Name = "barrierBtn";
            this.barrierBtn.Size = new System.Drawing.Size(55, 23);
            this.barrierBtn.TabIndex = 8;
            this.barrierBtn.Text = "Barrier";
            this.barrierBtn.UseVisualStyleBackColor = true;
            this.barrierBtn.Click += new System.EventHandler(this.barrierBtn_Click);
            // 
            // airBtn
            // 
            this.airBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.airBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.airBtn.Location = new System.Drawing.Point(183, 312);
            this.airBtn.Name = "airBtn";
            this.airBtn.Size = new System.Drawing.Size(55, 23);
            this.airBtn.TabIndex = 9;
            this.airBtn.Text = "Air";
            this.airBtn.UseVisualStyleBackColor = true;
            this.airBtn.Click += new System.EventHandler(this.airBtn_Click);
            // 
            // waterBtn
            // 
            this.waterBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.waterBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.waterBtn.Location = new System.Drawing.Point(244, 312);
            this.waterBtn.Name = "waterBtn";
            this.waterBtn.Size = new System.Drawing.Size(55, 23);
            this.waterBtn.TabIndex = 10;
            this.waterBtn.Text = "Water";
            this.waterBtn.UseVisualStyleBackColor = true;
            this.waterBtn.Click += new System.EventHandler(this.waterBtn_Click);
            // 
            // pourableCheck
            // 
            this.pourableCheck.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pourableCheck.AutoSize = true;
            this.pourableCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pourableCheck.Location = new System.Drawing.Point(1, 347);
            this.pourableCheck.Name = "pourableCheck";
            this.pourableCheck.Size = new System.Drawing.Size(54, 17);
            this.pourableCheck.TabIndex = 11;
            this.pourableCheck.Text = "Infinite";
            this.pourableCheck.UseVisualStyleBackColor = true;
            this.pourableCheck.CheckedChanged += new System.EventHandler(this.pourableCheck_CheckedChanged);
            // 
            // woodBtn
            // 
            this.woodBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.woodBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.woodBtn.Location = new System.Drawing.Point(61, 341);
            this.woodBtn.Name = "woodBtn";
            this.woodBtn.Size = new System.Drawing.Size(55, 23);
            this.woodBtn.TabIndex = 12;
            this.woodBtn.Text = "Wood";
            this.woodBtn.UseVisualStyleBackColor = true;
            this.woodBtn.Click += new System.EventHandler(this.woodBtn_Click);
            // 
            // fireBtn
            // 
            this.fireBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.fireBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fireBtn.Location = new System.Drawing.Point(122, 341);
            this.fireBtn.Name = "fireBtn";
            this.fireBtn.Size = new System.Drawing.Size(55, 23);
            this.fireBtn.TabIndex = 13;
            this.fireBtn.Text = "Fire";
            this.fireBtn.UseVisualStyleBackColor = true;
            this.fireBtn.Click += new System.EventHandler(this.fireBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 461);
            this.Controls.Add(this.fireBtn);
            this.Controls.Add(this.woodBtn);
            this.Controls.Add(this.pourableCheck);
            this.Controls.Add(this.waterBtn);
            this.Controls.Add(this.airBtn);
            this.Controls.Add(this.barrierBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.sandBtn);
            this.Controls.Add(this.radLabel);
            this.Controls.Add(this.reduceRadBtn);
            this.Controls.Add(this.increaseRadBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.playBtn);
            this.Controls.Add(this.outPic);
            this.MinimumSize = new System.Drawing.Size(500, 500);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.outPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox outPic;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button playBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button increaseRadBtn;
        private System.Windows.Forms.Button reduceRadBtn;
        private System.Windows.Forms.Label radLabel;
        private System.Windows.Forms.Button sandBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button barrierBtn;
        private System.Windows.Forms.Button airBtn;
        private System.Windows.Forms.Button waterBtn;
        private System.Windows.Forms.CheckBox pourableCheck;
        private System.Windows.Forms.Button woodBtn;
        private System.Windows.Forms.Button fireBtn;
    }
}

