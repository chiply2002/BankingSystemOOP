
namespace BankSystem
{
    partial class Payment
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
            this.confirm = new System.Windows.Forms.Button();
            this.money = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // confirm
            // 
            this.confirm.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.confirm.Location = new System.Drawing.Point(30, 103);
            this.confirm.Name = "confirm";
            this.confirm.Size = new System.Drawing.Size(95, 29);
            this.confirm.TabIndex = 0;
            this.confirm.Text = "OK";
            this.confirm.UseVisualStyleBackColor = true;
            this.confirm.Click += new System.EventHandler(this.confirm_Click);
            // 
            // money
            // 
            this.money.Location = new System.Drawing.Point(31, 56);
            this.money.Name = "money";
            this.money.Size = new System.Drawing.Size(312, 27);
            this.money.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(25, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Enter Money :";
            // 
            // cancel
            // 
            this.cancel.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cancel.Location = new System.Drawing.Point(248, 103);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(95, 29);
            this.cancel.TabIndex = 4;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(382, 153);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.money);
            this.Controls.Add(this.confirm);
            this.Name = "Payment";
            this.Text = "Payment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button confirm;
        private System.Windows.Forms.TextBox money;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cancel;
    }
}