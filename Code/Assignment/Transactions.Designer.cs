namespace Assignment
{
    partial class Transactions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Transactions));
            this.btnBack = new System.Windows.Forms.Button();
            this.dgvTransactions = new System.Windows.Forms.DataGridView();
            this.btnAllTranactions = new System.Windows.Forms.Button();
            this.btnLodgements = new System.Windows.Forms.Button();
            this.btnViewWithdraws = new System.Windows.Forms.Button();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.blLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.rdoSavingsAcc = new System.Windows.Forms.RadioButton();
            this.rdoCurrentAcc = new System.Windows.Forms.RadioButton();
            this.txtAccountNum = new System.Windows.Forms.TextBox();
            this.lblAccountNumber = new System.Windows.Forms.Label();
            this.lblAccountType = new System.Windows.Forms.Label();
            this.btnTransfers = new System.Windows.Forms.Button();
            this.dgvTransfers = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransactions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransfers)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(631, 417);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(91, 33);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // dgvTransactions
            // 
            this.dgvTransactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTransactions.Location = new System.Drawing.Point(13, 134);
            this.dgvTransactions.Name = "dgvTransactions";
            this.dgvTransactions.Size = new System.Drawing.Size(709, 277);
            this.dgvTransactions.TabIndex = 1;
            // 
            // btnAllTranactions
            // 
            this.btnAllTranactions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAllTranactions.Location = new System.Drawing.Point(13, 12);
            this.btnAllTranactions.Name = "btnAllTranactions";
            this.btnAllTranactions.Size = new System.Drawing.Size(161, 39);
            this.btnAllTranactions.TabIndex = 2;
            this.btnAllTranactions.Text = "View All Tranactions";
            this.btnAllTranactions.UseVisualStyleBackColor = true;
            this.btnAllTranactions.Click += new System.EventHandler(this.btnAllTranactions_Click);
            // 
            // btnLodgements
            // 
            this.btnLodgements.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLodgements.Location = new System.Drawing.Point(377, 12);
            this.btnLodgements.Name = "btnLodgements";
            this.btnLodgements.Size = new System.Drawing.Size(161, 39);
            this.btnLodgements.TabIndex = 4;
            this.btnLodgements.Text = "View Lodgements";
            this.btnLodgements.UseVisualStyleBackColor = true;
            this.btnLodgements.Click += new System.EventHandler(this.btnLodgements_Click);
            // 
            // btnViewWithdraws
            // 
            this.btnViewWithdraws.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewWithdraws.Location = new System.Drawing.Point(559, 12);
            this.btnViewWithdraws.Name = "btnViewWithdraws";
            this.btnViewWithdraws.Size = new System.Drawing.Size(161, 39);
            this.btnViewWithdraws.TabIndex = 5;
            this.btnViewWithdraws.Text = "View Withdraws";
            this.btnViewWithdraws.UseVisualStyleBackColor = true;
            this.btnViewWithdraws.Click += new System.EventHandler(this.btnViewWithdraws_Click);
            // 
            // txtLastName
            // 
            this.txtLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastName.Location = new System.Drawing.Point(136, 97);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(150, 26);
            this.txtLastName.TabIndex = 33;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstName.Location = new System.Drawing.Point(136, 65);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(150, 26);
            this.txtFirstName.TabIndex = 31;
            // 
            // blLastName
            // 
            this.blLastName.AutoSize = true;
            this.blLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blLastName.ForeColor = System.Drawing.SystemColors.Control;
            this.blLastName.Location = new System.Drawing.Point(40, 100);
            this.blLastName.Name = "blLastName";
            this.blLastName.Size = new System.Drawing.Size(90, 20);
            this.blLastName.TabIndex = 32;
            this.blLastName.Text = "Last Name:";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.ForeColor = System.Drawing.SystemColors.Control;
            this.lblFirstName.Location = new System.Drawing.Point(40, 70);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(90, 20);
            this.lblFirstName.TabIndex = 30;
            this.lblFirstName.Text = "First Name:";
            // 
            // rdoSavingsAcc
            // 
            this.rdoSavingsAcc.AutoSize = true;
            this.rdoSavingsAcc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoSavingsAcc.ForeColor = System.Drawing.SystemColors.Control;
            this.rdoSavingsAcc.Location = new System.Drawing.Point(574, 66);
            this.rdoSavingsAcc.Name = "rdoSavingsAcc";
            this.rdoSavingsAcc.Size = new System.Drawing.Size(114, 24);
            this.rdoSavingsAcc.TabIndex = 57;
            this.rdoSavingsAcc.TabStop = true;
            this.rdoSavingsAcc.Text = "Savings Acc";
            this.rdoSavingsAcc.UseVisualStyleBackColor = true;
            // 
            // rdoCurrentAcc
            // 
            this.rdoCurrentAcc.AutoSize = true;
            this.rdoCurrentAcc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoCurrentAcc.ForeColor = System.Drawing.SystemColors.Control;
            this.rdoCurrentAcc.Location = new System.Drawing.Point(456, 66);
            this.rdoCurrentAcc.Name = "rdoCurrentAcc";
            this.rdoCurrentAcc.Size = new System.Drawing.Size(111, 24);
            this.rdoCurrentAcc.TabIndex = 56;
            this.rdoCurrentAcc.TabStop = true;
            this.rdoCurrentAcc.Text = "Current Acc";
            this.rdoCurrentAcc.UseVisualStyleBackColor = true;
            // 
            // txtAccountNum
            // 
            this.txtAccountNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAccountNum.Location = new System.Drawing.Point(456, 97);
            this.txtAccountNum.Name = "txtAccountNum";
            this.txtAccountNum.Size = new System.Drawing.Size(150, 26);
            this.txtAccountNum.TabIndex = 55;
            // 
            // lblAccountNumber
            // 
            this.lblAccountNumber.AutoSize = true;
            this.lblAccountNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccountNumber.ForeColor = System.Drawing.SystemColors.Control;
            this.lblAccountNumber.Location = new System.Drawing.Point(302, 100);
            this.lblAccountNumber.Name = "lblAccountNumber";
            this.lblAccountNumber.Size = new System.Drawing.Size(132, 20);
            this.lblAccountNumber.TabIndex = 54;
            this.lblAccountNumber.Text = "Account Number:";
            // 
            // lblAccountType
            // 
            this.lblAccountType.AutoSize = true;
            this.lblAccountType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccountType.ForeColor = System.Drawing.SystemColors.Control;
            this.lblAccountType.Location = new System.Drawing.Point(324, 70);
            this.lblAccountType.Name = "lblAccountType";
            this.lblAccountType.Size = new System.Drawing.Size(110, 20);
            this.lblAccountType.TabIndex = 53;
            this.lblAccountType.Text = "Account Type:";
            // 
            // btnTransfers
            // 
            this.btnTransfers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransfers.Location = new System.Drawing.Point(195, 12);
            this.btnTransfers.Name = "btnTransfers";
            this.btnTransfers.Size = new System.Drawing.Size(161, 39);
            this.btnTransfers.TabIndex = 58;
            this.btnTransfers.Text = "View Transfers";
            this.btnTransfers.UseVisualStyleBackColor = true;
            this.btnTransfers.Click += new System.EventHandler(this.btnTransfers_Click);
            // 
            // dgvTransfers
            // 
            this.dgvTransfers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTransfers.Location = new System.Drawing.Point(13, 134);
            this.dgvTransfers.Name = "dgvTransfers";
            this.dgvTransfers.Size = new System.Drawing.Size(709, 277);
            this.dgvTransfers.TabIndex = 59;
            this.dgvTransfers.Visible = false;
            // 
            // Transactions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(88)))), ((int)(((byte)(149)))));
            this.ClientSize = new System.Drawing.Size(734, 462);
            this.Controls.Add(this.dgvTransfers);
            this.Controls.Add(this.btnTransfers);
            this.Controls.Add(this.rdoSavingsAcc);
            this.Controls.Add(this.rdoCurrentAcc);
            this.Controls.Add(this.txtAccountNum);
            this.Controls.Add(this.lblAccountNumber);
            this.Controls.Add(this.lblAccountType);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.blLastName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.btnViewWithdraws);
            this.Controls.Add(this.btnLodgements);
            this.Controls.Add(this.btnAllTranactions);
            this.Controls.Add(this.dgvTransactions);
            this.Controls.Add(this.btnBack);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Transactions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DBS Credit Union - View All Transactions";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransactions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransfers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataGridView dgvTransactions;
        private System.Windows.Forms.Button btnAllTranactions;
        private System.Windows.Forms.Button btnLodgements;
        private System.Windows.Forms.Button btnViewWithdraws;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label blLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.RadioButton rdoSavingsAcc;
        private System.Windows.Forms.RadioButton rdoCurrentAcc;
        private System.Windows.Forms.TextBox txtAccountNum;
        private System.Windows.Forms.Label lblAccountNumber;
        private System.Windows.Forms.Label lblAccountType;
        private System.Windows.Forms.Button btnTransfers;
        private System.Windows.Forms.DataGridView dgvTransfers;
    }
}