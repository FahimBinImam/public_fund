﻿namespace PublicFund
{
    partial class EventManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EventManagement));
            this.btnClose = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.btnSend = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEID = new System.Windows.Forms.Label();
            this.txtVID = new System.Windows.Forms.Label();
            this.txtStatus = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSearchEID = new System.Windows.Forms.TextBox();
            this.btnSearchEID = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Cooper Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(952, 643);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 42);
            this.btnClose.TabIndex = 164;
            this.btnClose.Text = "Close";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Orange;
            this.groupBox1.Controls.Add(this.txtStatus);
            this.groupBox1.Controls.Add(this.txtVID);
            this.groupBox1.Controls.Add(this.txtEID);
            this.groupBox1.Controls.Add(this.btnPrint);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.btnReset);
            this.groupBox1.Controls.Add(this.dataGridView2);
            this.groupBox1.Controls.Add(this.btnSend);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(33, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(522, 701);
            this.groupBox1.TabIndex = 163;
            this.groupBox1.TabStop = false;
            // 
            // btnPrint
            // 
            this.btnPrint.Font = new System.Drawing.Font("Impact", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Image = ((System.Drawing.Image)(resources.GetObject("btnPrint.Image")));
            this.btnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrint.Location = new System.Drawing.Point(201, 642);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(98, 34);
            this.btnPrint.TabIndex = 162;
            this.btnPrint.Text = "Print";
            this.btnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(151, 225);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(246, 36);
            this.label7.TabIndex = 157;
            this.label7.Text = "Paricipation List";
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Cooper Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Image = ((System.Drawing.Image)(resources.GetObject("btnReset.Image")));
            this.btnReset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReset.Location = new System.Drawing.Point(62, 163);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(110, 33);
            this.btnReset.TabIndex = 161;
            this.btnReset.Text = "Reset";
            this.btnReset.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(15, 276);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 62;
            this.dataGridView2.RowTemplate.Height = 28;
            this.dataGridView2.Size = new System.Drawing.Size(493, 345);
            this.dataGridView2.TabIndex = 160;
            // 
            // btnSend
            // 
            this.btnSend.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSend.Location = new System.Drawing.Point(368, 163);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(101, 33);
            this.btnSend.TabIndex = 159;
            this.btnSend.Text = "Update";
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(169, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 25);
            this.label5.TabIndex = 157;
            this.label5.Text = "Volunteer ID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(207, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 25);
            this.label4.TabIndex = 155;
            this.label4.Text = "Event ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(288, 25);
            this.label1.TabIndex = 157;
            this.label1.Text = "Volunteer Participent Status:";
            // 
            // txtEID
            // 
            this.txtEID.AutoSize = true;
            this.txtEID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEID.Location = new System.Drawing.Point(314, 31);
            this.txtEID.Name = "txtEID";
            this.txtEID.Size = new System.Drawing.Size(57, 25);
            this.txtEID.TabIndex = 163;
            this.txtEID.Text = "*****";
            // 
            // txtVID
            // 
            this.txtVID.AutoSize = true;
            this.txtVID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVID.Location = new System.Drawing.Point(314, 64);
            this.txtVID.Name = "txtVID";
            this.txtVID.Size = new System.Drawing.Size(57, 25);
            this.txtVID.TabIndex = 163;
            this.txtVID.Text = "*****";
            // 
            // txtStatus
            // 
            this.txtStatus.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txtStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtStatus.FormattingEnabled = true;
            this.txtStatus.Items.AddRange(new object[] {
            "YES",
            "NO"});
            this.txtStatus.Location = new System.Drawing.Point(319, 102);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(121, 28);
            this.txtStatus.TabIndex = 164;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(775, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(211, 36);
            this.label2.TabIndex = 165;
            this.label2.Text = "Invitation List";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(612, 156);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(493, 444);
            this.dataGridView1.TabIndex = 166;
            this.dataGridView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseDoubleClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(649, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 25);
            this.label3.TabIndex = 169;
            this.label3.Text = "Event ID:";
            // 
            // txtSearchEID
            // 
            this.txtSearchEID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchEID.Location = new System.Drawing.Point(757, 94);
            this.txtSearchEID.Multiline = true;
            this.txtSearchEID.Name = "txtSearchEID";
            this.txtSearchEID.Size = new System.Drawing.Size(204, 35);
            this.txtSearchEID.TabIndex = 168;
            // 
            // btnSearchEID
            // 
            this.btnSearchEID.Font = new System.Drawing.Font("Impact", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchEID.Image = ((System.Drawing.Image)(resources.GetObject("btnSearchEID.Image")));
            this.btnSearchEID.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearchEID.Location = new System.Drawing.Point(986, 94);
            this.btnSearchEID.Name = "btnSearchEID";
            this.btnSearchEID.Size = new System.Drawing.Size(94, 45);
            this.btnSearchEID.TabIndex = 167;
            this.btnSearchEID.Text = "Search";
            this.btnSearchEID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearchEID.UseVisualStyleBackColor = true;
            this.btnSearchEID.Click += new System.EventHandler(this.btnSearchEID_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // EventManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(1147, 721);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSearchEID);
            this.Controls.Add(this.btnSearchEID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.groupBox1);
            this.Name = "EventManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EventManagement";
            this.Load += new System.EventHandler(this.EventManagement_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label txtEID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox txtStatus;
        private System.Windows.Forms.Label txtVID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSearchEID;
        private System.Windows.Forms.Button btnSearchEID;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}