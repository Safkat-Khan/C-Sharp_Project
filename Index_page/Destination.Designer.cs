﻿namespace Index_page
{
    partial class Destination
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Destination));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            dateTimePicker1 = new DateTimePicker();
            comboBox1 = new ComboBox();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            label7 = new Label();
            button2 = new Button();
            frmcom = new ComboBox();
            tocombo = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Green;
            label1.Location = new Point(104, 78);
            label1.Name = "label1";
            label1.Size = new Size(540, 38);
            label1.TabIndex = 2;
            label1.Text = "A Simple Way To Buy Tickets From Home";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(826, 539);
            label2.Name = "label2";
            label2.Size = new Size(0, 20);
            label2.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(69, 192);
            label3.Name = "label3";
            label3.Size = new Size(59, 28);
            label3.TabIndex = 3;
            label3.Text = "From";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(406, 192);
            label4.Name = "label4";
            label4.Size = new Size(33, 28);
            label4.TabIndex = 4;
            label4.Text = "To";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(73, 324);
            label5.Name = "label5";
            label5.Size = new Size(147, 28);
            label5.TabIndex = 5;
            label5.Text = "Choose a Class";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(406, 318);
            label6.Name = "label6";
            label6.Size = new Size(157, 28);
            label6.TabIndex = 6;
            label6.Text = "Date of Journey";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dateTimePicker1.Location = new Point(406, 370);
            dateTimePicker1.MaxDate = new DateTime(2026, 12, 31, 0, 0, 0, 0);
            dateTimePicker1.MinDate = new DateTime(2022, 1, 1, 0, 0, 0, 0);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 9;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            comboBox1.ForeColor = SystemColors.ControlDarkDark;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "AC_BERTH", "AC_SEAT", "NORMAL_BERTH", "NORMAL_SEAT" });
            comboBox1.Location = new Point(69, 372);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(250, 31);
            comboBox1.TabIndex = 10;
            comboBox1.Text = "Seats";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(765, -31);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(977, 1014);
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.Green;
            button1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.HighlightText;
            button1.Location = new Point(216, 471);
            button1.Name = "button1";
            button1.Size = new Size(277, 46);
            button1.TabIndex = 1;
            button1.Text = "Search Tarins";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(69, 650);
            label7.Name = "label7";
            label7.Size = new Size(600, 112);
            label7.TabIndex = 13;
            label7.Text = resources.GetString("label7.Text");
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button2
            // 
            button2.Location = new Point(2, -1);
            button2.Name = "button2";
            button2.Size = new Size(126, 43);
            button2.TabIndex = 14;
            button2.Text = "◁ Back";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // frmcom
            // 
            frmcom.FormattingEnabled = true;
            frmcom.Location = new Point(69, 232);
            frmcom.Name = "frmcom";
            frmcom.Size = new Size(250, 28);
            frmcom.TabIndex = 15;
            frmcom.Text = "From Station";
            frmcom.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // tocombo
            // 
            tocombo.FormattingEnabled = true;
            tocombo.Location = new Point(406, 232);
            tocombo.Name = "tocombo";
            tocombo.Size = new Size(250, 28);
            tocombo.TabIndex = 15;
            tocombo.Text = "To Station";
            // 
            // Destination
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HighlightText;
            ClientSize = new Size(1737, 972);
            ControlBox = false;
            Controls.Add(tocombo);
            Controls.Add(frmcom);
            Controls.Add(button2);
            Controls.Add(label7);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Controls.Add(comboBox1);
            Controls.Add(dateTimePicker1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Destination";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "E-Ticket";
            Load += Form4_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private DateTimePicker dateTimePicker1;
        private ComboBox comboBox1;
        private PictureBox pictureBox1;
        private Button button1;
        private Label label7;
        private Button button6;
        private Button button2;
        private ComboBox frmcom;
        private ComboBox tocombo;
    }
}