using System;
using System.Windows.Forms;
using VI_VideoCleaner.Properties;

namespace VI_VideoCleaner
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Populate Location and Offset Fields
            string vidLoc = Settings.Default.VideoLocation;
            int offSet = Settings.Default.OffsetDays;

            tb_location.Text = vidLoc;
            tbOffset.Text = offSet.ToString();

        }

        private void btnStart_Click(object sender, EventArgs e)
        {

        }
    }
}
