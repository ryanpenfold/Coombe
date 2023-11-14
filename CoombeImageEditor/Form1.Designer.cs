namespace CoombeImageEditor
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
            this.label1 = new System.Windows.Forms.Label();
            this.metabox = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnFolder = new System.Windows.Forms.Button();
            this.metaType = new System.Windows.Forms.ComboBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.metaName = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.metaFormat = new System.Windows.Forms.TextBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.panel1 = new System.Windows.Forms.Panel();
            this.generateProjectBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.isoChoose = new System.Windows.Forms.OpenFileDialog();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.metabox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Project Folder (location for Project.XML)";
            // 
            // metabox
            // 
            this.metabox.Controls.Add(this.metaName);
            this.metabox.Controls.Add(this.label3);
            this.metabox.Controls.Add(this.label2);
            this.metabox.Controls.Add(this.metaType);
            this.metabox.Location = new System.Drawing.Point(15, 37);
            this.metabox.Name = "metabox";
            this.metabox.Size = new System.Drawing.Size(773, 101);
            this.metabox.TabIndex = 1;
            this.metabox.TabStop = false;
            this.metabox.Text = "Metadata (meta)";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(259, 6);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(494, 22);
            this.textBox1.TabIndex = 0;
            // 
            // btnFolder
            // 
            this.btnFolder.Location = new System.Drawing.Point(759, 6);
            this.btnFolder.Name = "btnFolder";
            this.btnFolder.Size = new System.Drawing.Size(29, 23);
            this.btnFolder.TabIndex = 1;
            this.btnFolder.Text = "...";
            this.btnFolder.UseVisualStyleBackColor = true;
            this.btnFolder.Click += new System.EventHandler(this.btnFolder_Click);
            // 
            // metaType
            // 
            this.metaType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.metaType.FormattingEnabled = true;
            this.metaType.Items.AddRange(new object[] {
            "iso",
            "floppy",
            "vhd"});
            this.metaType.Location = new System.Drawing.Point(94, 17);
            this.metaType.Name = "metaType";
            this.metaType.Size = new System.Drawing.Size(663, 24);
            this.metaType.TabIndex = 2;
            this.metaType.SelectedIndexChanged += new System.EventHandler(this.metaType_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Image Type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Image Name";
            // 
            // metaName
            // 
            this.metaName.Location = new System.Drawing.Point(99, 56);
            this.metaName.Name = "metaName";
            this.metaName.Size = new System.Drawing.Size(658, 22);
            this.metaName.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numericUpDown1);
            this.groupBox1.Controls.Add(this.metaFormat);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(15, 144);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(773, 101);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "FileSystem";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Image Size (MB)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "Image Format";
            // 
            // metaFormat
            // 
            this.metaFormat.Location = new System.Drawing.Point(99, 17);
            this.metaFormat.Name = "metaFormat";
            this.metaFormat.Size = new System.Drawing.Size(658, 22);
            this.metaFormat.TabIndex = 5;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(119, 54);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(638, 22);
            this.numericUpDown1.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.generateProjectBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 350);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(809, 100);
            this.panel1.TabIndex = 7;
            // 
            // generateProjectBtn
            // 
            this.generateProjectBtn.Location = new System.Drawing.Point(3, 3);
            this.generateProjectBtn.Name = "generateProjectBtn";
            this.generateProjectBtn.Size = new System.Drawing.Size(185, 23);
            this.generateProjectBtn.TabIndex = 0;
            this.generateProjectBtn.Text = "Generate/Save Project";
            this.generateProjectBtn.UseVisualStyleBackColor = true;
            this.generateProjectBtn.Click += new System.EventHandler(this.generateProjectBtn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(185, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Open Project in Explorer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(194, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(185, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Load Project";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 248);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(316, 64);
            this.label6.TabIndex = 8;
            this.label6.Text = "For now, you\'ll need to insert the files in File Explorer.\r\nYou can do this by br" +
    "owsing to the \'fs\' folder.\r\n\r\nBeta Version.";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(603, 61);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(185, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Export Project";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(3, 61);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(185, 23);
            this.button4.TabIndex = 4;
            this.button4.Text = "Import from ISO";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // isoChoose
            // 
            this.isoChoose.Filter = "ISO File|*.iso|All Files|*.*";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel2.Controls.Add(this.button13);
            this.panel2.Controls.Add(this.button12);
            this.panel2.Controls.Add(this.button11);
            this.panel2.Controls.Add(this.button10);
            this.panel2.Controls.Add(this.button9);
            this.panel2.Controls.Add(this.button8);
            this.panel2.Controls.Add(this.button7);
            this.panel2.Controls.Add(this.button6);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.button5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(809, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 450);
            this.panel2.TabIndex = 9;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(6, 57);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(182, 23);
            this.button5.TabIndex = 10;
            this.button5.Text = "About Window";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 16);
            this.label7.TabIndex = 11;
            this.label7.Text = "Dialogs";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(6, 28);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(182, 23);
            this.button6.TabIndex = 12;
            this.button6.Text = "Settings";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(6, 87);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(182, 23);
            this.button7.TabIndex = 13;
            this.button7.Text = "Project Properties";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(6, 116);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(182, 23);
            this.button8.TabIndex = 14;
            this.button8.Text = "New Project Wizard";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(6, 145);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(182, 23);
            this.button9.TabIndex = 15;
            this.button9.Text = "Update Dialog";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(6, 261);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(182, 23);
            this.button10.TabIndex = 16;
            this.button10.Text = "DEBUG - String Test";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(6, 174);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(182, 23);
            this.button11.TabIndex = 17;
            this.button11.Text = "Startup Dialog";
            this.button11.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(6, 203);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(182, 23);
            this.button12.TabIndex = 18;
            this.button12.Text = "nothing here";
            this.button12.UseVisualStyleBackColor = true;
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(6, 232);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(182, 23);
            this.button13.TabIndex = 19;
            this.button13.Text = "Main Page";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnFolder);
            this.Controls.Add(this.metabox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Name = "Form1";
            this.Text = "Debug Window";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.metabox.ResumeLayout(false);
            this.metabox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox metabox;
        private System.Windows.Forms.TextBox metaName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox metaType;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnFolder;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.TextBox metaFormat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button generateProjectBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.OpenFileDialog isoChoose;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button11;
    }
}

