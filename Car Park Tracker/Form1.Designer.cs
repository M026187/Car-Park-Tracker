namespace Car_Park_Tracker
{
    partial class FormCarParkTracker
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
            this.ButtonOpenLoadData = new System.Windows.Forms.Button();
            this.ButtonSaveData = new System.Windows.Forms.Button();
            this.ButtonEnterNewLicencePlate = new System.Windows.Forms.Button();
            this.ButtonExitExistingLicencePlate = new System.Windows.Forms.Button();
            this.ButtonSearchLinear = new System.Windows.Forms.Button();
            this.ButtonSearchBinary = new System.Windows.Forms.Button();
            this.ButtonTagLicencePlate = new System.Windows.Forms.Button();
            this.ButtonResetData = new System.Windows.Forms.Button();
            this.ListBoxLicencePlateMainList = new System.Windows.Forms.ListBox();
            this.ListBoxLicencePlateTagged = new System.Windows.Forms.ListBox();
            this.TextBoxUserInput = new System.Windows.Forms.TextBox();
            this.StatusStripMessages = new System.Windows.Forms.StatusStrip();
            this.ButtonEditLicencePlate = new System.Windows.Forms.Button();
            this.LabelLicencePlateList = new System.Windows.Forms.Label();
            this.LabelTaggedLicencePlate = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.GroupBoxSearch = new System.Windows.Forms.GroupBox();
            this.GroupBoxModify = new System.Windows.Forms.GroupBox();
            this.GroupBoxInput = new System.Windows.Forms.GroupBox();
            this.GroupBoxFileControl = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.GroupBoxSearch.SuspendLayout();
            this.GroupBoxModify.SuspendLayout();
            this.GroupBoxInput.SuspendLayout();
            this.GroupBoxFileControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButtonOpenLoadData
            // 
            this.ButtonOpenLoadData.Location = new System.Drawing.Point(9, 18);
            this.ButtonOpenLoadData.Name = "ButtonOpenLoadData";
            this.ButtonOpenLoadData.Size = new System.Drawing.Size(90, 26);
            this.ButtonOpenLoadData.TabIndex = 0;
            this.ButtonOpenLoadData.Text = "OPEN/LOAD";
            this.ButtonOpenLoadData.UseVisualStyleBackColor = true;
            // 
            // ButtonSaveData
            // 
            this.ButtonSaveData.Location = new System.Drawing.Point(9, 50);
            this.ButtonSaveData.Name = "ButtonSaveData";
            this.ButtonSaveData.Size = new System.Drawing.Size(90, 26);
            this.ButtonSaveData.TabIndex = 1;
            this.ButtonSaveData.Text = "SAVE";
            this.ButtonSaveData.UseVisualStyleBackColor = true;
            // 
            // ButtonEnterNewLicencePlate
            // 
            this.ButtonEnterNewLicencePlate.Location = new System.Drawing.Point(8, 47);
            this.ButtonEnterNewLicencePlate.Name = "ButtonEnterNewLicencePlate";
            this.ButtonEnterNewLicencePlate.Size = new System.Drawing.Size(90, 26);
            this.ButtonEnterNewLicencePlate.TabIndex = 2;
            this.ButtonEnterNewLicencePlate.Text = "ENTER";
            this.ButtonEnterNewLicencePlate.UseVisualStyleBackColor = true;
            // 
            // ButtonExitExistingLicencePlate
            // 
            this.ButtonExitExistingLicencePlate.Location = new System.Drawing.Point(8, 80);
            this.ButtonExitExistingLicencePlate.Name = "ButtonExitExistingLicencePlate";
            this.ButtonExitExistingLicencePlate.Size = new System.Drawing.Size(90, 26);
            this.ButtonExitExistingLicencePlate.TabIndex = 3;
            this.ButtonExitExistingLicencePlate.Text = "EXIT";
            this.ButtonExitExistingLicencePlate.UseVisualStyleBackColor = true;
            // 
            // ButtonSearchLinear
            // 
            this.ButtonSearchLinear.Location = new System.Drawing.Point(9, 18);
            this.ButtonSearchLinear.Name = "ButtonSearchLinear";
            this.ButtonSearchLinear.Size = new System.Drawing.Size(90, 35);
            this.ButtonSearchLinear.TabIndex = 4;
            this.ButtonSearchLinear.Text = "LINEAR SEARCH";
            this.ButtonSearchLinear.UseVisualStyleBackColor = true;
            // 
            // ButtonSearchBinary
            // 
            this.ButtonSearchBinary.Location = new System.Drawing.Point(8, 59);
            this.ButtonSearchBinary.Name = "ButtonSearchBinary";
            this.ButtonSearchBinary.Size = new System.Drawing.Size(90, 35);
            this.ButtonSearchBinary.TabIndex = 5;
            this.ButtonSearchBinary.Text = "BINARY SEARCH";
            this.ButtonSearchBinary.UseVisualStyleBackColor = true;
            // 
            // ButtonTagLicencePlate
            // 
            this.ButtonTagLicencePlate.Location = new System.Drawing.Point(8, 112);
            this.ButtonTagLicencePlate.Name = "ButtonTagLicencePlate";
            this.ButtonTagLicencePlate.Size = new System.Drawing.Size(90, 26);
            this.ButtonTagLicencePlate.TabIndex = 6;
            this.ButtonTagLicencePlate.Text = "TAG";
            this.ButtonTagLicencePlate.UseVisualStyleBackColor = true;
            // 
            // ButtonResetData
            // 
            this.ButtonResetData.Location = new System.Drawing.Point(9, 83);
            this.ButtonResetData.Name = "ButtonResetData";
            this.ButtonResetData.Size = new System.Drawing.Size(90, 26);
            this.ButtonResetData.TabIndex = 7;
            this.ButtonResetData.Text = "RESET";
            this.ButtonResetData.UseVisualStyleBackColor = true;
            // 
            // ListBoxLicencePlateMainList
            // 
            this.ListBoxLicencePlateMainList.FormattingEnabled = true;
            this.ListBoxLicencePlateMainList.Location = new System.Drawing.Point(175, 166);
            this.ListBoxLicencePlateMainList.Name = "ListBoxLicencePlateMainList";
            this.ListBoxLicencePlateMainList.Size = new System.Drawing.Size(101, 329);
            this.ListBoxLicencePlateMainList.TabIndex = 8;
            // 
            // ListBoxLicencePlateTagged
            // 
            this.ListBoxLicencePlateTagged.FormattingEnabled = true;
            this.ListBoxLicencePlateTagged.Location = new System.Drawing.Point(446, 166);
            this.ListBoxLicencePlateTagged.Name = "ListBoxLicencePlateTagged";
            this.ListBoxLicencePlateTagged.Size = new System.Drawing.Size(101, 329);
            this.ListBoxLicencePlateTagged.TabIndex = 9;
            // 
            // TextBoxUserInput
            // 
            this.TextBoxUserInput.Location = new System.Drawing.Point(9, 18);
            this.TextBoxUserInput.Name = "TextBoxUserInput";
            this.TextBoxUserInput.Size = new System.Drawing.Size(89, 20);
            this.TextBoxUserInput.TabIndex = 10;
            // 
            // StatusStripMessages
            // 
            this.StatusStripMessages.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.StatusStripMessages.Location = new System.Drawing.Point(0, 539);
            this.StatusStripMessages.Name = "StatusStripMessages";
            this.StatusStripMessages.Size = new System.Drawing.Size(584, 22);
            this.StatusStripMessages.TabIndex = 11;
            this.StatusStripMessages.Text = "statusStrip1";
            // 
            // ButtonEditLicencePlate
            // 
            this.ButtonEditLicencePlate.Location = new System.Drawing.Point(8, 16);
            this.ButtonEditLicencePlate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ButtonEditLicencePlate.Name = "ButtonEditLicencePlate";
            this.ButtonEditLicencePlate.Size = new System.Drawing.Size(90, 26);
            this.ButtonEditLicencePlate.TabIndex = 12;
            this.ButtonEditLicencePlate.Text = "EDIT";
            this.ButtonEditLicencePlate.UseVisualStyleBackColor = true;
            // 
            // LabelLicencePlateList
            // 
            this.LabelLicencePlateList.AutoSize = true;
            this.LabelLicencePlateList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelLicencePlateList.Location = new System.Drawing.Point(194, 130);
            this.LabelLicencePlateList.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelLicencePlateList.Name = "LabelLicencePlateList";
            this.LabelLicencePlateList.Size = new System.Drawing.Size(63, 17);
            this.LabelLicencePlateList.TabIndex = 13;
            this.LabelLicencePlateList.Text = "Car Park";
            // 
            // LabelTaggedLicencePlate
            // 
            this.LabelTaggedLicencePlate.AutoSize = true;
            this.LabelTaggedLicencePlate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTaggedLicencePlate.Location = new System.Drawing.Point(423, 146);
            this.LabelTaggedLicencePlate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelTaggedLicencePlate.Name = "LabelTaggedLicencePlate";
            this.LabelTaggedLicencePlate.Size = new System.Drawing.Size(146, 17);
            this.LabelTaggedLicencePlate.TabIndex = 14;
            this.LabelTaggedLicencePlate.Text = "Tagged Licence Plate";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Car_Park_Tracker.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(480, 15);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.MaximumSize = new System.Drawing.Size(100, 98);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(67, 65);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 20);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(447, 54);
            this.label3.TabIndex = 16;
            this.label3.Text = "Active Systems PTY";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(82, 87);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(341, 31);
            this.label4.TabIndex = 17;
            this.label4.Text = "Licence Plate Management";
            // 
            // GroupBoxSearch
            // 
            this.GroupBoxSearch.BackColor = System.Drawing.SystemColors.Control;
            this.GroupBoxSearch.Controls.Add(this.ButtonSearchBinary);
            this.GroupBoxSearch.Controls.Add(this.ButtonSearchLinear);
            this.GroupBoxSearch.Location = new System.Drawing.Point(307, 166);
            this.GroupBoxSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GroupBoxSearch.Name = "GroupBoxSearch";
            this.GroupBoxSearch.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GroupBoxSearch.Size = new System.Drawing.Size(107, 109);
            this.GroupBoxSearch.TabIndex = 18;
            this.GroupBoxSearch.TabStop = false;
            this.GroupBoxSearch.Text = "SEARCH";
            // 
            // GroupBoxModify
            // 
            this.GroupBoxModify.Controls.Add(this.ButtonEditLicencePlate);
            this.GroupBoxModify.Controls.Add(this.ButtonTagLicencePlate);
            this.GroupBoxModify.Controls.Add(this.ButtonExitExistingLicencePlate);
            this.GroupBoxModify.Controls.Add(this.ButtonEnterNewLicencePlate);
            this.GroupBoxModify.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBoxModify.Location = new System.Drawing.Point(307, 345);
            this.GroupBoxModify.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GroupBoxModify.Name = "GroupBoxModify";
            this.GroupBoxModify.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GroupBoxModify.Size = new System.Drawing.Size(107, 148);
            this.GroupBoxModify.TabIndex = 19;
            this.GroupBoxModify.TabStop = false;
            this.GroupBoxModify.Text = "MODIFY";
            // 
            // GroupBoxInput
            // 
            this.GroupBoxInput.BackColor = System.Drawing.SystemColors.Control;
            this.GroupBoxInput.Controls.Add(this.TextBoxUserInput);
            this.GroupBoxInput.Location = new System.Drawing.Point(307, 283);
            this.GroupBoxInput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GroupBoxInput.Name = "GroupBoxInput";
            this.GroupBoxInput.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GroupBoxInput.Size = new System.Drawing.Size(107, 46);
            this.GroupBoxInput.TabIndex = 20;
            this.GroupBoxInput.TabStop = false;
            this.GroupBoxInput.Text = "INPUT";
            // 
            // GroupBoxFileControl
            // 
            this.GroupBoxFileControl.Controls.Add(this.ButtonResetData);
            this.GroupBoxFileControl.Controls.Add(this.ButtonSaveData);
            this.GroupBoxFileControl.Controls.Add(this.ButtonOpenLoadData);
            this.GroupBoxFileControl.Location = new System.Drawing.Point(29, 166);
            this.GroupBoxFileControl.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GroupBoxFileControl.Name = "GroupBoxFileControl";
            this.GroupBoxFileControl.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GroupBoxFileControl.Size = new System.Drawing.Size(111, 120);
            this.GroupBoxFileControl.TabIndex = 21;
            this.GroupBoxFileControl.TabStop = false;
            this.GroupBoxFileControl.Text = "FILE CONTROL";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(165, 146);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 17);
            this.label1.TabIndex = 22;
            this.label1.Text = "Licence Plate Log";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // FormCarParkTracker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GroupBoxFileControl);
            this.Controls.Add(this.GroupBoxInput);
            this.Controls.Add(this.GroupBoxModify);
            this.Controls.Add(this.GroupBoxSearch);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.LabelTaggedLicencePlate);
            this.Controls.Add(this.LabelLicencePlateList);
            this.Controls.Add(this.StatusStripMessages);
            this.Controls.Add(this.ListBoxLicencePlateTagged);
            this.Controls.Add(this.ListBoxLicencePlateMainList);
            this.Name = "FormCarParkTracker";
            this.Text = "Active Systems PTY";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.GroupBoxSearch.ResumeLayout(false);
            this.GroupBoxModify.ResumeLayout(false);
            this.GroupBoxInput.ResumeLayout(false);
            this.GroupBoxInput.PerformLayout();
            this.GroupBoxFileControl.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonOpenLoadData;
        private System.Windows.Forms.Button ButtonSaveData;
        private System.Windows.Forms.Button ButtonEnterNewLicencePlate;
        private System.Windows.Forms.Button ButtonExitExistingLicencePlate;
        private System.Windows.Forms.Button ButtonSearchLinear;
        private System.Windows.Forms.Button ButtonSearchBinary;
        private System.Windows.Forms.Button ButtonTagLicencePlate;
        private System.Windows.Forms.Button ButtonResetData;
        private System.Windows.Forms.ListBox ListBoxLicencePlateMainList;
        private System.Windows.Forms.ListBox ListBoxLicencePlateTagged;
        private System.Windows.Forms.TextBox TextBoxUserInput;
        private System.Windows.Forms.StatusStrip StatusStripMessages;
        private System.Windows.Forms.Button ButtonEditLicencePlate;
        private System.Windows.Forms.Label LabelLicencePlateList;
        private System.Windows.Forms.Label LabelTaggedLicencePlate;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox GroupBoxSearch;
        private System.Windows.Forms.GroupBox GroupBoxModify;
        private System.Windows.Forms.GroupBox GroupBoxInput;
        private System.Windows.Forms.GroupBox GroupBoxFileControl;
        private System.Windows.Forms.Label label1;
    }
}

