using System;
using System.Drawing;
using System.Windows.Forms;

namespace ResistorCalculator
{
    public partial class Form1 : Form
    {
        double? firstTwoNumbers=null, firstStripeValue = null, secondStripeValue=null, thirdStripeValue=null, fourthStripeValue;
        ElectricalResistance resistance = new ElectricalResistance();
        SetColor panelColor = new SetColor();

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
            panel1.BackColor = panelColor.GetColor(comBox1.SelectedIndex);
                      
        }

        

        private void MakingChoice2(object sender, EventArgs e)
        {
            secondStripeValue = resistance.TableValue(comBox2.SelectedIndex, 1);
            Display();
            panel2.BackColor = panelColor.GetColor(comBox2.SelectedIndex);

        }

        private void MakingChoice3(object sender, EventArgs e)
        {
            thirdStripeValue = resistance.TableValue(comBox3.SelectedIndex, 2);
            Display();
            panel3.BackColor = panelColor.GetColor(comBox3.SelectedIndex);          
        }



        private void MakingChoice4(object sender, EventArgs e)
        {
            fourthStripeValue = resistance.TableValue(comBox4.SelectedIndex, 3);
            if (fourthStripeValue==null)
            {
                lblTol.Text = "-";
            }
            else 

            lblTol.Text = String.Format("± {0} %", fourthStripeValue);

            panel4.BackColor = panelColor.GetColor(comBox4.SelectedIndex);            
        }


        

}
}
