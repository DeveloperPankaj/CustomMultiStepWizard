using CustomMultiStepWizard.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CustomMultiStepWizard
{
    public partial class Form1 : Form
    {
        int i = 1;
        public Form1()
        {
            InitializeComponent();
            panel1.Visible = true;
            panel2.Visible = false;
            panel3.Visible = false;
            btnBack.Visible = false;
           // lblConfirm.Enabled = false;
            //lblPayment.Enabled = false;
            pictureBox2.Enabled = false;
            pictureBox3.Enabled = false;
            lblDone.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            i = i + 1;
            string panelDetails = string.Empty;
            switch(i)
            {
                case 1:
                    panelDetails = "panel1";
                    break;
                case 2:
                    panelDetails = "panel2";
                    break;
                case 3:
                    panelDetails = "panel3";
                    break;
                case 4:
                    panelDetails = "panelContainer";
                    break;
                default:
                    break;
            }
            UpdateGUI(i, panelDetails,false);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            i = i - 1;
            string panelDetails = string.Empty;
            switch (i)
            {
                case 1:
                    panelDetails = "panel1";
                    break;
                case 2:
                    panelDetails = "panel2";
                    break;
                case 3:
                    panelDetails = "panel3";
                    break;
                case 4:
                    panelDetails = "panelContainer";
                    break;
                default:
                    break;
            }
            UpdateGUI(i, panelDetails,true);
        }


        public void UpdateGUI(int tabDetail, string activePanelDetails, bool isBack)
        {
            switch (activePanelDetails)
            {
                case "panel1":
                    panel1.Visible = true;
                    panel2.Visible = false;
                    panel3.Visible = false;
                    lblDone.Visible = false;
                    btnBack.Visible = false;
                    pictureBox1.Image = Properties.Resources.current;
                    pictureBox2.Image = Properties.Resources.pending;
                    btnNext.Visible = true;
                    break;
                case "panel2":
                    panel1.Visible = false;
                    panel2.Visible = true;
                    panel3.Visible = false;
                    pictureBox1.Image = Properties.Resources.completed;
                    pictureBox2.Image = Properties.Resources.current;
                    pictureBox3.Image = Properties.Resources.pending;
                    btnBack.Visible = true;
                    btnNext.Visible = true;
                    break;
                case "panel3":
                    panel1.Visible = false;
                    panel2.Visible = false;
                    pictureBox2.Image = Properties.Resources.completed;
                    pictureBox3.Image = Properties.Resources.current;
                    panel3.Visible = true;
                    btnBack.Visible = true;
                    btnNext.Visible = true;
                    break;
                case "panelContainer":
                    panel1.Visible = false;
                    panel2.Visible = false;
                    pictureBox3.Image = Properties.Resources.completed;
                    lblDone.Location = new Point((panelContainer.Width / 2) - lblDone.Width, (panelContainer.Height / 2) - lblDone.Height);
                    lblDone.Visible = true;
                    panel3.Visible = false;
                    btnBack.Visible = true;
                    btnNext.Visible = false;
                    break;
                default:
                    i = 0;
                    break;
            }
        }
    }
}
