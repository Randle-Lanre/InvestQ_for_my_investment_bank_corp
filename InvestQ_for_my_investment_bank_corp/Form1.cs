﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
//using System.Text.RegularExpressions;

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
        string AvgMonths;
       

        //-----------
        decimal Month1InterestWithPrincipal, Month3InterestWithPrincipal, Month6InterestWithPrincipal,
            Month12InterestWithPrincipal;
        decimal AllInvestments;
        decimal InvestedAmount;
        decimal AccuringInterest;
        int TotalTermsInvested;
        decimal NumberOfTransactions=0;
        //-----------
        decimal RawSum, RawMonths, RawInvestment;
        string Result, Result2,de, Result3, Result4;

        int count = 0;



        public InvestQForm()
        {
            InitializeComponent();
        }



        private void InvestQForm_Load(object sender, EventArgs e)
        {
            UserDetailsGB.Enabled = false;
            ConfirmButton.Enabled = false;
            
            SummaryGB.Visible = true;

            
            SummaryButton.Visible = true;
            ClearButton.Enabled = false;
            ProceedButton.Enabled = false;

            Month1RadioButton.Checked = false;
            Month3RadioButton.Checked = false;
            Month6RadioButton.Checked = false;
            Month12RadioButton.Checked = false;

            Month1RadioButton.Enabled = false;
            Month3RadioButton.Enabled = false;
            Month6RadioButton.Enabled = false;
            Month12RadioButton.Enabled = false;

            InvestAmountTextBox.MaxLength = 9;//sets the maximum lenght of input that can be accepted
            TransactionNumberTextBox.MaxLength = 6;

            DisplayButton.Text = "&Display";
            ProceedButton.Text = "&Proceed";
            ConfirmButton.Text = "&Confirm";
            SummaryButton.Text = "&Summary";
            ClearButton.Text = "&Clear";
            //Clear button and Transaction history remains

            



        }

        private void DisplayButton_Click(object sender, EventArgs e)
        {
            string Str = InvestAmountTextBox.Text;

            double Num;

            bool isNum = double.TryParse(Str, out Num);

            if (isNum && InvestAmountTextBox.TextLength>=5)
            {

                Month1RadioButton.Enabled = true;
                Month3RadioButton.Enabled = true;
                Month6RadioButton.Enabled = true;
                Month12RadioButton.Enabled = true;
                ProceedButton.Enabled = true;
                ClearButton.Enabled = true;

                if (InvestAmountTextBox.Text != "" && InvestAmountTextBox.TextLength == 5 && InvestAmountTextBox.TextLength < 6)//check there aren't negatives, set max limit(max and min)
                {
                    //principal = decimal.Parse(InvestAmountTextBox.Text);

                    // Amount = (principal * (Math.Pow ((double)(1 + INTEREST_ON_AMOUNT_UPTO_100K_1MONTH, TERM_1)) - 1).ToString;

                    decimal principal = decimal.Parse(InvestAmountTextBox.Text);
                    //CalculateInterest(principal, 6m, 6m);
                    //label6.Text = Amount.ToString("C2");


                    CalculateInterest(principal, INTEREST_ON_AMOUNT_UPTO_100K_1MONTH, TERM_1);
                    Month1InterestWithPrincipal = (decimal)Amount;
                    Month1RadioButton.Text = "1 month  " + Amount.ToString("C2");

                    CalculateInterest(principal, INTEREST_0N_AMOUNT_UPTO_100K_3MONTH, TERM_3);
                    Month3InterestWithPrincipal = (decimal)Amount;
                    Month3RadioButton.Text = "3 months  " + Amount.ToString("C2");

                    CalculateInterest(principal, INTEREST_ON_AMOUNT_UPTO_100K_6MONTH, TERM_6);
                    Month6InterestWithPrincipal = (decimal)Amount;
                    Month6RadioButton.Text = "6 months  " + Amount.ToString("C2");

                    CalculateInterest(principal, INTEREST_ON_AMOUNT_UPTO_100K_12MONTH, TERM_12);
                    Month12InterestWithPrincipal = (decimal)Amount;
                    Month12RadioButton.Text = "12 months  " + Amount.ToString("C2");




                }
                else if (InvestAmountTextBox.Text != "" && InvestAmountTextBox.TextLength == 6 && InvestAmountTextBox.TextLength < 7)
                {

                    decimal principal = decimal.Parse(InvestAmountTextBox.Text);

                    CalculateInterest(principal, INTEREST_ON_AMOUNT_ABOVE_100K_1MONTH, TERM_1);
                    Month1InterestWithPrincipal = (decimal)Amount;
                    Month1RadioButton.Text = "1 month  " + Amount.ToString("C2");

                    CalculateInterest(principal, INTEREST_ON_AMOUNT_ABOVE_100K_3MONTH, TERM_3);
                    Month3InterestWithPrincipal = (decimal)Amount;
                    Month3RadioButton.Text = "3 months  " + Amount.ToString("C2");

                    CalculateInterest(principal, INTEREST_ON_AMOUNT_ABOVE_100K_6MONTH, TERM_6);
                    Month6InterestWithPrincipal = (decimal)Amount;
                    Month6RadioButton.Text = "6 months  " + Amount.ToString("C2");

                    CalculateInterest(principal, INTEREST_ON_AMOUNT_ABOVE_100K_12MONTH, TERM_12);
                    Month12InterestWithPrincipal = (decimal)Amount;
                    Month12RadioButton.Text = "12 months  " + Amount.ToString("C2");


                }
                else if (InvestAmountTextBox.Text != "" && InvestAmountTextBox.TextLength == 7 && InvestAmountTextBox.TextLength < 9)
                {
                    decimal principal = decimal.Parse(InvestAmountTextBox.Text);

                    CalculateInterest(principal, INTEREST_ON_AMOUNT_ABOVE_100K_1MONTH, TERM_1);
                    Month1InterestWithPrincipal = (decimal)Amount;
                    Month1RadioButton.Text = "1 month  " + Amount.ToString("C2");

                    CalculateInterest(principal, INTEREST_ON_AMOUNT_ABOVE_100K_3MONTH, TERM_3);
                    Month3InterestWithPrincipal = (decimal)Amount;
                    Month3RadioButton.Text = "3 months  " + Amount.ToString("C2");

                    CalculateInterest(principal, INTEREST_ON_AMOUNT_ABOVE_100K_6MONTH, TERM_6);
                    Month6InterestWithPrincipal = (decimal)(Amount + 5000);
                    Month6RadioButton.Text = "6 months  " + "+ £5000 " + (Amount + 5000).ToString("C2");
                    

                    CalculateInterest(principal, INTEREST_ON_AMOUNT_ABOVE_100K_12MONTH, TERM_12);
                    Month12InterestWithPrincipal = (decimal)(Amount + 5000);
                    Month12RadioButton.Text = "12 months  " + "+ £5000 " + (Amount + 5000).ToString("C2");

                }
                else
                {
                    MessageBox.Show("Please enter a valid Number Not less than 5 digits", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    InvestAmountTextBox.Focus();
                    InvestAmountTextBox.SelectAll();
                }

            }
            else
            {
                MessageBox.Show("Please enter a valid Number Not Strings or Symbols", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                InvestAmountTextBox.Focus();
                InvestAmountTextBox.SelectAll();
            }
        }

        private void TransacHistory_Click(object sender, EventArgs e)
        {
            //calls the method find my transaction to search for transactions
            FindMyTransactions(SearchQueryTextBox.Text);

        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            InvestAmountTextBox.Text = "";

            TransactionNumberTextBox.Text = "";
            NameTextBox.Text = "";
            PhoneNumberTextBox.Text = "";
            EmailTextBox.Text = "";

            DisplayTransNumber.Text = "";
            TotalAmountInvestedLabel.Text = "";
            TotalInterestAccruedLabel.Text = "";
            AvgTermOfInvestementLabel.Text = "";

            Month1RadioButton.Text = "1 Month";
            Month3RadioButton.Text = "3 Months";
            Month6RadioButton.Text = "6 Months";
            Month12RadioButton.Text = "12 Months";

            UserDetailsGB.Enabled = false;
            SummaryGB.Visible = false;

            ConfirmButton.Enabled = false;
            SummaryButton.Visible = false;
            ClearButton.Enabled = false;
            ProceedButton.Enabled = false;

            Month1RadioButton.Checked = false;
            Month3RadioButton.Checked = false;
            Month6RadioButton.Checked = false;
            Month12RadioButton.Checked = false;

            Month1RadioButton.Enabled = false;
            Month3RadioButton.Enabled = false;
            Month6RadioButton.Enabled = false;
            Month12RadioButton.Enabled = false;





        }

        private void ProceedButton_Click(object sender, EventArgs e)
        {



            bool CheckThatARadioButtonIsSelected = false;
            foreach (RadioButton Radio in InvestmentTermsGB.Controls.OfType<RadioButton>())
            {
                if (Radio.Checked)
                {
                    CheckThatARadioButtonIsSelected = true;
                    break;


                }
            }
            if (CheckThatARadioButtonIsSelected)
            {
                UserDetailsGB.Enabled = true;
                ConfirmButton.Enabled = true;


                Month1RadioButton.Enabled = false;
                Month3RadioButton.Enabled = false;
                Month6RadioButton.Enabled = false;
                Month12RadioButton.Enabled = false;

                if ((InvestAmountTextBox.TextLength>=7) && (Month6RadioButton.Checked||Month12RadioButton.Checked))
                {
                    MessageBox.Show("Congrats you won an extra 5k");
                }

                if (Month1RadioButton.Checked)
                {
                    AllInvestments += Month1InterestWithPrincipal;
                    value = (Month1InterestWithPrincipal).ToString("F");
                    AvgMonths= TERM_1.ToString();


                }
                else if (Month3RadioButton.Checked)
                {
                    AllInvestments += Month3InterestWithPrincipal;
                    value = (Month3InterestWithPrincipal).ToString("F");
                    AvgMonths= TERM_3.ToString();

                }
                else if (Month6RadioButton.Checked)
                {
                    AllInvestments += Month6InterestWithPrincipal;
                    value = (Month6InterestWithPrincipal).ToString("F");
                    AvgMonths= TERM_6.ToString();
                    

                }
                else if (Month12RadioButton.Checked)
                {
                    AllInvestments += Month12InterestWithPrincipal;
                    value = (Month12InterestWithPrincipal).ToString("F");
                    AvgMonths = TERM_12.ToString();

                }
            }
            else
            {
                MessageBox.Show("Please Select a term "); 
            }

            

              

            



        }

       

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            string Str = TransactionNumberTextBox.Text;  
            double Num;
            bool isNum = double.TryParse(Str, out Num);

            string Str2 = PhoneNumberTextBox.Text;
            double Num2;
            bool isNum2 = double.TryParse(Str2, out Num2);

            if  (isNum)
            {
                if (NameTextBox.Text != "")
                {
                    if (isNum2)
                    {
                        if (EmailTextBox.Text !="")
                        {
                            

                            Message = ("Details of your transaction below\n" +
                            "Transaction id: " + TransactionNumberTextBox.Text + "\n" +
                           "Name: " + NameTextBox.Text + "\n" +
                           "Phone Number: " + PhoneNumberTextBox.Text + "\n" +
                           "Email: " + EmailTextBox.Text + "\n" + "Principal+interest: " + 
                            value+ "\n"+
                           "If the details above are correct and you wish to proceed click OK ");
                            Heading = "Confirmation";
                            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
                            MessageBoxIcon messageIcon = MessageBoxIcon.Question;
                            DialogResult result;
                            result = MessageBox.Show(Message, Heading, buttons, messageIcon);
                            if (result == DialogResult.OK)
                            {
                                FileWriter();

                                MessageBox.Show("Clients details have been saved ", "Details Saved", MessageBoxButtons.OK);

                                TransCount += TransactionNumberTextBox.Text + "\n";
                                InvestedAmount += decimal.Parse(InvestAmountTextBox.Text);
                                NumberOfTransactions++;

                                SummaryGB.Visible = true;
                                SummaryButton.Visible = true;
                                



                            }




                        }
                        else
                        {
                            MessageBox.Show("Please enter your email address");
                            EmailTextBox.Focus();
                            EmailTextBox.SelectAll();

                        }

                    }
                    else
                    {
                        MessageBox.Show("Please enter a phone number, Only numeric Input accepted");
                        PhoneNumberTextBox.Focus();
                        PhoneNumberTextBox.SelectAll();

                    }
                }
                else
                {
                    MessageBox.Show("Please enter your name");
                    NameTextBox.Focus();
                    NameTextBox.SelectAll();

                }
            }
            else
            {
                MessageBox.Show("Please enter a SIX digit unique key");
                TransactionNumberTextBox.Focus();
                TransactionNumberTextBox.SelectAll();
            }


            

            
        }

        private void SummaryButton_Click(object sender, EventArgs e)
        {
            //DisplayTransNumberLabel.Text = TransCount;
            //AccuringInterest=AllInvestments - InvestedAmount;

            //TotalAmountInvestedLabel.Text = InvestedAmount.ToString("C");
            //TotalInterestAccruedLabel.Text = AccuringInterest.ToString("C");
            //AvgTermOfInvestementLabel.Text = (TotalTermsInvested / NumberOfTransactions).ToString();



           
            string line;

            
            

            // Read the file and display it line by line.  
            //System.IO.StreamReader file = new System.IO.StreamReader("Investorslist.txt");
            using (StreamReader sr = File.OpenText("Investorslist.txt"))
            {
                while ((line = sr.ReadLine()) != null)
                {
                    //label10.Text += (line)+"\n";

                    //DisplayTransNumber.Text = GetFirstFromSplit(line, ',');


                    //System.Console.WriteLine(line);
                    //counter++;


                    //DisplayTransNumber.Text = GetFirstFromSplit(line, ',') + "\n";
                    /*
                     
                    */
                    
                    if (line != "")
                    {

                        Result3 = line.Split(',').FirstOrDefault();
                        de += (Result3) + "\n";
                        




                        Result = line.Split(',').Skip(5).FirstOrDefault();
                        RawSum += decimal.Parse(Result);
                        


                        Result2 = line.Split(',').Skip(6).FirstOrDefault();
                        RawInvestment += decimal.Parse(Result2);
                        

                        Result4 = line.Split(',').Skip(4).FirstOrDefault();
                        RawMonths += int.Parse(Result4);
                        count++;
                    }
                    
                    //AvgTermOfInvestementLabel.Text = (RawMonths).ToString();
                    





                }

            }

            DisplayTransNumber.Text = de;
            TotalAmountInvestedLabel.Text = RawSum.ToString("C2");
            TotalInterestAccruedLabel.Text = (RawInvestment - RawSum).ToString("C2");
            AvgTermOfInvestementLabel.Text = (RawMonths/count).ToString("F");




            //System.Console.WriteLine("There were {0} lines.", counter);
            // Suspend the screen.  
            //System.Console.ReadLine();








            /*        
            string line;
             string cat="";

             //StreamWriter outputFile = new StreamWriter("FoundTransactions.txt", true);
             using (StreamReader outputFile = new StreamReader("Investorslist.txt"))
             {
                




                while ((line = outputFile.ReadLine()) != null)
                 {
                    //cat += line.Split(',');
                    foreach (string Str in line)
                    {
                        if (MessageContents.Contains(course))
                            Display_Course.Text = course;



                    }

                } 
             }   */











        }

        public void FileWriter()//method created to handle file writes
        {
            StreamWriter outputFile = new StreamWriter("Investorslist.txt", true);
            outputFile.WriteLine(TransactionNumberTextBox.Text + ", " + NameTextBox.Text +
                ", " + PhoneNumberTextBox.Text + ", " + EmailTextBox.Text +","+AvgMonths+","
                +InvestAmountTextBox.Text+","+value+"\n");
            outputFile.Close();

        }

        public double CalculateInterest(decimal principal,  decimal rate, decimal term)
        {
            // principal((1 + (rate/100)/term )^term);
            Amount =(double) principal * (Math.Pow(1 + (double)rate/100, (double)term) );
            return Amount;
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        

        public void FindMyTransactions(string SearchQuery)
        {
           // string stt = "55545";
            string line;
            StreamWriter outputFile = new StreamWriter("FoundTransactions.txt", true);
            using (StreamReader File=new StreamReader("Investorslist.txt"))
            {
                while((line=File.ReadLine()) != null)
                {
                    /*
                    int stratindex = 0;
                    line.IndexOf(',')
                    String tn = line.Substring()
                    */

                    if (line.Contains(SearchQuery))
                    {
                        outputFile.WriteLine(line);
                        MessageBox.Show("Transaction FOund");
                    }
                    else
                    {
                        MessageBox.Show("Search didn't return any result");
                        break;
                    }
                    
                }
            }
            outputFile.Close();







            /*StreamReader InputFile;
           StreamWriter FoundTransac = new StreamWriter("FoundTransactions.txt");
           InputFile = File.OpenText ("Investorslist.txt");

           while (InputFile.EndOfStream == false)
           {
               string Line= InputFile.ReadLine();
               if (Line.Contains(stt))
               {
                   FoundTransac.WriteLine(Line);
                   break;

               }


           }
            */
        }
        /*
        public string GetSubstring(string input, int count, char delimiter)
        {
            return string.Join(delimiter.ToString(),
                               input.Split(delimiter).Take(count));
        }  */


        public string GetFirstFromSplit(string input, char delimiter)
        {
            var i = input.IndexOf(delimiter);

            return i == -1 ? input : input.Substring(0, i);
        }
    }



    

}
