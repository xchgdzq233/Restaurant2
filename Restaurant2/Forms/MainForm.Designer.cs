namespace Restaurant2
{
    partial class MainForm
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
            this.addIngredientBnt = new System.Windows.Forms.Button();
            this.addRecipeBnt = new System.Windows.Forms.Button();
            this.checkAllBnt = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(784, 73);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to the smart Recipe/Ingredient Management System";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // addIngredientBnt
            // 
            this.addIngredientBnt.AutoSize = true;
            this.addIngredientBnt.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addIngredientBnt.Location = new System.Drawing.Point(300, 195);
            this.addIngredientBnt.Name = "addIngredientBnt";
            this.addIngredientBnt.Size = new System.Drawing.Size(200, 29);
            this.addIngredientBnt.TabIndex = 2;
            this.addIngredientBnt.Text = "Add a new Ingredient";
            this.addIngredientBnt.UseVisualStyleBackColor = true;
            this.addIngredientBnt.Click += new System.EventHandler(this.addIngredientBnt_Click);
            // 
            // addRecipeBnt
            // 
            this.addRecipeBnt.AutoSize = true;
            this.addRecipeBnt.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addRecipeBnt.Location = new System.Drawing.Point(300, 245);
            this.addRecipeBnt.Name = "addRecipeBnt";
            this.addRecipeBnt.Size = new System.Drawing.Size(200, 29);
            this.addRecipeBnt.TabIndex = 3;
            this.addRecipeBnt.Text = "Add a new Recipe";
            this.addRecipeBnt.UseVisualStyleBackColor = true;
            this.addRecipeBnt.Click += new System.EventHandler(this.addRecipeBnt_Click);
            // 
            // checkAllBnt
            // 
            this.checkAllBnt.AutoSize = true;
            this.checkAllBnt.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkAllBnt.Location = new System.Drawing.Point(300, 295);
            this.checkAllBnt.Name = "checkAllBnt";
            this.checkAllBnt.Size = new System.Drawing.Size(200, 29);
            this.checkAllBnt.TabIndex = 4;
            this.checkAllBnt.Text = "Check All I have";
            this.checkAllBnt.UseVisualStyleBackColor = true;
            this.checkAllBnt.Click += new System.EventHandler(this.checkAllBnt_Click);
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(300, 145);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 29);
            this.button1.TabIndex = 1;
            this.button1.Text = "Load the scripts";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkAllBnt);
            this.Controls.Add(this.addRecipeBnt);
            this.Controls.Add(this.addIngredientBnt);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Restaurant Story 2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addIngredientBnt;
        private System.Windows.Forms.Button addRecipeBnt;
        private System.Windows.Forms.Button checkAllBnt;
        private System.Windows.Forms.Button button1;
    }
}

