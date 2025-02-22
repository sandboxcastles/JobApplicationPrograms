namespace CoverLetterTextMaker
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            companyNameTextBox = new TextBox();
            companyNameLbl = new Label();
            jobNameLbl = new Label();
            jobNameTextBox = new TextBox();
            experienceInLbl = new Label();
            experienceInTextBox = new TextBox();
            generateTextBtn = new Button();
            generatedTextTextBox = new TextBox();
            copyTextBtn = new Button();
            createPdfBtn = new Button();
            jobListingLocationLbl = new Label();
            jobListingLocationTextBox = new TextBox();
            jobSpecificQualificationsLbl = new Label();
            jobSpecificQualificationsTextBox = new TextBox();
            SuspendLayout();
            // 
            // companyNameTextBox
            // 
            companyNameTextBox.Location = new Point(12, 39);
            companyNameTextBox.Name = "companyNameTextBox";
            companyNameTextBox.Size = new Size(517, 23);
            companyNameTextBox.TabIndex = 0;
            // 
            // companyNameLbl
            // 
            companyNameLbl.AutoSize = true;
            companyNameLbl.ImageAlign = ContentAlignment.BottomLeft;
            companyNameLbl.Location = new Point(12, 18);
            companyNameLbl.Name = "companyNameLbl";
            companyNameLbl.Size = new Size(94, 15);
            companyNameLbl.TabIndex = 1;
            companyNameLbl.Text = "Company Name";
            // 
            // jobNameLbl
            // 
            jobNameLbl.AutoSize = true;
            jobNameLbl.ImageAlign = ContentAlignment.BottomLeft;
            jobNameLbl.Location = new Point(12, 65);
            jobNameLbl.Name = "jobNameLbl";
            jobNameLbl.Size = new Size(152, 15);
            jobNameLbl.TabIndex = 3;
            jobNameLbl.Text = "Job Name (from job listing)";
            // 
            // jobNameTextBox
            // 
            jobNameTextBox.Location = new Point(12, 83);
            jobNameTextBox.Name = "jobNameTextBox";
            jobNameTextBox.Size = new Size(517, 23);
            jobNameTextBox.TabIndex = 2;
            jobNameTextBox.Text = "Senior Front End Engineer";
            // 
            // experienceInLbl
            // 
            experienceInLbl.AutoSize = true;
            experienceInLbl.ImageAlign = ContentAlignment.BottomLeft;
            experienceInLbl.Location = new Point(12, 119);
            experienceInLbl.Name = "experienceInLbl";
            experienceInLbl.Size = new Size(265, 15);
            experienceInLbl.TabIndex = 5;
            experienceInLbl.Text = "Experience In? (eg. 'front end web development')";
            // 
            // experienceInTextBox
            // 
            experienceInTextBox.Location = new Point(12, 137);
            experienceInTextBox.Name = "experienceInTextBox";
            experienceInTextBox.Size = new Size(517, 23);
            experienceInTextBox.TabIndex = 4;
            experienceInTextBox.Text = "front end web development";
            // 
            // generateTextBtn
            // 
            generateTextBtn.Location = new Point(13, 301);
            generateTextBtn.Name = "generateTextBtn";
            generateTextBtn.Size = new Size(99, 23);
            generateTextBtn.TabIndex = 6;
            generateTextBtn.Text = "Generate Text";
            generateTextBtn.UseVisualStyleBackColor = true;
            generateTextBtn.Click += generateTextBtn_Click;
            // 
            // generatedTextTextBox
            // 
            generatedTextTextBox.Location = new Point(13, 330);
            generatedTextTextBox.Multiline = true;
            generatedTextTextBox.Name = "generatedTextTextBox";
            generatedTextTextBox.Size = new Size(517, 421);
            generatedTextTextBox.TabIndex = 7;
            // 
            // copyTextBtn
            // 
            copyTextBtn.Location = new Point(455, 301);
            copyTextBtn.Name = "copyTextBtn";
            copyTextBtn.Size = new Size(75, 23);
            copyTextBtn.TabIndex = 8;
            copyTextBtn.Text = "Copy Text";
            copyTextBtn.UseVisualStyleBackColor = true;
            copyTextBtn.Click += copyTextBtn_Click;
            // 
            // createPdfBtn
            // 
            createPdfBtn.Enabled = false;
            createPdfBtn.Location = new Point(118, 301);
            createPdfBtn.Name = "createPdfBtn";
            createPdfBtn.Size = new Size(99, 23);
            createPdfBtn.TabIndex = 9;
            createPdfBtn.Text = "Create PDF";
            createPdfBtn.UseVisualStyleBackColor = true;
            createPdfBtn.Click += createPdfBtn_Click;
            // 
            // jobListingLocationLbl
            // 
            jobListingLocationLbl.AutoSize = true;
            jobListingLocationLbl.ImageAlign = ContentAlignment.BottomLeft;
            jobListingLocationLbl.Location = new Point(12, 170);
            jobListingLocationLbl.Name = "jobListingLocationLbl";
            jobListingLocationLbl.Size = new Size(251, 15);
            jobListingLocationLbl.TabIndex = 11;
            jobListingLocationLbl.Text = "Job Listing Location (eg. 'I found on LinkedIn')";
            // 
            // jobListingLocationTextBox
            // 
            jobListingLocationTextBox.Location = new Point(12, 188);
            jobListingLocationTextBox.Name = "jobListingLocationTextBox";
            jobListingLocationTextBox.Size = new Size(517, 23);
            jobListingLocationTextBox.TabIndex = 10;
            // 
            // jobSpecificQualificationsLbl
            // 
            jobSpecificQualificationsLbl.AutoSize = true;
            jobSpecificQualificationsLbl.ImageAlign = ContentAlignment.BottomLeft;
            jobSpecificQualificationsLbl.Location = new Point(13, 225);
            jobSpecificQualificationsLbl.Name = "jobSpecificQualificationsLbl";
            jobSpecificQualificationsLbl.Size = new Size(255, 15);
            jobSpecificQualificationsLbl.TabIndex = 13;
            jobSpecificQualificationsLbl.Text = "Job-Specific Qualifications (comma-separated)";
            // 
            // jobSpecificQualificationsTextBox
            // 
            jobSpecificQualificationsTextBox.Location = new Point(13, 243);
            jobSpecificQualificationsTextBox.Name = "jobSpecificQualificationsTextBox";
            jobSpecificQualificationsTextBox.Size = new Size(517, 23);
            jobSpecificQualificationsTextBox.TabIndex = 12;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(541, 756);
            Controls.Add(jobSpecificQualificationsLbl);
            Controls.Add(jobSpecificQualificationsTextBox);
            Controls.Add(jobListingLocationLbl);
            Controls.Add(jobListingLocationTextBox);
            Controls.Add(createPdfBtn);
            Controls.Add(copyTextBtn);
            Controls.Add(generatedTextTextBox);
            Controls.Add(generateTextBtn);
            Controls.Add(experienceInLbl);
            Controls.Add(experienceInTextBox);
            Controls.Add(jobNameLbl);
            Controls.Add(jobNameTextBox);
            Controls.Add(companyNameLbl);
            Controls.Add(companyNameTextBox);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Cover Letter Generator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox companyNameTextBox;
        private Label companyNameLbl;
        private Label jobNameLbl;
        private TextBox jobNameTextBox;
        private Label experienceInLbl;
        private TextBox experienceInTextBox;
        private Button generateTextBtn;
        private TextBox generatedTextTextBox;
        private Button copyTextBtn;
        private Button createPdfBtn;
        private Label jobListingLocationLbl;
        private TextBox jobListingLocationTextBox;
        private Label jobSpecificQualificationsLbl;
        private TextBox jobSpecificQualificationsTextBox;
    }
}
