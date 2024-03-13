using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM
{
    public partial class ATMModeSelection : Form
    {
        private SoundPlayer OnClickSound;// SoundPlayer object to play button click sound
        public ATMModeSelection()
        {
            InitializeComponent();
            // Initialize the SoundPlayer object with the sound file location
            OnClickSound = new SoundPlayer();
            OnClickSound.SoundLocation = "ButtonClick.wav";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            PlayButtonClickSound();// Play button click sound
            this.Close();//Close the form
        }

        private void btnSimulateNoRaceCondition_Click(object sender, EventArgs e)
        {
            PlayButtonClickSound(); // Play button click sound
            runningThreads(false); // Start running ATM simulations without race condition
        }

        private void btnSimulateRace_Click(object sender, EventArgs e)
        {
            PlayButtonClickSound();
            runningThreads(true);// Start running ATM simulations with race condition

        }

        // Method to start multiple threads for ATM simulations
        private void runningThreads(bool raceCondition)
        {
            AtmSimulator atmSimulator = new AtmSimulator();
            Account[] ac = atmSimulator.GetAccounts();

            // Define ThreadStart delegates for each thread
            ThreadStart FormStart_t1 = new ThreadStart(() =>
            {
                Application.Run(new Atm(atmSimulator,raceCondition));
            });

            ThreadStart FormStart_t2 = new ThreadStart(() =>
            {
                Application.Run(new Atm(atmSimulator, raceCondition));
            });

            ThreadStart FormStart_t3 = new ThreadStart(() =>
            {
                Application.Run(new Atm(atmSimulator, raceCondition));
            });

            ThreadStart FormStart_t4 = new ThreadStart(() =>
            {
                Application.Run(new Atm(atmSimulator, raceCondition));
            });

            // Create threads for each FormStart delegate
            Thread Form1_t = new Thread(FormStart_t1);
            Thread Form2_t = new Thread(FormStart_t2);
            Thread Form3_t = new Thread(FormStart_t3);
            Thread Form4_t = new Thread(FormStart_t4);

            // Start each thread
            Form1_t.Start();
            Form2_t.Start();
            Form3_t.Start();
            Form4_t.Start();

            // Close the current form
            this.Close();
        }

        // Method to play button click sound
        private void PlayButtonClickSound()
        {
            OnClickSound.Play();
        }
    }

    // Class representing ATM simulation
    public class AtmSimulator
    {
        private Account[] ac = new Account[3]; // Array to hold accounts

        public AtmSimulator()
        {
            // Initialize accounts with balances, PINs, and account numbers
            ac[0] = new Account(300, 1111, 111111);
            ac[1] = new Account(750, 2222, 222222);
            ac[2] = new Account(3000, 3333, 333333);
        }
        public Account[] GetAccounts()
        {
            return ac;
        }

        // Method to find an account by account number
        public Account findAccount(int input)
        {
            Console.WriteLine("enter your account number..");

            for (int i = 0; i < this.ac.Length; i++)
            {
                if (ac[i].getAccountNum() == input)
                {
                    return ac[i];
                }
            }

            return null;
        }
    }

    // Class representing a bank account
    public class Account
    {
        private int balance;
        private int pin;
        private int accountNum;

        public Account(int balance, int pin, int accountNum)
        {
            this.balance = balance;
            this.pin = pin;
            this.accountNum = accountNum;
        }

        public int getBalance()
        {
            return balance;
        }
        public void setBalance(int newBalance)
        {
            this.balance = newBalance;
        }
        public Boolean decrementBalance(int amount)
        {
            if (balance >= amount)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Boolean checkPin(int pinEntered)
        {
            if (pinEntered == pin)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public int getAccountNum()
        {
            return accountNum;
        }
        

    }
}
