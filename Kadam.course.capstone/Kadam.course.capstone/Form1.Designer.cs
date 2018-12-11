namespace Kadam.course.capstone
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label coursNOLabel1;
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.Name = new System.Windows.Forms.TextBox();
            this.Number = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.Hybrid = new System.Windows.Forms.RadioButton();
            this.Number1 = new System.Windows.Forms.TextBox();
            this.Name1 = new System.Windows.Forms.TextBox();
            this.Date = new System.Windows.Forms.TextBox();
            this.Coursenumber = new System.Windows.Forms.TextBox();
            this.Type = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.online = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.capstoneDataSet = new Kadam.course.capstone.CapstoneDataSet();
            this.numberBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.numberTableAdapter = new Kadam.course.capstone.CapstoneDataSetTableAdapters.NumberTableAdapter();
            this.tableAdapterManager = new Kadam.course.capstone.CapstoneDataSetTableAdapters.TableAdapterManager();
            this.numberBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.capstoneDataSet1 = new Kadam.course.capstone.CapstoneDataSet1();
            this.numberBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.numberTableAdapter1 = new Kadam.course.capstone.CapstoneDataSet1TableAdapters.NumberTableAdapter();
            this.tableAdapterManager1 = new Kadam.course.capstone.CapstoneDataSet1TableAdapters.TableAdapterManager();
            this.coursNOComboBox = new System.Windows.Forms.ComboBox();
            coursNOLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.capstoneDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.capstoneDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // coursNOLabel1
            // 
            coursNOLabel1.AutoSize = true;
            coursNOLabel1.Location = new System.Drawing.Point(36, 202);
            coursNOLabel1.Name = "coursNOLabel1";
            coursNOLabel1.Size = new System.Drawing.Size(82, 17);
            coursNOLabel1.TabIndex = 28;
            coursNOLabel1.Text = "Course NO:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = " Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Start Date";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Number of courses";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 255);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Type";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(377, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Number of courses";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(377, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = " Name";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(377, 251);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 17);
            this.label8.TabIndex = 7;
            this.label8.Text = "Type";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(377, 198);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(107, 17);
            this.label9.TabIndex = 8;
            this.label9.Text = "Course Number";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(377, 140);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 17);
            this.label10.TabIndex = 9;
            this.label10.Text = "Start Date";
            // 
            // Name
            // 
            this.Name.Location = new System.Drawing.Point(235, 12);
            this.Name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(100, 22);
            this.Name.TabIndex = 10;
            // 
            // Number
            // 
            this.Number.Location = new System.Drawing.Point(235, 70);
            this.Number.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Number.Name = "Number";
            this.Number.Size = new System.Drawing.Size(100, 22);
            this.Number.TabIndex = 11;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(133, 135);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker1.MaxDate = new System.DateTime(2019, 1, 31, 0, 0, 0, 0);
            this.dateTimePicker1.MinDate = new System.DateTime(2019, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 12;
            this.dateTimePicker1.Value = new System.DateTime(2019, 1, 1, 0, 0, 0, 0);
            // 
            // Hybrid
            // 
            this.Hybrid.AutoSize = true;
            this.Hybrid.Location = new System.Drawing.Point(103, 253);
            this.Hybrid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Hybrid.Name = "Hybrid";
            this.Hybrid.Size = new System.Drawing.Size(70, 21);
            this.Hybrid.TabIndex = 14;
            this.Hybrid.Text = "Hybrid";
            this.Hybrid.UseVisualStyleBackColor = true;
            // 
            // Number1
            // 
            this.Number1.Location = new System.Drawing.Point(517, 75);
            this.Number1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Number1.Name = "Number1";
            this.Number1.ReadOnly = true;
            this.Number1.Size = new System.Drawing.Size(100, 22);
            this.Number1.TabIndex = 16;
            // 
            // Name1
            // 
            this.Name1.Location = new System.Drawing.Point(517, 15);
            this.Name1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name1.Name = "Name1";
            this.Name1.ReadOnly = true;
            this.Name1.Size = new System.Drawing.Size(100, 22);
            this.Name1.TabIndex = 17;
            // 
            // Date
            // 
            this.Date.Location = new System.Drawing.Point(517, 137);
            this.Date.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            this.Date.Size = new System.Drawing.Size(100, 22);
            this.Date.TabIndex = 18;
            // 
            // Coursenumber
            // 
            this.Coursenumber.Location = new System.Drawing.Point(517, 193);
            this.Coursenumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Coursenumber.Name = "Coursenumber";
            this.Coursenumber.ReadOnly = true;
            this.Coursenumber.Size = new System.Drawing.Size(100, 22);
            this.Coursenumber.TabIndex = 19;
            // 
            // Type
            // 
            this.Type.Location = new System.Drawing.Point(517, 249);
            this.Type.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Type.Name = "Type";
            this.Type.ReadOnly = true;
            this.Type.Size = new System.Drawing.Size(100, 22);
            this.Type.TabIndex = 20;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(412, 318);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(141, 34);
            this.button2.TabIndex = 22;
            this.button2.Text = "Get";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(304, 388);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(145, 34);
            this.button3.TabIndex = 23;
            this.button3.Text = "Exit";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // online
            // 
            this.online.AutoSize = true;
            this.online.Location = new System.Drawing.Point(189, 253);
            this.online.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.online.Name = "online";
            this.online.Size = new System.Drawing.Size(67, 21);
            this.online.TabIndex = 24;
            this.online.Text = "online";
            this.online.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(189, 318);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 34);
            this.button1.TabIndex = 25;
            this.button1.Text = "Set";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // capstoneDataSet
            // 
            this.capstoneDataSet.DataSetName = "CapstoneDataSet";
            this.capstoneDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // numberBindingSource
            // 
            this.numberBindingSource.DataMember = "Number";
            this.numberBindingSource.DataSource = this.capstoneDataSet;
            // 
            // numberTableAdapter
            // 
            this.numberTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.NumberTableAdapter = this.numberTableAdapter;
            this.tableAdapterManager.UpdateOrder = Kadam.course.capstone.CapstoneDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // numberBindingSource1
            // 
            this.numberBindingSource1.DataMember = "Number";
            this.numberBindingSource1.DataSource = this.capstoneDataSet;
            // 
            // capstoneDataSet1
            // 
            this.capstoneDataSet1.DataSetName = "CapstoneDataSet1";
            this.capstoneDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // numberBindingSource2
            // 
            this.numberBindingSource2.DataMember = "Number";
            this.numberBindingSource2.DataSource = this.capstoneDataSet1;
            // 
            // numberTableAdapter1
            // 
            this.numberTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.NumberTableAdapter = this.numberTableAdapter1;
            this.tableAdapterManager1.UpdateOrder = Kadam.course.capstone.CapstoneDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // coursNOComboBox
            // 
            this.coursNOComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.numberBindingSource, "CoursNO", true));
            this.coursNOComboBox.DataSource = this.numberBindingSource1;
            this.coursNOComboBox.DisplayMember = "CoursNO";
            this.coursNOComboBox.FormattingEnabled = true;
            this.coursNOComboBox.Location = new System.Drawing.Point(133, 195);
            this.coursNOComboBox.Name = "coursNOComboBox";
            this.coursNOComboBox.Size = new System.Drawing.Size(121, 24);
            this.coursNOComboBox.TabIndex = 29;
            this.coursNOComboBox.ValueMember = "CoursNO";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 450);
            this.Controls.Add(coursNOLabel1);
            this.Controls.Add(this.coursNOComboBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.online);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Type);
            this.Controls.Add(this.Coursenumber);
            this.Controls.Add(this.Date);
            this.Controls.Add(this.Name1);
            this.Controls.Add(this.Number1);
            this.Controls.Add(this.Hybrid);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.Number);
            this.Controls.Add(this.Name);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            //this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.capstoneDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.capstoneDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox Name;
        private System.Windows.Forms.TextBox Number;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.RadioButton Hybrid;
        private System.Windows.Forms.TextBox Number1;
        private System.Windows.Forms.TextBox Name1;
        private System.Windows.Forms.TextBox Date;
        private System.Windows.Forms.TextBox Coursenumber;
        private System.Windows.Forms.TextBox Type;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.RadioButton online;
        private System.Windows.Forms.Button button1;
        private CapstoneDataSet capstoneDataSet;
        private System.Windows.Forms.BindingSource numberBindingSource;
        private CapstoneDataSetTableAdapters.NumberTableAdapter numberTableAdapter;
        private CapstoneDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource numberBindingSource1;
        private CapstoneDataSet1 capstoneDataSet1;
        private System.Windows.Forms.BindingSource numberBindingSource2;
        private CapstoneDataSet1TableAdapters.NumberTableAdapter numberTableAdapter1;
        private CapstoneDataSet1TableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.ComboBox coursNOComboBox;
    }
}

