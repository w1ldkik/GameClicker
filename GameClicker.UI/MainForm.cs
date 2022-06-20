﻿using GameClicker.BLL;
using GameClicker.DAL;
using GameClicker.DAL.Models;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameClicker.UI
{
    public partial class MainForm : Form
    {
        public PreparationForm preparationForm;
        public DataConteiner dataConteiner;
        public UserService userService;
        
        public MainForm(PreparationForm preparationForm, DataConteiner dataConteiner, UserService userService)
        {
            InitializeComponent();
            this.dataConteiner = dataConteiner;
            this.preparationForm = preparationForm;
            this.userService = userService;

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void inventoryButton_Click(object sender, EventArgs e)
        {
            Hide();
            var inventoryForm = new InventoryForm(dataConteiner, userService);
            inventoryForm.Show();
        }

        private void playButton_Click(object sender, EventArgs e)
        {
           
            this.Hide();
            preparationForm.Show();
        }
    }
}
