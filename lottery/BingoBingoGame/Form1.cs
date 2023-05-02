using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BingoBingoGame
{
    
    public partial class Form1 : Form
    {
        //List<Label> listLabels = new List<Label>();
        public List<Button> ListPGBtn = new List<Button>();
        List<string> listGamePlay = new List<string>();
        List<string> listGamePlay_1 = new List<string>();
        List<string> listGamePlay_2 = new List<string>();
        List<int> listMoney = new List<int>();
        List<int> listMoney_1 = new List<int>();
        List<int> listMoney_2 = new List<int>();
        List<int> listMultiple = new List<int>();
        List<int> listMultiple_1 = new List<int>();
        List<int> listMultiple_2 = new List<int>();
        //List<string> listGOE = new List<string>();
        string roleGamePlay;
        //string roleGamePlay_1;
        //string roleGamePlay_2;
        int roleMultiple;
        int roleMultiple_1;
        int roleMultiple_2;
        int price;
        int price_1;
        int price_2;
        int sum;
        int winning;
        int winningPrize;
        int winningPrize_1;
        Button[] arrayBtn80_num = new Button[80];
        int[] arrayRndNums = new int[10];
        int[] arrayRndNums_1 = new int[9];
        int[] arrayRndNums_2 = new int[8];
        int[] arrayRndNums_3 = new int[7];
        int[] arrayRndNums_4 = new int[6];
        int[] arrayRndNums_5 = new int[5];
        int[] arrayRndNums_6 = new int[4];
        int[] arrayRndNums_7 = new int[3];
        int[] arrayRndNums_8 = new int[2];
        int[] arrayRndNums_9 = new int[1];
        int[] rndNumber = new int[20];
        string[] char_1 = new string[2];
        int[] arrayConvert = new int[10];
        int[] arrayConvert_01 = new int[10];
        int[] arrayConvert_1 = new int[9];
        int[] arrayConvert_2 = new int[8];
        int[] arrayConvert_3 = new int[7];
        int[] arrayConvert_4 = new int[6];
        int[] arrayConvert_5 = new int[5];
        int[] arrayConvert_6 = new int[4];
        int[] arrayConvert_7 = new int[3];
        int[] arrayConvert_8 = new int[2];
        int[] arrayConvert_9 = new int[1];

        public Form1()
        {
            InitializeComponent();
        }

        void createBtn(int intColumn, int intRow)
        {
            int num = 0;

            for(int i = 0; i < intRow; i++)
            {
                for(int j = 0; j < intColumn; j++)
                {
                    num++;
                    Button dBtn = new Button();
                    dBtn.BackColor = Color.Tan;
                    dBtn.ForeColor = Color.Navy;
                    dBtn.Font = new Font("微軟正黑體", 18);
                    dBtn.Text = num.ToString("00");
                    dBtn.Location = new Point(20 + 68 * j, 20 + 42 * i);
                    dBtn.Size = new Size(66, 40);
                    dBtn.Click += new EventHandler(dBtn_click);

                    Controls.Add(dBtn);
                    ListPGBtn.Add(dBtn);
                }
            }
            ListPGBtn.CopyTo(arrayBtn80_num);
            
        }

        private void dBtn_click(object sender, EventArgs e)
        {
            Button myBtn = (Button)sender;
            bool ifselected = false;

            if ((ListPGBtn.Count < 10) && (ifselected == false) && (comboGamePlay.SelectedIndex == 9))
            {
                if (myBtn.BackColor == Color.Tan)
                {
                    myBtn.BackColor = Color.Orange;
                    ListPGBtn.Add(myBtn);
                }
                else
                {
                    myBtn.BackColor = Color.Tan;
                    ListPGBtn.Remove(myBtn);
                }
            }
            else if ((ListPGBtn.Count < 9) && (ifselected == false) && (comboGamePlay.SelectedIndex == 8))
            {
                if (myBtn.BackColor == Color.Tan)
                {
                    myBtn.BackColor = Color.Orange;
                    ListPGBtn.Add(myBtn);
                }
                else
                {
                    myBtn.BackColor = Color.Tan;
                    ListPGBtn.Remove(myBtn);
                }
            }
            else if ((ListPGBtn.Count < 8) && (ifselected == false) && (comboGamePlay.SelectedIndex == 7))
            {
                if (myBtn.BackColor == Color.Tan)
                {
                    myBtn.BackColor = Color.Orange;
                    ListPGBtn.Add(myBtn);
                }
                else
                {
                    myBtn.BackColor = Color.Tan;
                    ListPGBtn.Remove(myBtn);
                }
            }
            else if ((ListPGBtn.Count < 7) && (ifselected == false) && (comboGamePlay.SelectedIndex == 6))
            {
                if (myBtn.BackColor == Color.Tan)
                {
                    myBtn.BackColor = Color.Orange;
                    ListPGBtn.Add(myBtn);
                }
                else
                {
                    myBtn.BackColor = Color.Tan;
                    ListPGBtn.Remove(myBtn);
                }
            }
            else if ((ListPGBtn.Count < 6) && (ifselected == false) && (comboGamePlay.SelectedIndex == 5))
            {
                if (myBtn.BackColor == Color.Tan)
                {
                    myBtn.BackColor = Color.Orange;
                    ListPGBtn.Add(myBtn);
                }
                else
                {
                    myBtn.BackColor = Color.Tan;
                    ListPGBtn.Remove(myBtn);
                }
            }
            else if ((ListPGBtn.Count < 5) && (ifselected == false) && (comboGamePlay.SelectedIndex == 4))
            {
                if (myBtn.BackColor == Color.Tan)
                {
                    myBtn.BackColor = Color.Orange;
                    ListPGBtn.Add(myBtn);
                }
                else
                {
                    myBtn.BackColor = Color.Tan;
                    ListPGBtn.Remove(myBtn);
                }
            }
            else if ((ListPGBtn.Count < 4) && (ifselected == false) && (comboGamePlay.SelectedIndex == 3))
            {
                if (myBtn.BackColor == Color.Tan)
                {
                    myBtn.BackColor = Color.Orange;
                    ListPGBtn.Add(myBtn);
                }
                else
                {
                    myBtn.BackColor = Color.Tan;
                    ListPGBtn.Remove(myBtn);
                }
            }
            else if ((ListPGBtn.Count < 3) && (ifselected == false) && (comboGamePlay.SelectedIndex == 2))
            {
                if (myBtn.BackColor == Color.Tan)
                {
                    myBtn.BackColor = Color.Orange;
                    ListPGBtn.Add(myBtn);
                }
                else
                {
                    myBtn.BackColor = Color.Tan;
                    ListPGBtn.Remove(myBtn);
                }
            }
            else if ((ListPGBtn.Count < 2) && (ifselected == false) && (comboGamePlay.SelectedIndex == 1))
            {
                if (myBtn.BackColor == Color.Tan)
                {
                    myBtn.BackColor = Color.Orange;
                    ListPGBtn.Add(myBtn);
                }
                else
                {
                    myBtn.BackColor = Color.Tan;
                    ListPGBtn.Remove(myBtn);
                }
            }
            else if((ListPGBtn.Count < 1) && (ifselected == false) && (comboGamePlay.SelectedIndex == 0))
            {
                if (myBtn.BackColor == Color.Tan)
                {
                    myBtn.BackColor = Color.Orange;
                    ListPGBtn.Add(myBtn);
                }
                else
                {
                    myBtn.BackColor = Color.Tan;
                    ListPGBtn.Remove(myBtn);
                }
            }
            else
            {
                if (myBtn.BackColor == Color.Orange)
                {
                    myBtn.BackColor = Color.Tan;
                    ListPGBtn.Remove(myBtn);
                }
            }

        }


        void produceRndNum()
        {
            Random myRndNum = new Random();
            int tempRndNum = 0;
            bool isDuplicate = false;

            arrayRndNums[0] = myRndNum.Next(1, 81);
            for(int i = 1; i < 10; i++)
            {
                tempRndNum = myRndNum.Next(1, 81);
                isDuplicate = arrayRndNums.Contains(tempRndNum);
                for(int j = 1; j < 10; j++)
                {
                    if(isDuplicate == true)
                    {
                        tempRndNum = myRndNum.Next(1, 81);
                        isDuplicate = arrayRndNums.Contains(tempRndNum);
                    }
                    else
                    {
                        arrayRndNums[i] = tempRndNum;
                    }
                }

            }
        }

        void produceRndNum_1()
        {
            Random myRndNum = new Random();
            int tempRndNum = 0;
            bool isDuplicate = false;

            arrayRndNums_1[0] = myRndNum.Next(1, 81);
            for (int i = 1; i < 9; i++)
            {
                tempRndNum = myRndNum.Next(1, 81);
                isDuplicate = arrayRndNums_1.Contains(tempRndNum);
                for (int j = 1; j < 9; j++)
                {
                    if (isDuplicate == true)
                    {
                        tempRndNum = myRndNum.Next(1, 81);
                        isDuplicate = arrayRndNums_1.Contains(tempRndNum);
                    }
                    else
                    {
                        arrayRndNums_1[i] = tempRndNum;
                    }
                }

            }
        }
        void produceRndNum_2()
        {
            Random myRndNum = new Random();
            int tempRndNum = 0;
            bool isDuplicate = false;

            arrayRndNums_2[0] = myRndNum.Next(1, 81);
            for (int i = 1; i < 8; i++)
            {
                tempRndNum = myRndNum.Next(1, 81);
                isDuplicate = arrayRndNums_2.Contains(tempRndNum);
                for (int j = 1; j < 8; j++)
                {
                    if (isDuplicate == true)
                    {
                        tempRndNum = myRndNum.Next(1, 81);
                        isDuplicate = arrayRndNums_2.Contains(tempRndNum);
                    }
                    else
                    {
                        arrayRndNums_2[i] = tempRndNum;
                    }
                }

            }
        }
        void produceRndNum_3()
        {
            Random myRndNum = new Random();
            int tempRndNum = 0;
            bool isDuplicate = false;

            arrayRndNums_3[0] = myRndNum.Next(1, 81);
            for (int i = 1; i < 7; i++)
            {
                tempRndNum = myRndNum.Next(1, 81);
                isDuplicate = arrayRndNums_3.Contains(tempRndNum);
                for (int j = 1; j < 9; j++)
                {
                    if (isDuplicate == true)
                    {
                        tempRndNum = myRndNum.Next(1, 81);
                        isDuplicate = arrayRndNums_3.Contains(tempRndNum);
                    }
                    else
                    {
                        arrayRndNums_3[i] = tempRndNum;
                    }
                }

            }
        }
        void produceRndNum_4()
        {
            Random myRndNum = new Random();
            int tempRndNum = 0;
            bool isDuplicate = false;

            arrayRndNums_4[0] = myRndNum.Next(1, 81);
            for (int i = 1; i < 6; i++)
            {
                tempRndNum = myRndNum.Next(1, 81);
                isDuplicate = arrayRndNums_4.Contains(tempRndNum);
                for (int j = 1; j < 6; j++)
                {
                    if (isDuplicate == true)
                    {
                        tempRndNum = myRndNum.Next(1, 81);
                        isDuplicate = arrayRndNums_4.Contains(tempRndNum);
                    }
                    else
                    {
                        arrayRndNums_4[i] = tempRndNum;
                    }
                }

            }
        }
        void produceRndNum_5()
        {
            Random myRndNum = new Random();
            int tempRndNum = 0;
            bool isDuplicate = false;

            arrayRndNums_5[0] = myRndNum.Next(1, 81);
            for (int i = 1; i < 5; i++)
            {
                tempRndNum = myRndNum.Next(1, 81);
                isDuplicate = arrayRndNums_5.Contains(tempRndNum);
                for (int j = 1; j < 5; j++)
                {
                    if (isDuplicate == true)
                    {
                        tempRndNum = myRndNum.Next(1, 81);
                        isDuplicate = arrayRndNums_5.Contains(tempRndNum);
                    }
                    else
                    {
                        arrayRndNums_5[i] = tempRndNum;
                    }
                }

            }
        }
        void produceRndNum_6()
        {
            Random myRndNum = new Random();
            int tempRndNum = 0;
            bool isDuplicate = false;

            arrayRndNums_6[0] = myRndNum.Next(1, 81);
            for (int i = 1; i < 4; i++)
            {
                tempRndNum = myRndNum.Next(1, 81);
                isDuplicate = arrayRndNums_6.Contains(tempRndNum);
                for (int j = 1; j < 4; j++)
                {
                    if (isDuplicate == true)
                    {
                        tempRndNum = myRndNum.Next(1, 81);
                        isDuplicate = arrayRndNums_6.Contains(tempRndNum);
                    }
                    else
                    {
                        arrayRndNums_6[i] = tempRndNum;
                    }
                }

            }
        }
        void produceRndNum_7()
        {
            Random myRndNum = new Random();
            int tempRndNum = 0;
            bool isDuplicate = false;

            arrayRndNums_7[0] = myRndNum.Next(1, 81);
            for (int i = 1; i < 3; i++)
            {
                tempRndNum = myRndNum.Next(1, 81);
                isDuplicate = arrayRndNums_7.Contains(tempRndNum);
                for (int j = 1; j < 3; j++)
                {
                    if (isDuplicate == true)
                    {
                        tempRndNum = myRndNum.Next(1, 81);
                        isDuplicate = arrayRndNums_7.Contains(tempRndNum);
                    }
                    else
                    {
                        arrayRndNums_7[i] = tempRndNum;
                    }
                }

            }
        }
        void produceRndNum_8()
        {
            Random myRndNum = new Random();
            int tempRndNum = 0;
            bool isDuplicate = false;

            arrayRndNums_8[0] = myRndNum.Next(1, 81);
            for (int i = 1; i < 2; i++)
            {
                tempRndNum = myRndNum.Next(1, 81);
                isDuplicate = arrayRndNums_8.Contains(tempRndNum);
                for (int j = 1; j < 2; j++)
                {
                    if (isDuplicate == true)
                    {
                        tempRndNum = myRndNum.Next(1, 81);
                        isDuplicate = arrayRndNums_8.Contains(tempRndNum);
                    }
                    else
                    {
                        arrayRndNums_8[i] = tempRndNum;
                    }
                }

            }
        }
        void produceRndNum_9()
        {
            Random myRndNum = new Random();
            int tempRndNum = 0;
            bool isDuplicate = false;

            arrayRndNums_9[0] = myRndNum.Next(1, 81);
            for (int i = 1; i < 1; i++)
            {
                tempRndNum = myRndNum.Next(1, 81);
                isDuplicate = arrayRndNums_9.Contains(tempRndNum);
                for (int j = 1; j < 1; j++)
                {
                    if (isDuplicate == true)
                    {
                        tempRndNum = myRndNum.Next(1, 81);
                        isDuplicate = arrayRndNums_9.Contains(tempRndNum);
                    }
                    else
                    {
                        arrayRndNums_9[i] = tempRndNum;
                    }
                }

            }
        }
        void quickPick()
        {   int[] idxNum = new int[10];
            Random myNumRnd = new Random();
            for(int i = 0; i < 10; i++)
            {
                idxNum[i] = myNumRnd.Next(1, 80);

                for (int j = 0; j < i; j++)
                {
                    while (idxNum[i] == idxNum[j])
                    {
                        j = 0;
                        idxNum[i] = myNumRnd.Next(1, 80);
                    }
                }


                ListPGBtn[idxNum[i]].BackColor = Color.Orange;
            }
        }

        void quickPick_1()
        {
            int[] idxNum = new int[9];
            Random myNumRnd = new Random();
            for (int i = 0; i < 9; i++)
            {
                idxNum[i] = myNumRnd.Next(1, 80);

                for (int j = 0; j < i; j++)
                {
                    while (idxNum[i] == idxNum[j])
                    {
                        j = 0;
                        idxNum[i] = myNumRnd.Next(1, 80);
                    }
                }


                ListPGBtn[idxNum[i]].BackColor = Color.Orange;
            }
        }
        void quickPick_2()
        {
            int[] idxNum = new int[8];
            Random myNumRnd = new Random();
            for (int i = 0; i < 8; i++)
            {
                idxNum[i] = myNumRnd.Next(1, 80);

                for (int j = 0; j < i; j++)
                {
                    while (idxNum[i] == idxNum[j])
                    {
                        j = 0;
                        idxNum[i] = myNumRnd.Next(1, 80);
                    }
                }


                ListPGBtn[idxNum[i]].BackColor = Color.Orange;
            }
        }
        void quickPick_3()
        {
            int[] idxNum = new int[7];
            Random myNumRnd = new Random();
            for (int i = 0; i < 7; i++)
            {
                idxNum[i] = myNumRnd.Next(1, 80);

                for (int j = 0; j < i; j++)
                {
                    while (idxNum[i] == idxNum[j])
                    {
                        j = 0;
                        idxNum[i] = myNumRnd.Next(1, 80);
                    }
                }


                ListPGBtn[idxNum[i]].BackColor = Color.Orange;
            }
        }
        void quickPick_4()
        {
            int[] idxNum = new int[6];
            Random myNumRnd = new Random();
            for (int i = 0; i < 6; i++)
            {
                idxNum[i] = myNumRnd.Next(1, 80);

                for (int j = 0; j < i; j++)
                {
                    while (idxNum[i] == idxNum[j])
                    {
                        j = 0;
                        idxNum[i] = myNumRnd.Next(1, 80);
                    }
                }


                ListPGBtn[idxNum[i]].BackColor = Color.Orange;
            }
        }
        void quickPick_5()
        {
            int[] idxNum = new int[5];
            Random myNumRnd = new Random();
            for (int i = 0; i < 5; i++)
            {
                idxNum[i] = myNumRnd.Next(1, 80);

                for (int j = 0; j < i; j++)
                {
                    while (idxNum[i] == idxNum[j])
                    {
                        j = 0;
                        idxNum[i] = myNumRnd.Next(1, 80);
                    }
                }


                ListPGBtn[idxNum[i]].BackColor = Color.Orange;
            }
        }
        void quickPick_6()
        {
            int[] idxNum = new int[4];
            Random myNumRnd = new Random();
            for (int i = 0; i < 4; i++)
            {
                idxNum[i] = myNumRnd.Next(1, 80);

                for (int j = 0; j < i; j++)
                {
                    while (idxNum[i] == idxNum[j])
                    {
                        j = 0;
                        idxNum[i] = myNumRnd.Next(1, 80);
                    }
                }


                ListPGBtn[idxNum[i]].BackColor = Color.Orange;
            }
        }
        void quickPick_7()
        {
            int[] idxNum = new int[3];
            Random myNumRnd = new Random();
            for (int i = 0; i < 3; i++)
            {
                idxNum[i] = myNumRnd.Next(1, 80);

                for (int j = 0; j < i; j++)
                {
                    while (idxNum[i] == idxNum[j])
                    {
                        j = 0;
                        idxNum[i] = myNumRnd.Next(1, 80);
                    }
                }


                ListPGBtn[idxNum[i]].BackColor = Color.Orange;
            }
        }
        void quickPick_8()
        {
            int[] idxNum = new int[2];
            Random myNumRnd = new Random();
            for (int i = 0; i < 2; i++)
            {
                idxNum[i] = myNumRnd.Next(1, 80);

                for (int j = 0; j < i; j++)
                {
                    while (idxNum[i] == idxNum[j])
                    {
                        j = 0;
                        idxNum[i] = myNumRnd.Next(1, 80);
                    }
                }


                ListPGBtn[idxNum[i]].BackColor = Color.Orange;
            }
        }
        void quickPick_9()
        {
            int[] idxNum = new int[1];
            Random myNumRnd = new Random();
            for (int i = 0; i < 1; i++)
            {
                idxNum[i] = myNumRnd.Next(1, 80);

                for (int j = 0; j < i; j++)
                {
                    while (idxNum[i] == idxNum[j])
                    {
                        j = 0;
                        idxNum[i] = myNumRnd.Next(1, 80);
                    }
                }


                ListPGBtn[idxNum[i]].BackColor = Color.Orange;
            }
        }
        void clearNum()
        {
            for (int i = 0; i < ListPGBtn.Count; i++)
            {
                ListPGBtn[i].BackColor = Color.Tan;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            createBtn(10, 8);
            ListPGBtn.Clear();

            lblbet.Text = "";
            //listLabels.Add(lbl1st);
            //listLabels.Add(lbl2nd);
            //listLabels.Add(lbl3rd);
            //listLabels.Add(lbl4th);
            //listLabels.Add(lbl5th);
            //listLabels.Add(lbl6th);
            //listLabels.Add(lbl7th);
            //listLabels.Add(lbl8th);
            //listLabels.Add(lbl9th);
            //listLabels.Add(lbl10th);
            //listLabels.Add(lbl11th);
            //listLabels.Add(lbl12th);
            //listLabels.Add(lbl13th);
            //listLabels.Add(lbl14th);
            //listLabels.Add(lbl15th);
            //listLabels.Add(lbl16th);
            //listLabels.Add(lbl17th);
            //listLabels.Add(lbl18th);
            //listLabels.Add(lbl19th);
            //listLabels.Add(lbl20th);

            listGamePlay.Add("Choose One");
            listGamePlay.Add("Choose Two");
            listGamePlay.Add("Choose Three");
            listGamePlay.Add("Choose Four");
            listGamePlay.Add("Choose Five");
            listGamePlay.Add("Choose Six");
            listGamePlay.Add("Choose Seven");
            listGamePlay.Add("Choose Eight");
            listGamePlay.Add("Choose Night");
            listGamePlay.Add("Choose Ten");

            listGamePlay_1.Add("--");
            listGamePlay_1.Add("OddNumber");
            listGamePlay_1.Add("EvenNumber");

            listGamePlay_2.Add("--");
            listGamePlay_2.Add("BIG");
            listGamePlay_2.Add("SMALL");

            listMoney.Add(25);
            listMoney.Add(25);
            listMoney.Add(25);
            listMoney.Add(25);
            listMoney.Add(25);
            listMoney.Add(25);
            listMoney.Add(25);
            listMoney.Add(25);
            listMoney.Add(25);
            listMoney.Add(25);

            listMoney_1.Add(0);
            listMoney_1.Add(25);
            listMoney_1.Add(25);

            listMoney_2.Add(0);
            listMoney_2.Add(25);
            listMoney_2.Add(25);

            listMultiple.Add(1);
            listMultiple.Add(2);
            listMultiple.Add(3);
            listMultiple.Add(4);
            listMultiple.Add(5);
            listMultiple.Add(6);
            listMultiple.Add(8);
            listMultiple.Add(10);
            listMultiple.Add(12);
            listMultiple.Add(20);
            listMultiple.Add(50);
            

            listMultiple_1.Add(1);
            listMultiple_1.Add(2);
            listMultiple_1.Add(3);
            listMultiple_1.Add(4);
            listMultiple_1.Add(5);
            listMultiple_1.Add(6);
            listMultiple_1.Add(8);
            listMultiple_1.Add(10);
            listMultiple_1.Add(12);
            listMultiple_1.Add(20);
            listMultiple_1.Add(50);

            listMultiple_2.Add(1);
            listMultiple_2.Add(2);
            listMultiple_2.Add(3);
            listMultiple_2.Add(4);
            listMultiple_2.Add(5);
            listMultiple_2.Add(6);
            listMultiple_2.Add(8);
            listMultiple_2.Add(10);
            listMultiple_2.Add(12);
            listMultiple_2.Add(20);
            listMultiple_2.Add(50);


            foreach (string item in listGamePlay)
            {
                comboGamePlay.Items.Add(item);
            }
            foreach (string item in listGamePlay_1)
            {
                comboGamePlay_1.Items.Add(item);
            }
            foreach (string item in listGamePlay_2)
            {
                comboGamePlay_2.Items.Add(item);
            }
            for (int i = 0; i < listMultiple.Count; i++)
            {
                string strRole = string.Format("X {0}", listMultiple[i]);
                comboMultiple.Items.Add(strRole);
            }
            for (int i = 0; i < listMultiple_1.Count; i++)
            {
                string strRole = string.Format("X {0}", listMultiple_1[i]);
                comboMultiple_1.Items.Add(strRole);
            }
            for (int i = 0; i < listMultiple_2.Count; i++)
            {
                string strRole = string.Format("X {0}", listMultiple_2[i]);
                comboMultiple_2.Items.Add(strRole);
            }

            comboGamePlay.SelectedIndex = 0;
            roleGamePlay = listGamePlay[comboGamePlay.SelectedIndex];
            //comboGamePlay_1.SelectedIndex = 0;
            //roleGamePlay_1 = listGamePlay_1[comboGamePlay_1.SelectedIndex];
            //comboGamePlay_2.SelectedIndex = 0;
            //roleGamePlay_2 = listGamePlay_2[comboGamePlay_2.SelectedIndex];
            comboMultiple.SelectedIndex= 0;
            roleMultiple = listMultiple[comboMultiple.SelectedIndex];
            comboMultiple_1.SelectedIndex = 0;
            roleMultiple_1 = listMultiple_1[comboMultiple_1.SelectedIndex];
            comboMultiple_2.SelectedIndex = 0;
            roleMultiple_2 = listMultiple_2[comboMultiple_2.SelectedIndex];
        }

        private void btnLotteryDraw_Click(object sender, EventArgs e)
        {
            Random number = new Random();
            //int[] rndNumber = new int[20];
            //list01 = char_1.ToList<string>();
            //string[] char_1 = new string[2];
            char_1[0] = "OddNumber";
            char_1[1] = "EvenNumber";

            string[] char_2 = new string[3];
            char_2[0] = "BIG";
            char_2[1] = "SMALL";
            char_2[2] = "--";

            //string strNumSet = "";

            //for (int i = 0; i < 20; i++)
            //{
            //    int randNum = number.Next(1, 81);
            //    //listLabels[i].Text = randNum.ToString("00");
                
            //    //strNumSet += number + " ";
            //}
            for (int i = 0; i < 20; i++)
            {
                rndNumber[i] = number.Next(1, 81);
                for(int j = 0; j < i; j++)
                {
                    while (rndNumber[i] == rndNumber[j])
                    {
                        j = 0;
                        rndNumber[i] = number.Next(1, 81); 
                    }
                }
            }
            Array.Sort(rndNumber);
            lbl1st.Text = rndNumber[0].ToString("00");
            lbl2nd.Text = rndNumber[1].ToString("00");
            lbl3rd.Text = rndNumber[2].ToString("00");
            lbl4th.Text = rndNumber[3].ToString("00");
            lbl5th.Text = rndNumber[4].ToString("00");
            lbl6th.Text = rndNumber[5].ToString("00");
            lbl7th.Text = rndNumber[6].ToString("00");
            lbl8th.Text = rndNumber[7].ToString("00");
            lbl9th.Text = rndNumber[8].ToString("00");
            lbl10th.Text= rndNumber[9].ToString("00");
            lbl11th.Text= rndNumber[10].ToString("00");
            lbl12th.Text= rndNumber[11].ToString("00");
            lbl13th.Text= rndNumber[12].ToString("00");
            lbl14th.Text= rndNumber[13].ToString("00");
            lbl15th.Text= rndNumber[14].ToString("00");
            lbl16th.Text= rndNumber[15].ToString("00");
            lbl17th.Text= rndNumber[16].ToString("00");
            lbl18th.Text= rndNumber[17].ToString("00");
            lbl19th.Text= rndNumber[18].ToString("00");
            lbl20th.Text= rndNumber[19].ToString("00");

            for (int i = 0; i < 2; i++)
            {
                int guess_1 = number.Next(0, char_1.Length);
                lblOddorEven.Text = char_1[guess_1];
            }

            for (int i = 0; i < 3; i++)
            {
                int guess_2 = number.Next(0, char_2.Length);
                lblBigorSmall.Text = char_2[guess_2];
            }

        }

        private void comboGamePlay_SelectedIndexChanged(object sender, EventArgs e)
        {
            roleGamePlay = listGamePlay[comboGamePlay.SelectedIndex];
        }

        void total()
        {
            sum = price + price_1 + price_2;

            lblSum.Text = string.Format("{0}NTD", sum);
            
        }

        private void comboMultiple_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (comboGamePlay.SelectedIndex > -1)
            {
                roleGamePlay = listGamePlay[comboGamePlay.SelectedIndex];
                price = listMoney[comboGamePlay.SelectedIndex] * listMultiple[comboMultiple.SelectedIndex];

                lblprice.Text = string.Format("{0}NTD", price);

                total();
            }
        }
        private void comboGamePlay_1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (comboGamePlay_1.SelectedIndex > -1)
            {
                roleMultiple_1 = listMultiple_1[comboMultiple_1.SelectedIndex];
                price_1 = listMoney_1[comboGamePlay_1.SelectedIndex] * listMultiple_1[comboMultiple_1.SelectedIndex];

                lblprice_1.Text = string.Format("{0}NTD", price_1);

                total();
            }

        }
        private void comboMultiple_1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboGamePlay_1.SelectedIndex > -1)
            {
                roleMultiple_1 = listMultiple_1[comboMultiple_1.SelectedIndex];
                price_1 = listMoney_1[comboGamePlay_1.SelectedIndex] * listMultiple_1[comboMultiple_1.SelectedIndex];

                lblprice_1.Text = string.Format("{0}NTD", price_1);

                total();
            }

        }

        private void comboGamePlay_2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboGamePlay_2.SelectedIndex > -1)
            {
                roleMultiple_2 = listMultiple_1[comboMultiple_2.SelectedIndex];
                price_2 = listMoney_2[comboGamePlay_2.SelectedIndex] * listMultiple_2[comboMultiple_2.SelectedIndex];

                lblprice_2.Text = string.Format("{0}NTD", price_2);

                total();
            }
        }

        private void comboMultiple_2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboGamePlay_2.SelectedIndex > -1)
            {
                roleMultiple_2 = listMultiple_1[comboMultiple_2.SelectedIndex];
                price_2 = listMoney_2[comboGamePlay_2.SelectedIndex] * listMultiple_2[comboMultiple_2.SelectedIndex];

                lblprice_2.Text = string.Format("{0}NTD", price_2);

                total();
            }
        }

        private void btnQuickPick_Click(object sender, EventArgs e)
        {
            if (comboGamePlay.SelectedIndex == 9)
            {
                produceRndNum();
                foreach (Button Numbers in arrayBtn80_num)
                {
                    Numbers.BackColor = Color.Tan;
                }

                ListPGBtn.Clear();

                foreach (int rndNum in arrayRndNums)
                {
                    arrayBtn80_num[rndNum - 1].BackColor = Color.Orange;
                    ListPGBtn.Add(arrayBtn80_num[rndNum - 1]);
                }

            }else if (comboGamePlay.SelectedIndex == 8)
            {
                produceRndNum_1();
                foreach (Button Numbers in arrayBtn80_num)
                {
                    Numbers.BackColor = Color.Tan;
                }

                ListPGBtn.Clear();

                foreach (int rndNum in arrayRndNums_1)
                {
                    arrayBtn80_num[rndNum - 1].BackColor = Color.Orange;
                    ListPGBtn.Add(arrayBtn80_num[rndNum - 1]);
                }
            }
            else if (comboGamePlay.SelectedIndex == 7)
            {
                produceRndNum_2();
                foreach (Button Numbers in arrayBtn80_num)
                {
                    Numbers.BackColor = Color.Tan;
                }

                ListPGBtn.Clear();

                foreach (int rndNum in arrayRndNums_2)
                {
                    arrayBtn80_num[rndNum - 1].BackColor = Color.Orange;
                    ListPGBtn.Add(arrayBtn80_num[rndNum - 1]);
                }
            }
            else if (comboGamePlay.SelectedIndex == 6)
            {
                produceRndNum_3();
                foreach (Button Numbers in arrayBtn80_num)
                {
                    Numbers.BackColor = Color.Tan;
                }

                ListPGBtn.Clear();

                foreach (int rndNum in arrayRndNums_3)
                {
                    arrayBtn80_num[rndNum - 1].BackColor = Color.Orange;
                    ListPGBtn.Add(arrayBtn80_num[rndNum - 1]);
                }
            }
            else if (comboGamePlay.SelectedIndex == 5)
            {
                produceRndNum_4();
                foreach (Button Numbers in arrayBtn80_num)
                {
                    Numbers.BackColor = Color.Tan;
                }

                ListPGBtn.Clear();

                foreach (int rndNum in arrayRndNums_4)
                {
                    arrayBtn80_num[rndNum - 1].BackColor = Color.Orange;
                    ListPGBtn.Add(arrayBtn80_num[rndNum - 1]);
                }
            }
            else if (comboGamePlay.SelectedIndex == 4)
            {
                produceRndNum_5();
                foreach (Button Numbers in arrayBtn80_num)
                {
                    Numbers.BackColor = Color.Tan;
                }

                ListPGBtn.Clear();

                foreach (int rndNum in arrayRndNums_5)
                {
                    arrayBtn80_num[rndNum - 1].BackColor = Color.Orange;
                    ListPGBtn.Add(arrayBtn80_num[rndNum - 1]);
                }
            }
            else if (comboGamePlay.SelectedIndex == 3)
            {
                produceRndNum_6();
                foreach (Button Numbers in arrayBtn80_num)
                {
                    Numbers.BackColor = Color.Tan;
                }

                ListPGBtn.Clear();

                foreach (int rndNum in arrayRndNums_6)
                {
                    arrayBtn80_num[rndNum - 1].BackColor = Color.Orange;
                    ListPGBtn.Add(arrayBtn80_num[rndNum - 1]);
                }
            }
            else if (comboGamePlay.SelectedIndex == 2)
            {
                produceRndNum_7();
                foreach (Button Numbers in arrayBtn80_num)
                {
                    Numbers.BackColor = Color.Tan;
                }

                ListPGBtn.Clear();

                foreach (int rndNum in arrayRndNums_7)
                {
                    arrayBtn80_num[rndNum - 1].BackColor = Color.Orange;
                    ListPGBtn.Add(arrayBtn80_num[rndNum - 1]);
                }
            }
            else if (comboGamePlay.SelectedIndex == 1)
            {
                produceRndNum_8();
                foreach (Button Numbers in arrayBtn80_num)
                {
                    Numbers.BackColor = Color.Tan;
                }

                ListPGBtn.Clear();

                foreach (int rndNum in arrayRndNums_8)
                {
                    arrayBtn80_num[rndNum - 1].BackColor = Color.Orange;
                    ListPGBtn.Add(arrayBtn80_num[rndNum - 1]);
                }
            }
            else
            {
                produceRndNum_9();
                foreach (Button Numbers in arrayBtn80_num)
                {
                    Numbers.BackColor = Color.Tan;
                }

                ListPGBtn.Clear();

                foreach (int rndNum in arrayRndNums_9)
                {
                    arrayBtn80_num[rndNum - 1].BackColor = Color.Orange;
                    ListPGBtn.Add(arrayBtn80_num[rndNum - 1]);
                }
            }
            //if(btnQuickPick.Enabled == true && comboGamePlay.SelectedIndex == 9)
            //{
            //    clearNum();
            //    quickPick();
            //}
            //else if(btnQuickPick.Enabled == true && comboGamePlay.SelectedIndex == 8)
            //{
            //    clearNum();
            //    quickPick_1();
            //}
            //else if (btnQuickPick.Enabled == true && comboGamePlay.SelectedIndex == 7)
            //{
            //    clearNum();
            //    quickPick_2();
            //}
            //else if (btnQuickPick.Enabled == true && comboGamePlay.SelectedIndex == 6)
            //{
            //    clearNum();
            //    quickPick_3();
            //}
            //else if (btnQuickPick.Enabled == true && comboGamePlay.SelectedIndex == 5)
            //{
            //    clearNum();
            //    quickPick_4();
            //}
            //else if (btnQuickPick.Enabled == true && comboGamePlay.SelectedIndex == 4)
            //{
            //    clearNum();
            //    quickPick_5();
            //}
            //else if (btnQuickPick.Enabled == true && comboGamePlay.SelectedIndex == 3)
            //{
            //    clearNum();
            //    quickPick_6();
            //}
            //else if (btnQuickPick.Enabled == true && comboGamePlay.SelectedIndex == 2)
            //{
            //    clearNum();
            //    quickPick_7();
            //}
            //else if (btnQuickPick.Enabled == true && comboGamePlay.SelectedIndex == 1)
            //{
            //    clearNum();
            //    quickPick_8();
            //}
            //else 
            //{
            //    clearNum();
            //    quickPick_9();
            //}

        }

        private void btnClearPick_Click(object sender, EventArgs e)
        {
            //clearNum();
            ListPGBtn.Clear();
            foreach(Button clear in arrayBtn80_num)
            {
                clear.BackColor = Color.Tan;
            }
        }

        private void groupGOE_Enter(object sender, EventArgs e)
        {
            
        }

        private void radioOdd_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void radioEven_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void radioBig_CheckedChanged(object sender, EventArgs e)
        {
           
        }
        private void radioSmall_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        void winnningPrizes()
        {


            if (winningPrize > 0)
            {
                winning = winningPrize;
                label3.Text = string.Format("CONGRATS!! \nWiNNING the Lottey\nYou can get: {0}NTD", winning);

            }
            else
            {
                label3.Text = "SORRY, \nYou didn't winning the Prize";
            }

            if (winningPrize_1 > 0) 
            {
                winning = winningPrize_1;
                label3.Text = string.Format("CONGRATS!! \nWiNNING the Lottey\nYou can get: {0}NTD", winning);
                
            }
            else 
            {
                label3.Text = "SORRY, \nYou didn't winning the Prize";
            }
            
        }

        private void btnWiningNum_Click(object sender, EventArgs e)
        {


            if (listGamePlay[comboGamePlay.SelectedIndex] == listGamePlay[9])
            {
                if (arrayRndNums.Intersect(rndNumber).Count() == 10)
                {
                    winningPrize = 200000 * 25 * listMultiple[comboMultiple.SelectedIndex];
                }
                else if (arrayRndNums.Intersect(rndNumber).Count() == 9)
                {
                    winningPrize = 10000 * 25 * listMultiple[comboMultiple.SelectedIndex];
                }
                else if (arrayRndNums.Intersect(rndNumber).Count() == 8)
                {
                    winningPrize = 1000 * 25 * listMultiple[comboMultiple.SelectedIndex];
                }
                else if (arrayRndNums.Intersect(rndNumber).Count() == 7)
                {
                    winningPrize = 100 * 25 * listMultiple[comboMultiple.SelectedIndex];
                }
                else if (arrayRndNums.Intersect(rndNumber).Count() == 6)
                {
                    winningPrize = 10 * 25 * listMultiple[comboMultiple.SelectedIndex];
                }
                else if ((arrayRndNums.Intersect(rndNumber).Count() == 5) || (arrayRndNums.Intersect(rndNumber).Count() == 0))
                {
                    winningPrize = 1 * 25 * listMultiple[comboMultiple.SelectedIndex];
                }
                else
                {
                    winningPrize = 0;
                }
                winnningPrizes();
            }

            if (listGamePlay[comboGamePlay.SelectedIndex] == listGamePlay[8])
            {
                if (arrayRndNums_1.Intersect(rndNumber).Count() == 9)
                {
                    winningPrize = 40000 * 25 * listMultiple[comboMultiple.SelectedIndex];
                }
                else if (arrayRndNums_1.Intersect(rndNumber).Count() == 8)
                {
                    winningPrize = 4000 * 25 * listMultiple[comboMultiple.SelectedIndex];
                }
                else if (arrayRndNums_1.Intersect(rndNumber).Count() == 7)
                {
                    winningPrize = 120 * 25 * listMultiple[comboMultiple.SelectedIndex];
                }
                else if (arrayRndNums_1.Intersect(rndNumber).Count() == 6)
                {
                    winningPrize = 20 * 25 * listMultiple[comboMultiple.SelectedIndex];
                }
                else if (arrayRndNums_1.Intersect(rndNumber).Count() == 5)
                {
                    winningPrize = 4 * 25 * listMultiple[comboMultiple.SelectedIndex];
                }
                else if ((arrayRndNums_1.Intersect(rndNumber).Count() == 4) || (arrayRndNums_1.Intersect(rndNumber).Count() == 0))
                {
                    winningPrize = 1 * 25 * listMultiple[comboMultiple.SelectedIndex];
                }
                else
                {
                    winningPrize = 0;
                }
                winnningPrizes();
            }


            if (listGamePlay[comboGamePlay.SelectedIndex] == listGamePlay[7])
            {
                if (arrayRndNums_2.Intersect(rndNumber).Count() == 8)
                {
                    winningPrize = 20000 * 25 * listMultiple[comboMultiple.SelectedIndex];
                }
                else if (arrayRndNums_2.Intersect(rndNumber).Count() == 7)
                {
                    winningPrize = 800 * 25 * listMultiple[comboMultiple.SelectedIndex];
                }
                else if (arrayRndNums_2.Intersect(rndNumber).Count() == 6)
                {
                    winningPrize = 40 * 25 * listMultiple[comboMultiple.SelectedIndex];
                }
                else if (arrayRndNums_2.Intersect(rndNumber).Count() == 5)
                {
                    winningPrize = 8 * 25 * listMultiple[comboMultiple.SelectedIndex];
                }
                else if ((arrayRndNums_2.Intersect(rndNumber).Count() == 4) || (arrayRndNums_2.Intersect(rndNumber).Count() == 0))
                {
                    winningPrize = 1 * 25 * listMultiple[comboMultiple.SelectedIndex];
                }
                else
                {
                    winningPrize = 0;
                }
                winnningPrizes();
            }


            if (listGamePlay[comboGamePlay.SelectedIndex] == listGamePlay[6])
            {
                if (arrayRndNums_3.Intersect(rndNumber).Count() == 7)
                {
                    winningPrize = 3200 * 25 * listMultiple[comboMultiple.SelectedIndex];
                }
                else if (arrayRndNums_3.Intersect(rndNumber).Count() == 6)
                {
                    winningPrize = 120 * 25 * listMultiple[comboMultiple.SelectedIndex];
                }
                else if (arrayRndNums_3.Intersect(rndNumber).Count() == 5)
                {
                    winningPrize = 12 * 25 * listMultiple[comboMultiple.SelectedIndex];
                }
                else if (arrayRndNums_3.Intersect(rndNumber).Count() == 4)
                {
                    winningPrize = 2 * 25 * listMultiple[comboMultiple.SelectedIndex];
                }
                else if (arrayRndNums_3.Intersect(rndNumber).Count() == 3)
                {
                    winningPrize = 1 * 25 * listMultiple[comboMultiple.SelectedIndex];
                }
                else
                {
                    winningPrize = 0;
                }
                winnningPrizes();
            }


            if (listGamePlay[comboGamePlay.SelectedIndex] == listGamePlay[5])
            {
                if (arrayRndNums_4.Intersect(rndNumber).Count() == 6)
                {
                    winningPrize = 100 * 25 * listMultiple[comboMultiple.SelectedIndex];
                }
                else if (arrayRndNums_4.Intersect(rndNumber).Count() == 5)
                {
                    winningPrize = 40 * 25 * listMultiple[comboMultiple.SelectedIndex];
                }
                else if (arrayRndNums_4.Intersect(rndNumber).Count() == 4)
                {
                    winningPrize = 8 * 25 * listMultiple[comboMultiple.SelectedIndex];
                }
                else if (arrayRndNums_4.Intersect(rndNumber).Count() == 3)
                {
                    winningPrize = 1 * 25 * listMultiple[comboMultiple.SelectedIndex];
                }
                else
                {
                    winningPrize = 0;
                }
                winnningPrizes();
            }

            if (listGamePlay[comboGamePlay.SelectedIndex] == listGamePlay[4])
            {
                if (arrayRndNums_5.Intersect(rndNumber).Count() == 5)
                {
                    winningPrize = 300 * 25 * listMultiple[comboMultiple.SelectedIndex];
                }
                else if (arrayRndNums_5.Intersect(rndNumber).Count() == 4)
                {
                    winningPrize = 20 * 25 * listMultiple[comboMultiple.SelectedIndex];
                }
                else if (arrayRndNums_5.Intersect(rndNumber).Count() == 3)
                {
                    winningPrize = 2 * 25 * listMultiple[comboMultiple.SelectedIndex];
                }
                else
                {
                    winningPrize = 0;
                }
                winnningPrizes();
            }



            if (listGamePlay[comboGamePlay.SelectedIndex] == listGamePlay[3])
            {
                if (arrayRndNums_6.Intersect(rndNumber).Count() == 4)
                {
                    winningPrize = 40 * 25 * listMultiple[comboMultiple.SelectedIndex];
                }
                else if (arrayRndNums_6.Intersect(rndNumber).Count() == 3)
                {
                    winningPrize = 4 * 25 * listMultiple[comboMultiple.SelectedIndex];
                }
                else if (arrayRndNums_6.Intersect(rndNumber).Count() == 2)
                {
                    winningPrize = 1 * 25 * listMultiple[comboMultiple.SelectedIndex];
                }
                else
                {
                    winningPrize = 0;
                }
                winnningPrizes();
            }

            if (listGamePlay[comboGamePlay.SelectedIndex] == listGamePlay[2])
            {
                if (arrayRndNums_7.Intersect(rndNumber).Count() == 3)
                {
                    winningPrize = 20 * 25 * listMultiple[comboMultiple.SelectedIndex];
                }
                else if (arrayRndNums_7.Intersect(rndNumber).Count() == 2)
                {
                    winningPrize = 2 * 25 * listMultiple[comboMultiple.SelectedIndex];
                }
                else
                {
                    winningPrize = 0;
                }
                winnningPrizes();
            }


            if (listGamePlay[comboGamePlay.SelectedIndex] == listGamePlay[1])
            {
                if (arrayRndNums_8.Intersect(rndNumber).Count() == 2)
                {
                    winningPrize = 3 * 25 * listMultiple[comboMultiple.SelectedIndex];
                }
                else if (arrayRndNums_8.Intersect(rndNumber).Count() == 1)
                {
                    winningPrize = 1 * 25 * listMultiple[comboMultiple.SelectedIndex];
                }
                else
                {
                    winningPrize = 0;
                }
                winnningPrizes();
            }


            if (listGamePlay[comboGamePlay.SelectedIndex] == listGamePlay[0])
            {
                if (arrayRndNums_9.Intersect(rndNumber).Count() == 1)
                {
                    winningPrize = 2 * 25 * listMultiple[comboMultiple.SelectedIndex];
                }
                else
                {
                    winningPrize = 0;
                }
                winnningPrizes();
            }



            if (listGamePlay[comboGamePlay.SelectedIndex] == listGamePlay[9])
            {
                if (arrayConvert.Intersect(rndNumber).Count() == 10)
                {
                    winningPrize_1 = 200000 * 25 * listMultiple[comboMultiple.SelectedIndex];
                }
                else if (arrayConvert.Intersect(rndNumber).Count() == 9)
                {
                    winningPrize_1 = 10000 * 25 * listMultiple[comboMultiple.SelectedIndex];
                }
                else if (arrayConvert.Intersect(rndNumber).Count() == 8)
                {
                    winningPrize_1 = 1000 * 25 * listMultiple[comboMultiple.SelectedIndex];
                }
                else if (arrayConvert.Intersect(rndNumber).Count() == 7)
                {
                    winningPrize_1 = 100 * 25 * listMultiple[comboMultiple.SelectedIndex];
                }
                else if (arrayConvert.Intersect(rndNumber).Count() == 6)
                {
                    winningPrize_1 = 10 * 25 * listMultiple[comboMultiple.SelectedIndex];
                }
                else if ((arrayConvert.Intersect(rndNumber).Count() == 5) || (arrayConvert.Intersect(rndNumber).Count() == 0))
                {
                    winningPrize_1 = 1 * 25 * listMultiple[comboMultiple.SelectedIndex];
                }
                else
                {
                    winningPrize_1 = 0;
                }
                winnningPrizes();
            }

            if (listGamePlay[comboGamePlay.SelectedIndex] == listGamePlay[8])
            {
                if (arrayConvert_1.Intersect(rndNumber).Count() == 9)
                {
                    winningPrize_1 = 40000 * 25 * listMultiple[comboMultiple.SelectedIndex];
                }
                else if (arrayConvert_1.Intersect(rndNumber).Count() == 8)
                {
                    winningPrize_1 = 4000 * 25 * listMultiple[comboMultiple.SelectedIndex];
                }
                else if (arrayConvert_1.Intersect(rndNumber).Count() == 7)
                {
                    winningPrize_1 = 120 * 25 * listMultiple[comboMultiple.SelectedIndex];
                }
                else if (arrayConvert_1.Intersect(rndNumber).Count() == 6)
                {
                    winningPrize_1 = 20 * 25 * listMultiple[comboMultiple.SelectedIndex];
                }
                else if (arrayConvert_1.Intersect(rndNumber).Count() == 5)
                {
                    winningPrize_1 = 4 * 25 * listMultiple[comboMultiple.SelectedIndex];
                }
                else if ((arrayConvert_1.Intersect(rndNumber).Count() == 4) || (arrayConvert_1.Intersect(rndNumber).Count() == 0))
                {
                    winningPrize_1 = 1 * 25 * listMultiple[comboMultiple.SelectedIndex];
                }
                else
                {
                    winningPrize_1 = 0;
                }
                winnningPrizes();
            }


            if (listGamePlay[comboGamePlay.SelectedIndex] == listGamePlay[7])
            {
                if (rndNumber.Intersect(arrayConvert_2).Count() == 8)
                {
                    winningPrize_1 = 20000 * 25 * listMultiple[comboMultiple.SelectedIndex];
                }
                else if (rndNumber.Intersect(arrayConvert_2).Count() == 7)
                {
                    winningPrize_1 = 800 * 25 * listMultiple[comboMultiple.SelectedIndex];
                }
                else if (rndNumber.Intersect(arrayConvert_2).Count() == 6)
                {
                    winningPrize_1 = 40 * 25 * listMultiple[comboMultiple.SelectedIndex];
                }
                else if (rndNumber.Intersect(arrayConvert_2).Count() == 5)
                {
                    winningPrize_1 = 8 * 25 * listMultiple[comboMultiple.SelectedIndex];
                }
                else if ((rndNumber.Intersect(arrayConvert_2).Count() == 4) || (rndNumber.Intersect(arrayConvert_2).Count() == 0))
                {
                    winningPrize_1 = 1 * 25 * listMultiple[comboMultiple.SelectedIndex];
                }
                else
                {
                    winningPrize_1 = 0;
                }
                winnningPrizes();
            }

            if (listGamePlay[comboGamePlay.SelectedIndex] == listGamePlay[6])
            {
                if (rndNumber.Intersect(arrayConvert_3).Count() == 7)
                {
                    winningPrize_1 = 3200 * 25 * listMultiple[comboMultiple.SelectedIndex];
                }
                else if (rndNumber.Intersect(arrayConvert_3).Count() == 6)
                {
                    winningPrize_1 = 120 * 25 * listMultiple[comboMultiple.SelectedIndex];
                }
                else if (rndNumber.Intersect(arrayConvert_3).Count() == 5)
                {
                    winningPrize_1 = 12 * 25 * listMultiple[comboMultiple.SelectedIndex];
                }
                else if (rndNumber.Intersect(arrayConvert_3).Count() == 4)
                {
                    winningPrize_1 = 2 * 25 * listMultiple[comboMultiple.SelectedIndex];
                }
                else if (rndNumber.Intersect(arrayConvert_3).Count() == 3)
                {
                    winningPrize_1 = 1 * 25 * listMultiple[comboMultiple.SelectedIndex];
                }
                else
                {
                    winningPrize_1 = 0;
                }
                winnningPrizes();
            }

            if (listGamePlay[comboGamePlay.SelectedIndex] == listGamePlay[5])
            {
                if (rndNumber.Intersect(arrayConvert_4).Count() == 6)
                {
                    winningPrize_1 = 100 * 25 * listMultiple[comboMultiple.SelectedIndex];
                }
                else if (rndNumber.Intersect(arrayConvert_4).Count() == 5)
                {
                    winningPrize_1 = 40 * 25 * listMultiple[comboMultiple.SelectedIndex];
                }
                else if (rndNumber.Intersect(arrayConvert_4).Count() == 4)
                {
                    winningPrize_1 = 8 * 25 * listMultiple[comboMultiple.SelectedIndex];
                }
                else if (rndNumber.Intersect(arrayConvert_4).Count() == 3)
                {
                    winningPrize_1 = 1 * 25 * listMultiple[comboMultiple.SelectedIndex];
                }
                else
                {
                    winningPrize_1 = 0;
                }
                winnningPrizes();
            }

            if (listGamePlay[comboGamePlay.SelectedIndex] == listGamePlay[4])
            {
                if (rndNumber.Intersect(arrayConvert_5).Count() == 5)
                {
                    winningPrize_1 = 300 * 25 * listMultiple[comboMultiple.SelectedIndex];
                }
                else if (rndNumber.Intersect(arrayConvert_5).Count() == 4)
                {
                    winningPrize_1 = 20 * 25 * listMultiple[comboMultiple.SelectedIndex];
                }
                else if (rndNumber.Intersect(arrayConvert_5).Count() == 3)
                {
                    winningPrize_1 = 2 * 25 * listMultiple[comboMultiple.SelectedIndex];
                }
                else
                {
                    winningPrize_1 = 0;
                }
                winnningPrizes();
            }


            if (listGamePlay[comboGamePlay.SelectedIndex] == listGamePlay[3])
            {
                if (rndNumber.Intersect(arrayConvert_6).Count() == 4)
                {
                    winningPrize_1 = 40 * 25 * listMultiple[comboMultiple.SelectedIndex];
                }
                else if (rndNumber.Intersect(arrayConvert_6).Count() == 3)
                {
                    winningPrize_1 = 4 * 25 * listMultiple[comboMultiple.SelectedIndex];
                }
                else if (rndNumber.Intersect(arrayConvert_6).Count() == 2)
                {
                    winningPrize_1 = 1 * 25 * listMultiple[comboMultiple.SelectedIndex];
                }
                else
                {
                    winningPrize_1 = 0;
                }
                winnningPrizes();
            }


            if (listGamePlay[comboGamePlay.SelectedIndex] == listGamePlay[2])
            {
                if (rndNumber.Intersect(arrayConvert_7).Count() == 3)
                {
                    winningPrize_1 = 20 * 25 * listMultiple[comboMultiple.SelectedIndex];
                }
                else if (rndNumber.Intersect(arrayConvert_7).Count() == 2)
                {
                    winningPrize_1 = 2 * 25 * listMultiple[comboMultiple.SelectedIndex];
                }
                else
                {
                    winningPrize_1 = 0;
                }
                winnningPrizes();
            }

            if (listGamePlay[comboGamePlay.SelectedIndex] == listGamePlay[1])
            {
                if (arrayConvert_8.Intersect(rndNumber).Count() == 2)
                {
                    winningPrize_1 = 3 * 25 * listMultiple[comboMultiple.SelectedIndex];

                }
                else if (arrayConvert_8.Intersect(rndNumber).Count() == 1)
                {
                    winningPrize_1 = 1 * 25 * listMultiple[comboMultiple.SelectedIndex];

                }
                else
                {
                    winningPrize_1 = 0;
                }
                winnningPrizes();
            }

            if (listGamePlay[comboGamePlay.SelectedIndex] == listGamePlay[0])
            {

                if (arrayConvert_9.Intersect(rndNumber).Count() == 1)
                {
                    winningPrize_1 = 2 * 25 * listMultiple[comboMultiple.SelectedIndex];

                }
                else
                {
                    winningPrize_1 = 0;
                }
                winnningPrizes();
            }
               





            winnningPrizes();
            

        }

        private void btnBet_Click(object sender, EventArgs e)
        {
            if (listGamePlay[comboGamePlay.SelectedIndex] == listGamePlay[9])
            {

                if (ListPGBtn.Count == 10)
                {
                    if (lblbet.Text == "")
                    {
                        for (int i = 0; i < 10; i++)
                        {
                            arrayConvert[i] = Convert.ToInt32(ListPGBtn[i].Text);
                        }
                        Array.Sort(arrayConvert);
                        foreach (Button myButton in ListPGBtn)
                        {

                            lblbet.Text += myButton.Text.ToString() + " ";

                        }

                    }
                }
                else
                {
                    MessageBox.Show("請選擇\"10\"個號碼，或 由電腦選號下注");
                }
            }
            if (listGamePlay[comboGamePlay.SelectedIndex] == listGamePlay[8])
            {

                

            
            if (ListPGBtn.Count == 9)
            {
                    if (lblbet.Text == "")
                    {
                        for (int i = 0; i < 9; i++)
                        {
                            arrayConvert_1[i] = Convert.ToInt32(ListPGBtn[i].Text);
                        }
                        Array.Sort(arrayConvert_1);
                        foreach (Button myButton in ListPGBtn)
                        {
                            lblbet.Text += myButton.Text.ToString() + " ";
                        }

                    }
                }
                else
                {
                    MessageBox.Show("請選擇\"9\"個號碼，或 由電腦選號下注");
                }
            }

            if (listGamePlay[comboGamePlay.SelectedIndex] == listGamePlay[7])
            {

                if (ListPGBtn.Count == 8)
                {
                    if (lblbet.Text == "")
                    {
                        for (int i = 0; i < 8; i++)
                        {
                            arrayConvert_2[i] = Convert.ToInt32(ListPGBtn[i].Text);
                        }
                        Array.Sort(arrayConvert_2);
                        foreach (Button myButton in ListPGBtn)
                        {
                            lblbet.Text += myButton.Text.ToString() + " ";
                        }

                    }
                }
                else
                {
                    MessageBox.Show("請選擇\"8\"個號碼，或 由電腦選號下注");
                }
            }

            if (listGamePlay[comboGamePlay.SelectedIndex] == listGamePlay[6])
            {

                if (ListPGBtn.Count == 7)
                {
                    if (lblbet.Text == "")
                    {
                        for (int i = 0; i < 7; i++)
                        {
                            arrayConvert_3[i] = Convert.ToInt32(ListPGBtn[i].Text);
                        }
                        Array.Sort(arrayConvert_3);
                        foreach (Button myButton in ListPGBtn)
                        {
                            lblbet.Text += myButton.Text.ToString() + " ";
                        }

                    }
                }
                else
                {
                    MessageBox.Show("請選擇\"7\"個號碼，或 由電腦選號下注");
                }
            }

            if (listGamePlay[comboGamePlay.SelectedIndex] == listGamePlay[5])
            {

                if (ListPGBtn.Count == 6)
                {
                    if (lblbet.Text == "")
                    {
                        for (int i = 0; i < 6; i++)
                        {
                            arrayConvert_4[i] = Convert.ToInt32(ListPGBtn[i].Text);
                        }
                        Array.Sort(arrayConvert_4);
                        foreach (Button myButton in ListPGBtn)
                        {
                            lblbet.Text += myButton.Text.ToString() + " ";
                        }

                    }
                }
                else
                {
                    MessageBox.Show("請選擇\"6\"個號碼，或 由電腦選號下注");
                }
            }

            if (listGamePlay[comboGamePlay.SelectedIndex] == listGamePlay[4])
            {

                if (ListPGBtn.Count == 5)
                {
                    if (lblbet.Text == "")
                    {
                        for (int i = 0; i < 5; i++)
                        {
                            arrayConvert_5[i] = Convert.ToInt32(ListPGBtn[i].Text);
                        }
                        Array.Sort(arrayConvert_5);
                        foreach (Button myButton in ListPGBtn)
                        {
                            lblbet.Text += myButton.Text.ToString() + " ";
                        }

                    }
                }
                else
                {
                    MessageBox.Show("請選擇\"5\"個號碼，或 由電腦選號下注");
                }
            }

            if (listGamePlay[comboGamePlay.SelectedIndex] == listGamePlay[3])
            {

                if (ListPGBtn.Count == 4)
                {
                    if (lblbet.Text == "")
                    {
                        for (int i = 0; i < 4; i++)
                        {
                            arrayConvert_6[i] = Convert.ToInt32(ListPGBtn[i].Text);
                        }
                        Array.Sort(arrayConvert_6);
                        foreach (Button myButton in ListPGBtn)
                        {
                            lblbet.Text += myButton.Text.ToString() + " ";
                        }

                    }
                }
                else
                {
                    MessageBox.Show("請選擇\"4\"個號碼，或 由電腦選號下注");
                }
            }

            if (listGamePlay[comboGamePlay.SelectedIndex] == listGamePlay[2])
            {

                if (ListPGBtn.Count == 3)
                {
                    if (lblbet.Text == "")
                    {
                        for (int i = 0; i < 3; i++)
                        {
                            arrayConvert_7[i] = Convert.ToInt32(ListPGBtn[i].Text);
                        }
                        Array.Sort(arrayConvert_7);
                        foreach (Button myButton in ListPGBtn)
                        {
                            lblbet.Text += myButton.Text.ToString() + " ";
                        }

                    }
                }
                else
                {
                    MessageBox.Show("請選擇\"3\"個號碼，或 由電腦選號下注");
                }
            }

            if (listGamePlay[comboGamePlay.SelectedIndex] == listGamePlay[1])
            {

                if (ListPGBtn.Count == 2)
                {
                    if (lblbet.Text == "")
                    {
                        for (int i = 0; i < 2; i++)
                        {
                            arrayConvert_8[i] = Convert.ToInt32(ListPGBtn[i].Text);
                        }
                        Array.Sort(arrayConvert_8);
                        foreach (Button myButton in ListPGBtn)
                        {
                            lblbet.Text += myButton.Text.ToString() + " ";
                        }

                    }
                }
                else
                {
                    MessageBox.Show("請選擇\"2\"個號碼，或 由電腦選號下注");
                }
            }

            if (listGamePlay[comboGamePlay.SelectedIndex] == listGamePlay[0])
            {

                if (ListPGBtn.Count == 1)
                {
                    if (lblbet.Text == "")
                    {
                        for (int i = 0; i < 1; i++)
                        {
                            arrayConvert_9[i] = Convert.ToInt32(ListPGBtn[i].Text);
                        }
                        Array.Sort(arrayConvert_9);
                        foreach (Button myButton in ListPGBtn)
                        {
                            lblbet.Text += myButton.Text.ToString() + " ";
                        }

                    }
                }
                else
                {
                    MessageBox.Show("請選擇\"1\"個號碼，或 由電腦選號下注");
                }
            }
        }

        private void btnReBet_Click(object sender, EventArgs e)
        {
            lblbet.Text = "";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            
        }

        private void lblbet_Click(object sender, EventArgs e)
        {

        }
    }
}
