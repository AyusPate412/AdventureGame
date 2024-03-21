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
        private void option2Button_Click(object sender, EventArgs e)
        {
            if (page == 1)
            {
                page = 3;    
            }
            
            else if (page == 2)
            {
                page = 5;
            }
            else if (page == 3)
            {
                page = 25;
            }
            // Have to code the process here
            else if (page == 4)
            {
                page = 1;
            }
            else if (page == 5)
            {
                page = 10;
            }
            else if (page == 6)
            {
                page = 5;
            }
            else if (page == 7)
            {
                page = 5;
            }
            else if (page == 8)
            {
                page = 5;
            }
            else if (page == 9)
            {
                page = 5;
            }
            else if (page == 10)
            {
                page = 5;
            }
            else if (page == 11)
            {
                page = 5;
            }
            else if (page == 12)
            {
                page = 5;
            }
            else if (page == 13)
            {
                page = 5;
            }
            else if (page == 14)
            {
                page = 5;
            }
            else if (page == 15)
            {
                page = 5;
            }
            else if (page == 16)
            {
                page = 5;
            }
            else if (page == 17)
            {
                page = 5;
            }
            else if (page == 18)
            {
                page = 5;
            }
            else if (page == 19)
            {
                page = 5;
            }
            else if (page == 20)
            {
                page = 5;
            }
            else if (page == 21)
            {
                page = 5;
            }
            
            
            
            

            DisplayPage();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void option1Label_Click(object sender, EventArgs e)
        {

        }
    }
    }
