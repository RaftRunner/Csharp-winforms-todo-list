namespace toDoList
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtTaskInput = new System.Windows.Forms.TextBox();
            this.btnAddTask = new System.Windows.Forms.Button();
            this.listBoxTasks = new System.Windows.Forms.ListBox();
            this.btnRemoveTask = new System.Windows.Forms.Button();
            this.btnSaveTasks = new System.Windows.Forms.Button();
            this.btnLoadTasks = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtTaskInput
            // 
            this.txtTaskInput.Location = new System.Drawing.Point(12, 12);
            this.txtTaskInput.Name = "txtTaskInput";
            this.txtTaskInput.Size = new System.Drawing.Size(260, 20);
            this.txtTaskInput.TabIndex = 0;
            // 
            // btnAddTask
            // 
            this.btnAddTask.Location = new System.Drawing.Point(278, 10);
            this.btnAddTask.Name = "btnAddTask";
            this.btnAddTask.Size = new System.Drawing.Size(75, 23);
            this.btnAddTask.TabIndex = 1;
            this.btnAddTask.Text = "Add Task";
            this.btnAddTask.UseVisualStyleBackColor = true;
            this.btnAddTask.Click += new System.EventHandler(this.btnAddTask_Click);
            // 
            // listBoxTasks
            // 
            this.listBoxTasks.FormattingEnabled = true;
            this.listBoxTasks.Location = new System.Drawing.Point(12, 38);
            this.listBoxTasks.Name = "listBoxTasks";
            this.listBoxTasks.Size = new System.Drawing.Size(341, 147);
            this.listBoxTasks.TabIndex = 2;
            // 
            // btnRemoveTask
            // 
            this.btnRemoveTask.Location = new System.Drawing.Point(12, 191);
            this.btnRemoveTask.Name = "btnRemoveTask";
            this.btnRemoveTask.Size = new System.Drawing.Size(90, 23);
            this.btnRemoveTask.TabIndex = 3;
            this.btnRemoveTask.Text = "Remove Task";
            this.btnRemoveTask.UseVisualStyleBackColor = true;
            this.btnRemoveTask.Click += new System.EventHandler(this.btnRemoveTask_Click);
            // 
            // btnSaveTasks
            // 
            this.btnSaveTasks.Location = new System.Drawing.Point(138, 191);
            this.btnSaveTasks.Name = "btnSaveTasks";
            this.btnSaveTasks.Size = new System.Drawing.Size(90, 23);
            this.btnSaveTasks.TabIndex = 4;
            this.btnSaveTasks.Text = "Save Tasks";
            this.btnSaveTasks.UseVisualStyleBackColor = true;
            this.btnSaveTasks.Click += new System.EventHandler(this.btnSaveTasks_Click);
            // 
            // btnLoadTasks
            // 
            this.btnLoadTasks.Location = new System.Drawing.Point(263, 191);
            this.btnLoadTasks.Name = "btnLoadTasks";
            this.btnLoadTasks.Size = new System.Drawing.Size(90, 23);
            this.btnLoadTasks.TabIndex = 5;
            this.btnLoadTasks.Text = "Load Tasks";
            this.btnLoadTasks.UseVisualStyleBackColor = true;
            this.btnLoadTasks.Click += new System.EventHandler(this.btnLoadTasks_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 226);
            this.Controls.Add(this.btnLoadTasks);
            this.Controls.Add(this.btnSaveTasks);
            this.Controls.Add(this.btnRemoveTask);
            this.Controls.Add(this.listBoxTasks);
            this.Controls.Add(this.btnAddTask);
            this.Controls.Add(this.txtTaskInput);
            this.Name = "Form1";
            this.Text = "To-Do List";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox txtTaskInput;
        private System.Windows.Forms.Button btnAddTask;
        private System.Windows.Forms.ListBox listBoxTasks;
        private System.Windows.Forms.Button btnRemoveTask;
        private System.Windows.Forms.Button btnSaveTasks;
        private System.Windows.Forms.Button btnLoadTasks;
    }
}
