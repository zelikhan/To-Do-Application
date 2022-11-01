namespace To_Do_Application
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tasktitle = new System.Windows.Forms.TextBox();
            this.taskdiscription = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.deadline = new System.Windows.Forms.DateTimePicker();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.addtask = new System.Windows.Forms.Button();
            this.alltask = new System.Windows.Forms.Button();
            this.unitask = new System.Windows.Forms.Button();
            this.imptask = new System.Windows.Forms.Button();
            this.hometask = new System.Windows.Forms.Button();
            this.normaltask = new System.Windows.Forms.Button();
            this.datagrid_show = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.delete = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.Status = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_show)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(2, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(799, 450);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(791, 424);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Add Task";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Silver;
            this.tabPage2.Controls.Add(this.panel3);
            this.tabPage2.Controls.Add(this.datagrid_show);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(791, 424);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Show All Task";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tabPage3.Controls.Add(this.Status);
            this.tabPage3.Controls.Add(this.panel4);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(791, 424);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Delete Task";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "To-Do-Application";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Task Title";
            // 
            // tasktitle
            // 
            this.tasktitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tasktitle.Location = new System.Drawing.Point(186, 12);
            this.tasktitle.Name = "tasktitle";
            this.tasktitle.Size = new System.Drawing.Size(304, 22);
            this.tasktitle.TabIndex = 2;
            // 
            // taskdiscription
            // 
            this.taskdiscription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taskdiscription.Location = new System.Drawing.Point(186, 40);
            this.taskdiscription.Multiline = true;
            this.taskdiscription.Name = "taskdiscription";
            this.taskdiscription.Size = new System.Drawing.Size(304, 79);
            this.taskdiscription.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Task Discription";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 24);
            this.label4.TabIndex = 5;
            this.label4.Text = "Task Type";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(176, 6);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(104, 24);
            this.radioButton1.TabIndex = 6;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Home task";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.Location = new System.Drawing.Point(351, 6);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(129, 24);
            this.radioButton2.TabIndex = 7;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "University task";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(7, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 24);
            this.label5.TabIndex = 8;
            this.label5.Text = "Task DeadLine";
            // 
            // deadline
            // 
            this.deadline.Location = new System.Drawing.Point(186, 173);
            this.deadline.Name = "deadline";
            this.deadline.Size = new System.Drawing.Size(304, 20);
            this.deadline.TabIndex = 9;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton3.Location = new System.Drawing.Point(361, 214);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(77, 24);
            this.radioButton3.TabIndex = 12;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Normal";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton4.Location = new System.Drawing.Point(186, 214);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(96, 24);
            this.radioButton4.TabIndex = 11;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Important";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(7, 213);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 24);
            this.label6.TabIndex = 10;
            this.label6.Text = "Task Level";
            // 
            // addtask
            // 
            this.addtask.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.addtask.Location = new System.Drawing.Point(186, 284);
            this.addtask.Name = "addtask";
            this.addtask.Size = new System.Drawing.Size(128, 30);
            this.addtask.TabIndex = 13;
            this.addtask.Text = "Add Task";
            this.addtask.UseVisualStyleBackColor = false;
            this.addtask.Click += new System.EventHandler(this.addtask_Click);
            // 
            // alltask
            // 
            this.alltask.BackColor = System.Drawing.Color.White;
            this.alltask.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.alltask.Location = new System.Drawing.Point(64, 27);
            this.alltask.Name = "alltask";
            this.alltask.Size = new System.Drawing.Size(128, 30);
            this.alltask.TabIndex = 14;
            this.alltask.Text = "Show All Task";
            this.alltask.UseVisualStyleBackColor = false;
            this.alltask.Click += new System.EventHandler(this.alltask_Click);
            // 
            // unitask
            // 
            this.unitask.BackColor = System.Drawing.Color.White;
            this.unitask.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.unitask.Location = new System.Drawing.Point(275, 11);
            this.unitask.Name = "unitask";
            this.unitask.Size = new System.Drawing.Size(128, 30);
            this.unitask.TabIndex = 15;
            this.unitask.Text = "Show University Task";
            this.unitask.UseVisualStyleBackColor = false;
            this.unitask.Click += new System.EventHandler(this.unitask_Click);
            // 
            // imptask
            // 
            this.imptask.BackColor = System.Drawing.Color.White;
            this.imptask.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.imptask.Location = new System.Drawing.Point(481, 11);
            this.imptask.Name = "imptask";
            this.imptask.Size = new System.Drawing.Size(128, 30);
            this.imptask.TabIndex = 16;
            this.imptask.Text = "Show Important Task";
            this.imptask.UseVisualStyleBackColor = false;
            this.imptask.Click += new System.EventHandler(this.imptask_Click);
            // 
            // hometask
            // 
            this.hometask.BackColor = System.Drawing.Color.White;
            this.hometask.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.hometask.Location = new System.Drawing.Point(275, 47);
            this.hometask.Name = "hometask";
            this.hometask.Size = new System.Drawing.Size(128, 30);
            this.hometask.TabIndex = 17;
            this.hometask.Text = "Show Home Task";
            this.hometask.UseVisualStyleBackColor = false;
            this.hometask.Click += new System.EventHandler(this.hometask_Click);
            // 
            // normaltask
            // 
            this.normaltask.BackColor = System.Drawing.Color.White;
            this.normaltask.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.normaltask.Location = new System.Drawing.Point(481, 47);
            this.normaltask.Name = "normaltask";
            this.normaltask.Size = new System.Drawing.Size(128, 30);
            this.normaltask.TabIndex = 18;
            this.normaltask.Text = "Show Normal Task";
            this.normaltask.UseVisualStyleBackColor = false;
            this.normaltask.Click += new System.EventHandler(this.normaltask_Click);
            // 
            // datagrid_show
            // 
            this.datagrid_show.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.datagrid_show.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid_show.Location = new System.Drawing.Point(66, 95);
            this.datagrid_show.Name = "datagrid_show";
            this.datagrid_show.Size = new System.Drawing.Size(666, 319);
            this.datagrid_show.TabIndex = 19;
            this.datagrid_show.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagrid_show_CellContentClick);
            // 
            // id
            // 
            this.id.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id.Location = new System.Drawing.Point(201, 12);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(75, 22);
            this.id.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(17, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(142, 24);
            this.label7.TabIndex = 3;
            this.label7.Text = "Enter ID of Task";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(243, 55);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(267, 29);
            this.label8.TabIndex = 5;
            this.label8.Text = "Delete any Task by ID";
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.delete.Location = new System.Drawing.Point(148, 64);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(128, 30);
            this.delete.TabIndex = 14;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = false;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(255, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(308, 45);
            this.panel1.TabIndex = 14;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.addtask);
            this.panel2.Controls.Add(this.radioButton3);
            this.panel2.Controls.Add(this.radioButton4);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.deadline);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.taskdiscription);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.tasktitle);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(18, 53);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(756, 338);
            this.panel2.TabIndex = 15;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel3.Controls.Add(this.normaltask);
            this.panel3.Controls.Add(this.hometask);
            this.panel3.Controls.Add(this.imptask);
            this.panel3.Controls.Add(this.unitask);
            this.panel3.Controls.Add(this.alltask);
            this.panel3.Location = new System.Drawing.Point(66, 7);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(665, 88);
            this.panel3.TabIndex = 20;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel4.Controls.Add(this.delete);
            this.panel4.Controls.Add(this.id);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Location = new System.Drawing.Point(192, 132);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(366, 108);
            this.panel4.TabIndex = 15;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.radioButton2);
            this.panel5.Controls.Add(this.radioButton1);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Location = new System.Drawing.Point(11, 125);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(496, 38);
            this.panel5.TabIndex = 14;
            // 
            // Status
            // 
            this.Status.AutoSize = true;
            this.Status.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Status.Location = new System.Drawing.Point(302, 297);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(164, 20);
            this.Status.TabIndex = 16;
            this.Status.Text = "Status...........................";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_show)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button addtask;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker deadline;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox taskdiscription;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tasktitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView datagrid_show;
        private System.Windows.Forms.Button normaltask;
        private System.Windows.Forms.Button hometask;
        private System.Windows.Forms.Button imptask;
        private System.Windows.Forms.Button unitask;
        private System.Windows.Forms.Button alltask;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label Status;
    }
}

