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
            button1 = new Button();
            MatrixA = new FlowLayoutPanel();
            MatrixB = new FlowLayoutPanel();
            label3 = new Label();
            MatrixRez = new FlowLayoutPanel();
            button2 = new Button();
            button3 = new Button();
            txtX1 = new TextBox();
            txtY1 = new TextBox();
            label4 = new Label();
            txtY2 = new TextBox();
            label5 = new Label();
            txtX2 = new TextBox();
            label6 = new Label();
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
            label2.Size = new Size(39, 30);
            label2.TabIndex = 1;
            label2.Text = "X1:";
            // 
            // button1
            // 
            button1.BackColor = Color.LightCyan;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            button1.ForeColor = Color.DarkSlateGray;
            button1.Location = new Point(12, 234);
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
            // MatrixRez
            // 
            MatrixRez.Location = new Point(350, 346);
            MatrixRez.Name = "MatrixRez";
            MatrixRez.Size = new Size(316, 229);
            MatrixRez.TabIndex = 8;
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
            // txtX1
            // 
            txtX1.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold);
            txtX1.Location = new Point(57, 54);
            txtX1.Name = "txtX1";
            txtX1.Size = new Size(45, 35);
            txtX1.TabIndex = 12;
            txtX1.KeyPress += txtX1_KeyPress;
            // 
            // txtY1
            // 
            txtY1.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold);
            txtY1.Location = new Point(57, 93);
            txtY1.Name = "txtY1";
            txtY1.Size = new Size(45, 35);
            txtY1.TabIndex = 14;
            txtY1.KeyPress += txtY1_KeyPress;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 186);
            label4.ForeColor = Color.DarkSlateGray;
            label4.Location = new Point(12, 93);
            label4.Name = "label4";
            label4.Size = new Size(38, 30);
            label4.TabIndex = 13;
            label4.Text = "Y1:";
            // 
            // txtY2
            // 
            txtY2.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold);
            txtY2.Location = new Point(57, 184);
            txtY2.Name = "txtY2";
            txtY2.Size = new Size(45, 35);
            txtY2.TabIndex = 18;
            txtY2.KeyPress += txtY2_KeyPress;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 186);
            label5.ForeColor = Color.DarkSlateGray;
            label5.Location = new Point(12, 184);
            label5.Name = "label5";
            label5.Size = new Size(42, 30);
            label5.TabIndex = 17;
            label5.Text = "Y2:";
            // 
            // txtX2
            // 
            txtX2.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold);
            txtX2.Location = new Point(57, 145);
            txtX2.Name = "txtX2";
            txtX2.Size = new Size(45, 35);
            txtX2.TabIndex = 16;
            txtX2.KeyPress += txtX2_KeyPress;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 186);
            label6.ForeColor = Color.DarkSlateGray;
            label6.Location = new Point(12, 145);
            label6.Name = "label6";
            label6.Size = new Size(43, 30);
            label6.TabIndex = 15;
            label6.Text = "X2:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Snow;
            ClientSize = new Size(861, 580);
            Controls.Add(txtY2);
            Controls.Add(label5);
            Controls.Add(txtX2);
            Controls.Add(label6);
            Controls.Add(txtY1);
            Controls.Add(label4);
            Controls.Add(txtX1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(MatrixRez);
            Controls.Add(label3);
            Controls.Add(MatrixB);
            Controls.Add(MatrixA);
            Controls.Add(button1);
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
        private Button button1;
        private FlowLayoutPanel MatrixA;
        private FlowLayoutPanel MatrixB;
        private Label label3;
        private FlowLayoutPanel MatrixRez;
        private Button button2;
        private Button button3;
        private TextBox txtX1;
        private TextBox txtY1;
        private Label label4;
        private TextBox txtY2;
        private Label label5;
        private TextBox txtX2;
        private Label label6;
    }
}
