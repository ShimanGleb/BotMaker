namespace BotMaker
{
    partial class MainWindow
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ActionBox = new System.Windows.Forms.ComboBox();
            this.insertBeforeRadioButton = new System.Windows.Forms.RadioButton();
            this.insertAfterRadioButton = new System.Windows.Forms.RadioButton();
            this.CheckCursorButton = new System.Windows.Forms.Button();
            this.RemoveActionButton = new System.Windows.Forms.Button();
            this.ActionListGrid = new System.Windows.Forms.DataGridView();
            this.AvtionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CommentColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddActionButton = new System.Windows.Forms.Button();
            this.RunBotButton = new System.Windows.Forms.Button();
            this.StopBotButton = new System.Windows.Forms.Button();
            this.InsetInEndRadioButton = new System.Windows.Forms.RadioButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ActionListGrid)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 191F));
            this.tableLayoutPanel1.Controls.Add(this.ActionBox, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.insertBeforeRadioButton, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.insertAfterRadioButton, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.CheckCursorButton, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.RemoveActionButton, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.ActionListGrid, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.AddActionButton, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.RunBotButton, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.StopBotButton, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.InsetInEndRadioButton, 2, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.896552F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.488064F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 77.45358F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(559, 490);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // ActionBox
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.ActionBox, 3);
            this.ActionBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ActionBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ActionBox.FormattingEnabled = true;
            this.ActionBox.Items.AddRange(new object[] {
            "Point - points cursor to the position.",
            "Drag - drags cursor from current postiton to new one.",
            "Click - click in position.",
            "Wait - wait certain time.",
            "Repeat - repeats commands inside the loop."});
            this.ActionBox.Location = new System.Drawing.Point(3, 3);
            this.ActionBox.Name = "ActionBox";
            this.ActionBox.Size = new System.Drawing.Size(553, 21);
            this.ActionBox.TabIndex = 0;
            // 
            // insertBeforeRadioButton
            // 
            this.insertBeforeRadioButton.AutoSize = true;
            this.insertBeforeRadioButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.insertBeforeRadioButton.Location = new System.Drawing.Point(3, 38);
            this.insertBeforeRadioButton.Name = "insertBeforeRadioButton";
            this.insertBeforeRadioButton.Size = new System.Drawing.Size(178, 25);
            this.insertBeforeRadioButton.TabIndex = 1;
            this.insertBeforeRadioButton.Text = "Insert befor selected";
            this.insertBeforeRadioButton.UseVisualStyleBackColor = true;
            // 
            // insertAfterRadioButton
            // 
            this.insertAfterRadioButton.AutoSize = true;
            this.insertAfterRadioButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.insertAfterRadioButton.Location = new System.Drawing.Point(187, 38);
            this.insertAfterRadioButton.Name = "insertAfterRadioButton";
            this.insertAfterRadioButton.Size = new System.Drawing.Size(178, 25);
            this.insertAfterRadioButton.TabIndex = 2;
            this.insertAfterRadioButton.Text = "Insert after selected";
            this.insertAfterRadioButton.UseVisualStyleBackColor = true;
            // 
            // CheckCursorButton
            // 
            this.CheckCursorButton.Enabled = false;
            this.CheckCursorButton.Location = new System.Drawing.Point(187, 69);
            this.CheckCursorButton.Name = "CheckCursorButton";
            this.CheckCursorButton.Size = new System.Drawing.Size(178, 23);
            this.CheckCursorButton.TabIndex = 3;
            this.CheckCursorButton.Text = "Check cursor position";
            this.CheckCursorButton.UseVisualStyleBackColor = true;
            this.CheckCursorButton.Click += new System.EventHandler(this.CheckCursorButton_Click);
            // 
            // RemoveActionButton
            // 
            this.RemoveActionButton.Enabled = false;
            this.RemoveActionButton.Location = new System.Drawing.Point(371, 69);
            this.RemoveActionButton.Name = "RemoveActionButton";
            this.RemoveActionButton.Size = new System.Drawing.Size(185, 23);
            this.RemoveActionButton.TabIndex = 5;
            this.RemoveActionButton.Text = "Remove selected action";
            this.RemoveActionButton.UseVisualStyleBackColor = true;
            this.RemoveActionButton.Click += new System.EventHandler(this.RemoveActionButton_Click);
            // 
            // ActionListGrid
            // 
            this.ActionListGrid.AllowUserToAddRows = false;
            this.ActionListGrid.BackgroundColor = System.Drawing.Color.White;
            this.ActionListGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ActionListGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AvtionColumn,
            this.CommentColumn});
            this.tableLayoutPanel1.SetColumnSpan(this.ActionListGrid, 3);
            this.ActionListGrid.Location = new System.Drawing.Point(3, 108);
            this.ActionListGrid.MultiSelect = false;
            this.ActionListGrid.Name = "ActionListGrid";
            this.ActionListGrid.RowHeadersVisible = false;
            this.ActionListGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ActionListGrid.Size = new System.Drawing.Size(551, 351);
            this.ActionListGrid.TabIndex = 6;
            // 
            // AvtionColumn
            // 
            this.AvtionColumn.HeaderText = "Action";
            this.AvtionColumn.Name = "AvtionColumn";
            this.AvtionColumn.ReadOnly = true;
            // 
            // CommentColumn
            // 
            this.CommentColumn.HeaderText = "Comment";
            this.CommentColumn.Name = "CommentColumn";
            this.CommentColumn.Width = 448;
            // 
            // AddActionButton
            // 
            this.AddActionButton.Location = new System.Drawing.Point(3, 69);
            this.AddActionButton.Name = "AddActionButton";
            this.AddActionButton.Size = new System.Drawing.Size(178, 23);
            this.AddActionButton.TabIndex = 4;
            this.AddActionButton.Text = "Add action";
            this.AddActionButton.UseVisualStyleBackColor = true;
            this.AddActionButton.Click += new System.EventHandler(this.AddActionButton_Click);
            // 
            // RunBotButton
            // 
            this.RunBotButton.Location = new System.Drawing.Point(3, 465);
            this.RunBotButton.Name = "RunBotButton";
            this.RunBotButton.Size = new System.Drawing.Size(178, 22);
            this.RunBotButton.TabIndex = 7;
            this.RunBotButton.Text = "Run bot";
            this.RunBotButton.UseVisualStyleBackColor = true;
            this.RunBotButton.Click += new System.EventHandler(this.RunBotButton_Click);
            // 
            // StopBotButton
            // 
            this.StopBotButton.Enabled = false;
            this.StopBotButton.Location = new System.Drawing.Point(371, 465);
            this.StopBotButton.Name = "StopBotButton";
            this.StopBotButton.Size = new System.Drawing.Size(183, 22);
            this.StopBotButton.TabIndex = 8;
            this.StopBotButton.Text = "Stop bot";
            this.StopBotButton.UseVisualStyleBackColor = true;
            this.StopBotButton.Click += new System.EventHandler(this.StopBotButton_Click);
            // 
            // InsetInEndRadioButton
            // 
            this.InsetInEndRadioButton.AutoSize = true;
            this.InsetInEndRadioButton.Checked = true;
            this.InsetInEndRadioButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InsetInEndRadioButton.Location = new System.Drawing.Point(371, 38);
            this.InsetInEndRadioButton.Name = "InsetInEndRadioButton";
            this.InsetInEndRadioButton.Size = new System.Drawing.Size(185, 25);
            this.InsetInEndRadioButton.TabIndex = 9;
            this.InsetInEndRadioButton.TabStop = true;
            this.InsetInEndRadioButton.Text = "Insert in the end";
            this.InsetInEndRadioButton.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(559, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.loadToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.loadToolStripMenuItem.Text = "Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 514);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainWindow";
            this.Text = "Bot maker V2.0";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ActionListGrid)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ComboBox ActionBox;
        private System.Windows.Forms.RadioButton insertBeforeRadioButton;
        private System.Windows.Forms.RadioButton insertAfterRadioButton;
        private System.Windows.Forms.Button CheckCursorButton;
        private System.Windows.Forms.Button AddActionButton;
        private System.Windows.Forms.Button RemoveActionButton;
        private System.Windows.Forms.DataGridView ActionListGrid;
        private System.Windows.Forms.Button RunBotButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn AvtionColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CommentColumn;
        private System.Windows.Forms.Button StopBotButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.RadioButton InsetInEndRadioButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

