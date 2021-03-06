﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP1004_F2016_Lesson6
{
    public partial class RaceForm : Form
    {

        public AbilityForm previousForm { get; set; }

        public RaceForm()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.previousForm.Show();
            this.Hide();
        }

        private void RaceForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            BackButton_Click(sender, e);
        }

        private void RaceForm_Load(object sender, EventArgs e)
        {
            if(Program.character.Race == null)
            {
                RaceListBox.SelectedItem = "Human";
            }
            else
            {
                RaceListBox.SelectedItem = Program.character.Race;
            }
            
        }

        private void RaceListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            RaceSelectedTextBox.Text = RaceListBox.SelectedItem.ToString();
            Program.character.Race = RaceSelectedTextBox.Text;
        }
    }
}
