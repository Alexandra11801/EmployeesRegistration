
namespace EmployeesRegistration.Forms
{
    partial class DepartmentForm
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
            this.backButton = new System.Windows.Forms.Button();
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.nameLabel = new System.Windows.Forms.Label();
            this.headDepartmentLink = new System.Windows.Forms.LinkLabel();
            this.headLink = new System.Windows.Forms.LinkLabel();
            this.employeesLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.statusLabel = new System.Windows.Forms.Label();
            this.buttonsPanel = new System.Windows.Forms.Panel();
            this.deleteButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.flowLayoutPanel.SuspendLayout();
            this.employeesLayoutPanel.SuspendLayout();
            this.buttonsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.White;
            this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.backButton.Location = new System.Drawing.Point(7, 11);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(50, 40);
            this.backButton.TabIndex = 3;
            this.backButton.Text = "←";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.AutoScroll = true;
            this.flowLayoutPanel.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel.Controls.Add(this.nameLabel);
            this.flowLayoutPanel.Controls.Add(this.headDepartmentLink);
            this.flowLayoutPanel.Controls.Add(this.headLink);
            this.flowLayoutPanel.Controls.Add(this.employeesLayoutPanel);
            this.flowLayoutPanel.Controls.Add(this.statusLabel);
            this.flowLayoutPanel.Controls.Add(this.buttonsPanel);
            this.flowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.flowLayoutPanel.Location = new System.Drawing.Point(64, -2);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.flowLayoutPanel.Size = new System.Drawing.Size(730, 454);
            this.flowLayoutPanel.TabIndex = 2;
            this.flowLayoutPanel.WrapContents = false;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.nameLabel.Location = new System.Drawing.Point(33, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Padding = new System.Windows.Forms.Padding(0, 30, 0, 15);
            this.nameLabel.Size = new System.Drawing.Size(154, 81);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Название";
            // 
            // headDepartmentLink
            // 
            this.headDepartmentLink.AutoSize = true;
            this.headDepartmentLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.headDepartmentLink.LinkColor = System.Drawing.Color.Black;
            this.headDepartmentLink.Location = new System.Drawing.Point(33, 81);
            this.headDepartmentLink.Name = "headDepartmentLink";
            this.headDepartmentLink.Padding = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.headDepartmentLink.Size = new System.Drawing.Size(257, 45);
            this.headDepartmentLink.TabIndex = 12;
            this.headDepartmentLink.TabStop = true;
            this.headDepartmentLink.Text = "Головное подразделение:";
            this.headDepartmentLink.VisitedLinkColor = System.Drawing.Color.Black;
            this.headDepartmentLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.headDepartmentLink_LinkClicked);
            // 
            // headLink
            // 
            this.headLink.AutoSize = true;
            this.headLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.headLink.LinkColor = System.Drawing.Color.Black;
            this.headLink.Location = new System.Drawing.Point(33, 126);
            this.headLink.Name = "headLink";
            this.headLink.Padding = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.headLink.Size = new System.Drawing.Size(149, 45);
            this.headLink.TabIndex = 13;
            this.headLink.TabStop = true;
            this.headLink.Text = "Руководитель:";
            this.headLink.VisitedLinkColor = System.Drawing.Color.Black;
            this.headLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.headLink_LinkClicked);
            // 
            // employeesLayoutPanel
            // 
            this.employeesLayoutPanel.AutoSize = true;
            this.employeesLayoutPanel.Controls.Add(this.label1);
            this.employeesLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.employeesLayoutPanel.Location = new System.Drawing.Point(33, 174);
            this.employeesLayoutPanel.Name = "employeesLayoutPanel";
            this.employeesLayoutPanel.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.employeesLayoutPanel.Size = new System.Drawing.Size(135, 45);
            this.employeesLayoutPanel.TabIndex = 14;
            this.employeesLayoutPanel.WrapContents = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.label1.Size = new System.Drawing.Size(129, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Сотрудники:";
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.statusLabel.Location = new System.Drawing.Point(33, 222);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Padding = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.statusLabel.Size = new System.Drawing.Size(188, 45);
            this.statusLabel.TabIndex = 8;
            this.statusLabel.Text = "Состояние записи:";
            // 
            // buttonsPanel
            // 
            this.buttonsPanel.Controls.Add(this.deleteButton);
            this.buttonsPanel.Controls.Add(this.editButton);
            this.buttonsPanel.Location = new System.Drawing.Point(33, 270);
            this.buttonsPanel.Name = "buttonsPanel";
            this.buttonsPanel.Size = new System.Drawing.Size(577, 51);
            this.buttonsPanel.TabIndex = 11;
            // 
            // deleteButton
            // 
            this.deleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.deleteButton.Location = new System.Drawing.Point(277, 3);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(295, 42);
            this.deleteButton.TabIndex = 11;
            this.deleteButton.Text = "Удалить подразделение";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // editButton
            // 
            this.editButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.editButton.Location = new System.Drawing.Point(0, 3);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(271, 42);
            this.editButton.TabIndex = 10;
            this.editButton.Text = "Редактировать запись";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // DepartmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.flowLayoutPanel);
            this.Name = "DepartmentForm";
            this.Text = "Employees Registartion";
            this.Load += new System.EventHandler(this.DepartmentForm_Load);
            this.flowLayoutPanel.ResumeLayout(false);
            this.flowLayoutPanel.PerformLayout();
            this.employeesLayoutPanel.ResumeLayout(false);
            this.employeesLayoutPanel.PerformLayout();
            this.buttonsPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Panel buttonsPanel;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.LinkLabel headDepartmentLink;
        private System.Windows.Forms.LinkLabel headLink;
        private System.Windows.Forms.FlowLayoutPanel employeesLayoutPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button deleteButton;
    }
}