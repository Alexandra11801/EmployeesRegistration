
namespace EmployeesRegistration.Forms
{
    partial class StatisticsForm
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
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.periodBox = new System.Windows.Forms.ComboBox();
            this.departmentBox = new System.Windows.Forms.ComboBox();
            this.showStatisticsButton = new System.Windows.Forms.Button();
            this.recruitedLabel = new System.Windows.Forms.Label();
            this.firedLabel = new System.Windows.Forms.Label();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.backButton.Location = new System.Drawing.Point(12, 29);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(50, 40);
            this.backButton.TabIndex = 6;
            this.backButton.Text = "←";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoScroll = true;
            this.flowLayoutPanel2.Controls.Add(this.flowLayoutPanel1);
            this.flowLayoutPanel2.Controls.Add(this.recruitedLabel);
            this.flowLayoutPanel2.Controls.Add(this.firedLabel);
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(83, 28);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(677, 387);
            this.flowLayoutPanel2.TabIndex = 2;
            this.flowLayoutPanel2.WrapContents = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel1.Controls.Add(this.periodBox);
            this.flowLayoutPanel1.Controls.Add(this.departmentBox);
            this.flowLayoutPanel1.Controls.Add(this.showStatisticsButton);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 30);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(586, 69);
            this.flowLayoutPanel1.TabIndex = 0;
            this.flowLayoutPanel1.WrapContents = false;
            // 
            // periodBox
            // 
            this.periodBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.periodBox.FormattingEnabled = true;
            this.periodBox.Items.AddRange(new object[] {
            "Всё время",
            "Месяц",
            "Год"});
            this.periodBox.Location = new System.Drawing.Point(3, 3);
            this.periodBox.Name = "periodBox";
            this.periodBox.Size = new System.Drawing.Size(172, 33);
            this.periodBox.TabIndex = 0;
            // 
            // departmentBox
            // 
            this.departmentBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.departmentBox.FormattingEnabled = true;
            this.departmentBox.Items.AddRange(new object[] {
            "Все подразделения"});
            this.departmentBox.Location = new System.Drawing.Point(181, 3);
            this.departmentBox.Name = "departmentBox";
            this.departmentBox.Size = new System.Drawing.Size(231, 33);
            this.departmentBox.TabIndex = 1;
            // 
            // showStatisticsButton
            // 
            this.showStatisticsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.showStatisticsButton.Location = new System.Drawing.Point(418, 3);
            this.showStatisticsButton.Name = "showStatisticsButton";
            this.showStatisticsButton.Size = new System.Drawing.Size(165, 33);
            this.showStatisticsButton.TabIndex = 2;
            this.showStatisticsButton.Text = "Статистика";
            this.showStatisticsButton.UseVisualStyleBackColor = true;
            this.showStatisticsButton.Click += new System.EventHandler(this.showStatisticsButton_Click);
            // 
            // recruitedLabel
            // 
            this.recruitedLabel.AutoSize = true;
            this.recruitedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.recruitedLabel.Location = new System.Drawing.Point(3, 75);
            this.recruitedLabel.Name = "recruitedLabel";
            this.recruitedLabel.Padding = new System.Windows.Forms.Padding(0, 0, 0, 15);
            this.recruitedLabel.Size = new System.Drawing.Size(120, 44);
            this.recruitedLabel.TabIndex = 1;
            this.recruitedLabel.Text = "Принято:";
            // 
            // firedLabel
            // 
            this.firedLabel.AutoSize = true;
            this.firedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.firedLabel.Location = new System.Drawing.Point(3, 119);
            this.firedLabel.Name = "firedLabel";
            this.firedLabel.Padding = new System.Windows.Forms.Padding(0, 0, 0, 15);
            this.firedLabel.Size = new System.Drawing.Size(121, 44);
            this.firedLabel.TabIndex = 2;
            this.firedLabel.Text = "Уволено:";
            // 
            // StatisticsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Name = "StatisticsForm";
            this.Text = "Employees Registration";
            this.Load += new System.EventHandler(this.StatisticsForm_Load);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.ComboBox periodBox;
        private System.Windows.Forms.ComboBox departmentBox;
        private System.Windows.Forms.Button showStatisticsButton;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label recruitedLabel;
        private System.Windows.Forms.Label firedLabel;
        private System.Windows.Forms.Button backButton;
    }
}