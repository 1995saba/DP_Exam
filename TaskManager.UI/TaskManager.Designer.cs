namespace TaskManager.UI
{
    partial class TaskManager
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.addTaskButton = new System.Windows.Forms.Button();
            this.addTagButton = new System.Windows.Forms.Button();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.deadlinePicker = new System.Windows.Forms.DateTimePicker();
            this.priorityNum = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tagTextBox = new System.Windows.Forms.TextBox();
            this.taskListView = new System.Windows.Forms.ListView();
            this.saveButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.tagsListBox = new System.Windows.Forms.CheckedListBox();
            this.paramTextBox = new System.Windows.Forms.TextBox();
            this.nameRadioButton = new System.Windows.Forms.RadioButton();
            this.creationDateRadioButton = new System.Windows.Forms.RadioButton();
            this.deadlineRadioButton = new System.Windows.Forms.RadioButton();
            this.tagRadioButton = new System.Windows.Forms.RadioButton();
            this.priorityRadioButton = new System.Windows.Forms.RadioButton();
            this.searchButton = new System.Windows.Forms.Button();
            this.showAllButton = new System.Windows.Forms.Button();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.priorityNum)).BeginInit();
            this.SuspendLayout();
            // 
            // addTaskButton
            // 
            this.addTaskButton.Location = new System.Drawing.Point(87, 242);
            this.addTaskButton.Name = "addTaskButton";
            this.addTaskButton.Size = new System.Drawing.Size(75, 23);
            this.addTaskButton.TabIndex = 0;
            this.addTaskButton.Text = "Add Task";
            this.addTaskButton.UseVisualStyleBackColor = true;
            this.addTaskButton.Click += new System.EventHandler(this.AddTaskButton_Click);
            // 
            // addTagButton
            // 
            this.addTagButton.Location = new System.Drawing.Point(88, 378);
            this.addTagButton.Name = "addTagButton";
            this.addTagButton.Size = new System.Drawing.Size(75, 23);
            this.addTagButton.TabIndex = 1;
            this.addTagButton.Text = "AddTag";
            this.addTagButton.UseVisualStyleBackColor = true;
            this.addTagButton.Click += new System.EventHandler(this.AddTagButton_Click);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(22, 33);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(201, 20);
            this.nameTextBox.TabIndex = 2;
            // 
            // deadlinePicker
            // 
            this.deadlinePicker.Location = new System.Drawing.Point(74, 80);
            this.deadlinePicker.Name = "deadlinePicker";
            this.deadlinePicker.Size = new System.Drawing.Size(148, 20);
            this.deadlinePicker.TabIndex = 5;
            // 
            // priorityNum
            // 
            this.priorityNum.Location = new System.Drawing.Point(103, 106);
            this.priorityNum.Name = "priorityNum";
            this.priorityNum.Size = new System.Drawing.Size(120, 20);
            this.priorityNum.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "New Task";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Deadline";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Priority";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Choose Tags";
            // 
            // tagTextBox
            // 
            this.tagTextBox.Location = new System.Drawing.Point(23, 333);
            this.tagTextBox.Name = "tagTextBox";
            this.tagTextBox.Size = new System.Drawing.Size(200, 20);
            this.tagTextBox.TabIndex = 12;
            // 
            // taskListView
            // 
            this.taskListView.Location = new System.Drawing.Point(273, 166);
            this.taskListView.Name = "taskListView";
            this.taskListView.Size = new System.Drawing.Size(736, 270);
            this.taskListView.TabIndex = 13;
            this.taskListView.UseCompatibleStateImageBehavior = false;
            this.taskListView.View = System.Windows.Forms.View.Details;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(566, 479);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 15;
            this.saveButton.Text = "Save As";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.SaveToFileButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(718, 479);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 16;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // tagsListBox
            // 
            this.tagsListBox.FormattingEnabled = true;
            this.tagsListBox.Location = new System.Drawing.Point(22, 166);
            this.tagsListBox.Name = "tagsListBox";
            this.tagsListBox.Size = new System.Drawing.Size(201, 64);
            this.tagsListBox.TabIndex = 17;
            // 
            // paramTextBox
            // 
            this.paramTextBox.Location = new System.Drawing.Point(276, 72);
            this.paramTextBox.Name = "paramTextBox";
            this.paramTextBox.Size = new System.Drawing.Size(504, 20);
            this.paramTextBox.TabIndex = 18;
            // 
            // nameRadioButton
            // 
            this.nameRadioButton.AutoSize = true;
            this.nameRadioButton.Location = new System.Drawing.Point(276, 108);
            this.nameRadioButton.Name = "nameRadioButton";
            this.nameRadioButton.Size = new System.Drawing.Size(53, 17);
            this.nameRadioButton.TabIndex = 19;
            this.nameRadioButton.TabStop = true;
            this.nameRadioButton.Text = "Name";
            this.nameRadioButton.UseVisualStyleBackColor = true;
            // 
            // creationDateRadioButton
            // 
            this.creationDateRadioButton.AutoSize = true;
            this.creationDateRadioButton.Location = new System.Drawing.Point(422, 108);
            this.creationDateRadioButton.Name = "creationDateRadioButton";
            this.creationDateRadioButton.Size = new System.Drawing.Size(90, 17);
            this.creationDateRadioButton.TabIndex = 20;
            this.creationDateRadioButton.TabStop = true;
            this.creationDateRadioButton.Text = "Creation Date";
            this.creationDateRadioButton.UseVisualStyleBackColor = true;
            // 
            // deadlineRadioButton
            // 
            this.deadlineRadioButton.AutoSize = true;
            this.deadlineRadioButton.Location = new System.Drawing.Point(569, 108);
            this.deadlineRadioButton.Name = "deadlineRadioButton";
            this.deadlineRadioButton.Size = new System.Drawing.Size(67, 17);
            this.deadlineRadioButton.TabIndex = 21;
            this.deadlineRadioButton.TabStop = true;
            this.deadlineRadioButton.Text = "Deadline";
            this.deadlineRadioButton.UseVisualStyleBackColor = true;
            // 
            // tagRadioButton
            // 
            this.tagRadioButton.AutoSize = true;
            this.tagRadioButton.Location = new System.Drawing.Point(705, 108);
            this.tagRadioButton.Name = "tagRadioButton";
            this.tagRadioButton.Size = new System.Drawing.Size(44, 17);
            this.tagRadioButton.TabIndex = 22;
            this.tagRadioButton.TabStop = true;
            this.tagRadioButton.Text = "Tag";
            this.tagRadioButton.UseVisualStyleBackColor = true;
            // 
            // priorityRadioButton
            // 
            this.priorityRadioButton.AutoSize = true;
            this.priorityRadioButton.Location = new System.Drawing.Point(839, 108);
            this.priorityRadioButton.Name = "priorityRadioButton";
            this.priorityRadioButton.Size = new System.Drawing.Size(56, 17);
            this.priorityRadioButton.TabIndex = 23;
            this.priorityRadioButton.TabStop = true;
            this.priorityRadioButton.Text = "Priority";
            this.priorityRadioButton.UseVisualStyleBackColor = true;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(839, 69);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 24;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // showAllButton
            // 
            this.showAllButton.Location = new System.Drawing.Point(402, 12);
            this.showAllButton.Name = "showAllButton";
            this.showAllButton.Size = new System.Drawing.Size(428, 41);
            this.showAllButton.TabIndex = 25;
            this.showAllButton.Text = "Show All";
            this.showAllButton.UseVisualStyleBackColor = true;
            this.showAllButton.Click += new System.EventHandler(this.ShowAllButton_Click);
            // 
            // TaskManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 563);
            this.Controls.Add(this.showAllButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.priorityRadioButton);
            this.Controls.Add(this.tagRadioButton);
            this.Controls.Add(this.deadlineRadioButton);
            this.Controls.Add(this.creationDateRadioButton);
            this.Controls.Add(this.nameRadioButton);
            this.Controls.Add(this.paramTextBox);
            this.Controls.Add(this.tagsListBox);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.taskListView);
            this.Controls.Add(this.tagTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.priorityNum);
            this.Controls.Add(this.deadlinePicker);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.addTagButton);
            this.Controls.Add(this.addTaskButton);
            this.Name = "TaskManager";
            this.Text = "Task Manager";
            ((System.ComponentModel.ISupportInitialize)(this.priorityNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addTaskButton;
        private System.Windows.Forms.Button addTagButton;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.DateTimePicker deadlinePicker;
        private System.Windows.Forms.NumericUpDown priorityNum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tagTextBox;
        private System.Windows.Forms.ListView taskListView;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.CheckedListBox tagsListBox;
        private System.Windows.Forms.TextBox paramTextBox;
        private System.Windows.Forms.RadioButton nameRadioButton;
        private System.Windows.Forms.RadioButton creationDateRadioButton;
        private System.Windows.Forms.RadioButton deadlineRadioButton;
        private System.Windows.Forms.RadioButton tagRadioButton;
        private System.Windows.Forms.RadioButton priorityRadioButton;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button showAllButton;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
    }
}

