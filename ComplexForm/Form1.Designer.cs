
namespace ComplexForm
{
    partial class Form1
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
            this.Panel_Menu = new System.Windows.Forms.Panel();
            this.Ticket_Butt = new FontAwesome.Sharp.IconButton();
            this.AddressButt = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Panel_TitleBar = new System.Windows.Forms.Panel();
            this.lblTitleCurrentForm = new System.Windows.Forms.Label();
            this.IconCurrentForm = new FontAwesome.Sharp.IconPictureBox();
            this.PanelShadow = new System.Windows.Forms.Panel();
            this.DesktopPanel = new System.Windows.Forms.Panel();
            this.Panel_Menu.SuspendLayout();
            this.Panel_TitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconCurrentForm)).BeginInit();
            this.SuspendLayout();
            // 
            // Panel_Menu
            // 
            this.Panel_Menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.Panel_Menu.Controls.Add(this.Ticket_Butt);
            this.Panel_Menu.Controls.Add(this.AddressButt);
            this.Panel_Menu.Controls.Add(this.panel1);
            this.Panel_Menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.Panel_Menu.Location = new System.Drawing.Point(0, 0);
            this.Panel_Menu.Name = "Panel_Menu";
            this.Panel_Menu.Size = new System.Drawing.Size(241, 596);
            this.Panel_Menu.TabIndex = 0;
            // 
            // Ticket_Butt
            // 
            this.Ticket_Butt.Dock = System.Windows.Forms.DockStyle.Top;
            this.Ticket_Butt.FlatAppearance.BorderSize = 0;
            this.Ticket_Butt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Ticket_Butt.ForeColor = System.Drawing.Color.Gainsboro;
            this.Ticket_Butt.IconChar = FontAwesome.Sharp.IconChar.TicketAlt;
            this.Ticket_Butt.IconColor = System.Drawing.Color.Gainsboro;
            this.Ticket_Butt.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Ticket_Butt.IconSize = 32;
            this.Ticket_Butt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Ticket_Butt.Location = new System.Drawing.Point(0, 170);
            this.Ticket_Butt.Name = "Ticket_Butt";
            this.Ticket_Butt.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.Ticket_Butt.Size = new System.Drawing.Size(241, 60);
            this.Ticket_Butt.TabIndex = 2;
            this.Ticket_Butt.Text = "Log Tciket";
            this.Ticket_Butt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Ticket_Butt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Ticket_Butt.UseVisualStyleBackColor = true;
            this.Ticket_Butt.Click += new System.EventHandler(this.Ticket_Butt_Click);
            // 
            // AddressButt
            // 
            this.AddressButt.Dock = System.Windows.Forms.DockStyle.Top;
            this.AddressButt.FlatAppearance.BorderSize = 0;
            this.AddressButt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddressButt.ForeColor = System.Drawing.Color.Gainsboro;
            this.AddressButt.IconChar = FontAwesome.Sharp.IconChar.AddressCard;
            this.AddressButt.IconColor = System.Drawing.Color.Gainsboro;
            this.AddressButt.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.AddressButt.IconSize = 32;
            this.AddressButt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddressButt.Location = new System.Drawing.Point(0, 110);
            this.AddressButt.Name = "AddressButt";
            this.AddressButt.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.AddressButt.Size = new System.Drawing.Size(241, 60);
            this.AddressButt.TabIndex = 1;
            this.AddressButt.Text = "Owner Details";
            this.AddressButt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddressButt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AddressButt.UseVisualStyleBackColor = true;
            this.AddressButt.Click += new System.EventHandler(this.AddressButt_Click);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(241, 110);
            this.panel1.TabIndex = 0;
            // 
            // Panel_TitleBar
            // 
            this.Panel_TitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.Panel_TitleBar.Controls.Add(this.lblTitleCurrentForm);
            this.Panel_TitleBar.Controls.Add(this.IconCurrentForm);
            this.Panel_TitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel_TitleBar.Location = new System.Drawing.Point(241, 0);
            this.Panel_TitleBar.Name = "Panel_TitleBar";
            this.Panel_TitleBar.Size = new System.Drawing.Size(907, 80);
            this.Panel_TitleBar.TabIndex = 1;
            this.Panel_TitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel_TitleBar_MouseDown);
            // 
            // lblTitleCurrentForm
            // 
            this.lblTitleCurrentForm.AutoSize = true;
            this.lblTitleCurrentForm.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblTitleCurrentForm.Location = new System.Drawing.Point(138, 35);
            this.lblTitleCurrentForm.Name = "lblTitleCurrentForm";
            this.lblTitleCurrentForm.Size = new System.Drawing.Size(50, 20);
            this.lblTitleCurrentForm.TabIndex = 1;
            this.lblTitleCurrentForm.Text = "Home";
            // 
            // IconCurrentForm
            // 
            this.IconCurrentForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.IconCurrentForm.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.IconCurrentForm.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.IconCurrentForm.IconColor = System.Drawing.SystemColors.ButtonHighlight;
            this.IconCurrentForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IconCurrentForm.IconSize = 40;
            this.IconCurrentForm.Location = new System.Drawing.Point(28, 25);
            this.IconCurrentForm.Name = "IconCurrentForm";
            this.IconCurrentForm.Size = new System.Drawing.Size(40, 40);
            this.IconCurrentForm.TabIndex = 0;
            this.IconCurrentForm.TabStop = false;
            // 
            // PanelShadow
            // 
            this.PanelShadow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(58)))));
            this.PanelShadow.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelShadow.Location = new System.Drawing.Point(241, 80);
            this.PanelShadow.Name = "PanelShadow";
            this.PanelShadow.Size = new System.Drawing.Size(907, 9);
            this.PanelShadow.TabIndex = 2;
            // 
            // DesktopPanel
            // 
            this.DesktopPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.DesktopPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DesktopPanel.Location = new System.Drawing.Point(241, 89);
            this.DesktopPanel.Name = "DesktopPanel";
            this.DesktopPanel.Size = new System.Drawing.Size(907, 507);
            this.DesktopPanel.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1148, 596);
            this.Controls.Add(this.DesktopPanel);
            this.Controls.Add(this.PanelShadow);
            this.Controls.Add(this.Panel_TitleBar);
            this.Controls.Add(this.Panel_Menu);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Panel_Menu.ResumeLayout(false);
            this.Panel_TitleBar.ResumeLayout(false);
            this.Panel_TitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconCurrentForm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel_Menu;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton Ticket_Butt;
        private FontAwesome.Sharp.IconButton AddressButt;
        private System.Windows.Forms.Panel Panel_TitleBar;
        private System.Windows.Forms.Label lblTitleCurrentForm;
        private FontAwesome.Sharp.IconPictureBox IconCurrentForm;
        private System.Windows.Forms.Panel PanelShadow;
        private System.Windows.Forms.Panel DesktopPanel;
    }
}

