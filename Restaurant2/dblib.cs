using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant2
{
    public class dblib
    {
        private SqlConnection cnn;

        public dblib()
        {
            try
            {
                cnn = new SqlConnection();
                cnn.ConnectionString = "Data Source=LIVINGROOM-PC;Initial Catalog=Restaurant2Db;Integrated Security=True";
            }
            catch (SqlException e)
            {
                MessageBox.Show("cannot connect to database");
                throw e;
            }
        }

        private DataSet Select(String sql)
        {
            DataSet ds = new DataSet();
            try
            {
                cnn.Open();
                SqlDataAdapter da = new SqlDataAdapter();
                SqlCommand cmd = new SqlCommand(sql, cnn);

                da.SelectCommand = cmd;
                da.Fill(ds);
            }
            catch (SqlException e)
            {
                MessageBox.Show("Failed to query database");
                throw e;
            }
            finally
            {
                cnn.Close();
            }
            return ds;
        }

        private void Transaction(String sql)
        {
            cnn.Open();
            SqlCommand cmd = new SqlCommand();
            SqlTransaction trans = cnn.BeginTransaction();
            try
            {
                cmd.Connection = cnn;
                cmd.Transaction = trans;

                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();

                trans.Commit();
            }
            catch (SqlException e)
            {
                trans.Rollback();
                throw e;
            }
            finally
            {
                cnn.Close();
            }
        }

        public void addNewIngredient (string ingredientName, string ingredientCost, string ingredientH, string ingredientM, string ingredientS)
        {
            try
            {
                String sql = String.Format("insert into IngredientTbl values('{0}', '{1}', '{2}:{3}:{4}')", ingredientName, ingredientCost, ingredientH, ingredientM, ingredientS);
                sql.ToUpper();
                Transaction(sql);
            }
            catch (SqlException e)
            {
                MessageBox.Show(String.Format("Failed to add the ingredient named {0}, please try again", ingredientName));
                throw e;
            }
        }

        public void addNewRecipe(string recipeName, string recipeRevenue, string recipeServing, string recipeCdH, string recipeCdM, string recipeCdS, string recipeCookware, string[] ingredientIds, string[] ingredientAmounts)
        {
            string addedRecipeId = "";
            try
            {
                String sql = String.Format("insert into RecipeTbl values ('{0}', '{1}', '{2}', '{3}:{4}:{5}', '{6}')", recipeName, recipeRevenue, recipeServing, recipeCdH, recipeCdM, recipeCdS, recipeCookware);
                sql.ToUpper();
                Transaction(sql);

                sql = String.Format("select RecipeId from RecipeTbl where RecipeName = '{0}'", recipeName);
                DataSet ds = Select(sql);
                DataTable dt = ds.Tables[0];
                addedRecipeId = dt.Rows[0][0].ToString();

                for (int i = 0; i < ingredientIds.Length; i++)
                {
                    sql = String.Format("insert into RecipeIngredientTbl values ('{0}', '{1}', '{2}')", addedRecipeId, ingredientIds[i], ingredientAmounts[i]);
                    sql.ToUpper();
                    Transaction(sql);
                }
            }
            catch (SqlException e)
            {
                if (!string.IsNullOrEmpty(addedRecipeId))
                {
                    String sql = String.Format("delete from RecipeTbl where RecipeId = {0}", addedRecipeId);
                    sql.ToUpper();
                    try
                    {
                        Transaction(sql);
                        sql = String.Format("delete from RecipeIngredientTbl where RecipeId = {0}", addedRecipeId);
                        sql.ToUpper();
                        Transaction(sql);
                    }
                    catch (SqlException)
                    {
                        MessageBox.Show("error(s) occured while cleaning up RecipeTbl, please check the database");
                    }
                }
                MessageBox.Show(String.Format("Failed to add the new recipe named {0}, please try again", recipeName));
                throw e;
            }
        }

        public void addNewCookware(string cookwareName)
        {
            try
            {
                String sql = String.Format("insert into CookwareTbl values ('{0}')", cookwareName);
                sql.ToUpper();
                Transaction(sql);
            }
            catch(SqlException e)
            {
                MessageBox.Show(String.Format("Failed to add the cookware named {0}, please try again", cookwareName));
                throw e;
            }
        }

        public string findCookwareId(string cookwareName)
        {
            string result = "";
            String sql = String.Format("select CookwareId from CookwareTbl where CookwareName = '{0}'", cookwareName);
            try
            {
                sql.ToUpper();
                DataSet ds = Select(sql);
                DataTable dt = ds.Tables[0];
                if (dt.Rows.Count == 1)
                {
                    result = dt.Rows[0][0].ToString();
                }
                else
                {
                    MessageBox.Show(String.Format("Cannot find cookware named {0}, please try again", cookwareName));
                }
            }
            catch (SqlException e)
            {
                throw e;
            }

            return result;
        }

        public string findIngredientId(string ingredientName)
        {
            string result = "";
            String sql = String.Format("select IngredientId from IngredientTbl where IngredientName = '{0}'", ingredientName);
            try
            {
                sql.ToUpper();
                DataSet ds = Select(sql);
                DataTable dt = ds.Tables[0];
                if (dt.Rows.Count == 1)
                {
                    result = dt.Rows[0][0].ToString();
                }
                else
                {
                    MessageBox.Show(String.Format("Cannot find ingredient named {0}, please try again", ingredientName));
                }
            }
            catch (SqlException e)
            {
                throw e;
            }

            return result;
        }
    }
}
