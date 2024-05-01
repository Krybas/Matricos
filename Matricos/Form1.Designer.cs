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
            MatrixRez = new FlowLayoutPanel();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 186);
            label1.ForeColor = Color.DarkSlateGray;
            label1.Location = new Point(14, 12);
            label1.Name = "label1";
            label1.Size = new Size(292, 41);
            label1.TabIndex = 0;
            label1.Text = "Matricu dauginimas";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 186);
            label2.ForeColor = Color.DarkSlateGray;
            label2.Location = new Point(14, 72);
            label2.Name = "label2";
            label2.Size = new Size(92, 37);
            label2.TabIndex = 1;
            label2.Text = "Dydis:";
            // 
            // txtSize
            // 
            txtSize.BorderStyle = BorderStyle.FixedSingle;
            txtSize.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 186);
            txtSize.Location = new Point(94, 75);
            txtSize.Margin = new Padding(3, 4, 3, 4);
            txtSize.Name = "txtSize";
            txtSize.Size = new Size(74, 39);
            txtSize.TabIndex = 2;
            // 
            // button1
            // 
            button1.BackColor = Color.LightCyan;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            button1.ForeColor = Color.DarkSlateGray;
            button1.Location = new Point(14, 127);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(171, 65);
            button1.TabIndex = 5;
            button1.Text = "Kurti matricas";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // MatrixA
            // 
            MatrixA.Location = new Point(206, 72);
            MatrixA.Margin = new Padding(3, 4, 3, 4);
            MatrixA.Name = "MatrixA";
            MatrixA.Size = new Size(363, 305);
            MatrixA.TabIndex = 6;
            // 
            // MatrixB
            // 
            MatrixB.Location = new Point(606, 72);
            MatrixB.Margin = new Padding(3, 4, 3, 4);
            MatrixB.Name = "MatrixB";
            MatrixB.Size = new Size(361, 305);
            MatrixB.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 186);
            label3.ForeColor = Color.DarkSlateGray;
            label3.Location = new Point(222, 461);
            label3.Name = "label3";
            label3.Size = new Size(166, 41);
            label3.TabIndex = 9;
            label3.Text = "Rezultatas:";
            // 
            // MatrixRez
            // 
            MatrixRez.Location = new Point(400, 461);
            MatrixRez.Margin = new Padding(3, 4, 3, 4);
            MatrixRez.Name = "MatrixRez";
            MatrixRez.Size = new Size(361, 305);
            MatrixRez.TabIndex = 8;
            // 
            // button2
            // 
            button2.BackColor = Color.LightCyan;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            button2.ForeColor = Color.DarkSlateGray;
            button2.Location = new Point(503, 385);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(154, 65);
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
            button3.Location = new Point(811, 672);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(154, 95);
            button3.TabIndex = 11;
            button3.Text = "Isvalyti laukus";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Snow;
            ClientSize = new Size(979, 775);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(MatrixRez);
            Controls.Add(label3);
            Controls.Add(MatrixB);
            Controls.Add(MatrixA);
            Controls.Add(button1);
            Controls.Add(txtSize);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
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
        private FlowLayoutPanel MatrixRez;
        private Button button2;
        private Button button3;
    }
}
