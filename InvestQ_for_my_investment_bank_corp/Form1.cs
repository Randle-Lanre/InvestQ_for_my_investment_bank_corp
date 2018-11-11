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
using System.Text.RegularExpressions;

namespace InvestQ_for_my_investment_bank_corp
{
    
    public partial class InvestQForm : Form
    {
         //decimal VALUE_OF_PRINCIPAL = 0m;

        const decimal INTEREST_ON_AMOUNT_UPTO_100K_1MONTH = 0.5000m;
        const decimal INTEREST_0N_AMOUNT_UPTO_100K_3MONTH = 0.6250m;
        const decimal INTEREST_ON_AMOUNT_UPTO_100K_6MONTH = 0.7125m;
        const decimal INTEREST_ON_AMOUNT_UPTO_100K_12MONTH= 1.1250m;

        const decimal INTEREST_ON_AMOUNT_ABOVE_100K_1MONTH = 0.6000m;
        const decimal INTEREST_ON_AMOUNT_ABOVE_100K_3MONTH = 0.7250m;
        const decimal INTEREST_ON_AMOUNT_ABOVE_100K_6MONTH = 0.8125m;
        const decimal INTEREST_ON_AMOUNT_ABOVE_100K_12MONTH= 1.2500m;

         int TERM_1=1, TERM_3=3,  TERM_6=6, TERM_12 = 12;
        string value = "";

        //decimal principal
        double Amount; //decimal rate; //decimal term;
        string Message, Heading;

        string TransCount;
        decimal InvestmentAmount;

