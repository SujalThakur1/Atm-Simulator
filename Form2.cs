using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using ATM;
using System.Media;
namespace ATM
{
    // The main form representing the ATM interface
    public partial class Atm : Form
    {
        private SoundPlayer OnClickSound; // SoundPlayer object to play button click sound
        private Account activeAccount; // Currently active account
        private AtmSimulator simulator; // ATM simulator object
        private bool raceCondition; // Flag indicating whether to simulate a race condition
        private static Mutex mutex = new Mutex(); // Mutex for thread synchronization

        public Atm(AtmSimulator simulator,bool raceCondition)
        {
            this.simulator = simulator;
            this.raceCondition = raceCondition;
            InitializeComponent();
            OnClickSound = new SoundPlayer();
            OnClickSound.SoundLocation = "ButtonClick.wav";
        }

        
        private void lblATMAccount_Click(object sender, EventArgs e)
        {

        }

        private void tbxAccountNumber_TextChanged(object sender, EventArgs e)
        {

        }

        // Event handler for submitting account number and PIN
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // Initialize variables
            int input;
            int userPin;

            lblErrorMsg.Visible = false;// Hide error message label
            PlayButtonClickSound();

            // Get user input for account number and PIN
            string userAccount = tbxAccountNumber.Text;
            string pinInput = tbxPin.Text;

            // Check if either account number or PIN is empty
            if (string.IsNullOrWhiteSpace(userAccount) || string.IsNullOrWhiteSpace(pinInput))
            {
                lblErrorMsg.Text = "Enter both account number and PIN.";
                lblErrorMsg.Visible = true;
                return;
            }

            // Check if account number is a valid integer
            if (!int.TryParse(userAccount, out input))
            {
                lblErrorMsg.Text = "*** Invalid Account number. ***";
                lblErrorMsg.Visible = true;
                return;
            }

            // Check if PIN is a valid integer
            if (!int.TryParse(pinInput, out userPin))
            {
                lblErrorMsg.Text = "*** Please enter a valid PIN. ***";
                lblErrorMsg.Visible = true;
                return;
            }

            // Find the account using the input account number
            activeAccount = simulator.findAccount(input);

            if (activeAccount != null)
            {
                // Check if PIN matches
                if (activeAccount.checkPin(userPin))
                {
                    pnlAccountAndPin.Visible = false;
                    pnlDisplayOptions.Visible = true;
                }
                else
                {
                    lblErrorMsg.Text = "*** Incorrect PIN. ***";
                    lblErrorMsg.Visible = true;
                    return;
                }
            }
            else
            {
                lblErrorMsg.Text = "*** Account not found. ***";
                lblErrorMsg.Visible = true;
                return;
            }

        }

        // Event handler for clicking the return card button
        private async void btnReturnCard_Click(object sender, EventArgs e)
        {
            PlayButtonClickSound();
            pnlReturning.Visible = true;
            pnlDisplayOptions.Visible = false;
            await Task.Delay(1000);
            lblReturning.Text = "GoodBye";
            await Task.Delay(1000);
            this.Close();
        }

        // Event handler for clicking the check balance button
        private void btnCheckBalance_Click(object sender, EventArgs e)
        {
            PlayButtonClickSound();
            lblBalance.Text = "Your Balance is £" + activeAccount.getBalance();
            pnlBalance.Visible = true;
            pnlDisplayOptions.Visible = false;
        }

