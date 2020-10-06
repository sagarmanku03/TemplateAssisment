using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TemplateAssisment
{
    public partial class MainForm : Form
    {
        RRClass rrClass = new RRClass();    
        
        public MainForm()
        {
            InitializeComponent();
        }

        private void BackgroundImage_Click(object sender, EventArgs e)
        {

        }

        private void GunShootButton_Click(object sender, EventArgs e)
        {
            rrClass.ShootAtHead();
            //I am playing this sound from resources file
            SoundPlayer sound = new SoundPlayer(TemplateAssisment.Properties.Resources.Bomber);
            sound.Play();
          
        }

        private void ShootAwayButton_Click(object sender, EventArgs e)
        {
            rrClass.ShootAway();
            //I am playing this sound from resources file
            SoundPlayer sound = new SoundPlayer(TemplateAssisment.Properties.Resources.gunsound);
            sound.Play();

           
                }
        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

      

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void SpinButton_Click(object sender, EventArgs e)
        {
            rrClass.SpinChamber();
        }

        private void ReloadRevolver_Click(object sender, EventArgs e)
        {
            rrClass.ReloadRevolver();
        }

        private void QuitGame_Click(object sender, EventArgs e)
        {
            Application.Exit();
        
        }
    }
    }
