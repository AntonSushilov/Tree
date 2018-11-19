using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using Tools;

namespace Draw
{
    public class TreeDraw
    {
        Bitmap Image { get; set; }
        Graphics G;
        int DY;
        public int Height { get; set; }
        public int Width { get; set; }
        public Size Size
        {
            get => new Size(Width, Height);
            set
            {
                Width = value.Width;
                Height = value.Height;
            }
        }
        public Tree tree { get; set; }
        public TreeDraw(Size size,Tree tree)
        {
            Height = size.Height;
            Width = size.Width;
            this.tree = tree;
        }
        public Bitmap Draw()
        {
            Image = new Bitmap(Width, Height);
            G = Graphics.FromImage(Image);
            DY = Height / (tree.GetLevelCount() + 1);
            DrawNode(tree.Root, 0, Width, DY);
            return Image;
        }
        private void DrawNode(Node node,int Left, int Right, int Y )
        {
            int DX = 0;
            if (node.Nodes.Count!=0)
            {
                DX = (Right - Left) / node.Nodes.Count;
                for (int i = 0; i < node.Nodes.Count; i++)
                {
                    G.DrawLine(Pens.Black, (Left + Right) / 2, Y, Left + i * DX + DX / 2, Y + DY);
                }
            }
            int R = Math.Min(Right-Left, DY) / 4;
            G.FillEllipse(Brushes.LightGreen, (Left + Right) / 2 - R, Y - R, 2 * R, 2 * R);
            G.DrawEllipse(Pens.Green, (Left + Right) / 2 - R, Y - R, 2 * R, 2 * R);
            float t = 0;
            string text = node.Value.ToString();
            do
            {
                t += (float)0.2;
            }
            while (G.MeasureString(text, new Font("Microsoft Sans Serif", t)).Width < R);
            StringFormat sf = new StringFormat
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };
            G.DrawString(text, new Font("Microsoft Sans Serif", t), Brushes.Black, new Rectangle((Left + Right) / 2 - R, Y - R, 2 * R, 2 * R), sf);
            if(node.Nodes.Count!=0)
            {
                for (int i = 0; i < node.Nodes.Count; i++)
                    DrawNode(node.Nodes[i], Left + i * DX, Left + (i + 1) * DX, Y + DY);
            }
        }
        private Node GetNode(Node node,int Left, int Right, int Y, int mX, int mY)
        {
            int R = Math.Min(Right - Left, DY) / 4;
            if (Math.Pow(mX - (Left + Right) / 2, 2) + Math.Pow(mY - Y, 2) <= R * R)
                return node;
            if(node.Nodes.Count!= 0)
            {
                int DX = (Right - Left) / node.Nodes.Count;
                for (int i = 0; i < node.Nodes.Count; i++)
                {
                    Node T = GetNode(node.Nodes[i], Left + i * DX, Left + (i + 1) * DX, Y + DY, mX, mY);
                    if (T != null)
                        return T;
                }
            }
            return null;
        }
        public Node GetNode(int mX, int mY)
        {
            DY = Height / (tree.GetLevelCount() + 1);
            return GetNode(tree.Root, 0, Width, DY, mX, mY);
        }
    }
}
