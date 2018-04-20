namespace Stock_Purchase
{
    partial class Form1
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
            this.labelCostPerShare = new System.Windows.Forms.Label();
            this.labelNumberOfShares = new System.Windows.Forms.Label();
            this.labelAmount = new System.Windows.Forms.Label();
            this.labelProjectedValue = new System.Windows.Forms.Label();
            this.textCostPerShare = new System.Windows.Forms.TextBox();
            this.textNumberOfShares = new System.Windows.Forms.TextBox();
            this.textAmount = new System.Windows.Forms.TextBox();
            this.textIncrease = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.textDecrease = new System.Windows.Forms.TextBox();
            this.labelIncrease = new System.Windows.Forms.Label();
            this.labelDecrease = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelCostPerShare
            // 
            this.labelCostPerShare.AutoSize = true;
            this.labelCostPerShare.Location = new System.Drawing.Point(23, 23);
            this.labelCostPerShare.Name = "labelCostPerShare";
            this.labelCostPerShare.Size = new System.Drawing.Size(81, 13);
            this.labelCostPerShare.TabIndex = 0;
            this.labelCostPerShare.Text = "Cost P&er Share:";
            // 
            // labelNumberOfShares
            // 
            this.labelNumberOfShares.AutoSize = true;
            this.labelNumberOfShares.Location = new System.Drawing.Point(23, 60);
            this.labelNumberOfShares.Name = "labelNumberOfShares";
            this.labelNumberOfShares.Size = new System.Drawing.Size(65, 13);
            this.labelNumberOfShares.TabIndex = 1;
            this.labelNumberOfShares.Text = "# of &Shares:";
            // 
            // labelAmount
            // 
            this.labelAmount.AutoSize = true;
            this.labelAmount.Location = new System.Drawing.Point(22, 97);
            this.labelAmount.Name = "labelAmount";
            this.labelAmount.Size = new System.Drawing.Size(46, 13);
            this.labelAmount.TabIndex = 2;
            this.labelAmount.Text = "Amount:";
            // 
            // labelProjectedValue
            // 
            this.labelProjectedValue.AutoSize = true;
            this.labelProjectedValue.Location = new System.Drawing.Point(92, 138);
            this.labelProjectedValue.Name = "labelProjectedValue";
            this.labelProjectedValue.Size = new System.Drawing.Size(90, 13);
            this.labelProjectedValue.TabIndex = 3;
            this.labelProjectedValue.Text = "Projected Values:";
            // 
            // textCostPerShare
            // 
            this.textCostPerShare.Location = new System.Drawing.Point(147, 16);
            this.textCostPerShare.Name = "textCostPerShare";
            this.textCostPerShare.Size = new System.Drawing.Size(100, 20);
            this.textCostPerShare.TabIndex = 1;
            // 
            // textNumberOfShares
            // 
            this.textNumberOfShares.Location = new System.Drawing.Point(147, 53);
            this.textNumberOfShares.Name = "textNumberOfShares";
            this.textNumberOfShares.Size = new System.Drawing.Size(100, 20);
            this.textNumberOfShares.TabIndex = 2;
            // 
            // textAmount
            // 
            this.textAmount.Location = new System.Drawing.Point(147, 90);
            this.textAmount.Name = "textAmount";
            this.textAmount.ReadOnly = true;
            this.textAmount.Size = new System.Drawing.Size(100, 20);
            this.textAmount.TabIndex = 6;
            this.textAmount.TabStop = false;
            // 
            // textIncrease
            // 
            this.textIncrease.Location = new System.Drawing.Point(147, 158);
            this.textIncrease.Name = "textIncrease";
            this.textIncrease.ReadOnly = true;
            this.textIncrease.Size = new System.Drawing.Size(100, 20);
            this.textIncrease.TabIndex = 7;
            this.textIncrease.TabStop = false;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(25, 240);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 8;
            this.btnCalculate.Text = "C&alculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(172, 240);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // textDecrease
            // 
            this.textDecrease.Location = new System.Drawing.Point(147, 193);
            this.textDecrease.Name = "textDecrease";
            this.textDecrease.ReadOnly = true;
            this.textDecrease.Size = new System.Drawing.Size(100, 20);
            this.textDecrease.TabIndex = 10;
            this.textDecrease.TabStop = false;
            // 
            // labelIncrease
            // 
            this.labelIncrease.AutoSize = true;
            this.labelIncrease.Location = new System.Drawing.Point(23, 165);
            this.labelIncrease.Name = "labelIncrease";
            this.labelIncrease.Size = new System.Drawing.Size(68, 13);
            this.labelIncrease.TabIndex = 11;
            this.labelIncrease.Text = "5% Increase:";
            // 
            // labelDecrease
            // 
            this.labelDecrease.AutoSize = true;
            this.labelDecrease.Location = new System.Drawing.Point(23, 200);
            this.labelDecrease.Name = "labelDecrease";
            this.labelDecrease.Size = new System.Drawing.Size(79, 13);
            this.labelDecrease.TabIndex = 12;
            this.labelDecrease.Text = "10% Decrease:";
            // 
            // Form1
            // 
            this.AcceptButton = this.btnCalculate;
            this.CancelButton = this.btnExit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 281);
            this.Controls.Add(this.labelDecrease);
            this.Controls.Add(this.labelIncrease);
            this.Controls.Add(this.textDecrease);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.textIncrease);
            this.Controls.Add(this.textAmount);
            this.Controls.Add(this.textNumberOfShares);
            this.Controls.Add(this.textCostPerShare);
            this.Controls.Add(this.labelProjectedValue);
            this.Controls.Add(this.labelAmount);
            this.Controls.Add(this.labelNumberOfShares);
            this.Controls.Add(this.labelCostPerShare);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCostPerShare;
        private System.Windows.Forms.Label labelNumberOfShares;
        private System.Windows.Forms.Label labelAmount;
        private System.Windows.Forms.Label labelProjectedValue;
        private System.Windows.Forms.TextBox textCostPerShare;
        private System.Windows.Forms.TextBox textNumberOfShares;
        private System.Windows.Forms.TextBox textAmount;
        private System.Windows.Forms.TextBox textIncrease;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox textDecrease;
        private System.Windows.Forms.Label labelIncrease;
        private System.Windows.Forms.Label labelDecrease;
    }
}

