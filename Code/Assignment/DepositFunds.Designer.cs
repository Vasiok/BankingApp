namespace Assignment
{
    partial class DepositFunds
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DepositFunds));
            this.btnBack = new System.Windows.Forms.Button();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.blLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.rdoSavingsAcc = new System.Windows.Forms.RadioButton();
            this.rdoCurrentAcc = new System.Windows.Forms.RadioButton();
            this.txtAccountNum = new System.Windows.Forms.TextBox();
            this.lblAccountNumber = new System.Windows.Forms.Label();
            this.lblAccountType = new System.Windows.Forms.Label();
            this.txtCurrentBal = new System.Windows.Forms.TextBox();
            this.lblCurrentBal = new System.Windows.Forms.Label();
            this.txtOverdraft = new System.Windows.Forms.TextBox();
            this.lblOverdraft = new System.Windows.Forms.Label();
            this.txtDeposit = new System.Windows.Forms.TextBox();
            this.lblDeposit = new System.Windows.Forms.Label();
            this.btnDeposit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.errDeposit = new System.Windows.Forms.ErrorProvider(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.errDeposit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(642, 419);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(80, 31);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // txtLastName
            // 
            this.txtLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastName.Location = new System.Drawing.Point(199, 104);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(150, 26);
            this.txtLastName.TabIndex = 29;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstName.Location = new System.Drawing.Point(199, 61);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(150, 26);
            this.txtFirstName.TabIndex = 27;
            // 
            // blLastName
            // 
            this.blLastName.AutoSize = true;
            this.blLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blLastName.ForeColor = System.Drawing.SystemColors.Control;
            this.blLastName.Location = new System.Drawing.Point(84, 107);
            this.blLastName.Name = "blLastName";
            this.blLastName.Size = new System.Drawing.Size(90, 20);
            this.blLastName.TabIndex = 28;
            this.blLastName.Text = "Last Name:";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.ForeColor = System.Drawing.SystemColors.Control;
            this.lblFirstName.Location = new System.Drawing.Point(84, 64);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(90, 20);
            this.lblFirstName.TabIndex = 26;
            this.lblFirstName.Text = "First Name:";
            // 
            // rdoSavingsAcc
            // 
            this.rdoSavingsAcc.AutoSize = true;
            this.rdoSavingsAcc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoSavingsAcc.ForeColor = System.Drawing.SystemColors.Control;
            this.rdoSavingsAcc.Location = new System.Drawing.Point(199, 179);
            this.rdoSavingsAcc.Name = "rdoSavingsAcc";
            this.rdoSavingsAcc.Size = new System.Drawing.Size(146, 24);
            this.rdoSavingsAcc.TabIndex = 52;
            this.rdoSavingsAcc.TabStop = true;
            this.rdoSavingsAcc.Text = "Savings Account";
            this.rdoSavingsAcc.UseVisualStyleBackColor = true;
            // 
            // rdoCurrentAcc
            // 
            this.rdoCurrentAcc.AutoSize = true;
            this.rdoCurrentAcc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoCurrentAcc.ForeColor = System.Drawing.SystemColors.Control;
            this.rdoCurrentAcc.Location = new System.Drawing.Point(199, 149);
            this.rdoCurrentAcc.Name = "rdoCurrentAcc";
            this.rdoCurrentAcc.Size = new System.Drawing.Size(143, 24);
            this.rdoCurrentAcc.TabIndex = 51;
            this.rdoCurrentAcc.TabStop = true;
            this.rdoCurrentAcc.Text = "Current Account";
            this.rdoCurrentAcc.UseVisualStyleBackColor = true;
            // 
            // txtAccountNum
            // 
            this.txtAccountNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAccountNum.Location = new System.Drawing.Point(199, 213);
            this.txtAccountNum.Name = "txtAccountNum";
            this.txtAccountNum.Size = new System.Drawing.Size(150, 26);
            this.txtAccountNum.TabIndex = 50;
            // 
            // lblAccountNumber
            // 
            this.lblAccountNumber.AutoSize = true;
            this.lblAccountNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccountNumber.ForeColor = System.Drawing.SystemColors.Control;
            this.lblAccountNumber.Location = new System.Drawing.Point(42, 216);
            this.lblAccountNumber.Name = "lblAccountNumber";
            this.lblAccountNumber.Size = new System.Drawing.Size(132, 20);
            this.lblAccountNumber.TabIndex = 49;
            this.lblAccountNumber.Text = "Account Number:";
            // 
            // lblAccountType
            // 
            this.lblAccountType.AutoSize = true;
            this.lblAccountType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccountType.ForeColor = System.Drawing.SystemColors.Control;
            this.lblAccountType.Location = new System.Drawing.Point(64, 149);
            this.lblAccountType.Name = "lblAccountType";
            this.lblAccountType.Size = new System.Drawing.Size(110, 20);
            this.lblAccountType.TabIndex = 48;
            this.lblAccountType.Text = "Account Type:";
            // 
            // txtCurrentBal
            // 
            this.txtCurrentBal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCurrentBal.Location = new System.Drawing.Point(199, 254);
            this.txtCurrentBal.Name = "txtCurrentBal";
            this.txtCurrentBal.Size = new System.Drawing.Size(150, 26);
            this.txtCurrentBal.TabIndex = 56;
            // 
            // lblCurrentBal
            // 
            this.lblCurrentBal.AutoSize = true;
            this.lblCurrentBal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentBal.ForeColor = System.Drawing.SystemColors.Control;
            this.lblCurrentBal.Location = new System.Drawing.Point(46, 257);
            this.lblCurrentBal.Name = "lblCurrentBal";
            this.lblCurrentBal.Size = new System.Drawing.Size(128, 20);
            this.lblCurrentBal.TabIndex = 55;
            this.lblCurrentBal.Text = "Current Balance:";
            // 
            // txtOverdraft
            // 
            this.txtOverdraft.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOverdraft.Location = new System.Drawing.Point(199, 295);
            this.txtOverdraft.Name = "txtOverdraft";
            this.txtOverdraft.Size = new System.Drawing.Size(150, 26);
            this.txtOverdraft.TabIndex = 54;
            // 
            // lblOverdraft
            // 
            this.lblOverdraft.AutoSize = true;
            this.lblOverdraft.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOverdraft.ForeColor = System.Drawing.SystemColors.Control;
            this.lblOverdraft.Location = new System.Drawing.Point(58, 298);
            this.lblOverdraft.Name = "lblOverdraft";
            this.lblOverdraft.Size = new System.Drawing.Size(116, 20);
            this.lblOverdraft.TabIndex = 53;
            this.lblOverdraft.Text = "Overdraft Limit:";
            // 
            // txtDeposit
            // 
            this.txtDeposit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDeposit.Location = new System.Drawing.Point(542, 64);
            this.txtDeposit.Name = "txtDeposit";
            this.txtDeposit.Size = new System.Drawing.Size(150, 26);
            this.txtDeposit.TabIndex = 58;
            this.txtDeposit.Validating += new System.ComponentModel.CancelEventHandler(this.txtDeposit_Validating);
            // 
            // lblDeposit
            // 
            this.lblDeposit.AutoSize = true;
            this.lblDeposit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeposit.ForeColor = System.Drawing.SystemColors.Control;
            this.lblDeposit.Location = new System.Drawing.Point(397, 64);
            this.lblDeposit.Name = "lblDeposit";
            this.lblDeposit.Size = new System.Drawing.Size(128, 20);
            this.lblDeposit.TabIndex = 57;
            this.lblDeposit.Text = "Deposit Amount:";
            // 
            // btnDeposit
            // 
            this.btnDeposit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeposit.Location = new System.Drawing.Point(592, 101);
            this.btnDeposit.Name = "btnDeposit";
            this.btnDeposit.Size = new System.Drawing.Size(100, 38);
            this.btnDeposit.TabIndex = 59;
            this.btnDeposit.Text = "Deposit";
            this.btnDeposit.UseVisualStyleBackColor = true;
            this.btnDeposit.Click += new System.EventHandler(this.btnDeposit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 20);
            this.label1.TabIndex = 62;
            this.label1.Text = "Deposit Funds:";
            // 
            // errDeposit
            // 
            this.errDeposit.ContainerControl = this;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Assignment.Properties.Resources.DBSCU1;
            this.pictureBox1.Location = new System.Drawing.Point(420, 230);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(286, 126);
            this.pictureBox1.TabIndex = 63;
            this.pictureBox1.TabStop = false;
            // 
            // DepositFunds
            // 
            this.AcceptButton = this.btnDeposit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(88)))), ((int)(((byte)(149)))));
            this.ClientSize = new System.Drawing.Size(734, 462);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDeposit);
            this.Controls.Add(this.txtDeposit);
            this.Controls.Add(this.lblDeposit);
            this.Controls.Add(this.txtCurrentBal);
            this.Controls.Add(this.lblCurrentBal);
            this.Controls.Add(this.txtOverdraft);
            this.Controls.Add(this.lblOverdraft);
            this.Controls.Add(this.rdoSavingsAcc);
            this.Controls.Add(this.rdoCurrentAcc);
            this.Controls.Add(this.txtAccountNum);
            this.Controls.Add(this.lblAccountNumber);
            this.Controls.Add(this.lblAccountType);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.blLastName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.btnBack);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DepositFunds";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DBS Credit Union - Deposit Funds";
            this.Load += new System.EventHandler(this.DepositFunds_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errDeposit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label blLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.RadioButton rdoSavingsAcc;
        private System.Windows.Forms.RadioButton rdoCurrentAcc;
        private System.Windows.Forms.TextBox txtAccountNum;
        private System.Windows.Forms.Label lblAccountNumber;
        private System.Windows.Forms.Label lblAccountType;
        private System.Windows.Forms.TextBox txtCurrentBal;
        private System.Windows.Forms.Label lblCurrentBal;
        private System.Windows.Forms.TextBox txtOverdraft;
        private System.Windows.Forms.Label lblOverdraft;
        private System.Windows.Forms.TextBox txtDeposit;
        private System.Windows.Forms.Label lblDeposit;
        private System.Windows.Forms.Button btnDeposit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errDeposit;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}