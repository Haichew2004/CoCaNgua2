using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CoCaNgua
{

    public partial class Form1 : Form
    {

        int value = -1;
        int diceValue = 0;
        int[] Bancochinh = new int[54];

        int StartpositionBlue = 0;
        int StartpositionRed = 13;
        int StartpositionGreen = 26;
        int StartpositionYellow = 39;

        int currentBarnPositionBlueSeaHorse1 = 0;
        int currentBarnPositionBlueSeaHorse2 = 0;
        int currentBarnPositionBlueSeaHorse3 = 0;
        int currentBarnPositionBlueSeaHorse4 = 0;
        int currentBarnPositionRedSeaHorse1 = 0;
        int currentBarnPositionRedSeaHorse2 = 0;
        int currentBarnPositionRedSeaHorse3 = 0;
        int currentBarnPositionRedSeaHorse4 = 0; 
        int currentBarnPositionGreenSeaHorse1 = 0;
        int currentBarnPositionGreenSeaHorse2 = 0;
        int currentBarnPositionGreenSeaHorse3 = 0;
        int currentBarnPositionGreenSeaHorse4 = 0;
        int currentBarnPositionYellowSeaHorse1 = 0;
        int currentBarnPositionYellowSeaHorse2 = 0;
        int currentBarnPositionYellowSeaHorse3 = 0;
        int currentBarnPositionYellowSeaHorse4 = 0; 


        int currentPositionBlueSeaHorse1 = -1;
        int currentPositionBlueSeaHorse2 = -1;
        int currentPositionBlueSeaHorse3 = -1;
        int currentPositionBlueSeaHorse4 = -1;
        int currentPositionRedSeaHorse1 = -1;
        int currentPositionRedSeaHorse2 = -1;
        int currentPositionRedSeaHorse3 = -1;
        int currentPositionRedSeaHorse4 = -1;
        int currentPositionGreenSeaHorse1 = -1;
        int currentPositionGreenSeaHorse2 = -1;
        int currentPositionGreenSeaHorse3 = -1;
        int currentPositionGreenSeaHorse4 = -1;
        int currentPositionYellowSeaHorse1 = -1;
        int currentPositionYellowSeaHorse2 = -1;
        int currentPositionYellowSeaHorse3 = -1;
        int currentPositionYellowSeaHorse4 = -1;

        int AvailableMoveLeftBlueSeaHorse1 = 52;
        int AvailableMoveLeftBlueSeaHorse2 = 52;
        int AvailableMoveLeftBlueSeaHorse3 = 52;
        int AvailableMoveLeftBlueSeaHorse4 = 52;
        int AvailableMoveLeftRedSeaHorse1 = 52;
        int AvailableMoveLeftRedSeaHorse2 = 52;
        int AvailableMoveLeftRedSeaHorse3 = 52;
        int AvailableMoveLeftRedSeaHorse4 = 52;
        int AvailableMoveLeftGreenSeaHorse1 = 52;
        int AvailableMoveLeftGreenSeaHorse2 = 52;
        int AvailableMoveLeftGreenSeaHorse3 = 52;
        int AvailableMoveLeftGreenSeaHorse4 = 52;
        int AvailableMoveLeftYellowSeaHorse1 = 52;
        int AvailableMoveLeftYellowSeaHorse2 = 52;
        int AvailableMoveLeftYellowSeaHorse3 = 52;
        int AvailableMoveLeftYellowSeaHorse4 = 52;



        List<Bitmap> listdiceimages = new List<Bitmap>
        {
            Properties.Resources.dice_1,
            Properties.Resources.dice_2,
            Properties.Resources.dice_3,
            Properties.Resources.dice_4,
            Properties.Resources.dice_5,
            Properties.Resources.dice_6,

        };


        List<PictureBox> listBoardPositions = new List<PictureBox>();
        List<PictureBox> listBlueBarnPos = new List<PictureBox>();
        List<PictureBox> listRedBarnPos = new List<PictureBox>();
        List<PictureBox> listGreenBarnPos = new List<PictureBox>();
        List<PictureBox> listYellowBarnPos = new List<PictureBox>();


        public Form1()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            picDice11.Visible = false;
            BlueBox1.Visible = false;
            BlueBox2.Visible = false;
            BlueBox3.Visible = false;
            BlueBox4.Visible = false;
            BlueBox5.Visible = false;
            BlueBox6.Visible = false;
            BlueBox7.Visible = false;
            BlueBox8.Visible = false;
            BlueBox9.Visible = false;
            BlueBox10.Visible = false;
            BlueBox11.Visible = false;
            BlueBox12.Visible = false;
            BoardPosBox13.Visible = false;
            BoardPosBox14.Visible = false;
            BoardPosBox15.Visible = false;
            BoardPosBox16.Visible = false;
            BoardPosBox17.Visible = false;
            BoardPosBox18.Visible = false;
            BoardPosBox19.Visible = false;
            BoardPosBox20.Visible = false;
            BoardPosBox21.Visible = false;
            BoardPosBox22.Visible = false;
            BoardPosBox23.Visible = false;
            BoardPosBox24.Visible = false;
            BoardPosBox25.Visible = false;
            BoardPosBox26.Visible = false;
            BoardPosBox27.Visible = false;
            BoardPosBox28.Visible = false;
            BoardPosBox29.Visible = false;
            BoardPosBox30.Visible = false;
            BoardPosBox31.Visible = false;
            BoardPosBox32.Visible = false;
            BoardPosBox33.Visible = false;
            BoardPosBox34.Visible = false;
            BoardPosBox35.Visible = false;
            BoardPosBox36.Visible = false;
            BoardPosBox37.Visible = false;
            BoardPosBox38.Visible = false;
            BoardPosBox39.Visible = false;
            BoardPosBox40.Visible = false;
            BoardPosBox41.Visible = false;
            BoardPosBox42.Visible = false;
            BoardPosBox43.Visible = false;
            BoardPosBox44.Visible = false;
            BoardPosBox45.Visible = false;
            BoardPosBox46.Visible = false;
            BoardPosBox47.Visible = false;
            BoardPosBox48.Visible = false;
            BoardPosBox49.Visible = false;
            BoardPosBox50.Visible = false;
            BoardPosBox51.Visible = false;
            BoardPosBox52.Visible = false;
            
            BoardPosBox52.Visible = false;
            BlueBox53.Visible = false;
            BlueBox54.Visible = false;
            BlueBox55.Visible = false;
            BlueBox56.Visible = false;
            picTurnBlue.Visible = false;
            picTurnRed.Visible = false;
            picTurnGreen.Visible = false;
            picTurnYellow.Visible = false;

            picYellowBarnPos1.Visible = false;
            picYellowBarnPos2.Visible = false;
            picYellowBarnPos3.Visible = false;
            picYellowBarnPos4.Visible = false;
            picYellowBarnPos5.Visible = false;
            picYellowBarnPos6.Visible = false;

            btnRoll.Enabled = false;

            arrayInit(Bancochinh);

            listBoardPositions.Add(BlueBox1); // 0
            listBoardPositions.Add(BlueBox2); // 1
            listBoardPositions.Add(BlueBox3);
            listBoardPositions.Add(BlueBox4);
            listBoardPositions.Add(BlueBox5);
            listBoardPositions.Add(BlueBox6);
            listBoardPositions.Add(BlueBox7);
            listBoardPositions.Add(BlueBox8);
            listBoardPositions.Add(BlueBox9);
            listBoardPositions.Add(BlueBox10);
            listBoardPositions.Add(BlueBox11);
            listBoardPositions.Add(BlueBox12);
            listBoardPositions.Add(BoardPosBox13);
            listBoardPositions.Add(BoardPosBox14);
            listBoardPositions.Add(BoardPosBox15);
            listBoardPositions.Add(BoardPosBox16);
            listBoardPositions.Add(BoardPosBox17);
            listBoardPositions.Add(BoardPosBox18);
            listBoardPositions.Add(BoardPosBox19);
            listBoardPositions.Add(BoardPosBox20);
            listBoardPositions.Add(BoardPosBox21);
            listBoardPositions.Add(BoardPosBox22);
            listBoardPositions.Add(BoardPosBox23);
            listBoardPositions.Add(BoardPosBox24);
            listBoardPositions.Add(BoardPosBox25);
            listBoardPositions.Add(BoardPosBox26);
            listBoardPositions.Add(BoardPosBox27);
            listBoardPositions.Add(BoardPosBox28);
            listBoardPositions.Add(BoardPosBox29);
            listBoardPositions.Add(BoardPosBox30);
            listBoardPositions.Add(BoardPosBox31);
            listBoardPositions.Add(BoardPosBox32);
            listBoardPositions.Add(BoardPosBox33);
            listBoardPositions.Add(BoardPosBox34);
            listBoardPositions.Add(BoardPosBox35);
            listBoardPositions.Add(BoardPosBox36);
            listBoardPositions.Add(BoardPosBox37);
            listBoardPositions.Add(BoardPosBox38);
            listBoardPositions.Add(BoardPosBox39);
            listBoardPositions.Add(BoardPosBox40);
            listBoardPositions.Add(BoardPosBox41);
            listBoardPositions.Add(BoardPosBox42);
            listBoardPositions.Add(BoardPosBox43);
            listBoardPositions.Add(BoardPosBox44);
            listBoardPositions.Add(BoardPosBox45);
            listBoardPositions.Add(BoardPosBox46);
            listBoardPositions.Add(BoardPosBox47);
            listBoardPositions.Add(BoardPosBox48);
            listBoardPositions.Add(BoardPosBox49);
            listBoardPositions.Add(BoardPosBox50);
            listBoardPositions.Add(BoardPosBox51);
            listBoardPositions.Add(BoardPosBox52);

            listYellowBarnPos.Add(picYellowBarnPos1);
            listYellowBarnPos.Add(picYellowBarnPos2);
            listYellowBarnPos.Add(picYellowBarnPos3);
            listYellowBarnPos.Add(picYellowBarnPos4);
            listYellowBarnPos.Add(picYellowBarnPos5);
            listYellowBarnPos.Add(picYellowBarnPos6); 
            //listYellowBarnPos.Add(picYellowBarnPos1);
            //listYellowBarnPos.Add(picYellowBarnPos2);
            //listYellowBarnPos.Add(picYellowBarnPos3);
            //listYellowBarnPos.Add(picYellowBarnPos4);
            //listYellowBarnPos.Add(picYellowBarnPos5);
            //listYellowBarnPos.Add(picYellowBarnPos6); 
            //listYellowBarnPos.Add(picYellowBarnPos1);
            //listYellowBarnPos.Add(picYellowBarnPos2);
            //listYellowBarnPos.Add(picYellowBarnPos3);
            //listYellowBarnPos.Add(picYellowBarnPos4);
            //listYellowBarnPos.Add(picYellowBarnPos5);
            //listYellowBarnPos.Add(picYellowBarnPos6); 
            //listYellowBarnPos.Add(picYellowBarnPos1);
            //listYellowBarnPos.Add(picYellowBarnPos2);
            //listYellowBarnPos.Add(picYellowBarnPos3);
            //listYellowBarnPos.Add(picYellowBarnPos4);
            //listYellowBarnPos.Add(picYellowBarnPos5);
            //listYellowBarnPos.Add(picYellowBarnPos6);
        }


        private void arrayInit(int[] arr, int value = 0)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = value;
            }
        }

        //Nút start
        private void btnStart_Click(object sender, EventArgs e)
        {

            picBlue1.Visible = true;
            picBlue2.Visible = true;
            picBlue4.Visible = true;
            picBlue3.Visible = true;
            picRed1.Visible = true;
            picRed2.Visible = true;
            picRed3.Visible = true;
            picRed4.Visible = true;
            picGreen1.Visible = true;
            picGreen2.Visible = true;
            picGreen3.Visible = true;
            picGreen4.Visible = true;
            picYellow4.Visible = true;
            picYellow3.Visible = true;
            picYellow2.Visible = true;
            picYellow1.Visible = true;
            picBlue1.Location = new Point(531, 128);
            picBlue2.Location = new Point(502, 101);
            picBlue3.Location = new Point(469, 72);
            picBlue4.Location = new Point(435, 55);
            picRed1.Location = new Point(154, 55);
            picRed2.Location = new Point(124, 72);
            picRed3.Location = new Point(96, 101);
            picRed4.Location = new Point(61, 128);
            picGreen1.Location = new Point(61, 429);
            picGreen2.Location = new Point(96, 448);
            picGreen3.Location = new Point(124, 485);
            picGreen4.Location = new Point(154, 513);
            picYellow4.Location = new Point(434, 513);
            picYellow3.Location = new Point(469, 485);
            picYellow2.Location = new Point(502, 448);
            picYellow1.Location = new Point(531, 429);
            btnRoll.Visible = true;
            picDice11.Visible = false;
            btnRoll.Enabled = true;

            clear();

            picTurnBlue.Visible = true;


        }
        //Nút thoát
        private void btnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }




        //Random
        private Random roll = new Random();
        private int rollDice()
        {
            return roll.Next(1, 4);
            //return 1;
        }





        //Nút roll
        private void btnRoll_Click(object sender, EventArgs e)
        {
            value++;
            if (value > 3)
            {
                value = 0;

            }
            labelCount.Text = value.ToString();



            diceValue = rollDice();
            isTurn();

            //outBam(ref diceValue);
            move();


            picDice11.Image = listdiceimages[diceValue - 1];
            picDice11.Invalidate();
            picDice11.Visible = true;



        }

        private void move()
        {
            //throw new NotImplementedException();
        }

        void clear()
        {
            BlueBox1.Visible = false;
            BlueBox2.Visible = false;
            BlueBox3.Visible = false;
            BlueBox4.Visible = false;
            BlueBox5.Visible = false;
            BlueBox6.Visible = false;
            BlueBox7.Visible = false;
            BlueBox8.Visible = false;
            BlueBox9.Visible = false;
            BlueBox10.Visible = false;
            BlueBox11.Visible = false;
            BlueBox12.Visible = false;
            BoardPosBox52.Visible = false;
            BlueBox53.Visible = false;
            BlueBox54.Visible = false;
            BlueBox55.Visible = false;
            BlueBox56.Visible = false;
            value = -1;
        }

        void isTurn()
        {



            string[] colors = { "Blue", "Red", "Green", "Yellow" };
            string currentColor = colors[value];
            if (currentColor == "Blue")
            {
                picTurnBlue.Visible = true;
                picTurnRed.Visible = false;
                picTurnGreen.Visible = false;
                picTurnYellow.Visible = false;

            }
            if (currentColor == "Red")
            {
                picTurnRed.Visible = true;
                picTurnBlue.Visible = false;
                picTurnGreen.Visible = false;
                picTurnYellow.Visible = false;

            }
            if (currentColor == "Green")
            {
                picTurnGreen.Visible = true;
                picTurnBlue.Visible = false;
                picTurnRed.Visible = false;
                picTurnYellow.Visible = false;

            }
            if (currentColor == "Yellow")
            {
                picTurnYellow.Visible = true;
                picTurnBlue.Visible = false;
                picTurnGreen.Visible = false;
                picTurnRed.Visible = false;

            }



        }


        void outBam(ref int canOut)
        {
            if (canOut == 1 || canOut == 6)
            {
                picBlue1.Cursor = Cursors.Default;
                picBlue2.Cursor = Cursors.Default;
                picBlue3.Cursor = Cursors.Default;
                picBlue4.Cursor = Cursors.Default;
                picRed1.Cursor = Cursors.Default;
                picRed2.Cursor = Cursors.Default;
                picRed3.Cursor = Cursors.Default;
                picRed4.Cursor = Cursors.Default;
                picGreen1.Cursor = Cursors.Default;
                picGreen2.Cursor = Cursors.Default;
                picGreen3.Cursor = Cursors.Default;
                picGreen4.Cursor = Cursors.Default;
                picYellow4.Cursor = Cursors.Default;
                picYellow3.Cursor = Cursors.Default;
                picYellow2.Cursor = Cursors.Default;
                picYellow1.Cursor = Cursors.Default;
                if (value == 0)
                {
                    picBlue1.Cursor = Cursors.Hand;
                    picBlue2.Cursor = Cursors.Hand;
                    picBlue3.Cursor = Cursors.Hand;
                    picBlue4.Cursor = Cursors.Hand;
                }

                if (value == 1)
                {
                    picRed1.Cursor = Cursors.Hand;
                    picRed2.Cursor = Cursors.Hand;
                    picRed3.Cursor = Cursors.Hand;
                    picRed4.Cursor = Cursors.Hand;
                }

                if (value == 2)
                {
                    picGreen1.Cursor = Cursors.Hand;
                    picGreen2.Cursor = Cursors.Hand;
                    picGreen3.Cursor = Cursors.Hand;
                    picGreen4.Cursor = Cursors.Hand;
                }

                if (value == 3)
                {
                    picYellow4.Cursor = Cursors.Hand;
                    picYellow3.Cursor = Cursors.Hand;
                    picYellow2.Cursor = Cursors.Hand;
                    picYellow1.Cursor = Cursors.Hand;
                }
            }


        }



        private void btnGuild_Click(object sender, EventArgs e)
        {
            Form2 guildform = new Form2();
            guildform.Show();
        }

        private void moveBlueSeaHorse1(object sender, EventArgs e)
        {
            // ra quan
            if (currentPositionBlueSeaHorse1 == -1)
            {
                picBlue1.Location = listBoardPositions[StartpositionBlue].Location;
                Bancochinh[StartpositionBlue] = 1;
                currentPositionBlueSeaHorse1 = StartpositionBlue;
            }
            // di chuyen
            else
            {
                int nextPos = currentPositionBlueSeaHorse1 + diceValue;
                picBlue1.Location = listBoardPositions[nextPos].Location;
                listBoardPositions[nextPos].Visible = false;
                Bancochinh[currentPositionBlueSeaHorse1] = 0;
                Bancochinh[nextPos] = 1;
                currentPositionBlueSeaHorse1 = nextPos;
            }
        }
        private void moveBlueSeaHorse2(object sender, EventArgs e)
        {
            // ra quan
            if (currentPositionBlueSeaHorse2 == -1)
            {
                picBlue2.Location = listBoardPositions[StartpositionBlue].Location;
                Bancochinh[StartpositionBlue] = 1;
                currentPositionBlueSeaHorse2 = StartpositionBlue;
            }
            // di chuyen
            else
            {
                int nextPos = currentPositionBlueSeaHorse2 + diceValue;
                picBlue2.Location = listBoardPositions[nextPos].Location;
                listBoardPositions[nextPos].Visible = false;
                Bancochinh[currentPositionBlueSeaHorse2] = 0;
                Bancochinh[nextPos] = 1;
                currentPositionBlueSeaHorse2 = nextPos;
            }
        }
        private void moveBlueSeaHorse3(object sender, EventArgs e)
        {
            // ra quan
            if (currentPositionBlueSeaHorse3 == -1)
            {
                picBlue3.Location = listBoardPositions[StartpositionBlue].Location;
                Bancochinh[StartpositionBlue] = 1;
                currentPositionBlueSeaHorse3 = StartpositionBlue;
            }
            // di chuyen
            else
            {
                int nextPos = currentPositionBlueSeaHorse3 + diceValue;
                picBlue3.Location = listBoardPositions[nextPos].Location;
                listBoardPositions[nextPos].Visible = false;
                Bancochinh[currentPositionBlueSeaHorse3] = 0;
                Bancochinh[nextPos] = 1;
                currentPositionBlueSeaHorse3 = nextPos;
            }
        }
        private void moveBlueSeaHorse4(object sender, EventArgs e)
        {
            // ra quan
            if (currentPositionBlueSeaHorse4 == -1)
            {
                picBlue4.Location = listBoardPositions[StartpositionBlue].Location;
                Bancochinh[StartpositionBlue] = 1;
                currentPositionBlueSeaHorse4 = StartpositionBlue;
            }
            // di chuyen
            else
            {
                int nextPos = currentPositionBlueSeaHorse4 + diceValue;
                picBlue4.Location = listBoardPositions[nextPos].Location;
                listBoardPositions[nextPos].Visible = false;
                Bancochinh[currentPositionBlueSeaHorse4] = 0;
                Bancochinh[nextPos] = 1;
                currentPositionBlueSeaHorse4 = nextPos;
            }
        }

        private void moveRedSeaHorse1(object sender, EventArgs e)
        {
            // ra quan
            if (currentPositionRedSeaHorse1 == -1)
            {
                picRed1.Location = listBoardPositions[StartpositionRed].Location;
                Bancochinh[StartpositionRed] = 1;
                currentPositionRedSeaHorse1 = StartpositionRed;
            }
            // di chuyen
            else
            {
                int nextPos = currentPositionRedSeaHorse1 + diceValue;
                picRed1.Location = listBoardPositions[nextPos].Location;
                listBoardPositions[nextPos].Visible = false;
                currentPositionRedSeaHorse1 = nextPos;
            }
        }
        private void moveGreenSeaHorse1(object sender, EventArgs e)
        {
            // ra quan
            if (currentPositionGreenSeaHorse1 == -1)
            {
                picGreen1.Location = listBoardPositions[StartpositionGreen].Location;
                Bancochinh[StartpositionGreen] = 1;
                currentPositionGreenSeaHorse1 = StartpositionGreen;
            }
            // di chuyen
            else
            {
                int nextPos = currentPositionGreenSeaHorse1 + diceValue;
                picGreen1.Location = listBoardPositions[nextPos].Location;
                listBoardPositions[nextPos].Visible = false;
                Bancochinh[currentPositionGreenSeaHorse1] = 0;
                Bancochinh[nextPos] = 1;
                currentPositionGreenSeaHorse1 = nextPos;
            }
        }
        private void moveYellowSeaHorse1(object sender, EventArgs e)
        {
            // ra quan                      
                if (currentPositionYellowSeaHorse1 == -1)

                {
                    if (diceValue == 1 || diceValue == 6)
                    {
                        picYellow1.Location = listBoardPositions[StartpositionYellow].Location;
                        Bancochinh[StartpositionYellow] = 1;
                        currentPositionYellowSeaHorse1 = StartpositionYellow;
                    }                  
                }            
            // di chuyen
            else if(AvailableMoveLeftYellowSeaHorse1>1)
            {
                int nextPos = ComputeNextPos(currentPositionYellowSeaHorse1, diceValue);
                if (AvailableMoveLeftYellowSeaHorse1 - diceValue > 0)
                {
                    picYellow1.Location = listBoardPositions[nextPos].Location;
                    listBoardPositions[nextPos].Visible = false;
                    Bancochinh[currentPositionYellowSeaHorse1] = 0;
                    Bancochinh[nextPos] = 1;
                    currentPositionYellowSeaHorse1 = nextPos;
                    AvailableMoveLeftYellowSeaHorse1 = AvailableMoveLeftYellowSeaHorse1 - diceValue;

                }
            }
            else
            {
                // len chuong
                int nextBarnPos = diceValue;
                if (currentBarnPositionYellowSeaHorse1 == 0)
                {
                    // di chuyen len barn theo dice
                    picYellow1.Location = listYellowBarnPos[nextBarnPos-1].Location;

                    currentBarnPositionYellowSeaHorse1 = nextBarnPos;
                }
                else
                {
                    if (diceValue == 1 || diceValue == 6 || diceValue == currentBarnPositionYellowSeaHorse1 + 1) 
                    {
                        // chi di chuyen khi da trong barn
                        nextBarnPos = currentBarnPositionYellowSeaHorse1 + 1;
                        picYellow1.Location = listYellowBarnPos[nextBarnPos - 1].Location;
                        currentBarnPositionYellowSeaHorse1 = nextBarnPos;
                    }
                }
                label4.Text = nextBarnPos.ToString();
            }
            label2.Text = AvailableMoveLeftYellowSeaHorse1.ToString();
            label3.Text = currentBarnPositionYellowSeaHorse1.ToString();
            
        }
        private int ComputeNextPos(int currentPos, int dicevalue) 
        { 
            int nextPos = currentPos + diceValue;
            if (nextPos >= 52)
            {
                int remainder = nextPos - 52;
                nextPos = 0 + remainder;
            }
            return nextPos;

        }
    }
}

