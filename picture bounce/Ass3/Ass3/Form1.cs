namespace Ass3
{
    public partial class Form1 : Form
    {

        private Point currentDirection = new Point(0, 0);
        private PictureBox currentPictureBox = null;

        public Form1()
        {
            InitializeComponent();

            
        }

        private void orlandoContextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBoxJackosnville.Visible = false;
            pictureBoxMiami.Visible = false;
            pictureBoxOrlando.Visible = true;
            pictureBoxTampa.Visible = false;
        }

        private void miamiContextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBoxJackosnville.Visible = false;
            pictureBoxMiami.Visible = true;
            pictureBoxOrlando.Visible = false;
            pictureBoxTampa.Visible = false;
        }

        private void TampaContextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBoxJackosnville.Visible = false;
            pictureBoxMiami.Visible = false;
            pictureBoxOrlando.Visible = false;
            pictureBoxTampa.Visible = true;
        }

        private void jacksonvilleContextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBoxJackosnville.Visible = true;
            pictureBoxMiami.Visible = false;
            pictureBoxOrlando.Visible = false;
            pictureBoxTampa.Visible = false;
        }



        private void nEContextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetCurrentDirection(new Point(1, -1));
        }

        private void sEContextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetCurrentDirection(new Point(1, 1));
        }

        private void sWContextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetCurrentDirection(new Point(-1, 1));
        }

        private void nW_Click(object sender, EventArgs e)
        {
            SetCurrentDirection(new Point(-1, -1));
        }

        private void Form1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            movementTimer.Stop();
        }
        // 
        private void orlandoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetPictureBoxVisibility(pictureBoxOrlando);
        }

        private void tampaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetPictureBoxVisibility(pictureBoxTampa);
        }

        private void miamiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetPictureBoxVisibility(pictureBoxMiami);
        }

        private void jacksonvileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetPictureBoxVisibility(pictureBoxJackosnville);
        }

        private void SetPictureBoxVisibility(PictureBox selectedPictureBox)
        {
            pictureBoxJackosnville.Visible = false;
            pictureBoxMiami.Visible = false;
            pictureBoxOrlando.Visible = false;
            pictureBoxTampa.Visible = false;

            // Make only the selected picture box visible
            selectedPictureBox.Visible = true;

            // Assign the selected picture box to the current picture box field
            currentPictureBox = selectedPictureBox;
        }
        //
        private void nEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetCurrentDirection(new Point(1, -1));
        }

        private void sEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetCurrentDirection(new Point(1, 1));
        }

        private void sWToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetCurrentDirection(new Point(-1, 1));
        }

        private void nWToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetCurrentDirection(new Point(-1, -1));
        }

        private void SetCurrentDirection(Point direction)
        {
            currentDirection = direction;

            movementTimer.Start();
        }
        //
        private void movementTimer_Tick(object sender, EventArgs e)
        {
            if (currentPictureBox != null && currentDirection != Point.Empty)
            {
                Point newPosition = new Point(
                        currentPictureBox.Location.X + currentDirection.X * 8,
                        currentPictureBox.Location.Y + currentDirection.Y * 8
                    );

                if (newPosition.X >= 0 && newPosition.Y >= 0 &&
                newPosition.X <= this.ClientSize.Width - currentPictureBox.Width &&
                newPosition.Y <= this.ClientSize.Height - currentPictureBox.Height)
                {
                    // If within bounds, update PictureBox location
                    currentPictureBox.Location = newPosition;
                }
                else
                {
                    // If out of bounds, stop the PictureBox and timer
                    movementTimer.Stop();
                }

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            movementTimer.Enabled = false;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (movementTimer.Enabled)
            {
                movementTimer.Stop();
            }

            movementTimer.Dispose();
        }
    }
}
