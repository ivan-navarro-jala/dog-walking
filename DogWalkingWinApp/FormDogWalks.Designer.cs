namespace DogWalkingWinApp
{
    partial class FormDogWalks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDogWalks));
            toolStrip1 = new ToolStrip();
            _btnNew = new ToolStripButton();
            _btnSave = new ToolStripButton();
            _btnDelete = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            toolStripLabel1 = new ToolStripLabel();
            toolStripTextBox1 = new ToolStripTextBox();
            toolStripLabel2 = new ToolStripLabel();
            toolStripTextBox2 = new ToolStripTextBox();
            _btnSearch = new ToolStripButton();
            _btnClearSearch = new ToolStripButton();
            _pnlBottom = new Panel();
            _pnlTop = new Panel();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { _btnNew, _btnSave, _btnDelete, toolStripSeparator1, toolStripLabel1, toolStripTextBox1, toolStripLabel2, toolStripTextBox2, _btnSearch, _btnClearSearch });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 25);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // _btnNew
            // 
            _btnNew.DisplayStyle = ToolStripItemDisplayStyle.Text;
            _btnNew.Image = (Image)resources.GetObject("_btnNew.Image");
            _btnNew.ImageTransparentColor = Color.Magenta;
            _btnNew.Name = "_btnNew";
            _btnNew.Size = new Size(35, 22);
            _btnNew.Text = "New";
            _btnNew.TextImageRelation = TextImageRelation.TextAboveImage;
            _btnNew.Click += _btnNew_Click;
            // 
            // _btnSave
            // 
            _btnSave.DisplayStyle = ToolStripItemDisplayStyle.Text;
            _btnSave.Image = (Image)resources.GetObject("_btnSave.Image");
            _btnSave.ImageTransparentColor = Color.Magenta;
            _btnSave.Name = "_btnSave";
            _btnSave.Size = new Size(35, 22);
            _btnSave.Text = "Save";
            _btnSave.Click += _btnSave_Click;
            // 
            // _btnDelete
            // 
            _btnDelete.DisplayStyle = ToolStripItemDisplayStyle.Text;
            _btnDelete.Image = (Image)resources.GetObject("_btnDelete.Image");
            _btnDelete.ImageTransparentColor = Color.Magenta;
            _btnDelete.Name = "_btnDelete";
            _btnDelete.Size = new Size(44, 22);
            _btnDelete.Text = "Delete";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 25);
            // 
            // toolStripLabel1
            // 
            toolStripLabel1.Name = "toolStripLabel1";
            toolStripLabel1.Size = new Size(76, 22);
            toolStripLabel1.Text = "Client Name:";
            // 
            // toolStripTextBox1
            // 
            toolStripTextBox1.Name = "toolStripTextBox1";
            toolStripTextBox1.Size = new Size(100, 25);
            // 
            // toolStripLabel2
            // 
            toolStripLabel2.Name = "toolStripLabel2";
            toolStripLabel2.Size = new Size(64, 22);
            toolStripLabel2.Text = "Dog Name";
            // 
            // toolStripTextBox2
            // 
            toolStripTextBox2.Name = "toolStripTextBox2";
            toolStripTextBox2.Size = new Size(100, 25);
            // 
            // _btnSearch
            // 
            _btnSearch.DisplayStyle = ToolStripItemDisplayStyle.Text;
            _btnSearch.Image = (Image)resources.GetObject("_btnSearch.Image");
            _btnSearch.ImageTransparentColor = Color.Magenta;
            _btnSearch.Name = "_btnSearch";
            _btnSearch.Size = new Size(46, 22);
            _btnSearch.Text = "Search";
            // 
            // _btnClearSearch
            // 
            _btnClearSearch.DisplayStyle = ToolStripItemDisplayStyle.Text;
            _btnClearSearch.Image = (Image)resources.GetObject("_btnClearSearch.Image");
            _btnClearSearch.ImageTransparentColor = Color.Magenta;
            _btnClearSearch.Name = "_btnClearSearch";
            _btnClearSearch.Size = new Size(76, 22);
            _btnClearSearch.Text = "Clear Search";
            // 
            // _pnlBottom
            // 
            _pnlBottom.Dock = DockStyle.Fill;
            _pnlBottom.Location = new Point(0, 251);
            _pnlBottom.Name = "_pnlBottom";
            _pnlBottom.Size = new Size(800, 199);
            _pnlBottom.TabIndex = 4;
            // 
            // _pnlTop
            // 
            _pnlTop.Dock = DockStyle.Top;
            _pnlTop.Location = new Point(0, 25);
            _pnlTop.Name = "_pnlTop";
            _pnlTop.Size = new Size(800, 226);
            _pnlTop.TabIndex = 3;
            // 
            // FormDogWalks
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(_pnlBottom);
            Controls.Add(_pnlTop);
            Controls.Add(toolStrip1);
            Name = "FormDogWalks";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dog Walks";
            WindowState = FormWindowState.Maximized;
            Load += FormDogWalks_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton _btnNew;
        private ToolStripButton _btnSave;
        private ToolStripButton _btnDelete;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripLabel toolStripLabel1;
        private ToolStripTextBox toolStripTextBox1;
        private ToolStripLabel toolStripLabel2;
        private ToolStripTextBox toolStripTextBox2;
        private ToolStripButton _btnSearch;
        private ToolStripButton _btnClearSearch;
        private Panel _pnlBottom;
        private Panel _pnlTop;
    }
}
