namespace Tema4_Forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Default();
        }
        private void Default()
        {
            Size = new Size(850, 550);
            Text = "Quizz Istoria Moldovei";
            StartPosition = FormStartPosition.CenterScreen;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;

            Label label=new Label();
            label.Text = "Istoria Moldovei";
            label.Location = new Point(105,215);
            label.Size = new Size(300,40);
            label.Font = new Font("Cambria", 30);
            label.ForeColor = Color.White;
            label.BackColor = Color.FromArgb(0, 0, 172);
            Controls.Add(label);

            Label label1 = new Label();
            label1.Text = "Quiz GAME";
            label1.Location = new Point(198, 280);
            label1.Size = new Size(200, 40);
            label1.Font = new Font("Cambria", 15);
            label1.ForeColor = Color.White;
            label1.BackColor = Color.FromArgb(0, 0, 172);
            Controls.Add(label1);

            Button button=new Button();
            button.Text = "Inregistrare";
            button.Location = new Point(155,340);
            button.Font = new Font("Cambria", 14);
            button.Size = new Size(200,30);
            button.FlatStyle = FlatStyle.Flat;
            button.ForeColor = Color.White;
            button.BackColor = Color.FromArgb(0, 0, 172);
            button.Click += Button_Click;
            Controls.Add(button);
        }
        private void Button_Click(object? sender, EventArgs e)
        {
            LogIn form = new LogIn();
            this.Hide();
            form.ShowDialog();
        }
    }
}