namespace ElementaryMathGame
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
            nameBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            scoreboardNameBox = new ListBox();
            scoreboardScoreBox = new ListBox();
            label3 = new Label();
            gameStartBtn = new Button();
            panel1 = new Panel();
            oprtrAddSlctBtn = new Button();
            oprtrSubSlctBtn = new Button();
            oprtrMulSlctBtn = new Button();
            oprtrDivSlctBtn = new Button();
            oprtrAllSlctBtn = new Button();
            level1SlctBtn = new Button();
            level2SlctBtn = new Button();
            level3SlctBtn = new Button();
            level4SlctBtn = new Button();
            level5SlctBtn = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // nameBox
            // 
            nameBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            nameBox.Location = new Point(142, 83);
            nameBox.Name = "nameBox";
            nameBox.PlaceholderText = "Enter Your Name";
            nameBox.Size = new Size(170, 34);
            nameBox.TabIndex = 0;
            nameBox.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(142, 52);
            label1.Name = "label1";
            label1.Size = new Size(112, 28);
            label1.TabIndex = 1;
            label1.Text = "Your Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(631, 23);
            label2.Name = "label2";
            label2.Size = new Size(68, 28);
            label2.TabIndex = 2;
            label2.Text = "Levels:";
            label2.Click += label2_Click;
            // 
            // scoreboardNameBox
            // 
            scoreboardNameBox.FormattingEnabled = true;
            scoreboardNameBox.ItemHeight = 20;
            scoreboardNameBox.Location = new Point(61, 249);
            scoreboardNameBox.Name = "scoreboardNameBox";
            scoreboardNameBox.Size = new Size(150, 104);
            scoreboardNameBox.TabIndex = 3;
            // 
            // scoreboardScoreBox
            // 
            scoreboardScoreBox.FormattingEnabled = true;
            scoreboardScoreBox.ItemHeight = 20;
            scoreboardScoreBox.Location = new Point(217, 249);
            scoreboardScoreBox.Name = "scoreboardScoreBox";
            scoreboardScoreBox.Size = new Size(150, 104);
            scoreboardScoreBox.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(631, 155);
            label3.Name = "label3";
            label3.Size = new Size(166, 28);
            label3.TabIndex = 5;
            label3.Text = "Choose Operator:";
            // 
            // gameStartBtn
            // 
            gameStartBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            gameStartBtn.Location = new Point(160, 386);
            gameStartBtn.Name = "gameStartBtn";
            gameStartBtn.Size = new Size(94, 42);
            gameStartBtn.TabIndex = 16;
            gameStartBtn.Text = "Start";
            gameStartBtn.UseVisualStyleBackColor = true;
            gameStartBtn.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.RosyBrown;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(gameStartBtn);
            panel1.Controls.Add(nameBox);
            panel1.Controls.Add(scoreboardNameBox);
            panel1.Controls.Add(scoreboardScoreBox);
            panel1.Location = new Point(42, 23);
            panel1.Name = "panel1";
            panel1.Size = new Size(539, 464);
            panel1.TabIndex = 17;
            // 
            // oprtrAddSlctBtn
            // 
            oprtrAddSlctBtn.BackColor = Color.Green;
            oprtrAddSlctBtn.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            oprtrAddSlctBtn.Location = new Point(631, 228);
            oprtrAddSlctBtn.Name = "oprtrAddSlctBtn";
            oprtrAddSlctBtn.Size = new Size(126, 58);
            oprtrAddSlctBtn.TabIndex = 18;
            oprtrAddSlctBtn.Text = "+";
            oprtrAddSlctBtn.UseVisualStyleBackColor = false;
            oprtrAddSlctBtn.Click += button1_Click_1;
            // 
            // oprtrSubSlctBtn
            // 
            oprtrSubSlctBtn.BackColor = Color.White;
            oprtrSubSlctBtn.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            oprtrSubSlctBtn.Location = new Point(829, 228);
            oprtrSubSlctBtn.Name = "oprtrSubSlctBtn";
            oprtrSubSlctBtn.Size = new Size(126, 58);
            oprtrSubSlctBtn.TabIndex = 19;
            oprtrSubSlctBtn.Text = "-";
            oprtrSubSlctBtn.UseVisualStyleBackColor = false;
            oprtrSubSlctBtn.Click += oprtrSubSlctBtn_Click;
            // 
            // oprtrMulSlctBtn
            // 
            oprtrMulSlctBtn.BackColor = Color.White;
            oprtrMulSlctBtn.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            oprtrMulSlctBtn.Location = new Point(631, 292);
            oprtrMulSlctBtn.Name = "oprtrMulSlctBtn";
            oprtrMulSlctBtn.Size = new Size(126, 62);
            oprtrMulSlctBtn.TabIndex = 20;
            oprtrMulSlctBtn.Text = "*";
            oprtrMulSlctBtn.UseVisualStyleBackColor = false;
            oprtrMulSlctBtn.Click += oprtrMulSlctBtn_Click;
            // 
            // oprtrDivSlctBtn
            // 
            oprtrDivSlctBtn.BackColor = Color.White;
            oprtrDivSlctBtn.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            oprtrDivSlctBtn.Location = new Point(829, 292);
            oprtrDivSlctBtn.Name = "oprtrDivSlctBtn";
            oprtrDivSlctBtn.Size = new Size(126, 62);
            oprtrDivSlctBtn.TabIndex = 21;
            oprtrDivSlctBtn.Text = "/";
            oprtrDivSlctBtn.UseVisualStyleBackColor = false;
            oprtrDivSlctBtn.Click += oprtrDivSlctBtn_Click;
            // 
            // oprtrAllSlctBtn
            // 
            oprtrAllSlctBtn.BackColor = Color.White;
            oprtrAllSlctBtn.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            oprtrAllSlctBtn.Location = new Point(736, 360);
            oprtrAllSlctBtn.Name = "oprtrAllSlctBtn";
            oprtrAllSlctBtn.Size = new Size(117, 81);
            oprtrAllSlctBtn.TabIndex = 22;
            oprtrAllSlctBtn.Text = "ALL";
            oprtrAllSlctBtn.UseVisualStyleBackColor = false;
            oprtrAllSlctBtn.Click += oprtrAllSlctBtn_Click;
            // 
            // level1SlctBtn
            // 
            level1SlctBtn.BackColor = Color.DodgerBlue;
            level1SlctBtn.Location = new Point(631, 54);
            level1SlctBtn.Name = "level1SlctBtn";
            level1SlctBtn.Size = new Size(60, 29);
            level1SlctBtn.TabIndex = 23;
            level1SlctBtn.Text = "L1";
            level1SlctBtn.UseVisualStyleBackColor = false;
            level1SlctBtn.Click += level1SlctBtn_Click;
            // 
            // level2SlctBtn
            // 
            level2SlctBtn.BackColor = Color.White;
            level2SlctBtn.Location = new Point(697, 54);
            level2SlctBtn.Name = "level2SlctBtn";
            level2SlctBtn.Size = new Size(60, 29);
            level2SlctBtn.TabIndex = 24;
            level2SlctBtn.Text = "L2";
            level2SlctBtn.UseVisualStyleBackColor = false;
            level2SlctBtn.Click += level2SlctBtn_Click;
            // 
            // level3SlctBtn
            // 
            level3SlctBtn.BackColor = Color.White;
            level3SlctBtn.Location = new Point(763, 54);
            level3SlctBtn.Name = "level3SlctBtn";
            level3SlctBtn.Size = new Size(60, 29);
            level3SlctBtn.TabIndex = 25;
            level3SlctBtn.Text = "L3";
            level3SlctBtn.UseVisualStyleBackColor = false;
            level3SlctBtn.Click += level3SlctBtn_Click;
            // 
            // level4SlctBtn
            // 
            level4SlctBtn.BackColor = Color.White;
            level4SlctBtn.Location = new Point(829, 54);
            level4SlctBtn.Name = "level4SlctBtn";
            level4SlctBtn.Size = new Size(60, 29);
            level4SlctBtn.TabIndex = 26;
            level4SlctBtn.Text = "L4";
            level4SlctBtn.UseVisualStyleBackColor = false;
            level4SlctBtn.Click += level4SlctBtn_Click;
            // 
            // level5SlctBtn
            // 
            level5SlctBtn.BackColor = Color.White;
            level5SlctBtn.Location = new Point(895, 54);
            level5SlctBtn.Name = "level5SlctBtn";
            level5SlctBtn.Size = new Size(60, 29);
            level5SlctBtn.TabIndex = 27;
            level5SlctBtn.Text = "L5";
            level5SlctBtn.UseVisualStyleBackColor = false;
            level5SlctBtn.Click += level5SlctBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(986, 538);
            Controls.Add(level5SlctBtn);
            Controls.Add(level4SlctBtn);
            Controls.Add(level3SlctBtn);
            Controls.Add(level2SlctBtn);
            Controls.Add(level1SlctBtn);
            Controls.Add(oprtrAllSlctBtn);
            Controls.Add(oprtrDivSlctBtn);
            Controls.Add(oprtrMulSlctBtn);
            Controls.Add(oprtrSubSlctBtn);
            Controls.Add(oprtrAddSlctBtn);
            Controls.Add(panel1);
            Controls.Add(label3);
            Controls.Add(label2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox nameBox;
        private Label label1;
        private Label label2;
        private ListBox scoreboardNameBox;
        private ListBox scoreboardScoreBox;
        private Label label3;
        private Button gameStartBtn;
        private Panel panel1;
        private Button oprtrAddSlctBtn;
        private Button oprtrSubSlctBtn;
        private Button oprtrMulSlctBtn;
        private Button oprtrDivSlctBtn;
        private Button oprtrAllSlctBtn;
        private Button level1SlctBtn;
        private Button level2SlctBtn;
        private Button level3SlctBtn;
        private Button level4SlctBtn;
        private Button level5SlctBtn;
    }
}