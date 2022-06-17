namespace Tema5
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
            this.topleft = new System.Windows.Forms.PictureBox();
            this.left = new System.Windows.Forms.PictureBox();
            this.top = new System.Windows.Forms.PictureBox();
            this.topright = new System.Windows.Forms.PictureBox();
            this.right = new System.Windows.Forms.PictureBox();
            this.goalKeeper = new System.Windows.Forms.PictureBox();
            this.football = new System.Windows.Forms.PictureBox();
            this.missText = new System.Windows.Forms.Label();
            this.goalText = new System.Windows.Forms.Label();
            this.keeperTimer = new System.Windows.Forms.Timer(this.components);
            this.ballTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.topleft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.left)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.top)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.topright)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.right)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.goalKeeper)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.football)).BeginInit();
            this.SuspendLayout();
            // 
            // topleft
            // 
            this.topleft.BackColor = System.Drawing.Color.Yellow;
            this.topleft.Image = global::Tema5.Properties.Resources.target;
            this.topleft.Location = new System.Drawing.Point(205, 78);
            this.topleft.Name = "topleft";
            this.topleft.Size = new System.Drawing.Size(40, 35);
            this.topleft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.topleft.TabIndex = 0;
            this.topleft.TabStop = false;
            this.topleft.Tag = "topleft";
            this.topleft.Click += new System.EventHandler(this.setTarget);
            // 
            // left
            // 
            this.left.BackColor = System.Drawing.Color.Yellow;
            this.left.Image = global::Tema5.Properties.Resources.target;
            this.left.Location = new System.Drawing.Point(205, 232);
            this.left.Name = "left";
            this.left.Size = new System.Drawing.Size(40, 35);
            this.left.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.left.TabIndex = 1;
            this.left.TabStop = false;
            this.left.Tag = "left";
            this.left.Click += new System.EventHandler(this.setTarget);
            // 
            // top
            // 
            this.top.BackColor = System.Drawing.Color.Yellow;
            this.top.Image = global::Tema5.Properties.Resources.target;
            this.top.Location = new System.Drawing.Point(437, 78);
            this.top.Name = "top";
            this.top.Size = new System.Drawing.Size(40, 35);
            this.top.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.top.TabIndex = 2;
            this.top.TabStop = false;
            this.top.Tag = "top";
            this.top.Click += new System.EventHandler(this.setTarget);
            // 
            // topright
            // 
            this.topright.BackColor = System.Drawing.Color.Yellow;
            this.topright.Image = global::Tema5.Properties.Resources.target;
            this.topright.Location = new System.Drawing.Point(685, 78);
            this.topright.Name = "topright";
            this.topright.Size = new System.Drawing.Size(40, 35);
            this.topright.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.topright.TabIndex = 3;
            this.topright.TabStop = false;
            this.topright.Tag = "topright";
            this.topright.Click += new System.EventHandler(this.setTarget);
            // 
            // right
            // 
            this.right.BackColor = System.Drawing.Color.Yellow;
            this.right.Image = global::Tema5.Properties.Resources.target;
            this.right.Location = new System.Drawing.Point(685, 232);
            this.right.Name = "right";
            this.right.Size = new System.Drawing.Size(40, 35);
            this.right.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.right.TabIndex = 4;
            this.right.TabStop = false;
            this.right.Tag = "right";
            this.right.Click += new System.EventHandler(this.setTarget);
            // 
            // goalKeeper
            // 
            this.goalKeeper.BackColor = System.Drawing.Color.Transparent;
            this.goalKeeper.Image = global::Tema5.Properties.Resources.stand_small;
            this.goalKeeper.Location = new System.Drawing.Point(426, 162);
            this.goalKeeper.Name = "goalKeeper";
            this.goalKeeper.Size = new System.Drawing.Size(82, 126);
            this.goalKeeper.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.goalKeeper.TabIndex = 5;
            this.goalKeeper.TabStop = false;
            // 
            // football
            // 
            this.football.BackColor = System.Drawing.Color.Transparent;
            this.football.Image = global::Tema5.Properties.Resources.football;
            this.football.Location = new System.Drawing.Point(413, 481);
            this.football.Name = "football";
            this.football.Size = new System.Drawing.Size(50, 51);
            this.football.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.football.TabIndex = 6;
            this.football.TabStop = false;
            // 
            // missText
            // 
            this.missText.AutoSize = true;
            this.missText.BackColor = System.Drawing.Color.Transparent;
            this.missText.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.missText.ForeColor = System.Drawing.Color.White;
            this.missText.Location = new System.Drawing.Point(12, 15);
            this.missText.Name = "missText";
            this.missText.Size = new System.Drawing.Size(70, 22);
            this.missText.TabIndex = 7;
            this.missText.Text = "Miss: 0";
            // 
            // goalText
            // 
            this.goalText.AutoSize = true;
            this.goalText.BackColor = System.Drawing.Color.Transparent;
            this.goalText.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.goalText.ForeColor = System.Drawing.Color.White;
            this.goalText.Location = new System.Drawing.Point(800, 16);
            this.goalText.Name = "goalText";
            this.goalText.Size = new System.Drawing.Size(69, 22);
            this.goalText.TabIndex = 8;
            this.goalText.Text = "Goal: 0";
            // 
            // keeperTimer
            // 
            this.keeperTimer.Interval = 20;
            this.keeperTimer.Tick += new System.EventHandler(this.moveKeeper);
            // 
            // ballTimer
            // 
            this.ballTimer.Interval = 20;
            this.ballTimer.Tick += new System.EventHandler(this.shootball);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Tema5.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(899, 633);
            this.Controls.Add(this.goalText);
            this.Controls.Add(this.missText);
            this.Controls.Add(this.football);
            this.Controls.Add(this.goalKeeper);
            this.Controls.Add(this.right);
            this.Controls.Add(this.topright);
            this.Controls.Add(this.top);
            this.Controls.Add(this.left);
            this.Controls.Add(this.topleft);
            this.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.topleft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.left)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.top)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.topright)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.right)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.goalKeeper)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.football)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox topleft;
        private PictureBox left;
        private PictureBox top;
        private PictureBox topright;
        private PictureBox right;
        private PictureBox goalKeeper;
        private PictureBox football;
        private Label missText;
        private Label goalText;
        private System.Windows.Forms.Timer keeperTimer;
        private System.Windows.Forms.Timer ballTimer;
    }
}