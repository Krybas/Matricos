using System.Drawing;
using System.Drawing.Drawing2D;
using System.Security.Policy;
using System.Windows.Forms;

namespace Matricos
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Size = new Size(266, 210);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //sukuria matricos forma su teksto langais
            int size = Convert.ToInt32(txtSize.Text);
            MatrixA.Controls.Clear();
            if (size > 5)
            {
                MessageBox.Show("Maksimalus matricos dydis yra 5");
            }
            else
            {
                Size = new Size(875, 391);
                Label nameA = new Label();
                nameA.Size = new Size(100, 30);
                nameA.Text = "Matrica A";
                nameA.BackColor = Color.Snow;
                nameA.ForeColor = Color.DarkSlateGray;
                nameA.BorderStyle = BorderStyle.None;
                nameA.Font = new Font("Segoe UI Semibold", 14, FontStyle.Bold);
                MatrixA.Controls.Add(nameA);
                MatrixA.SetFlowBreak(nameA, true);

                for (int i = 0; i < size; i++)
                {
                    for (int j = 0; j < size; j++)
                    {
                        int name = (i + 1) * 10 + j + 1;
                        TextBox a = new TextBox();
                        a.Size = new Size(40, 20);
                        a.Font = new Font("Segoe UI Semibold", 14, FontStyle.Bold);
                        a.Name = name.ToString();
                        MatrixA.Controls.Add(a);

                        if (j + 1 == size)
                        {
                            MatrixA.SetFlowBreak(a, true);
                        }
                    }
                }

                MatrixB.Controls.Clear();

                Label nameB = new Label();
                nameB.Size = new Size(100, 30);
                nameB.Text = "Matrica B";
                nameB.BackColor = Color.Snow;
                nameB.ForeColor = Color.DarkSlateGray;
                nameB.BorderStyle = BorderStyle.None;
                nameB.Font = new Font("Segoe UI Semibold", 14, FontStyle.Bold);
                MatrixB.Controls.Add(nameB);
                MatrixB.SetFlowBreak(nameB, true);

                for (int i = 0; i < size; i++)
                {
                    for (int j = 0; j < size; j++)
                    {
                        int name = (i + 1) * 10 + j + 1;
                        TextBox a = new TextBox();
                        a.Font = new Font("Segoe UI Semibold", 14, FontStyle.Bold);
                        a.Size = new Size(40, 20);
                        a.Name = name.ToString();
                        MatrixB.Controls.Add(a);

                        if (j + 1 == size)
                        {
                            MatrixB.SetFlowBreak(a, true);
                        }
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Size = new Size(875, 620);

            int size = Convert.ToInt32(txtSize.Text);
            int[,] matrixA = new int[size, size];
            int[,] matrixB = new int[size, size];

            //prideda skaicius i 2D masyva
            int k = 0;
            foreach (Control c in MatrixA.Controls)
            {
                if (c is TextBox)
                {
                    TextBox tb = (TextBox)c;
                    int value = int.Parse(tb.Text);
                    matrixA[k / size, k % size] = value;
                    k++;
                }
            }

            k = 0;
            foreach (Control c in MatrixB.Controls)
            {
                if (c is TextBox)
                {
                    TextBox tb = (TextBox)c;
                    int value = int.Parse(tb.Text);
                    matrixB[k / size, k % size] = value;
                    k++;
                }
            }

            Calculations multiplier = new Calculations(matrixA, matrixB, size);
            int[,] result = multiplier.Multi();

            k = 0;
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    int name = (i + 1) * 10 + j + 1;
                    TextBox a = new TextBox();
                    a.Size = new Size(40, 20);
                    a.Font = new Font("Segoe UI Semibold", 14, FontStyle.Bold);
                    a.Name = "MatrixC_" + name.ToString();
                    MatrixRez.Controls.Add(a);

                    if (j + 1 == size)
                    {
                        MatrixRez.SetFlowBreak(a, true);
                    }
                }
            }
            k = 0;
            foreach (Control c in MatrixRez.Controls)
            {
                if (c is TextBox)
                {
                    TextBox tb = (TextBox)c;
                    tb.Text = result[k / size, k % size].ToString();
                    k++;
                }
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            clearText(MatrixA);
            clearText(MatrixB);
            txtSize.Text = "";

        }
        private void clearText(Panel PanelID)
        {
            foreach (Control c in PanelID.Controls)
            {
                if (c is TextBox)
                {
                    if (c is TextBox matrixTextBox)
                    {
                        matrixTextBox.Text = "";
                    }
                }
            }
        }
    }
}
