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
        int[] BarnBLue = new int[6];
        int[] BarnRed = new int[6];
        int[] BarnYellow = new int[6];
        int[] BarnGreen = new int[6];

        int StartpositionBlue = 0;
        int StartpositionRed = 13;
        int StartpositionGreen = 26;
        int StartpositionYellow = 39;
        int EndpositionBlue = 53;
        int EndpositionRed = 12;
        int EndpositionGreen = 25;
        int EndpositionYellow = 38;


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
            //BlueBox13.Visible = false;
            //BlueBox14.Visible = false;
            //BlueBox15.Visible = false;
            //BlueBox16.Visible = false;
            //BlueBox17.Visible = false;
            //BlueBox18.Visible = false;
            //BlueBox19.Visible = false;
            //BlueBox20.Visible = false;
            //BlueBox21.Visible = false;
            //BlueBox22.Visible = false;
            //BlueBox23.Visible = false;
            //BlueBox24.Visible = false;
            //BlueBox25.Visible = false;
            //BlueBox26.Visible = false;
            //BlueBox27.Visible = false;
            //BlueBox28.Visible = false;
            //BlueBox29.Visible = false;
            //BlueBox30.Visible = false;
            //BlueBox31.Visible = false;
            //BlueBox32.Visible = false;
            //BlueBox33.Visible = false;
            //BlueBox34.Visible = false;
            //BlueBox35.Visible = false;
            //BlueBox36.Visible = false;
            //BlueBox37.Visible = false;
            //BlueBox38.Visible = false;
            //BlueBox39.Visible = false;
            //BlueBox40.Visible = false;
            //BlueBox41.Visible = false;
            //BlueBox42.Visible = false;
            //BlueBox43.Visible = false;
            //BlueBox44.Visible = false;
            //BlueBox45.Visible = false;
            //BlueBox46.Visible = false;
            //BlueBox47.Visible = false;
            //BlueBox48.Visible = false;
            //BlueBox49.Visible = false;
            //BlueBox50.Visible = false;
            //BlueBox51.Visible = false;
            BlueBox52.Visible = false;
            BlueBox53.Visible = false;
            BlueBox54.Visible = false;
            BlueBox55.Visible = false;
            BlueBox56.Visible = false;
            picTurnBlue.Visible = false;
            picTurnRed.Visible = false;
            picTurnGreen.Visible = false;
            picTurnYellow.Visible = false;

            btnRoll.Enabled = false;

            arrayInit(Bancochinh);
            arrayInit(BarnBLue);
            arrayInit(BarnRed);
            arrayInit(BarnGreen);
            arrayInit(BarnYellow);

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

        }


        private void arrayInit(int[] arr, int value=0)
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
            picYellow1.Visible = true;
            picYellow2.Visible = true;
            picYellow3.Visible = true;
            picYellow4.Visible = true;
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
            picYellow1.Location = new Point(434, 513);
            picYellow2.Location = new Point(469, 485);
            picYellow3.Location = new Point(502, 448);
            picYellow4.Location = new Point(531, 429);
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

            outBam(ref diceValue);
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
            BlueBox52.Visible = false;
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

        private void Raquan(ref PictureBox chess, int numMove)
        {
            chess.Location = listBoardPositions[numMove].Location;
            listBoardPositions[numMove].Visible = false;
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
                picYellow1.Cursor = Cursors.Default;
                picYellow2.Cursor = Cursors.Default;
                picYellow3.Cursor = Cursors.Default;
                picYellow4.Cursor = Cursors.Default;
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
                    picYellow1.Cursor = Cursors.Hand;
                    picYellow2.Cursor = Cursors.Hand;
                    picYellow3.Cursor = Cursors.Hand;
                    picYellow4.Cursor = Cursors.Hand;
                }
            }


        }

        private void moveBlueSeaHorse1(object sender, EventArgs e)
        {
            PictureBox clickedChess = sender as PictureBox;
            Raquan(ref clickedChess, diceValue);
        }
    }
}

