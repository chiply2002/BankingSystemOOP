
namespace BankSystem
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.myId = new System.Windows.Forms.Label();
            this.myName = new System.Windows.Forms.Label();
            this.list = new System.Windows.Forms.ListBox();
            this.registerTable = new System.Windows.Forms.TableLayoutPanel();
            this.name = new System.Windows.Forms.TextBox();
            this.age = new System.Windows.Forms.TextBox();
            this.accType = new System.Windows.Forms.ComboBox();
            this.password = new System.Windows.Forms.TextBox();
            this.amount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.register = new System.Windows.Forms.Button();
            this.login = new System.Windows.Forms.Button();
            this.deposit = new System.Windows.Forms.Button();
            this.withdraw = new System.Windows.Forms.Button();
            this.showAccounts = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.loginTable = new System.Windows.Forms.TableLayoutPanel();
            this.logID = new System.Windows.Forms.TextBox();
            this.myPass = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.infoTable = new System.Windows.Forms.TableLayoutPanel();
            this.myAge = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.myAmount = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.myAccType = new System.Windows.Forms.Label();
            this.registerAgain = new System.Windows.Forms.Button();
            this.login2 = new System.Windows.Forms.Button();
            this.contact = new System.Windows.Forms.Button();
            this.aboutUs = new System.Windows.Forms.Button();
            this.logout = new System.Windows.Forms.Button();
            this.contact2 = new System.Windows.Forms.Button();
            this.aboutUs2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.registerTable.SuspendLayout();
            this.loginTable.SuspendLayout();
            this.infoTable.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(758, 167);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // myId
            // 
            this.myId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.myId.AutoSize = true;
            this.myId.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.myId.Location = new System.Drawing.Point(320, 11);
            this.myId.Name = "myId";
            this.myId.Size = new System.Drawing.Size(59, 25);
            this.myId.TabIndex = 7;
            this.myId.Text = "label1";
            // 
            // myName
            // 
            this.myName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.myName.AutoSize = true;
            this.myName.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.myName.Location = new System.Drawing.Point(320, 58);
            this.myName.Name = "myName";
            this.myName.Size = new System.Drawing.Size(59, 25);
            this.myName.TabIndex = 8;
            this.myName.Text = "label2";
            // 
            // list
            // 
            this.list.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.list.FormattingEnabled = true;
            this.list.ItemHeight = 20;
            this.list.Location = new System.Drawing.Point(32, 456);
            this.list.Name = "list";
            this.list.Size = new System.Drawing.Size(466, 104);
            this.list.TabIndex = 18;
            // 
            // registerTable
            // 
            this.registerTable.ColumnCount = 2;
            this.registerTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.registerTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.registerTable.Controls.Add(this.name, 1, 0);
            this.registerTable.Controls.Add(this.age, 1, 1);
            this.registerTable.Controls.Add(this.accType, 1, 2);
            this.registerTable.Controls.Add(this.password, 1, 3);
            this.registerTable.Controls.Add(this.amount, 1, 4);
            this.registerTable.Controls.Add(this.label1, 0, 0);
            this.registerTable.Controls.Add(this.label2, 0, 1);
            this.registerTable.Controls.Add(this.label3, 0, 2);
            this.registerTable.Controls.Add(this.label4, 0, 3);
            this.registerTable.Controls.Add(this.label5, 0, 4);
            this.registerTable.Location = new System.Drawing.Point(32, 196);
            this.registerTable.Name = "registerTable";
            this.registerTable.RowCount = 5;
            this.registerTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.registerTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.registerTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.registerTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.registerTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.registerTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.registerTable.Size = new System.Drawing.Size(466, 364);
            this.registerTable.TabIndex = 21;
            // 
            // name
            // 
            this.name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.name.Location = new System.Drawing.Point(236, 22);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(227, 27);
            this.name.TabIndex = 21;
            // 
            // age
            // 
            this.age.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.age.Location = new System.Drawing.Point(236, 94);
            this.age.Name = "age";
            this.age.Size = new System.Drawing.Size(227, 27);
            this.age.TabIndex = 22;
            // 
            // accType
            // 
            this.accType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.accType.FormattingEnabled = true;
            this.accType.Items.AddRange(new object[] {
            "Credit",
            "Debit",
            "Saving"});
            this.accType.Location = new System.Drawing.Point(236, 166);
            this.accType.Name = "accType";
            this.accType.Size = new System.Drawing.Size(227, 28);
            this.accType.TabIndex = 24;
            // 
            // password
            // 
            this.password.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.password.Location = new System.Drawing.Point(236, 238);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(227, 27);
            this.password.TabIndex = 25;
            // 
            // amount
            // 
            this.amount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.amount.Location = new System.Drawing.Point(236, 312);
            this.amount.Name = "amount";
            this.amount.Size = new System.Drawing.Size(227, 27);
            this.amount.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(81, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 25);
            this.label1.TabIndex = 27;
            this.label1.Text = "Name :";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(89, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 25);
            this.label2.TabIndex = 28;
            this.label2.Text = "Age :";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(50, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 25);
            this.label3.TabIndex = 29;
            this.label3.Text = "Account Type :";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(67, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 25);
            this.label4.TabIndex = 30;
            this.label4.Text = "Password :";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(72, 313);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 25);
            this.label5.TabIndex = 31;
            this.label5.Text = "Amount :";
            // 
            // register
            // 
            this.register.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.register.Location = new System.Drawing.Point(559, 196);
            this.register.Name = "register";
            this.register.Size = new System.Drawing.Size(187, 68);
            this.register.TabIndex = 22;
            this.register.Text = "Register";
            this.register.UseVisualStyleBackColor = true;
            this.register.Click += new System.EventHandler(this.register_Click);
            // 
            // login
            // 
            this.login.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.login.Location = new System.Drawing.Point(559, 270);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(187, 68);
            this.login.TabIndex = 23;
            this.login.Text = "Log In";
            this.login.UseVisualStyleBackColor = true;
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // deposit
            // 
            this.deposit.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.deposit.Location = new System.Drawing.Point(559, 270);
            this.deposit.Name = "deposit";
            this.deposit.Size = new System.Drawing.Size(187, 68);
            this.deposit.TabIndex = 24;
            this.deposit.Text = "Deposit";
            this.deposit.UseVisualStyleBackColor = true;
            this.deposit.Click += new System.EventHandler(this.deposit_Click);
            // 
            // withdraw
            // 
            this.withdraw.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.withdraw.Location = new System.Drawing.Point(559, 344);
            this.withdraw.Name = "withdraw";
            this.withdraw.Size = new System.Drawing.Size(187, 68);
            this.withdraw.TabIndex = 25;
            this.withdraw.Text = "Withdraw";
            this.withdraw.UseVisualStyleBackColor = true;
            this.withdraw.Click += new System.EventHandler(this.withdraw_Click);
            // 
            // showAccounts
            // 
            this.showAccounts.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.showAccounts.Location = new System.Drawing.Point(559, 418);
            this.showAccounts.Name = "showAccounts";
            this.showAccounts.Size = new System.Drawing.Size(187, 68);
            this.showAccounts.TabIndex = 26;
            this.showAccounts.Text = "Show Account";
            this.showAccounts.UseVisualStyleBackColor = true;
            this.showAccounts.Click += new System.EventHandler(this.showAccounts_Click);
            // 
            // exit
            // 
            this.exit.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.exit.Location = new System.Drawing.Point(559, 492);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(187, 68);
            this.exit.TabIndex = 27;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // loginTable
            // 
            this.loginTable.ColumnCount = 2;
            this.loginTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.loginTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.loginTable.Controls.Add(this.logID, 1, 0);
            this.loginTable.Controls.Add(this.myPass, 1, 1);
            this.loginTable.Controls.Add(this.label6, 0, 0);
            this.loginTable.Controls.Add(this.label7, 0, 1);
            this.loginTable.Location = new System.Drawing.Point(32, 225);
            this.loginTable.Name = "loginTable";
            this.loginTable.RowCount = 2;
            this.loginTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.loginTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.loginTable.Size = new System.Drawing.Size(466, 130);
            this.loginTable.TabIndex = 28;
            // 
            // logID
            // 
            this.logID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.logID.Location = new System.Drawing.Point(236, 19);
            this.logID.Name = "logID";
            this.logID.Size = new System.Drawing.Size(227, 27);
            this.logID.TabIndex = 7;
            // 
            // myPass
            // 
            this.myPass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.myPass.Location = new System.Drawing.Point(236, 84);
            this.myPass.Name = "myPass";
            this.myPass.Size = new System.Drawing.Size(227, 27);
            this.myPass.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(60, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 25);
            this.label6.TabIndex = 17;
            this.label6.Text = "Account ID :";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(67, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 25);
            this.label7.TabIndex = 18;
            this.label7.Text = "Password :";
            // 
            // infoTable
            // 
            this.infoTable.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.infoTable.ColumnCount = 2;
            this.infoTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.infoTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.infoTable.Controls.Add(this.myAge, 1, 2);
            this.infoTable.Controls.Add(this.label12, 0, 4);
            this.infoTable.Controls.Add(this.myAmount, 0, 4);
            this.infoTable.Controls.Add(this.myId, 1, 0);
            this.infoTable.Controls.Add(this.myName, 1, 1);
            this.infoTable.Controls.Add(this.label8, 0, 0);
            this.infoTable.Controls.Add(this.label9, 0, 1);
            this.infoTable.Controls.Add(this.label10, 0, 2);
            this.infoTable.Controls.Add(this.label11, 0, 3);
            this.infoTable.Controls.Add(this.myAccType, 1, 3);
            this.infoTable.Location = new System.Drawing.Point(32, 197);
            this.infoTable.Name = "infoTable";
            this.infoTable.RowCount = 5;
            this.infoTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.infoTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.infoTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.infoTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.infoTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.infoTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.infoTable.Size = new System.Drawing.Size(466, 236);
            this.infoTable.TabIndex = 29;
            // 
            // myAge
            // 
            this.myAge.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.myAge.AutoSize = true;
            this.myAge.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.myAge.Location = new System.Drawing.Point(320, 105);
            this.myAge.Name = "myAge";
            this.myAge.Size = new System.Drawing.Size(59, 25);
            this.myAge.TabIndex = 20;
            this.myAge.Text = "label3";
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(72, 199);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(89, 25);
            this.label12.TabIndex = 22;
            this.label12.Text = "Amount :";
            // 
            // myAmount
            // 
            this.myAmount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.myAmount.AutoSize = true;
            this.myAmount.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.myAmount.Location = new System.Drawing.Point(320, 199);
            this.myAmount.Name = "myAmount";
            this.myAmount.Size = new System.Drawing.Size(59, 25);
            this.myAmount.TabIndex = 21;
            this.myAmount.Text = "label1";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(60, 11);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 25);
            this.label8.TabIndex = 13;
            this.label8.Text = "Account ID :";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(81, 58);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 25);
            this.label9.TabIndex = 14;
            this.label9.Text = "Name :";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(89, 105);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 25);
            this.label10.TabIndex = 15;
            this.label10.Text = "Age :";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(50, 152);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(133, 25);
            this.label11.TabIndex = 16;
            this.label11.Text = "Account Type :";
            // 
            // myAccType
            // 
            this.myAccType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.myAccType.AutoSize = true;
            this.myAccType.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.myAccType.Location = new System.Drawing.Point(320, 152);
            this.myAccType.Name = "myAccType";
            this.myAccType.Size = new System.Drawing.Size(59, 25);
            this.myAccType.TabIndex = 18;
            this.myAccType.Text = "label4";
            // 
            // registerAgain
            // 
            this.registerAgain.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.registerAgain.Location = new System.Drawing.Point(559, 196);
            this.registerAgain.Name = "registerAgain";
            this.registerAgain.Size = new System.Drawing.Size(187, 68);
            this.registerAgain.TabIndex = 30;
            this.registerAgain.Text = "Register";
            this.registerAgain.UseVisualStyleBackColor = true;
            this.registerAgain.Click += new System.EventHandler(this.registerAgain_Click);
            // 
            // login2
            // 
            this.login2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.login2.Location = new System.Drawing.Point(559, 270);
            this.login2.Name = "login2";
            this.login2.Size = new System.Drawing.Size(187, 68);
            this.login2.TabIndex = 31;
            this.login2.Text = "Log In";
            this.login2.UseVisualStyleBackColor = true;
            this.login2.Click += new System.EventHandler(this.login2_Click);
            // 
            // contact
            // 
            this.contact.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.contact.Location = new System.Drawing.Point(559, 297);
            this.contact.Name = "contact";
            this.contact.Size = new System.Drawing.Size(187, 68);
            this.contact.TabIndex = 32;
            this.contact.Text = "Contact";
            this.contact.UseVisualStyleBackColor = true;
            this.contact.Click += new System.EventHandler(this.contact_Click);
            // 
            // aboutUs
            // 
            this.aboutUs.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.aboutUs.Location = new System.Drawing.Point(559, 396);
            this.aboutUs.Name = "aboutUs";
            this.aboutUs.Size = new System.Drawing.Size(187, 68);
            this.aboutUs.TabIndex = 33;
            this.aboutUs.Text = "About Us";
            this.aboutUs.UseVisualStyleBackColor = true;
            this.aboutUs.Click += new System.EventHandler(this.aboutUs_Click);
            // 
            // logout
            // 
            this.logout.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.logout.Location = new System.Drawing.Point(559, 196);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(187, 68);
            this.logout.TabIndex = 34;
            this.logout.Text = "Log Out";
            this.logout.UseVisualStyleBackColor = true;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // contact2
            // 
            this.contact2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.contact2.Location = new System.Drawing.Point(559, 344);
            this.contact2.Name = "contact2";
            this.contact2.Size = new System.Drawing.Size(187, 68);
            this.contact2.TabIndex = 35;
            this.contact2.Text = "Contact";
            this.contact2.UseVisualStyleBackColor = true;
            this.contact2.Click += new System.EventHandler(this.contact2_Click);
            // 
            // aboutUs2
            // 
            this.aboutUs2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.aboutUs2.Location = new System.Drawing.Point(559, 417);
            this.aboutUs2.Name = "aboutUs2";
            this.aboutUs2.Size = new System.Drawing.Size(187, 68);
            this.aboutUs2.TabIndex = 36;
            this.aboutUs2.Text = "About Us";
            this.aboutUs2.UseVisualStyleBackColor = true;
            this.aboutUs2.Click += new System.EventHandler(this.aboutUs2_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(782, 573);
            this.Controls.Add(this.aboutUs2);
            this.Controls.Add(this.contact2);
            this.Controls.Add(this.withdraw);
            this.Controls.Add(this.logout);
            this.Controls.Add(this.aboutUs);
            this.Controls.Add(this.login2);
            this.Controls.Add(this.registerAgain);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.showAccounts);
            this.Controls.Add(this.deposit);
            this.Controls.Add(this.login);
            this.Controls.Add(this.register);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.registerTable);
            this.Controls.Add(this.infoTable);
            this.Controls.Add(this.loginTable);
            this.Controls.Add(this.list);
            this.Controls.Add(this.contact);
            this.Name = "Main";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.registerTable.ResumeLayout(false);
            this.registerTable.PerformLayout();
            this.loginTable.ResumeLayout(false);
            this.loginTable.PerformLayout();
            this.infoTable.ResumeLayout(false);
            this.infoTable.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label myId;
        private System.Windows.Forms.Label myName;
        private System.Windows.Forms.ListBox list;
        private System.Windows.Forms.TableLayoutPanel registerTable;
        private System.Windows.Forms.Button register;
        private System.Windows.Forms.Button login;
        private System.Windows.Forms.Button deposit;
        private System.Windows.Forms.Button withdraw;
        private System.Windows.Forms.Button showAccounts;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox age;
        private System.Windows.Forms.ComboBox accType;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox amount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TableLayoutPanel loginTable;
        private System.Windows.Forms.TextBox logID;
        private System.Windows.Forms.TextBox myPass;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TableLayoutPanel infoTable;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button registerAgain;
        private System.Windows.Forms.Button login2;
        private System.Windows.Forms.Label myAccType;
        private System.Windows.Forms.Label myAge;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label myAmount;
        private System.Windows.Forms.Button contact;
        private System.Windows.Forms.Button aboutUs;
        private System.Windows.Forms.Button logout;
        private System.Windows.Forms.Button contact2;
        private System.Windows.Forms.Button aboutUs2;
    }
}

