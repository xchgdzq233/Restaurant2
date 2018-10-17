namespace Restaurant2
{
    partial class AddIngredientForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ingredientCost = new System.Windows.Forms.TextBox();
            this.ingredientName = new System.Windows.Forms.TextBox();
            this.cancelIngBnt = new System.Windows.Forms.Button();
            this.addIngBnt = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ingredientCdH = new System.Windows.Forms.NumericUpDown();
            this.ingredientCdM = new System.Windows.Forms.NumericUpDown();
            this.ingredientCdS = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.ingredientCdH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ingredientCdM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ingredientCdS)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingredient Name: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ingredient Cost: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(189, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ingredient CD Time: ";
            // 
            // ingredientCost
            // 
            this.ingredientCost.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ingredientCost.Location = new System.Drawing.Point(16, 82);
            this.ingredientCost.Name = "ingredientCost";
            this.ingredientCost.Size = new System.Drawing.Size(180, 26);
            this.ingredientCost.TabIndex = 2;
            // 
            // ingredientName
            // 
            this.ingredientName.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ingredientName.Location = new System.Drawing.Point(16, 31);
            this.ingredientName.Name = "ingredientName";
            this.ingredientName.Size = new System.Drawing.Size(180, 26);
            this.ingredientName.TabIndex = 1;
            // 
            // cancelIngBnt
            // 
            this.cancelIngBnt.AutoSize = true;
            this.cancelIngBnt.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelIngBnt.Location = new System.Drawing.Point(121, 165);
            this.cancelIngBnt.Name = "cancelIngBnt";
            this.cancelIngBnt.Size = new System.Drawing.Size(75, 29);
            this.cancelIngBnt.TabIndex = 7;
            this.cancelIngBnt.Text = "Cancel";
            this.cancelIngBnt.UseVisualStyleBackColor = true;
            this.cancelIngBnt.Click += new System.EventHandler(this.cancelIngBnt_Click);
            // 
            // addIngBnt
            // 
            this.addIngBnt.AutoSize = true;
            this.addIngBnt.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addIngBnt.Location = new System.Drawing.Point(40, 165);
            this.addIngBnt.Name = "addIngBnt";
            this.addIngBnt.Size = new System.Drawing.Size(75, 29);
            this.addIngBnt.TabIndex = 6;
            this.addIngBnt.Text = "Add";
            this.addIngBnt.UseVisualStyleBackColor = true;
            this.addIngBnt.Click += new System.EventHandler(this.addIngBnt_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 12F);
            this.label4.Location = new System.Drawing.Point(64, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 19);
            this.label4.TabIndex = 8;
            this.label4.Text = ":";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 12F);
            this.label5.Location = new System.Drawing.Point(130, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 19);
            this.label5.TabIndex = 10;
            this.label5.Text = ":";
            // 
            // ingredientCdH
            // 
            this.ingredientCdH.Font = new System.Drawing.Font("Consolas", 12F);
            this.ingredientCdH.Location = new System.Drawing.Point(16, 133);
            this.ingredientCdH.Maximum = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.ingredientCdH.Name = "ingredientCdH";
            this.ingredientCdH.Size = new System.Drawing.Size(42, 26);
            this.ingredientCdH.TabIndex = 3;
            // 
            // ingredientCdM
            // 
            this.ingredientCdM.Font = new System.Drawing.Font("Consolas", 12F);
            this.ingredientCdM.Location = new System.Drawing.Point(86, 133);
            this.ingredientCdM.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.ingredientCdM.Name = "ingredientCdM";
            this.ingredientCdM.Size = new System.Drawing.Size(42, 26);
            this.ingredientCdM.TabIndex = 4;
            // 
            // ingredientCdS
            // 
            this.ingredientCdS.Font = new System.Drawing.Font("Consolas", 12F);
            this.ingredientCdS.Location = new System.Drawing.Point(154, 133);
            this.ingredientCdS.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.ingredientCdS.Name = "ingredientCdS";
            this.ingredientCdS.Size = new System.Drawing.Size(42, 26);
            this.ingredientCdS.TabIndex = 5;
            // 
            // AddIngredientForm
            // 
            this.AcceptButton = this.addIngBnt;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(214, 208);
            this.Controls.Add(this.ingredientCdS);
            this.Controls.Add(this.ingredientCdM);
            this.Controls.Add(this.ingredientCdH);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cancelIngBnt);
            this.Controls.Add(this.addIngBnt);
            this.Controls.Add(this.ingredientName);
            this.Controls.Add(this.ingredientCost);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddIngredientForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add an Ingredient";
            ((System.ComponentModel.ISupportInitialize)(this.ingredientCdH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ingredientCdM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ingredientCdS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ingredientCost;
        private System.Windows.Forms.TextBox ingredientName;
        private System.Windows.Forms.Button cancelIngBnt;
        private System.Windows.Forms.Button addIngBnt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown ingredientCdH;
        private System.Windows.Forms.NumericUpDown ingredientCdM;
        private System.Windows.Forms.NumericUpDown ingredientCdS;
    }
}