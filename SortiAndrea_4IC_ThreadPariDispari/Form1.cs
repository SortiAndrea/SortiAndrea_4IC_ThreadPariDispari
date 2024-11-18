using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SortiAndrea_4IC_ThreadPariDispari
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        int[] numeriPari = new int[100];

        int[] numeriDispari = new int[100];

        static int turno = 0;

        static int numeroCorrentePari = -2; // se voglio che parta da 0 metto -2, se voglio che parta da 2 metto 0

        static int numeroCorrenteDispari = -1; // se voglio che parta da 1 metto -1, se voglio che parta da 3 metto 1

        private void btnThread_Pari_Click(object sender, EventArgs e)
        {
            Thread pariThread = new Thread(new ThreadStart(GeneraPari));
            pariThread.Start();
        }

        private void btnThread_Dispari_Click(object sender, EventArgs e)
        {
            Thread dispariThread = new Thread(new ThreadStart(GeneraDispari));
            dispariThread.Start();
        }

        public void GeneraPari()
        {
            while (true)
            {
                while (turno != 0)
                    Thread.Sleep(100);

                lock (numeriPari)
                {
                    numeroCorrentePari += 2;
                    turno = 1;

                    //Invoke(new Action(() =>
                    //{
                    //    lbThreads.Items.Add($"Numero pari: {numeroCorrentePari}");
                    //}));

                    lbThreads.Items.Add($"Numero pari: {numeroCorrentePari}");
                }

                Thread.Sleep(2000);
            }
        }

        public void GeneraDispari()
        {
            while (true)
            {
                while (turno != 1)
                    Thread.Sleep(100);

                lock (numeriDispari)
                {
                    numeroCorrenteDispari += 2;
                    turno = 0;  // Passa il turno ai numeri pari

                    //Invoke(new Action(() =>
                    //{
                    //    lbThreads.Items.Add($"Numero dispari: {numeroCorrenteDispari}");
                    //}));

                    lbThreads.Items.Add($"Numero dispari: {numeroCorrenteDispari}");
                }

                Thread.Sleep(2000);
            }
        }
    }
}
