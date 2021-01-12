using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
namespace CommentTallyTool
{
    public partial class Form1 : Form
    {
        bool altKeyDown;

        List<Comment> commentList;
        public Form1()
        {
            InitializeComponent();
            commentList = new List<Comment>();
            altKeyDown = false;

            commentListView.KeyDown += _KeyDown;
            commentListView.KeyUp += _KeyUp;

            addCommentTextBox.KeyDown += _KeyDown;
            addCommentTextBox.KeyUp += _KeyUp;

            commentAddButton.KeyDown += _KeyDown;
            commentAddButton.KeyUp += _KeyUp; 
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void _KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Alt || e.KeyCode == Keys.Menu)
            {
                altKeyDown = true;
            }
        }

        private void _KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Alt || e.KeyCode == Keys.Menu)
            {
                altKeyDown = false;
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
        }

        private void commentListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedComments = ((ListView)sender).SelectedItems;
         
            if (selectedComments.Count != 1)
            {
                return;
            }

            var item = selectedComments[0]; // can only ever select 1 item
            int itemIndex = selectedComments[0].Index;

            if (altKeyDown)
            {
                // increment the comment counter since we are now copying it
                copyComment(item, itemIndex);
      
            }

            selectedComments.Clear();
        }

        private void commentAddButton_Click(object sender, EventArgs e)
        {
            Comment newComment = new Comment(addCommentTextBox.Text, 0);
            ListViewItem commentItem = new ListViewItem();
            commentItem.Text = newComment.ToString();
            commentItem.SubItems.Add("0");

            Debug.WriteLine("TRYING TO ADD " + newComment);

            commentList.Add(newComment);
            commentListView.Items.Add(commentItem);

            addCommentTextBox.Text = "";
        }

        private void toolStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void copyComment(ListViewItem comment, int commentIndex)
        {
            string commentText = comment.Text;
            Clipboard.SetText(commentText);

            comment.SubItems[1].Text = $"{Int32.Parse(comment.SubItems[1].Text) + 1}";
            commentList[commentIndex].Count++;
        }
    }
}
