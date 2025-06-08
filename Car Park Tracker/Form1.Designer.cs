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
            this.components = new System.ComponentModel.Container();
            this.ButtonOpenLoadData = new System.Windows.Forms.Button();
            this.ButtonSaveData = new System.Windows.Forms.Button();
            this.ButtonEnterNewLicencePlate = new System.Windows.Forms.Button();
            this.ButtonExitExistingLicencePlate = new System.Windows.Forms.Button();
            this.ButtonSearchLinear = new System.Windows.Forms.Button();
            this.ButtonSearchBinary = new System.Windows.Forms.Button();
            this.ButtonTagLicencePlate = new System.Windows.Forms.Button();
            this.ButtonResetData = new System.Windows.Forms.Button();
            this.ListBoxLicencePlateMain = new System.Windows.Forms.ListBox();
            this.ListBoxLicencePlateTagged = new System.Windows.Forms.ListBox();
            this.TextBoxUserInput = new System.Windows.Forms.TextBox();
            this.StatusStripMessages = new System.Windows.Forms.StatusStrip();
            this.ToolStripStatusLabelMessage = new System.Windows.Forms.ToolStripStatusLabel();
            this.ButtonEditLicencePlate = new System.Windows.Forms.Button();
            this.LabelLicencePlateList1 = new System.Windows.Forms.Label();
            this.LabelTaggedLicencePlate = new System.Windows.Forms.Label();
            this.PictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.LabelTitle1 = new System.Windows.Forms.Label();
            this.LabelTitle2 = new System.Windows.Forms.Label();
            this.GroupBoxSearch = new System.Windows.Forms.GroupBox();
            this.GroupBoxModify = new System.Windows.Forms.GroupBox();
            this.GroupBoxInput = new System.Windows.Forms.GroupBox();
            this.GroupBoxFileControl = new System.Windows.Forms.GroupBox();
            this.LabelLicencePlateList2 = new System.Windows.Forms.Label();
            this.ToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.StatusStripMessages.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxLogo)).BeginInit();
            this.GroupBoxSearch.SuspendLayout();
            this.GroupBoxModify.SuspendLayout();
            this.GroupBoxInput.SuspendLayout();
            this.GroupBoxFileControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButtonOpenLoadData
            // 
            this.ButtonOpenLoadData.Location = new System.Drawing.Point(14, 28);
            this.ButtonOpenLoadData.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ButtonOpenLoadData.Name = "ButtonOpenLoadData";
            this.ButtonOpenLoadData.Size = new System.Drawing.Size(135, 40);
            this.ButtonOpenLoadData.TabIndex = 0;
            this.ButtonOpenLoadData.Text = "OPEN/LOAD";
            this.ButtonOpenLoadData.UseVisualStyleBackColor = true;
            this.ButtonOpenLoadData.Click += new System.EventHandler(this.ButtonOpenLoadData_Click);
            // 
            // ButtonSaveData
            // 
            this.ButtonSaveData.Location = new System.Drawing.Point(14, 77);
            this.ButtonSaveData.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ButtonSaveData.Name = "ButtonSaveData";
            this.ButtonSaveData.Size = new System.Drawing.Size(135, 40);
            this.ButtonSaveData.TabIndex = 1;
            this.ButtonSaveData.Text = "SAVE";
            this.ButtonSaveData.UseVisualStyleBackColor = true;
            this.ButtonSaveData.Click += new System.EventHandler(this.ButtonSaveData_Click);
            // 
            // ButtonEnterNewLicencePlate
            // 
            this.ButtonEnterNewLicencePlate.Location = new System.Drawing.Point(12, 72);
            this.ButtonEnterNewLicencePlate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ButtonEnterNewLicencePlate.Name = "ButtonEnterNewLicencePlate";
            this.ButtonEnterNewLicencePlate.Size = new System.Drawing.Size(135, 40);
            this.ButtonEnterNewLicencePlate.TabIndex = 2;
            this.ButtonEnterNewLicencePlate.Text = "ENTER";
            this.ButtonEnterNewLicencePlate.UseVisualStyleBackColor = true;
            this.ButtonEnterNewLicencePlate.Click += new System.EventHandler(this.ButtonEnterNewLicencePlate_Click);
            // 
            // ButtonExitExistingLicencePlate
            // 
            this.ButtonExitExistingLicencePlate.Location = new System.Drawing.Point(12, 123);
            this.ButtonExitExistingLicencePlate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ButtonExitExistingLicencePlate.Name = "ButtonExitExistingLicencePlate";
            this.ButtonExitExistingLicencePlate.Size = new System.Drawing.Size(135, 40);
            this.ButtonExitExistingLicencePlate.TabIndex = 3;
            this.ButtonExitExistingLicencePlate.Text = "EXIT";
            this.ButtonExitExistingLicencePlate.UseVisualStyleBackColor = true;
            this.ButtonExitExistingLicencePlate.Click += new System.EventHandler(this.ButtonExitExistingLicencePlate_Click);
            // 
            // ButtonSearchLinear
            // 
            this.ButtonSearchLinear.Location = new System.Drawing.Point(14, 28);
            this.ButtonSearchLinear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ButtonSearchLinear.Name = "ButtonSearchLinear";
            this.ButtonSearchLinear.Size = new System.Drawing.Size(135, 54);
            this.ButtonSearchLinear.TabIndex = 4;
            this.ButtonSearchLinear.Text = "LINEAR SEARCH";
            this.ButtonSearchLinear.UseVisualStyleBackColor = true;
            this.ButtonSearchLinear.Click += new System.EventHandler(this.ButtonSearchLinear_Click);
            // 
            // ButtonSearchBinary
            // 
            this.ButtonSearchBinary.Location = new System.Drawing.Point(12, 91);
            this.ButtonSearchBinary.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ButtonSearchBinary.Name = "ButtonSearchBinary";
            this.ButtonSearchBinary.Size = new System.Drawing.Size(135, 54);
            this.ButtonSearchBinary.TabIndex = 5;
            this.ButtonSearchBinary.Text = "BINARY SEARCH";
            this.ButtonSearchBinary.UseVisualStyleBackColor = true;
            this.ButtonSearchBinary.Click += new System.EventHandler(this.ButtonSearchBinary_Click);
            // 
            // ButtonTagLicencePlate
            // 
            this.ButtonTagLicencePlate.Location = new System.Drawing.Point(12, 172);
            this.ButtonTagLicencePlate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ButtonTagLicencePlate.Name = "ButtonTagLicencePlate";
            this.ButtonTagLicencePlate.Size = new System.Drawing.Size(135, 40);
            this.ButtonTagLicencePlate.TabIndex = 6;
            this.ButtonTagLicencePlate.Text = "TAG";
            this.ButtonTagLicencePlate.UseVisualStyleBackColor = true;
            this.ButtonTagLicencePlate.Click += new System.EventHandler(this.ButtonTagLicencePlate_Click);
            // 
            // ButtonResetData
            // 
            this.ButtonResetData.Location = new System.Drawing.Point(14, 128);
            this.ButtonResetData.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ButtonResetData.Name = "ButtonResetData";
            this.ButtonResetData.Size = new System.Drawing.Size(135, 40);
            this.ButtonResetData.TabIndex = 7;
            this.ButtonResetData.Text = "RESET";
            this.ButtonResetData.UseVisualStyleBackColor = true;
            this.ButtonResetData.Click += new System.EventHandler(this.ButtonResetData_Click);
            // 
            // ListBoxLicencePlateMain
            // 
            this.ListBoxLicencePlateMain.FormattingEnabled = true;
            this.ListBoxLicencePlateMain.ItemHeight = 20;
            this.ListBoxLicencePlateMain.Location = new System.Drawing.Point(262, 255);
            this.ListBoxLicencePlateMain.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ListBoxLicencePlateMain.Name = "ListBoxLicencePlateMain";
            this.ListBoxLicencePlateMain.Size = new System.Drawing.Size(150, 504);
            this.ListBoxLicencePlateMain.TabIndex = 8;
            this.ListBoxLicencePlateMain.SelectedIndexChanged += new System.EventHandler(this.ListBoxLicencePlateMain_SelectedIndexChanged);
            this.ListBoxLicencePlateMain.DoubleClick += new System.EventHandler(this.ListBoxLicencePlateMain_DoubleClick);
            // 
            // ListBoxLicencePlateTagged
            // 
            this.ListBoxLicencePlateTagged.FormattingEnabled = true;
            this.ListBoxLicencePlateTagged.ItemHeight = 20;
            this.ListBoxLicencePlateTagged.Location = new System.Drawing.Point(669, 255);
            this.ListBoxLicencePlateTagged.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ListBoxLicencePlateTagged.Name = "ListBoxLicencePlateTagged";
            this.ListBoxLicencePlateTagged.Size = new System.Drawing.Size(150, 504);
            this.ListBoxLicencePlateTagged.TabIndex = 9;
            this.ListBoxLicencePlateTagged.SelectedIndexChanged += new System.EventHandler(this.ListBoxLicencePlateTagged_SelectedIndexChanged);
            this.ListBoxLicencePlateTagged.DoubleClick += new System.EventHandler(this.ListBoxLicencePlateTagged_DoubleClick);
            // 
            // TextBoxUserInput
            // 
            this.TextBoxUserInput.Location = new System.Drawing.Point(14, 28);
            this.TextBoxUserInput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TextBoxUserInput.Name = "TextBoxUserInput";
            this.TextBoxUserInput.Size = new System.Drawing.Size(132, 26);
            this.TextBoxUserInput.TabIndex = 10;
            // 
            // StatusStripMessages
            // 
            this.StatusStripMessages.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.StatusStripMessages.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripStatusLabelMessage});
            this.StatusStripMessages.Location = new System.Drawing.Point(0, 841);
            this.StatusStripMessages.Name = "StatusStripMessages";
            this.StatusStripMessages.Padding = new System.Windows.Forms.Padding(2, 0, 21, 0);
            this.StatusStripMessages.Size = new System.Drawing.Size(876, 22);
            this.StatusStripMessages.TabIndex = 11;
            this.StatusStripMessages.Text = "statusStrip1";
            // 
            // ToolStripStatusLabelMessage
            // 
            this.ToolStripStatusLabelMessage.Name = "ToolStripStatusLabelMessage";
            this.ToolStripStatusLabelMessage.Size = new System.Drawing.Size(0, 15);
            // 
            // ButtonEditLicencePlate
            // 
            this.ButtonEditLicencePlate.Location = new System.Drawing.Point(12, 25);
            this.ButtonEditLicencePlate.Name = "ButtonEditLicencePlate";
            this.ButtonEditLicencePlate.Size = new System.Drawing.Size(135, 40);
            this.ButtonEditLicencePlate.TabIndex = 12;
            this.ButtonEditLicencePlate.Text = "EDIT";
            this.ButtonEditLicencePlate.UseVisualStyleBackColor = true;
            this.ButtonEditLicencePlate.Click += new System.EventHandler(this.ButtonEditLicencePlate_Click);
            // 
            // LabelLicencePlateList1
            // 
            this.LabelLicencePlateList1.AutoSize = true;
            this.LabelLicencePlateList1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelLicencePlateList1.Location = new System.Drawing.Point(291, 200);
            this.LabelLicencePlateList1.Name = "LabelLicencePlateList1";
            this.LabelLicencePlateList1.Size = new System.Drawing.Size(89, 25);
            this.LabelLicencePlateList1.TabIndex = 13;
            this.LabelLicencePlateList1.Text = "Car Park";
            // 
            // LabelTaggedLicencePlate
            // 
            this.LabelTaggedLicencePlate.AutoSize = true;
            this.LabelTaggedLicencePlate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTaggedLicencePlate.Location = new System.Drawing.Point(634, 225);
            this.LabelTaggedLicencePlate.Name = "LabelTaggedLicencePlate";
            this.LabelTaggedLicencePlate.Size = new System.Drawing.Size(202, 25);
            this.LabelTaggedLicencePlate.TabIndex = 14;
            this.LabelTaggedLicencePlate.Text = "Tagged Licence Plate";
            // 
            // PictureBoxLogo
            // 
            this.PictureBoxLogo.Image = global::Car_Park_Tracker.Properties.Resources.logo;
            this.PictureBoxLogo.Location = new System.Drawing.Point(720, 23);
            this.PictureBoxLogo.MaximumSize = new System.Drawing.Size(150, 151);
            this.PictureBoxLogo.Name = "PictureBoxLogo";
            this.PictureBoxLogo.Size = new System.Drawing.Size(100, 100);
            this.PictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBoxLogo.TabIndex = 15;
            this.PictureBoxLogo.TabStop = false;
            // 
            // LabelTitle1
            // 
            this.LabelTitle1.AutoSize = true;
            this.LabelTitle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTitle1.Location = new System.Drawing.Point(44, 31);
            this.LabelTitle1.Name = "LabelTitle1";
            this.LabelTitle1.Size = new System.Drawing.Size(668, 79);
            this.LabelTitle1.TabIndex = 16;
            this.LabelTitle1.Text = "Active Systems PTY";
            this.LabelTitle1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // LabelTitle2
            // 
            this.LabelTitle2.AutoSize = true;
            this.LabelTitle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTitle2.Location = new System.Drawing.Point(123, 134);
            this.LabelTitle2.Name = "LabelTitle2";
            this.LabelTitle2.Size = new System.Drawing.Size(503, 46);
            this.LabelTitle2.TabIndex = 17;
            this.LabelTitle2.Text = "Licence Plate Management";
            // 
            // GroupBoxSearch
            // 
            this.GroupBoxSearch.BackColor = System.Drawing.SystemColors.Control;
            this.GroupBoxSearch.Controls.Add(this.ButtonSearchBinary);
            this.GroupBoxSearch.Controls.Add(this.ButtonSearchLinear);
            this.GroupBoxSearch.Location = new System.Drawing.Point(460, 255);
            this.GroupBoxSearch.Name = "GroupBoxSearch";
            this.GroupBoxSearch.Size = new System.Drawing.Size(160, 168);
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
            this.GroupBoxModify.Location = new System.Drawing.Point(460, 531);
            this.GroupBoxModify.Name = "GroupBoxModify";
            this.GroupBoxModify.Size = new System.Drawing.Size(160, 228);
            this.GroupBoxModify.TabIndex = 19;
            this.GroupBoxModify.TabStop = false;
            this.GroupBoxModify.Text = "MODIFY";
            // 
            // GroupBoxInput
            // 
            this.GroupBoxInput.BackColor = System.Drawing.SystemColors.Control;
            this.GroupBoxInput.Controls.Add(this.TextBoxUserInput);
            this.GroupBoxInput.Location = new System.Drawing.Point(460, 435);
            this.GroupBoxInput.Name = "GroupBoxInput";
            this.GroupBoxInput.Size = new System.Drawing.Size(160, 71);
            this.GroupBoxInput.TabIndex = 20;
            this.GroupBoxInput.TabStop = false;
            this.GroupBoxInput.Text = "INPUT";
            // 
            // GroupBoxFileControl
            // 
            this.GroupBoxFileControl.Controls.Add(this.ButtonResetData);
            this.GroupBoxFileControl.Controls.Add(this.ButtonSaveData);
            this.GroupBoxFileControl.Controls.Add(this.ButtonOpenLoadData);
            this.GroupBoxFileControl.Location = new System.Drawing.Point(44, 255);
            this.GroupBoxFileControl.Name = "GroupBoxFileControl";
            this.GroupBoxFileControl.Size = new System.Drawing.Size(166, 185);
            this.GroupBoxFileControl.TabIndex = 21;
            this.GroupBoxFileControl.TabStop = false;
            this.GroupBoxFileControl.Text = "FILE CONTROL";
            // 
            // LabelLicencePlateList2
            // 
            this.LabelLicencePlateList2.AutoSize = true;
            this.LabelLicencePlateList2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelLicencePlateList2.Location = new System.Drawing.Point(248, 225);
            this.LabelLicencePlateList2.Name = "LabelLicencePlateList2";
            this.LabelLicencePlateList2.Size = new System.Drawing.Size(167, 25);
            this.LabelLicencePlateList2.TabIndex = 22;
            this.LabelLicencePlateList2.Text = "Licence Plate Log";
            // 
            // FormCarParkTracker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 863);
            this.Controls.Add(this.LabelLicencePlateList2);
            this.Controls.Add(this.GroupBoxFileControl);
            this.Controls.Add(this.GroupBoxInput);
            this.Controls.Add(this.GroupBoxModify);
            this.Controls.Add(this.GroupBoxSearch);
            this.Controls.Add(this.LabelTitle2);
            this.Controls.Add(this.LabelTitle1);
            this.Controls.Add(this.PictureBoxLogo);
            this.Controls.Add(this.LabelTaggedLicencePlate);
            this.Controls.Add(this.LabelLicencePlateList1);
            this.Controls.Add(this.StatusStripMessages);
            this.Controls.Add(this.ListBoxLicencePlateTagged);
            this.Controls.Add(this.ListBoxLicencePlateMain);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormCarParkTracker";
            this.Text = "Active Systems PTY";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormCarParkTracker_FormClosing_1);
            this.StatusStripMessages.ResumeLayout(false);
            this.StatusStripMessages.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxLogo)).EndInit();
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
        private System.Windows.Forms.ListBox ListBoxLicencePlateMain;
        private System.Windows.Forms.ListBox ListBoxLicencePlateTagged;
        private System.Windows.Forms.TextBox TextBoxUserInput;
        private System.Windows.Forms.StatusStrip StatusStripMessages;
        private System.Windows.Forms.Button ButtonEditLicencePlate;
        private System.Windows.Forms.Label LabelLicencePlateList1;
        private System.Windows.Forms.Label LabelTaggedLicencePlate;
        private System.Windows.Forms.PictureBox PictureBoxLogo;
        private System.Windows.Forms.Label LabelTitle1;
        private System.Windows.Forms.Label LabelTitle2;
        private System.Windows.Forms.GroupBox GroupBoxSearch;
        private System.Windows.Forms.GroupBox GroupBoxModify;
        private System.Windows.Forms.GroupBox GroupBoxInput;
        private System.Windows.Forms.GroupBox GroupBoxFileControl;
        private System.Windows.Forms.Label LabelLicencePlateList2;
        private System.Windows.Forms.ToolStripStatusLabel ToolStripStatusLabelMessage;
        private System.Windows.Forms.ToolTip ToolTip;
    }
}

