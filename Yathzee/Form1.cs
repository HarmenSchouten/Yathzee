using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yathzee
{
    public partial class Form1 : Form
    {
        int attempts = 3;

        bool pin_dice1 = false;
        bool pin_dice2 = false;
        bool pin_dice3 = false;
        bool pin_dice4 = false;
        bool pin_dice5 = false;

        Image dice1 = Yathzee.Properties.Resources._1;
        Image dice2 = Yathzee.Properties.Resources._2;
        Image dice3 = Yathzee.Properties.Resources._3;
        Image dice4 = Yathzee.Properties.Resources._4;
        Image dice5 = Yathzee.Properties.Resources._5;
        Image dice6 = Yathzee.Properties.Resources._6;

        Image dice1_red = Yathzee.Properties.Resources._1_red;
        Image dice2_red = Yathzee.Properties.Resources._2_red;
        Image dice3_red = Yathzee.Properties.Resources._3_red;
        Image dice4_red = Yathzee.Properties.Resources._4_red;
        Image dice5_red = Yathzee.Properties.Resources._5_red;
        Image dice6_red = Yathzee.Properties.Resources._6_red;

        public Form1()
        {
            InitializeComponent();
            setupLabels();
            setupSmallDices();
            setupButtons();
            setupDicesOnRow();
            setReadOnlys();
            //rollDices(true, true, true, true, true, true);
        }

        protected void rollDice_Click(object sender, EventArgs e)
        {
            if (attempts <= 3 && attempts > 0)
            {
                attempts -= 1;
                rollDices(true, true, true, true, true, true);
                label2.Text = attempts + " attempts left";
                if (attempts == 0)
                {
                    rollDice.Enabled = false;
                }
            }
            else
            {
                rollDice.Enabled = false;
            }
        }

        protected void setupDicesOnRow()
        {
            dice_1.Image = dice1;
            dice_2.Image = dice2;
            dice_3.Image = dice3;
            dice_4.Image = dice4;
            dice_5.Image = dice5;
        }

        protected void setupLabels()
        {
            //label 2
            label2.Text = "";
            label2.ForeColor = Color.ForestGreen;

            //label 3
            label3.Text = "All the aces";

            //label4
            label4.Text = "All the twos";

            //label5
            label5.Text = "All the threes";

            //label6
            label6.Text = "All the fours";

            //label7
            label7.Text = "All the fives";

            //label8
            label8.Text = "All the sixes";

            //label9
            label9.Text = "";

            //label10
            label10.Text = "35 points";

            //label11
            label11.Text = "";

            //label12
            label12.Text = "Total of 5 dices";

            //label13
            label13.Text = "Total of 5 dices";

            //label14
            label14.Text = "25 points";

            //label15
            label15.Text = "30 points";

            //label16
            label16.Text = "40 points";

            //label 17
            label17.Text = "50 points";

            //label18
            label18.Text = "Total of 5 dices";

            label19.Text = "";
            label20.Text = "";
        }

        protected void setupButtons()
        {
            //button 1 (roll dice)
            rollDice.Text = "Roll the dices";
            rollDice.BackColor = Color.ForestGreen;
            rollDice.ForeColor = Color.White;
        }

        protected void setupSmallDices()
        {
            Dice1_small.Image = dice1;
            Dice2_small.Image = dice2;
            Dice3_small.Image = dice3;
            Dice4_small.Image = dice4;
            Dice5_small.Image = dice5;
            Dice6_small.Image = dice6;
        }

        protected void setReadOnlys()
        {
            ones.ReadOnly = true;
            twos.ReadOnly = true;
            threes.ReadOnly = true;
            fours.ReadOnly = true;
            fives.ReadOnly = true;
            sixes.ReadOnly = true;
            totalExBonus.ReadOnly = true;
            bonus.ReadOnly = true;
            TotalUpper.ReadOnly = true;

            three_kind.ReadOnly = true;
            carre.ReadOnly = true;
            full_house.ReadOnly = true;
            small_street.ReadOnly = true;
            big_street.ReadOnly = true;
            yathzee.ReadOnly = true;
            change.ReadOnly = true;

            totalDown.ReadOnly = true;
            totalUpper_1.ReadOnly = true;
            total_general.ReadOnly = true;
        }

        protected void rollDices(bool Dice1, bool Dice2, bool Dice3, bool Dice4, bool Dice5, bool Dice6)
        {
            Random rnd = new Random();
            if (pin_dice1 == false)
            {
                int dice = rnd.Next(1, 7);
                dice_1.Image = getImage(dice);
            }
            if (pin_dice2 == false)
            {
                int dice = rnd.Next(1, 7);
                dice_2.Image = getImage(dice);
            }
            if (pin_dice3 == false)
            {
                int dice = rnd.Next(1, 7);
                dice_3.Image = getImage(dice);
            }
            if (pin_dice4 == false)
            {
                int dice = rnd.Next(1, 7);
                dice_4.Image = getImage(dice);
            }
            if (pin_dice5 == false)
            {
                int dice = rnd.Next(1, 7);
                dice_5.Image = getImage(dice);
            }
        }

        protected Image getImage(int dice)
        {
            switch (dice)
            {
                case 1:
                    return dice1;
                    break;
                case 2:
                    return dice2;
                    break;
                case 3:
                    return dice3;
                    break;
                case 4:
                    return dice4;
                    break;
                case 5:
                    return dice5;
                    break;
                case 6:
                    return dice6;
                    break;
                default:
                    return dice1;
                    break;
            }
        }

        protected Image getImageOfBox(int pictureBox)
        {
            switch (pictureBox)
            {
                case 1:
                    return dice_1.Image;
                case 2:
                    return dice_2.Image;
                case 3:
                    return dice_3.Image;
                case 4:
                    return dice_4.Image;
                case 5:
                    return dice_5.Image;
                default:
                    return dice_1.Image;
            }
        }

        protected Image getOppositeImage(Image dicu)
        {
            if (dicu == dice1)
            {
                return dice1_red;
            } else if (dicu == dice1_red)
            {
                return dice1;
            } else if (dicu == dice2)
            {
                return dice2_red;
            } else if (dicu == dice2_red)
            {
                return dice2;
            } else if (dicu == dice3)
            {
                return dice3_red;
            } else if (dicu == dice3_red)
            {
                return dice3;
            } else if (dicu == dice4)
            {
                return dice4_red;
            } else if (dicu == dice4_red)
            {
                return dice4;
            } else if (dicu == dice5)
            {
                return dice5_red;
            } else if (dicu == dice5_red)
            {
                return dice5;
            } else if (dicu == dice6)
            {
                return dice6_red;
            } else
            {
                return dice6;
            }
        }

        protected Array getImageArray()
        {
            Image[] dices = new Image[6] { dice1, dice2, dice3, dice4, dice5, dice6 };
            return dices;
        }

        protected Array getPictureBoxes()
        {
            Image[] picBoxes = new Image[5] { dice_1.Image, dice_2.Image, dice_3.Image, dice_4.Image, dice_5.Image };
            return picBoxes;
        }

        protected void PinnImage(int pcBox)
        {
            Image pinnedDice = getImageOfBox(pcBox);
            switch (pcBox)
            {
                case 1:
                    dice_1.Image = getOppositeImage(pinnedDice);
                    break;
                case 2:
                    dice_2.Image = getOppositeImage(pinnedDice);
                    break;
                case 3:
                    dice_3.Image = getOppositeImage(pinnedDice);
                    break;
                case 4:
                    dice_4.Image = getOppositeImage(pinnedDice);
                    break;
                case 5:
                    dice_5.Image = getOppositeImage(pinnedDice);
                    break;
            }
        }

        private int compareImages(int number, int dice_int)
        {
            int value = 0;
            Image dice;
            Image dice_red;
            switch (dice_int)
            {
                case 1:
                    dice = dice1;
                    dice_red = dice1_red;
                    break;
                case 2:
                    dice = dice2;
                    dice_red = dice2_red;
                    break;
                case 3:
                    dice = dice3;
                    dice_red = dice3_red;
                    break;
                case 4:
                    dice = dice4;
                    dice_red = dice4_red;
                    break;
                case 5:
                    dice = dice5;
                    dice_red = dice5_red;
                    break;
                case 6:
                    dice = dice6;
                    dice_red = dice6_red;
                    break;
                default:
                    dice = dice1;
                    dice_red = dice1_red;
                    break;
            }
            Array picBoxes = getPictureBoxes();
            foreach (Image picBox in picBoxes)
            {
                if (picBox == dice || picBox == dice_red)
                {
                    value += 1;
                }
            }
            return (value * number);
        }

        private int getNumber(Image dice)
        {
            if (dice == dice1 || dice == dice1_red)
            {
                return 1;
            } else if (dice == dice2 || dice == dice2_red)
            {
                return 2;
            } else if (dice == dice3 || dice == dice3_red)
            {
                return 3;
            } else if (dice == dice4 || dice == dice4_red)
            {
                return 4;
            } else if (dice == dice5 || dice == dice5_red)
            {
                return 5;
            } else
            {
                return 6;
            }
        }

        protected void resetAttempts()
        {
            attempts = 3;
            rollDice.Enabled = true;
            label2.Text = 3 + " attempts left";
            pin_dice1 = false;
            pin_dice2 = false;
            pin_dice3 = false;
            pin_dice4 = false;
            pin_dice5 = false;
            setupDicesOnRow();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g;

            g = e.Graphics;

            Pen myPen = new Pen(Color.Green);
            myPen.Width = 1;
            g.DrawLine(myPen, 10, 350, 375, 350);
            myPen.Width = 3;
            g.DrawLine(myPen, 0, 604, 385, 604);
        }

        protected string getThreeOfaKind()
        {
            bool ThreeOfAKind = false;
            int Sum = 0;
            int dicu1 = getNumber(dice_1.Image);
            int dicu2 = getNumber(dice_2.Image);
            int dicu3 = getNumber(dice_3.Image);
            int dicu4 = getNumber(dice_4.Image);
            int dicu5 = getNumber(dice_5.Image);

            int[] dices = new int[5] { dicu1, dicu2, dicu3, dicu4, dicu5 };

            for (int i = 1; i <= 6; i++)
            {
                int Count = 0;
                for (int j = 0; j < 5; j++)
                {
                    if (dices[j] == i)
                        Count++;

                    if (Count > 2)
                        ThreeOfAKind = true;
                }
            }

            if (ThreeOfAKind)
            {
                Sum = dicu1 + dicu2 + dicu3 + dicu4 + dicu5;
            }

            return Sum.ToString();
        }

        protected string getCarre()
        {
            bool Carre = false;
            int Sum = 0;
            int dicu1 = getNumber(dice_1.Image);
            int dicu2 = getNumber(dice_2.Image);
            int dicu3 = getNumber(dice_3.Image);
            int dicu4 = getNumber(dice_4.Image);
            int dicu5 = getNumber(dice_5.Image);

            int[] dices = new int[5] { dicu1, dicu2, dicu3, dicu4, dicu5 };

            for (int i = 1; i <= 6; i++)
            {
                int Count = 0;
                for (int j = 0; j < 5; j++)
                {
                    if (dices[j] == i)
                        Count++;

                    if (Count > 3)
                        Carre = true;
                }
            }

            if (Carre)
            {
                Sum = dicu1 + dicu2 + dicu3 + dicu4 + dicu5;
            }

            return Sum.ToString();
        }

        protected string getFullHouse()
        {
            int Sum = 0;
            int dicu1 = getNumber(dice_1.Image);
            int dicu2 = getNumber(dice_2.Image);
            int dicu3 = getNumber(dice_3.Image);
            int dicu4 = getNumber(dice_4.Image);
            int dicu5 = getNumber(dice_5.Image);

            int[] dices = new int[5] { dicu1, dicu2, dicu3, dicu4, dicu5 };

            Array.Sort(dices);

            if ((((dices[0] == dices[1]) && (dices[1] == dices[2])) && // Three of a Kind
             (dices[3] == dices[4]) && // Two of a Kind
             (dices[2] != dices[3])) ||
             ((dices[0] == dices[1]) && // Two of a Kind
             ((dices[2] == dices[3]) && (dices[3] == dices[4])) && // Three of a Kind
             (dices[1] != dices[2])))
            {
                Sum = 25;
            }
            return Sum.ToString();
        }

        protected string getSmallStraight()
        {
            int Sum = 0;
            int dicu1 = getNumber(dice_1.Image);
            int dicu2 = getNumber(dice_2.Image);
            int dicu3 = getNumber(dice_3.Image);
            int dicu4 = getNumber(dice_4.Image);
            int dicu5 = getNumber(dice_5.Image);

            int[] dices = new int[5] { dicu1, dicu2, dicu3, dicu4, dicu5 };

            Array.Sort(dices);

            // Problem can arise hear, if there is more than one of the same number, so
            // we must move any doubles to the end
            for (int j = 0; j < 4; j++)
            {
                int temp = 0;
                if (dices[j] == dices[j + 1])
                {
                    temp = dices[j];

                    for (int k = j; k < 4; k++)
                    {
                        dices[k] = dices[k + 1];
                    }

                    dices[4] = temp;
                }
            }

            if (((dices[0] == 1) && (dices[1] == 2) && (dices[2] == 3) && (dices[3] == 4)) ||
                ((dices[0] == 2) && (dices[1] == 3) && (dices[2] == 4) && (dices[3] == 5)) ||
                ((dices[0] == 3) && (dices[1] == 4) && (dices[2] == 5) && (dices[3] == 6)) ||
                ((dices[1] == 1) && (dices[2] == 2) && (dices[3] == 3) && (dices[4] == 4)) ||
                ((dices[1] == 2) && (dices[2] == 3) && (dices[3] == 4) && (dices[4] == 5)) ||
                ((dices[1] == 3) && (dices[2] == 4) && (dices[3] == 5) && (dices[4] == 6)))
            {
                Sum = 30;
            }

            return Sum.ToString();
        }

        protected string getLargeStraight()
        {
            int Sum = 0;
            int dicu1 = getNumber(dice_1.Image);
            int dicu2 = getNumber(dice_2.Image);
            int dicu3 = getNumber(dice_3.Image);
            int dicu4 = getNumber(dice_4.Image);
            int dicu5 = getNumber(dice_5.Image);

            int[] dices = new int[5] { dicu1, dicu2, dicu3, dicu4, dicu5 };

            Array.Sort(dices);

            if (((dices[0] == 1) &&
                 (dices[1] == 2) &&
                 (dices[2] == 3) &&
                 (dices[3] == 4) &&
                 (dices[4] == 5)) ||
                ((dices[0] == 2) &&
                 (dices[1] == 3) &&
                 (dices[2] == 4) &&
                 (dices[3] == 5) &&
                 (dices[4] == 6)))
            {
                Sum = 40;
            }
            return Sum.ToString();
        }

        protected string getYathzee()
        {
            Image dicu1 = getImageOfBox(1);
            Image dicu2 = getImageOfBox(2);
            Image dicu3 = getImageOfBox(3);
            Image dicu4 = getImageOfBox(4);
            Image dicu5 = getImageOfBox(5);
            Image dicu1_red = getOppositeImage(dicu1);
            if ((dicu2 == dicu1_red || dicu2 == dicu1_red) && (dicu3 == dicu1 || dicu3 == dicu1_red) && (dicu4 == dicu1 || dicu4 == dicu1_red) && (dicu5 == dicu1 || dicu5 == dicu1_red))
            {
                return "50";
            } else
            {
                return "0";
            }
        }

        protected string getChance()
        {
            int dicu1 = getNumber(dice_1.Image);
            int dicu2 = getNumber(dice_2.Image);
            int dicu3 = getNumber(dice_3.Image);
            int dicu4 = getNumber(dice_4.Image);
            int dicu5 = getNumber(dice_5.Image);
            int Sum = dicu1 + dicu2 + dicu3 + dicu4 + dicu5;
            return Sum.ToString();
        }

        // === Update Totals
        protected void UpdateTotalUpperExBonus()
        {
            int one; int two; int three; int four; int five; int six; int total = 0;
            bool isOne = Int32.TryParse(ones.Text, out one);
            bool isTwo = Int32.TryParse(twos.Text, out two);
            bool isThree = Int32.TryParse(threes.Text, out three);
            bool isFour = Int32.TryParse(fours.Text, out four);
            bool isFive = Int32.TryParse(fives.Text, out five);
            bool isSix = Int32.TryParse(sixes.Text, out six);
            if (isOne == true)
            {
                total += one;
            }
            if (isTwo == true)
            {
                total += two;
            }
            if (isThree == true)
            {
                total += three;
            }
            if (isFour == true)
            {
                total += four;
            }
            if (isFive == true)
            {
                total += five;
            }
            if (isSix == true)
            {
                total += six;
            }
            if (isOne == true && isTwo == true && isThree == true && isThree == true && isFour == true && isFive == true && isSix == true)
            {
                TotalIncBonus(total);
            }
            totalExBonus.Text = total.ToString();
        }

        protected void TotalIncBonus(int totalExBonus)
        {
            int total = totalExBonus;
            if (totalExBonus >= 63)
            {
                total += 35;
                bonus.Text = "35";
                bonus.BackColor = Color.LightGreen;
            } else
            {
                bonus.Text = "0";
                bonus.BackColor = Color.IndianRed;
            }
            TotalUpper.Text = total.ToString();
            totalUpper_1.Text = total.ToString();
            CheckGameOver();
        }

        protected void UpdateTotalLower()
        {
            int threeKind; int Carre; int FullHouse; int SmallStraight; int LargeStraight; int Yathzee; int Change; int total = 0;
            bool isThreeKind = Int32.TryParse(three_kind.Text, out threeKind);
            bool isCarre = Int32.TryParse(carre.Text, out Carre);
            bool isFullHouse = Int32.TryParse(full_house.Text, out FullHouse);
            bool isSmallStraight = Int32.TryParse(small_street.Text, out SmallStraight);
            bool isLargeStraight = Int32.TryParse(big_street.Text, out LargeStraight);
            bool isYathzee = Int32.TryParse(yathzee.Text, out Yathzee);
            bool isChance = Int32.TryParse(change.Text, out Change);
            if (isThreeKind == true)
            {
                total += threeKind;
            }
            if (isCarre == true)
            {
                total += Carre;
            }
            if (isFullHouse == true)
            {
                total += FullHouse;
            }
            if (isSmallStraight == true)
            {
                total += SmallStraight;
            }
            if (isLargeStraight == true)
            {
                total += LargeStraight;
            }
            if (isYathzee == true)
            {
                total += Yathzee;
            }
            if (isChance == true)
            {
                total += Change;
            }
            totalDown.Text = total.ToString();
            CheckGameOver();
        }

        protected void CheckGameOver()
        {
            if (TotalUpper.Text != "" &&
                three_kind.Text != "" &&
                carre.Text != "" &&
                full_house.Text != "" &&
                small_street.Text != "" &&
                big_street.Text != "" &&
                yathzee.Text != "" &&
                change.Text != "")
            {
                rollDice.Enabled = false;
                label2.Text = "Game is completed";
                int upper = Int32.Parse(TotalUpper.Text);
                int lower = Int32.Parse(totalDown.Text);
                int total = upper + lower;
                total_general.Text = total.ToString();
                setupDicesOnRow();
            }
        }

        // === Add code to pinn dice or not
        private void dice_1_Click(object sender, EventArgs e)
        {
            if (pin_dice1 == true)
            {
                PinnImage(1);
                pin_dice1 = false;
            } else
            {
                PinnImage(1);
                pin_dice1 = true;
            }
        }

        private void dice_2_Click(object sender, EventArgs e)
        {
            if (pin_dice2 == true)
            {
                PinnImage(2);
                pin_dice2 = false;
            }
            else
            {
                PinnImage(2);
                pin_dice2 = true;
            }
        }

        private void dice_3_Click(object sender, EventArgs e)
        {
            if (pin_dice3 == true)
            {
                PinnImage(3);
                pin_dice3 = false;
            }
            else
            {
                PinnImage(3);
                pin_dice3 = true;
            }
        }

        private void dice_4_Click(object sender, EventArgs e)
        {
            if (pin_dice4 == true)
            {
                PinnImage(4);
                pin_dice4 = false;
            }
            else
            {
                PinnImage(4);
                pin_dice4 = true;
            }
        }

        private void dice_5_Click(object sender, EventArgs e)
        {
            if (pin_dice5 == true)
            {
                PinnImage(5);
                pin_dice5 = false;
            }
            else
            {
                PinnImage(5);
                pin_dice5 = true;
            }
        }

        // === Show Text on Mouse Hover
        private void ones_MouseHover(object sender, EventArgs e)
        {
            if (attempts != 3)
            {
                ones.BackColor = Color.LightGreen;
                ones.Text = compareImages(1, 1).ToString();
            }
        }

        private void twos_MouseHover(object sender, EventArgs e)
        {
            if (attempts != 3)
            {
                twos.BackColor = Color.LightGreen;
                twos.Text = compareImages(2, 2).ToString();
            }
        }

        private void threes_MouseHover(object sender, EventArgs e)
        {
            if (attempts != 3)
            {
                threes.BackColor = Color.LightGreen;
                threes.Text = compareImages(3, 3).ToString();
            }
        }

        private void fours_MouseHover(object sender, EventArgs e)
        {
            if (attempts != 3)
            {
                fours.BackColor = Color.LightGreen;
                fours.Text = compareImages(4, 4).ToString();
            }
        }

        private void fives_MouseHover(object sender, EventArgs e)
        {
            if (attempts != 3)
            {
                fives.BackColor = Color.LightGreen;
                fives.Text = compareImages(5, 5).ToString();
            }
        }

        private void sixes_MouseHover(object sender, EventArgs e)
        {
            if (attempts != 3)
            {
                sixes.BackColor = Color.LightGreen;
                sixes.Text = compareImages(6, 6).ToString();
            }
        }

        //----------------------------------------------------------

        private void three_kind_MouseHover(object sender, EventArgs e)
        {
            if (attempts != 3)
            {
                three_kind.BackColor = Color.LightGreen;
                three_kind.Text = getThreeOfaKind();
            }
        }

        private void carre_MouseHover(object sender, EventArgs e)
        {
            if (attempts != 3)
            {
                carre.BackColor = Color.LightGreen;
                carre.Text = getCarre();
            }
        }

        private void full_house_MouseHover(object sender, EventArgs e)
        {
            if (attempts != 3)
            {
                full_house.BackColor = Color.LightGreen;
                full_house.Text = getFullHouse();
            }
        }

        private void small_street_MouseHover(object sender, EventArgs e)
        {
            if (attempts != 3 && small_street.Enabled == true)
            {
                small_street.BackColor = Color.LightGreen;
                small_street.Text = getSmallStraight();
            }
        }

        private void big_street_MouseHover(object sender, EventArgs e)
        {
            if (attempts != 3 && big_street.Enabled == true)
            {
                big_street.BackColor = Color.LightGreen;
                big_street.Text = getLargeStraight();
            }
        }

        private void yathzee_MouseHover(object sender, EventArgs e)
        {
            if (attempts != 3 && yathzee.Enabled == true)
            {
                yathzee.BackColor = Color.LightGreen;
                yathzee.Text = getYathzee();
            }
        }

        private void change_MouseHover(object sender, EventArgs e)
        {
            if (attempts != 3 && change.Enabled == true)
            {
                change.BackColor = Color.LightGreen;
                change.Text = getChance();
            }
        }

        // === Clean textbox on mouseLeave
        private void ones_MouseLeave(object sender, EventArgs e)
        {
            if (ones.Enabled != false)
            {
                ones.Text = "";
                ones.BackColor = Color.White;
            }
        }

        private void twos_MouseLeave(object sender, EventArgs e)
        {
            if (twos.Enabled != false)
            {
                twos.Text = "";
                twos.BackColor = Color.White;
            }
        }

        private void threes_MouseLeave(object sender, EventArgs e)
        {
            if (threes.Enabled != false)
            {
                threes.Text = "";
                threes.BackColor = Color.White;
            }
        }

        private void fours_MouseLeave(object sender, EventArgs e)
        {
            if (fours.Enabled != false)
            {
                fours.Text = "";
                fours.BackColor = Color.White;
            }
        }

        private void fives_MouseLeave(object sender, EventArgs e)
        {
            if (fives.Enabled != false) { 
                fives.Text = "";
                fives.BackColor = Color.White;
            }
        }

        private void sixes_MouseLeave(object sender, EventArgs e)
        {
            if (sixes.Enabled != false)
            {
                sixes.Text = "";
                sixes.BackColor = Color.White;
            }
        }

        // ---------------------------------------------------------

        private void three_kind_MouseLeave(object sender, EventArgs e)
        {
            if (three_kind.Enabled != false)
            {
                three_kind.Text = "";
                three_kind.BackColor = Color.White;
            }
        }

        private void carre_MouseLeave(object sender, EventArgs e)
        {
            if (carre.Enabled != false)
            {
                carre.Text = "";
                carre.BackColor = Color.White;
            }
        }

        private void full_house_MouseLeave(object sender, EventArgs e)
        {
            if (full_house.Enabled != false)
            {
                full_house.Text = "";
                full_house.BackColor = Color.White;
            }
        }

        private void small_street_MouseLeave(object sender, EventArgs e)
        {
            if (small_street.Enabled != false)
            {
                small_street.Text = "";
                small_street.BackColor = Color.White;
            }
        }

        private void big_street_MouseLeave(object sender, EventArgs e)
        {
            if (big_street.Enabled != false)
            {
                big_street.Text = "";
                big_street.BackColor = Color.White;
            }
        }

        private void yathzee_MouseLeave(object sender, EventArgs e)
        {
            if (yathzee.Enabled == true)
            {
                yathzee.Text = "";
                yathzee.BackColor = Color.White;
            }
        }

        private void change_MouseLeave(object sender, EventArgs e)
        {
            if (change.Enabled != false)
            {
                change.Text = "";
                change.BackColor = Color.White;
            }
        }

        // === Attach value on mouse click
        private void ones_MouseClick(object sender, MouseEventArgs e)
        {
            if (attempts != 3)
            {
                ones.BackColor = Color.LightGreen;
                ones.Text = compareImages(1, 1).ToString();
                ones.Enabled = false;
                resetAttempts();
                UpdateTotalUpperExBonus();
            }
        }

        private void twos_MouseClick(object sender, MouseEventArgs e)
        {
            if (attempts != 3)
            {
                twos.BackColor = Color.LightGreen;
                twos.Text = compareImages(2, 2).ToString();
                twos.Enabled = false;
                resetAttempts();
                UpdateTotalUpperExBonus();
            }
        }

        private void threes_MouseClick(object sender, MouseEventArgs e)
        {
            if (attempts != 3)
            {
                threes.BackColor = Color.LightGreen;
                threes.Text = compareImages(3, 3).ToString();
                threes.Enabled = false;
                resetAttempts();
                UpdateTotalUpperExBonus();
            }
        }

        private void fours_MouseClick(object sender, MouseEventArgs e)
        {
            if (attempts != 3)
            {
                fours.BackColor = Color.LightGreen;
                fours.Text = compareImages(4, 4).ToString();
                fours.Enabled = false;
                resetAttempts();
                UpdateTotalUpperExBonus();
            }
        }

        private void fives_MouseClick(object sender, MouseEventArgs e)
        {
            if (attempts != 3)
            {
                fives.BackColor = Color.LightGreen;
                fives.Text = compareImages(5, 5).ToString();
                fives.Enabled = false;
                resetAttempts();
                UpdateTotalUpperExBonus();
            }
        }

        private void sixes_MouseClick(object sender, MouseEventArgs e)
        {
            if (attempts != 3)
            {
                sixes.BackColor = Color.LightGreen;
                sixes.Text = compareImages(6, 6).ToString();
                sixes.Enabled = false;
                resetAttempts();
                UpdateTotalUpperExBonus();
            }
        }

        // --------------------------------------------------------------

        private void three_kind_MouseClick(object sender, MouseEventArgs e)
        {
            if (attempts != 3 && three_kind.Enabled == true)
            {
                three_kind.BackColor = Color.LightGreen;
                three_kind.Enabled = false;
                three_kind.Text = getThreeOfaKind();
                UpdateTotalLower();
                resetAttempts();
            }
        }

        private void carre_MouseClick(object sender, MouseEventArgs e)
        {
            if (attempts != 3 && carre.Enabled == true)
            {
                carre.BackColor = Color.LightGreen;
                carre.Enabled = false;
                carre.Text = getCarre();
                UpdateTotalLower();
                resetAttempts();
            }
        }

        private void full_house_MouseClick(object sender, MouseEventArgs e)
        {
            if (attempts != 3 && full_house.Enabled == true)
            {
                full_house.BackColor = Color.LightGreen;
                full_house.Enabled = false;
                full_house.Text = getFullHouse();
                UpdateTotalLower();
                resetAttempts();
            }
        }

        private void small_street_MouseClick(object sender, MouseEventArgs e)
        {
            if (attempts != 3 && small_street.Enabled == true)
            {
                small_street.BackColor = Color.LightGreen;
                small_street.Enabled = false;
                small_street.Text = getSmallStraight();
                UpdateTotalLower();
                resetAttempts();
            }
        }

        private void big_street_MouseClick(object sender, MouseEventArgs e)
        {
            if (attempts != 3 && big_street.Enabled == true)
            {
                big_street.BackColor = Color.LightGreen;
                big_street.Enabled = false;
                big_street.Text = getLargeStraight();
                UpdateTotalLower();
                resetAttempts();
            }
        }

        private void yathzee_MouseClick(object sender, MouseEventArgs e)
        {
            if (attempts != 3 && yathzee.Enabled == true)
            {
                yathzee.BackColor = Color.LightGreen;
                yathzee.Enabled = false;
                yathzee.Text = getYathzee();
                UpdateTotalLower();
                resetAttempts();
            }
        }

        private void change_MouseClick(object sender, MouseEventArgs e)
        {
            if (attempts != 3 && change.Enabled == true)
            {
                change.BackColor = Color.LightGreen;
                change.Text = getChance();
                change.Enabled = false;
                UpdateTotalLower();
                resetAttempts();
            }
        }
    }
}
