namespace DogWalkingWinApp.Views
{
    partial class CtrlDogWalk
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            _txtClientName = new TextBox();
            label2 = new Label();
            _txtPhone = new TextBox();
            label3 = new Label();
            _txtDogName = new TextBox();
            label4 = new Label();
            _txtBreed = new TextBox();
            label5 = new Label();
            _numAge = new NumericUpDown();
            label6 = new Label();
            _cmbMonthsYears = new ComboBox();
            label7 = new Label();
            _dtpDate = new DateTimePicker();
            label8 = new Label();
            _numDuration = new NumericUpDown();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            _dtpTime = new DateTimePicker();
            label9 = new Label();
            ((System.ComponentModel.ISupportInitialize)_numAge).BeginInit();
            ((System.ComponentModel.ISupportInitialize)_numDuration).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 25);
            label1.Name = "label1";
            label1.Size = new Size(76, 15);
            label1.TabIndex = 0;
            label1.Text = "Client Name:";
            // 
            // _txtClientName
            // 
            _txtClientName.Location = new Point(95, 22);
            _txtClientName.Name = "_txtClientName";
            _txtClientName.Size = new Size(248, 23);
            _txtClientName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(349, 25);
            label2.Name = "label2";
            label2.Size = new Size(91, 15);
            label2.TabIndex = 2;
            label2.Text = "Phone Number:";
            // 
            // _txtPhone
            // 
            _txtPhone.Location = new Point(446, 22);
            _txtPhone.Name = "_txtPhone";
            _txtPhone.Size = new Size(100, 23);
            _txtPhone.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(77, 30);
            label3.Name = "label3";
            label3.Size = new Size(67, 15);
            label3.TabIndex = 4;
            label3.Text = "Dog Name:";
            // 
            // _txtDogName
            // 
            _txtDogName.Location = new Point(150, 22);
            _txtDogName.Name = "_txtDogName";
            _txtDogName.Size = new Size(162, 23);
            _txtDogName.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(346, 25);
            label4.Name = "label4";
            label4.Size = new Size(40, 15);
            label4.TabIndex = 6;
            label4.Text = "Breed:";
            // 
            // _txtBreed
            // 
            _txtBreed.Location = new Point(392, 22);
            _txtBreed.Name = "_txtBreed";
            _txtBreed.Size = new Size(100, 23);
            _txtBreed.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(104, 59);
            label5.Name = "label5";
            label5.Size = new Size(31, 15);
            label5.TabIndex = 8;
            label5.Text = "Age:";
            // 
            // _numAge
            // 
            _numAge.Location = new Point(150, 54);
            _numAge.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            _numAge.Name = "_numAge";
            _numAge.Size = new Size(76, 23);
            _numAge.TabIndex = 9;
            _numAge.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(306, 54);
            label6.Name = "label6";
            label6.Size = new Size(80, 15);
            label6.TabIndex = 10;
            label6.Text = "Months/Years";
            // 
            // _cmbMonthsYears
            // 
            _cmbMonthsYears.FormattingEnabled = true;
            _cmbMonthsYears.Items.AddRange(new object[] { "Weeks", "Months", "Years" });
            _cmbMonthsYears.Location = new Point(392, 51);
            _cmbMonthsYears.Name = "_cmbMonthsYears";
            _cmbMonthsYears.Size = new Size(100, 23);
            _cmbMonthsYears.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(33, 25);
            label7.Name = "label7";
            label7.Size = new Size(34, 15);
            label7.TabIndex = 12;
            label7.Text = "Date:";
            // 
            // _dtpDate
            // 
            _dtpDate.CustomFormat = "dd-MMM-yyyy";
            _dtpDate.Format = DateTimePickerFormat.Custom;
            _dtpDate.Location = new Point(73, 22);
            _dtpDate.Name = "_dtpDate";
            _dtpDate.Size = new Size(118, 23);
            _dtpDate.TabIndex = 13;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(346, 24);
            label8.Name = "label8";
            label8.Size = new Size(115, 15);
            label8.TabIndex = 14;
            label8.Text = "Duration in minutes:";
            // 
            // _numDuration
            // 
            _numDuration.Increment = new decimal(new int[] { 10, 0, 0, 0 });
            _numDuration.Location = new Point(467, 21);
            _numDuration.Maximum = new decimal(new int[] { 180, 0, 0, 0 });
            _numDuration.Minimum = new decimal(new int[] { 5, 0, 0, 0 });
            _numDuration.Name = "_numDuration";
            _numDuration.Size = new Size(60, 23);
            _numDuration.TabIndex = 15;
            _numDuration.Value = new decimal(new int[] { 5, 0, 0, 0 });
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(_txtPhone);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(_txtClientName);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(6, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(613, 57);
            groupBox1.TabIndex = 16;
            groupBox1.TabStop = false;
            groupBox1.Text = "Client Info";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(_txtBreed);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(_txtDogName);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(_cmbMonthsYears);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(_numAge);
            groupBox2.Controls.Add(label6);
            groupBox2.Location = new Point(6, 67);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(613, 98);
            groupBox2.TabIndex = 17;
            groupBox2.TabStop = false;
            groupBox2.Text = "Dog Info";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(_dtpTime);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(_dtpDate);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(_numDuration);
            groupBox3.Location = new Point(6, 173);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(612, 52);
            groupBox3.TabIndex = 18;
            groupBox3.TabStop = false;
            groupBox3.Text = "Walk Info";
            // 
            // _dtpTime
            // 
            _dtpTime.CustomFormat = "HH:mm";
            _dtpTime.Format = DateTimePickerFormat.Custom;
            _dtpTime.Location = new Point(251, 22);
            _dtpTime.Name = "_dtpTime";
            _dtpTime.ShowUpDown = true;
            _dtpTime.Size = new Size(72, 23);
            _dtpTime.TabIndex = 17;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(208, 25);
            label9.Name = "label9";
            label9.Size = new Size(37, 15);
            label9.TabIndex = 16;
            label9.Text = "Time:";
            // 
            // CtrlDogWalk
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "CtrlDogWalk";
            Size = new Size(629, 236);
            ((System.ComponentModel.ISupportInitialize)_numAge).EndInit();
            ((System.ComponentModel.ISupportInitialize)_numDuration).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private TextBox _txtClientName;
        private Label label2;
        private TextBox _txtPhone;
        private Label label3;
        private TextBox _txtDogName;
        private Label label4;
        private TextBox _txtBreed;
        private Label label5;
        private NumericUpDown _numAge;
        private Label label6;
        private ComboBox _cmbMonthsYears;
        private Label label7;
        private DateTimePicker _dtpDate;
        private Label label8;
        private NumericUpDown _numDuration;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private DateTimePicker _dtpTime;
        private Label label9;
    }
}
