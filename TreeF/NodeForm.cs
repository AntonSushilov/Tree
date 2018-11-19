using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TreeF
{
    public partial class NodeForm : Form
    {
        public NodeForm()
        {
            InitializeComponent();
        }
        public double Value { get; set; } = 0;
        private void NodeForm_Load(object sender, EventArgs e)
        {
            Input.Text = Value.ToString();
        }

        private void OkBtn_Click(object sender, EventArgs e)
        {
            Value = double.Parse(Input.Text);
        }
    }
}
