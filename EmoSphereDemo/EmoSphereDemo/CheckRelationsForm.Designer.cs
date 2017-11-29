namespace EmoSphereDemo
{
    partial class CheckRelationsForm
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
            this.lblRelation1 = new System.Windows.Forms.Label();
            this.lblRelation2 = new System.Windows.Forms.Label();
            this.lblRelation3 = new System.Windows.Forms.Label();
            this.tbRelation3 = new System.Windows.Forms.TrackBar();
            this.tbRelation2 = new System.Windows.Forms.TrackBar();
            this.tbRelation1 = new System.Windows.Forms.TrackBar();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tbRelation3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbRelation2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbRelation1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRelation1
            // 
            this.lblRelation1.AutoSize = true;
            this.lblRelation1.Location = new System.Drawing.Point(12, 29);
            this.lblRelation1.Name = "lblRelation1";
            this.lblRelation1.Size = new System.Drawing.Size(47, 13);
            this.lblRelation1.TabIndex = 0;
            this.lblRelation1.Text = "-relation-";
            // 
            // lblRelation2
            // 
            this.lblRelation2.AutoSize = true;
            this.lblRelation2.Location = new System.Drawing.Point(12, 96);
            this.lblRelation2.Name = "lblRelation2";
            this.lblRelation2.Size = new System.Drawing.Size(47, 13);
            this.lblRelation2.TabIndex = 1;
            this.lblRelation2.Text = "-relation-";
            // 
            // lblRelation3
            // 
            this.lblRelation3.AutoSize = true;
            this.lblRelation3.Location = new System.Drawing.Point(12, 170);
            this.lblRelation3.Name = "lblRelation3";
            this.lblRelation3.Size = new System.Drawing.Size(47, 13);
            this.lblRelation3.TabIndex = 2;
            this.lblRelation3.Text = "-relation-";
            // 
            // tbRelation3
            // 
            this.tbRelation3.Enabled = false;
            this.tbRelation3.Location = new System.Drawing.Point(15, 186);
            this.tbRelation3.Maximum = 100;
            this.tbRelation3.Minimum = -100;
            this.tbRelation3.Name = "tbRelation3";
            this.tbRelation3.Size = new System.Drawing.Size(334, 45);
            this.tbRelation3.TabIndex = 3;
            // 
            // tbRelation2
            // 
            this.tbRelation2.Enabled = false;
            this.tbRelation2.Location = new System.Drawing.Point(15, 112);
            this.tbRelation2.Maximum = 100;
            this.tbRelation2.Minimum = -100;
            this.tbRelation2.Name = "tbRelation2";
            this.tbRelation2.Size = new System.Drawing.Size(334, 45);
            this.tbRelation2.TabIndex = 4;
            // 
            // tbRelation1
            // 
            this.tbRelation1.Enabled = false;
            this.tbRelation1.Location = new System.Drawing.Point(15, 45);
            this.tbRelation1.Maximum = 100;
            this.tbRelation1.Minimum = -100;
            this.tbRelation1.Name = "tbRelation1";
            this.tbRelation1.Size = new System.Drawing.Size(334, 45);
            this.tbRelation1.TabIndex = 5;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(12, 248);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(112, 41);
            this.btnBack.TabIndex = 6;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // CheckRelationsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 304);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.tbRelation1);
            this.Controls.Add(this.tbRelation2);
            this.Controls.Add(this.tbRelation3);
            this.Controls.Add(this.lblRelation3);
            this.Controls.Add(this.lblRelation2);
            this.Controls.Add(this.lblRelation1);
            this.Name = "CheckRelationsForm";
            this.Text = "CheckRelationsForm";
            ((System.ComponentModel.ISupportInitialize)(this.tbRelation3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbRelation2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbRelation1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRelation1;
        private System.Windows.Forms.Label lblRelation2;
        private System.Windows.Forms.Label lblRelation3;
        private System.Windows.Forms.TrackBar tbRelation3;
        private System.Windows.Forms.TrackBar tbRelation2;
        private System.Windows.Forms.TrackBar tbRelation1;
        private System.Windows.Forms.Button btnBack;
    }
}