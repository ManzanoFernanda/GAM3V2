﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Threading;
using GAM3;

namespace GAM3
{
    

    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();

        }

        public async void CircularButton1_Click(object sender, EventArgs e)
        {

            SoundPlayer Sclick = new SoundPlayer(GAM3.Properties.Resources.BT);
            Sclick.Play();

            Task oTask = new Task(Espera);
            oTask.Start();
            await oTask;

            Form formulario = new Form2();
            formulario.Show();
            this.Hide();
            Dispose();
        }

        private async void CircularButton2_Click(object sender, EventArgs e)
        {
            SoundPlayer Sclick = new SoundPlayer(GAM3.Properties.Resources.BT);
            Sclick.Play();

            Task oTask = new Task(Espera);
            oTask.Start();
            await oTask;

            Form formulario = new Form3();
            formulario.Show();
            this.Hide();
            Dispose();
            

        }
        public void Espera()
        {
            Thread.Sleep(1500);
        }



    }


}




