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
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            L1Btn = new TextBox();
            L2Btn = new TextBox();
            L3Btn = new TextBox();
            L5Btn = new TextBox();
            L4Btn = new TextBox();
            textBox2 = new TextBox();
            gameStartBtn = new Button();
            panel1 = new Panel();
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
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            textBox3.Location = new Point(631, 199);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(118, 52);
            textBox3.TabIndex = 7;
            textBox3.Text = "+";
            textBox3.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            textBox4.Location = new Point(817, 272);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(118, 52);
            textBox4.TabIndex = 8;
            textBox4.Text = "/";
            textBox4.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox5
            // 
            textBox5.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            textBox5.Location = new Point(631, 272);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(118, 52);
            textBox5.TabIndex = 9;
            textBox5.Text = "*";
            textBox5.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox6
            // 
            textBox6.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            textBox6.Location = new Point(721, 349);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(125, 52);
            textBox6.TabIndex = 10;
            textBox6.Text = "ALL";
            textBox6.TextAlign = HorizontalAlignment.Center;
            // 
            // L1Btn
            // 
            L1Btn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            L1Btn.Location = new Point(631, 54);
            L1Btn.Name = "L1Btn";
            L1Btn.Size = new Size(56, 34);
            L1Btn.TabIndex = 11;
            L1Btn.Text = "L1";
            L1Btn.TextAlign = HorizontalAlignment.Center;
            L1Btn.TextChanged += L1Btn_TextChanged;
            // 
            // L2Btn
            // 
            L2Btn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            L2Btn.Location = new Point(693, 54);
            L2Btn.Name = "L2Btn";
            L2Btn.Size = new Size(56, 34);
            L2Btn.TabIndex = 12;
            L2Btn.Text = "L2";
            L2Btn.TextAlign = HorizontalAlignment.Center;
            // 
            // L3Btn
            // 
            L3Btn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            L3Btn.Location = new Point(755, 54);
            L3Btn.Name = "L3Btn";
            L3Btn.Size = new Size(56, 34);
            L3Btn.TabIndex = 13;
            L3Btn.Text = "L3";
            L3Btn.TextAlign = HorizontalAlignment.Center;
            // 
            // L5Btn
            // 
            L5Btn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            L5Btn.Location = new Point(879, 54);
            L5Btn.Name = "L5Btn";
            L5Btn.Size = new Size(56, 34);
            L5Btn.TabIndex = 14;
            L5Btn.Text = "L5";
            L5Btn.TextAlign = HorizontalAlignment.Center;
            // 
            // L4Btn
            // 
            L4Btn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            L4Btn.Location = new Point(817, 54);
            L4Btn.Name = "L4Btn";
            L4Btn.Size = new Size(56, 34);
            L4Btn.TabIndex = 15;
            L4Btn.Text = "L4";
            L4Btn.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(817, 199);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(118, 52);
            textBox2.TabIndex = 6;
            textBox2.Text = "-";
            textBox2.TextAlign = HorizontalAlignment.Center;
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(986, 538);
            Controls.Add(panel1);
            Controls.Add(L4Btn);
            Controls.Add(L5Btn);
            Controls.Add(L3Btn);
            Controls.Add(L2Btn);
            Controls.Add(L1Btn);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(label2);
            Name = "Form1";
            Text = "Form1";
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
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox L1Btn;
        private TextBox L2Btn;
        private TextBox L3Btn;
        private TextBox L5Btn;
        private TextBox L4Btn;
        private TextBox textBox2;
        private Button gameStartBtn;
        private Panel panel1;
    }
}