
namespace ComplexForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Log_Butt = new System.Windows.Forms.Button();
            this.Complaint_list = new System.Windows.Forms.ListBox();
            this.txtTicket = new System.Windows.Forms.TextBox();
            this.txtDatePicker = new System.Windows.Forms.DateTimePicker();
            this.txtComplaint = new System.Windows.Forms.TextBox();
            this.txtType = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(248, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "Log Ticket";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ticket Number";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Complaint";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 336);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Type";
            // 
            // Log_Butt
            // 
            this.Log_Butt.Location = new System.Drawing.Point(176, 409);
            this.Log_Butt.Name = "Log_Butt";
            this.Log_Butt.Size = new System.Drawing.Size(94, 29);
            this.Log_Butt.TabIndex = 5;
            this.Log_Butt.Text = "LOG";
            this.Log_Butt.UseVisualStyleBackColor = true;
            // 
            // Complaint_list
            // 
            this.Complaint_list.FormattingEnabled = true;
            this.Complaint_list.ItemHeight = 20;
            this.Complaint_list.Location = new System.Drawing.Point(511, 102);
            this.Complaint_list.Name = "Complaint_list";
            this.Complaint_list.Size = new System.Drawing.Size(277, 244);
            this.Complaint_list.TabIndex = 6;
            // 
            // txtTicket
            // 
            this.txtTicket.Location = new System.Drawing.Point(209, 98);
            this.txtTicket.Name = "txtTicket";
            this.txtTicket.Size = new System.Drawing.Size(125, 27);
            this.txtTicket.TabIndex = 7;
            // 
            // txtDatePicker
            // 
            this.txtDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtDatePicker.Location = new System.Drawing.Point(209, 158);
            this.txtDatePicker.Name = "txtDatePicker";
            this.txtDatePicker.Size = new System.Drawing.Size(109, 27);
            this.txtDatePicker.TabIndex = 8;
            // 
            // txtComplaint
            // 
            this.txtComplaint.Location = new System.Drawing.Point(209, 221);
            this.txtComplaint.Multiline = true;
            this.txtComplaint.Name = "txtComplaint";
            this.txtComplaint.Size = new System.Drawing.Size(229, 75);
            this.txtComplaint.TabIndex = 9;
            // 
            // txtType
            // 
            this.txtType.Location = new System.Drawing.Point(209, 333);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(125, 27);
            this.txtType.TabIndex = 10;
            // 
            // Ticket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtType);
            this.Controls.Add(this.txtComplaint);
            this.Controls.Add(this.txtDatePicker);
            this.Controls.Add(this.txtTicket);
            this.Controls.Add(this.Complaint_list);
            this.Controls.Add(this.Log_Butt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Ticket";
            this.Text = "Ticket";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Log_Butt;
        private System.Windows.Forms.ListBox Complaint_list;
        private System.Windows.Forms.TextBox txtTicket;
        private System.Windows.Forms.DateTimePicker txtDatePicker;
        private System.Windows.Forms.TextBox txtComplaint;
        private System.Windows.Forms.TextBox txtType;
    }
}