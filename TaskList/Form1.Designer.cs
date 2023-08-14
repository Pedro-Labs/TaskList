namespace TaskList
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            GridTasks = new DataGridView();
            btnAddTask = new Button();
            btnMarkAsCompleted = new Button();
            btnRemoveTask = new Button();
            ((System.ComponentModel.ISupportInitialize)GridTasks).BeginInit();
            SuspendLayout();
            // 
            // GridTasks
            // 
            GridTasks.AccessibleName = "GridTasks";
            GridTasks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GridTasks.Location = new Point(152, 12);
            GridTasks.Name = "GridTasks";
            GridTasks.RowTemplate.Height = 25;
            GridTasks.Size = new Size(930, 417);
            GridTasks.TabIndex = 0;
            // 
            // btnAddTask
            // 
            btnAddTask.AccessibleName = "btnAddTask";
            btnAddTask.Location = new Point(152, 447);
            btnAddTask.Name = "btnAddTask";
            btnAddTask.Size = new Size(75, 37);
            btnAddTask.TabIndex = 1;
            btnAddTask.Text = "Adicionar";
            btnAddTask.UseVisualStyleBackColor = true;
            btnAddTask.Click += btnAddTask_Click;
            // 
            // btnMarkAsCompleted
            // 
            btnMarkAsCompleted.Location = new Point(233, 447);
            btnMarkAsCompleted.Name = "btnMarkAsCompleted";
            btnMarkAsCompleted.Size = new Size(75, 37);
            btnMarkAsCompleted.TabIndex = 3;
            btnMarkAsCompleted.Text = "Feito";
            btnMarkAsCompleted.UseVisualStyleBackColor = true;
            btnMarkAsCompleted.Click += btnMarkAsCompleted_Click;
            // 
            // btnRemoveTask
            // 
            btnRemoveTask.Location = new Point(314, 447);
            btnRemoveTask.Name = "btnRemoveTask";
            btnRemoveTask.Size = new Size(75, 37);
            btnRemoveTask.TabIndex = 2;
            btnRemoveTask.Text = "Remover";
            btnRemoveTask.UseVisualStyleBackColor = true;
            btnRemoveTask.Click += btnRemoveTask_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1207, 496);
            Controls.Add(btnMarkAsCompleted);
            Controls.Add(btnRemoveTask);
            Controls.Add(btnAddTask);
            Controls.Add(GridTasks);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)GridTasks).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView GridTasks;
        private Button btnAddTask;
        private Button btnMarkAsCompleted;
        private Button btnRemoveTask;
    }
}
