using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant2
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

        }

        private void addIngredientBnt_Click(object sender, EventArgs e)
        {
            new AddIngredientForm().ShowDialog();
        }

        private void addRecipeBnt_Click(object sender, EventArgs e)
        {
            new AddRecipeForm().ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new LoadScriptForm().ShowDialog();
        }

        private void checkAllBnt_Click(object sender, EventArgs e)
        {
            (new QueryForm()).Show();
            this.Hide();
        }
    }
}
