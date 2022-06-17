using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tema4_Forms
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
            Default();
        }
        RichTextBox richTextBox, richTextBox1;
        private void Default()
        {
            Size = new Size(850, 550);
            Text = "Register";
            StartPosition = FormStartPosition.CenterScreen;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;

            Label label = new Label();
            label.Text = "Nume :";
            label.Size = new Size(100,50);
            label.Location = new Point(450,235);
            label.BackColor= Color.White;
            label.Font = new Font("Cambria", 20);
            Controls.Add(label); 
            
            Label label1 = new Label();
            label1.Text = "Prenume :";
            label1.Size = new Size(140, 50);
            label1.Location = new Point(410, 285);
            label1.BackColor = Color.White;
            label1.Font = new Font("Cambria", 20);
            Controls.Add(label1);

            richTextBox= new RichTextBox();
            richTextBox.Size = new Size(180,35);
            richTextBox.Location = new Point(550,235);
            richTextBox.BackColor = Color.FromArgb(241, 241, 241);
            richTextBox.Font = new Font("Cambria", 16);
            Controls.Add(richTextBox);

            richTextBox1= new RichTextBox();
            richTextBox1.Size = new Size(180, 35);
            richTextBox1.Location = new Point(550, 285);
            richTextBox1.BackColor = Color.FromArgb(241, 241, 241);
            richTextBox1.Font = new Font("Cambria", 16);
            Controls.Add(richTextBox1);

            Button button= new Button();
            button.Text = "Start";
            button.Font = new Font("Cambria", 18);
            button.Location = new Point(460,350);
            button.Size = new Size(100, 35);
            button.FlatStyle = FlatStyle.Flat;
            button.ForeColor = Color.FromArgb(34, 42, 53);
            button.BackColor = Color.White;
            button.Click += Button_Click;
            Controls.Add(button);

            Button button1 = new Button();
            button1.Text = "Iesire";
            button1.Font = new Font("Cambria", 18);
            button1.Location = new Point(580, 350);
            button1.Size = new Size(100, 35);
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.FromArgb(34, 42, 53);
            button1.BackColor = Color.White;
            button1.Click += Button1_Click;
            Controls.Add(button1);
        }
        private void Button1_Click(object? sender, EventArgs e)
        {
            MessageBox.Show("Aplicatia a fost inchisa !");
            Environment.Exit(0);
        }
        private void Button_Click(object? sender, EventArgs e)
        {
            try
            {
                string Nume = richTextBox.Text;
                string Prenume = richTextBox1.Text;
                if (Nume.Length==0)
                {
                    throw new Exception();
                }
                if (Prenume.Length==0)
                {
                    throw new Exception();
                }
                this.Hide();
                Form2 form2 = new Form2();
                form2.ShowDialog();
            }
            catch (Exception)
            {
                MessageBox.Show("Nu ati introdus date !");
            }
        }
    }
}
