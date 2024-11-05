using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace adventure_game
{
    public partial class Form1 : Form
    {
        int page = 1;
        public Form1()
        {
            InitializeComponent();
            DisplayPage();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void optionButton1_Click(object sender, EventArgs e)
        {
            if(page == 1)
            {
                page = 2;
            }
            else if (page == 2)
            {
                page = 1;
            }

            else if (page == 3)
            {
                page = 4;
            }

            else if (page == 4)
            {
                page = 1;
            }

            else if (page == 5)
            {
                page = 6;
            }

            else if (page == 6)
            {
                page = 8;
            }

            else if (page == 7)
            {
                page = 1;
            }

            else if (page == 8)
            {
                page = 10;
            }

            else if (page == 9)
            {
                page = 12;
            }

            else if (page == 10)
            {
                page = 1;
            }

            else if (page == 11)
            {
                page = 14;
            }

            else if (page == 12)
            {
                page = 1;
            }

            else if (page == 13)
            {
                page = 15;
            }

            else if (page == 14)
            {
                page = 1;
            }

            else if (page == 15)
            {
                page = 1;
            }

            else if (page == 16)
            {
                page = 18;
            }

            else if (page == 17)
            {
                page = 1;
            }

            else if (page == 18)
            {
                page = 1;
            }

            else if (page == 19)
            {
                page = 20;
            }

            else if (page == 20)
            {
                page = 1;
            }

            else if (page == 21)
            {
                page = 99;
            }

            DisplayPage();  
        }

        private void optionButton2_Click(object sender, EventArgs e)
        {
            if (page == 1)
            {
                page = 3;
            }

            else if (page == 2)
            {
                page = 99;
            }

            else if (page == 3)
            {
                page = 5;
            }
          
            else if (page == 4)
            {
                page = 99;
            }

            else if (page == 5)
            {
                page = 7;
            }

            else if (page == 6)
            {
                page = 9;
            }

            else if (page == 7)
            {
                page = 99;
            }

            else if (page == 8)
            {
                page = 11;
            }

            else if (page == 9)
            {
                page = 13;
            }

            else if (page == 10)
            {
                page = 99;
            }

            else if (page == 11)
            {
                page = 17;
            }

            else if (page == 12)
            {
                page = 99;
            }

            else if (page == 13)
            {
                page = 16;
            }

            else if (page == 14)
            {
                page = 99;
            }

            else if (page == 15)
            {
                page = 99;
            }

            else if (page == 16)
            {
                page = 19;
            }

            else if (page == 17)
            {
                page = 99;
            }

            else if (page == 18)
            {
                page = 99;
            }

            else if (page == 19)

            {
                page = 21;
            }

            else if (page == 20)
            {
                page = 99;
            }

            else if (page == 21)
            {
                page = 99;
            }

            DisplayPage();
        }

        public void DisplayPage()
        {
            switch (page)
            {
                case 1:
                    outputLabel.Text = "You need to excape prison, do you attempt to steal the cell key?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    break;
                case 2:
                    outputLabel.Text = "You get caught and get the death penaulty. PLay again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    break;
                case 3:
                    outputLabel.Text = "Your cellmate already happens to have the key! Do you escape with him?";
                    option1Label.Text = "No";
                    option2Label.Text = "Yes";
                    break;
                case 4:
                    outputLabel.Text = "You never escape again. Play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";

                    break;
                case 5:
                    outputLabel.Text = "You make it to the prison fence, do you climb it or steal a car?";
                    option1Label.Text = "Climb";
                    option2Label.Text = "Steal a car";

                    break;
                case 6:
                    outputLabel.Text = "You make it over, do you run to the country or to the city?";
                    option1Label.Text = "Country";
                    option2Label.Text = "City";

                    break;
                case 7:
                    outputLabel.Text = "You drive the car out of prison unnoticed, until the car breaks down in the woods and a mountain lion eats you. Play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";

                    break;
                case 8:
                    outputLabel.Text = "You're hiding out in a farmer's barn and you need food, do enter his house to steal his food?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    break;
                case 9:
                    outputLabel.Text = "You're hiding out in an abandonned garage and you need food, do you go to Circle K";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    break;
                case 10:
                    outputLabel.Text = "You get shot by the farmer on sight. PLay again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    break;
                case 11:
                    outputLabel.Text = "He becomes your friend and drives you to the airport. How to you sneak on a plane?";
                    option1Label.Text = "In a suitcase";
                    option2Label.Text = "Fake flight attendant";
                    break;
                case 12:
                    outputLabel.Text = "You get spotted and arrested. PLay again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";

                    break;
                case 13:
                    outputLabel.Text = "You find garbage food to eat. Do you eat it?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";

                    break;
                case 14:
                    outputLabel.Text = "They find you. PLay again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";

                    break;
                case 15:
                    outputLabel.Text = "It's poisoned. PLay again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";

                    break;
                case 16:
                    outputLabel.Text = "You stumble across a homeless shelter to eat. After that, do you steal a car?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";

                    break;
                case 17:
                    outputLabel.Text = "You make it out of the country and you win! PLay again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";

                    break;
                case 18:
                    outputLabel.Text = "The police find you. PLay again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";

                    break;
                case 19:
                    outputLabel.Text = "You flee the city! What border do you cross?";
                    option1Label.Text = "Canada";
                    option2Label.Text = "Mexico";

                    break;
                case 20:
                    outputLabel.Text = "You get caught by the cartel and they murder you. PLay again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";

                    break;
                case 21:
                    outputLabel.Text = "You flee and you win!. PLay again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";

                    break;
                case 99:
                    outputLabel.Text = outputLabel.Text = "Thank you for playinhg!";
                    option1Label.Text = "...";
                    option2Label.Text = "...";
                    Refresh();
                    Thread.Sleep(2000);
                    Application.Exit();

                    break;
                default:
                    break;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
