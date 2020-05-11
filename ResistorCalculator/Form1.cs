using System;
using System.Drawing;
using System.Windows.Forms;

namespace ResistorCalculator
{
    public partial class Form1 : Form
    {
        double? firstTwoNumbers=null, firstStripeValue = null, secondStripeValue=null, thirdStripeValue=null, fourthStripeValue;
        ElectricalResistance resistance = new ElectricalResistance();
         

        public Form1()
        {
            InitializeComponent();
        }   
       
        
        private void Display ()
        {
            try
            {
                firstTwoNumbers = Convert.ToDouble(string.Format("{0}{1}", firstStripeValue, secondStripeValue));
                lblResValue.Text = String.Format("{0}", (firstTwoNumbers));
            }
            catch (Exception)
            {

                lblResValue.Text = "";
            }

            if (firstTwoNumbers == null && thirdStripeValue != null)
            {
                lblResValue.Text = string.Format("{0} kΩ", thirdStripeValue/1000);
            }

            else if (firstTwoNumbers != null && thirdStripeValue != null)
            {

                double? resValue = (firstTwoNumbers * thirdStripeValue) / 1000;

                lblResValue.Text = string.Format("{0} kΩ", resValue);
            }

        }


        private void MakingChoice1(object sender, EventArgs e)
        {
            firstStripeValue = resistance.TableValue(comBox1.SelectedIndex, 0);
            Display();


            if (comBox1.SelectedIndex > -1)
            {
                switch (comBox1.SelectedIndex)
                {
                    case 0:
                        panel1.BackColor = Color.Transparent;
                        break;

                    case 1:
                        panel1.BackColor = Color.Gray;
                        break;

                    case 2:
                        panel1.BackColor = Color.Gold;
                        break;

                    case 3:
                        panel1.BackColor = Color.Black;
                        break;

                    case 4:
                        panel1.BackColor = Color.Brown;
                        break;

                    case 5:
                        panel1.BackColor = Color.Red;
                        break;

                    case 6:
                        panel1.BackColor = Color.Orange;
                        break;

                    case 7:
                        panel1.BackColor = Color.Yellow;
                        break;

                    case 8:
                        panel1.BackColor = Color.Green;
                        break;

                    case 9:
                        panel1.BackColor = Color.Blue;
                        break;

                    case 10:
                        panel1.BackColor = Color.Violet;
                        break;

                    case 11:
                        panel1.BackColor = Color.Gray;
                        break;

                    case 12:
                        panel1.BackColor = Color.White;
                        break;

                    default:
                        break;
                }
            }
        }

        

        private void MakingChoice2(object sender, EventArgs e)
        {
            secondStripeValue = resistance.TableValue(comBox2.SelectedIndex, 1);
            Display();


            if (comBox2.SelectedIndex > -1)
            {
                switch (comBox2.SelectedIndex)
                {
                    case 0:
                        panel2.BackColor = Color.Transparent;
                        break;

                    case 1:
                        panel2.BackColor = Color.Gray;
                        break;

                    case 2:
                        panel2.BackColor = Color.Gold;
                        break;

                    case 3:
                        panel2.BackColor = Color.Black;
                        break;

                    case 4:
                        panel2.BackColor = Color.Brown;
                        break;

                    case 5:
                        panel2.BackColor = Color.Red;
                        break;

                    case 6:
                        panel2.BackColor = Color.Orange;
                        break;

                    case 7:
                        panel2.BackColor = Color.Yellow;
                        break;

                    case 8:
                        panel2.BackColor = Color.Green;
                        break;

                    case 9:
                        panel2.BackColor = Color.Blue;
                        break;

                    case 10:
                        panel2.BackColor = Color.Violet;
                        break;

                    case 11:
                        panel2.BackColor = Color.Gray;
                        break;

                    case 12:
                        panel2.BackColor = Color.White;
                        break;

                    default:
                        break;
                }


            }
        }

        private void MakingChoice3(object sender, EventArgs e)
        {
            thirdStripeValue = resistance.TableValue(comBox3.SelectedIndex, 2);
            Display();


            if (comBox3.SelectedIndex > -1)
            {
                switch (comBox3.SelectedIndex)
                {
                    case 0:
                        panel3.BackColor = Color.Transparent;
                        break;

                    case 1:
                        panel3.BackColor = Color.Gray;
                        break;

                    case 2:
                        panel3.BackColor = Color.Gold;
                        break;

                    case 3:
                        panel3.BackColor = Color.Black;
                        break;

                    case 4:
                        panel3.BackColor = Color.Brown;
                        break;

                    case 5:
                        panel3.BackColor = Color.Red;
                        break;

                    case 6:
                        panel3.BackColor = Color.Orange;
                        break;

                    case 7:
                        panel3.BackColor = Color.Yellow;
                        break;

                    case 8:
                        panel3.BackColor = Color.Green;
                        break;

                    case 9:
                        panel3.BackColor = Color.Blue;
                        break;

                    case 10:
                        panel3.BackColor = Color.Violet;
                        break;

                    case 11:
                        panel3.BackColor = Color.Gray;
                        break;

                    case 12:
                        panel3.BackColor = Color.White;
                        break;

                    default:
                        break;
                }

            }
           
          
        }



        private void MakingChoice4(object sender, EventArgs e)
        {
            fourthStripeValue = resistance.TableValue(comBox4.SelectedIndex, 3);
            if (fourthStripeValue==null)
            {
                lblTol.Text = "-";
            }
            else 

            lblTol.Text = String.Format("Tolerancja: ± {0} %", fourthStripeValue);


            if (comBox4.SelectedIndex > -1)
            {
                switch (comBox4.SelectedIndex)
                {
                    case 0:
                        panel4.BackColor = Color.Transparent;
                        break;

                    case 1:
                        panel4.BackColor = Color.Gray;
                        break;

                    case 2:
                        panel4.BackColor = Color.Gold;
                        break;

                    case 3:
                        panel4.BackColor = Color.Black;
                        break;

                    case 4:
                        panel4.BackColor = Color.Brown;
                        break;

                    case 5:
                        panel4.BackColor = Color.Red;
                        break;

                    case 6:
                        panel4.BackColor = Color.Orange;
                        break;

                    case 7:
                        panel4.BackColor = Color.Yellow;
                        break;

                    case 8:
                        panel4.BackColor = Color.Green;
                        break;

                    case 9:
                        panel4.BackColor = Color.Blue;
                        break;

                    case 10:
                        panel4.BackColor = Color.Violet;
                        break;

                    case 11:
                        panel4.BackColor = Color.Gray;
                        break;

                    case 12:
                        panel4.BackColor = Color.White;
                        break;

                    default:
                        break;
                }


            }
        }


        

}
}
