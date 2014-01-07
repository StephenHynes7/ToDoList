namespace ToDoList
{
    partial class Form1
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
            this.Input = new System.Windows.Forms.RichTextBox();
            this.AddTask = new System.Windows.Forms.Button();
            this.FinishedBtn = new System.Windows.Forms.Button();
            this.RemoveBtn = new System.Windows.Forms.Button();
            this.ToDoTasks = new System.Windows.Forms.ListBox();
            this.FinishedTasks = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Input
            // 
            this.Input.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Input.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Input.Location = new System.Drawing.Point(150, 50);
            this.Input.Name = "Input";
            this.Input.Size = new System.Drawing.Size(414, 27);
            this.Input.TabIndex = 0;
            this.Input.Text = "";
            this.Input.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // AddTask
            // 
            this.AddTask.Location = new System.Drawing.Point(212, 84);
            this.AddTask.Name = "AddTask";
            this.AddTask.Size = new System.Drawing.Size(75, 23);
            this.AddTask.TabIndex = 2;
            this.AddTask.Text = "Add Task";
            this.AddTask.UseVisualStyleBackColor = true;
            this.AddTask.Click += new System.EventHandler(this.AddTask_Click);
            // 
            // FinishedBtn
            // 
            this.FinishedBtn.Location = new System.Drawing.Point(327, 84);
            this.FinishedBtn.Name = "FinishedBtn";
            this.FinishedBtn.Size = new System.Drawing.Size(75, 23);
            this.FinishedBtn.TabIndex = 3;
            this.FinishedBtn.Text = "Finished";
            this.FinishedBtn.UseVisualStyleBackColor = true;
            this.FinishedBtn.Click += new System.EventHandler(this.FinishedBtn_Click);
            // 
            // RemoveBtn
            // 
            this.RemoveBtn.Location = new System.Drawing.Point(435, 83);
            this.RemoveBtn.Name = "RemoveBtn";
            this.RemoveBtn.Size = new System.Drawing.Size(75, 23);
            this.RemoveBtn.TabIndex = 4;
            this.RemoveBtn.Text = "Remove";
            this.RemoveBtn.UseVisualStyleBackColor = true;
            this.RemoveBtn.Click += new System.EventHandler(this.RemoveBtn_Click);
            // 
            // ToDoTasks
            // 
            this.ToDoTasks.BackColor = System.Drawing.SystemColors.Menu;
            this.ToDoTasks.FormattingEnabled = true;
            this.ToDoTasks.Location = new System.Drawing.Point(150, 121);
            this.ToDoTasks.Name = "ToDoTasks";
            this.ToDoTasks.Size = new System.Drawing.Size(414, 199);
            this.ToDoTasks.TabIndex = 1;
            // 
            // FinishedTasks
            // 
            this.FinishedTasks.BackColor = System.Drawing.SystemColors.Menu;
            this.FinishedTasks.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FinishedTasks.FormattingEnabled = true;
            this.FinishedTasks.Location = new System.Drawing.Point(150, 343);
            this.FinishedTasks.Name = "FinishedTasks";
            this.FinishedTasks.Size = new System.Drawing.Size(414, 199);
            this.FinishedTasks.TabIndex = 5;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(780, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 554);
            this.Controls.Add(this.FinishedTasks);
            this.Controls.Add(this.RemoveBtn);
            this.Controls.Add(this.FinishedBtn);
            this.Controls.Add(this.AddTask);
            this.Controls.Add(this.ToDoTasks);
            this.Controls.Add(this.Input);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "To Do List";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox Input;
        private System.Windows.Forms.Button AddTask;
        private System.Windows.Forms.Button FinishedBtn;
        private System.Windows.Forms.Button RemoveBtn;
        private System.Windows.Forms.ListBox ToDoTasks;
        private System.Windows.Forms.ListBox FinishedTasks;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
    }
}

