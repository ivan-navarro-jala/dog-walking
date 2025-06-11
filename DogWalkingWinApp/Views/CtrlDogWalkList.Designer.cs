namespace DogWalkingWinApp.Views
{
    partial class CtrlDogWalkList
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
            _dgvDogWalks = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)_dgvDogWalks).BeginInit();
            SuspendLayout();
            // 
            // _dgvDogWalks
            // 
            _dgvDogWalks.AllowUserToAddRows = false;
            _dgvDogWalks.AllowUserToDeleteRows = false;
            _dgvDogWalks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            _dgvDogWalks.Dock = DockStyle.Fill;
            _dgvDogWalks.Location = new Point(0, 0);
            _dgvDogWalks.Name = "_dgvDogWalks";
            _dgvDogWalks.ReadOnly = true;
            _dgvDogWalks.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            _dgvDogWalks.Size = new Size(689, 400);
            _dgvDogWalks.TabIndex = 0;
            _dgvDogWalks.SelectionChanged += _dgvDogWalks_SelectionChanged;
            // 
            // CtrlDogWalkList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(_dgvDogWalks);
            Name = "CtrlDogWalkList";
            Size = new Size(689, 400);
            ((System.ComponentModel.ISupportInitialize)_dgvDogWalks).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView _dgvDogWalks;
    }
}
