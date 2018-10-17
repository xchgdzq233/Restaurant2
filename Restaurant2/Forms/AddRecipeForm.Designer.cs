namespace Restaurant2
{
    partial class AddRecipeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.recipeName = new System.Windows.Forms.TextBox();
            this.recipeRevenue = new System.Windows.Forms.TextBox();
            this.recipeServing = new System.Windows.Forms.TextBox();
            this.recipeCookware = new System.Windows.Forms.ComboBox();
            this.cookwareTblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.restaurant2DbDataSet1 = new Restaurant2.Restaurant2DbDataSet1();
            this.cancelRecBnt = new System.Windows.Forms.Button();
            this.addRecBnt = new System.Windows.Forms.Button();
            this.addIngTbl = new System.Windows.Forms.DataGridView();
            this.No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IngredientName = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ingredientTblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.restaurant2DbDataSet = new Restaurant2.Restaurant2DbDataSet();
            this.IngredientAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addIngBnt = new System.Windows.Forms.Button();
            this.ingredientTblTableAdapter = new Restaurant2.Restaurant2DbDataSetTableAdapters.IngredientTblTableAdapter();
            this.cookwareTblTableAdapter = new Restaurant2.Restaurant2DbDataSet1TableAdapters.CookwareTblTableAdapter();
            this.recipeCdS = new System.Windows.Forms.NumericUpDown();
            this.recipeCdM = new System.Windows.Forms.NumericUpDown();
            this.recipeCdH = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cookwareTblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurant2DbDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addIngTbl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ingredientTblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurant2DbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recipeCdS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recipeCdM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recipeCdH)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(57, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Recipe Name: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Recipe Cook Time: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Recipe Revenue: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Recipe Cookware: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(30, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(153, 19);
            this.label6.TabIndex = 5;
            this.label6.Text = "Recipe Serving: ";
            // 
            // recipeName
            // 
            this.recipeName.Font = new System.Drawing.Font("Consolas", 12F);
            this.recipeName.Location = new System.Drawing.Point(189, 12);
            this.recipeName.Name = "recipeName";
            this.recipeName.Size = new System.Drawing.Size(180, 26);
            this.recipeName.TabIndex = 1;
            // 
            // recipeRevenue
            // 
            this.recipeRevenue.Font = new System.Drawing.Font("Consolas", 12F);
            this.recipeRevenue.Location = new System.Drawing.Point(189, 44);
            this.recipeRevenue.Name = "recipeRevenue";
            this.recipeRevenue.Size = new System.Drawing.Size(180, 26);
            this.recipeRevenue.TabIndex = 2;
            // 
            // recipeServing
            // 
            this.recipeServing.Font = new System.Drawing.Font("Consolas", 12F);
            this.recipeServing.Location = new System.Drawing.Point(189, 76);
            this.recipeServing.Name = "recipeServing";
            this.recipeServing.Size = new System.Drawing.Size(180, 26);
            this.recipeServing.TabIndex = 3;
            // 
            // recipeCookware
            // 
            this.recipeCookware.DataSource = this.cookwareTblBindingSource;
            this.recipeCookware.DisplayMember = "CookwareName";
            this.recipeCookware.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recipeCookware.FormattingEnabled = true;
            this.recipeCookware.Location = new System.Drawing.Point(189, 140);
            this.recipeCookware.Name = "recipeCookware";
            this.recipeCookware.Size = new System.Drawing.Size(180, 27);
            this.recipeCookware.TabIndex = 7;
            this.recipeCookware.ValueMember = "CookwareId";
            // 
            // cookwareTblBindingSource
            // 
            this.cookwareTblBindingSource.DataMember = "CookwareTbl";
            this.cookwareTblBindingSource.DataSource = this.restaurant2DbDataSet1;
            // 
            // restaurant2DbDataSet1
            // 
            this.restaurant2DbDataSet1.DataSetName = "Restaurant2DbDataSet1";
            this.restaurant2DbDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cancelRecBnt
            // 
            this.cancelRecBnt.AutoSize = true;
            this.cancelRecBnt.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelRecBnt.Location = new System.Drawing.Point(294, 401);
            this.cancelRecBnt.Name = "cancelRecBnt";
            this.cancelRecBnt.Size = new System.Drawing.Size(75, 29);
            this.cancelRecBnt.TabIndex = 11;
            this.cancelRecBnt.Text = "Cancel";
            this.cancelRecBnt.UseVisualStyleBackColor = true;
            this.cancelRecBnt.Click += new System.EventHandler(this.cancelRecBnt_Click);
            // 
            // addRecBnt
            // 
            this.addRecBnt.AutoSize = true;
            this.addRecBnt.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addRecBnt.Location = new System.Drawing.Point(143, 401);
            this.addRecBnt.Name = "addRecBnt";
            this.addRecBnt.Size = new System.Drawing.Size(145, 29);
            this.addRecBnt.TabIndex = 10;
            this.addRecBnt.Text = "Add the recipe";
            this.addRecBnt.UseVisualStyleBackColor = true;
            this.addRecBnt.Click += new System.EventHandler(this.addRecBnt_Click);
            // 
            // addIngTbl
            // 
            this.addIngTbl.AllowUserToAddRows = false;
            this.addIngTbl.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Consolas", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.addIngTbl.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.addIngTbl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.addIngTbl.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.No,
            this.IngredientName,
            this.IngredientAmount});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Consolas", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.addIngTbl.DefaultCellStyle = dataGridViewCellStyle2;
            this.addIngTbl.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.addIngTbl.Location = new System.Drawing.Point(16, 208);
            this.addIngTbl.Name = "addIngTbl";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Consolas", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.addIngTbl.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.addIngTbl.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Consolas", 12F);
            this.addIngTbl.Size = new System.Drawing.Size(353, 187);
            this.addIngTbl.TabIndex = 9;
            this.addIngTbl.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.addIngTbl_RowsRemoved);
            // 
            // No
            // 
            this.No.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.No.FillWeight = 126.5686F;
            this.No.HeaderText = "No";
            this.No.Name = "No";
            this.No.ReadOnly = true;
            this.No.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.No.Width = 58;
            // 
            // IngredientName
            // 
            this.IngredientName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.IngredientName.DataSource = this.ingredientTblBindingSource;
            this.IngredientName.DisplayMember = "IngredientName";
            this.IngredientName.FillWeight = 85.10649F;
            this.IngredientName.HeaderText = "Name";
            this.IngredientName.Name = "IngredientName";
            this.IngredientName.ValueMember = "IngredientId";
            this.IngredientName.Width = 177;
            // 
            // ingredientTblBindingSource
            // 
            this.ingredientTblBindingSource.DataMember = "IngredientTbl";
            this.ingredientTblBindingSource.DataSource = this.restaurant2DbDataSet;
            // 
            // restaurant2DbDataSet
            // 
            this.restaurant2DbDataSet.DataSetName = "Restaurant2DbDataSet";
            this.restaurant2DbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // IngredientAmount
            // 
            this.IngredientAmount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.IngredientAmount.FillWeight = 88.32487F;
            this.IngredientAmount.HeaderText = "Amount";
            this.IngredientAmount.Name = "IngredientAmount";
            // 
            // addIngBnt
            // 
            this.addIngBnt.AutoSize = true;
            this.addIngBnt.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addIngBnt.Location = new System.Drawing.Point(16, 173);
            this.addIngBnt.Name = "addIngBnt";
            this.addIngBnt.Size = new System.Drawing.Size(172, 29);
            this.addIngBnt.TabIndex = 8;
            this.addIngBnt.Text = "Add an ingredient";
            this.addIngBnt.UseVisualStyleBackColor = true;
            this.addIngBnt.Click += new System.EventHandler(this.addIngBnt_Click);
            // 
            // ingredientTblTableAdapter
            // 
            this.ingredientTblTableAdapter.ClearBeforeFill = true;
            // 
            // cookwareTblTableAdapter
            // 
            this.cookwareTblTableAdapter.ClearBeforeFill = true;
            // 
            // recipeCdS
            // 
            this.recipeCdS.Font = new System.Drawing.Font("Consolas", 12F);
            this.recipeCdS.Location = new System.Drawing.Point(327, 108);
            this.recipeCdS.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.recipeCdS.Name = "recipeCdS";
            this.recipeCdS.Size = new System.Drawing.Size(42, 26);
            this.recipeCdS.TabIndex = 6;
            // 
            // recipeCdM
            // 
            this.recipeCdM.Font = new System.Drawing.Font("Consolas", 12F);
            this.recipeCdM.Location = new System.Drawing.Point(259, 108);
            this.recipeCdM.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.recipeCdM.Name = "recipeCdM";
            this.recipeCdM.Size = new System.Drawing.Size(42, 26);
            this.recipeCdM.TabIndex = 5;
            // 
            // recipeCdH
            // 
            this.recipeCdH.Font = new System.Drawing.Font("Consolas", 12F);
            this.recipeCdH.Location = new System.Drawing.Point(189, 108);
            this.recipeCdH.Maximum = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.recipeCdH.Name = "recipeCdH";
            this.recipeCdH.Size = new System.Drawing.Size(42, 26);
            this.recipeCdH.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 12F);
            this.label5.Location = new System.Drawing.Point(303, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 19);
            this.label5.TabIndex = 21;
            this.label5.Text = ":";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Consolas", 12F);
            this.label7.Location = new System.Drawing.Point(237, 110);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(18, 19);
            this.label7.TabIndex = 20;
            this.label7.Text = ":";
            // 
            // AddRecipeForm
            // 
            this.AcceptButton = this.addRecBnt;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 445);
            this.Controls.Add(this.recipeCdS);
            this.Controls.Add(this.recipeCdM);
            this.Controls.Add(this.recipeCdH);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.addIngBnt);
            this.Controls.Add(this.addIngTbl);
            this.Controls.Add(this.addRecBnt);
            this.Controls.Add(this.cancelRecBnt);
            this.Controls.Add(this.recipeCookware);
            this.Controls.Add(this.recipeServing);
            this.Controls.Add(this.recipeRevenue);
            this.Controls.Add(this.recipeName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddRecipeForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add a Recipe";
            ((System.ComponentModel.ISupportInitialize)(this.cookwareTblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurant2DbDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addIngTbl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ingredientTblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurant2DbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recipeCdS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recipeCdM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recipeCdH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox recipeName;
        private System.Windows.Forms.TextBox recipeRevenue;
        private System.Windows.Forms.TextBox recipeServing;
        private System.Windows.Forms.ComboBox recipeCookware;
        private System.Windows.Forms.Button cancelRecBnt;
        private System.Windows.Forms.Button addRecBnt;
        private System.Windows.Forms.DataGridView addIngTbl;
        private System.Windows.Forms.Button addIngBnt;
        private Restaurant2DbDataSet restaurant2DbDataSet;
        private System.Windows.Forms.BindingSource ingredientTblBindingSource;
        private Restaurant2DbDataSetTableAdapters.IngredientTblTableAdapter ingredientTblTableAdapter;
        private Restaurant2DbDataSet1 restaurant2DbDataSet1;
        private System.Windows.Forms.BindingSource cookwareTblBindingSource;
        private Restaurant2DbDataSet1TableAdapters.CookwareTblTableAdapter cookwareTblTableAdapter;
        private System.Windows.Forms.NumericUpDown recipeCdS;
        private System.Windows.Forms.NumericUpDown recipeCdM;
        private System.Windows.Forms.NumericUpDown recipeCdH;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn No;
        private System.Windows.Forms.DataGridViewComboBoxColumn IngredientName;
        private System.Windows.Forms.DataGridViewTextBoxColumn IngredientAmount;
    }
}