namespace SlotMachine
{
    partial class Ticket
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tbDate = new System.Windows.Forms.Label();
            this.tbTime = new System.Windows.Forms.Label();
            this.tbAmount = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SlotMachine.Properties.Resources.tiket;
            this.pictureBox1.Location = new System.Drawing.Point(-1, -1);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(772, 345);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // tbDate
            // 
            this.tbDate.AutoSize = true;
            this.tbDate.BackColor = System.Drawing.Color.White;
            this.tbDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDate.ForeColor = System.Drawing.Color.Black;
            this.tbDate.Location = new System.Drawing.Point(220, 238);
            this.tbDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.tbDate.Name = "tbDate";
            this.tbDate.Size = new System.Drawing.Size(58, 22);
            this.tbDate.TabIndex = 2;
            this.tbDate.Text = "label1";
            this.tbDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbTime
            // 
            this.tbTime.AutoSize = true;
            this.tbTime.BackColor = System.Drawing.Color.White;
            this.tbTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTime.ForeColor = System.Drawing.Color.Black;
            this.tbTime.Location = new System.Drawing.Point(352, 238);
            this.tbTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.tbTime.Name = "tbTime";
            this.tbTime.Size = new System.Drawing.Size(58, 22);
            this.tbTime.TabIndex = 3;
            this.tbTime.Text = "label1";
            this.tbTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbAmount
            // 
            this.tbAmount.AutoSize = true;
            this.tbAmount.BackColor = System.Drawing.Color.White;
            this.tbAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAmount.ForeColor = System.Drawing.Color.Black;
            this.tbAmount.Location = new System.Drawing.Point(331, 276);
            this.tbAmount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.tbAmount.Name = "tbAmount";
            this.tbAmount.Size = new System.Drawing.Size(86, 31);
            this.tbAmount.TabIndex = 4;
            this.tbAmount.Text = "label1";
            this.tbAmount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(714, 323);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(58, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "PRINT";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Ticket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 343);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbAmount);
            this.Controls.Add(this.tbTime);
            this.Controls.Add(this.tbDate);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Ticket";
            this.Text = "Ticket";
            this.Load += new System.EventHandler(this.Ticket_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label tbDate;
        private System.Windows.Forms.Label tbTime;
        private System.Windows.Forms.Label tbAmount;
        private System.Windows.Forms.Button button1;
    }
}