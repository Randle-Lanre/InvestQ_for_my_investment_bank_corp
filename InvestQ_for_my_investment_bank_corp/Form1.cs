using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace InvestQ_for_my_investment_bank_corp
{
    
    public partial class Form1 : Form
    {
         decimal VALUE_OF_PRINCIPAL = 0m;

        const decimal INTEREST_ON_AMOUNT_UPTO_100K_1MONTH = 0.5000m;
        const decimal INTEREST_0N_AMOUNT_UPTO_100K_3MONTH = 0.6250m;
        const decimal INTEREST_ON_AMOUNT_UPTO_100K_6MONTH = 0.7125m;
        const decimal INTEREST_ON_AMOUNT_UPTO_100K_12MONTH= 1.1250m;

        const decimal INTEREST_ON_AMOUNT_ABOVE_100K_1MONTH = 0.6000m;
        const decimal INTEREST_ON_AMOUNT_ABOVE_100K_3MONTH = 0.7250m;
        const decimal INTEREST_ON_AMOUNT_ABOVE_100K_6MONTH = 0.8125m;
        const decimal INTEREST_ON_AMOUNT_ABOVE_100K_12MONTH= 1.2500m;

         int TERM_1=1, TERM_3=3,  TERM_6=6, TERM_12 = 12;

        decimal principal; double Amount; decimal rate; decimal term;
       

        private void DisplayButton_Click(object sender, EventArgs e)
        { 
            InvestAmountTextBox.MaxLength = 9;//sets the maximum lenght of input that can be accepted

            if (InvestAmountTextBox.Text != "" &&  InvestAmountTextBox.TextLength==5 && InvestAmountTextBox.TextLength<6 )//check there aren't negatives, set max limit(max and min)
            {
                //principal = decimal.Parse(InvestAmountTextBox.Text);

                // Amount = (principal * (Math.Pow ((double)(1 + INTEREST_ON_AMOUNT_UPTO_100K_1MONTH, TERM_1)) - 1).ToString;

                decimal rawdata = decimal.Parse(InvestAmountTextBox.Text);
                 CalculateInterest(rawdata, 6m, 6m);
                label6.Text = Amount.ToString();
                
                



            }
            else if (InvestAmountTextBox.Text != "" && InvestAmountTextBox.TextLength==6 && InvestAmountTextBox.TextLength<7 )
            {


            }
            else if (InvestAmountTextBox.Text !="" && InvestAmountTextBox.TextLength>7)
            {

            }
            else
            {
                MessageBox.Show("Invalid Input", "Please enter a valid Number Not less than 5 digits", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } 
        } 

    
        public Form1()
        {
            InitializeComponent();
        }

        public void FileWriter()//method created to handle file writes
        {
            using (StreamWriter writer = new StreamWriter("ListOfInvestors.txt"))
                writer.Write(Name + PhoneNumberTextBox + EmailTextBox);

        }

        public double CalculateInterest(decimal principal,  decimal rate, decimal term)
        {
            // principal((1 + (rate/100)/term )^term);
            Amount =(double) principal * (Math.Pow(1 + (double)rate, (double)term) - 1);
            return Amount;
        }
        public void FindMyTransactions()
        {

        }
    }
}