        private void DisplayButton_Click(object sender, EventArgs e)
        { 
            InvestAmountTextBox.MaxLength = 9;//sets the maximum lenght of input that can be accepted

            if (InvestAmountTextBox.Text != "" &&  InvestAmountTextBox.TextLength==5 && InvestAmountTextBox.TextLength<6 )//check there aren't negatives, set max limit(max and min)
            {
                //principal = decimal.Parse(InvestAmountTextBox.Text);

                // Amount = (principal * (Math.Pow ((double)(1 + INTEREST_ON_AMOUNT_UPTO_100K_1MONTH, TERM_1)) - 1).ToString;

                decimal principal = decimal.Parse(InvestAmountTextBox.Text);
                //CalculateInterest(principal, 6m, 6m);
                //label6.Text = Amount.ToString("C2");

                
                CalculateInterest(principal, INTEREST_ON_AMOUNT_UPTO_100K_1MONTH, TERM_1);
                
                Month1RadioButton.Text = "1 month  " +Amount.ToString("C2");

                CalculateInterest(principal, INTEREST_0N_AMOUNT_UPTO_100K_3MONTH, TERM_3);
                Month3RadioButton.Text = "3 months  " +Amount.ToString("C2");

                CalculateInterest(principal, INTEREST_ON_AMOUNT_UPTO_100K_6MONTH, TERM_6);
                Month6RadioButton.Text = "6 months  "+Amount.ToString("C2");

                CalculateInterest(principal, INTEREST_ON_AMOUNT_UPTO_100K_12MONTH, TERM_12);
                Month12RadioButton.Text = "12 months  "+Amount.ToString("C2");
                



            }
            else if (InvestAmountTextBox.Text != "" && InvestAmountTextBox.TextLength==6 && InvestAmountTextBox.TextLength<7 )
            {

                decimal principal = decimal.Parse(InvestAmountTextBox.Text);

                CalculateInterest(principal, INTEREST_ON_AMOUNT_ABOVE_100K_1MONTH, TERM_1);

                Month1RadioButton.Text = "1 month  " + Amount.ToString("C2");

                CalculateInterest(principal, INTEREST_ON_AMOUNT_ABOVE_100K_3MONTH, TERM_3);
                Month3RadioButton.Text = "3 months  " + Amount.ToString("C2");

                CalculateInterest(principal, INTEREST_ON_AMOUNT_ABOVE_100K_6MONTH, TERM_6);
                Month6RadioButton.Text = "6 months  " + Amount.ToString("C2");

                CalculateInterest(principal, INTEREST_ON_AMOUNT_ABOVE_100K_12MONTH, TERM_12);
                Month12RadioButton.Text = "12 months  " + Amount.ToString("C2");
                

            }
            else if (InvestAmountTextBox.Text !="" && InvestAmountTextBox.TextLength==7 && InvestAmountTextBox.TextLength<9)
            {
                decimal principal = decimal.Parse(InvestAmountTextBox.Text);

                CalculateInterest(principal, INTEREST_ON_AMOUNT_ABOVE_100K_1MONTH, TERM_1);

                Month1RadioButton.Text = "1 month  " + Amount.ToString("C2");

                CalculateInterest(principal, INTEREST_ON_AMOUNT_ABOVE_100K_3MONTH, TERM_3);
                Month3RadioButton.Text = "3 months  " + Amount.ToString("C2");

                CalculateInterest(principal, INTEREST_ON_AMOUNT_ABOVE_100K_6MONTH, TERM_6);
                Month6RadioButton.Text = "6 months  " +"+ £5000 "+ (Amount+5000).ToString("C2");

                CalculateInterest(principal, INTEREST_ON_AMOUNT_ABOVE_100K_12MONTH, TERM_12);
                Month12RadioButton.Text = "12 months  "+"+ £5000 " + (Amount+5000).ToString("C2");

            }
            else
            {
                MessageBox.Show( "Please enter a valid Number Not less than 5 digits", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } 
        } 

    
        public InvestQForm()
        {
            InitializeComponent();
        }

        private void ProceedButton_Click(object sender, EventArgs e)
        {
            UserDetailsGB.Visible = true;
            ConfirmButton.Visible = true;
            try
            {
                if (Month1RadioButton.Checked)
                {
                    value = Month1RadioButton.Text;
                }
                else if (Month3RadioButton.Checked)
                {
                    value = Month3RadioButton.Text;
                }
                else if (Month6RadioButton.Checked)
                {
                    value = Month6RadioButton.Text;
                }
                else if (Month12RadioButton.Checked)
                {
                    value = Month12RadioButton.Text;
                }
            }
            catch { MessageBox.Show("Please choose a term"); }



           /* 
            bool isChecked = Month1RadioButton.Checked;
            if (isChecked)
               value = Month1RadioButton.Text;
            
            else
               value = Month3RadioButton.Text;
            else
                value = Month6RadioButton.Text;  */
        }

        private void InvestQForm_Load(object sender, EventArgs e)
        {
            UserDetailsGB.Visible = false;
            ConfirmButton.Visible = false;

        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            Message = ("Details of your transaction below\n"+
                "Transaction id: "+ TransactionNumberTextBox.Text+"\n"+ 
               "Name: " +NameTextBox.Text+"\n"+ 
               "Phone Number: "+PhoneNumberTextBox.Text+"\n"+
               "Email: "+EmailTextBox.Text+"\n"+
               "If the details above are correct and you wish to proceed click OK ");
            Heading = "Confirmation";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            MessageBoxIcon messageIcon = MessageBoxIcon.Question;
            DialogResult result;
            result = MessageBox.Show(Message, Heading, buttons,messageIcon );
            if (result==DialogResult.OK)
            {
                FileWriter();

                MessageBox.Show("Clients details have been saved ","Details Saved",MessageBoxButtons.OK);

                TransCount += TransactionNumberTextBox.Text + "\n";
                

            }

            
        }

        private void SummaryButton_Click(object sender, EventArgs e)
        {
            TextOut.Text = TransCount; 
        }

        public void FileWriter()//method created to handle file writes
        {
            StreamWriter outputFile = new StreamWriter("Investorslist.txt", true);
            outputFile.WriteLine(TransactionNumberTextBox.Text + "" + NameTextBox.Text +
                " " + PhoneNumberTextBox.Text + " " + EmailTextBox.Text+ "" + value);
            outputFile.Close();

        }

        public double CalculateInterest(decimal principal,  decimal rate, decimal term)
        {
            // principal((1 + (rate/100)/term )^term);
            Amount =(double) principal * (Math.Pow(1 + (double)rate/100, (double)term) );
            return Amount;
        }

        public void TransactionDetails()
        {

        }

        public void FindMyTransactions()
        {

        }
    }
}
