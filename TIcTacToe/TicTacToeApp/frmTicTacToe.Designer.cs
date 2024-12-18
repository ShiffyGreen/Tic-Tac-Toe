namespace TIcTacToe
{
    partial class frmTicTacToe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTicTacToe));
            tblMain = new TableLayoutPanel();
            ctlTicTacToesg = new TicTacToeSG();
            tblMain.SuspendLayout();
            SuspendLayout();
            // 
            // tblMain
            // 
            tblMain.ColumnCount = 1;
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tblMain.Controls.Add(ctlTicTacToesg, 0, 0);
            tblMain.Dock = DockStyle.Fill;
            tblMain.Location = new Point(0, 0);
            tblMain.Name = "tblMain";
            tblMain.RowCount = 1;
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblMain.Size = new Size(613, 562);
            tblMain.TabIndex = 0;
            // 
            // ctlTicTacToesg
            // 
            ctlTicTacToesg.Dock = DockStyle.Fill;
            ctlTicTacToesg.Location = new Point(3, 3);
            ctlTicTacToesg.Name = "ctlTicTacToesg";
            ctlTicTacToesg.Size = new Size(607, 556);
            ctlTicTacToesg.TabIndex = 1;
            // 
            // frmTicTacToe
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(613, 562);
            Controls.Add(tblMain);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmTicTacToe";
            Text = "Tic Tac Toe";
            tblMain.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tblMain;
        private TicTacToeSG ctlTicTacToesg;
    }
}