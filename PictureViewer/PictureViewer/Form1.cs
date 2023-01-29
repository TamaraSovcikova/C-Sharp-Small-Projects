namespace PictureViewer
{

    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void backgroundButton_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog1 = new ColorDialog();
            colorDialog1.AllowFullOpen = false;
            // Allows the user to get help. (The default is false.)
            colorDialog1.ShowHelp = true;
            // Sets the initial color select to the current text color.
            colorDialog1.Color = pictureBox1.BackColor;
            
            // Show the color dialog box. If the user clicks OK, change the
            // PictureBox control's background to the color the user chose.
            if (colorDialog1.ShowDialog() == DialogResult.OK)
                pictureBox1.BackColor = colorDialog1.Color;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            //Close the form
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void showButton_Click(object sender, EventArgs e)
        {
            //Show the Open File dialog. If the user clicks OK, load the 
            //picture that the user chose. 
            if(openFileDialog1.ShowDialog() == 
                DialogResult.OK)
            {
                pictureBox1.Load(openFileDialog1.FileName);
            }
          
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            //Clear the picture
            pictureBox1.Image=null;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            // If the user selects the Stretch check box, 
            // change the PictureBox's SizeMode property to "Stretch".
            // If the user clears the check box, change it to "Normal".
            if (checkBox1.Checked)
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            else
                pictureBox1.SizeMode = PictureBoxSizeMode.Normal;
        }
    }
}