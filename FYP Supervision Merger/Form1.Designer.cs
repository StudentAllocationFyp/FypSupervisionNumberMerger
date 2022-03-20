namespace FYP_Supervision_Merger
{
    partial class Form1
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
            this.btnCurrUpload = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbSupFacultyName = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbCurrSupSem1 = new System.Windows.Forms.CheckBox();
            this.cbCurrStaff = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.aaa = new System.Windows.Forms.Label();
            this.cbCurrSupSem2 = new System.Windows.Forms.CheckBox();
            this.lblSupUpload = new System.Windows.Forms.Label();
            this.lblCurrUpload = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.btnGenerateSem1 = new System.Windows.Forms.Button();
            this.btnGenerateSem2 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.btnSupUpload = new System.Windows.Forms.Button();
            this.cbSupTotalFyp = new System.Windows.Forms.CheckBox();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCurrUpload
            // 
            this.btnCurrUpload.Location = new System.Drawing.Point(271, 135);
            this.btnCurrUpload.Name = "btnCurrUpload";
            this.btnCurrUpload.Size = new System.Drawing.Size(105, 33);
            this.btnCurrUpload.TabIndex = 1;
            this.btnCurrUpload.Text = "UPLOAD";
            this.btnCurrUpload.UseVisualStyleBackColor = true;
            this.btnCurrUpload.Click += new System.EventHandler(this.btnCurrUpload_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "FYP Supervision Numbers (CSV):";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Fields Required (Row 1):";
            // 
            // cbSupFacultyName
            // 
            this.cbSupFacultyName.AutoSize = true;
            this.cbSupFacultyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSupFacultyName.Location = new System.Drawing.Point(20, 89);
            this.cbSupFacultyName.Name = "cbSupFacultyName";
            this.cbSupFacultyName.Size = new System.Drawing.Size(113, 21);
            this.cbSupFacultyName.TabIndex = 4;
            this.cbSupFacultyName.Text = "Faculty Name";
            this.cbSupFacultyName.UseVisualStyleBackColor = true;
            this.cbSupFacultyName.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(206, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Currently Assigned (XLSX):";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // cbCurrSupSem1
            // 
            this.cbCurrSupSem1.AutoSize = true;
            this.cbCurrSupSem1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCurrSupSem1.Location = new System.Drawing.Point(21, 235);
            this.cbCurrSupSem1.Name = "cbCurrSupSem1";
            this.cbCurrSupSem1.Size = new System.Drawing.Size(56, 21);
            this.cbCurrSupSem1.TabIndex = 9;
            this.cbCurrSupSem1.Text = "Sup.";
            this.cbCurrSupSem1.UseVisualStyleBackColor = true;
            // 
            // cbCurrStaff
            // 
            this.cbCurrStaff.AutoSize = true;
            this.cbCurrStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCurrStaff.Location = new System.Drawing.Point(21, 217);
            this.cbCurrStaff.Name = "cbCurrStaff";
            this.cbCurrStaff.Size = new System.Drawing.Size(56, 21);
            this.cbCurrStaff.TabIndex = 8;
            this.cbCurrStaff.Text = "Staff";
            this.cbCurrStaff.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Fields Required (Row 3):";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(37, 253);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Sem1";
            // 
            // aaa
            // 
            this.aaa.AutoSize = true;
            this.aaa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aaa.Location = new System.Drawing.Point(37, 285);
            this.aaa.Name = "aaa";
            this.aaa.Size = new System.Drawing.Size(44, 17);
            this.aaa.TabIndex = 12;
            this.aaa.Text = "Sem2";
            this.aaa.Click += new System.EventHandler(this.label6_Click);
            // 
            // cbCurrSupSem2
            // 
            this.cbCurrSupSem2.AutoSize = true;
            this.cbCurrSupSem2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCurrSupSem2.Location = new System.Drawing.Point(21, 267);
            this.cbCurrSupSem2.Name = "cbCurrSupSem2";
            this.cbCurrSupSem2.Size = new System.Drawing.Size(56, 21);
            this.cbCurrSupSem2.TabIndex = 11;
            this.cbCurrSupSem2.Text = "Sup.";
            this.cbCurrSupSem2.UseVisualStyleBackColor = true;
            // 
            // lblSupUpload
            // 
            this.lblSupUpload.AutoSize = true;
            this.lblSupUpload.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupUpload.Location = new System.Drawing.Point(17, 49);
            this.lblSupUpload.Name = "lblSupUpload";
            this.lblSupUpload.Size = new System.Drawing.Size(0, 17);
            this.lblSupUpload.TabIndex = 13;
            // 
            // lblCurrUpload
            // 
            this.lblCurrUpload.AutoSize = true;
            this.lblCurrUpload.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrUpload.Location = new System.Drawing.Point(18, 176);
            this.lblCurrUpload.Name = "lblCurrUpload";
            this.lblCurrUpload.Size = new System.Drawing.Size(0, 17);
            this.lblCurrUpload.TabIndex = 14;
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblError.Location = new System.Drawing.Point(81, 563);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 17);
            this.lblError.TabIndex = 15;
            this.lblError.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblError.Click += new System.EventHandler(this.label9_Click);
            // 
            // btnGenerateSem1
            // 
            this.btnGenerateSem1.Location = new System.Drawing.Point(63, 516);
            this.btnGenerateSem1.Name = "btnGenerateSem1";
            this.btnGenerateSem1.Size = new System.Drawing.Size(136, 33);
            this.btnGenerateSem1.TabIndex = 16;
            this.btnGenerateSem1.Text = "GENERATE SEM1";
            this.btnGenerateSem1.UseVisualStyleBackColor = true;
            this.btnGenerateSem1.Click += new System.EventHandler(this.btnGenerateSem1_Click);
            // 
            // btnGenerateSem2
            // 
            this.btnGenerateSem2.Location = new System.Drawing.Point(205, 516);
            this.btnGenerateSem2.Name = "btnGenerateSem2";
            this.btnGenerateSem2.Size = new System.Drawing.Size(136, 33);
            this.btnGenerateSem2.TabIndex = 17;
            this.btnGenerateSem2.Text = "GENERATE SEM2";
            this.btnGenerateSem2.UseVisualStyleBackColor = true;
            this.btnGenerateSem2.Click += new System.EventHandler(this.btnGenerateSem2_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // btnSupUpload
            // 
            this.btnSupUpload.Location = new System.Drawing.Point(271, 12);
            this.btnSupUpload.Name = "btnSupUpload";
            this.btnSupUpload.Size = new System.Drawing.Size(105, 33);
            this.btnSupUpload.TabIndex = 19;
            this.btnSupUpload.Text = "UPLOAD";
            this.btnSupUpload.UseVisualStyleBackColor = true;
            this.btnSupUpload.Click += new System.EventHandler(this.btnSupUpload_Click);
            // 
            // cbSupTotalFyp
            // 
            this.cbSupTotalFyp.AutoSize = true;
            this.cbSupTotalFyp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSupTotalFyp.Location = new System.Drawing.Point(20, 107);
            this.cbSupTotalFyp.Name = "cbSupTotalFyp";
            this.cbSupTotalFyp.Size = new System.Drawing.Size(89, 21);
            this.cbSupTotalFyp.TabIndex = 20;
            this.cbSupTotalFyp.Text = "Total FYP";
            this.cbSupTotalFyp.UseVisualStyleBackColor = true;
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(21, 349);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(355, 150);
            this.dgv.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(23, 326);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(157, 17);
            this.label6.TabIndex = 22;
            this.label6.Text = "Unmerged Faculties:";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(21, 563);
            this.progressBar1.MarqueeAnimationSpeed = 1000;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(355, 23);
            this.progressBar1.Step = 1;
            this.progressBar1.TabIndex = 23;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 601);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.cbSupTotalFyp);
            this.Controls.Add(this.btnSupUpload);
            this.Controls.Add(this.btnGenerateSem2);
            this.Controls.Add(this.btnGenerateSem1);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.lblCurrUpload);
            this.Controls.Add(this.lblSupUpload);
            this.Controls.Add(this.aaa);
            this.Controls.Add(this.cbCurrSupSem2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbCurrSupSem1);
            this.Controls.Add(this.cbCurrStaff);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbSupFacultyName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCurrUpload);
            this.Name = "Form1";
            this.Text = "FYP Supervision Merger";
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCurrUpload;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cbSupFacultyName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox cbCurrSupSem1;
        private System.Windows.Forms.CheckBox cbCurrStaff;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label aaa;
        private System.Windows.Forms.CheckBox cbCurrSupSem2;
        private System.Windows.Forms.Label lblSupUpload;
        private System.Windows.Forms.Label lblCurrUpload;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Button btnGenerateSem1;
        private System.Windows.Forms.Button btnGenerateSem2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.Button btnSupUpload;
        private System.Windows.Forms.CheckBox cbSupTotalFyp;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

