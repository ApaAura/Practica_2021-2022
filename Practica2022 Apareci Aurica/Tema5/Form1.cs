namespace Tema5
{
    public partial class Form1 : Form
    {
        Random rnd = new Random(); 
        List<string> keeperPosition = new List<string> { "left", "right", "topsave", "topleft", "topright" };

        int ballX = 0; 
        int ballY = 0; 
        string state; 
        string playerTarget; 
        bool aimSet = false; 
        int goal;  int miss;
        public Form1()
        {
            InitializeComponent();
        }
        private void shootball(object sender, EventArgs e)
        {
            football.Left -= ballX; 
            football.Top -= ballY;
            if (football.Bounds.IntersectsWith(right.Bounds) && playerTarget == "right"
                || football.Bounds.IntersectsWith(topright.Bounds) && playerTarget == "topRight"
                || football.Bounds.IntersectsWith(top.Bounds) && playerTarget == "top"
                || football.Bounds.IntersectsWith(left.Bounds) && playerTarget == "left"
                || football.Bounds.IntersectsWith(topleft.Bounds) && playerTarget == "topLeft")
            {
                football.Left = 431; 
                football.Top = 500; 
                ballX = 0; 
                ballY = 0;
                aimSet = false;
                ballTimer.Stop(); 
            }
        }
        private void moveKeeper(object sender, EventArgs e)
        {
            switch (state)
            {
                case "left":
                    if (goalKeeper.Left > 192)
                    {
                        goalKeeper.Left -= 6;
                        goalKeeper.Top = 209;
                    }
                    else
                    {
                        goalKeeper.Left = 421;
                        goalKeeper.Top = 162;
                        goalKeeper.Image = Properties.Resources.stand_small;
                        keeperTimer.Stop();
                    } break;
                case "right":
                    if (goalKeeper.Left < 548)
                    {
                        goalKeeper.Left += 6;
                        goalKeeper.Top = 209;
                    }
                    else
                    {
                        goalKeeper.Left = 421;
                        goalKeeper.Top = 162;
                        goalKeeper.Image = Properties.Resources.stand_small;
                        keeperTimer.Stop();
                    } break;
                case "topleft":
                    if (goalKeeper.Top > 71)
                    {
                        goalKeeper.Left -= 8;
                        goalKeeper.Top -= 3;
                    }
                    else
                    {
                        goalKeeper.Left = 421;
                        goalKeeper.Top = 162;
                        goalKeeper.Image = Properties.Resources.stand_small;
                        keeperTimer.Stop();
                    } break;
                case "topright":
                    if (goalKeeper.Top > 71)
                    {
                        goalKeeper.Left += 5;
                        goalKeeper.Top -= 3;
                    }
                    else
                    {
                        goalKeeper.Left = 421;
                        goalKeeper.Top = 162;
                        goalKeeper.Image = Properties.Resources.stand_small;
                        keeperTimer.Stop();
                    } break;
                case "topsave":
                    if (goalKeeper.Top > 71)
                    {
                        goalKeeper.Top -= 3;
                    }
                    else
                    {
                        goalKeeper.Left = 421;
                        goalKeeper.Top = 162;
                        goalKeeper.Image = Properties.Resources.stand_small;
                        keeperTimer.Stop();
                    } break;
            }
        }
        private void setTarget(object sender, EventArgs e)
        {
            if (aimSet) { return; } 
            ballTimer.Start(); 
            keeperTimer.Start(); 
            changeState();
            var senderObject = (PictureBox)sender;
            senderObject.BackColor = Color.Beige;
            if (senderObject.Tag.ToString() == "topRight")
            {
                ballX = -7;
                ballY = 15; 
                playerTarget = senderObject.Tag.ToString();
                aimSet = true;
            }
            if (senderObject.Tag.ToString() == "right")
            {
                ballX = -11; 
                ballY = 15; 
                playerTarget = senderObject.Tag.ToString(); 
                aimSet = true; 
            }
            if (senderObject.Tag.ToString() == "top")
            {
                ballX = 0; 
                ballY = 20; 
                playerTarget = senderObject.Tag.ToString(); 
                aimSet = true; 
            }
            if (senderObject.Tag.ToString() == "left")
            {
                ballX = 7; 
                ballY = 11; 
                playerTarget = senderObject.Tag.ToString(); 
                aimSet = true;  
            }
            if (senderObject.Tag.ToString() == "topLeft")
            {
                ballX = 8; 
                ballY = 15; 
                playerTarget = senderObject.Tag.ToString(); 
                aimSet = true; 
            }
            checkScore(); 
        }
        private void checkScore()
        {
            if (state == "left" && playerTarget == "left"
                || state == "right" && playerTarget == "right"
                || state == "topsave" && playerTarget == "top"
                || state == "left" && playerTarget == "left"
                || state == "topleft" && playerTarget == "topLeft"
                || state == "topright" && playerTarget == "topRight")
            {
                miss++; 
                missText.Text = "Missed: " + miss; 
            }
            else
            {
                goal++; 
                goalText.Text = "Scored: " + goal; 
            }
        }
        private void changeState()
        {
            keeperTimer.Start();
            int i = rnd.Next(0, keeperPosition.Count);

            state = keeperPosition[i].ToString();
            switch (i)
            {
                case 0:
                    goalKeeper.Image = Properties.Resources.left_save_small;
                    break;
                case 1:
                    goalKeeper.Image = Properties.Resources.right_save_small;
                    break;
                case 2:
                    goalKeeper.Image = Properties.Resources.top_save_small;
                    break;
                case 3:
                    goalKeeper.Image = Properties.Resources.top_left_save_small;
                    break;
                case 4:
                    goalKeeper.Image = Properties.Resources.top_right_save_small;
                    break;
            }
        }
    }
}