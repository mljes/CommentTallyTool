namespace CommentTallyTool
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.commentListView = new System.Windows.Forms.ListView();
            this.commentTextColumnHeader = new System.Windows.Forms.ColumnHeader();
            this.commentCountColumnHeader = new System.Windows.Forms.ColumnHeader();
            this.listLabel = new System.Windows.Forms.Label();
            this.addNewLabel = new System.Windows.Forms.Label();
            this.commentAddButton = new System.Windows.Forms.Button();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.openToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.saveToolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.copyToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.helpToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.addCommentTextBox = new System.Windows.Forms.RichTextBox();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // commentListView
            // 
            this.commentListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.commentTextColumnHeader,
            this.commentCountColumnHeader});
            this.commentListView.GridLines = true;
            this.commentListView.HideSelection = false;
            this.commentListView.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.commentListView.Location = new System.Drawing.Point(12, 43);
            this.commentListView.MultiSelect = false;
            this.commentListView.Name = "commentListView";
            this.commentListView.Size = new System.Drawing.Size(910, 373);
            this.commentListView.TabIndex = 1;
            this.commentListView.UseCompatibleStateImageBehavior = false;
            this.commentListView.View = System.Windows.Forms.View.Details;
            this.commentListView.SelectedIndexChanged += new System.EventHandler(this.commentListView_SelectedIndexChanged);
            // 
            // commentTextColumnHeader
            // 
            this.commentTextColumnHeader.Text = "Text";
            this.commentTextColumnHeader.Width = 850;
            // 
            // commentCountColumnHeader
            // 
            this.commentCountColumnHeader.Text = "Count";
            this.commentCountColumnHeader.Width = 50;
            // 
            // listLabel
            // 
            this.listLabel.AutoSize = true;
            this.listLabel.Location = new System.Drawing.Point(12, 25);
            this.listLabel.Name = "listLabel";
            this.listLabel.Size = new System.Drawing.Size(66, 15);
            this.listLabel.TabIndex = 2;
            this.listLabel.Text = "Comments";
            // 
            // addNewLabel
            // 
            this.addNewLabel.AutoSize = true;
            this.addNewLabel.Location = new System.Drawing.Point(12, 437);
            this.addNewLabel.Name = "addNewLabel";
            this.addNewLabel.Size = new System.Drawing.Size(109, 15);
            this.addNewLabel.TabIndex = 3;
            this.addNewLabel.Text = "Add new comment";
            // 
            // commentAddButton
            // 
            this.commentAddButton.Location = new System.Drawing.Point(847, 455);
            this.commentAddButton.Name = "commentAddButton";
            this.commentAddButton.Size = new System.Drawing.Size(75, 95);
            this.commentAddButton.TabIndex = 5;
            this.commentAddButton.Text = "Add";
            this.commentAddButton.UseVisualStyleBackColor = true;
            this.commentAddButton.Click += new System.EventHandler(this.commentAddButton_Click);
            // 
            // toolStrip
            // 
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripButton,
            this.saveToolStripButton1,
            this.toolStripSeparator,
            this.copyToolStripButton,
            this.toolStripSeparator1,
            this.helpToolStripButton});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(934, 25);
            this.toolStrip.TabIndex = 6;
            this.toolStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip_ItemClicked);
            // 
            // openToolStripButton
            // 
            this.openToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.openToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripButton.Image")));
            this.openToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripButton.Name = "openToolStripButton";
            this.openToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.openToolStripButton.Text = "&Open";
            // 
            // saveToolStripButton1
            // 
            this.saveToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveToolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripButton1.Image")));
            this.saveToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripButton1.Name = "saveToolStripButton1";
            this.saveToolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.saveToolStripButton1.Text = "&Save";
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // copyToolStripButton
            // 
            this.copyToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.copyToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("copyToolStripButton.Image")));
            this.copyToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copyToolStripButton.Name = "copyToolStripButton";
            this.copyToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.copyToolStripButton.Text = "&Copy";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // helpToolStripButton
            // 
            this.helpToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.helpToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("helpToolStripButton.Image")));
            this.helpToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.helpToolStripButton.Name = "helpToolStripButton";
            this.helpToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.helpToolStripButton.Text = "He&lp";
            // 
            // addCommentTextBox
            // 
            this.addCommentTextBox.Location = new System.Drawing.Point(12, 455);
            this.addCommentTextBox.Name = "addCommentTextBox";
            this.addCommentTextBox.Size = new System.Drawing.Size(829, 96);
            this.addCommentTextBox.TabIndex = 7;
            this.addCommentTextBox.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 562);
            this.Controls.Add(this.addCommentTextBox);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.commentAddButton);
            this.Controls.Add(this.addNewLabel);
            this.Controls.Add(this.listLabel);
            this.Controls.Add(this.commentListView);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView commentListView;
        private System.Windows.Forms.Label listLabel;
        private System.Windows.Forms.Label addNewLabel;
        private System.Windows.Forms.Button commentAddButton;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton copyToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton helpToolStripButton;
        private System.Windows.Forms.ToolStripButton openToolStripButton;
        private System.Windows.Forms.ToolStripButton saveToolStripButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.RichTextBox addCommentTextBox;
        private System.Windows.Forms.ColumnHeader commentTextColumnHeader;
        private System.Windows.Forms.ColumnHeader commentCountColumnHeader;
    }
}

