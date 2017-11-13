﻿namespace MedClerk.Views
{
    partial class PatientManagementView
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
            this.btn_OpenMenu = new System.Windows.Forms.Button();
            this.btn_SearchPatients = new System.Windows.Forms.Button();
            this.btn_AddPatient = new System.Windows.Forms.Button();
            this.lbl_patientsManagementTitle = new System.Windows.Forms.Label();
            this.txtbx_AddNameField = new System.Windows.Forms.TextBox();
            this.txtbx_AddAddressField = new System.Windows.Forms.TextBox();
            this.lbl_AddName = new System.Windows.Forms.Label();
            this.lbl_AddAddress = new System.Windows.Forms.Label();
            this.lbl_AddDob = new System.Windows.Forms.Label();
            this.txtbx_AddDobField = new System.Windows.Forms.TextBox();
            this.dGrid_SearchPatientResults = new System.Windows.Forms.DataGridView();
            this.lbl_SearchPatientNameField = new System.Windows.Forms.Label();
            this.lbl_SearchAddess = new System.Windows.Forms.Label();
            this.lbl_SearchPatientId = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.txtbx_SearchAddressField = new System.Windows.Forms.TextBox();
            this.txtbx_SearchPatientIdField = new System.Windows.Forms.TextBox();
            this.lbl_SearchDob = new System.Windows.Forms.Label();
            this.txtbx_SearchDobField = new System.Windows.Forms.TextBox();
            this.lbl_SearchPatientsTitle = new System.Windows.Forms.Label();
            this.lbl_patientsManagementInstructions = new System.Windows.Forms.Label();
            this.lbl_SearchPatientsInstructions = new System.Windows.Forms.Label();
            this.btn_ViewPatientProfile = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dGrid_SearchPatientResults)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_OpenMenu
            // 
            this.btn_OpenMenu.Location = new System.Drawing.Point(13, 448);
            this.btn_OpenMenu.Name = "btn_OpenMenu";
            this.btn_OpenMenu.Size = new System.Drawing.Size(75, 23);
            this.btn_OpenMenu.TabIndex = 0;
            this.btn_OpenMenu.Text = "Menu";
            this.btn_OpenMenu.UseVisualStyleBackColor = true;
            this.btn_OpenMenu.Click += new System.EventHandler(this.btn_OpenMenu_Click);
            // 
            // btn_SearchPatients
            // 
            this.btn_SearchPatients.Location = new System.Drawing.Point(603, 192);
            this.btn_SearchPatients.Name = "btn_SearchPatients";
            this.btn_SearchPatients.Size = new System.Drawing.Size(75, 23);
            this.btn_SearchPatients.TabIndex = 1;
            this.btn_SearchPatients.Text = "Search";
            this.btn_SearchPatients.UseVisualStyleBackColor = true;
            // 
            // btn_AddPatient
            // 
            this.btn_AddPatient.Location = new System.Drawing.Point(603, 83);
            this.btn_AddPatient.Name = "btn_AddPatient";
            this.btn_AddPatient.Size = new System.Drawing.Size(75, 23);
            this.btn_AddPatient.TabIndex = 2;
            this.btn_AddPatient.Text = "Add";
            this.btn_AddPatient.UseVisualStyleBackColor = true;
            // 
            // lbl_patientsManagementTitle
            // 
            this.lbl_patientsManagementTitle.AutoSize = true;
            this.lbl_patientsManagementTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_patientsManagementTitle.Location = new System.Drawing.Point(13, 13);
            this.lbl_patientsManagementTitle.Name = "lbl_patientsManagementTitle";
            this.lbl_patientsManagementTitle.Size = new System.Drawing.Size(226, 20);
            this.lbl_patientsManagementTitle.TabIndex = 4;
            this.lbl_patientsManagementTitle.Text = "Patients Management: Add";
            // 
            // txtbx_AddNameField
            // 
            this.txtbx_AddNameField.Location = new System.Drawing.Point(80, 54);
            this.txtbx_AddNameField.Name = "txtbx_AddNameField";
            this.txtbx_AddNameField.Size = new System.Drawing.Size(181, 20);
            this.txtbx_AddNameField.TabIndex = 6;
            // 
            // txtbx_AddAddressField
            // 
            this.txtbx_AddAddressField.Location = new System.Drawing.Point(329, 54);
            this.txtbx_AddAddressField.Name = "txtbx_AddAddressField";
            this.txtbx_AddAddressField.Size = new System.Drawing.Size(349, 20);
            this.txtbx_AddAddressField.TabIndex = 7;
            // 
            // lbl_AddName
            // 
            this.lbl_AddName.AutoSize = true;
            this.lbl_AddName.Location = new System.Drawing.Point(15, 57);
            this.lbl_AddName.Name = "lbl_AddName";
            this.lbl_AddName.Size = new System.Drawing.Size(35, 13);
            this.lbl_AddName.TabIndex = 9;
            this.lbl_AddName.Text = "Name";
            // 
            // lbl_AddAddress
            // 
            this.lbl_AddAddress.AutoSize = true;
            this.lbl_AddAddress.Location = new System.Drawing.Point(278, 57);
            this.lbl_AddAddress.Name = "lbl_AddAddress";
            this.lbl_AddAddress.Size = new System.Drawing.Size(45, 13);
            this.lbl_AddAddress.TabIndex = 10;
            this.lbl_AddAddress.Text = "Address";
            // 
            // lbl_AddDob
            // 
            this.lbl_AddDob.AutoSize = true;
            this.lbl_AddDob.Location = new System.Drawing.Point(15, 83);
            this.lbl_AddDob.Name = "lbl_AddDob";
            this.lbl_AddDob.Size = new System.Drawing.Size(30, 13);
            this.lbl_AddDob.TabIndex = 11;
            this.lbl_AddDob.Text = "DOB";
            // 
            // txtbx_AddDobField
            // 
            this.txtbx_AddDobField.Location = new System.Drawing.Point(80, 80);
            this.txtbx_AddDobField.Name = "txtbx_AddDobField";
            this.txtbx_AddDobField.Size = new System.Drawing.Size(181, 20);
            this.txtbx_AddDobField.TabIndex = 8;
            // 
            // dGrid_SearchPatientResults
            // 
            this.dGrid_SearchPatientResults.AllowUserToAddRows = false;
            this.dGrid_SearchPatientResults.AllowUserToDeleteRows = false;
            this.dGrid_SearchPatientResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGrid_SearchPatientResults.Location = new System.Drawing.Point(13, 251);
            this.dGrid_SearchPatientResults.Name = "dGrid_SearchPatientResults";
            this.dGrid_SearchPatientResults.ReadOnly = true;
            this.dGrid_SearchPatientResults.Size = new System.Drawing.Size(663, 191);
            this.dGrid_SearchPatientResults.TabIndex = 12;
            // 
            // lbl_SearchPatientNameField
            // 
            this.lbl_SearchPatientNameField.AutoSize = true;
            this.lbl_SearchPatientNameField.Location = new System.Drawing.Point(15, 228);
            this.lbl_SearchPatientNameField.Name = "lbl_SearchPatientNameField";
            this.lbl_SearchPatientNameField.Size = new System.Drawing.Size(35, 13);
            this.lbl_SearchPatientNameField.TabIndex = 18;
            this.lbl_SearchPatientNameField.Text = "Name";
            // 
            // lbl_SearchAddess
            // 
            this.lbl_SearchAddess.AutoSize = true;
            this.lbl_SearchAddess.Location = new System.Drawing.Point(278, 228);
            this.lbl_SearchAddess.Name = "lbl_SearchAddess";
            this.lbl_SearchAddess.Size = new System.Drawing.Size(45, 13);
            this.lbl_SearchAddess.TabIndex = 17;
            this.lbl_SearchAddess.Text = "Address";
            // 
            // lbl_SearchPatientId
            // 
            this.lbl_SearchPatientId.AutoSize = true;
            this.lbl_SearchPatientId.Location = new System.Drawing.Point(15, 202);
            this.lbl_SearchPatientId.Name = "lbl_SearchPatientId";
            this.lbl_SearchPatientId.Size = new System.Drawing.Size(18, 13);
            this.lbl_SearchPatientId.TabIndex = 16;
            this.lbl_SearchPatientId.Text = "ID";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(80, 225);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(129, 20);
            this.textBox4.TabIndex = 15;
            // 
            // txtbx_SearchAddressField
            // 
            this.txtbx_SearchAddressField.Location = new System.Drawing.Point(329, 225);
            this.txtbx_SearchAddressField.Name = "txtbx_SearchAddressField";
            this.txtbx_SearchAddressField.Size = new System.Drawing.Size(349, 20);
            this.txtbx_SearchAddressField.TabIndex = 14;
            // 
            // txtbx_SearchPatientIdField
            // 
            this.txtbx_SearchPatientIdField.Location = new System.Drawing.Point(80, 199);
            this.txtbx_SearchPatientIdField.Name = "txtbx_SearchPatientIdField";
            this.txtbx_SearchPatientIdField.Size = new System.Drawing.Size(50, 20);
            this.txtbx_SearchPatientIdField.TabIndex = 13;
            // 
            // lbl_SearchDob
            // 
            this.lbl_SearchDob.AutoSize = true;
            this.lbl_SearchDob.Location = new System.Drawing.Point(278, 202);
            this.lbl_SearchDob.Name = "lbl_SearchDob";
            this.lbl_SearchDob.Size = new System.Drawing.Size(30, 13);
            this.lbl_SearchDob.TabIndex = 20;
            this.lbl_SearchDob.Text = "DOB";
            // 
            // txtbx_SearchDobField
            // 
            this.txtbx_SearchDobField.Location = new System.Drawing.Point(329, 199);
            this.txtbx_SearchDobField.Name = "txtbx_SearchDobField";
            this.txtbx_SearchDobField.Size = new System.Drawing.Size(129, 20);
            this.txtbx_SearchDobField.TabIndex = 19;
            // 
            // lbl_SearchPatientsTitle
            // 
            this.lbl_SearchPatientsTitle.AutoSize = true;
            this.lbl_SearchPatientsTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SearchPatientsTitle.Location = new System.Drawing.Point(12, 140);
            this.lbl_SearchPatientsTitle.Name = "lbl_SearchPatientsTitle";
            this.lbl_SearchPatientsTitle.Size = new System.Drawing.Size(251, 20);
            this.lbl_SearchPatientsTitle.TabIndex = 21;
            this.lbl_SearchPatientsTitle.Text = "Patients Management: Search";
            // 
            // lbl_patientsManagementInstructions
            // 
            this.lbl_patientsManagementInstructions.AutoSize = true;
            this.lbl_patientsManagementInstructions.Location = new System.Drawing.Point(14, 33);
            this.lbl_patientsManagementInstructions.Name = "lbl_patientsManagementInstructions";
            this.lbl_patientsManagementInstructions.Size = new System.Drawing.Size(612, 13);
            this.lbl_patientsManagementInstructions.TabIndex = 22;
            this.lbl_patientsManagementInstructions.Text = "To add a new patient, fill out all required fields. The date must be in DD/MM/YYY" +
    "Y format. Address should be comma seperated.";
            // 
            // lbl_SearchPatientsInstructions
            // 
            this.lbl_SearchPatientsInstructions.AutoSize = true;
            this.lbl_SearchPatientsInstructions.Location = new System.Drawing.Point(12, 163);
            this.lbl_SearchPatientsInstructions.MaximumSize = new System.Drawing.Size(650, 0);
            this.lbl_SearchPatientsInstructions.Name = "lbl_SearchPatientsInstructions";
            this.lbl_SearchPatientsInstructions.Size = new System.Drawing.Size(646, 26);
            this.lbl_SearchPatientsInstructions.TabIndex = 23;
            this.lbl_SearchPatientsInstructions.Text = "To locate a patients details, please enter an ID, name and DOB, or name and addre" +
    "ss to search by. Highlight a patient and select \'View Profile\' to open the patie" +
    "nts profile.";
            // 
            // btn_ViewPatientProfile
            // 
            this.btn_ViewPatientProfile.Location = new System.Drawing.Point(603, 448);
            this.btn_ViewPatientProfile.Name = "btn_ViewPatientProfile";
            this.btn_ViewPatientProfile.Size = new System.Drawing.Size(75, 23);
            this.btn_ViewPatientProfile.TabIndex = 24;
            this.btn_ViewPatientProfile.Text = "View Profile";
            this.btn_ViewPatientProfile.UseVisualStyleBackColor = true;
            // 
            // PatientManagementView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 483);
            this.Controls.Add(this.btn_ViewPatientProfile);
            this.Controls.Add(this.lbl_SearchPatientsInstructions);
            this.Controls.Add(this.lbl_patientsManagementInstructions);
            this.Controls.Add(this.lbl_SearchPatientsTitle);
            this.Controls.Add(this.lbl_SearchDob);
            this.Controls.Add(this.txtbx_SearchDobField);
            this.Controls.Add(this.lbl_SearchPatientNameField);
            this.Controls.Add(this.lbl_SearchAddess);
            this.Controls.Add(this.lbl_SearchPatientId);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.txtbx_SearchAddressField);
            this.Controls.Add(this.txtbx_SearchPatientIdField);
            this.Controls.Add(this.dGrid_SearchPatientResults);
            this.Controls.Add(this.lbl_AddDob);
            this.Controls.Add(this.lbl_AddAddress);
            this.Controls.Add(this.lbl_AddName);
            this.Controls.Add(this.txtbx_AddDobField);
            this.Controls.Add(this.txtbx_AddAddressField);
            this.Controls.Add(this.txtbx_AddNameField);
            this.Controls.Add(this.lbl_patientsManagementTitle);
            this.Controls.Add(this.btn_AddPatient);
            this.Controls.Add(this.btn_SearchPatients);
            this.Controls.Add(this.btn_OpenMenu);
            this.Name = "PatientManagementView";
            this.Text = "Patient Management";
            ((System.ComponentModel.ISupportInitialize)(this.dGrid_SearchPatientResults)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_OpenMenu;
        private System.Windows.Forms.Button btn_SearchPatients;
        private System.Windows.Forms.Button btn_AddPatient;
        private System.Windows.Forms.Label lbl_patientsManagementTitle;
        private System.Windows.Forms.TextBox txtbx_AddNameField;
        private System.Windows.Forms.TextBox txtbx_AddAddressField;
        private System.Windows.Forms.Label lbl_AddName;
        private System.Windows.Forms.Label lbl_AddAddress;
        private System.Windows.Forms.Label lbl_AddDob;
        private System.Windows.Forms.TextBox txtbx_AddDobField;
        private System.Windows.Forms.DataGridView dGrid_SearchPatientResults;
        private System.Windows.Forms.Label lbl_SearchPatientNameField;
        private System.Windows.Forms.Label lbl_SearchAddess;
        private System.Windows.Forms.Label lbl_SearchPatientId;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox txtbx_SearchAddressField;
        private System.Windows.Forms.TextBox txtbx_SearchPatientIdField;
        private System.Windows.Forms.Label lbl_SearchDob;
        private System.Windows.Forms.TextBox txtbx_SearchDobField;
        private System.Windows.Forms.Label lbl_SearchPatientsTitle;
        private System.Windows.Forms.Label lbl_patientsManagementInstructions;
        private System.Windows.Forms.Label lbl_SearchPatientsInstructions;
        private System.Windows.Forms.Button btn_ViewPatientProfile;
    }
}