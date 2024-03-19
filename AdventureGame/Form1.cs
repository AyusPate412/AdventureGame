using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdventureGame
{
    public partial class Form1 : Form
    {
        //Track what page you are on
        int page;
        public Form1()
        {
            InitializeComponent();
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            int page = 1;
        }
        private void displayPage()
        {
            switch (page)
            {
                case 1:
                    outputLabel.Text = "You are lost in a forest";
                    option1Label.Text = "Go North";
                    option2Label.Text = "Go South";
                    break;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void option1Label_Click(object sender, EventArgs e)
        {

        }
    }
    }
