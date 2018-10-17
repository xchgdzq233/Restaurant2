namespace Restaurant2
{
    partial class LoadScriptForm
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
            this.cookwareScriptPath = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.ingredientScriptPath = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.recipeScriptPath = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cancelLoadBnt = new System.Windows.Forms.Button();
            this.loadScriptBnt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 12F);
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select cookware script: ";
            // 
            // cookwareScriptPath
            // 
            this.cookwareScriptPath.Font = new System.Drawing.Font("Consolas", 12F);
            this.cookwareScriptPath.Location = new System.Drawing.Point(17, 36);
            this.cookwareScriptPath.Name = "cookwareScriptPath";
            this.cookwareScriptPath.ReadOnly = true;
            this.cookwareScriptPath.Size = new System.Drawing.Size(400, 26);
            this.cookwareScriptPath.TabIndex = 1;
            this.cookwareScriptPath.TabStop = false;
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.Font = new System.Drawing.Font("Consolas", 12F);
            this.button1.Location = new System.Drawing.Point(423, 34);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 29);
            this.button1.TabIndex = 2;
            this.button1.Text = "Browse...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.Font = new System.Drawing.Font("Consolas", 12F);
            this.button2.Location = new System.Drawing.Point(423, 86);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 29);
            this.button2.TabIndex = 5;
            this.button2.Text = "Browse...";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ingredientScriptPath
            // 
            this.ingredientScriptPath.Font = new System.Drawing.Font("Consolas", 12F);
            this.ingredientScriptPath.Location = new System.Drawing.Point(17, 88);
            this.ingredientScriptPath.Name = "ingredientScriptPath";
            this.ingredientScriptPath.ReadOnly = true;
            this.ingredientScriptPath.Size = new System.Drawing.Size(400, 26);
            this.ingredientScriptPath.TabIndex = 4;
            this.ingredientScriptPath.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 12F);
            this.label2.Location = new System.Drawing.Point(13, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(243, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Select ingredient script: ";
            // 
            // button3
            // 
            this.button3.AutoSize = true;
            this.button3.Font = new System.Drawing.Font("Consolas", 12F);
            this.button3.Location = new System.Drawing.Point(423, 138);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 29);
            this.button3.TabIndex = 8;
            this.button3.Text = "Browse...";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // recipeScriptPath
            // 
            this.recipeScriptPath.Font = new System.Drawing.Font("Consolas", 12F);
            this.recipeScriptPath.Location = new System.Drawing.Point(17, 140);
            this.recipeScriptPath.Name = "recipeScriptPath";
            this.recipeScriptPath.ReadOnly = true;
            this.recipeScriptPath.Size = new System.Drawing.Size(400, 26);
            this.recipeScriptPath.TabIndex = 7;
            this.recipeScriptPath.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 12F);
            this.label3.Location = new System.Drawing.Point(13, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(207, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "Select recipe script: ";
            // 
            // cancelLoadBnt
            // 
            this.cancelLoadBnt.AutoSize = true;
            this.cancelLoadBnt.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelLoadBnt.Location = new System.Drawing.Point(98, 172);
            this.cancelLoadBnt.Name = "cancelLoadBnt";
            this.cancelLoadBnt.Size = new System.Drawing.Size(75, 29);
            this.cancelLoadBnt.TabIndex = 10;
            this.cancelLoadBnt.Text = "Cancel";
            this.cancelLoadBnt.UseVisualStyleBackColor = true;
            this.cancelLoadBnt.Click += new System.EventHandler(this.cancelLoadBnt_Click);
            // 
            // loadScriptBnt
            // 
            this.loadScriptBnt.AutoSize = true;
            this.loadScriptBnt.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadScriptBnt.Location = new System.Drawing.Point(17, 172);
            this.loadScriptBnt.Name = "loadScriptBnt";
            this.loadScriptBnt.Size = new System.Drawing.Size(75, 29);
            this.loadScriptBnt.TabIndex = 9;
            this.loadScriptBnt.Text = "Load";
            this.loadScriptBnt.UseVisualStyleBackColor = true;
            this.loadScriptBnt.Click += new System.EventHandler(this.loadScriptBnt_Click);
            // 
            // LoadScriptForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 210);
            this.Controls.Add(this.cancelLoadBnt);
            this.Controls.Add(this.loadScriptBnt);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.recipeScriptPath);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.ingredientScriptPath);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cookwareScriptPath);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "LoadScriptForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Load Script(s)";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox cookwareScriptPath;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox ingredientScriptPath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox recipeScriptPath;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button cancelLoadBnt;
        private System.Windows.Forms.Button loadScriptBnt;

    }
}