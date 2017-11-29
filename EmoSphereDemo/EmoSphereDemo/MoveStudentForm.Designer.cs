namespace EmoSphereDemo
{
    partial class MoveStudentForm
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
            this.cbStudents = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nudChairIndex = new System.Windows.Forms.NumericUpDown();
            this.btnConfirm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudChairIndex)).BeginInit();
            this.SuspendLayout();
            // 
            // cbStudents
            // 
            this.cbStudents.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStudents.FormattingEnabled = true;
            this.cbStudents.Location = new System.Drawing.Point(12, 41);
            this.cbStudents.Name = "cbStudents";
            this.cbStudents.Size = new System.Drawing.Size(176, 21);
            this.cbStudents.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Who do you want to move?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "To where?";
            // 
            // nudChairIndex
            // 
            this.nudChairIndex.Location = new System.Drawing.Point(12, 100);
            this.nudChairIndex.Maximum = new decimal(new int[] {
            18,
            0,
            0,
            0});
            this.nudChairIndex.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudChairIndex.Name = "nudChairIndex";
            this.nudChairIndex.Size = new System.Drawing.Size(120, 20);
            this.nudChairIndex.TabIndex = 3;
            this.nudChairIndex.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(16, 137);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(172, 44);
            this.btnConfirm.TabIndex = 4;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // MoveStudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(207, 192);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.nudChairIndex);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbStudents);
            this.Name = "MoveStudentForm";
            this.Text = "MoveStudentForm";
            ((System.ComponentModel.ISupportInitialize)(this.nudChairIndex)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbStudents;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudChairIndex;
        private System.Windows.Forms.Button btnConfirm;
    }
}