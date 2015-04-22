namespace Assignment
{
    partial class TransferFunds
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TransferFunds));
            this.btnBack = new System.Windows.Forms.Button();
            this.btnTransfer = new System.Windows.Forms.Button();
            this.lblAccountNumber = new System.Windows.Forms.Label();
            this.txtAccountNumber = new System.Windows.Forms.TextBox();
            this.lblSource = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.rtfDescription = new System.Windows.Forms.RichTextBox();
            this.lblDestination = new System.Windows.Forms.Label();
            this.txtAccOutNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDestinationSortCode = new System.Windows.Forms.TextBox();
            this.lblSortCode = new System.Windows.Forms.Label();
            this.btnInternal = new System.Windows.Forms.Button();
            this.btnExternal = new System.Windows.Forms.Button();
            this.txtAmmount = new System.Windows.Forms.TextBox();
            this.lblAmmount = new System.Windows.Forms.Label();
            this.txtRecepientName = new System.Windows.Forms.TextBox();
            this.lblRecepientName = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.btnExternalSource = new System.Windows.Forms.Button();
            this.errTransferAmmount = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errTransferAmmount)).BeginInit();
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
            // btnTransfer
            // 
            this.btnTransfer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransfer.Location = new System.Drawing.Point(540, 309);
            this.btnTransfer.Name = "btnTransfer";
            this.btnTransfer.Size = new System.Drawing.Size(150, 30);
            this.btnTransfer.TabIndex = 1;
            this.btnTransfer.Text = "Transfer";
            this.btnTransfer.UseVisualStyleBackColor = true;
            this.btnTransfer.Click += new System.EventHandler(this.btnTransfer_Click);
            // 
            // lblAccountNumber
            // 
            this.lblAccountNumber.AutoSize = true;
            this.lblAccountNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccountNumber.ForeColor = System.Drawing.Color.White;
            this.lblAccountNumber.Location = new System.Drawing.Point(10, 100);
            this.lblAccountNumber.Name = "lblAccountNumber";
            this.lblAccountNumber.Size = new System.Drawing.Size(132, 20);
            this.lblAccountNumber.TabIndex = 2;
            this.lblAccountNumber.Text = "Account Number:";
            // 
            // txtAccountNumber
            // 
            this.txtAccountNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAccountNumber.Location = new System.Drawing.Point(173, 100);
            this.txtAccountNumber.Name = "txtAccountNumber";
            this.txtAccountNumber.Size = new System.Drawing.Size(150, 26);
            this.txtAccountNumber.TabIndex = 54;
            // 
            // lblSource
            // 
            this.lblSource.AutoSize = true;
            this.lblSource.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSource.ForeColor = System.Drawing.Color.White;
            this.lblSource.Location = new System.Drawing.Point(65, 63);
            this.lblSource.Name = "lblSource";
            this.lblSource.Size = new System.Drawing.Size(77, 24);
            this.lblSource.TabIndex = 55;
            this.lblSource.Text = "Source";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.White;
            this.lblDate.Location = new System.Drawing.Point(94, 137);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(48, 20);
            this.lblDate.TabIndex = 59;
            this.lblDate.Text = "Date:";
            // 
            // txtDate
            // 
            this.txtDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDate.Location = new System.Drawing.Point(173, 133);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(150, 26);
            this.txtDate.TabIndex = 60;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.ForeColor = System.Drawing.Color.White;
            this.lblDescription.Location = new System.Drawing.Point(49, 205);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(93, 20);
            this.lblDescription.TabIndex = 61;
            this.lblDescription.Text = "Description:";
            // 
            // rtfDescription
            // 
            this.rtfDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtfDescription.Location = new System.Drawing.Point(173, 205);
            this.rtfDescription.Name = "rtfDescription";
            this.rtfDescription.Size = new System.Drawing.Size(193, 134);
            this.rtfDescription.TabIndex = 62;
            this.rtfDescription.Text = "";
            // 
            // lblDestination
            // 
            this.lblDestination.AutoSize = true;
            this.lblDestination.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDestination.ForeColor = System.Drawing.Color.White;
            this.lblDestination.Location = new System.Drawing.Point(400, 63);
            this.lblDestination.Name = "lblDestination";
            this.lblDestination.Size = new System.Drawing.Size(113, 24);
            this.lblDestination.TabIndex = 63;
            this.lblDestination.Text = "Destination";
            // 
            // txtAccOutNumber
            // 
            this.txtAccOutNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAccOutNumber.Location = new System.Drawing.Point(540, 135);
            this.txtAccOutNumber.Name = "txtAccOutNumber";
            this.txtAccOutNumber.Size = new System.Drawing.Size(150, 26);
            this.txtAccOutNumber.TabIndex = 65;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(381, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 20);
            this.label1.TabIndex = 64;
            this.label1.Text = "Account Number:";
            // 
            // txtDestinationSortCode
            // 
            this.txtDestinationSortCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDestinationSortCode.Location = new System.Drawing.Point(540, 100);
            this.txtDestinationSortCode.Name = "txtDestinationSortCode";
            this.txtDestinationSortCode.Size = new System.Drawing.Size(150, 26);
            this.txtDestinationSortCode.TabIndex = 67;
            // 
            // lblSortCode
            // 
            this.lblSortCode.AutoSize = true;
            this.lblSortCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSortCode.ForeColor = System.Drawing.Color.White;
            this.lblSortCode.Location = new System.Drawing.Point(428, 103);
            this.lblSortCode.Name = "lblSortCode";
            this.lblSortCode.Size = new System.Drawing.Size(85, 20);
            this.lblSortCode.TabIndex = 66;
            this.lblSortCode.Text = "Sort Code:";
            // 
            // btnInternal
            // 
            this.btnInternal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInternal.Location = new System.Drawing.Point(540, 245);
            this.btnInternal.Name = "btnInternal";
            this.btnInternal.Size = new System.Drawing.Size(150, 31);
            this.btnInternal.TabIndex = 68;
            this.btnInternal.Text = "Find Account";
            this.btnInternal.UseVisualStyleBackColor = true;
            this.btnInternal.Click += new System.EventHandler(this.btnInternal_Click);
            // 
            // btnExternal
            // 
            this.btnExternal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExternal.Location = new System.Drawing.Point(540, 205);
            this.btnExternal.Name = "btnExternal";
            this.btnExternal.Size = new System.Drawing.Size(150, 31);
            this.btnExternal.TabIndex = 69;
            this.btnExternal.Text = "External Transfer";
            this.btnExternal.UseVisualStyleBackColor = true;
            this.btnExternal.Click += new System.EventHandler(this.btnExternal_Click);
            // 
            // txtAmmount
            // 
            this.txtAmmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmmount.Location = new System.Drawing.Point(173, 167);
            this.txtAmmount.Name = "txtAmmount";
            this.txtAmmount.Size = new System.Drawing.Size(150, 26);
            this.txtAmmount.TabIndex = 70;
            this.txtAmmount.Validating += new System.ComponentModel.CancelEventHandler(this.txtAmmount_Validating);
            // 
            // lblAmmount
            // 
            this.lblAmmount.AutoSize = true;
            this.lblAmmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmmount.ForeColor = System.Drawing.Color.White;
            this.lblAmmount.Location = new System.Drawing.Point(60, 170);
            this.lblAmmount.Name = "lblAmmount";
            this.lblAmmount.Size = new System.Drawing.Size(82, 20);
            this.lblAmmount.TabIndex = 71;
            this.lblAmmount.Text = "Ammount:";
            // 
            // txtRecepientName
            // 
            this.txtRecepientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRecepientName.Location = new System.Drawing.Point(540, 170);
            this.txtRecepientName.Name = "txtRecepientName";
            this.txtRecepientName.Size = new System.Drawing.Size(150, 26);
            this.txtRecepientName.TabIndex = 72;
            // 
            // lblRecepientName
            // 
            this.lblRecepientName.AutoSize = true;
            this.lblRecepientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecepientName.ForeColor = System.Drawing.Color.White;
            this.lblRecepientName.Location = new System.Drawing.Point(381, 173);
            this.lblRecepientName.Name = "lblRecepientName";
            this.lblRecepientName.Size = new System.Drawing.Size(132, 20);
            this.lblRecepientName.TabIndex = 73;
            this.lblRecepientName.Text = "Recepient Name:";
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.ForeColor = System.Drawing.SystemColors.Control;
            this.lblInfo.Location = new System.Drawing.Point(12, 9);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(136, 20);
            this.lblInfo.TabIndex = 74;
            this.lblInfo.Text = "Transfer Funds:";
            // 
            // btnExternalSource
            // 
            this.btnExternalSource.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExternalSource.Location = new System.Drawing.Point(173, 367);
            this.btnExternalSource.Name = "btnExternalSource";
            this.btnExternalSource.Size = new System.Drawing.Size(150, 31);
            this.btnExternalSource.TabIndex = 75;
            this.btnExternalSource.Text = "External Source";
            this.btnExternalSource.UseVisualStyleBackColor = true;
            this.btnExternalSource.Click += new System.EventHandler(this.btnExternalSource_Click);
            // 
            // errTransferAmmount
            // 
            this.errTransferAmmount.ContainerControl = this;
            // 
            // TransferFunds
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(88)))), ((int)(((byte)(149)))));
            this.ClientSize = new System.Drawing.Size(734, 462);
            this.Controls.Add(this.btnExternalSource);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.lblRecepientName);
            this.Controls.Add(this.txtRecepientName);
            this.Controls.Add(this.lblAmmount);
            this.Controls.Add(this.txtAmmount);
            this.Controls.Add(this.btnExternal);
            this.Controls.Add(this.btnInternal);
            this.Controls.Add(this.txtDestinationSortCode);
            this.Controls.Add(this.lblSortCode);
            this.Controls.Add(this.txtAccOutNumber);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblDestination);
            this.Controls.Add(this.rtfDescription);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblSource);
            this.Controls.Add(this.txtAccountNumber);
            this.Controls.Add(this.lblAccountNumber);
            this.Controls.Add(this.btnTransfer);
            this.Controls.Add(this.btnBack);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TransferFunds";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DBS Credit Union - Transfer Funds";
            this.Load += new System.EventHandler(this.TransferFunds_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errTransferAmmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnTransfer;
        private System.Windows.Forms.Label lblAccountNumber;
        private System.Windows.Forms.TextBox txtAccountNumber;
        private System.Windows.Forms.Label lblSource;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.RichTextBox rtfDescription;
        private System.Windows.Forms.Label lblDestination;
        private System.Windows.Forms.TextBox txtAccOutNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDestinationSortCode;
        private System.Windows.Forms.Label lblSortCode;
        private System.Windows.Forms.Button btnInternal;
        private System.Windows.Forms.Button btnExternal;
        private System.Windows.Forms.TextBox txtAmmount;
        private System.Windows.Forms.Label lblAmmount;
        private System.Windows.Forms.TextBox txtRecepientName;
        private System.Windows.Forms.Label lblRecepientName;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Button btnExternalSource;
        private System.Windows.Forms.ErrorProvider errTransferAmmount;
    }
}