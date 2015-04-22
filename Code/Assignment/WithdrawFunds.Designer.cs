namespace Assignment
{
    partial class WithdrawFunds
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WithdrawFunds));
            this.btnBack = new System.Windows.Forms.Button();
            this.btnWithdraw = new System.Windows.Forms.Button();
            this.txtWithdraw = new System.Windows.Forms.TextBox();
            this.lblWithdraw = new System.Windows.Forms.Label();
            this.txtCurrentBal = new System.Windows.Forms.TextBox();
            this.lblCurrentBal = new System.Windows.Forms.Label();
            this.txtOverdraft = new System.Windows.Forms.TextBox();
            this.lblOverdraft = new System.Windows.Forms.Label();
            this.rdoSavingsAcc = new System.Windows.Forms.RadioButton();
            this.rdoCurrentAcc = new System.Windows.Forms.RadioButton();
            this.txtAccountNum = new System.Windows.Forms.TextBox();
            this.lblAccountNumber = new System.Windows.Forms.Label();
            this.lblAccountType = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.blLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.errWithdraw = new System.Windows.Forms.ErrorProvider(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.errWithdraw)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(641, 420);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(81, 30);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnWithdraw
            // 
            this.btnWithdraw.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWithdraw.Location = new System.Drawing.Point(567, 106);
            this.btnWithdraw.Name = "btnWithdraw";
            this.btnWithdraw.Size = new System.Drawing.Size(107, 32);
            this.btnWithdraw.TabIndex = 77;
            this.btnWithdraw.Text = "Withdraw";
            this.btnWithdraw.UseVisualStyleBackColor = true;
            this.btnWithdraw.Click += new System.EventHandler(this.btnWithdraw_Click);
            // 
            // txtWithdraw
            // 
            this.txtWithdraw.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWithdraw.Location = new System.Drawing.Point(524, 70);
            this.txtWithdraw.Name = "txtWithdraw";
            this.txtWithdraw.Size = new System.Drawing.Size(150, 26);
            this.txtWithdraw.TabIndex = 76;
            this.txtWithdraw.Validating += new System.ComponentModel.CancelEventHandler(this.txtWithdraw_Validating);
            // 
            // lblWithdraw
            // 
            this.lblWithdraw.AutoSize = true;
            this.lblWithdraw.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWithdraw.ForeColor = System.Drawing.SystemColors.Control;
            this.lblWithdraw.Location = new System.Drawing.Point(379, 73);
            this.lblWithdraw.Name = "lblWithdraw";
            this.lblWithdraw.Size = new System.Drawing.Size(139, 20);
            this.lblWithdraw.TabIndex = 75;
            this.lblWithdraw.Text = "Withdraw Amount:";
            // 
            // txtCurrentBal
            // 
            this.txtCurrentBal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCurrentBal.Location = new System.Drawing.Point(201, 251);
            this.txtCurrentBal.Name = "txtCurrentBal";
            this.txtCurrentBal.Size = new System.Drawing.Size(150, 26);
            this.txtCurrentBal.TabIndex = 74;
            // 
            // lblCurrentBal
            // 
            this.lblCurrentBal.AutoSize = true;
            this.lblCurrentBal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentBal.ForeColor = System.Drawing.SystemColors.Control;
            this.lblCurrentBal.Location = new System.Drawing.Point(42, 254);
            this.lblCurrentBal.Name = "lblCurrentBal";
            this.lblCurrentBal.Size = new System.Drawing.Size(128, 20);
            this.lblCurrentBal.TabIndex = 73;
            this.lblCurrentBal.Text = "Current Balance:";
            // 
            // txtOverdraft
            // 
            this.txtOverdraft.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOverdraft.Location = new System.Drawing.Point(201, 293);
            this.txtOverdraft.Name = "txtOverdraft";
            this.txtOverdraft.Size = new System.Drawing.Size(150, 26);
            this.txtOverdraft.TabIndex = 72;
            // 
            // lblOverdraft
            // 
            this.lblOverdraft.AutoSize = true;
            this.lblOverdraft.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOverdraft.ForeColor = System.Drawing.SystemColors.Control;
            this.lblOverdraft.Location = new System.Drawing.Point(54, 296);
            this.lblOverdraft.Name = "lblOverdraft";
            this.lblOverdraft.Size = new System.Drawing.Size(116, 20);
            this.lblOverdraft.TabIndex = 71;
            this.lblOverdraft.Text = "Overdraft Limit:";
            // 
            // rdoSavingsAcc
            // 
            this.rdoSavingsAcc.AutoSize = true;
            this.rdoSavingsAcc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoSavingsAcc.ForeColor = System.Drawing.SystemColors.Control;
            this.rdoSavingsAcc.Location = new System.Drawing.Point(201, 178);
            this.rdoSavingsAcc.Name = "rdoSavingsAcc";
            this.rdoSavingsAcc.Size = new System.Drawing.Size(146, 24);
            this.rdoSavingsAcc.TabIndex = 70;
            this.rdoSavingsAcc.TabStop = true;
            this.rdoSavingsAcc.Text = "Savings Account";
            this.rdoSavingsAcc.UseVisualStyleBackColor = true;
            // 
            // rdoCurrentAcc
            // 
            this.rdoCurrentAcc.AutoSize = true;
            this.rdoCurrentAcc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoCurrentAcc.ForeColor = System.Drawing.SystemColors.Control;
            this.rdoCurrentAcc.Location = new System.Drawing.Point(201, 147);
            this.rdoCurrentAcc.Name = "rdoCurrentAcc";
            this.rdoCurrentAcc.Size = new System.Drawing.Size(143, 24);
            this.rdoCurrentAcc.TabIndex = 69;
            this.rdoCurrentAcc.TabStop = true;
            this.rdoCurrentAcc.Text = "Current Account";
            this.rdoCurrentAcc.UseVisualStyleBackColor = true;
            // 
            // txtAccountNum
            // 
            this.txtAccountNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAccountNum.Location = new System.Drawing.Point(201, 209);
            this.txtAccountNum.Name = "txtAccountNum";
            this.txtAccountNum.Size = new System.Drawing.Size(150, 26);
            this.txtAccountNum.TabIndex = 68;
            // 
            // lblAccountNumber
            // 
            this.lblAccountNumber.AutoSize = true;
            this.lblAccountNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccountNumber.ForeColor = System.Drawing.SystemColors.Control;
            this.lblAccountNumber.Location = new System.Drawing.Point(38, 212);
            this.lblAccountNumber.Name = "lblAccountNumber";
            this.lblAccountNumber.Size = new System.Drawing.Size(132, 20);
            this.lblAccountNumber.TabIndex = 67;
            this.lblAccountNumber.Text = "Account Number:";
            // 
            // lblAccountType
            // 
            this.lblAccountType.AutoSize = true;
            this.lblAccountType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccountType.ForeColor = System.Drawing.SystemColors.Control;
            this.lblAccountType.Location = new System.Drawing.Point(60, 151);
            this.lblAccountType.Name = "lblAccountType";
            this.lblAccountType.Size = new System.Drawing.Size(110, 20);
            this.lblAccountType.TabIndex = 66;
            this.lblAccountType.Text = "Account Type:";
            // 
            // txtLastName
            // 
            this.txtLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastName.Location = new System.Drawing.Point(201, 109);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(150, 26);
            this.txtLastName.TabIndex = 65;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstName.Location = new System.Drawing.Point(201, 67);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(150, 26);
            this.txtFirstName.TabIndex = 63;
            // 
            // blLastName
            // 
            this.blLastName.AutoSize = true;
            this.blLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blLastName.ForeColor = System.Drawing.SystemColors.Control;
            this.blLastName.Location = new System.Drawing.Point(80, 112);
            this.blLastName.Name = "blLastName";
            this.blLastName.Size = new System.Drawing.Size(90, 20);
            this.blLastName.TabIndex = 64;
            this.blLastName.Text = "Last Name:";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.ForeColor = System.Drawing.SystemColors.Control;
            this.lblFirstName.Location = new System.Drawing.Point(80, 70);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(90, 20);
            this.lblFirstName.TabIndex = 62;
            this.lblFirstName.Text = "First Name:";
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.ForeColor = System.Drawing.SystemColors.Control;
            this.lblInfo.Location = new System.Drawing.Point(12, 9);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(143, 20);
            this.lblInfo.TabIndex = 80;
            this.lblInfo.Text = "Withdraw Funds:";
            // 
            // errWithdraw
            // 
            this.errWithdraw.ContainerControl = this;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Assignment.Properties.Resources.DBSCU1;
            this.pictureBox1.Location = new System.Drawing.Point(420, 230);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(286, 126);
            this.pictureBox1.TabIndex = 81;
            this.pictureBox1.TabStop = false;
            // 
            // WithdrawFunds
            // 
            this.AcceptButton = this.btnWithdraw;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(88)))), ((int)(((byte)(149)))));
            this.ClientSize = new System.Drawing.Size(734, 462);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.btnWithdraw);
            this.Controls.Add(this.txtWithdraw);
            this.Controls.Add(this.lblWithdraw);
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
            this.Name = "WithdrawFunds";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DBS Credit Union - Withdraw Funds";
            this.Load += new System.EventHandler(this.WithdrawFunds_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errWithdraw)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnWithdraw;
        private System.Windows.Forms.TextBox txtWithdraw;
        private System.Windows.Forms.Label lblWithdraw;
        private System.Windows.Forms.TextBox txtCurrentBal;
        private System.Windows.Forms.Label lblCurrentBal;
        private System.Windows.Forms.TextBox txtOverdraft;
        private System.Windows.Forms.Label lblOverdraft;
        private System.Windows.Forms.RadioButton rdoSavingsAcc;
        private System.Windows.Forms.RadioButton rdoCurrentAcc;
        private System.Windows.Forms.TextBox txtAccountNum;
        private System.Windows.Forms.Label lblAccountNumber;
        private System.Windows.Forms.Label lblAccountType;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label blLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.ErrorProvider errWithdraw;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}