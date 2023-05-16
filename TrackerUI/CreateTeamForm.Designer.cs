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
            this.label1 = new System.Windows.Forms.Label();
            this.addMemberButton = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SelectTeamMemberlabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.teamNamelabel = new System.Windows.Forms.Label();
            this.addNewMemberGroupBox = new System.Windows.Forms.GroupBox();
            this.CreateMemberButton = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.Cellphonelabel = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.emaillabel = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.lastNamelabel = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.TeamMembersListBox = new System.Windows.Forms.ListBox();
            this.DeleteSelectedMemberButton = new System.Windows.Forms.Button();
            this.createTeamButton = new System.Windows.Forms.Button();
            this.addNewMemberGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(23, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 45);
            this.label1.TabIndex = 2;
            this.label1.Text = "Create Team";
            // 
            // addMemberButton
            // 
            this.addMemberButton.BackColor = System.Drawing.Color.Black;
            this.addMemberButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.addMemberButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.addMemberButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addMemberButton.ForeColor = System.Drawing.Color.Red;
            this.addMemberButton.Location = new System.Drawing.Point(74, 245);
            this.addMemberButton.Name = "addMemberButton";
            this.addMemberButton.Size = new System.Drawing.Size(218, 57);
            this.addMemberButton.TabIndex = 20;
            this.addMemberButton.Text = "Add Member";
            this.addMemberButton.UseVisualStyleBackColor = false;
            this.addMemberButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.Red;
            this.comboBox1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(35, 188);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(304, 40);
            this.comboBox1.TabIndex = 19;
            // 
            // SelectTeamMemberlabel
            // 
            this.SelectTeamMemberlabel.AutoSize = true;
            this.SelectTeamMemberlabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SelectTeamMemberlabel.ForeColor = System.Drawing.Color.Red;
            this.SelectTeamMemberlabel.Location = new System.Drawing.Point(35, 155);
            this.SelectTeamMemberlabel.Name = "SelectTeamMemberlabel";
            this.SelectTeamMemberlabel.Size = new System.Drawing.Size(207, 30);
            this.SelectTeamMemberlabel.TabIndex = 18;
            this.SelectTeamMemberlabel.Text = "Select Team Member";
            this.SelectTeamMemberlabel.Click += new System.EventHandler(this.label3_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Red;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.ForeColor = System.Drawing.Color.Black;
            this.textBox1.Location = new System.Drawing.Point(35, 116);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(304, 29);
            this.textBox1.TabIndex = 22;
            // 
            // teamNamelabel
            // 
            this.teamNamelabel.AutoSize = true;
            this.teamNamelabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.teamNamelabel.ForeColor = System.Drawing.Color.Red;
            this.teamNamelabel.Location = new System.Drawing.Point(35, 83);
            this.teamNamelabel.Name = "teamNamelabel";
            this.teamNamelabel.Size = new System.Drawing.Size(124, 30);
            this.teamNamelabel.TabIndex = 21;
            this.teamNamelabel.Text = "Team Name";
            // 
            // addNewMemberGroupBox
            // 
            this.addNewMemberGroupBox.Controls.Add(this.CreateMemberButton);
            this.addNewMemberGroupBox.Controls.Add(this.textBox4);
            this.addNewMemberGroupBox.Controls.Add(this.Cellphonelabel);
            this.addNewMemberGroupBox.Controls.Add(this.textBox5);
            this.addNewMemberGroupBox.Controls.Add(this.emaillabel);
            this.addNewMemberGroupBox.Controls.Add(this.textBox3);
            this.addNewMemberGroupBox.Controls.Add(this.lastNamelabel);
            this.addNewMemberGroupBox.Controls.Add(this.textBox2);
            this.addNewMemberGroupBox.Controls.Add(this.firstNameLabel);
            this.addNewMemberGroupBox.ForeColor = System.Drawing.Color.Red;
            this.addNewMemberGroupBox.Location = new System.Drawing.Point(35, 318);
            this.addNewMemberGroupBox.Name = "addNewMemberGroupBox";
            this.addNewMemberGroupBox.Size = new System.Drawing.Size(323, 300);
            this.addNewMemberGroupBox.TabIndex = 23;
            this.addNewMemberGroupBox.TabStop = false;
            this.addNewMemberGroupBox.Text = "Add New Member";
            // 
            // CreateMemberButton
            // 
            this.CreateMemberButton.BackColor = System.Drawing.Color.Black;
            this.CreateMemberButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.CreateMemberButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.CreateMemberButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CreateMemberButton.ForeColor = System.Drawing.Color.Red;
            this.CreateMemberButton.Location = new System.Drawing.Point(39, 224);
            this.CreateMemberButton.Name = "CreateMemberButton";
            this.CreateMemberButton.Size = new System.Drawing.Size(218, 57);
            this.CreateMemberButton.TabIndex = 24;
            this.CreateMemberButton.Text = "Create Member";
            this.CreateMemberButton.UseVisualStyleBackColor = false;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.Red;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox4.ForeColor = System.Drawing.Color.Black;
            this.textBox4.Location = new System.Drawing.Point(133, 175);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(146, 29);
            this.textBox4.TabIndex = 17;
            // 
            // Cellphonelabel
            // 
            this.Cellphonelabel.AutoSize = true;
            this.Cellphonelabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Cellphonelabel.ForeColor = System.Drawing.Color.Red;
            this.Cellphonelabel.Location = new System.Drawing.Point(14, 175);
            this.Cellphonelabel.Name = "Cellphonelabel";
            this.Cellphonelabel.Size = new System.Drawing.Size(106, 30);
            this.Cellphonelabel.TabIndex = 16;
            this.Cellphonelabel.Text = "Cellphone";
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.Color.Red;
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox5.ForeColor = System.Drawing.Color.Black;
            this.textBox5.Location = new System.Drawing.Point(133, 129);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(146, 29);
            this.textBox5.TabIndex = 15;
            // 
            // emaillabel
            // 
            this.emaillabel.AutoSize = true;
            this.emaillabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.emaillabel.ForeColor = System.Drawing.Color.Red;
            this.emaillabel.Location = new System.Drawing.Point(14, 129);
            this.emaillabel.Name = "emaillabel";
            this.emaillabel.Size = new System.Drawing.Size(63, 30);
            this.emaillabel.TabIndex = 14;
            this.emaillabel.Text = "Email";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.Red;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox3.ForeColor = System.Drawing.Color.Black;
            this.textBox3.Location = new System.Drawing.Point(133, 83);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(146, 29);
            this.textBox3.TabIndex = 13;
            // 
            // lastNamelabel
            // 
            this.lastNamelabel.AutoSize = true;
            this.lastNamelabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lastNamelabel.ForeColor = System.Drawing.Color.Red;
            this.lastNamelabel.Location = new System.Drawing.Point(14, 83);
            this.lastNamelabel.Name = "lastNamelabel";
            this.lastNamelabel.Size = new System.Drawing.Size(112, 30);
            this.lastNamelabel.TabIndex = 12;
            this.lastNamelabel.Text = "Last Name";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.Red;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox2.ForeColor = System.Drawing.Color.Black;
            this.textBox2.Location = new System.Drawing.Point(133, 37);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(146, 29);
            this.textBox2.TabIndex = 11;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.firstNameLabel.ForeColor = System.Drawing.Color.Red;
            this.firstNameLabel.Location = new System.Drawing.Point(14, 37);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(113, 30);
            this.firstNameLabel.TabIndex = 10;
            this.firstNameLabel.Text = "First Name";
            // 
            // TeamMembersListBox
            // 
            this.TeamMembersListBox.BackColor = System.Drawing.Color.Red;
            this.TeamMembersListBox.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TeamMembersListBox.FormattingEnabled = true;
            this.TeamMembersListBox.ItemHeight = 32;
            this.TeamMembersListBox.Location = new System.Drawing.Point(380, 83);
            this.TeamMembersListBox.Name = "TeamMembersListBox";
            this.TeamMembersListBox.Size = new System.Drawing.Size(336, 516);
            this.TeamMembersListBox.TabIndex = 24;
            // 
            // DeleteSelectedMemberButton
            // 
            this.DeleteSelectedMemberButton.BackColor = System.Drawing.Color.Black;
            this.DeleteSelectedMemberButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.DeleteSelectedMemberButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.DeleteSelectedMemberButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DeleteSelectedMemberButton.ForeColor = System.Drawing.Color.Red;
            this.DeleteSelectedMemberButton.Location = new System.Drawing.Point(733, 318);
            this.DeleteSelectedMemberButton.Name = "DeleteSelectedMemberButton";
            this.DeleteSelectedMemberButton.Size = new System.Drawing.Size(119, 77);
            this.DeleteSelectedMemberButton.TabIndex = 26;
            this.DeleteSelectedMemberButton.Text = "Delete Selected";
            this.DeleteSelectedMemberButton.UseVisualStyleBackColor = false;
            // 
            // createTeamButton
            // 
            this.createTeamButton.BackColor = System.Drawing.Color.Black;
            this.createTeamButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.createTeamButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.createTeamButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.createTeamButton.ForeColor = System.Drawing.Color.Red;
            this.createTeamButton.Location = new System.Drawing.Point(283, 633);
            this.createTeamButton.Name = "createTeamButton";
            this.createTeamButton.Size = new System.Drawing.Size(243, 66);
            this.createTeamButton.TabIndex = 27;
            this.createTeamButton.Text = "Create Team";
            this.createTeamButton.UseVisualStyleBackColor = false;
            // 
            // CreateTeamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(864, 711);
            this.Controls.Add(this.createTeamButton);
            this.Controls.Add(this.DeleteSelectedMemberButton);
            this.Controls.Add(this.TeamMembersListBox);
            this.Controls.Add(this.addNewMemberGroupBox);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.teamNamelabel);
            this.Controls.Add(this.addMemberButton);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.SelectTeamMemberlabel);
            this.Controls.Add(this.label1);
            this.Name = "CreateTeamForm";
            this.Text = "CreateTeamForm";
            this.Load += new System.EventHandler(this.CreateTeamForm_Load);
            this.addNewMemberGroupBox.ResumeLayout(false);
            this.addNewMemberGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button addMemberButton;
        private ComboBox comboBox1;
        private Label SelectTeamMemberlabel;
        private TextBox textBox1;
        private Label teamNamelabel;
        private GroupBox addNewMemberGroupBox;
        private TextBox textBox2;
        private Label firstNameLabel;
        private Button CreateMemberButton;
        private TextBox textBox4;
        private Label Cellphonelabel;
        private TextBox textBox5;
        private Label emaillabel;
        private TextBox textBox3;
        private Label lastNamelabel;
        private ListBox TeamMembersListBox;
        private Button DeleteSelectedMemberButton;
        private Button createTeamButton;
    }
}