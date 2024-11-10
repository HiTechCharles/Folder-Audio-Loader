namespace Workout_Videos_for_Tiffany
{
    partial class TWV
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
            this.FileListLB = new System.Windows.Forms.ListBox();
            this.WorkoutLBL = new System.Windows.Forms.Label();
            this.OKBTN = new System.Windows.Forms.Button();
            this.RandomBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FileListLB
            // 
            this.FileListLB.FormattingEnabled = true;
            this.FileListLB.ItemHeight = 39;
            this.FileListLB.Location = new System.Drawing.Point(12, 58);
            this.FileListLB.Name = "FileListLB";
            this.FileListLB.Size = new System.Drawing.Size(556, 433);
            this.FileListLB.Sorted = true;
            this.FileListLB.TabIndex = 1;
            this.FileListLB.DoubleClick += new System.EventHandler(this.FileListLB_DoubleClick);
            // 
            // WorkoutLBL
            // 
            this.WorkoutLBL.AutoSize = true;
            this.WorkoutLBL.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.WorkoutLBL.Location = new System.Drawing.Point(12, 14);
            this.WorkoutLBL.Name = "WorkoutLBL";
            this.WorkoutLBL.Size = new System.Drawing.Size(538, 39);
            this.WorkoutLBL.TabIndex = 0;
            this.WorkoutLBL.Text = "Select a playlist, then hit ENTER.";
            // 
            // OKBTN
            // 
            this.OKBTN.AccessibleName = "OK";
            this.OKBTN.AutoSize = true;
            this.OKBTN.Location = new System.Drawing.Point(19, 515);
            this.OKBTN.Name = "OKBTN";
            this.OKBTN.Size = new System.Drawing.Size(254, 51);
            this.OKBTN.TabIndex = 2;
            this.OKBTN.Text = "&OK";
            this.OKBTN.UseVisualStyleBackColor = true;
            this.OKBTN.UseWaitCursor = true;
            this.OKBTN.Click += new System.EventHandler(this.OKBTN_Click);
            // 
            // RandomBTN
            // 
            this.RandomBTN.AccessibleName = "Random";
            this.RandomBTN.AutoSize = true;
            this.RandomBTN.Location = new System.Drawing.Point(314, 515);
            this.RandomBTN.Name = "RandomBTN";
            this.RandomBTN.Size = new System.Drawing.Size(254, 51);
            this.RandomBTN.TabIndex = 3;
            this.RandomBTN.Text = "&Random";
            this.RandomBTN.UseVisualStyleBackColor = true;
            this.RandomBTN.UseWaitCursor = true;
            this.RandomBTN.Click += new System.EventHandler(this.RandomBTN_Click);
            // 
            // TWV
            // 
            this.AcceptButton = this.OKBTN;
            this.AutoScaleDimensions = new System.Drawing.SizeF(20F, 39F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Purple;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(581, 588);
            this.Controls.Add(this.RandomBTN);
            this.Controls.Add(this.OKBTN);
            this.Controls.Add(this.WorkoutLBL);
            this.Controls.Add(this.FileListLB);
            this.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.Name = "TWV";
            this.Text = "Favorite Music for Tiffany";
            this.Load += new System.EventHandler(this.TWV_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox FileListLB;
        private System.Windows.Forms.Label WorkoutLBL;
        public System.Windows.Forms.Button OKBTN;
        public System.Windows.Forms.Button RandomBTN;
    }
}

