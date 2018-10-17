using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Restaurant2
{
    public partial class AddRecipeForm : Form
    {
        public AddRecipeForm()
        {
            InitializeComponent();
            // TODO: This line of code loads data into the 'restaurant2DbDataSet1.CookwareTbl' table. You can move, or remove it, as needed.
            this.cookwareTblTableAdapter.Fill(this.restaurant2DbDataSet1.CookwareTbl);
            // TODO: This line of code loads data into the 'restaurant2DbDataSet.IngredientTbl' table. You can move, or remove it, as needed.
            this.ingredientTblTableAdapter.Fill(this.restaurant2DbDataSet.IngredientTbl);
        }

        private void cancelRecBnt_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addIngTbl_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            for (int i = 0; i < addIngTbl.RowCount; i++)
            {
                addIngTbl.Rows[i].Cells[0].Value = i + 1;
            }
        }

        private void addIngBnt_Click(object sender, EventArgs e)
        {
            addIngTbl.Rows.Add(1);

            int rowCount = addIngTbl.RowCount;
            addIngTbl.Rows[rowCount - 1].Cells[0].Value = rowCount;
        }

        private void addRecBnt_Click(object sender, EventArgs e)
        {
            try
            {
                int intValue = 0;
                if (string.IsNullOrEmpty(recipeName.Text) || string.IsNullOrEmpty(recipeRevenue.Text) || string.IsNullOrEmpty(recipeServing.Text) || addIngTbl.RowCount == 0)
                {
                    throw new MissingValueException();
                }
                else if (recipeCdH.Value == decimal.Zero && recipeCdM.Value == decimal.Zero && recipeCdS.Value == decimal.Zero)
                {
                    throw new MissingValueException();
                }
                else if (!int.TryParse(recipeRevenue.Text, out intValue) || !int.TryParse(recipeServing.Text, out intValue) || !int.TryParse(recipeCdH.Value.ToString(), out intValue) || !int.TryParse(recipeCdM.Value.ToString(), out intValue) || !int.TryParse(recipeCdS.Value.ToString(), out intValue))
                {
                    throw new InvalidValueException();
                }
                else
                {
                    string[] ingIds = new string[addIngTbl.RowCount];
                    string[] ingAmounts = new string[addIngTbl.RowCount];
                    for (int i = 0; i < addIngTbl.RowCount; i++)
                    {
                        string ingId = addIngTbl.Rows[i].Cells[1].Value.ToString();
                        string ingAmount = addIngTbl.Rows[i].Cells[2].Value.ToString();
                        if (string.IsNullOrEmpty(ingId) || string.IsNullOrEmpty(ingAmount))
                        {
                            throw new MissingValueException();
                        }
                        else if (!int.TryParse(ingAmount, out intValue))
                        {
                            throw new InvalidValueException();
                        }
                        else
                        {
                            ingIds[i] = ingId;
                            ingAmounts[i] = ingAmount;
                        }
                    }

                    dblib db = new dblib();
                    db.addNewRecipe(recipeName.Text, recipeRevenue.Text, recipeServing.Text, recipeCdH.Value.ToString(), recipeCdM.Value.ToString(), recipeCdS.Value.ToString(), recipeCookware.SelectedValue.ToString(), ingIds, ingAmounts);

                    MessageBox.Show("New recipe added");
                    this.DialogResult = DialogResult.OK;
                }
            }
            catch (MissingValueException)
            {
                MessageBox.Show("Missing value(s)");
            }
            catch (NullReferenceException)
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
