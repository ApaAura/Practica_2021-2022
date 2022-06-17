using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tema3_Forms
{
    public partial class SortInfo : Form
    {
        public List<Biblioteca> Carti { get; set; }
        public SortInfo(List<Biblioteca> carti)
        {
            InitializeComponent();
            Carti = carti;
            Default1();
        }
        TextBox textBox;
        DataGridView dataGridView;
        private void Default1()
        {
            Size = new Size(600, 350);
            Text = "SortInfo";
            BackColor = Color.FromArgb(51, 75, 110);
            StartPosition = FormStartPosition.CenterScreen;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            ControlBox = false;
            MaximizeBox = false;
            MinimizeBox = false;

            Panel panel = new Panel();
            panel.BackColor = Color.White;
            panel.Size = new Size(5, 400);
            panel.Location = new Point(0, 0);
            Controls.Add(panel);

            Panel panel1 = new Panel();
            panel1.BackColor = Color.White;
            panel1.Size = new Size(600, 5);
            panel1.Location = new Point(0, 306);
            Controls.Add(panel1);

            Panel panel2 = new Panel();
            panel2.BackColor = Color.White;
            panel2.Size = new Size(5, 400);
            panel2.Location = new Point(579, 0);
            Controls.Add(panel2);

            Label label = new Label();
            label.Font = new Font("Cambria", 16);
            label.ForeColor = Color.White;
            label.BackColor = Color.FromArgb(51, 75, 110);
            label.Size = new Size(560,60);
            label.Location = new Point(50,10);
            label.Text = "Sortare alfabetica dupa numele autorului a cartilor\n                  aparute dupa anul specificat!";
            Controls.Add(label);

            Panel panel3 = new Panel();
            panel3.BackColor = Color.White;
            panel3.Size = new Size(100, 1);
            panel3.Location = new Point(240, 74);
            Controls.Add(panel3);

            Label label1 = new Label();
            label1.Font = new Font("Cambria", 14);
            label1.ForeColor = Color.White;
            label1.BackColor = Color.FromArgb(51, 75, 110);
            label1.Size = new Size(170, 30);
            label1.Location = new Point(170, 85);
            label1.Text = "Introduceti anul :";
            Controls.Add(label1);

            textBox = new TextBox();
            textBox.Location = new Point(340,87);
            textBox.Size = new Size(100,40);
            Controls.Add(textBox);

            dataGridView = new DataGridView();
            dataGridView.Size = new Size(510, 145);
            dataGridView.Location = new Point(40, 115);
            dataGridView.BackgroundColor = Color.FromArgb(44, 66, 97);
            dataGridView.ForeColor = Color.Black;
            dataGridView.Font = new Font("Cambria", 12);
            dataGridView.RowHeadersWidth = 4;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            Controls.Add(dataGridView);

            Button button4 = new Button();
            button4.Font = new Font("Cambria", 12);
            button4.Text = "Show";
            button4.Location = new Point(200, 270);
            button4.Size = new Size(80, 25);
            button4.FlatStyle = FlatStyle.Flat;
            button4.ForeColor = Color.White;
            button4.BackColor = Color.FromArgb(51, 75, 110);
            button4.Click += Show_Click;
            Controls.Add(button4);

            Button button5 = new Button();
            button5.Font = new Font("Cambria", 12);
            button5.Text = "Close";
            button5.Location = new Point(295, 270);
            button5.Size = new Size(80, 25);
            button5.FlatStyle = FlatStyle.Flat;
            button5.ForeColor = Color.White;
            button5.BackColor = Color.FromArgb(51, 75, 110);
            button5.Click += Close_Click1;
            Controls.Add(button5);
        }
        private void Close_Click1(object? sender, EventArgs e)
        {
            this.Close();
        }
        public int selected { get; set; }
        private void Show_Click(object? sender, EventArgs e)
        {
            try
            {
                selected = int.Parse(textBox.Text);
                List<Biblioteca> s = (from c in Carti where c.Anul_Aparitiei.Year >= selected orderby c.Autorul select c).ToList();
                dataGridView.DataSource = s;
            }
            catch (Exception)
            {
                MessageBox.Show("Introduceti date valide !");
            }
        }
    }
}
