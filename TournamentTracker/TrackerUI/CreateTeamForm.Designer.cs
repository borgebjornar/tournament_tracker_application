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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateTeamForm));
            this.teamNameValue = new System.Windows.Forms.TextBox();
            this.teamNameLabel = new System.Windows.Forms.Label();
            this.createTeamHeader = new System.Windows.Forms.Label();
            this.addTeamMemberButton = new System.Windows.Forms.Button();
            this.selectTeamMemberDropDown = new System.Windows.Forms.ComboBox();
            this.selectTeamMemberLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.createMemberButton = new System.Windows.Forms.Button();
            this.cellphoneValue = new System.Windows.Forms.TextBox();
            this.cellphoneLabel = new System.Windows.Forms.Label();
            this.emailValue = new System.Windows.Forms.TextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.lastNameValue = new System.Windows.Forms.TextBox();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.firstNameValue = new System.Windows.Forms.TextBox();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.teamMembersListBox = new System.Windows.Forms.ListBox();
            this.removeSelectedMemberButton = new System.Windows.Forms.Button();
            this.createTeamButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // teamNameValue
            // 
            this.teamNameValue.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.teamNameValue.Location = new System.Drawing.Point(24, 136);
            this.teamNameValue.Name = "teamNameValue";
            this.teamNameValue.Size = new System.Drawing.Size(357, 33);
            this.teamNameValue.TabIndex = 13;
            // 
            // teamNameLabel
            // 
            this.teamNameLabel.AutoSize = true;
            this.teamNameLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.teamNameLabel.Location = new System.Drawing.Point(24, 108);
            this.teamNameLabel.Name = "teamNameLabel";
            this.teamNameLabel.Size = new System.Drawing.Size(111, 25);
            this.teamNameLabel.TabIndex = 12;
            this.teamNameLabel.Text = "Team Name";
            // 
            // createTeamHeader
            // 
            this.createTeamHeader.AutoSize = true;
            this.createTeamHeader.Font = new System.Drawing.Font("Segoe UI", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.createTeamHeader.ForeColor = System.Drawing.SystemColors.WindowText;
            this.createTeamHeader.Location = new System.Drawing.Point(24, 26);
            this.createTeamHeader.Name = "createTeamHeader";
            this.createTeamHeader.Size = new System.Drawing.Size(225, 47);
            this.createTeamHeader.TabIndex = 11;
            this.createTeamHeader.Text = "Create Team";
            // 
            // addTeamMemberButton
            // 
            this.addTeamMemberButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.addTeamMemberButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.addTeamMemberButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.addTeamMemberButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addTeamMemberButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addTeamMemberButton.Location = new System.Drawing.Point(104, 273);
            this.addTeamMemberButton.Name = "addTeamMemberButton";
            this.addTeamMemberButton.Size = new System.Drawing.Size(199, 54);
            this.addTeamMemberButton.TabIndex = 20;
            this.addTeamMemberButton.Text = "Add Member";
            this.addTeamMemberButton.UseVisualStyleBackColor = true;
            this.addTeamMemberButton.Click += new System.EventHandler(this.addTeamMemberButton_Click);
            // 
            // selectTeamMemberDropDown
            // 
            this.selectTeamMemberDropDown.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.selectTeamMemberDropDown.FormattingEnabled = true;
            this.selectTeamMemberDropDown.Location = new System.Drawing.Point(24, 213);
            this.selectTeamMemberDropDown.Name = "selectTeamMemberDropDown";
            this.selectTeamMemberDropDown.Size = new System.Drawing.Size(357, 33);
            this.selectTeamMemberDropDown.TabIndex = 18;
            // 
            // selectTeamMemberLabel
            // 
            this.selectTeamMemberLabel.AutoSize = true;
            this.selectTeamMemberLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.selectTeamMemberLabel.Location = new System.Drawing.Point(24, 185);
            this.selectTeamMemberLabel.Name = "selectTeamMemberLabel";
            this.selectTeamMemberLabel.Size = new System.Drawing.Size(187, 25);
            this.selectTeamMemberLabel.TabIndex = 17;
            this.selectTeamMemberLabel.Text = "Select Team Member";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.createMemberButton);
            this.groupBox1.Controls.Add(this.cellphoneValue);
            this.groupBox1.Controls.Add(this.cellphoneLabel);
            this.groupBox1.Controls.Add(this.emailValue);
            this.groupBox1.Controls.Add(this.emailLabel);
            this.groupBox1.Controls.Add(this.lastNameValue);
            this.groupBox1.Controls.Add(this.lastNameLabel);
            this.groupBox1.Controls.Add(this.firstNameValue);
            this.groupBox1.Controls.Add(this.firstNameLabel);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(24, 347);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(392, 341);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add New Member";
            // 
            // createMemberButton
            // 
            this.createMemberButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.createMemberButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.createMemberButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.createMemberButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createMemberButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.createMemberButton.Location = new System.Drawing.Point(80, 268);
            this.createMemberButton.Name = "createMemberButton";
            this.createMemberButton.Size = new System.Drawing.Size(199, 55);
            this.createMemberButton.TabIndex = 22;
            this.createMemberButton.Text = "Create Member";
            this.createMemberButton.UseVisualStyleBackColor = true;
            this.createMemberButton.Click += new System.EventHandler(this.createMemberButton_Click);
            // 
            // cellphoneValue
            // 
            this.cellphoneValue.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cellphoneValue.Location = new System.Drawing.Point(164, 218);
            this.cellphoneValue.Name = "cellphoneValue";
            this.cellphoneValue.Size = new System.Drawing.Size(193, 33);
            this.cellphoneValue.TabIndex = 29;
            // 
            // cellphoneLabel
            // 
            this.cellphoneLabel.AutoSize = true;
            this.cellphoneLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cellphoneLabel.Location = new System.Drawing.Point(26, 218);
            this.cellphoneLabel.Name = "cellphoneLabel";
            this.cellphoneLabel.Size = new System.Drawing.Size(98, 25);
            this.cellphoneLabel.TabIndex = 28;
            this.cellphoneLabel.Text = "Cellphone";
            // 
            // emailValue
            // 
            this.emailValue.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.emailValue.Location = new System.Drawing.Point(164, 165);
            this.emailValue.Name = "emailValue";
            this.emailValue.Size = new System.Drawing.Size(193, 33);
            this.emailValue.TabIndex = 27;
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.emailLabel.Location = new System.Drawing.Point(26, 165);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(58, 25);
            this.emailLabel.TabIndex = 26;
            this.emailLabel.Text = "Email";
            // 
            // lastNameValue
            // 
            this.lastNameValue.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lastNameValue.Location = new System.Drawing.Point(164, 108);
            this.lastNameValue.Name = "lastNameValue";
            this.lastNameValue.Size = new System.Drawing.Size(193, 33);
            this.lastNameValue.TabIndex = 25;
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lastNameLabel.Location = new System.Drawing.Point(24, 111);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(100, 25);
            this.lastNameLabel.TabIndex = 24;
            this.lastNameLabel.Text = "Last Name";
            // 
            // firstNameValue
            // 
            this.firstNameValue.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.firstNameValue.Location = new System.Drawing.Point(164, 52);
            this.firstNameValue.Name = "firstNameValue";
            this.firstNameValue.Size = new System.Drawing.Size(193, 33);
            this.firstNameValue.TabIndex = 23;
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.firstNameLabel.Location = new System.Drawing.Point(22, 55);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(102, 25);
            this.firstNameLabel.TabIndex = 22;
            this.firstNameLabel.Text = "First Name";
            // 
            // teamMembersListBox
            // 
            this.teamMembersListBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.teamMembersListBox.FormattingEnabled = true;
            this.teamMembersListBox.ItemHeight = 25;
            this.teamMembersListBox.Location = new System.Drawing.Point(436, 108);
            this.teamMembersListBox.Name = "teamMembersListBox";
            this.teamMembersListBox.Size = new System.Drawing.Size(331, 579);
            this.teamMembersListBox.TabIndex = 23;
            // 
            // removeSelectedMemberButton
            // 
            this.removeSelectedMemberButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.removeSelectedMemberButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.removeSelectedMemberButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.removeSelectedMemberButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeSelectedMemberButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.removeSelectedMemberButton.Location = new System.Drawing.Point(784, 374);
            this.removeSelectedMemberButton.Name = "removeSelectedMemberButton";
            this.removeSelectedMemberButton.Size = new System.Drawing.Size(127, 81);
            this.removeSelectedMemberButton.TabIndex = 24;
            this.removeSelectedMemberButton.Text = "Remove Selected";
            this.removeSelectedMemberButton.UseVisualStyleBackColor = true;
            this.removeSelectedMemberButton.Click += new System.EventHandler(this.removeSelectedMemberButton_Click);
            // 
            // createTeamButton
            // 
            this.createTeamButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.createTeamButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.createTeamButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.createTeamButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createTeamButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.createTeamButton.Location = new System.Drawing.Point(408, 703);
            this.createTeamButton.Name = "createTeamButton";
            this.createTeamButton.Size = new System.Drawing.Size(175, 63);
            this.createTeamButton.TabIndex = 25;
            this.createTeamButton.Text = "Create Team";
            this.createTeamButton.UseVisualStyleBackColor = true;
            // 
            // CreateTeamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(934, 783);
            this.Controls.Add(this.createTeamButton);
            this.Controls.Add(this.removeSelectedMemberButton);
            this.Controls.Add(this.teamMembersListBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.addTeamMemberButton);
            this.Controls.Add(this.selectTeamMemberDropDown);
            this.Controls.Add(this.selectTeamMemberLabel);
            this.Controls.Add(this.teamNameValue);
            this.Controls.Add(this.teamNameLabel);
            this.Controls.Add(this.createTeamHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "CreateTeamForm";
            this.Text = "Create Team";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox teamNameValue;
        private Label teamNameLabel;
        private Label createTeamHeader;
        private Button addTeamMemberButton;
        private ComboBox selectTeamMemberDropDown;
        private Label selectTeamMemberLabel;
        private GroupBox groupBox1;
        private Button createMemberButton;
        private TextBox cellphoneValue;
        private Label cellphoneLabel;
        private TextBox emailValue;
        private Label emailLabel;
        private TextBox lastNameValue;
        private Label lastNameLabel;
        private TextBox firstNameValue;
        private Label firstNameLabel;
        private ListBox teamMembersListBox;
        private Button removeSelectedMemberButton;
        private Button createTeamButton;
    }
}