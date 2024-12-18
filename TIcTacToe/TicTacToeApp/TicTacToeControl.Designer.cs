namespace TIcTacToe
{
    partial class TicTacToeControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tblmain = new TableLayoutPanel();
            tblToolBar = new TableLayoutPanel();
            btnStart = new Button();
            rdPlayComputer = new RadioButton();
            rdTwoPlayer = new RadioButton();
            lblStatus = new Label();
            tblSpots = new TableLayoutPanel();
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btn4 = new Button();
            btn5 = new Button();
            btn6 = new Button();
            btn7 = new Button();
            btn8 = new Button();
            btn9 = new Button();
            tblmain.SuspendLayout();
            tblToolBar.SuspendLayout();
            tblSpots.SuspendLayout();
            SuspendLayout();
            // 
            // tblmain
            // 
            tblmain.ColumnCount = 1;
            tblmain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblmain.Controls.Add(tblToolBar, 0, 0);
            tblmain.Controls.Add(tblSpots, 0, 1);
            tblmain.Dock = DockStyle.Fill;
            tblmain.Location = new Point(0, 0);
            tblmain.Name = "tblmain";
            tblmain.RowCount = 2;
            tblmain.RowStyles.Add(new RowStyle(SizeType.Percent, 14.581419F));
            tblmain.RowStyles.Add(new RowStyle(SizeType.Percent, 85.41858F));
            tblmain.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tblmain.Size = new Size(731, 561);
            tblmain.TabIndex = 0;
            // 
            // tblToolBar
            // 
            tblToolBar.ColumnCount = 4;
            tblToolBar.ColumnStyles.Add(new ColumnStyle());
            tblToolBar.ColumnStyles.Add(new ColumnStyle());
            tblToolBar.ColumnStyles.Add(new ColumnStyle());
            tblToolBar.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblToolBar.Controls.Add(btnStart, 0, 0);
            tblToolBar.Controls.Add(rdPlayComputer, 2, 0);
            tblToolBar.Controls.Add(rdTwoPlayer, 1, 0);
            tblToolBar.Controls.Add(lblStatus, 0, 1);
            tblToolBar.Location = new Point(3, 3);
            tblToolBar.Name = "tblToolBar";
            tblToolBar.RowCount = 2;
            tblToolBar.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblToolBar.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblToolBar.Size = new Size(725, 69);
            tblToolBar.TabIndex = 0;
            // 
            // btnStart
            // 
            btnStart.AutoSize = true;
            btnStart.Location = new Point(3, 3);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(118, 28);
            btnStart.TabIndex = 0;
            btnStart.Text = "&Start";
            btnStart.UseVisualStyleBackColor = true;
            // 
            // rdPlayComputer
            // 
            rdPlayComputer.AutoSize = true;
            rdPlayComputer.Dock = DockStyle.Fill;
            rdPlayComputer.Location = new Point(215, 3);
            rdPlayComputer.Name = "rdPlayComputer";
            rdPlayComputer.Size = new Size(181, 28);
            rdPlayComputer.TabIndex = 2;
            rdPlayComputer.Text = "Play &Against Computer";
            rdPlayComputer.TextAlign = ContentAlignment.MiddleCenter;
            rdPlayComputer.UseVisualStyleBackColor = true;
            // 
            // rdTwoPlayer
            // 
            rdTwoPlayer.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            rdTwoPlayer.AutoSize = true;
            rdTwoPlayer.Checked = true;
            rdTwoPlayer.Location = new Point(127, 3);
            rdTwoPlayer.Name = "rdTwoPlayer";
            rdTwoPlayer.Size = new Size(82, 28);
            rdTwoPlayer.TabIndex = 1;
            rdTwoPlayer.TabStop = true;
            rdTwoPlayer.Text = "2 &Player";
            rdTwoPlayer.TextAlign = ContentAlignment.MiddleCenter;
            rdTwoPlayer.UseVisualStyleBackColor = true;
            // 
            // lblStatus
            // 
            lblStatus.BackColor = Color.Moccasin;
            lblStatus.BorderStyle = BorderStyle.FixedSingle;
            tblToolBar.SetColumnSpan(lblStatus, 4);
            lblStatus.Dock = DockStyle.Fill;
            lblStatus.Location = new Point(3, 34);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(719, 35);
            lblStatus.TabIndex = 3;
            lblStatus.TextAlign = ContentAlignment.TopCenter;
            // 
            // tblSpots
            // 
            tblSpots.ColumnCount = 3;
            tblSpots.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tblSpots.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tblSpots.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tblSpots.Controls.Add(btn1, 0, 0);
            tblSpots.Controls.Add(btn2, 1, 0);
            tblSpots.Controls.Add(btn3, 2, 0);
            tblSpots.Controls.Add(btn4, 0, 1);
            tblSpots.Controls.Add(btn5, 1, 1);
            tblSpots.Controls.Add(btn6, 2, 1);
            tblSpots.Controls.Add(btn7, 0, 2);
            tblSpots.Controls.Add(btn8, 1, 2);
            tblSpots.Controls.Add(btn9, 2, 2);
            tblSpots.Dock = DockStyle.Fill;
            tblSpots.Location = new Point(3, 84);
            tblSpots.Name = "tblSpots";
            tblSpots.RowCount = 3;
            tblSpots.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tblSpots.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tblSpots.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tblSpots.Size = new Size(725, 474);
            tblSpots.TabIndex = 1;
            // 
            // btn1
            // 
            btn1.Dock = DockStyle.Fill;
            btn1.Location = new Point(3, 3);
            btn1.Name = "btn1";
            btn1.Size = new Size(235, 151);
            btn1.TabIndex = 0;
            btn1.UseVisualStyleBackColor = true;
            // 
            // btn2
            // 
            btn2.Dock = DockStyle.Fill;
            btn2.Location = new Point(244, 3);
            btn2.Name = "btn2";
            btn2.Size = new Size(235, 151);
            btn2.TabIndex = 1;
            btn2.UseVisualStyleBackColor = true;
            // 
            // btn3
            // 
            btn3.Dock = DockStyle.Fill;
            btn3.Location = new Point(485, 3);
            btn3.Name = "btn3";
            btn3.Size = new Size(237, 151);
            btn3.TabIndex = 2;
            btn3.UseVisualStyleBackColor = true;
            // 
            // btn4
            // 
            btn4.Dock = DockStyle.Fill;
            btn4.Location = new Point(3, 160);
            btn4.Name = "btn4";
            btn4.Size = new Size(235, 151);
            btn4.TabIndex = 3;
            btn4.UseVisualStyleBackColor = true;
            // 
            // btn5
            // 
            btn5.Dock = DockStyle.Fill;
            btn5.Location = new Point(244, 160);
            btn5.Name = "btn5";
            btn5.Size = new Size(235, 151);
            btn5.TabIndex = 4;
            btn5.UseVisualStyleBackColor = true;
            // 
            // btn6
            // 
            btn6.Dock = DockStyle.Fill;
            btn6.Location = new Point(485, 160);
            btn6.Name = "btn6";
            btn6.Size = new Size(237, 151);
            btn6.TabIndex = 5;
            btn6.UseVisualStyleBackColor = true;
            // 
            // btn7
            // 
            btn7.Dock = DockStyle.Fill;
            btn7.Location = new Point(3, 317);
            btn7.Name = "btn7";
            btn7.Size = new Size(235, 154);
            btn7.TabIndex = 6;
            btn7.UseVisualStyleBackColor = true;
            // 
            // btn8
            // 
            btn8.Dock = DockStyle.Fill;
            btn8.Location = new Point(244, 317);
            btn8.Name = "btn8";
            btn8.Size = new Size(235, 154);
            btn8.TabIndex = 7;
            btn8.UseVisualStyleBackColor = true;
            // 
            // btn9
            // 
            btn9.Dock = DockStyle.Fill;
            btn9.Location = new Point(485, 317);
            btn9.Name = "btn9";
            btn9.Size = new Size(237, 154);
            btn9.TabIndex = 8;
            btn9.UseVisualStyleBackColor = true;
            // 
            // TicTacToeControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tblmain);
            Name = "TicTacToeControl";
            Size = new Size(731, 561);
            tblmain.ResumeLayout(false);
            tblToolBar.ResumeLayout(false);
            tblToolBar.PerformLayout();
            tblSpots.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        public TableLayoutPanel tblmain;
        public TableLayoutPanel tblToolBar;
        public Button btnStart;
        public RadioButton rdTwoPlayer;
        public RadioButton rdPlayComputer;
        public Label lblStatus;
        public TableLayoutPanel tblSpots;
        public Button btn1;
        public Button btn2;
        public Button btn3;
        public Button btn4;
        public Button btn5;
        public Button btn6;
        public Button btn7;
        public Button btn8;
        public Button btn9;
    }
}
