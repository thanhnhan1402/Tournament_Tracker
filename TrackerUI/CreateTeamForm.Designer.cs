namespace TrackerUI
{
    partial class CreateTeamForm
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
            this.txtTeamName = new System.Windows.Forms.TextBox();
            this.lbTeamName = new System.Windows.Forms.Label();
            this.lbHeader = new System.Windows.Forms.Label();
            this.cboSelectTeamMemberDropDown = new System.Windows.Forms.ComboBox();
            this.lbSelectTeamMember = new System.Windows.Forms.Label();
            this.btnAddMember = new System.Windows.Forms.Button();
            this.gbAddNewMember = new System.Windows.Forms.GroupBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lbFirstName = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lbLastName = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lbEmail = new System.Windows.Forms.Label();
            this.txtCellPhone = new System.Windows.Forms.TextBox();
            this.lbCellPhone = new System.Windows.Forms.Label();
            this.btnCreateMember = new System.Windows.Forms.Button();
            this.lboxTeamMembers = new System.Windows.Forms.ListBox();
            this.btnDeleteSelectedMember = new System.Windows.Forms.Button();
            this.btnCreateTeam = new System.Windows.Forms.Button();
            this.gbAddNewMember.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtTeamName
            // 
            this.txtTeamName.Location = new System.Drawing.Point(40, 134);
            this.txtTeamName.Name = "txtTeamName";
            this.txtTeamName.Size = new System.Drawing.Size(364, 35);
            this.txtTeamName.TabIndex = 13;
            // 
            // lbTeamName
            // 
            this.lbTeamName.AutoSize = true;
            this.lbTeamName.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbTeamName.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lbTeamName.Location = new System.Drawing.Point(33, 80);
            this.lbTeamName.Name = "lbTeamName";
            this.lbTeamName.Size = new System.Drawing.Size(157, 37);
            this.lbTeamName.TabIndex = 12;
            this.lbTeamName.Text = "Team Name";
            // 
            // lbHeader
            // 
            this.lbHeader.AutoSize = true;
            this.lbHeader.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbHeader.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lbHeader.Location = new System.Drawing.Point(33, 20);
            this.lbHeader.Name = "lbHeader";
            this.lbHeader.Size = new System.Drawing.Size(213, 50);
            this.lbHeader.TabIndex = 11;
            this.lbHeader.Text = "Create Team";
            // 
            // cboSelectTeamMemberDropDown
            // 
            this.cboSelectTeamMemberDropDown.FormattingEnabled = true;
            this.cboSelectTeamMemberDropDown.Location = new System.Drawing.Point(40, 238);
            this.cboSelectTeamMemberDropDown.Name = "cboSelectTeamMemberDropDown";
            this.cboSelectTeamMemberDropDown.Size = new System.Drawing.Size(364, 38);
            this.cboSelectTeamMemberDropDown.TabIndex = 16;
            // 
            // lbSelectTeamMember
            // 
            this.lbSelectTeamMember.AutoSize = true;
            this.lbSelectTeamMember.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbSelectTeamMember.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lbSelectTeamMember.Location = new System.Drawing.Point(32, 185);
            this.lbSelectTeamMember.Name = "lbSelectTeamMember";
            this.lbSelectTeamMember.Size = new System.Drawing.Size(263, 37);
            this.lbSelectTeamMember.TabIndex = 15;
            this.lbSelectTeamMember.Text = "Select Team Member";
            // 
            // btnAddMember
            // 
            this.btnAddMember.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnAddMember.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.btnAddMember.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnAddMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddMember.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddMember.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnAddMember.Location = new System.Drawing.Point(125, 292);
            this.btnAddMember.Name = "btnAddMember";
            this.btnAddMember.Size = new System.Drawing.Size(200, 41);
            this.btnAddMember.TabIndex = 17;
            this.btnAddMember.Text = "Add Member";
            this.btnAddMember.UseVisualStyleBackColor = true;
            // 
            // gbAddNewMember
            // 
            this.gbAddNewMember.Controls.Add(this.btnCreateMember);
            this.gbAddNewMember.Controls.Add(this.txtCellPhone);
            this.gbAddNewMember.Controls.Add(this.lbCellPhone);
            this.gbAddNewMember.Controls.Add(this.txtEmail);
            this.gbAddNewMember.Controls.Add(this.lbEmail);
            this.gbAddNewMember.Controls.Add(this.txtLastName);
            this.gbAddNewMember.Controls.Add(this.lbLastName);
            this.gbAddNewMember.Controls.Add(this.txtFirstName);
            this.gbAddNewMember.Controls.Add(this.lbFirstName);
            this.gbAddNewMember.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.gbAddNewMember.Location = new System.Drawing.Point(40, 352);
            this.gbAddNewMember.Name = "gbAddNewMember";
            this.gbAddNewMember.Size = new System.Drawing.Size(364, 327);
            this.gbAddNewMember.TabIndex = 18;
            this.gbAddNewMember.TabStop = false;
            this.gbAddNewMember.Text = "Add New Member";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(168, 53);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(178, 35);
            this.txtFirstName.TabIndex = 20;
            // 
            // lbFirstName
            // 
            this.lbFirstName.AutoSize = true;
            this.lbFirstName.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbFirstName.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lbFirstName.Location = new System.Drawing.Point(6, 50);
            this.lbFirstName.Name = "lbFirstName";
            this.lbFirstName.Size = new System.Drawing.Size(144, 37);
            this.lbFirstName.TabIndex = 19;
            this.lbFirstName.Text = "First Name";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(168, 106);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(178, 35);
            this.txtLastName.TabIndex = 22;
            // 
            // lbLastName
            // 
            this.lbLastName.AutoSize = true;
            this.lbLastName.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbLastName.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lbLastName.Location = new System.Drawing.Point(6, 103);
            this.lbLastName.Name = "lbLastName";
            this.lbLastName.Size = new System.Drawing.Size(142, 37);
            this.lbLastName.TabIndex = 21;
            this.lbLastName.Text = "Last Name";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(168, 160);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(178, 35);
            this.txtEmail.TabIndex = 24;
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbEmail.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lbEmail.Location = new System.Drawing.Point(6, 157);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(82, 37);
            this.lbEmail.TabIndex = 23;
            this.lbEmail.Text = "Email";
            // 
            // txtCellPhone
            // 
            this.txtCellPhone.Location = new System.Drawing.Point(168, 213);
            this.txtCellPhone.Name = "txtCellPhone";
            this.txtCellPhone.Size = new System.Drawing.Size(178, 35);
            this.txtCellPhone.TabIndex = 26;
            // 
            // lbCellPhone
            // 
            this.lbCellPhone.AutoSize = true;
            this.lbCellPhone.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbCellPhone.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lbCellPhone.Location = new System.Drawing.Point(6, 210);
            this.lbCellPhone.Name = "lbCellPhone";
            this.lbCellPhone.Size = new System.Drawing.Size(138, 37);
            this.lbCellPhone.TabIndex = 25;
            this.lbCellPhone.Text = "Cellphone";
            // 
            // btnCreateMember
            // 
            this.btnCreateMember.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnCreateMember.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.btnCreateMember.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnCreateMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateMember.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCreateMember.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnCreateMember.Location = new System.Drawing.Point(85, 265);
            this.btnCreateMember.Name = "btnCreateMember";
            this.btnCreateMember.Size = new System.Drawing.Size(200, 45);
            this.btnCreateMember.TabIndex = 19;
            this.btnCreateMember.Text = "Create Member";
            this.btnCreateMember.UseVisualStyleBackColor = true;
            // 
            // lboxTeamMembers
            // 
            this.lboxTeamMembers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lboxTeamMembers.FormattingEnabled = true;
            this.lboxTeamMembers.ItemHeight = 30;
            this.lboxTeamMembers.Location = new System.Drawing.Point(436, 135);
            this.lboxTeamMembers.Name = "lboxTeamMembers";
            this.lboxTeamMembers.Size = new System.Drawing.Size(312, 542);
            this.lboxTeamMembers.TabIndex = 19;
            // 
            // btnDeleteSelectedMember
            // 
            this.btnDeleteSelectedMember.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnDeleteSelectedMember.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.btnDeleteSelectedMember.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnDeleteSelectedMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteSelectedMember.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDeleteSelectedMember.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnDeleteSelectedMember.Location = new System.Drawing.Point(771, 326);
            this.btnDeleteSelectedMember.Name = "btnDeleteSelectedMember";
            this.btnDeleteSelectedMember.Size = new System.Drawing.Size(106, 71);
            this.btnDeleteSelectedMember.TabIndex = 21;
            this.btnDeleteSelectedMember.Text = "Delete Selected";
            this.btnDeleteSelectedMember.UseVisualStyleBackColor = true;
            // 
            // btnCreateTeam
            // 
            this.btnCreateTeam.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnCreateTeam.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.btnCreateTeam.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnCreateTeam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateTeam.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCreateTeam.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnCreateTeam.Location = new System.Drawing.Point(326, 705);
            this.btnCreateTeam.Name = "btnCreateTeam";
            this.btnCreateTeam.Size = new System.Drawing.Size(218, 54);
            this.btnCreateTeam.TabIndex = 25;
            this.btnCreateTeam.Text = "Create Team";
            this.btnCreateTeam.UseVisualStyleBackColor = true;
            // 
            // CreateTeamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(899, 771);
            this.Controls.Add(this.btnCreateTeam);
            this.Controls.Add(this.btnDeleteSelectedMember);
            this.Controls.Add(this.lboxTeamMembers);
            this.Controls.Add(this.gbAddNewMember);
            this.Controls.Add(this.btnAddMember);
            this.Controls.Add(this.cboSelectTeamMemberDropDown);
            this.Controls.Add(this.lbSelectTeamMember);
            this.Controls.Add(this.txtTeamName);
            this.Controls.Add(this.lbTeamName);
            this.Controls.Add(this.lbHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "CreateTeamForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create Team";
            this.gbAddNewMember.ResumeLayout(false);
            this.gbAddNewMember.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtTeamName;
        private Label lbTeamName;
        private Label lbHeader;
        private ComboBox cboSelectTeamMemberDropDown;
        private Label lbSelectTeamMember;
        private Button btnAddMember;
        private GroupBox gbAddNewMember;
        private Button btnCreateMember;
        private TextBox txtCellPhone;
        private Label lbCellPhone;
        private TextBox txtEmail;
        private Label lbEmail;
        private TextBox txtLastName;
        private Label lbLastName;
        private TextBox txtFirstName;
        private Label lbFirstName;
        private ListBox lboxTeamMembers;
        private Button btnDeleteSelectedMember;
        private Button btnCreateTeam;
    }
}