        // Event handler for clicking the withdraw button
        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            PlayButtonClickSound();
            pnlWithdrawSelection.Visible = true;
            pnlDisplayOptions.Visible = false;
        }

        // Event handler for clicking the back button in balance display
        private void btnBackBalance_Click(object sender, EventArgs e)
        {
            PlayButtonClickSound();
            pnlDisplayOptions.Visible = true;
            pnlBalance.Visible = false;
        }

        // Event handler for clicking the back button in withdrawal selection
        private void btnBackWithdraw_Click(object sender, EventArgs e)
        {
            PlayButtonClickSound();
            pnlDisplayOptions.Visible = true;
            pnlWithdrawSelection.Visible = false;
        }

        // Method to deduct balance asynchronously
        private async void deductBalance(int amount)
        {
            await Task.Delay(2000);
            if (raceCondition)// Check for race condition
            {
                // Deduct balance and update UI
                if (activeAccount.decrementBalance(amount))
                {
                    int balance = activeAccount.getBalance();
                    balance = balance - amount;
                    await Task.Delay(2000);
                    activeAccount.setBalance(balance);
                    lblWithdrawingAmount.Text = "£" + amount + " successfully withdrawn\n New Balance = £" + activeAccount.getBalance();
                }
                else
                {
                    lblWithdrawingAmount.Text = "Apologies, there are insufficient funds available in your account";
                }
                btnBackWithdrawingMoney.Visible = true;
            }
            else
            {
                // Use mutex for thread synchronization
                mutex.WaitOne();
                try
                {
                     if (activeAccount.decrementBalance(amount))
                {
                    int balance = activeAccount.getBalance();
                    balance = balance - amount;
                    await Task.Delay(2000);
                    activeAccount.setBalance(balance);
                    lblWithdrawingAmount.Text = "£" + amount +" successfully withdrawn\n New Balance = £" + activeAccount.getBalance();
                }
                else
                {
                    lblWithdrawingAmount.Text = "Apologies, there are insufficient funds available in your account";
                }
                btnBackWithdrawingMoney.Visible = true;
                }
                finally
                {
                    mutex.ReleaseMutex();
                }
            }
        }

        // Event handler for clicking the £10 withdrawal button
        private void btn10Pound_Click(object sender, EventArgs e)
        {
            PlayButtonClickSound();
            btnBackWithdrawingMoney.Visible = false;

            lblWithdrawingAmount.Size = new Size(605, 56);
            lblWithdrawingAmount.Text = "Withdrawing £10......";
            pnlWithdrawingMoney.Visible = true;
            pnlWithdrawSelection.Visible = false;
            lblWithdrawingAmount.Size = new Size(605, 110);
            deductBalance(10);
        }

        // Event handler for clicking the £20 withdrawal button
        private void btn20Pound_Click(object sender, EventArgs e)
        {
            PlayButtonClickSound();

            btnBackWithdrawingMoney.Visible = false;
            lblWithdrawingAmount.Size = new Size(605, 56);
            lblWithdrawingAmount.Text = "Withdrawing £20......";
            pnlWithdrawingMoney.Visible = true;
            pnlWithdrawSelection.Visible = false;
            lblWithdrawingAmount.Size = new Size(605, 110);
            deductBalance(20);
        }

        // Event handler for clicking the £50 withdrawal button
        private void btn50Pound_Click(object sender, EventArgs e)
        {
            PlayButtonClickSound();
            btnBackWithdrawingMoney.Visible = false;
            lblWithdrawingAmount.Size = new Size(605, 56);
            lblWithdrawingAmount.Text = "Withdrawing £50......";
            pnlWithdrawingMoney.Visible = true;
            pnlWithdrawSelection.Visible = false;
            lblWithdrawingAmount.Size = new Size(605, 110);
            deductBalance(50);
        }

        // Event handler for clicking the £100 withdrawal button
        private void btn100Pound_Click(object sender, EventArgs e)
        {
            PlayButtonClickSound();
            btnBackWithdrawingMoney.Visible = false;
            lblWithdrawingAmount.Size = new Size(605, 56);
            lblWithdrawingAmount.Text = "Withdrawing £100......";
            pnlWithdrawingMoney.Visible = true;
            pnlWithdrawSelection.Visible = false;
            lblWithdrawingAmount.Size = new Size(605, 110);
            deductBalance(100);
        }

        // Event handler for clicking the £200 withdrawal button
        private void btn200Pound_Click(object sender, EventArgs e)
        {
            PlayButtonClickSound();
            btnBackWithdrawingMoney.Visible = false;
            lblWithdrawingAmount.Size = new Size(605, 56);
            lblWithdrawingAmount.Text = "Withdrawing £200......";
            pnlWithdrawingMoney.Visible = true;
            pnlWithdrawSelection.Visible = false;
            lblWithdrawingAmount.Size = new Size(605, 110);
            deductBalance(200);
        }

        // Event handler for clicking the £500 withdrawal button
        private void btn500Pound_Click(object sender, EventArgs e)
        {
            PlayButtonClickSound();
            btnBackWithdrawingMoney.Visible = false;
            lblWithdrawingAmount.Size = new Size(605, 56);
            lblWithdrawingAmount.Text = "Withdrawing £500......";
            pnlWithdrawingMoney.Visible = true;
            pnlWithdrawSelection.Visible = false;
            lblWithdrawingAmount.Size = new Size(605, 110);
            deductBalance(500);
        }

        // Event handler for clicking the back button in withdrawal process
        private void btnBackWithdrawingMoney_Click(object sender, EventArgs e)
        {
            PlayButtonClickSound();
            pnlWithdrawingMoney.Visible = false;
            pnlDisplayOptions.Visible = true;
        }
        private void PlayButtonClickSound()
        {
            OnClickSound.Play();
        }

        // Event handler for clicking the deposit button
        private void btnDeposit_Click(object sender, EventArgs e)
        {
            PlayButtonClickSound();
            pnlDisplayOptions.Visible = false;
            pnlDepositMoney.Visible = true;
            
        }

        // Event handler for clicking the back button in deposit process
        private void btnBackDeposit_Click(object sender, EventArgs e)
        {
            PlayButtonClickSound(); 
            pnlDepositMoney.Visible = false;
            pnlDisplayOptions.Visible = true;

        }

        // Handles the click event for the "Proceed" button in the deposit panel
        private async void btnProceed_Click(object sender, EventArgs e)
        {
            lblErrorInDeposit.Visible = false;

            // Check if the deposit amount textbox is not empty
            if (!String.IsNullOrEmpty(textBoxDesposit.Text))
            {
                int input;

                // Attempt to parse the input as an integer
                if (int.TryParse(textBoxDesposit.Text, out input))
                {
                    // Check if the input is greater than or equal to the minimum deposit amount
                    if (input >= 10)
                    {
                        PlayButtonClickSound();
                        lblWithdrawingAmount.Size = new Size(605, 56);
                        lblWithdrawingAmount.Text = "Counting Money";
                        pnlWithdrawingMoney.Visible = true;
                        pnlDepositMoney.Visible = false;
                        textBoxDesposit.Text = "";
                        btnBackWithdrawingMoney.Visible = false;
                        await Task.Delay(2000);

                        // Check if the input exceeds the maximum deposit amount
                        if (input > 1000)
                        {
                            lblWithdrawingAmount.Text = "Sorry, the maximum deposit amount is £1000.";
                            btnBackWithdrawingMoney.Visible = true;
                            lblWithdrawingAmount.Size = new Size(605, 110);
                            return;
                        }
                        if(input % 10 != 0)
                        {
                            lblWithdrawingAmount.Text = "Sorry, only 10, 20, and 50 pounds notes are accepted.";
                            btnBackWithdrawingMoney.Visible = true;
                            lblWithdrawingAmount.Size = new Size(605, 110);
                            return;
                        }

                        // Deposit the money into the account
                        if (raceCondition)
                        {
                            int balance = activeAccount.getBalance();
                            balance = balance + input;
                            await Task.Delay(2000);
                            activeAccount.setBalance(balance);
                        }
                        else
                        {
                            mutex.WaitOne();
                            try
                            {
                                int balance = activeAccount.getBalance();
                                balance = balance + input;
                                await Task.Delay(2000);
                                activeAccount.setBalance(balance);
                            }
                            finally
                            {
                                mutex.ReleaseMutex();
                            }
                        }

                        // Update UI to show successful deposit and new balance
                        lblWithdrawingAmount.Text = "£" + input + " deposited.\n New Balance = £" + activeAccount.getBalance();
                        btnBackWithdrawingMoney.Visible = true;
                        lblWithdrawingAmount.Size = new Size(605, 110);
                    }
                    else
                    {
                        // Show error message for minimum deposit amount
                        lblErrorInDeposit.Text = "Minimum Deposit is £10";
                        lblErrorInDeposit.Visible = true;
                        lblWithdrawingAmount.Size = new Size(605, 110);
                    }
                }
                else
                {
                    // Show error message for invalid input format
                    lblErrorInDeposit.Text = "Invalid Amount";
                    lblErrorInDeposit.Visible = true;
                    lblWithdrawingAmount.Size = new Size(605, 110);
                }
            }
            else
            {
                // Show error message for empty input
                lblErrorInDeposit.Text = "Please Enter the Amount";
                lblErrorInDeposit.Visible = true;
                lblWithdrawingAmount.Size = new Size(605, 110);
            }
        }
    }
}