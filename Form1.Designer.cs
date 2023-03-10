namespace ParticleSystem_KulakovDA_ISTb_21_1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.picDisplay = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tbDirection = new System.Windows.Forms.TrackBar();
            this.lblDirection = new System.Windows.Forms.Label();
            this.lblDirection1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblGravitation1 = new System.Windows.Forms.Label();
            this.tbGraviton1 = new System.Windows.Forms.TrackBar();
            this.tbGraviton2 = new System.Windows.Forms.TrackBar();
            this.lblGravitation2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.substrateCheckBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.picDisplay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbDirection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbGraviton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbGraviton2)).BeginInit();
            this.SuspendLayout();
            // 
            // picDisplay
            // 
            this.picDisplay.Location = new System.Drawing.Point(11, 12);
            this.picDisplay.Name = "picDisplay";
            this.picDisplay.Size = new System.Drawing.Size(711, 376);
            this.picDisplay.TabIndex = 0;
            this.picDisplay.TabStop = false;
            this.picDisplay.Click += new System.EventHandler(this.picDisplay_Click);
            this.picDisplay.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picDisplay_MouseMove);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 40;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tbDirection
            // 
            this.tbDirection.Location = new System.Drawing.Point(11, 416);
            this.tbDirection.Maximum = 360;
            this.tbDirection.Name = "tbDirection";
            this.tbDirection.Size = new System.Drawing.Size(208, 56);
            this.tbDirection.TabIndex = 1;
            this.tbDirection.Scroll += new System.EventHandler(this.tbDirection_Scroll);
            // 
            // lblDirection
            // 
            this.lblDirection.AutoSize = true;
            this.lblDirection.Location = new System.Drawing.Point(198, 393);
            this.lblDirection.Name = "lblDirection";
            this.lblDirection.Size = new System.Drawing.Size(0, 20);
            this.lblDirection.TabIndex = 2;
            // 
            // lblDirection1
            // 
            this.lblDirection1.AutoSize = true;
            this.lblDirection1.Location = new System.Drawing.Point(215, 416);
            this.lblDirection1.Name = "lblDirection1";
            this.lblDirection1.Size = new System.Drawing.Size(23, 20);
            this.lblDirection1.TabIndex = 3;
            this.lblDirection1.Text = "0*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 395);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Направление";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(245, 391);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Сила 1 точки";
            // 
            // lblGravitation1
            // 
            this.lblGravitation1.AutoSize = true;
            this.lblGravitation1.Location = new System.Drawing.Point(357, 416);
            this.lblGravitation1.Name = "lblGravitation1";
            this.lblGravitation1.Size = new System.Drawing.Size(17, 20);
            this.lblGravitation1.TabIndex = 6;
            this.lblGravitation1.Text = "0";
            // 
            // tbGraviton1
            // 
            this.tbGraviton1.Location = new System.Drawing.Point(242, 412);
            this.tbGraviton1.Maximum = 100;
            this.tbGraviton1.Name = "tbGraviton1";
            this.tbGraviton1.Size = new System.Drawing.Size(118, 56);
            this.tbGraviton1.TabIndex = 5;
            this.tbGraviton1.Scroll += new System.EventHandler(this.tbGraviton_Scroll);
            // 
            // tbGraviton2
            // 
            this.tbGraviton2.Location = new System.Drawing.Point(389, 416);
            this.tbGraviton2.Maximum = 100;
            this.tbGraviton2.Name = "tbGraviton2";
            this.tbGraviton2.Size = new System.Drawing.Size(118, 56);
            this.tbGraviton2.TabIndex = 8;
            this.tbGraviton2.Scroll += new System.EventHandler(this.tbGraviton2_Scroll);
            // 
            // lblGravitation2
            // 
            this.lblGravitation2.AutoSize = true;
            this.lblGravitation2.Location = new System.Drawing.Point(503, 416);
            this.lblGravitation2.Name = "lblGravitation2";
            this.lblGravitation2.Size = new System.Drawing.Size(17, 20);
            this.lblGravitation2.TabIndex = 9;
            this.lblGravitation2.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(389, 391);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Сила 2 точки";
            // 
            // substrateCheckBox
            // 
            this.substrateCheckBox.AutoSize = true;
            this.substrateCheckBox.Location = new System.Drawing.Point(728, 12);
            this.substrateCheckBox.Name = "substrateCheckBox";
            this.substrateCheckBox.Size = new System.Drawing.Size(144, 24);
            this.substrateCheckBox.TabIndex = 11;
            this.substrateCheckBox.Text = "Подложка точек";
            this.substrateCheckBox.UseVisualStyleBackColor = true;
            this.substrateCheckBox.CheckedChanged += new System.EventHandler(this.Substrate_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 465);
            this.Controls.Add(this.substrateCheckBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblGravitation2);
            this.Controls.Add(this.tbGraviton2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblGravitation1);
            this.Controls.Add(this.tbGraviton1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblDirection1);
            this.Controls.Add(this.lblDirection);
            this.Controls.Add(this.tbDirection);
            this.Controls.Add(this.picDisplay);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.picDisplay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbDirection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbGraviton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbGraviton2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox picDisplay;
        private System.Windows.Forms.Timer timer1;
        private TrackBar tbDirection;
        private Label lblDirection;
        private Label lblDirection1;
        private Label label1;
        private Label label2;
        private Label lblGravitation1;
        private TrackBar tbGraviton1;
        private TrackBar tbGraviton2;
        private Label lblGravitation2;
        private Label label4;
        private CheckBox substrateCheckBox;
    }
}