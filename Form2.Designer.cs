namespace ATM
{
    partial class Atm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Atm));
            this.lblHeading = new System.Windows.Forms.Label();
            this.lblATMAccount = new System.Windows.Forms.Label();
            this.tbxAccountNumber = new System.Windows.Forms.TextBox();
            this.lblPin = new System.Windows.Forms.Label();
            this.tbxPin = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.pnlAccountAndPin = new System.Windows.Forms.Panel();
            this.lblErrorMsg = new System.Windows.Forms.Label();
            this.pnlReturning = new System.Windows.Forms.Panel();
            this.lblReturning = new System.Windows.Forms.Label();
            this.pnlDisplayOptions = new System.Windows.Forms.Panel();
            this.btnDeposit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnWithdraw = new System.Windows.Forms.Button();
            this.btnReturnCard = new System.Windows.Forms.Button();
            this.btnCheckBalance = new System.Windows.Forms.Button();
            this.pnlBalance = new System.Windows.Forms.Panel();
            this.lblBalance = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBackBalance = new System.Windows.Forms.Button();
            this.pnlWithdrawSelection = new System.Windows.Forms.Panel();
            this.btn500Pound = new System.Windows.Forms.Button();
            this.btn200Pound = new System.Windows.Forms.Button();
            this.btn50Pound = new System.Windows.Forms.Button();
            this.btn100Pound = new System.Windows.Forms.Button();
            this.btn20Pound = new System.Windows.Forms.Button();
            this.btn10Pound = new System.Windows.Forms.Button();
            this.btnBackWithdraw = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlWithdrawingMoney = new System.Windows.Forms.Panel();
            this.btnBackWithdrawingMoney = new System.Windows.Forms.Button();
            this.lblWithdrawingAmount = new System.Windows.Forms.Label();
            this.pnlDepositMoney = new System.Windows.Forms.Panel();
            this.lblErrorInDeposit = new System.Windows.Forms.Label();
            this.btnProceed = new System.Windows.Forms.Button();
            this.btnBackDeposit = new System.Windows.Forms.Button();
            this.textBoxDesposit = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pnlAccountAndPin.SuspendLayout();
            this.pnlReturning.SuspendLayout();
            this.pnlDisplayOptions.SuspendLayout();
            this.pnlBalance.SuspendLayout();
            this.pnlWithdrawSelection.SuspendLayout();
            this.pnlWithdrawingMoney.SuspendLayout();
            this.pnlDepositMoney.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblHeading
            // 
            this.lblHeading.BackColor = System.Drawing.Color.Transparent;
            this.lblHeading.Font = new System.Drawing.Font("Courier New", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.ForeColor = System.Drawing.Color.FloralWhite;
            this.lblHeading.Location = new System.Drawing.Point(404, 32);
            this.lblHeading.MaximumSize = new System.Drawing.Size(200, 199);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(196, 94);
            this.lblHeading.TabIndex = 2;
            this.lblHeading.Text = "ATMSimulator";
            this.lblHeading.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblATMAccount
            // 
            this.lblATMAccount.BackColor = System.Drawing.Color.DimGray;
            this.lblATMAccount.Font = new System.Drawing.Font("Courier New", 27F, System.Drawing.FontStyle.Bold);
            this.lblATMAccount.ForeColor = System.Drawing.Color.FloralWhite;
            this.lblATMAccount.Location = new System.Drawing.Point(25, 10);
            this.lblATMAccount.Name = "lblATMAccount";
            this.lblATMAccount.Size = new System.Drawing.Size(913, 59);
            this.lblATMAccount.TabIndex = 3;
            this.lblATMAccount.Text = "Please Enter Your Account Number";
            this.lblATMAccount.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblATMAccount.Click += new System.EventHandler(this.lblATMAccount_Click);
            // 
            // tbxAccountNumber
            // 
            this.tbxAccountNumber.Font = new System.Drawing.Font("Courier New", 30F, System.Drawing.FontStyle.Bold);
            this.tbxAccountNumber.Location = new System.Drawing.Point(233, 90);
            this.tbxAccountNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxAccountNumber.Name = "tbxAccountNumber";
            this.tbxAccountNumber.Size = new System.Drawing.Size(465, 64);
            this.tbxAccountNumber.TabIndex = 4;
            this.tbxAccountNumber.TextChanged += new System.EventHandler(this.tbxAccountNumber_TextChanged);
            // 
            // lblPin
            // 
            this.lblPin.BackColor = System.Drawing.Color.DimGray;
            this.lblPin.Font = new System.Drawing.Font("Courier New", 27F, System.Drawing.FontStyle.Bold);
            this.lblPin.ForeColor = System.Drawing.Color.FloralWhite;
            this.lblPin.Location = new System.Drawing.Point(25, 180);
            this.lblPin.Name = "lblPin";
            this.lblPin.Size = new System.Drawing.Size(911, 59);
            this.lblPin.TabIndex = 5;
            this.lblPin.Text = "Please Enter Your PIN";
            this.lblPin.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tbxPin
            // 
            this.tbxPin.Font = new System.Drawing.Font("Courier New", 30F, System.Drawing.FontStyle.Bold);
            this.tbxPin.Location = new System.Drawing.Point(233, 260);
            this.tbxPin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxPin.Name = "tbxPin";
            this.tbxPin.PasswordChar = '*';
            this.tbxPin.Size = new System.Drawing.Size(465, 64);
            this.tbxPin.TabIndex = 6;
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.DimGray;
            this.btnSubmit.Font = new System.Drawing.Font("Courier New", 27F, System.Drawing.FontStyle.Bold);
            this.btnSubmit.ForeColor = System.Drawing.Color.Snow;
            this.btnSubmit.Location = new System.Drawing.Point(361, 399);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(216, 66);
            this.btnSubmit.TabIndex = 7;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // pnlAccountAndPin
            // 
            this.pnlAccountAndPin.BackColor = System.Drawing.Color.Transparent;
            this.pnlAccountAndPin.Controls.Add(this.lblErrorMsg);
            this.pnlAccountAndPin.Controls.Add(this.tbxAccountNumber);
            this.pnlAccountAndPin.Controls.Add(this.lblATMAccount);
            this.pnlAccountAndPin.Controls.Add(this.btnSubmit);
            this.pnlAccountAndPin.Controls.Add(this.lblPin);
            this.pnlAccountAndPin.Controls.Add(this.tbxPin);
            this.pnlAccountAndPin.Location = new System.Drawing.Point(31, 134);
            this.pnlAccountAndPin.Margin = new System.Windows.Forms.Padding(4);
            this.pnlAccountAndPin.Name = "pnlAccountAndPin";
            this.pnlAccountAndPin.Size = new System.Drawing.Size(956, 492);
            this.pnlAccountAndPin.TabIndex = 8;
            // 
            // lblErrorMsg
            // 
            this.lblErrorMsg.Font = new System.Drawing.Font("Courier New", 23F, System.Drawing.FontStyle.Bold);
            this.lblErrorMsg.ForeColor = System.Drawing.Color.Red;
            this.lblErrorMsg.Location = new System.Drawing.Point(7, 341);
            this.lblErrorMsg.Name = "lblErrorMsg";
            this.lblErrorMsg.Size = new System.Drawing.Size(929, 47);
            this.lblErrorMsg.TabIndex = 8;
            this.lblErrorMsg.Text = "Enter both account number and PIN. ***";
            this.lblErrorMsg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblErrorMsg.Visible = false;
            // 
            // pnlReturning
            // 
            this.pnlReturning.BackColor = System.Drawing.Color.Transparent;
            this.pnlReturning.Controls.Add(this.lblReturning);
            this.pnlReturning.Location = new System.Drawing.Point(87, 122);
            this.pnlReturning.Margin = new System.Windows.Forms.Padding(4);
            this.pnlReturning.Name = "pnlReturning";
            this.pnlReturning.Size = new System.Drawing.Size(804, 496);
            this.pnlReturning.TabIndex = 10;
            this.pnlReturning.Visible = false;
            // 
            // lblReturning
            // 
            this.lblReturning.BackColor = System.Drawing.Color.DimGray;
            this.lblReturning.Font = new System.Drawing.Font("Courier New", 27F, System.Drawing.FontStyle.Bold);
            this.lblReturning.ForeColor = System.Drawing.Color.FloralWhite;
            this.lblReturning.Location = new System.Drawing.Point(84, 133);
            this.lblReturning.Name = "lblReturning";
            this.lblReturning.Size = new System.Drawing.Size(691, 58);
            this.lblReturning.TabIndex = 4;
            this.lblReturning.Text = "Returning Card.....";
            this.lblReturning.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pnlDisplayOptions
            // 
            this.pnlDisplayOptions.BackColor = System.Drawing.Color.Transparent;
            this.pnlDisplayOptions.Controls.Add(this.btnDeposit);
            this.pnlDisplayOptions.Controls.Add(this.label1);
            this.pnlDisplayOptions.Controls.Add(this.btnWithdraw);
            this.pnlDisplayOptions.Controls.Add(this.btnReturnCard);
            this.pnlDisplayOptions.Controls.Add(this.btnCheckBalance);
            this.pnlDisplayOptions.Location = new System.Drawing.Point(35, 129);
            this.pnlDisplayOptions.Margin = new System.Windows.Forms.Padding(4);
            this.pnlDisplayOptions.Name = "pnlDisplayOptions";
            this.pnlDisplayOptions.Size = new System.Drawing.Size(956, 492);
            this.pnlDisplayOptions.TabIndex = 9;
            this.pnlDisplayOptions.Visible = false;
            // 
            // btnDeposit
            // 
            this.btnDeposit.BackColor = System.Drawing.Color.DimGray;
            this.btnDeposit.Font = new System.Drawing.Font("Courier New", 27F, System.Drawing.FontStyle.Bold);
            this.btnDeposit.ForeColor = System.Drawing.Color.Snow;
            this.btnDeposit.Location = new System.Drawing.Point(251, 220);
            this.btnDeposit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDeposit.Name = "btnDeposit";
            this.btnDeposit.Size = new System.Drawing.Size(421, 66);
            this.btnDeposit.TabIndex = 10;
            this.btnDeposit.Text = "Deposit Money";
            this.btnDeposit.UseVisualStyleBackColor = false;
            this.btnDeposit.Click += new System.EventHandler(this.btnDeposit_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.DimGray;
            this.label1.Font = new System.Drawing.Font("Courier New", 25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FloralWhite;
            this.label1.Location = new System.Drawing.Point(25, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(913, 75);
            this.label1.TabIndex = 3;
            this.label1.Text = "Please choose from the following menu item";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnWithdraw
            // 
            this.btnWithdraw.BackColor = System.Drawing.Color.DimGray;
            this.btnWithdraw.Font = new System.Drawing.Font("Courier New", 27F, System.Drawing.FontStyle.Bold);
            this.btnWithdraw.ForeColor = System.Drawing.Color.Snow;
            this.btnWithdraw.Location = new System.Drawing.Point(251, 140);
            this.btnWithdraw.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnWithdraw.Name = "btnWithdraw";
            this.btnWithdraw.Size = new System.Drawing.Size(421, 66);
            this.btnWithdraw.TabIndex = 9;
            this.btnWithdraw.Text = "Withdraw Money";
            this.btnWithdraw.UseVisualStyleBackColor = false;
            this.btnWithdraw.Click += new System.EventHandler(this.btnWithdraw_Click);
            // 
            // btnReturnCard
            // 
            this.btnReturnCard.BackColor = System.Drawing.Color.DimGray;
            this.btnReturnCard.Font = new System.Drawing.Font("Courier New", 27F, System.Drawing.FontStyle.Bold);
            this.btnReturnCard.ForeColor = System.Drawing.Color.Snow;
            this.btnReturnCard.Location = new System.Drawing.Point(251, 382);
            this.btnReturnCard.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReturnCard.Name = "btnReturnCard";
            this.btnReturnCard.Size = new System.Drawing.Size(421, 66);
            this.btnReturnCard.TabIndex = 8;
            this.btnReturnCard.Text = "Return Card";
            this.btnReturnCard.UseVisualStyleBackColor = false;
            this.btnReturnCard.Click += new System.EventHandler(this.btnReturnCard_Click);
            // 
            // btnCheckBalance
            // 
            this.btnCheckBalance.BackColor = System.Drawing.Color.DimGray;
            this.btnCheckBalance.Font = new System.Drawing.Font("Courier New", 27F, System.Drawing.FontStyle.Bold);
            this.btnCheckBalance.ForeColor = System.Drawing.Color.Snow;
            this.btnCheckBalance.Location = new System.Drawing.Point(251, 300);
            this.btnCheckBalance.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCheckBalance.Name = "btnCheckBalance";
            this.btnCheckBalance.Size = new System.Drawing.Size(421, 66);
            this.btnCheckBalance.TabIndex = 7;
            this.btnCheckBalance.Text = "Check Balance";
            this.btnCheckBalance.UseVisualStyleBackColor = false;
            this.btnCheckBalance.Click += new System.EventHandler(this.btnCheckBalance_Click);
            // 
            // pnlBalance
            // 
            this.pnlBalance.BackColor = System.Drawing.Color.Transparent;
            this.pnlBalance.Controls.Add(this.lblBalance);
            this.pnlBalance.Controls.Add(this.label2);
            this.pnlBalance.Controls.Add(this.btnBackBalance);
            this.pnlBalance.Location = new System.Drawing.Point(155, 122);
            this.pnlBalance.Margin = new System.Windows.Forms.Padding(4);
            this.pnlBalance.Name = "pnlBalance";
            this.pnlBalance.Size = new System.Drawing.Size(760, 438);
            this.pnlBalance.TabIndex = 11;
            this.pnlBalance.Visible = false;
            // 
            // lblBalance
            // 
            this.lblBalance.BackColor = System.Drawing.Color.DimGray;
            this.lblBalance.Font = new System.Drawing.Font("Courier New", 27F, System.Drawing.FontStyle.Bold);
            this.lblBalance.ForeColor = System.Drawing.Color.FloralWhite;
            this.lblBalance.Location = new System.Drawing.Point(100, 145);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(485, 102);
            this.lblBalance.TabIndex = 11;
            this.lblBalance.Text = "Your Balance is £10000";
            this.lblBalance.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.DimGray;
            this.label2.Font = new System.Drawing.Font("Courier New", 27F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FloralWhite;
            this.label2.Location = new System.Drawing.Point(121, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(459, 58);
            this.label2.TabIndex = 10;
            this.label2.Text = "Balance";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnBackBalance
            // 
            this.btnBackBalance.BackColor = System.Drawing.Color.DimGray;
            this.btnBackBalance.Font = new System.Drawing.Font("Courier New", 27F, System.Drawing.FontStyle.Bold);
            this.btnBackBalance.ForeColor = System.Drawing.Color.Snow;
            this.btnBackBalance.Location = new System.Drawing.Point(237, 318);
            this.btnBackBalance.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBackBalance.Name = "btnBackBalance";
            this.btnBackBalance.Size = new System.Drawing.Size(208, 66);
            this.btnBackBalance.TabIndex = 9;
            this.btnBackBalance.Text = "Back";
            this.btnBackBalance.UseVisualStyleBackColor = false;
            this.btnBackBalance.Click += new System.EventHandler(this.btnBackBalance_Click);
            // 
            // pnlWithdrawSelection
            // 
            this.pnlWithdrawSelection.BackColor = System.Drawing.Color.Transparent;
            this.pnlWithdrawSelection.Controls.Add(this.btn500Pound);
            this.pnlWithdrawSelection.Controls.Add(this.btn200Pound);
            this.pnlWithdrawSelection.Controls.Add(this.btn50Pound);
            this.pnlWithdrawSelection.Controls.Add(this.btn100Pound);
            this.pnlWithdrawSelection.Controls.Add(this.btn20Pound);
            this.pnlWithdrawSelection.Controls.Add(this.btn10Pound);
            this.pnlWithdrawSelection.Controls.Add(this.btnBackWithdraw);
            this.pnlWithdrawSelection.Controls.Add(this.label3);
            this.pnlWithdrawSelection.Location = new System.Drawing.Point(69, 122);
            this.pnlWithdrawSelection.Margin = new System.Windows.Forms.Padding(4);
            this.pnlWithdrawSelection.Name = "pnlWithdrawSelection";
            this.pnlWithdrawSelection.Size = new System.Drawing.Size(897, 505);
            this.pnlWithdrawSelection.TabIndex = 12;
            this.pnlWithdrawSelection.Visible = false;
            // 
            // btn500Pound
            // 
            this.btn500Pound.BackColor = System.Drawing.Color.DimGray;
            this.btn500Pound.Font = new System.Drawing.Font("Courier New", 27F, System.Drawing.FontStyle.Bold);
            this.btn500Pound.ForeColor = System.Drawing.Color.Snow;
            this.btn500Pound.Location = new System.Drawing.Point(584, 318);
            this.btn500Pound.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn500Pound.Name = "btn500Pound";
            this.btn500Pound.Size = new System.Drawing.Size(208, 66);
            this.btn500Pound.TabIndex = 19;
            this.btn500Pound.Text = "£500";
            this.btn500Pound.UseVisualStyleBackColor = false;
            this.btn500Pound.Click += new System.EventHandler(this.btn500Pound_Click);
            // 
            // btn200Pound
            // 
            this.btn200Pound.BackColor = System.Drawing.Color.DimGray;
            this.btn200Pound.Font = new System.Drawing.Font("Courier New", 27F, System.Drawing.FontStyle.Bold);
            this.btn200Pound.ForeColor = System.Drawing.Color.Snow;
            this.btn200Pound.Location = new System.Drawing.Point(584, 225);
            this.btn200Pound.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn200Pound.Name = "btn200Pound";
            this.btn200Pound.Size = new System.Drawing.Size(208, 66);
            this.btn200Pound.TabIndex = 18;
            this.btn200Pound.Text = "£200";
            this.btn200Pound.UseVisualStyleBackColor = false;
            this.btn200Pound.Click += new System.EventHandler(this.btn200Pound_Click);
            // 
            // btn50Pound
            // 
            this.btn50Pound.BackColor = System.Drawing.Color.DimGray;
            this.btn50Pound.Font = new System.Drawing.Font("Courier New", 27F, System.Drawing.FontStyle.Bold);
            this.btn50Pound.ForeColor = System.Drawing.Color.Snow;
            this.btn50Pound.Location = new System.Drawing.Point(45, 318);
            this.btn50Pound.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn50Pound.Name = "btn50Pound";
            this.btn50Pound.Size = new System.Drawing.Size(208, 66);
            this.btn50Pound.TabIndex = 17;
            this.btn50Pound.Text = "£50";
            this.btn50Pound.UseVisualStyleBackColor = false;
            this.btn50Pound.Click += new System.EventHandler(this.btn50Pound_Click);
            // 
            // btn100Pound
            // 
            this.btn100Pound.BackColor = System.Drawing.Color.DimGray;
            this.btn100Pound.Font = new System.Drawing.Font("Courier New", 27F, System.Drawing.FontStyle.Bold);
            this.btn100Pound.ForeColor = System.Drawing.Color.Snow;
            this.btn100Pound.Location = new System.Drawing.Point(584, 124);
            this.btn100Pound.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn100Pound.Name = "btn100Pound";
            this.btn100Pound.Size = new System.Drawing.Size(208, 66);
            this.btn100Pound.TabIndex = 16;
            this.btn100Pound.Text = "£100";
            this.btn100Pound.UseVisualStyleBackColor = false;
            this.btn100Pound.Click += new System.EventHandler(this.btn100Pound_Click);
            // 
            // btn20Pound
            // 
            this.btn20Pound.BackColor = System.Drawing.Color.DimGray;
            this.btn20Pound.Font = new System.Drawing.Font("Courier New", 27F, System.Drawing.FontStyle.Bold);
            this.btn20Pound.ForeColor = System.Drawing.Color.Snow;
            this.btn20Pound.Location = new System.Drawing.Point(45, 225);
            this.btn20Pound.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn20Pound.Name = "btn20Pound";
            this.btn20Pound.Size = new System.Drawing.Size(208, 66);
            this.btn20Pound.TabIndex = 15;
            this.btn20Pound.Text = "£20";
            this.btn20Pound.UseVisualStyleBackColor = false;
            this.btn20Pound.Click += new System.EventHandler(this.btn20Pound_Click);
            // 
            // btn10Pound
            // 
            this.btn10Pound.BackColor = System.Drawing.Color.DimGray;
            this.btn10Pound.Font = new System.Drawing.Font("Courier New", 27F, System.Drawing.FontStyle.Bold);
            this.btn10Pound.ForeColor = System.Drawing.Color.Snow;
            this.btn10Pound.Location = new System.Drawing.Point(45, 124);
            this.btn10Pound.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn10Pound.Name = "btn10Pound";
            this.btn10Pound.Size = new System.Drawing.Size(208, 66);
            this.btn10Pound.TabIndex = 14;
            this.btn10Pound.Text = "£10";
            this.btn10Pound.UseVisualStyleBackColor = false;
            this.btn10Pound.Click += new System.EventHandler(this.btn10Pound_Click);
            // 
            // btnBackWithdraw
            // 
            this.btnBackWithdraw.BackColor = System.Drawing.Color.DimGray;
            this.btnBackWithdraw.Font = new System.Drawing.Font("Courier New", 27F, System.Drawing.FontStyle.Bold);
            this.btnBackWithdraw.ForeColor = System.Drawing.Color.Snow;
            this.btnBackWithdraw.Location = new System.Drawing.Point(323, 410);
            this.btnBackWithdraw.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBackWithdraw.Name = "btnBackWithdraw";
            this.btnBackWithdraw.Size = new System.Drawing.Size(208, 66);
            this.btnBackWithdraw.TabIndex = 13;
            this.btnBackWithdraw.Text = "Back";
            this.btnBackWithdraw.UseVisualStyleBackColor = false;
            this.btnBackWithdraw.Click += new System.EventHandler(this.btnBackWithdraw_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.DimGray;
            this.label3.Font = new System.Drawing.Font("Courier New", 27F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FloralWhite;
            this.label3.Location = new System.Drawing.Point(36, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(807, 55);
            this.label3.TabIndex = 12;
            this.label3.Text = "Choose Withdrawal Amount";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pnlWithdrawingMoney
            // 
            this.pnlWithdrawingMoney.BackColor = System.Drawing.Color.Transparent;
            this.pnlWithdrawingMoney.Controls.Add(this.btnBackWithdrawingMoney);
            this.pnlWithdrawingMoney.Controls.Add(this.lblWithdrawingAmount);
            this.pnlWithdrawingMoney.ForeColor = System.Drawing.Color.Red;
            this.pnlWithdrawingMoney.Location = new System.Drawing.Point(73, 117);
            this.pnlWithdrawingMoney.Margin = new System.Windows.Forms.Padding(4);
            this.pnlWithdrawingMoney.Name = "pnlWithdrawingMoney";
            this.pnlWithdrawingMoney.Size = new System.Drawing.Size(891, 481);
            this.pnlWithdrawingMoney.TabIndex = 13;
            this.pnlWithdrawingMoney.Visible = false;
            // 
            // btnBackWithdrawingMoney
            // 
            this.btnBackWithdrawingMoney.BackColor = System.Drawing.Color.DimGray;
            this.btnBackWithdrawingMoney.Font = new System.Drawing.Font("Courier New", 27F, System.Drawing.FontStyle.Bold);
            this.btnBackWithdrawingMoney.ForeColor = System.Drawing.Color.Snow;
            this.btnBackWithdrawingMoney.Location = new System.Drawing.Point(319, 394);
            this.btnBackWithdrawingMoney.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBackWithdrawingMoney.Name = "btnBackWithdrawingMoney";
            this.btnBackWithdrawingMoney.Size = new System.Drawing.Size(208, 66);
            this.btnBackWithdrawingMoney.TabIndex = 19;
            this.btnBackWithdrawingMoney.Text = "Back";
            this.btnBackWithdrawingMoney.UseVisualStyleBackColor = false;
            this.btnBackWithdrawingMoney.Visible = false;
            this.btnBackWithdrawingMoney.Click += new System.EventHandler(this.btnBackWithdrawingMoney_Click);
            // 
            // lblWithdrawingAmount
            // 
            this.lblWithdrawingAmount.BackColor = System.Drawing.Color.DimGray;
            this.lblWithdrawingAmount.Font = new System.Drawing.Font("Courier New", 26F, System.Drawing.FontStyle.Bold);
            this.lblWithdrawingAmount.ForeColor = System.Drawing.Color.FloralWhite;
            this.lblWithdrawingAmount.Location = new System.Drawing.Point(27, 86);
            this.lblWithdrawingAmount.Name = "lblWithdrawingAmount";
            this.lblWithdrawingAmount.Size = new System.Drawing.Size(847, 69);
            this.lblWithdrawingAmount.TabIndex = 18;
            this.lblWithdrawingAmount.Text = "£200 successfully withdrawn";
            this.lblWithdrawingAmount.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pnlDepositMoney
            // 
            this.pnlDepositMoney.BackColor = System.Drawing.Color.Transparent;
            this.pnlDepositMoney.Controls.Add(this.btnProceed);
            this.pnlDepositMoney.Controls.Add(this.btnBackDeposit);
            this.pnlDepositMoney.Controls.Add(this.textBoxDesposit);
            this.pnlDepositMoney.Controls.Add(this.label4);
            this.pnlDepositMoney.Controls.Add(this.lblErrorInDeposit);
            this.pnlDepositMoney.Location = new System.Drawing.Point(46, 117);
            this.pnlDepositMoney.Name = "pnlDepositMoney";
            this.pnlDepositMoney.Size = new System.Drawing.Size(923, 482);
            this.pnlDepositMoney.TabIndex = 11;
            this.pnlDepositMoney.Visible = false;
            // 
            // lblErrorInDeposit
            // 
            this.lblErrorInDeposit.BackColor = System.Drawing.Color.Transparent;
            this.lblErrorInDeposit.Font = new System.Drawing.Font("Courier New", 27F, System.Drawing.FontStyle.Bold);
            this.lblErrorInDeposit.ForeColor = System.Drawing.Color.Red;
            this.lblErrorInDeposit.Location = new System.Drawing.Point(18, 113);
            this.lblErrorInDeposit.Name = "lblErrorInDeposit";
            this.lblErrorInDeposit.Size = new System.Drawing.Size(882, 60);
            this.lblErrorInDeposit.TabIndex = 16;
            this.lblErrorInDeposit.Text = "Please insert your cash";
            this.lblErrorInDeposit.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblErrorInDeposit.Visible = false;
            // 
            // btnProceed
            // 
            this.btnProceed.BackColor = System.Drawing.Color.DimGray;
            this.btnProceed.Font = new System.Drawing.Font("Courier New", 27F, System.Drawing.FontStyle.Bold);
            this.btnProceed.ForeColor = System.Drawing.Color.Snow;
            this.btnProceed.Location = new System.Drawing.Point(333, 276);
            this.btnProceed.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnProceed.Name = "btnProceed";
            this.btnProceed.Size = new System.Drawing.Size(245, 66);
            this.btnProceed.TabIndex = 15;
            this.btnProceed.Text = "Proceed";
            this.btnProceed.UseVisualStyleBackColor = false;
            this.btnProceed.Click += new System.EventHandler(this.btnProceed_Click);
            // 
            // btnBackDeposit
            // 
            this.btnBackDeposit.BackColor = System.Drawing.Color.DimGray;
            this.btnBackDeposit.Font = new System.Drawing.Font("Courier New", 27F, System.Drawing.FontStyle.Bold);
            this.btnBackDeposit.ForeColor = System.Drawing.Color.Snow;
            this.btnBackDeposit.Location = new System.Drawing.Point(333, 358);
            this.btnBackDeposit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBackDeposit.Name = "btnBackDeposit";
            this.btnBackDeposit.Size = new System.Drawing.Size(245, 66);
            this.btnBackDeposit.TabIndex = 14;
            this.btnBackDeposit.Text = "Back";
            this.btnBackDeposit.UseVisualStyleBackColor = false;
            this.btnBackDeposit.Click += new System.EventHandler(this.btnBackDeposit_Click);
            // 
            // textBoxDesposit
            // 
            this.textBoxDesposit.Font = new System.Drawing.Font("Courier New", 30F, System.Drawing.FontStyle.Bold);
            this.textBoxDesposit.Location = new System.Drawing.Point(224, 188);
            this.textBoxDesposit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxDesposit.Name = "textBoxDesposit";
            this.textBoxDesposit.Size = new System.Drawing.Size(465, 64);
            this.textBoxDesposit.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.DimGray;
            this.label4.Font = new System.Drawing.Font("Courier New", 27F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FloralWhite;
            this.label4.Location = new System.Drawing.Point(19, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(882, 75);
            this.label4.TabIndex = 4;
            this.label4.Text = "Please insert your cash";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Atm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1019, 641);
            this.Controls.Add(this.lblHeading);
            this.Controls.Add(this.pnlDisplayOptions);
            this.Controls.Add(this.pnlAccountAndPin);
            this.Controls.Add(this.pnlDepositMoney);
            this.Controls.Add(this.pnlWithdrawSelection);
            this.Controls.Add(this.pnlWithdrawingMoney);
            this.Controls.Add(this.pnlBalance);
            this.Controls.Add(this.pnlReturning);
            this.ForeColor = System.Drawing.Color.Coral;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Atm";
            this.Text = "ATMSimulator Simutalor";
            this.pnlAccountAndPin.ResumeLayout(false);
            this.pnlAccountAndPin.PerformLayout();
            this.pnlReturning.ResumeLayout(false);
            this.pnlDisplayOptions.ResumeLayout(false);
            this.pnlBalance.ResumeLayout(false);
            this.pnlWithdrawSelection.ResumeLayout(false);
            this.pnlWithdrawingMoney.ResumeLayout(false);
            this.pnlDepositMoney.ResumeLayout(false);
            this.pnlDepositMoney.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.Label lblATMAccount;
        private System.Windows.Forms.TextBox tbxAccountNumber;
        private System.Windows.Forms.Label lblPin;
        private System.Windows.Forms.TextBox tbxPin;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Panel pnlAccountAndPin;
        private System.Windows.Forms.Panel pnlReturning;
        private System.Windows.Forms.Label lblReturning;
        private System.Windows.Forms.Panel pnlDisplayOptions;
        private System.Windows.Forms.Button btnWithdraw;
        private System.Windows.Forms.Button btnReturnCard;
        private System.Windows.Forms.Button btnCheckBalance;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlBalance;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBackBalance;
        private System.Windows.Forms.Panel pnlWithdrawSelection;
        private System.Windows.Forms.Button btn500Pound;
        private System.Windows.Forms.Button btn200Pound;
        private System.Windows.Forms.Button btn50Pound;
        private System.Windows.Forms.Button btn20Pound;
        private System.Windows.Forms.Button btn10Pound;
        private System.Windows.Forms.Button btnBackWithdraw;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn100Pound;
        private System.Windows.Forms.Panel pnlWithdrawingMoney;
        private System.Windows.Forms.Button btnBackWithdrawingMoney;
        private System.Windows.Forms.Label lblWithdrawingAmount;
        private System.Windows.Forms.Label lblErrorMsg;
        private System.Windows.Forms.Button btnDeposit;
        private System.Windows.Forms.Panel pnlDepositMoney;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxDesposit;
        private System.Windows.Forms.Button btnBackDeposit;
        private System.Windows.Forms.Button btnProceed;
        private System.Windows.Forms.Label lblErrorInDeposit;
    }
}