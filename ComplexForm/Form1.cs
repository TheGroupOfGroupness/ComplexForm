using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;

namespace ComplexForm
{
    public partial class Form1 : Form
    {

        private IconButton currentBtn;
        private Panel LeftBorderBtn;
        private Form CurrentForm;
        public Form1()
        {
            InitializeComponent();

            LeftBorderBtn = new Panel();
            LeftBorderBtn.Size = new Size(7, 60);
            Panel_Menu.Controls.Add(LeftBorderBtn);
            

          
          

        }

        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
        }

        //Method to activate Button

        private void ActivateButton(object senderBtn,Color color)
        {
            
            if(senderBtn!= null)
            {
                DisableButton();

                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(37,36,81);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;

                //Left border button

                LeftBorderBtn.BackColor = color;
                LeftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                LeftBorderBtn.Visible = true;
                LeftBorderBtn.BringToFront();

                //Icon of current form

                IconCurrentForm.IconChar = currentBtn.IconChar;
                IconCurrentForm.IconColor = color;
            }
        }

        //Disable button Highlighting

        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(31, 30, 68);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void OpenChildForm(Form childForm)
        {
            if(CurrentForm != null)
            {
               CurrentForm.Close();
            }

            CurrentForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            DesktopPanel.Controls.Add(childForm);
            DesktopPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitleCurrentForm.Text = childForm.Text;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void AddressButt_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new OwnerDetails());
        }

        private void Ticket_Butt_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
            OpenChildForm(new Ticket());
        }


        
        private void Panel_TitleBar_MouseDown(object sender, MouseEventArgs e)
        {

        }
    }
}
