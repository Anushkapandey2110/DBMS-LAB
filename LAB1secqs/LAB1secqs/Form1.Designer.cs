namespace LAB1secqs
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
            this.textbox1 = new System.Windows.Forms.TextBox();
            this.cb1 = new System.Windows.Forms.ComboBox();
            this.textbox2 = new System.Windows.Forms.TextBox();
            this.b1 = new System.Windows.Forms.RadioButton();
            this.b2 = new System.Windows.Forms.RadioButton();
            this.b3 = new System.Windows.Forms.RadioButton();
            this.checkbox1 = new System.Windows.Forms.CheckBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.submit = new System.Windows.Forms.Button();
            this.form = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Button();
            this.regno = new System.Windows.Forms.Button();
            this.messagebox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // textbox1
            // 
            this.textbox1.Location = new System.Drawing.Point(119, 73);
            this.textbox1.Name = "textbox1";
            this.textbox1.Size = new System.Drawing.Size(320, 20);
            this.textbox1.TabIndex = 0;
            this.textbox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // cb1
            // 
            this.cb1.FormattingEnabled = true;
            this.cb1.Items.AddRange(new object[] {
            "Year"});
            this.cb1.Location = new System.Drawing.Point(12, 177);
            this.cb1.Name = "cb1";
            this.cb1.Size = new System.Drawing.Size(121, 21);
            this.cb1.TabIndex = 1;
            this.cb1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // textbox2
            // 
            this.textbox2.Location = new System.Drawing.Point(119, 117);
            this.textbox2.Name = "textbox2";
            this.textbox2.Size = new System.Drawing.Size(320, 20);
            this.textbox2.TabIndex = 2;
            // 
            // b1
            // 
            this.b1.AutoSize = true;
            this.b1.Location = new System.Drawing.Point(13, 232);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(61, 17);
            this.b1.TabIndex = 3;
            this.b1.TabStop = true;
            this.b1.Text = "Block 1";
            this.b1.UseVisualStyleBackColor = true;
            this.b1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // b2
            // 
            this.b2.AutoSize = true;
            this.b2.Location = new System.Drawing.Point(13, 256);
            this.b2.Name = "b2";
            this.b2.Size = new System.Drawing.Size(61, 17);
            this.b2.TabIndex = 4;
            this.b2.TabStop = true;
            this.b2.Text = "Block 2";
            this.b2.UseVisualStyleBackColor = true;
            // 
            // b3
            // 
            this.b3.AutoSize = true;
            this.b3.Location = new System.Drawing.Point(13, 280);
            this.b3.Name = "b3";
            this.b3.Size = new System.Drawing.Size(61, 17);
            this.b3.TabIndex = 5;
            this.b3.TabStop = true;
            this.b3.Text = "Block 3";
            this.b3.UseVisualStyleBackColor = true;
            // 
            // checkbox1
            // 
            this.checkbox1.AutoSize = true;
            this.checkbox1.Location = new System.Drawing.Point(12, 324);
            this.checkbox1.Name = "checkbox1";
            this.checkbox1.Size = new System.Drawing.Size(120, 17);
            this.checkbox1.TabIndex = 6;
            this.checkbox1.Text = "I have paid the fees";
            this.checkbox1.UseVisualStyleBackColor = true;
            this.checkbox1.CheckedChanged += new System.EventHandler(this.checkbox1_CheckedChanged);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(474, 36);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 7;
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(13, 369);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(75, 23);
            this.submit.TabIndex = 8;
            this.submit.Text = "submit";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // form
            // 
            this.form.AutoSize = true;
            this.form.Location = new System.Drawing.Point(345, 9);
            this.form.Name = "form";
            this.form.Size = new System.Drawing.Size(38, 13);
            this.form.TabIndex = 9;
            this.form.Text = "FORM";
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(-1, 73);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(75, 20);
            this.name.TabIndex = 10;
            this.name.Text = "Name";
            this.name.UseVisualStyleBackColor = true;
            this.name.Click += new System.EventHandler(this.name_Click);
            // 
            // regno
            // 
            this.regno.Location = new System.Drawing.Point(-1, 114);
            this.regno.Name = "regno";
            this.regno.Size = new System.Drawing.Size(114, 23);
            this.regno.TabIndex = 11;
            this.regno.Text = "Registration number";
            this.regno.UseVisualStyleBackColor = true;
            this.regno.Click += new System.EventHandler(this.regno_Click);
            // 
            // messagebox
            // 
            this.messagebox.Location = new System.Drawing.Point(47, 436);
            this.messagebox.Name = "messagebox";
            this.messagebox.Size = new System.Drawing.Size(175, 96);
            this.messagebox.TabIndex = 12;
            this.messagebox.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 568);
            this.Controls.Add(this.messagebox);
            this.Controls.Add(this.regno);
            this.Controls.Add(this.name);
            this.Controls.Add(this.form);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.checkbox1);
            this.Controls.Add(this.b3);
            this.Controls.Add(this.b2);
            this.Controls.Add(this.b1);
            this.Controls.Add(this.textbox2);
            this.Controls.Add(this.cb1);
            this.Controls.Add(this.textbox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textbox1;
        private System.Windows.Forms.ComboBox cb1;
        private System.Windows.Forms.TextBox textbox2;
        private System.Windows.Forms.RadioButton b1;
        private System.Windows.Forms.RadioButton b2;
        private System.Windows.Forms.RadioButton b3;
        private System.Windows.Forms.CheckBox checkbox1;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.Label form;
        private System.Windows.Forms.Button name;
        private System.Windows.Forms.Button regno;
        private System.Windows.Forms.RichTextBox messagebox;
    }
}

