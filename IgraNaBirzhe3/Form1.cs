﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace IgraNaBirzhe3
{
    public partial class Form1 : Form
    {
        int Akcii = 0;
        int[,] Vybor = new int[3, 3];
        int Neftb = 0;
        public Form1()
        {
            InitializeComponent();
            timer1.Enabled = true;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    Vybor[i, j] = -1;
        }
        private bool buttonWasClicked = false;
        private void timer1_Tick(object sender, EventArgs e)
        {
            Random rnd = new Random(Environment.TickCount);
            Neftb = rnd.Next(3);
            Akcii = rnd.Next(3);

            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;

            switch (Neftb)
            {
                case 0:
                    label3.ForeColor = Color.Red;
                    label3.Text = "Падает";
                    break;

                case 1:
                    label3.ForeColor = Color.Yellow;
                    label3.Text = "Стабильна";
                    break;

                case 2:
                    label3.ForeColor = Color.Green;
                    label3.Text = "Растёт";
                    break;
            }
            switch (Akcii)
            {
                case 0:
                    label4.ForeColor = Color.Red;
                    label4.Text = "Падает";
                    break;

                case 1:
                    label4.ForeColor = Color.Yellow;
                    label4.Text = "Стабильна";
                    break;

                case 2:
                    label4.ForeColor = Color.Green;
                    label4.Text = "Растёт";
                    break;
            }
            if (buttonWasClicked == true)
                if (Vybor[Neftb, Akcii] == -1)
                {
                    timer1.Enabled = false;
                    label5.Text = "Выберите действие";
                }
            if (Vybor[Neftb, Akcii] == 0)
            {
                radioButton1.Checked = true;
            }
            if (Vybor[Neftb, Akcii] == 1)
            {
                radioButton2.Checked = true;
            }
            if (Vybor[Neftb, Akcii] == 2)
            {
                radioButton3.Checked = true;
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                Vybor[Neftb, Akcii] = 0;
                timer1.Enabled = true;
                label5.Text = "";
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                Vybor[Neftb, Akcii] = 1;
                timer1.Enabled = true;
                label5.Text = "";
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked == true)
            {
                Vybor[Neftb, Akcii] = 2;
                timer1.Enabled = true;
                label5.Text = "";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            buttonWasClicked = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


    }
}