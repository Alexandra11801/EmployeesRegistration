
namespace EmployeesRegistration.Forms
{
    partial class EmployeeForm
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
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.nameLabel = new System.Windows.Forms.Label();
            this.personnelNumberLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.departmentLink = new System.Windows.Forms.LinkLabel();
            this.emailLabel = new System.Windows.Forms.Label();
            this.phoneNumberLabel = new System.Windows.Forms.Label();
            this.recruitDateLabel = new System.Windows.Forms.Label();
            this.fireDateLabel = new System.Windows.Forms.Label();
            this.statusLabel = new System.Windows.Forms.Label();
            this.buttonsPanel = new System.Windows.Forms.Panel();
            this.fireButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.flowLayoutPanel.SuspendLayout();
            this.buttonsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.AutoScroll = true;
            this.flowLayoutPanel.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel.Controls.Add(this.nameLabel);
            this.flowLayoutPanel.Controls.Add(this.personnelNumberLabel);
            this.flowLayoutPanel.Controls.Add(this.titleLabel);
            this.flowLayoutPanel.Controls.Add(this.departmentLink);
            this.flowLayoutPanel.Controls.Add(this.emailLabel);
            this.flowLayoutPanel.Controls.Add(this.phoneNumberLabel);
            this.flowLayoutPanel.Controls.Add(this.recruitDateLabel);
            this.flowLayoutPanel.Controls.Add(this.fireDateLabel);
            this.flowLayoutPanel.Controls.Add(this.statusLabel);
            this.flowLayoutPanel.Controls.Add(this.buttonsPanel);
            this.flowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.flowLayoutPanel.Location = new System.Drawing.Point(69, -1);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.flowLayoutPanel.Size = new System.Drawing.Size(730, 454);
            this.flowLayoutPanel.TabIndex = 0;
            this.flowLayoutPanel.WrapContents = false;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.nameLabel.Location = new System.Drawing.Point(33, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Padding = new System.Windows.Forms.Padding(0, 30, 0, 15);
            this.nameLabel.Size = new System.Drawing.Size(89, 81);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "ФИО";
            // 
            // personnelNumberLabel
            // 
            this.personnelNumberLabel.AutoSize = true;
            this.personnelNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.personnelNumberLabel.Location = new System.Drawing.Point(33, 81);
            this.personnelNumberLabel.Name = "personnelNumberLabel";
            this.personnelNumberLabel.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.personnelNumberLabel.Size = new System.Drawing.Size(191, 35);
            this.personnelNumberLabel.TabIndex = 1;
            this.personnelNumberLabel.Text = "Табельный номер: ";
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.titleLabel.Location = new System.Drawing.Point(33, 116);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.titleLabel.Size = new System.Drawing.Size(129, 35);
            this.titleLabel.TabIndex = 2;
            this.titleLabel.Text = "Должность:";
            // 
            // departmentLink
            // 
            this.departmentLink.AutoSize = true;
            this.departmentLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.departmentLink.LinkColor = System.Drawing.Color.Black;
            this.departmentLink.Location = new System.Drawing.Point(33, 151);
            this.departmentLink.Name = "departmentLink";
            this.departmentLink.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.departmentLink.Size = new System.Drawing.Size(171, 35);
            this.departmentLink.TabIndex = 3;
            this.departmentLink.TabStop = true;
            this.departmentLink.Text = "Подразделение: ";
            this.departmentLink.VisitedLinkColor = System.Drawing.Color.Black;
            this.departmentLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.departmentLink_LinkClicked);
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.emailLabel.Location = new System.Drawing.Point(33, 186);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.emailLabel.Size = new System.Drawing.Size(66, 35);
            this.emailLabel.TabIndex = 4;
            this.emailLabel.Text = "Email:";
            // 
            // phoneNumberLabel
            // 
            this.phoneNumberLabel.AutoSize = true;
            this.phoneNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.phoneNumberLabel.Location = new System.Drawing.Point(33, 221);
            this.phoneNumberLabel.Name = "phoneNumberLabel";
            this.phoneNumberLabel.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.phoneNumberLabel.Size = new System.Drawing.Size(105, 35);
            this.phoneNumberLabel.TabIndex = 5;
            this.phoneNumberLabel.Text = "Телефон:";
            // 
            // recruitDateLabel
            // 
            this.recruitDateLabel.AutoSize = true;
            this.recruitDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.recruitDateLabel.Location = new System.Drawing.Point(33, 256);
            this.recruitDateLabel.Name = "recruitDateLabel";
            this.recruitDateLabel.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.recruitDateLabel.Size = new System.Drawing.Size(143, 35);
            this.recruitDateLabel.TabIndex = 6;
            this.recruitDateLabel.Text = "Дата приёма:";
            // 
            // fireDateLabel
            // 
            this.fireDateLabel.AutoSize = true;
            this.fireDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.fireDateLabel.Location = new System.Drawing.Point(33, 291);
            this.fireDateLabel.Name = "fireDateLabel";
            this.fireDateLabel.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.fireDateLabel.Size = new System.Drawing.Size(179, 35);
            this.fireDateLabel.TabIndex = 7;
            this.fireDateLabel.Text = "Дата увольнения:";
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.statusLabel.Location = new System.Drawing.Point(33, 326);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Padding = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.statusLabel.Size = new System.Drawing.Size(188, 45);
            this.statusLabel.TabIndex = 8;
            this.statusLabel.Text = "Состояние записи:";
            // 
            // buttonsPanel
            // 
            this.buttonsPanel.Controls.Add(this.fireButton);
            this.buttonsPanel.Controls.Add(this.editButton);
            this.buttonsPanel.Location = new System.Drawing.Point(33, 374);
            this.buttonsPanel.Name = "buttonsPanel";
            this.buttonsPanel.Size = new System.Drawing.Size(567, 51);
            this.buttonsPanel.TabIndex = 11;
            // 
            // fireButton
            // 
            this.fireButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.fireButton.Location = new System.Drawing.Point(289, 3);
            this.fireButton.Name = "fireButton";
            this.fireButton.Size = new System.Drawing.Size(240, 42);
            this.fireButton.TabIndex = 9;
            this.fireButton.Text = "Уволить сотрудника";
            this.fireButton.UseVisualStyleBackColor = true;
            this.fireButton.Click += new System.EventHandler(this.fireButton_Click);
            // 
            // editButton
            // 
            this.editButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.editButton.Location = new System.Drawing.Point(0, 3);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(283, 42);
            this.editButton.TabIndex = 10;
            this.editButton.Text = "Редактировать запись";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.White;
            this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.backButton.Location = new System.Drawing.Point(12, 12);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(50, 40);
            this.backButton.TabIndex = 1;
            this.backButton.Text = "←";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.flowLayoutPanel);
            this.Name = "EmployeeForm";
            this.Text = "Employees Registration";
            this.Load += new System.EventHandler(this.EmployeeForm_Load);
            this.flowLayoutPanel.ResumeLayout(false);
            this.flowLayoutPanel.PerformLayout();
            this.buttonsPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label personnelNumberLabel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.LinkLabel departmentLink;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label phoneNumberLabel;
        private System.Windows.Forms.Label recruitDateLabel;
        private System.Windows.Forms.Label fireDateLabel;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button fireButton;
        private System.Windows.Forms.Panel buttonsPanel;
        private System.Windows.Forms.Button editButton;
    }
}