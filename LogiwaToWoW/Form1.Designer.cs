
namespace LogiwaToWoW
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtAPI = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAuthorization = new System.Windows.Forms.TextBox();
            this.txtContentType = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBody = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMethod = new System.Windows.Forms.TextBox();
            this.btnExecute = new System.Windows.Forms.Button();
            this.txtWriteTo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFolderToMerge = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMergedFile = new System.Windows.Forms.TextBox();
            this.btnMergeJSON = new System.Windows.Forms.Button();
            this.lstFiles = new System.Windows.Forms.ListBox();
            this.btnLoadFiles = new System.Windows.Forms.Button();
            this.btnCondenseFiles = new System.Windows.Forms.Button();
            this.lstContract = new System.Windows.Forms.ListBox();
            this.lstContractPeriod = new System.Windows.Forms.ListBox();
            this.cmbAPIToCall = new System.Windows.Forms.ComboBox();
            this.lstBadDBInserts = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lstTransactionHistoryStart = new System.Windows.Forms.ListBox();
            this.lstTransactionHistoryEnd = new System.Windows.Forms.ListBox();
            this.txtConnectionString = new System.Windows.Forms.TextBox();
            this.btnTranHistExecute = new System.Windows.Forms.Button();
            this.txtGrant_Type = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnParallelExecute = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtAPI
            // 
            this.txtAPI.Location = new System.Drawing.Point(45, 22);
            this.txtAPI.Name = "txtAPI";
            this.txtAPI.Size = new System.Drawing.Size(618, 20);
            this.txtAPI.TabIndex = 0;
            this.txtAPI.Text = "https://<app>.logiwa.com/en/api/IntegrationApi/TransactionHistoryReportSearch\r\n";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "API:";
            // 
            // txtAuthorization
            // 
            this.txtAuthorization.Location = new System.Drawing.Point(45, 83);
            this.txtAuthorization.Multiline = true;
            this.txtAuthorization.Name = "txtAuthorization";
            this.txtAuthorization.Size = new System.Drawing.Size(618, 113);
            this.txtAuthorization.TabIndex = 2;
            this.txtAuthorization.Text = resources.GetString("txtAuthorization.Text");
            // 
            // txtContentType
            // 
            this.txtContentType.Location = new System.Drawing.Point(45, 202);
            this.txtContentType.Name = "txtContentType";
            this.txtContentType.Size = new System.Drawing.Size(128, 20);
            this.txtContentType.TabIndex = 3;
            this.txtContentType.Text = "application/json";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 237);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Body:";
            // 
            // txtBody
            // 
            this.txtBody.Location = new System.Drawing.Point(45, 237);
            this.txtBody.Multiline = true;
            this.txtBody.Name = "txtBody";
            this.txtBody.Size = new System.Drawing.Size(398, 173);
            this.txtBody.TabIndex = 5;
            this.txtBody.Text = "{\r\n\"EntryDateTime_Start\" : \"01.01.2021 00:00:00\",\r\n\"EntryDateTime_End\" : \"03.01.2" +
    "021 23:59:59\",\r\n\"PageSize\": 200,\r\n\"SelectedPageIndex\": 17455\r\n}";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Method:";
            // 
            // txtMethod
            // 
            this.txtMethod.Location = new System.Drawing.Point(45, 54);
            this.txtMethod.Name = "txtMethod";
            this.txtMethod.Size = new System.Drawing.Size(47, 20);
            this.txtMethod.TabIndex = 7;
            this.txtMethod.Text = "POST";
            // 
            // btnExecute
            // 
            this.btnExecute.Location = new System.Drawing.Point(98, 52);
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Size = new System.Drawing.Size(75, 23);
            this.btnExecute.TabIndex = 8;
            this.btnExecute.Text = "Execute";
            this.btnExecute.UseVisualStyleBackColor = true;
            this.btnExecute.Click += new System.EventHandler(this.btnExecute_Click);
            // 
            // txtWriteTo
            // 
            this.txtWriteTo.Location = new System.Drawing.Point(61, 615);
            this.txtWriteTo.Name = "txtWriteTo";
            this.txtWriteTo.Size = new System.Drawing.Size(456, 20);
            this.txtWriteTo.TabIndex = 9;
            this.txtWriteTo.Text = "C:\\Logiwa\\ContractBilling\\";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 618);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Write to:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 638);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(655, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = resources.GetString("label5.Text");
            // 
            // txtFolderToMerge
            // 
            this.txtFolderToMerge.Location = new System.Drawing.Point(84, 664);
            this.txtFolderToMerge.Name = "txtFolderToMerge";
            this.txtFolderToMerge.Size = new System.Drawing.Size(293, 20);
            this.txtFolderToMerge.TabIndex = 12;
            this.txtFolderToMerge.Text = "C:\\Logiwa\\ListOrders";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 667);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Folder to merge:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 706);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Folder into:";
            // 
            // txtMergedFile
            // 
            this.txtMergedFile.Location = new System.Drawing.Point(61, 703);
            this.txtMergedFile.Name = "txtMergedFile";
            this.txtMergedFile.Size = new System.Drawing.Size(316, 20);
            this.txtMergedFile.TabIndex = 14;
            this.txtMergedFile.Text = "C:\\Logiwa\\ListOrders\\Merged\\ListOrders.json\r\n";
            // 
            // btnMergeJSON
            // 
            this.btnMergeJSON.Enabled = false;
            this.btnMergeJSON.Location = new System.Drawing.Point(383, 661);
            this.btnMergeJSON.Name = "btnMergeJSON";
            this.btnMergeJSON.Size = new System.Drawing.Size(84, 23);
            this.btnMergeJSON.TabIndex = 16;
            this.btnMergeJSON.Text = "Merge JSON";
            this.btnMergeJSON.UseVisualStyleBackColor = true;
            this.btnMergeJSON.Click += new System.EventHandler(this.btnMergeJSON_Click);
            // 
            // lstFiles
            // 
            this.lstFiles.FormattingEnabled = true;
            this.lstFiles.Location = new System.Drawing.Point(8, 765);
            this.lstFiles.Name = "lstFiles";
            this.lstFiles.Size = new System.Drawing.Size(301, 43);
            this.lstFiles.Sorted = true;
            this.lstFiles.TabIndex = 17;
            // 
            // btnLoadFiles
            // 
            this.btnLoadFiles.Location = new System.Drawing.Point(8, 736);
            this.btnLoadFiles.Name = "btnLoadFiles";
            this.btnLoadFiles.Size = new System.Drawing.Size(63, 23);
            this.btnLoadFiles.TabIndex = 18;
            this.btnLoadFiles.Text = "Load Files";
            this.btnLoadFiles.UseVisualStyleBackColor = true;
            this.btnLoadFiles.Click += new System.EventHandler(this.btnLoadFiles_Click);
            // 
            // btnCondenseFiles
            // 
            this.btnCondenseFiles.Enabled = false;
            this.btnCondenseFiles.Location = new System.Drawing.Point(77, 736);
            this.btnCondenseFiles.Name = "btnCondenseFiles";
            this.btnCondenseFiles.Size = new System.Drawing.Size(93, 23);
            this.btnCondenseFiles.TabIndex = 20;
            this.btnCondenseFiles.Text = "Condense Files";
            this.btnCondenseFiles.UseVisualStyleBackColor = true;
            this.btnCondenseFiles.Click += new System.EventHandler(this.btnCondenseFiles_Click);
            // 
            // lstContract
            // 
            this.lstContract.FormattingEnabled = true;
            this.lstContract.Location = new System.Drawing.Point(513, 235);
            this.lstContract.Name = "lstContract";
            this.lstContract.Size = new System.Drawing.Size(164, 264);
            this.lstContract.TabIndex = 21;
            // 
            // lstContractPeriod
            // 
            this.lstContractPeriod.FormattingEnabled = true;
            this.lstContractPeriod.Location = new System.Drawing.Point(683, 235);
            this.lstContractPeriod.Name = "lstContractPeriod";
            this.lstContractPeriod.Size = new System.Drawing.Size(184, 264);
            this.lstContractPeriod.TabIndex = 22;
            // 
            // cmbAPIToCall
            // 
            this.cmbAPIToCall.FormattingEnabled = true;
            this.cmbAPIToCall.Location = new System.Drawing.Point(215, 202);
            this.cmbAPIToCall.Name = "cmbAPIToCall";
            this.cmbAPIToCall.Size = new System.Drawing.Size(228, 21);
            this.cmbAPIToCall.TabIndex = 23;
            // 
            // lstBadDBInserts
            // 
            this.lstBadDBInserts.FormattingEnabled = true;
            this.lstBadDBInserts.Location = new System.Drawing.Point(873, 43);
            this.lstBadDBInserts.Name = "lstBadDBInserts";
            this.lstBadDBInserts.Size = new System.Drawing.Size(370, 186);
            this.lstBadDBInserts.TabIndex = 24;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(870, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 13);
            this.label8.TabIndex = 25;
            this.label8.Text = "Bad DB Inserts:";
            // 
            // lstTransactionHistoryStart
            // 
            this.lstTransactionHistoryStart.FormattingEnabled = true;
            this.lstTransactionHistoryStart.Location = new System.Drawing.Point(873, 235);
            this.lstTransactionHistoryStart.Name = "lstTransactionHistoryStart";
            this.lstTransactionHistoryStart.Size = new System.Drawing.Size(177, 264);
            this.lstTransactionHistoryStart.TabIndex = 26;
            // 
            // lstTransactionHistoryEnd
            // 
            this.lstTransactionHistoryEnd.FormattingEnabled = true;
            this.lstTransactionHistoryEnd.Location = new System.Drawing.Point(1056, 235);
            this.lstTransactionHistoryEnd.Name = "lstTransactionHistoryEnd";
            this.lstTransactionHistoryEnd.Size = new System.Drawing.Size(187, 264);
            this.lstTransactionHistoryEnd.TabIndex = 27;
            // 
            // txtConnectionString
            // 
            this.txtConnectionString.Location = new System.Drawing.Point(179, 54);
            this.txtConnectionString.Name = "txtConnectionString";
            this.txtConnectionString.Size = new System.Drawing.Size(562, 20);
            this.txtConnectionString.TabIndex = 28;
            this.txtConnectionString.Text = "Data Source=<server>;Initial Catalog=<database>;User ID=<user>;Password=<password" +
    ">";
            // 
            // btnTranHistExecute
            // 
            this.btnTranHistExecute.Enabled = false;
            this.btnTranHistExecute.Location = new System.Drawing.Point(701, 618);
            this.btnTranHistExecute.Name = "btnTranHistExecute";
            this.btnTranHistExecute.Size = new System.Drawing.Size(105, 23);
            this.btnTranHistExecute.TabIndex = 29;
            this.btnTranHistExecute.Text = "Tran Hist Execute";
            this.btnTranHistExecute.UseVisualStyleBackColor = true;
            this.btnTranHistExecute.Click += new System.EventHandler(this.btnTranHistExecute_Click);
            // 
            // txtGrant_Type
            // 
            this.txtGrant_Type.Location = new System.Drawing.Point(670, 122);
            this.txtGrant_Type.Name = "txtGrant_Type";
            this.txtGrant_Type.Size = new System.Drawing.Size(197, 20);
            this.txtGrant_Type.TabIndex = 30;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(669, 148);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(197, 20);
            this.txtUsername.TabIndex = 31;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(669, 174);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(197, 20);
            this.txtPassword.TabIndex = 32;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(669, 106);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 13);
            this.label9.TabIndex = 33;
            this.label9.Text = "Info to get new token:";
            // 
            // btnParallelExecute
            // 
            this.btnParallelExecute.Enabled = false;
            this.btnParallelExecute.Location = new System.Drawing.Point(672, 18);
            this.btnParallelExecute.Name = "btnParallelExecute";
            this.btnParallelExecute.Size = new System.Drawing.Size(108, 26);
            this.btnParallelExecute.TabIndex = 34;
            this.btnParallelExecute.Text = "Parallel Execute";
            this.btnParallelExecute.UseVisualStyleBackColor = true;
            this.btnParallelExecute.Click += new System.EventHandler(this.btnParallelExecute_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1299, 508);
            this.Controls.Add(this.btnParallelExecute);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.txtGrant_Type);
            this.Controls.Add(this.btnTranHistExecute);
            this.Controls.Add(this.txtConnectionString);
            this.Controls.Add(this.lstTransactionHistoryEnd);
            this.Controls.Add(this.lstTransactionHistoryStart);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lstBadDBInserts);
            this.Controls.Add(this.cmbAPIToCall);
            this.Controls.Add(this.lstContractPeriod);
            this.Controls.Add(this.lstContract);
            this.Controls.Add(this.btnCondenseFiles);
            this.Controls.Add(this.btnLoadFiles);
            this.Controls.Add(this.lstFiles);
            this.Controls.Add(this.btnMergeJSON);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtMergedFile);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtFolderToMerge);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtWriteTo);
            this.Controls.Add(this.btnExecute);
            this.Controls.Add(this.txtMethod);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBody);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtContentType);
            this.Controls.Add(this.txtAuthorization);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAPI);
            this.Name = "Form1";
            this.Text = "API SelectedPageIndex backwards";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAPI;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAuthorization;
        private System.Windows.Forms.TextBox txtContentType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBody;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMethod;
        private System.Windows.Forms.Button btnExecute;
        private System.Windows.Forms.TextBox txtWriteTo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtFolderToMerge;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMergedFile;
        private System.Windows.Forms.Button btnMergeJSON;
        private System.Windows.Forms.ListBox lstFiles;
        private System.Windows.Forms.Button btnLoadFiles;
        private System.Windows.Forms.Button btnCondenseFiles;
        private System.Windows.Forms.ListBox lstContract;
        private System.Windows.Forms.ListBox lstContractPeriod;
        private System.Windows.Forms.ComboBox cmbAPIToCall;
        private System.Windows.Forms.ListBox lstBadDBInserts;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox lstTransactionHistoryStart;
        private System.Windows.Forms.ListBox lstTransactionHistoryEnd;
        private System.Windows.Forms.TextBox txtConnectionString;
        private System.Windows.Forms.Button btnTranHistExecute;
        private System.Windows.Forms.TextBox txtGrant_Type;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnParallelExecute;
    }
}

