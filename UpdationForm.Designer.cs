namespace BankingApplication
{
    partial class UpdationForm
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.otherradio = new System.Windows.Forms.RadioButton();
            this.femaleradio = new System.Windows.Forms.RadioButton();
            this.maleradio = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.unmarriedradio = new System.Windows.Forms.RadioButton();
            this.marriedradio = new System.Windows.Forms.RadioButton();
            this.uploadbutton2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mothertxt = new System.Windows.Forms.TextBox();
            this.fathertxt = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.statetxt = new System.Windows.Forms.ComboBox();
            this.disttxt = new System.Windows.Forms.TextBox();
            this.addtxt = new System.Windows.Forms.TextBox();
            this.phonetxt = new System.Windows.Forms.TextBox();
            this.nametxt = new System.Windows.Forms.TextBox();
            this.accnotext = new System.Windows.Forms.TextBox();
            this.updatebutton1 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.deletebutton3 = new System.Windows.Forms.Button();
            this.detailsbutton4 = new System.Windows.Forms.Button();
            this.searchbutton5 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(107, 155);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(214, 20);
            this.dateTimePicker1.TabIndex = 56;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(433, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(208, 181);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 54;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // otherradio
            // 
            this.otherradio.AutoSize = true;
            this.otherradio.Location = new System.Drawing.Point(225, 54);
            this.otherradio.Name = "otherradio";
            this.otherradio.Size = new System.Drawing.Size(55, 19);
            this.otherradio.TabIndex = 2;
            this.otherradio.TabStop = true;
            this.otherradio.Text = "Other";
            this.otherradio.UseVisualStyleBackColor = true;
            // 
            // femaleradio
            // 
            this.femaleradio.AutoSize = true;
            this.femaleradio.Location = new System.Drawing.Point(127, 54);
            this.femaleradio.Name = "femaleradio";
            this.femaleradio.Size = new System.Drawing.Size(67, 19);
            this.femaleradio.TabIndex = 1;
            this.femaleradio.TabStop = true;
            this.femaleradio.Text = "Female";
            this.femaleradio.UseVisualStyleBackColor = true;
            // 
            // maleradio
            // 
            this.maleradio.AutoSize = true;
            this.maleradio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maleradio.Location = new System.Drawing.Point(29, 54);
            this.maleradio.Name = "maleradio";
            this.maleradio.Size = new System.Drawing.Size(53, 19);
            this.maleradio.TabIndex = 0;
            this.maleradio.TabStop = true;
            this.maleradio.Text = "Male";
            this.maleradio.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.otherradio);
            this.groupBox2.Controls.Add(this.femaleradio);
            this.groupBox2.Controls.Add(this.maleradio);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(340, 237);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(301, 81);
            this.groupBox2.TabIndex = 53;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Gender";
            // 
            // unmarriedradio
            // 
            this.unmarriedradio.AutoSize = true;
            this.unmarriedradio.Location = new System.Drawing.Point(127, 54);
            this.unmarriedradio.Name = "unmarriedradio";
            this.unmarriedradio.Size = new System.Drawing.Size(84, 19);
            this.unmarriedradio.TabIndex = 1;
            this.unmarriedradio.TabStop = true;
            this.unmarriedradio.Text = "UnMarried";
            this.unmarriedradio.UseVisualStyleBackColor = true;
            // 
            // marriedradio
            // 
            this.marriedradio.AutoSize = true;
            this.marriedradio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.marriedradio.Location = new System.Drawing.Point(29, 54);
            this.marriedradio.Name = "marriedradio";
            this.marriedradio.Size = new System.Drawing.Size(68, 19);
            this.marriedradio.TabIndex = 0;
            this.marriedradio.TabStop = true;
            this.marriedradio.Text = "Married";
            this.marriedradio.UseVisualStyleBackColor = true;
            // 
            // uploadbutton2
            // 
            this.uploadbutton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uploadbutton2.Location = new System.Drawing.Point(433, 199);
            this.uploadbutton2.Name = "uploadbutton2";
            this.uploadbutton2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.uploadbutton2.Size = new System.Drawing.Size(208, 28);
            this.uploadbutton2.TabIndex = 55;
            this.uploadbutton2.Text = "Upload Photo";
            this.uploadbutton2.UseVisualStyleBackColor = true;
            this.uploadbutton2.Click += new System.EventHandler(this.uploadbutton2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.unmarriedradio);
            this.groupBox1.Controls.Add(this.marriedradio);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(340, 342);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(301, 81);
            this.groupBox1.TabIndex = 52;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Maritial Status";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // mothertxt
            // 
            this.mothertxt.Location = new System.Drawing.Point(107, 258);
            this.mothertxt.Name = "mothertxt";
            this.mothertxt.Size = new System.Drawing.Size(214, 20);
            this.mothertxt.TabIndex = 50;
            // 
            // fathertxt
            // 
            this.fathertxt.Location = new System.Drawing.Point(107, 205);
            this.fathertxt.Name = "fathertxt";
            this.fathertxt.Size = new System.Drawing.Size(214, 20);
            this.fathertxt.TabIndex = 49;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(9, 210);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(79, 15);
            this.label12.TabIndex = 47;
            this.label12.Text = "Father Name";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(9, 263);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(83, 15);
            this.label11.TabIndex = 46;
            this.label11.Text = "Mother Name";
            // 
            // statetxt
            // 
            this.statetxt.FormattingEnabled = true;
            this.statetxt.Items.AddRange(new object[] {
            "Cairo",
            "US",
            "UK"});
            this.statetxt.Location = new System.Drawing.Point(107, 433);
            this.statetxt.Name = "statetxt";
            this.statetxt.Size = new System.Drawing.Size(214, 21);
            this.statetxt.TabIndex = 45;
            // 
            // disttxt
            // 
            this.disttxt.Location = new System.Drawing.Point(107, 394);
            this.disttxt.Name = "disttxt";
            this.disttxt.Size = new System.Drawing.Size(214, 20);
            this.disttxt.TabIndex = 44;
            // 
            // addtxt
            // 
            this.addtxt.Location = new System.Drawing.Point(107, 342);
            this.addtxt.Multiline = true;
            this.addtxt.Name = "addtxt";
            this.addtxt.Size = new System.Drawing.Size(214, 34);
            this.addtxt.TabIndex = 43;
            // 
            // phonetxt
            // 
            this.phonetxt.Location = new System.Drawing.Point(107, 298);
            this.phonetxt.Name = "phonetxt";
            this.phonetxt.Size = new System.Drawing.Size(214, 20);
            this.phonetxt.TabIndex = 42;
            // 
            // nametxt
            // 
            this.nametxt.Location = new System.Drawing.Point(107, 116);
            this.nametxt.Name = "nametxt";
            this.nametxt.Size = new System.Drawing.Size(214, 20);
            this.nametxt.TabIndex = 41;
            // 
            // accnotext
            // 
            this.accnotext.Location = new System.Drawing.Point(107, 73);
            this.accnotext.Name = "accnotext";
            this.accnotext.Size = new System.Drawing.Size(214, 20);
            this.accnotext.TabIndex = 40;
            // 
            // updatebutton1
            // 
            this.updatebutton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatebutton1.Location = new System.Drawing.Point(107, 476);
            this.updatebutton1.Name = "updatebutton1";
            this.updatebutton1.Size = new System.Drawing.Size(87, 27);
            this.updatebutton1.TabIndex = 39;
            this.updatebutton1.Text = "Update";
            this.updatebutton1.UseVisualStyleBackColor = true;
            this.updatebutton1.Click += new System.EventHandler(this.updatebutton1_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(12, 121);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 15);
            this.label10.TabIndex = 38;
            this.label10.Text = "Name";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 434);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 15);
            this.label9.TabIndex = 37;
            this.label9.Text = "State";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 395);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 15);
            this.label8.TabIndex = 36;
            this.label8.Text = "Dist.";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(9, 343);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 15);
            this.label7.TabIndex = 35;
            this.label7.Text = "Address";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(9, 303);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 15);
            this.label6.TabIndex = 34;
            this.label6.Text = "Phone Number";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 15);
            this.label5.TabIndex = 33;
            this.label5.Text = "DOB";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 15);
            this.label4.TabIndex = 32;
            this.label4.Text = "Account No.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(269, -27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 20);
            this.label1.TabIndex = 29;
            this.label1.Text = "Customer Information Form";
            // 
            // deletebutton3
            // 
            this.deletebutton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletebutton3.Location = new System.Drawing.Point(234, 476);
            this.deletebutton3.Name = "deletebutton3";
            this.deletebutton3.Size = new System.Drawing.Size(87, 27);
            this.deletebutton3.TabIndex = 57;
            this.deletebutton3.Text = "Delete";
            this.deletebutton3.UseVisualStyleBackColor = true;
            this.deletebutton3.Click += new System.EventHandler(this.deletebutton3_Click);
            // 
            // detailsbutton4
            // 
            this.detailsbutton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detailsbutton4.Location = new System.Drawing.Point(340, 73);
            this.detailsbutton4.Name = "detailsbutton4";
            this.detailsbutton4.Size = new System.Drawing.Size(82, 27);
            this.detailsbutton4.TabIndex = 58;
            this.detailsbutton4.Text = "Detials";
            this.detailsbutton4.UseVisualStyleBackColor = true;
            this.detailsbutton4.Click += new System.EventHandler(this.detailsbutton4_Click);
            // 
            // searchbutton5
            // 
            this.searchbutton5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchbutton5.Location = new System.Drawing.Point(340, 111);
            this.searchbutton5.Name = "searchbutton5";
            this.searchbutton5.Size = new System.Drawing.Size(82, 27);
            this.searchbutton5.TabIndex = 59;
            this.searchbutton5.Text = "Search";
            this.searchbutton5.UseVisualStyleBackColor = true;
            this.searchbutton5.Click += new System.EventHandler(this.searchbutton5_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(275, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 25);
            this.label2.TabIndex = 60;
            this.label2.Text = "Update Form";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(647, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(662, 491);
            this.dataGridView1.TabIndex = 61;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // UpdationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1243, 510);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.searchbutton5);
            this.Controls.Add(this.detailsbutton4);
            this.Controls.Add(this.deletebutton3);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.uploadbutton2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.mothertxt);
            this.Controls.Add(this.fathertxt);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.statetxt);
            this.Controls.Add(this.disttxt);
            this.Controls.Add(this.addtxt);
            this.Controls.Add(this.phonetxt);
            this.Controls.Add(this.nametxt);
            this.Controls.Add(this.accnotext);
            this.Controls.Add(this.updatebutton1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Name = "UpdationForm";
            this.Text = "UpdationForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton otherradio;
        private System.Windows.Forms.RadioButton femaleradio;
        private System.Windows.Forms.RadioButton maleradio;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton unmarriedradio;
        private System.Windows.Forms.RadioButton marriedradio;
        private System.Windows.Forms.Button uploadbutton2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox mothertxt;
        private System.Windows.Forms.TextBox fathertxt;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox disttxt;
        private System.Windows.Forms.TextBox addtxt;
        private System.Windows.Forms.TextBox phonetxt;
        private System.Windows.Forms.TextBox nametxt;
        private System.Windows.Forms.TextBox accnotext;
        private System.Windows.Forms.Button updatebutton1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button deletebutton3;
        private System.Windows.Forms.Button detailsbutton4;
        private System.Windows.Forms.Button searchbutton5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox statetxt;
    }
}