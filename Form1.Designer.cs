namespace _9game
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
            menuStrip1 = new MenuStrip();
            menuToolStripMenuItem = new ToolStripMenuItem();
            startANewGameToolStripMenuItem = new ToolStripMenuItem();
            stopTheGameToolStripMenuItem = new ToolStripMenuItem();
            scoreboardToolStripMenuItem = new ToolStripMenuItem();
            quitToolStripMenuItem1 = new ToolStripMenuItem();
            cheatNowToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            showCreditsToolStripMenuItem = new ToolStripMenuItem();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            textBox_Nickname = new TextBox();
            label_Score = new Label();
            tableLayoutPanel3 = new TableLayoutPanel();
            panel10 = new Panel();
            label9 = new Label();
            panel9 = new Panel();
            label8 = new Label();
            panel8 = new Panel();
            label7 = new Label();
            panel7 = new Panel();
            label6 = new Label();
            panel6 = new Panel();
            label5 = new Label();
            panel5 = new Panel();
            label4 = new Label();
            panel4 = new Panel();
            label3 = new Label();
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            label2 = new Label();
            menuStrip1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            panel10.SuspendLayout();
            panel9.SuspendLayout();
            panel8.SuspendLayout();
            panel7.SuspendLayout();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.White;
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuToolStripMenuItem, aboutToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(437, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            menuToolStripMenuItem.BackColor = Color.Transparent;
            menuToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { startANewGameToolStripMenuItem, stopTheGameToolStripMenuItem, scoreboardToolStripMenuItem, quitToolStripMenuItem1, cheatNowToolStripMenuItem });
            menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            menuToolStripMenuItem.Size = new Size(50, 20);
            menuToolStripMenuItem.Text = "Menu";
            // 
            // startANewGameToolStripMenuItem
            // 
            startANewGameToolStripMenuItem.Name = "startANewGameToolStripMenuItem";
            startANewGameToolStripMenuItem.Size = new Size(165, 22);
            startANewGameToolStripMenuItem.Text = "Start a new game";
            startANewGameToolStripMenuItem.Click += startANewGameToolStripMenuItem_Click;
            // 
            // stopTheGameToolStripMenuItem
            // 
            stopTheGameToolStripMenuItem.Name = "stopTheGameToolStripMenuItem";
            stopTheGameToolStripMenuItem.Size = new Size(165, 22);
            stopTheGameToolStripMenuItem.Text = "stop the game";
            stopTheGameToolStripMenuItem.Visible = false;
            stopTheGameToolStripMenuItem.Click += stopTheGameToolStripMenuItem_Click;
            // 
            // scoreboardToolStripMenuItem
            // 
            scoreboardToolStripMenuItem.Name = "scoreboardToolStripMenuItem";
            scoreboardToolStripMenuItem.Size = new Size(165, 22);
            scoreboardToolStripMenuItem.Text = "Scoreboard";
            scoreboardToolStripMenuItem.Click += scoreboardToolStripMenuItem_Click;
            // 
            // quitToolStripMenuItem1
            // 
            quitToolStripMenuItem1.Name = "quitToolStripMenuItem1";
            quitToolStripMenuItem1.Size = new Size(165, 22);
            quitToolStripMenuItem1.Text = "Quit";
            quitToolStripMenuItem1.Click += quitToolStripMenuItem1_Click;
            // 
            // cheatNowToolStripMenuItem
            // 
            cheatNowToolStripMenuItem.Name = "cheatNowToolStripMenuItem";
            cheatNowToolStripMenuItem.Size = new Size(165, 22);
            cheatNowToolStripMenuItem.Text = "cheatNow";
            cheatNowToolStripMenuItem.Visible = false;
            cheatNowToolStripMenuItem.Click += cheatNowToolStripMenuItem_Click;
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { showCreditsToolStripMenuItem });
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(52, 20);
            aboutToolStripMenuItem.Text = "About";
            // 
            // showCreditsToolStripMenuItem
            // 
            showCreditsToolStripMenuItem.Name = "showCreditsToolStripMenuItem";
            showCreditsToolStripMenuItem.Size = new Size(143, 22);
            showCreditsToolStripMenuItem.Text = "Show Credits";
            showCreditsToolStripMenuItem.Click += showCreditsToolStripMenuItem_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 24);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(437, 393);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.AutoSize = true;
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Controls.Add(textBox_Nickname, 0, 0);
            tableLayoutPanel2.Controls.Add(label_Score, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(431, 29);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // textBox_Nickname
            // 
            textBox_Nickname.BorderStyle = BorderStyle.None;
            textBox_Nickname.Dock = DockStyle.Fill;
            textBox_Nickname.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            textBox_Nickname.Location = new Point(3, 3);
            textBox_Nickname.MaxLength = 10;
            textBox_Nickname.Name = "textBox_Nickname";
            textBox_Nickname.PlaceholderText = "Your Name...";
            textBox_Nickname.Size = new Size(209, 22);
            textBox_Nickname.TabIndex = 0;
            textBox_Nickname.TabStop = false;
            textBox_Nickname.TextAlign = HorizontalAlignment.Center;
            // 
            // label_Score
            // 
            label_Score.AutoSize = true;
            label_Score.Dock = DockStyle.Fill;
            label_Score.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label_Score.Location = new Point(218, 0);
            label_Score.Name = "label_Score";
            label_Score.Size = new Size(210, 29);
            label_Score.TabIndex = 1;
            label_Score.Text = "0";
            label_Score.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.BackColor = Color.Black;
            tableLayoutPanel3.ColumnCount = 3;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33334F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33334F));
            tableLayoutPanel3.Controls.Add(panel10, 2, 2);
            tableLayoutPanel3.Controls.Add(panel9, 1, 2);
            tableLayoutPanel3.Controls.Add(panel8, 0, 2);
            tableLayoutPanel3.Controls.Add(panel7, 2, 1);
            tableLayoutPanel3.Controls.Add(panel6, 1, 1);
            tableLayoutPanel3.Controls.Add(panel5, 0, 1);
            tableLayoutPanel3.Controls.Add(panel4, 2, 0);
            tableLayoutPanel3.Controls.Add(panel1, 0, 0);
            tableLayoutPanel3.Controls.Add(panel2, 1, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 38);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 3;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 33.33333F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 33.33334F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 33.33334F));
            tableLayoutPanel3.Size = new Size(431, 352);
            tableLayoutPanel3.TabIndex = 1;
            // 
            // panel10
            // 
            panel10.BackgroundImage = Properties.Resources.Untitled;
            panel10.BackgroundImageLayout = ImageLayout.Stretch;
            panel10.Controls.Add(label9);
            panel10.Dock = DockStyle.Fill;
            panel10.Location = new Point(289, 237);
            panel10.Name = "panel10";
            panel10.Size = new Size(139, 112);
            panel10.TabIndex = 18;
            // 
            // label9
            // 
            label9.BackColor = Color.Transparent;
            label9.Dock = DockStyle.Fill;
            label9.Font = new Font("Microsoft Sans Serif", 48F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.Black;
            label9.Location = new Point(0, 0);
            label9.Name = "label9";
            label9.Size = new Size(139, 112);
            label9.TabIndex = 8;
            label9.Text = "0";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            label9.UseMnemonic = false;
            // 
            // panel9
            // 
            panel9.BackgroundImage = Properties.Resources.Untitled;
            panel9.BackgroundImageLayout = ImageLayout.Stretch;
            panel9.Controls.Add(label8);
            panel9.Dock = DockStyle.Fill;
            panel9.Location = new Point(146, 237);
            panel9.Name = "panel9";
            panel9.Size = new Size(137, 112);
            panel9.TabIndex = 17;
            // 
            // label8
            // 
            label8.BackColor = Color.Transparent;
            label8.Dock = DockStyle.Fill;
            label8.Font = new Font("Microsoft Sans Serif", 48F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.White;
            label8.Location = new Point(0, 0);
            label8.Name = "label8";
            label8.Size = new Size(137, 112);
            label8.TabIndex = 7;
            label8.Text = "8";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            label8.UseMnemonic = false;
            // 
            // panel8
            // 
            panel8.BackgroundImage = Properties.Resources.Untitled;
            panel8.BackgroundImageLayout = ImageLayout.Stretch;
            panel8.Controls.Add(label7);
            panel8.Dock = DockStyle.Fill;
            panel8.Location = new Point(3, 237);
            panel8.Name = "panel8";
            panel8.Size = new Size(137, 112);
            panel8.TabIndex = 16;
            // 
            // label7
            // 
            label7.BackColor = Color.Transparent;
            label7.Dock = DockStyle.Fill;
            label7.Font = new Font("Microsoft Sans Serif", 48F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(0, 0);
            label7.Name = "label7";
            label7.Size = new Size(137, 112);
            label7.TabIndex = 6;
            label7.Text = "7";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            label7.UseMnemonic = false;
            // 
            // panel7
            // 
            panel7.BackgroundImage = Properties.Resources.Untitled;
            panel7.BackgroundImageLayout = ImageLayout.Stretch;
            panel7.Controls.Add(label6);
            panel7.Dock = DockStyle.Fill;
            panel7.Location = new Point(289, 120);
            panel7.Name = "panel7";
            panel7.Size = new Size(139, 111);
            panel7.TabIndex = 15;
            // 
            // label6
            // 
            label6.BackColor = Color.Transparent;
            label6.Dock = DockStyle.Fill;
            label6.Font = new Font("Microsoft Sans Serif", 48F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(0, 0);
            label6.Name = "label6";
            label6.Size = new Size(139, 111);
            label6.TabIndex = 5;
            label6.Text = "6";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            label6.UseMnemonic = false;
            // 
            // panel6
            // 
            panel6.BackgroundImage = Properties.Resources.Untitled;
            panel6.BackgroundImageLayout = ImageLayout.Stretch;
            panel6.Controls.Add(label5);
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(146, 120);
            panel6.Name = "panel6";
            panel6.Size = new Size(137, 111);
            panel6.TabIndex = 14;
            // 
            // label5
            // 
            label5.BackColor = Color.Transparent;
            label5.Dock = DockStyle.Fill;
            label5.Font = new Font("Microsoft Sans Serif", 48F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(0, 0);
            label5.Name = "label5";
            label5.Size = new Size(137, 111);
            label5.TabIndex = 4;
            label5.Text = "5";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            label5.UseMnemonic = false;
            // 
            // panel5
            // 
            panel5.BackgroundImage = Properties.Resources.Untitled;
            panel5.BackgroundImageLayout = ImageLayout.Stretch;
            panel5.Controls.Add(label4);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(3, 120);
            panel5.Name = "panel5";
            panel5.Size = new Size(137, 111);
            panel5.TabIndex = 13;
            // 
            // label4
            // 
            label4.BackColor = Color.Transparent;
            label4.Dock = DockStyle.Fill;
            label4.Font = new Font("Microsoft Sans Serif", 48F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(0, 0);
            label4.Name = "label4";
            label4.Size = new Size(137, 111);
            label4.TabIndex = 3;
            label4.Text = "4";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            label4.UseMnemonic = false;
            // 
            // panel4
            // 
            panel4.BackgroundImage = Properties.Resources.Untitled;
            panel4.BackgroundImageLayout = ImageLayout.Stretch;
            panel4.Controls.Add(label3);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(289, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(139, 111);
            panel4.TabIndex = 12;
            // 
            // label3
            // 
            label3.BackColor = Color.Transparent;
            label3.Dock = DockStyle.Fill;
            label3.Font = new Font("Microsoft Sans Serif", 48F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(0, 0);
            label3.Name = "label3";
            label3.Size = new Size(139, 111);
            label3.TabIndex = 2;
            label3.Text = "3";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            label3.UseMnemonic = false;
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.Untitled;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(137, 111);
            panel1.TabIndex = 9;
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Microsoft Sans Serif", 48F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(137, 111);
            label1.TabIndex = 0;
            label1.Text = "1";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.UseMnemonic = false;
            // 
            // panel2
            // 
            panel2.BackgroundImage = Properties.Resources.Untitled;
            panel2.BackgroundImageLayout = ImageLayout.Stretch;
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(146, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(137, 111);
            panel2.TabIndex = 10;
            // 
            // label2
            // 
            label2.BackColor = Color.Transparent;
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Microsoft Sans Serif", 48F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(137, 111);
            label2.TabIndex = 1;
            label2.Text = "2";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            label2.UseMnemonic = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(437, 417);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(menuStrip1);
            ForeColor = Color.White;
            KeyPreview = true;
            MainMenuStrip = menuStrip1;
            MinimumSize = new Size(400, 400);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Game";
            Load += Form1_Load;
            KeyPress += Form1_KeyPress;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            panel10.ResumeLayout(false);
            panel9.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuToolStripMenuItem;
        private ToolStripMenuItem startANewGameToolStripMenuItem;
        private ToolStripMenuItem quitToolStripMenuItem1;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private TextBox textBox_Nickname;
        private Label label_Score;
        private TableLayoutPanel tableLayoutPanel3;
        private ToolStripMenuItem cheatNowToolStripMenuItem;
        private ToolStripMenuItem scoreboardToolStripMenuItem;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private ToolStripMenuItem stopTheGameToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripMenuItem showCreditsToolStripMenuItem;
        private Panel panel10;
        private Panel panel9;
        private Panel panel8;
        private Panel panel7;
        private Panel panel6;
        private Panel panel5;
        private Panel panel4;
        private Panel panel1;
        private Panel panel2;
    }
}