namespace Tema2_Forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Default();
        }
        NumericUpDown numericUpDown1, numericUpDown2;
        DataGridView dataGridView;
        private void Default()
        {
            Size = new Size(650, 550);
            Text = "Tema 2";
            this.BackColor = Color.FromArgb(51, 75, 110);
            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            Panel panel = new Panel();
            panel.BackColor = Color.White;
            panel.Size = new Size(5, 650);
            panel.Location = new Point(0, 0);
            Controls.Add(panel);

            Panel panel1 = new Panel();
            panel1.BackColor = Color.White;
            panel1.Size = new Size(650, 5);
            panel1.Location = new Point(0, 506);
            Controls.Add(panel1);

            Panel panel2 = new Panel();
            panel2.BackColor = Color.White;
            panel2.Size = new Size(5, 550);
            panel2.Location = new Point(629, 0);
            Controls.Add(panel2);

            Label label= new Label();
            label.Text = "Produsul celor mai mici elemente ale \n          fiecarei coloane a matricei";
            label.Font = new Font("Cambria", 18);
            label.ForeColor = Color.White;
            label.BackColor = Color.FromArgb(51, 75, 110);
            label.Size = new Size(400,55);
            label.Location = new Point(120,20);
            Controls.Add(label);

            Label label1 = new Label();
            label1.Text = "Datele masivului: ";
            label1.Size = new Size(200,30);
            label1.Location = new Point(90,120);
            label1.Font = new Font("Cambria", 15);
            label1.ForeColor = Color.White;
            label1.BackColor = Color.FromArgb(51, 75, 110);
            Controls.Add(label1);

            Label label2 = new Label();
            label2.Text = "Randuri";
            label2.Font = new Font("Cambria", 15);
            label2.ForeColor = Color.White;
            label2.BackColor = Color.FromArgb(51, 75, 110);
            label2.Size = new Size(80,30);
            label2.Location = new Point(330,120);
            Controls.Add(label2);

            Label label3 = new Label();
            label3.Text = "Coloane";
            label3.Size = new Size(100,30);
            label3.Location = new Point(330,150);
            label3.Font = new Font("Cambria", 15);
            label3.ForeColor = Color.White;
            label3.BackColor = Color.FromArgb(51, 75, 110);
            Controls.Add(label3);

            numericUpDown1 = new NumericUpDown();
            numericUpDown1.Value = 2;
            numericUpDown1.Maximum = 10;
            numericUpDown1.Minimum = 2;
            numericUpDown1.Location = new Point(430, 121);
            numericUpDown1.Size = new Size(90, 40);
            numericUpDown1.ValueChanged += NumericUpDown1_ValueChanged;
            Controls.Add(numericUpDown1);

            numericUpDown2 = new NumericUpDown();
            numericUpDown2.Enabled = false;
            numericUpDown2.Maximum = 10;
            numericUpDown2.Value = 2;
            numericUpDown2.Minimum = 2;
            numericUpDown2.Location = new Point(430, 151);
            numericUpDown2.Size = new Size(90, 40);
            Controls.Add(numericUpDown2);

            dataGridView= new DataGridView();
            dataGridView.Location = new Point(65,190);
            dataGridView.Size = new Size(505,205);
            dataGridView.BackgroundColor = Color.FromArgb(44, 66, 97);
            dataGridView.BorderStyle = BorderStyle.None;
            dataGridView.Cursor = Cursors.Hand;
            dataGridView.RowHeadersWidth = 4;
            dataGridView.ColumnHeadersHeight = 4;
            Controls.Add(dataGridView);

            Panel panel3 = new Panel();
            panel3.BackColor = Color.White;
            panel3.Size = new Size(320, 1);
            panel3.Location = new Point(160,430);
            Controls.Add(panel3);

            Button button= new Button();
            button.Text = "Completeaza";
            button.Font = new Font("Cambria", 14);
            button.Location = new Point(90,445);
            button.Size = new Size(140, 35);
            button.FlatStyle = FlatStyle.Flat;
            button.ForeColor = Color.White;
            button.BackColor = Color.FromArgb(51, 75, 110);
            button.Click += Button_Click;
            Controls.Add(button);
            
            Button button2= new Button();
            button2.Text = "Determina";
            button2.Font = new Font("Cambria", 14);
            button2.Location = new Point(250,445);
            button2.Size = new Size(140, 35);
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.White;
            button2.BackColor = Color.FromArgb(51, 75, 110);
            button2.Click += Button2_Click;
            Controls.Add(button2);

            Button button3= new Button();
            button3.Font = new Font("Cambria", 14);
            button3.Text = "Sterge";
            button3.Location = new Point(410,445);
            button3.Size = new Size(140, 35);
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = Color.White;
            button3.BackColor = Color.FromArgb(51, 75, 110);
            button3.Click += Button3_Click;
            Controls.Add(button3);
        }
        private void Button3_Click(object? sender, EventArgs e)
        {
            dataGridView.Rows.Clear();
            dataGridView.Refresh();
            matrice = null;
        }
        public int[,] matrice;
        private void Button2_Click(object? sender, EventArgs e)
        {
            int produs = 1;
            int min = int.MaxValue;
            if (matrice==null)
            {
                MessageBox.Show("Matricea nu contine elemente !");
                return;
            }
            for (int i = 0; i < matrice.GetLength(0); i++)
            {
                min = int.MaxValue;
                for (int j = 0; j < matrice.GetLength(1); j++)
                {
                    if (matrice[j, i] < min)
                    {
                        min = matrice[j, i];
                    }
                }
                produs*=min;
            }
            MessageBox.Show($"Produsul elementelor minime de pe fiecare coloana : {produs}");
        }
        private void Button_Click(object? sender, EventArgs e)
        {
            int row = (int)numericUpDown1.Value;
            dataGridView.RowCount=row;
            dataGridView.ColumnCount=row;
            matrice = RandomEl(row,row);
            for (int i = 0; i < matrice.GetLength(0); i++)
            {
                for (int j = 0; j < matrice.GetLength(1); j++)
                {
                    dataGridView.Rows[i].Cells[j].Value=matrice[i,j].ToString();
                    dataGridView.Rows[i].Cells[j].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    dataGridView.Rows[i].Height = 20;
                    if (i == 0)
                        dataGridView.Columns[j].Width = 50;
                }
            }
        }
        private int[,] RandomEl(int row1, int row2)
        {
            int[,] matrix = new int[row1,row2];
            Random el = new Random();
            for (int i = 0; i < row1; i++)
            {
                for (int j = 0; j < row2; j++)
                {
                    matrix[i, j] = el.Next(1, 100);
                }
            }
            return matrix;
        }
        private void NumericUpDown1_ValueChanged(object? sender, EventArgs e)
        {
            numericUpDown2.Value = numericUpDown1.Value;
        }
    }
}