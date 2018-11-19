namespace TreeF
{
    partial class TreeForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label2 = new System.Windows.Forms.Label();
            this.Input = new System.Windows.Forms.TextBox();
            this.GetCountBtn = new System.Windows.Forms.Button();
            this.Output = new System.Windows.Forms.Label();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.AddBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.RemoveBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 18);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "K = ";
            // 
            // Input
            // 
            this.Input.Location = new System.Drawing.Point(40, 16);
            this.Input.Margin = new System.Windows.Forms.Padding(2);
            this.Input.Name = "Input";
            this.Input.Size = new System.Drawing.Size(76, 20);
            this.Input.TabIndex = 3;
            // 
            // GetCountBtn
            // 
            this.GetCountBtn.Location = new System.Drawing.Point(120, 12);
            this.GetCountBtn.Margin = new System.Windows.Forms.Padding(2);
            this.GetCountBtn.Name = "GetCountBtn";
            this.GetCountBtn.Size = new System.Drawing.Size(109, 27);
            this.GetCountBtn.TabIndex = 5;
            this.GetCountBtn.Text = " посчитать кол-во";
            this.GetCountBtn.UseVisualStyleBackColor = true;
            this.GetCountBtn.Click += new System.EventHandler(this.GetCountBtn_Click);
            // 
            // Output
            // 
            this.Output.AutoSize = true;
            this.Output.Location = new System.Drawing.Point(345, 19);
            this.Output.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Output.Name = "Output";
            this.Output.Size = new System.Drawing.Size(10, 13);
            this.Output.TabIndex = 6;
            this.Output.Text = " ";
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddBtn,
            this.RemoveBtn});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(127, 48);
            // 
            // AddBtn
            // 
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(126, 22);
            this.AddBtn.Text = "Добавить";
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // RemoveBtn
            // 
            this.RemoveBtn.Name = "RemoveBtn";
            this.RemoveBtn.Size = new System.Drawing.Size(126, 22);
            this.RemoveBtn.Text = "Удалить";
            this.RemoveBtn.Click += new System.EventHandler(this.RemoveBtn_Click);
            // 
            // TreeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 330);
            this.Controls.Add(this.Output);
            this.Controls.Add(this.GetCountBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Input);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "TreeForm";
            this.Text = "Tree";
            this.Load += new System.EventHandler(this.TreeForm_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.TreeForm_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TreeForm_MouseDown);
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Input;
        private System.Windows.Forms.Button GetCountBtn;
        private System.Windows.Forms.Label Output;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem AddBtn;
        private System.Windows.Forms.ToolStripMenuItem RemoveBtn;
    }
}

