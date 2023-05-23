using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CoCaNgua
{

    public partial class Form1 : Form
    {

        int value = -1;
        
        
    public Form1()
        {



            InitializeComponent();
            this.MaximizeBox = false;
            picDice11.Visible = false;
            picDice21.Visible = false;
            picDice31.Visible = false;
            picDice41.Visible = false;
            picDice51.Visible = false;
            picDice61.Visible = false;
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
            BlueBox13.Visible = false;
            BlueBox14.Visible = false;
            BlueBox15.Visible = false;
            BlueBox16.Visible = false;
            BlueBox17.Visible = false;
            BlueBox18.Visible = false;
            BlueBox19.Visible = false;
            BlueBox20.Visible = false;
            BlueBox21.Visible = false;
            BlueBox22.Visible = false;
            BlueBox23.Visible = false;
            BlueBox24.Visible = false;
            BlueBox25.Visible = false;
            BlueBox26.Visible = false;
            BlueBox27.Visible = false;
            BlueBox28.Visible = false;
            BlueBox29.Visible = false;
            BlueBox30.Visible = false;
            BlueBox31.Visible = false;
            BlueBox32.Visible = false;
            BlueBox33.Visible = false;
            BlueBox34.Visible = false;
            BlueBox35.Visible = false;
            BlueBox36.Visible = false;
            BlueBox37.Visible = false;
            BlueBox38.Visible = false;
            BlueBox39.Visible = false;
            BlueBox40.Visible = false;
            BlueBox41.Visible = false;
            BlueBox42.Visible = false;
            BlueBox43.Visible = false;
            BlueBox44.Visible = false;
            BlueBox45.Visible = false;
            BlueBox46.Visible = false;
            BlueBox47.Visible = false;
            BlueBox48.Visible = false;
            BlueBox49.Visible = false;
            BlueBox50.Visible = false;
            BlueBox51.Visible = false;
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
            picDice21.Visible = false;
            picDice31.Visible = false;
            picDice41.Visible = false;
            picDice51.Visible = false;
            picDice61.Visible = false;
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
            return roll.Next(1,7);
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

           
            
            int diceValue1 = rollDice();
            isTurn();
            
            outBam(ref diceValue1);
            move();

            

            if (diceValue1 == 1)
           
            
            {
                picDice11.Visible = true;
                picDice21.Visible = false;
                picDice31.Visible = false;
                picDice41.Visible = false;
                picDice51.Visible = false;
                picDice61.Visible = false;
                
            }
            if (diceValue1 == 2)
            {
                picDice21.Visible = true;
                picDice11.Visible = false;
                picDice31.Visible = false;
                picDice41.Visible = false;
                picDice51.Visible = false;
                picDice61.Visible = false;
            }
            if (diceValue1 == 3)
            {
                picDice31.Visible = true;
                picDice21.Visible = false;
                picDice11.Visible = false;
                picDice41.Visible = false;
                picDice51.Visible = false;
                picDice61.Visible = false;
            }
            if (diceValue1 == 4)
            {
                picDice41.Visible = true;
                picDice21.Visible = false;
                picDice31.Visible = false;
                picDice11.Visible = false;
                picDice51.Visible = false;
                picDice61.Visible = false;
            }
            if (diceValue1 == 5)
            {
                picDice51.Visible = true;
                picDice21.Visible = false;
                picDice31.Visible = false;
                picDice41.Visible = false;
                picDice11.Visible = false;
                picDice61.Visible = false;
            }
            if (diceValue1 == 6)
            {
                picDice61.Visible = true;
                picDice21.Visible = false;
                picDice31.Visible = false;
                picDice41.Visible = false;
                picDice51.Visible = false;
                picDice11.Visible = false;
            }
            
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
            BlueBox13.Visible = false;
            BlueBox14.Visible = false;
            BlueBox15.Visible = false;
            BlueBox16.Visible = false;
            BlueBox17.Visible = false;
            BlueBox18.Visible = false;
            BlueBox19.Visible = false;
            BlueBox20.Visible = false;
            BlueBox21.Visible = false;
            BlueBox22.Visible = false;
            BlueBox23.Visible = false;
            BlueBox24.Visible = false;
            BlueBox25.Visible = false;
            BlueBox26.Visible = false;
            BlueBox27.Visible = false;
            BlueBox28.Visible = false;
            BlueBox29.Visible = false;
            BlueBox30.Visible = false;
            BlueBox31.Visible = false;
            BlueBox32.Visible = false;
            BlueBox33.Visible = false;
            BlueBox34.Visible = false;
            BlueBox35.Visible = false;
            BlueBox36.Visible = false;
            BlueBox37.Visible = false;
            BlueBox38.Visible = false;
            BlueBox39.Visible = false;
            BlueBox40.Visible = false;
            BlueBox41.Visible = false;
            BlueBox42.Visible = false;
            BlueBox43.Visible = false;
            BlueBox44.Visible = false;
            BlueBox45.Visible = false;
            BlueBox46.Visible = false;
            BlueBox47.Visible = false;
            BlueBox48.Visible = false;
            BlueBox49.Visible = false;
            BlueBox50.Visible = false;
            BlueBox51.Visible = false;
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

        

        void outBam(ref int canOut)
        {
            if (value == 0)
            {
                if (canOut == 1 || canOut == 6)
                {
                    picBlue1.Cursor = Cursors.Hand;
                    picBlue2.Cursor = Cursors.Hand;
                    picBlue3.Cursor = Cursors.Hand;
                    picBlue4.Cursor = Cursors.Hand;
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

                    


                    
                }
            }

            if (value == 1)
            {
                if (canOut == 1 || canOut == 6)
                {
                    picRed1.Cursor = Cursors.Hand;
                    picRed2.Cursor = Cursors.Hand;
                    picRed3.Cursor = Cursors.Hand;
                    picRed4.Cursor = Cursors.Hand;
                    picBlue1.Cursor = Cursors.Default;
                    picBlue2.Cursor = Cursors.Default;
                    picBlue3.Cursor = Cursors.Default;
                    picBlue4.Cursor = Cursors.Default;
                    picGreen1.Cursor = Cursors.Default;
                    picGreen2.Cursor = Cursors.Default;
                    picGreen3.Cursor = Cursors.Default;
                    picGreen4.Cursor = Cursors.Default;
                    picYellow1.Cursor = Cursors.Default;
                    picYellow2.Cursor = Cursors.Default;
                    picYellow3.Cursor = Cursors.Default;
                    picYellow4.Cursor = Cursors.Default;

                    
                }
            }

            if (value == 2)
            {
                if (canOut == 1 || canOut == 6)
                {
                    picGreen1.Cursor = Cursors.Hand;
                    picGreen2.Cursor = Cursors.Hand;
                    picGreen3.Cursor = Cursors.Hand;
                    picGreen4.Cursor = Cursors.Hand;
                    picBlue1.Cursor = Cursors.Default;
                    picBlue2.Cursor = Cursors.Default;
                    picBlue3.Cursor = Cursors.Default;
                    picBlue4.Cursor = Cursors.Default;
                    picYellow1.Cursor = Cursors.Default;
                    picYellow2.Cursor = Cursors.Default;
                    picYellow3.Cursor = Cursors.Default;
                    picYellow4.Cursor = Cursors.Default;
                    picRed1.Cursor = Cursors.Default;
                    picRed2.Cursor = Cursors.Default;
                    picRed3.Cursor = Cursors.Default;
                    picRed4.Cursor = Cursors.Default;

                    
                }
            }

            if (value == 3)
            {
                if (canOut == 1 || canOut == 6)
                {
                    picYellow1.Cursor = Cursors.Hand;
                    picYellow2.Cursor = Cursors.Hand;
                    picYellow3.Cursor = Cursors.Hand;
                    picYellow4.Cursor = Cursors.Hand;
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

                    
                }
            }
        }

        void move()
        {

        }
    }


}
