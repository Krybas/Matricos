namespace Matricos
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
            label1 = new Label();
            label2 = new Label();
            txtSize = new TextBox();
            button1 = new Button();
            MatrixA = new FlowLayoutPanel();
            MatrixB = new FlowLayoutPanel();
            label3 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 186);
            label1.ForeColor = Color.DarkSlateGray;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(230, 32);
            label1.TabIndex = 0;
            label1.Text = "Matricu dauginimas";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 186);
            label2.ForeColor = Color.DarkSlateGray;
            label2.Location = new Point(12, 54);
            label2.Name = "label2";
            label2.Size = new Size(71, 30);
            label2.TabIndex = 1;
            label2.Text = "Dydis:";
            // 
            // txtSize
            // 
            txtSize.BorderStyle = BorderStyle.FixedSingle;
            txtSize.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 186);
            txtSize.Location = new Point(82, 56);
            txtSize.Name = "txtSize";
            txtSize.Size = new Size(65, 33);
            txtSize.TabIndex = 2;
            // 
            // button1
            // 
            button1.BackColor = Color.LightCyan;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            button1.ForeColor = Color.DarkSlateGray;
            button1.Location = new Point(12, 95);
            button1.Name = "button1";
            button1.Size = new Size(150, 49);
            button1.TabIndex = 5;
            button1.Text = "Kurti matricas";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // MatrixA
            // 
            MatrixA.Location = new Point(180, 54);
            MatrixA.Name = "MatrixA";
            MatrixA.Size = new Size(318, 229);
            MatrixA.TabIndex = 6;
            // 
            // MatrixB
            // 
            MatrixB.Location = new Point(530, 54);
            MatrixB.Name = "MatrixB";
            MatrixB.Size = new Size(316, 229);
            MatrixB.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 186);
            label3.ForeColor = Color.DarkSlateGray;
            label3.Location = new Point(194, 346);
            label3.Name = "label3";
            label3.Size = new Size(132, 32);
            label3.TabIndex = 9;
            label3.Text = "Rezultatas:";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Location = new Point(350, 346);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(316, 229);
            flowLayoutPanel1.TabIndex = 8;
            // 
            // button2
            // 
            button2.BackColor = Color.LightCyan;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            button2.ForeColor = Color.DarkSlateGray;
            button2.Location = new Point(440, 289);
            button2.Name = "button2";
            button2.Size = new Size(135, 49);
            button2.TabIndex = 10;
            button2.Text = "Apskaiciuoti";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.LightCyan;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            button3.ForeColor = Color.DarkSlateGray;
            button3.Location = new Point(710, 504);
            button3.Name = "button3";
            button3.Size = new Size(135, 71);
            button3.TabIndex = 11;
            button3.Text = "Isvalyti laukus";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Snow;
            ClientSize = new Size(857, 581);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(label3);
            Controls.Add(MatrixB);
            Controls.Add(MatrixA);
            Controls.Add(button1);
            Controls.Add(txtSize);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Matricos";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtSize;
        private Button button1;
        private FlowLayoutPanel MatrixA;
        private FlowLayoutPanel MatrixB;
        private Label label3;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button button2;
        private Button button3;
    }
}
