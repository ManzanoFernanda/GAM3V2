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
using GAM3;

namespace GAM3
{
    public partial class Form5 : Form
    {
        public void Espera()
        {
            Thread.Sleep(1800);
        }
        public Form5()
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

            Form formulario = new Form7();
            formulario.Show();
            this.Hide();
            this.Close();
        }

       

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        public async void circularButton2_Click_1(object sender, EventArgs e)
        {
            
        SoundPlayer Sclick = new SoundPlayer(GAM3.Properties.Resources.BT);
        Sclick.Play();

        Task oTask = new Task(Espera);
        oTask.Start();
        await oTask;

        Form formulario = new Form6();
        formulario.Show();
        this.Hide();
        this.Close();


            
        }
    }
}


