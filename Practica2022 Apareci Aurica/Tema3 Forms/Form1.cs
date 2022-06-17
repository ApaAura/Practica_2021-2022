namespace Tema3_Forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Default();
        }
        TextBox Autor, Titlu, Editura, NrPagini;
        NumericUpDown numericUpDown1;
        DataGridView dataGridView;
        DateTimePicker dateTimePicker;
        PictureBox pictureBox1;
        private void Default()
        {
            Size = new Size(600, 650);
            Text = "Tema 3";
            BackColor = Color.FromArgb(51, 75, 110);
            StartPosition = FormStartPosition.CenterScreen;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            ControlBox = false;

            Panel panel = new Panel();
            panel.BackColor = Color.White;
            panel.Size = new Size(5, 650);
            panel.Location = new Point(0, 0);
            Controls.Add(panel);

            Panel panel1 = new Panel();
            panel1.BackColor = Color.White;
            panel1.Size = new Size(600, 5);
            panel1.Location = new Point(0, 606);
            Controls.Add(panel1);

            Panel panel2 = new Panel();
            panel2.BackColor = Color.White;
            panel2.Size = new Size(5, 700);
            panel2.Location = new Point(579, 0);
            Controls.Add(panel2);

            pictureBox1 = new PictureBox();
            pictureBox1.Image = new Bitmap("Logo.png");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Size = new Size(50,30);
            pictureBox1.Location = new Point(35,30);
            pictureBox1.MouseHover += pictureBox1_MouseHover;
            Controls.Add(pictureBox1);

            Label label =new Label();
            label.Text = "inLibrary";
            label.Font = new Font("Cambria", 20);
            label.ForeColor = Color.White;
            label.BackColor = Color.FromArgb(51, 75, 110);
            label.Location = new Point(80,28);
            label.Size = new Size(150,40);
            Controls.Add(label);

            Label label1=new Label();
            label1.Text = "ID inregistrare:";
            label1.Font = new Font("Cambria", 16);
            label1.ForeColor = Color.White;
            label1.BackColor = Color.FromArgb(51, 75, 110);
            label1.Location = new Point(40,80);
            label1.Size = new Size(170,30);
            Controls.Add(label1);

            numericUpDown1 = new NumericUpDown();
            numericUpDown1.Value = 0;
            numericUpDown1.Maximum = 150;
            numericUpDown1.Minimum = 1;
            numericUpDown1.Enabled = false;
            numericUpDown1.Location = new Point(210,84);
            numericUpDown1.Size = new Size(60, 40);
            Controls.Add(numericUpDown1);

            GroupBox groupBox1 = new GroupBox();
            groupBox1.Size = new Size(500,190);
            groupBox1.Location = new Point(40,108);
            groupBox1.Text = "Datele cartii :";
            groupBox1.ForeColor = Color.White;
            groupBox1.Font = new Font("Cambria", 16);

            Label label2=new Label();
            label2.Text = "Autorul:";
            label2.ForeColor = Color.White;
            label2.BackColor = Color.FromArgb(51, 75, 110);
            label2.Location = new Point(70,30);
            label2.Size = new Size(150,30);
            groupBox1.Controls.Add(label2);
            Controls.Add(groupBox1);

            Autor = new TextBox();
            Autor.Size = new Size(170,10);    
            Autor.Location = new Point(230,30);
            Autor.Font = new Font("Cambria", 10);
            groupBox1.Controls.Add(Autor);

            Label label3=new Label();
            label3.Text = "Titlul:";
            label3.ForeColor = Color.White;
            label3.BackColor = Color.FromArgb(51, 75, 110);
            label3.Location = new Point(70, 60);
            label3.Size = new Size(150, 30);
            groupBox1.Controls.Add(label3);

            Titlu = new TextBox();
            Titlu.Size = new Size(170,10);
            Titlu.Location = new Point(230,60);
            Titlu.Font = new Font("Cambria", 10);
            groupBox1.Controls.Add(Titlu);

            Label label4=new Label();
            label4.Text = "Editura: ";
            label4.ForeColor = Color.White;
            label4.BackColor = Color.FromArgb(51, 75, 110);
            label4.Location = new Point(70,90);
            label4.Size = new Size(150,30);
            groupBox1.Controls.Add(label4);

            Editura = new TextBox();
            Editura.Size = new Size(170,30);
            Editura.Location = new Point(230,90);
            Editura.Font = new Font("Cambria", 10);
            groupBox1.Controls.Add(Editura);

            Label label5=new Label();
            label5.Text = "Numar pagini: ";
            label5.ForeColor = Color.White;
            label5.BackColor = Color.FromArgb(51, 75, 110);
            label5.Location = new Point(70,120);
            label5.Size = new Size(160,30);
            groupBox1.Controls.Add(label5);

            NrPagini= new TextBox();
            NrPagini.Size = new Size(170,30);
            NrPagini.Location = new Point(230,120);
            NrPagini.Font = new Font("Cambria", 10);
            groupBox1.Controls.Add(NrPagini);

            Label label6=new Label();
            label6.Text = "Anul aparitiei: ";
            label6.ForeColor = Color.White;
            label6.BackColor = Color.FromArgb(51, 75, 110);
            label6.Location = new Point(70,150);
            label6.Size = new Size(150,30);
            groupBox1.Controls.Add(label6);

            dateTimePicker=new DateTimePicker();
            dateTimePicker.Size = new Size(170,30);
            dateTimePicker.Location = new Point(230,150);
            dateTimePicker.Font = new Font("Cambria", 10);
            groupBox1.Controls.Add(dateTimePicker);

            GroupBox groupBox=new GroupBox();
            groupBox.Text = "Lista cartilor :";
            groupBox.Location = new Point(40,300);
            groupBox.Size = new Size(500, 220);
            groupBox.ForeColor = Color.White;
            groupBox.Font = new Font("Cambria", 16);
            Controls.Add(groupBox);

            dataGridView=new DataGridView();
            dataGridView.Size = new Size(470,175);
            dataGridView.Location = new Point(15,30);
            dataGridView.BackgroundColor= Color.FromArgb(44, 66, 97);
            dataGridView.ForeColor = Color.Black;
            dataGridView.Font = new Font("Cambria",12);
            dataGridView.RowHeadersWidth= 4;
            dataGridView.AutoSizeColumnsMode=DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView.DataSource = carti;
            groupBox.Controls.Add(dataGridView);

            Button button = new Button();
            button.Text = "Inregistrare";
            button.Font = new Font("Cambria", 14);
            button.Location = new Point(35, 545);
            button.Size = new Size(120, 40);
            button.FlatStyle = FlatStyle.Flat;
            button.ForeColor = Color.White;
            button.BackColor = Color.FromArgb(51, 75, 110);
            button.Click += Button_Click;
            Controls.Add(button);

            Button button1 = new Button();
            button1.Text = "Salvare";
            button1.Font = new Font("Cambria", 14);
            button1.Location = new Point(165,545);
            button1.Size = new Size(120,40);
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.BackColor = Color.FromArgb(51, 75, 110);
            button1.Click += Button1_Click;
            Controls.Add(button1);

            Button button2=new Button();
            button2.Text = "Deschide";
            button2.Font = new Font("Cambria", 14);
            button2.Location = new Point(295,545);
            button2.Size = new Size(120,40);
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.White;
            button2.BackColor = Color.FromArgb(51, 75, 110);
            button2.Click += Button2_Click;
            Controls.Add(button2);

            Button button3=new Button();
            button3.Text = "Sortare";
            button3.Font = new Font("Cambria", 14);
            button3.Location = new Point(425,545);
            button3.Size = new Size(120,40);
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = Color.White;
            button3.BackColor = Color.FromArgb(51, 75, 110);
            button3.Click += Button3_Click;
            Controls.Add(button3);

            Button button4=new Button();
            button4.Font = new Font("Cambria", 12);
            button4.Text = "Close";
            button4.Location = new Point(460,30);
            button4.Size = new Size(80,25);
            button4.FlatStyle = FlatStyle.Flat;
            button4.ForeColor = Color.White;
            button4.BackColor = Color.FromArgb(51, 75, 110);
            button4.Click += Button4_Click;
            Controls.Add(button4);
        }
        List<Biblioteca> carti = new List<Biblioteca>();
        private void Button3_Click(object? sender, EventArgs e)
        {
            SortInfo info = new SortInfo(carti);
            info.ShowDialog();
        }
        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            ToolTip tt = new ToolTip();
            tt.SetToolTip(this.pictureBox1, "Add a book");
        }
        private void Button4_Click(object? sender, EventArgs e)
        {
            this.Close();
        }
        private void Button2_Click(object? sender, EventArgs e)
        {
            carti = new List<Biblioteca>();
            if (File.Exists("date.txt"))
            {
                if (File.ReadAllText("date.txt") != null)
                {
                    try
                    {
                        using (StreamReader sr = new StreamReader(new FileStream("date.txt", FileMode.Open)))
                        {
                            int nr = int.Parse(sr.ReadLine());
                            string[] linie = null;
                            for (int i = 0; i < nr; i++)
                            {
                                linie = sr.ReadLine().Split("_");
                                carti.Add(new Biblioteca(carti.Count,linie[1],linie[2], linie[3],DateOnly.Parse(linie[4]),int.Parse(linie[5])));
                            }
                        }
                    }
                    catch (Exception)
                    { MessageBox.Show("Fisierul a fost gasit, insa nu este formatat corect."); }
                }
                else { MessageBox.Show("Fisierul a fost gasit, insa nu este formatat corect."); }
            }
            else { MessageBox.Show("Fisierul nu a fost gasit."); }
            dataGridView.DataSource = carti;
        }
        private void Button1_Click(object? sender, EventArgs e)
        {
            try
            {
                if (carti.Count != 0)
                {
                    using (StreamWriter sw = new StreamWriter(new FileStream("date.txt", FileMode.Create)))
                    {
                        sw.WriteLine(carti.Count);
                        foreach (var item in carti)
                        {
                            sw.WriteLine($"{item.ID}_{item.Autorul}_{item.Titlu}_{item.Editura}_{item.Anul_Aparitiei}_{item.NrPagini}");
                        }
                    }
                    MessageBox.Show("Fisierul a fost creat cu succes !");
                }
                else
                {
                    MessageBox.Show("Asigurati-va ca a-ti inregistrat cartile mai intai.");
                }
            }
            catch (Exception)
            { MessageBox.Show("Ceva nu a mers cum trebuie, m-ai incercati o data"); }
        }
        private void Button_Click(object? sender, EventArgs e)
        {
            int nrInregistrare=1;
            string autor="";
            string titlu="";
            string editura="";
            DateOnly anulAparitiei=new DateOnly();
            int nrPagini=0;
            try
            {
                nrInregistrare = (int)numericUpDown1.Value;
                autor = Autor.Text;
                if (autor.Length == 0)
                {
                    throw new Exception();
                }
                titlu =Titlu.Text;
                if (titlu.Length == 0)
                {
                    throw new Exception();
                }
                editura=Editura.Text;
                if (editura.Length == 0)
                {
                    throw new Exception();
                }
                anulAparitiei = new DateOnly(dateTimePicker.Value.Year, dateTimePicker.Value.Month, dateTimePicker.Value.Day);
                nrPagini = int.Parse(NrPagini.Text);
                Biblioteca carte = new Biblioteca(nrInregistrare, autor, titlu, editura, anulAparitiei, nrPagini);
                carti.Add(carte);
                MessageBox.Show($"Cartea a fost inregistrata cu succes !");
                numericUpDown1.Value+=1; Autor.Clear(); Titlu.Clear(); Editura.Clear(); NrPagini.Clear();
                dataGridView.DataSource = null;
                dataGridView.DataSource = carti;
            }
            catch (Exception)
            {
                MessageBox.Show("Introduceti date valide !");
            }
        }
    }
}