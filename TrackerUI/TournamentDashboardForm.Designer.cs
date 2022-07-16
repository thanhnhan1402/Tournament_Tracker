namespace TrackerUI
{
    partial class TournamentDashboardForm
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
            this.cboLoadExistingTournamentDropDown = new System.Windows.Forms.ComboBox();
            this.lbLoadExistingTournament = new System.Windows.Forms.Label();
            this.btnLoadTournament = new System.Windows.Forms.Button();
            this.btnCreateTournament = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbHeader
            // 
            this.lbHeader.AutoSize = true;
            this.lbHeader.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbHeader.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lbHeader.Location = new System.Drawing.Point(79, 28);
            this.lbHeader.Name = "lbHeader";
            this.lbHeader.Size = new System.Drawing.Size(385, 50);
            this.lbHeader.TabIndex = 13;
            this.lbHeader.Text = "Tournament Dashboard";
            // 
            // cboLoadExistingTournamentDropDown
            // 
            this.cboLoadExistingTournamentDropDown.FormattingEnabled = true;
            this.cboLoadExistingTournamentDropDown.Location = new System.Drawing.Point(123, 137);
            this.cboLoadExistingTournamentDropDown.Name = "cboLoadExistingTournamentDropDown";
            this.cboLoadExistingTournamentDropDown.Size = new System.Drawing.Size(296, 38);
            this.cboLoadExistingTournamentDropDown.TabIndex = 15;
            // 
            // lbLoadExistingTournament
            // 
            this.lbLoadExistingTournament.AutoSize = true;
            this.lbLoadExistingTournament.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbLoadExistingTournament.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lbLoadExistingTournament.Location = new System.Drawing.Point(110, 87);
            this.lbLoadExistingTournament.Name = "lbLoadExistingTournament";
            this.lbLoadExistingTournament.Size = new System.Drawing.Size(322, 37);
            this.lbLoadExistingTournament.TabIndex = 16;
            this.lbLoadExistingTournament.Text = "Load Existing Tournament";
            // 
            // btnLoadTournament
            // 
            this.btnLoadTournament.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnLoadTournament.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.btnLoadTournament.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnLoadTournament.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadTournament.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLoadTournament.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnLoadTournament.Location = new System.Drawing.Point(171, 191);
            this.btnLoadTournament.Name = "btnLoadTournament";
            this.btnLoadTournament.Size = new System.Drawing.Size(196, 46);
            this.btnLoadTournament.TabIndex = 17;
            this.btnLoadTournament.Text = "Load Tournament";
            this.btnLoadTournament.UseVisualStyleBackColor = true;
            // 
            // btnCreateTournament
            // 
            this.btnCreateTournament.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnCreateTournament.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.btnCreateTournament.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnCreateTournament.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateTournament.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCreateTournament.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnCreateTournament.Location = new System.Drawing.Point(162, 256);
            this.btnCreateTournament.Name = "btnCreateTournament";
            this.btnCreateTournament.Size = new System.Drawing.Size(218, 54);
            this.btnCreateTournament.TabIndex = 25;
            this.btnCreateTournament.Text = "Create Tournament";
            this.btnCreateTournament.UseVisualStyleBackColor = true;
            // 
            // TournamentDashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(520, 341);
            this.Controls.Add(this.btnCreateTournament);
            this.Controls.Add(this.btnLoadTournament);
            this.Controls.Add(this.lbLoadExistingTournament);
            this.Controls.Add(this.cboLoadExistingTournamentDropDown);
            this.Controls.Add(this.lbHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "TournamentDashboardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tournament Dashboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbHeader;
        private ComboBox cboLoadExistingTournamentDropDown;
        private Label lbLoadExistingTournament;
        private Button btnLoadTournament;
        private Button btnCreateTournament;
    }
}