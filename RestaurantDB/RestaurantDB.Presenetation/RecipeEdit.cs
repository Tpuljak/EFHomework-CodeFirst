﻿using Restaurant.DB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantDB.Presenetation
{
    public partial class RecipeEdit : Form
    {
        public RecipeEdit(RestaurantContext context)
        {
            InitializeComponent();
            _context = context;
        }

        private readonly RestaurantContext _context;

        private void EditButton_Click(object sender, EventArgs e)
        {
            Close();
            return;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
            return;
        }

        private void RecipeEdit_Load(object sender, EventArgs e)
        {
        }

        private void IngredientsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void IngredientsLabel_Click(object sender, EventArgs e)
        {

        }
    }
}