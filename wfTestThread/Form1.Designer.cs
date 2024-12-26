namespace wfTestThread
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            timer1 = new System.Windows.Forms.Timer(components);
            btnSelectFile = new Button();
            btnStartTimer = new Button();
            txtFilePath = new TextBox();
            txtDifferences = new TextBox();
            numInterval = new NumericUpDown();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)numInterval).BeginInit();
            SuspendLayout();
            // 
            // timer1
            // 
            timer1.Interval = 10;
            // 
            // btnSelectFile
            // 
            btnSelectFile.Location = new Point(96, 50);
            btnSelectFile.Name = "btnSelectFile";
            btnSelectFile.Size = new Size(75, 23);
            btnSelectFile.TabIndex = 0;
            btnSelectFile.Text = "Select File";
            btnSelectFile.UseVisualStyleBackColor = true;
            btnSelectFile.Click += btnSelectFile_Click;
            // 
            // btnStartTimer
            // 
            btnStartTimer.Location = new Point(96, 100);
            btnStartTimer.Name = "btnStartTimer";
            btnStartTimer.Size = new Size(75, 23);
            btnStartTimer.TabIndex = 1;
            btnStartTimer.Text = "Start Timer";
            btnStartTimer.UseVisualStyleBackColor = true;
            btnStartTimer.Click += btnStartTimer_Click;
            // 
            // txtFilePath
            // 
            txtFilePath.Location = new Point(195, 50);
            txtFilePath.Name = "txtFilePath";
            txtFilePath.Size = new Size(408, 23);
            txtFilePath.TabIndex = 2;
            // 
            // txtDifferences
            // 
            txtDifferences.Location = new Point(195, 100);
            txtDifferences.Multiline = true;
            txtDifferences.Name = "txtDifferences";
            txtDifferences.ScrollBars = ScrollBars.Vertical;
            txtDifferences.Size = new Size(408, 94);
            txtDifferences.TabIndex = 3;
            // 
            // numInterval
            // 
            numInterval.Location = new Point(195, 12);
            numInterval.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numInterval.Name = "numInterval";
            numInterval.Size = new Size(47, 23);
            numInterval.TabIndex = 5;
            numInterval.Value = new decimal(new int[] { 20, 0, 0, 0 });
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(125, 14);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 6;
            label1.Text = "Interval";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(254, 14);
            label2.Name = "label2";
            label2.Size = new Size(73, 15);
            label2.TabIndex = 7;
            label2.Text = "milliseconds";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(646, 206);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(numInterval);
            Controls.Add(txtDifferences);
            Controls.Add(txtFilePath);
            Controls.Add(btnStartTimer);
            Controls.Add(btnSelectFile);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numInterval).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private Button btnSelectFile;
        private Button btnStartTimer;
        private TextBox txtFilePath;
        private TextBox txtDifferences;
        private NumericUpDown numInterval;
        private Label label1;
        private Label label2;
    }
}