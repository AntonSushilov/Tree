using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Draw;
using Tools;

namespace TreeF
{
    public partial class TreeForm : Form
    {
        public TreeForm()
        {
            InitializeComponent();
        }
        Tree tree;
        TreeDraw draw;
        private void TreeForm_Load(object sender, EventArgs e)
        {
            tree = new Tree();
            draw = new TreeDraw(new Size(450, 300), tree);
        }

        private void TreeForm_Paint(object sender, PaintEventArgs e)
        {
            if(draw!=null)
            e.Graphics.DrawImage(draw.Draw(), 0, 50);
        }
        Node SelectedNode;
        private void TreeForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                SelectedNode = draw.GetNode(e.X, e.Y - 50);
                if (SelectedNode != null)
                {
                    if (SelectedNode == tree.Root)
                        RemoveBtn.Enabled = false;
                    else
                        RemoveBtn.Enabled = true;
                    if (SelectedNode.Nodes.Count == 2)
                        AddBtn.Enabled = false;
                    else
                        AddBtn.Enabled = true;
                    contextMenuStrip.Show(this, e.Location);
                }
            }
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            NodeForm node = new NodeForm();
            node.Value = 0;
            try
            {
                if(node.ShowDialog() == DialogResult.OK)
                {
                    SelectedNode.Add(node.Value);
                    Refresh();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("ошибка ввода");
            }
        }

        private void RemoveBtn_Click(object sender, EventArgs e)
        {
            SelectedNode.Parent.Nodes.Remove(SelectedNode);
            Refresh();
        }

        private void GetCountBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Output.Text = tree.GetCount(int.Parse(Input.Text) - 1).ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("ошибка ввода");
            }
        }
        
    }
}
