using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace Restaurant2
{
    public partial class LoadScriptForm : Form
    {

        public LoadScriptForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog select = new OpenFileDialog();

            select.Title = "Select the script for cookware";
            select.Filter = "Text files (*.txt)|*.txt";
            if (select.ShowDialog() == DialogResult.OK)
            {
                cookwareScriptPath.Text = select.FileName;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog select = new OpenFileDialog();

            select.Title = "Select the script for ingredient";
            select.Filter = "Text files (*.txt)|*.txt";
            if (select.ShowDialog() == DialogResult.OK)
            {
                ingredientScriptPath.Text = select.FileName;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog select = new OpenFileDialog();

            select.Title = "Select the script for recipe";
            select.Filter = "Text files (*.txt)|*.txt";
            if (select.ShowDialog() == DialogResult.OK)
            {
                recipeScriptPath.Text = select.FileName;
            }
        }

        private void cancelLoadBnt_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void loadScriptBnt_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(cookwareScriptPath.Text))
                {
                    using (StreamReader file = new StreamReader(cookwareScriptPath.Text))
                    {
                        string line;
                        while ((line = file.ReadLine()) != null)
                        {
                            dblib db = new dblib();
                            db.addNewCookware(line.Trim());
                        }
                    }

                    MessageBox.Show("Cookware script loaded");
                }

                if (!string.IsNullOrEmpty(ingredientScriptPath.Text))
                {
                    using (StreamReader file = new StreamReader(ingredientScriptPath.Text))
                    {
                        string line;
                        while ((line = file.ReadLine()) != null)
                        {
                            string[] separator = { ", " };
                            string[] values = line.Split(separator, StringSplitOptions.None);
                            string[] times = values[2].Split(':');
                            dblib db = new dblib();
                            db.addNewIngredient(values[0].Trim(), values[1].Trim(), times[0].Trim(), times[1].Trim(), times[2].Trim());
                        }
                    }

                    MessageBox.Show("Ingredient script loaded");
                }

                if (!string.IsNullOrEmpty(recipeScriptPath.Text))
                {
                    using (StreamReader file = new StreamReader(recipeScriptPath.Text))
                    {
                        string line;
                        while ((line = file.ReadLine()) != null)
                        {
                            string[] separator = { ", " };
                            string[] values = line.Split(separator, StringSplitOptions.None);
                            string[] times = values[3].Split(':');
                            dblib db = new dblib();
                            string cookwareId = db.findCookwareId(values[4]);
                            List<string> ingIds = new List<string>();
                            List<string> ingAmounts = new List<string>();
                            for (int i = 5; i < values.Length; i++)
                            {
                                ingIds.Add(db.findIngredientId(values[i]));
                                i++;
                                ingAmounts.Add(values[i]);
                            }
                            string[] ingredientNames = ingIds.ToArray();
                            string[] ingredientAmounts = ingAmounts.ToArray();
                            db.addNewRecipe(values[0].Trim(), values[1].Trim(), values[2].Trim(), times[0].Trim(), times[1].Trim(), times[2].Trim(), cookwareId, ingredientNames, ingredientAmounts);
                        }
                    }

                    MessageBox.Show("Recipe script loaded");
                }

                this.DialogResult = DialogResult.OK;
            }
            catch (SqlException)
            {
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("Cannot find the script file");
            }
        }
    }
}
