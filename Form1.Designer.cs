namespace ATM
{
    partial class ATMModeSelection
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
            this.lblHeading = new System.Windows.Forms.Label();
            this.btnSimulateNoRaceCondition = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.pnlStarting = new System.Windows.Forms.Panel();
            this.btnSimulateRace = new System.Windows.Forms.Button();
            this.pnlStarting.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblHeading
            // 
            this.lblHeading.BackColor = System.Drawing.Color.Transparent;
            this.lblHeading.Font = new System.Drawing.Font("Courier New", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.ForeColor = System.Drawing.Color.FloralWhite;
            this.lblHeading.Location = new System.Drawing.Point(489, 20);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(249, 94);
            this.lblHeading.TabIndex = 1;
            this.lblHeading.Text = "MODE";
            this.lblHeading.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblHeading.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnSimulateNoRaceCondition
            // 
            this.btnSimulateNoRaceCondition.BackColor = System.Drawing.Color.DimGray;
            this.btnSimulateNoRaceCondition.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnSimulateNoRaceCondition.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnSimulateNoRaceCondition.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnSimulateNoRaceCondition.Font = new System.Drawing.Font("Courier New", 30F, System.Drawing.FontStyle.Bold);
            this.btnSimulateNoRaceCondition.Location = new System.Drawing.Point(35, 159);
            this.btnSimulateNoRaceCondition.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSimulateNoRaceCondition.Name = "btnSimulateNoRaceCondition";
            this.btnSimulateNoRaceCondition.Size = new System.Drawing.Size(895, 89);
            this.btnSimulateNoRaceCondition.TabIndex = 2;
            this.btnSimulateNoRaceCondition.Text = "Simulate No Race Condition";
            this.btnSimulateNoRaceCondition.UseVisualStyleBackColor = false;
            this.btnSimulateNoRaceCondition.Click += new System.EventHandler(this.btnSimulateNoRaceCondition_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.DimGray;
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnExit.Font = new System.Drawing.Font("Courier New", 30F, System.Drawing.FontStyle.Bold);
            this.btnExit.Location = new System.Drawing.Point(35, 306);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(895, 89);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pnlStarting
            // 
            this.pnlStarting.BackColor = System.Drawing.Color.Transparent;
            this.pnlStarting.Controls.Add(this.btnSimulateRace);
            this.pnlStarting.Controls.Add(this.btnSimulateNoRaceCondition);
            this.pnlStarting.Controls.Add(this.btnExit);
            this.pnlStarting.Location = new System.Drawing.Point(107, 135);
            this.pnlStarting.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlStarting.Name = "pnlStarting";
            this.pnlStarting.Size = new System.Drawing.Size(985, 443);
            this.pnlStarting.TabIndex = 5;
            // 
            // btnSimulateRace
            // 
            this.btnSimulateRace.BackColor = System.Drawing.Color.DimGray;
            this.btnSimulateRace.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnSimulateRace.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnSimulateRace.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnSimulateRace.Font = new System.Drawing.Font("Courier New", 30F, System.Drawing.FontStyle.Bold);
            this.btnSimulateRace.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSimulateRace.Location = new System.Drawing.Point(35, 28);
            this.btnSimulateRace.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSimulateRace.Name = "btnSimulateRace";
            this.btnSimulateRace.Size = new System.Drawing.Size(895, 94);
            this.btnSimulateRace.TabIndex = 5;
            this.btnSimulateRace.Text = "Simulate Race Condition";
            this.btnSimulateRace.UseVisualStyleBackColor = false;
            this.btnSimulateRace.Click += new System.EventHandler(this.btnSimulateRace_Click);
            // 
            // ATMModeSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ATM.Properties.Resources.bgForATM;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1181, 702);
            this.Controls.Add(this.pnlStarting);
            this.Controls.Add(this.lblHeading);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ATMModeSelection";
            this.ShowIcon = false;
            this.Text = "ATMSimulator Mode Selection";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlStarting.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.Button btnSimulateNoRaceCondition;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel pnlStarting;
        private System.Windows.Forms.Button btnSimulateRace;
    }
}

