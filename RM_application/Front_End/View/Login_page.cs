using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace RM_application.Front_End.View
{
    public partial class Login_page : Form
    {
        public Login_page()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //exits the program / closes it
            System.Environment.Exit(0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RM_application.Backend.Controller.Login_page_backend.findUser(textBox1.Text, textBox2.Text);
        }
    }
}
