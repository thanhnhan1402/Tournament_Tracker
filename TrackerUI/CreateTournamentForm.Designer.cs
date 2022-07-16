namespace TrackerUI
{
    partial class CreateTournamentForm
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
            this.lbHeader = new System.Windows.Forms.Label();
            this.txtTournamentName = new System.Windows.Forms.TextBox();
            this.lbTournamentName = new System.Windows.Forms.Label();
            this.txtEntryFee = new System.Windows.Forms.TextBox();
            this.lbEntryFee = new System.Windows.Forms.Label();
            this.cboSelectTeamDropDown = new System.Windows.Forms.ComboBox();
            this.lbSelectTeam = new System.Windows.Forms.Label();
            this.linkCreateNewTeam = new System.Windows.Forms.LinkLabel();
            this.btnAddTeam = new System.Windows.Forms.Button();
            this.btnCreatePrize = new System.Windows.Forms.Button();
            this.lboxTournamentPlayers = new System.Windows.Forms.ListBox();
            this.lbTournamentPlayers = new System.Windows.Forms.Label();
            this.btnDeleteSelectedPlayer = new System.Windows.Forms.Button();
            this.btnDeleteSelectedPrize = new System.Windows.Forms.Button();
            this.lbPrizes = new System.Windows.Forms.Label();
            this.lboxPrizes = new System.Windows.Forms.ListBox();
            this.btnCreateTournament = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbHeader
            // 
            this.lbHeader.AutoSize = true;
            this.lbHeader.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbHeader.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lbHeader.Location = new System.Drawing.Point(12, 29);
            this.lbHeader.Name = "lbHeader";
            this.lbHeader.Size = new System.Drawing.Size(317, 50);
            this.lbHeader.TabIndex = 1;
            this.lbHeader.Text = "Create Tournament";
            // 
            // txtTournamentName
            // 
            this.txtTournamentName.Location = new System.Drawing.Point(33, 151);
            this.txtTournamentName.Name = "txtTournamentName";
            this.txtTournamentName.Size = new System.Drawing.Size(296, 35);
            this.txtTournamentName.TabIndex = 10;
            // 
            // lbTournamentName
            // 
            this.lbTournamentName.AutoSize = true;
            this.lbTournamentName.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbTournamentName.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lbTournamentName.Location = new System.Drawing.Point(33, 97);
            this.lbTournamentName.Name = "lbTournamentName";
            this.lbTournamentName.Size = new System.Drawing.Size(236, 37);
            this.lbTournamentName.TabIndex = 9;
            this.lbTournamentName.Text = "Tournament Name";
            // 
            // txtEntryFee
            // 
            this.txtEntryFee.Location = new System.Drawing.Point(160, 201);
            this.txtEntryFee.Name = "txtEntryFee";
            this.txtEntryFee.Size = new System.Drawing.Size(109, 35);
            this.txtEntryFee.TabIndex = 12;
            this.txtEntryFee.Text = "0";
            // 
            // lbEntryFee
            // 
            this.lbEntryFee.AutoSize = true;
            this.lbEntryFee.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbEntryFee.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lbEntryFee.Location = new System.Drawing.Point(25, 198);
            this.lbEntryFee.Name = "lbEntryFee";
            this.lbEntryFee.Size = new System.Drawing.Size(125, 37);
            this.lbEntryFee.TabIndex = 11;
            this.lbEntryFee.Text = "Entry Fee";
            // 
            // cboSelectTeamDropDown
            // 
            this.cboSelectTeamDropDown.FormattingEnabled = true;
            this.cboSelectTeamDropDown.Location = new System.Drawing.Point(33, 308);
            this.cboSelectTeamDropDown.Name = "cboSelectTeamDropDown";
            this.cboSelectTeamDropDown.Size = new System.Drawing.Size(296, 38);
            this.cboSelectTeamDropDown.TabIndex = 14;
            // 
            // lbSelectTeam
            // 
            this.lbSelectTeam.AutoSize = true;
            this.lbSelectTeam.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbSelectTeam.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lbSelectTeam.Location = new System.Drawing.Point(25, 268);
            this.lbSelectTeam.Name = "lbSelectTeam";
            this.lbSelectTeam.Size = new System.Drawing.Size(156, 37);
            this.lbSelectTeam.TabIndex = 13;
            this.lbSelectTeam.Text = "Select Team";
            // 
            // linkCreateNewTeam
            // 
            this.linkCreateNewTeam.AutoSize = true;
            this.linkCreateNewTeam.Location = new System.Drawing.Point(215, 274);
            this.linkCreateNewTeam.Name = "linkCreateNewTeam";
            this.linkCreateNewTeam.Size = new System.Drawing.Size(114, 30);
            this.linkCreateNewTeam.TabIndex = 15;
            this.linkCreateNewTeam.TabStop = true;
            this.linkCreateNewTeam.Text = "create new";
            // 
            // btnAddTeam
            // 
            this.btnAddTeam.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnAddTeam.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.btnAddTeam.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnAddTeam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddTeam.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddTeam.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnAddTeam.Location = new System.Drawing.Point(106, 366);
            this.btnAddTeam.Name = "btnAddTeam";
            this.btnAddTeam.Size = new System.Drawing.Size(149, 42);
            this.btnAddTeam.TabIndex = 16;
            this.btnAddTeam.Text = "Add Team";
            this.btnAddTeam.UseVisualStyleBackColor = true;
            // 
            // btnCreatePrize
            // 
            this.btnCreatePrize.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnCreatePrize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.btnCreatePrize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnCreatePrize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreatePrize.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCreatePrize.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnCreatePrize.Location = new System.Drawing.Point(106, 429);
            this.btnCreatePrize.Name = "btnCreatePrize";
            this.btnCreatePrize.Size = new System.Drawing.Size(149, 42);
            this.btnCreatePrize.TabIndex = 17;
            this.btnCreatePrize.Text = "Create Prize";
            this.btnCreatePrize.UseVisualStyleBackColor = true;
            // 
            // lboxTournamentPlayers
            // 
            this.lboxTournamentPlayers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lboxTournamentPlayers.FormattingEnabled = true;
            this.lboxTournamentPlayers.ItemHeight = 30;
            this.lboxTournamentPlayers.Location = new System.Drawing.Point(407, 137);
            this.lboxTournamentPlayers.Name = "lboxTournamentPlayers";
            this.lboxTournamentPlayers.Size = new System.Drawing.Size(312, 152);
            this.lboxTournamentPlayers.TabIndex = 18;
            // 
            // lbTournamentPlayers
            // 
            this.lbTournamentPlayers.AutoSize = true;
            this.lbTournamentPlayers.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbTournamentPlayers.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lbTournamentPlayers.Location = new System.Drawing.Point(398, 97);
            this.lbTournamentPlayers.Name = "lbTournamentPlayers";
            this.lbTournamentPlayers.Size = new System.Drawing.Size(198, 37);
            this.lbTournamentPlayers.TabIndex = 19;
            this.lbTournamentPlayers.Text = "Teams / Players";
            // 
            // btnDeleteSelectedPlayer
            // 
            this.btnDeleteSelectedPlayer.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnDeleteSelectedPlayer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.btnDeleteSelectedPlayer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnDeleteSelectedPlayer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteSelectedPlayer.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDeleteSelectedPlayer.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnDeleteSelectedPlayer.Location = new System.Drawing.Point(768, 193);
            this.btnDeleteSelectedPlayer.Name = "btnDeleteSelectedPlayer";
            this.btnDeleteSelectedPlayer.Size = new System.Drawing.Size(106, 71);
            this.btnDeleteSelectedPlayer.TabIndex = 20;
            this.btnDeleteSelectedPlayer.Text = "Delete Selected";
            this.btnDeleteSelectedPlayer.UseVisualStyleBackColor = true;
            // 
            // btnDeleteSelectedPrize
            // 
            this.btnDeleteSelectedPrize.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnDeleteSelectedPrize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.btnDeleteSelectedPrize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnDeleteSelectedPrize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteSelectedPrize.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDeleteSelectedPrize.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnDeleteSelectedPrize.Location = new System.Drawing.Point(768, 400);
            this.btnDeleteSelectedPrize.Name = "btnDeleteSelectedPrize";
            this.btnDeleteSelectedPrize.Size = new System.Drawing.Size(106, 71);
            this.btnDeleteSelectedPrize.TabIndex = 23;
            this.btnDeleteSelectedPrize.Text = "Delete Selected";
            this.btnDeleteSelectedPrize.UseVisualStyleBackColor = true;
            // 
            // lbPrizes
            // 
            this.lbPrizes.AutoSize = true;
            this.lbPrizes.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbPrizes.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lbPrizes.Location = new System.Drawing.Point(398, 309);
            this.lbPrizes.Name = "lbPrizes";
            this.lbPrizes.Size = new System.Drawing.Size(198, 37);
            this.lbPrizes.TabIndex = 22;
            this.lbPrizes.Text = "Teams / Players";
            // 
            // lboxPrizes
            // 
            this.lboxPrizes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lboxPrizes.FormattingEnabled = true;
            this.lboxPrizes.ItemHeight = 30;
            this.lboxPrizes.Location = new System.Drawing.Point(407, 352);
            this.lboxPrizes.Name = "lboxPrizes";
            this.lboxPrizes.Size = new System.Drawing.Size(312, 152);
            this.lboxPrizes.TabIndex = 21;
            // 
            // btnCreateTournament
            // 
            this.btnCreateTournament.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnCreateTournament.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.btnCreateTournament.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnCreateTournament.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateTournament.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCreateTournament.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnCreateTournament.Location = new System.Drawing.Point(329, 529);
            this.btnCreateTournament.Name = "btnCreateTournament";
            this.btnCreateTournament.Size = new System.Drawing.Size(218, 54);
            this.btnCreateTournament.TabIndex = 24;
            this.btnCreateTournament.Text = "Create Tournament";
            this.btnCreateTournament.UseVisualStyleBackColor = true;
            // 
            // CreateTournamentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(908, 599);
            this.Controls.Add(this.btnCreateTournament);
            this.Controls.Add(this.btnDeleteSelectedPrize);
            this.Controls.Add(this.lbPrizes);
            this.Controls.Add(this.lboxPrizes);
            this.Controls.Add(this.btnDeleteSelectedPlayer);
            this.Controls.Add(this.lbTournamentPlayers);
            this.Controls.Add(this.lboxTournamentPlayers);
            this.Controls.Add(this.btnCreatePrize);
            this.Controls.Add(this.btnAddTeam);
            this.Controls.Add(this.linkCreateNewTeam);
            this.Controls.Add(this.cboSelectTeamDropDown);
            this.Controls.Add(this.lbSelectTeam);
            this.Controls.Add(this.txtEntryFee);
            this.Controls.Add(this.lbEntryFee);
            this.Controls.Add(this.txtTournamentName);
            this.Controls.Add(this.lbTournamentName);
            this.Controls.Add(this.lbHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "CreateTournamentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create Tournament";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbHeader;
        private TextBox txtTournamentName;
        private Label lbTournamentName;
        private TextBox txtEntryFee;
        private Label lbEntryFee;
        private ComboBox cboSelectTeamDropDown;
        private Label lbSelectTeam;
        private LinkLabel linkCreateNewTeam;
        private Button btnAddTeam;
        private Button btnCreatePrize;
        private ListBox lboxTournamentPlayers;
        private Label lbTournamentPlayers;
        private Button btnDeleteSelectedPlayer;
        private Button btnDeleteSelectedPrize;
        private Label lbPrizes;
        private ListBox lboxPrizes;
        private Button btnCreateTournament;
    }
}