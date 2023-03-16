namespace Exams
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
            label1 = new Label();
            genreBox = new ListBox();
            GenerateSongs = new Button();
            idGenre = new ListBox();
            idSong = new ListBox();
            songBox = new ListBox();
            RefreshSongs = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            titleInput = new TextBox();
            artistInput = new TextBox();
            comboBoxInput = new ComboBox();
            label6 = new Label();
            secondInput = new NumericUpDown();
            label7 = new Label();
            trueValueBox = new CheckBox();
            falseValueBox = new CheckBox();
            groupBox1 = new GroupBox();
            AddSong = new Button();
            minuteInput = new NumericUpDown();
            label8 = new Label();
            label9 = new Label();
            releaseDateInput = new MonthCalendar();
            label10 = new Label();
            ((System.ComponentModel.ISupportInitialize)secondInput).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)minuteInput).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(27, 9);
            label1.Name = "label1";
            label1.Size = new Size(121, 32);
            label1.TabIndex = 0;
            label1.Text = "List Songs";
            // 
            // genreBox
            // 
            genreBox.FormattingEnabled = true;
            genreBox.ItemHeight = 15;
            genreBox.Location = new Point(333, 54);
            genreBox.Name = "genreBox";
            genreBox.Size = new Size(129, 94);
            genreBox.TabIndex = 1;
            // 
            // GenerateSongs
            // 
            GenerateSongs.Location = new Point(282, 154);
            GenerateSongs.Name = "GenerateSongs";
            GenerateSongs.Size = new Size(180, 69);
            GenerateSongs.TabIndex = 2;
            GenerateSongs.Text = "Generate Songs";
            GenerateSongs.UseVisualStyleBackColor = true;
            GenerateSongs.Click += GenerateButton_Click;
            // 
            // idGenre
            // 
            idGenre.FormattingEnabled = true;
            idGenre.ItemHeight = 15;
            idGenre.Location = new Point(282, 54);
            idGenre.Name = "idGenre";
            idGenre.Size = new Size(54, 94);
            idGenre.TabIndex = 3;
            // 
            // idSong
            // 
            idSong.FormattingEnabled = true;
            idSong.ItemHeight = 15;
            idSong.Location = new Point(27, 54);
            idSong.Name = "idSong";
            idSong.Size = new Size(63, 169);
            idSong.TabIndex = 4;
            // 
            // songBox
            // 
            songBox.FormattingEnabled = true;
            songBox.ItemHeight = 15;
            songBox.Location = new Point(87, 54);
            songBox.Name = "songBox";
            songBox.Size = new Size(189, 169);
            songBox.TabIndex = 5;
            // 
            // RefreshSongs
            // 
            RefreshSongs.Location = new Point(27, 233);
            RefreshSongs.Name = "RefreshSongs";
            RefreshSongs.Size = new Size(435, 41);
            RefreshSongs.TabIndex = 6;
            RefreshSongs.Text = "Refresh Songs";
            RefreshSongs.UseVisualStyleBackColor = true;
            RefreshSongs.Click += RefreshSongs_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(24, 277);
            label2.Name = "label2";
            label2.Size = new Size(124, 32);
            label2.TabIndex = 7;
            label2.Text = "New Song";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(52, 320);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 8;
            label3.Text = "Title : ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(236, 320);
            label4.Name = "label4";
            label4.Size = new Size(41, 15);
            label4.TabIndex = 9;
            label4.Text = "Artist :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(46, 349);
            label5.Name = "label5";
            label5.Size = new Size(44, 15);
            label5.TabIndex = 10;
            label5.Text = "Genre :";
            // 
            // titleInput
            // 
            titleInput.Location = new Point(96, 317);
            titleInput.Name = "titleInput";
            titleInput.Size = new Size(134, 23);
            titleInput.TabIndex = 11;
            // 
            // artistInput
            // 
            artistInput.Location = new Point(283, 317);
            artistInput.Name = "artistInput";
            artistInput.Size = new Size(179, 23);
            artistInput.TabIndex = 12;
            // 
            // comboBoxInput
            // 
            comboBoxInput.FormattingEnabled = true;
            comboBoxInput.Location = new Point(96, 346);
            comboBoxInput.Name = "comboBoxInput";
            comboBoxInput.Size = new Size(202, 23);
            comboBoxInput.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(40, 382);
            label6.Name = "label6";
            label6.Size = new Size(50, 15);
            label6.TabIndex = 14;
            label6.Text = "Length :";
            // 
            // secondInput
            // 
            secondInput.Location = new Point(212, 380);
            secondInput.Maximum = new decimal(new int[] { 59, 0, 0, 0 });
            secondInput.Name = "secondInput";
            secondInput.Size = new Size(39, 23);
            secondInput.TabIndex = 15;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(24, 414);
            label7.Name = "label7";
            label7.Size = new Size(72, 15);
            label7.TabIndex = 16;
            label7.Text = "isAvailable : ";
            // 
            // trueValueBox
            // 
            trueValueBox.AutoSize = true;
            trueValueBox.Location = new Point(9, 13);
            trueValueBox.Name = "trueValueBox";
            trueValueBox.Size = new Size(43, 19);
            trueValueBox.TabIndex = 17;
            trueValueBox.Text = "Yes";
            trueValueBox.UseVisualStyleBackColor = true;
            // 
            // falseValueBox
            // 
            falseValueBox.AutoSize = true;
            falseValueBox.Location = new Point(67, 13);
            falseValueBox.Name = "falseValueBox";
            falseValueBox.Size = new Size(42, 19);
            falseValueBox.TabIndex = 18;
            falseValueBox.Text = "No";
            falseValueBox.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(trueValueBox);
            groupBox1.Controls.Add(falseValueBox);
            groupBox1.Location = new Point(96, 400);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(134, 35);
            groupBox1.TabIndex = 19;
            groupBox1.TabStop = false;
            // 
            // AddSong
            // 
            AddSong.Location = new Point(354, 414);
            AddSong.Name = "AddSong";
            AddSong.Size = new Size(108, 40);
            AddSong.TabIndex = 20;
            AddSong.Text = "Add Song";
            AddSong.UseVisualStyleBackColor = true;
            AddSong.Click += AddSong_Click;
            // 
            // minuteInput
            // 
            minuteInput.Location = new Point(96, 380);
            minuteInput.Maximum = new decimal(new int[] { 250, 0, 0, 0 });
            minuteInput.Name = "minuteInput";
            minuteInput.Size = new Size(44, 23);
            minuteInput.TabIndex = 21;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(146, 382);
            label8.Name = "label8";
            label8.Size = new Size(50, 15);
            label8.TabIndex = 22;
            label8.Text = "minutes";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(260, 382);
            label9.Name = "label9";
            label9.Size = new Size(50, 15);
            label9.TabIndex = 23;
            label9.Text = "seconds";
            // 
            // releaseDateInput
            // 
            releaseDateInput.Location = new Point(96, 444);
            releaseDateInput.MinDate = new DateTime(2023, 1, 1, 0, 0, 0, 0);
            releaseDateInput.Name = "releaseDateInput";
            releaseDateInput.SelectionRange = new SelectionRange(new DateTime(2023, 3, 17, 0, 0, 0, 0), new DateTime(2023, 3, 23, 0, 0, 0, 0));
            releaseDateInput.TabIndex = 24;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(12, 444);
            label10.Name = "label10";
            label10.Size = new Size(79, 15);
            label10.TabIndex = 25;
            label10.Text = "Release Date :";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1072, 607);
            Controls.Add(label10);
            Controls.Add(releaseDateInput);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(minuteInput);
            Controls.Add(AddSong);
            Controls.Add(groupBox1);
            Controls.Add(label7);
            Controls.Add(secondInput);
            Controls.Add(label6);
            Controls.Add(comboBoxInput);
            Controls.Add(artistInput);
            Controls.Add(titleInput);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(RefreshSongs);
            Controls.Add(songBox);
            Controls.Add(idSong);
            Controls.Add(idGenre);
            Controls.Add(GenerateSongs);
            Controls.Add(genreBox);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)secondInput).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)minuteInput).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox genreBox;
        private Button GenerateSongs;
        private ListBox idGenre;
        private ListBox idSong;
        private ListBox songBox;
        private Button RefreshSongs;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox titleInput;
        private TextBox artistInput;
        private ComboBox comboBoxInput;
        private Label label6;
        private NumericUpDown secondInput;
        private Label label7;
        private CheckBox trueValueBox;
        private CheckBox falseValueBox;
        private GroupBox groupBox1;
        private Button AddSong;
        private NumericUpDown minuteInput;
        private Label label8;
        private Label label9;
        private MonthCalendar releaseDateInput;
        private Label label10;
    }
}