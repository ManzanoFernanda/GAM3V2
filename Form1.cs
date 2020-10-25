using System;
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

namespace GAM3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        public async void CircularButton4_Click(object sender, EventArgs e)
        {
           
            SoundPlayer Sclick = new SoundPlayer(GAM3.Properties.Resources.BT);
            Sclick.Play();

            Task oTask = new Task(Espera);
            oTask.Start();
            await oTask;
            
            Form formulario = new Form2();
            formulario.Show();
            this.Hide();
            

        }

        private async void CircularButton5_Click(object sender, EventArgs e)
        {
            SoundPlayer Sclick = new SoundPlayer(GAM3.Properties.Resources.BT);
            Sclick.Play();

            Task oTask = new Task(Espera);
            oTask.Start();
            await oTask;
            
            Form formulario = new Form3();
            formulario.Show();
            this.Hide();
            


        }
        private async void CircularButton6_Click(object sender, EventArgs e)
        {
            SoundPlayer Sclick = new SoundPlayer(GAM3.Properties.Resources.BT);
            Sclick.Play();

            Task oTask = new Task(Espera);
            oTask.Start();
            await oTask;
            this.Close();

            //Form formulario = new Form3();
            //formulario.Show();


        }
        public void Espera()
        {
            Thread.Sleep(1500);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

