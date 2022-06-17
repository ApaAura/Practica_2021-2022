namespace Tema1_Forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Default();
        }
        TextBox textBox, textBox1, textBox2;
        private void Default()
        {
            Size = new Size(500, 400);
            Text = "Tema 1";
            this.BackColor = Color.FromArgb(51,75,110);
            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            Panel panel = new Panel();
            panel.BackColor = Color.White;
            panel.Size = new Size(5,400);
            panel.Location = new Point(0,0);
            Controls.Add(panel);

            Panel panel1 = new Panel();
            panel1.BackColor = Color.White;
            panel1.Size = new Size(500, 5);
            panel1.Location = new Point(0, 356);
            Controls.Add(panel1);

            Panel panel2 = new Panel();
            panel2.BackColor = Color.White;
            panel2.Size = new Size(5,400);
            panel2.Location = new Point(479,0);
            Controls.Add(panel2);

            Label label=new Label();
            label.Text = "Ecuatie de gradul II";
            label.Font = new Font("Cambria", 16);
            label.ForeColor = Color.White;
            label.BackColor = Color.FromArgb(51, 75, 110);
            label.Location = new Point(140,90);
            label.Size = new Size(200,30);
            Controls.Add(label);

            textBox=new TextBox();
            textBox.Location = new Point(60,150);
            textBox.Size = new Size(50,90);
            textBox.KeyPress += textBox1_KeyPress;
            Controls.Add(textBox);

            Label label2=new Label();
            label2.Text = "X^2   +";
            label2.Font = new Font("Cambria", 16);
            label2.ForeColor = Color.White;
            label2.BackColor = Color.FromArgb(51, 75, 110);
            label2.Location= new Point(110,148);   
            label2.Size = new Size(90,30);
            Controls.Add(label2);

            textBox1=new TextBox();
            textBox1.Location = new Point(200, 150);
            textBox1.Size = new Size(50, 90);
            textBox1.KeyPress += textBox1_KeyPress;
            Controls.Add(textBox1);

            Label label1=new Label();
            label1.Text = "X    +";
            label1.Font = new Font("Cambria", 16);
            label1.Size= new Size(65,30);
            label1.Location= new Point(250,149);
            label1.ForeColor = Color.White;
            label1.BackColor = Color.FromArgb(51, 75, 110);
            Controls.Add(label1);

            textBox2 = new TextBox();
            textBox2.Location = new Point(320, 150);
            textBox2.Size = new Size(50, 90);
            textBox2.KeyPress += textBox1_KeyPress;
            Controls.Add(textBox2);

            Label label3 =new Label();
            label3.Font = new Font("Cambria", 16);
            label3.Text = "=  0";
            label3.Size = new Size(80, 30);
            label3.Location = new Point(380, 149);
            label3.ForeColor = Color.White;
            label3.BackColor = Color.FromArgb(51, 75, 110);
            Controls.Add(label3);

            Panel panel3=new Panel();
            panel3.BackColor = Color.White;
            panel3.Size = new Size(260, 1);
            panel3.Location = new Point(110,230);
            Controls.Add(panel3);

            Button button3=new Button();
            button3.Text = "Afla solutiile !";
            button3.Font = new Font("Cambria", 14);
            button3.Location = new Point(160,240);
            button3.Size = new Size(160,40);
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor= Color.White;
            button3.BackColor = Color.FromArgb(51, 75, 110);
            button3.Click += Button3_Click;
            Controls.Add(button3);
        }
        private void Button3_Click(object? sender, EventArgs e)
        {
            try
            {
                int A = int.Parse(textBox.Text);
                int B = int.Parse(textBox1.Text);
                int C = int.Parse(textBox2.Text);
                Rezolva(A, B, C);
            }
            catch (Exception)
            {
                MessageBox.Show("Introduceti date valide !");
            }
        }
        private static void Rezolva(int A, int B, int C)
        {
            if (A == 0)
            {
                MessageBox.Show($"Ecuatia este de gradul I !\nX = {- C / B}");
                return;
            }
            double delta = Math.Pow(B, 2) - 4 * A * C;
            if (delta < 0)
            {
                MessageBox.Show("Ecuatia nu are solutii in multimea numerelor reale !");
                return;
            }
            if (delta == 0)
            {
                MessageBox.Show($"Ecuatia are o solutie dubla !\nX = {-1 * B / 2 * A:F2} ");
                return;
            }
            MessageBox.Show($"X1 = {-B - Math.Sqrt(delta) / 2 * A:F2}\nX2 = {-B + Math.Sqrt(delta) / 2 * A:F2}");
        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.')&&(e.KeyChar != '-'))
            {
                e.Handled = true;
            }
        }
    }
}