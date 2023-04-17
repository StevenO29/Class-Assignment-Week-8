namespace Class_Assignment_Week_8
{
    partial class mainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.teamDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.findMatchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cBoxTeamName = new System.Windows.Forms.ComboBox();
            this.btnSearchTeam = new System.Windows.Forms.Button();
            this.dgvManager = new System.Windows.Forms.DataGridView();
            this.dgvPlayer = new System.Windows.Forms.DataGridView();
            this.dgvMatch = new System.Windows.Forms.DataGridView();
            this.btnSearchMatch = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatch)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.teamDataToolStripMenuItem,
            this.findMatchToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(931, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // teamDataToolStripMenuItem
            // 
            this.teamDataToolStripMenuItem.Name = "teamDataToolStripMenuItem";
            this.teamDataToolStripMenuItem.Size = new System.Drawing.Size(111, 29);
            this.teamDataToolStripMenuItem.Text = "Team Data";
            this.teamDataToolStripMenuItem.Click += new System.EventHandler(this.teamDataToolStripMenuItem_Click);
            // 
            // findMatchToolStripMenuItem
            // 
            this.findMatchToolStripMenuItem.Name = "findMatchToolStripMenuItem";
            this.findMatchToolStripMenuItem.Size = new System.Drawing.Size(116, 29);
            this.findMatchToolStripMenuItem.Text = "Find Match";
            this.findMatchToolStripMenuItem.Click += new System.EventHandler(this.findMatchToolStripMenuItem_Click);
            // 
            // cBoxTeamName
            // 
            this.cBoxTeamName.FormattingEnabled = true;
            this.cBoxTeamName.Location = new System.Drawing.Point(13, 58);
            this.cBoxTeamName.Name = "cBoxTeamName";
            this.cBoxTeamName.Size = new System.Drawing.Size(210, 28);
            this.cBoxTeamName.TabIndex = 1;
            this.cBoxTeamName.Visible = false;
            // 
            // btnSearchTeam
            // 
            this.btnSearchTeam.Location = new System.Drawing.Point(245, 54);
            this.btnSearchTeam.Name = "btnSearchTeam";
            this.btnSearchTeam.Size = new System.Drawing.Size(97, 38);
            this.btnSearchTeam.TabIndex = 2;
            this.btnSearchTeam.Text = "Search";
            this.btnSearchTeam.UseVisualStyleBackColor = true;
            this.btnSearchTeam.Visible = false;
            this.btnSearchTeam.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dgvManager
            // 
            this.dgvManager.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvManager.Location = new System.Drawing.Point(13, 114);
            this.dgvManager.Name = "dgvManager";
            this.dgvManager.RowHeadersWidth = 62;
            this.dgvManager.RowTemplate.Height = 28;
            this.dgvManager.Size = new System.Drawing.Size(906, 162);
            this.dgvManager.TabIndex = 3;
            this.dgvManager.Visible = false;
            // 
            // dgvPlayer
            // 
            this.dgvPlayer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlayer.Location = new System.Drawing.Point(12, 297);
            this.dgvPlayer.Name = "dgvPlayer";
            this.dgvPlayer.RowHeadersWidth = 62;
            this.dgvPlayer.RowTemplate.Height = 28;
            this.dgvPlayer.Size = new System.Drawing.Size(906, 234);
            this.dgvPlayer.TabIndex = 4;
            this.dgvPlayer.Visible = false;
            // 
            // dgvMatch
            // 
            this.dgvMatch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMatch.Location = new System.Drawing.Point(12, 114);
            this.dgvMatch.Name = "dgvMatch";
            this.dgvMatch.RowHeadersWidth = 62;
            this.dgvMatch.RowTemplate.Height = 28;
            this.dgvMatch.Size = new System.Drawing.Size(906, 417);
            this.dgvMatch.TabIndex = 5;
            this.dgvMatch.Visible = false;
            // 
            // btnSearchMatch
            // 
            this.btnSearchMatch.Location = new System.Drawing.Point(245, 54);
            this.btnSearchMatch.Name = "btnSearchMatch";
            this.btnSearchMatch.Size = new System.Drawing.Size(97, 38);
            this.btnSearchMatch.TabIndex = 6;
            this.btnSearchMatch.Text = "Search";
            this.btnSearchMatch.UseVisualStyleBackColor = true;
            this.btnSearchMatch.Visible = false;
            this.btnSearchMatch.Click += new System.EventHandler(this.btnSearchMatch_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 543);
            this.Controls.Add(this.btnSearchMatch);
            this.Controls.Add(this.dgvMatch);
            this.Controls.Add(this.dgvPlayer);
            this.Controls.Add(this.dgvManager);
            this.Controls.Add(this.btnSearchTeam);
            this.Controls.Add(this.cBoxTeamName);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Premier League";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem teamDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem findMatchToolStripMenuItem;
        private System.Windows.Forms.ComboBox cBoxTeamName;
        private System.Windows.Forms.Button btnSearchTeam;
        private System.Windows.Forms.DataGridView dgvManager;
        private System.Windows.Forms.DataGridView dgvPlayer;
        private System.Windows.Forms.DataGridView dgvMatch;
        private System.Windows.Forms.Button btnSearchMatch;
    }
}

