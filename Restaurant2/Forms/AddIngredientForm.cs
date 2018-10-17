using System;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace Restaurant2
{
    public partial class AddIngredientForm : Form
    {
        public AddIngredientForm()
        {
            InitializeComponent();
        }

        private void cancelIngBnt_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addIngBnt_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(ingredientName.Text) || string.IsNullOrEmpty(ingredientCost.Text))
                {
                    throw new MissingValueException();
                }
                else if (ingredientCdH.Value == decimal.Zero && ingredientCdM.Value == decimal.Zero && ingredientCdS.Value == decimal.Zero)
                {
                    throw new MissingValueException();
                }
                else
                {
                    int intValue = 0;
                    if (!int.TryParse(ingredientCost.Text, out intValue) || !int.TryParse(ingredientCdH.Value.ToString(), out intValue) || !int.TryParse(ingredientCdM.Value.ToString(), out intValue) || !int.TryParse(ingredientCdS.Value.ToString(), out intValue))
                    {
                        throw new InvalidValueException();
                    }
                    else
                    {
                        dblib db = new dblib();
                        db.addNewIngredient(ingredientName.Text, ingredientCost.Text, ingredientCdH.Value.ToString(), ingredientCdM.Value.ToString(), ingredientCdS.Value.ToString());

                        MessageBox.Show("New ingredient added");
                        this.DialogResult = DialogResult.OK;
                    }
                }
            }
            catch (MissingValueException)
            {
                MessageBox.Show("Missing value(s)");
            }
            catch (InvalidValueException)
            {
                MessageBox.Show("Invalidate value(s)");
            }
            catch (SqlException)
            {
            }
        }
    }
}
