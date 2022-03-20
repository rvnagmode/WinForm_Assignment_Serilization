namespace WinForm_Assignment_Serilization
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
            this.btnBinaryWrite = new System.Windows.Forms.Button();
            this.btnBinaryRead = new System.Windows.Forms.Button();
            this.txtpcode = new System.Windows.Forms.TextBox();
            this.bntSoapRead = new System.Windows.Forms.Button();
            this.bntSoapWrite = new System.Windows.Forms.Button();
            this.btnXmlRead = new System.Windows.Forms.Button();
            this.btnXmlWrite = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtpname = new System.Windows.Forms.TextBox();
            this.txtprice = new System.Windows.Forms.TextBox();
            this.btnJsonRead = new System.Windows.Forms.Button();
            this.btnJsonWrite = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pcode";
            // 
            // btnBinaryWrite
            // 
            this.btnBinaryWrite.Location = new System.Drawing.Point(408, 36);
            this.btnBinaryWrite.Name = "btnBinaryWrite";
            this.btnBinaryWrite.Size = new System.Drawing.Size(96, 51);
            this.btnBinaryWrite.TabIndex = 1;
            this.btnBinaryWrite.Text = "Binary Write";
            this.btnBinaryWrite.UseVisualStyleBackColor = true;
            this.btnBinaryWrite.Click += new System.EventHandler(this.btnBinaryWrite_Click);
            // 
            // btnBinaryRead
            // 
            this.btnBinaryRead.Location = new System.Drawing.Point(538, 36);
            this.btnBinaryRead.Name = "btnBinaryRead";
            this.btnBinaryRead.Size = new System.Drawing.Size(96, 51);
            this.btnBinaryRead.TabIndex = 2;
            this.btnBinaryRead.Text = "Binary Read";
            this.btnBinaryRead.UseVisualStyleBackColor = true;
            this.btnBinaryRead.Click += new System.EventHandler(this.btnBinaryRead_Click);
            // 
            // txtpcode
            // 
            this.txtpcode.Location = new System.Drawing.Point(151, 67);
            this.txtpcode.Name = "txtpcode";
            this.txtpcode.Size = new System.Drawing.Size(169, 20);
            this.txtpcode.TabIndex = 3;
            // 
            // bntSoapRead
            // 
            this.bntSoapRead.Location = new System.Drawing.Point(538, 103);
            this.bntSoapRead.Name = "bntSoapRead";
            this.bntSoapRead.Size = new System.Drawing.Size(96, 51);
            this.bntSoapRead.TabIndex = 5;
            this.bntSoapRead.Text = "Soap Read";
            this.bntSoapRead.UseVisualStyleBackColor = true;
            this.bntSoapRead.Click += new System.EventHandler(this.bntSoapRead_Click);
            // 
            // bntSoapWrite
            // 
            this.bntSoapWrite.Location = new System.Drawing.Point(408, 103);
            this.bntSoapWrite.Name = "bntSoapWrite";
            this.bntSoapWrite.Size = new System.Drawing.Size(96, 51);
            this.bntSoapWrite.TabIndex = 4;
            this.bntSoapWrite.Text = "SOAP Write";
            this.bntSoapWrite.UseVisualStyleBackColor = true;
            this.bntSoapWrite.Click += new System.EventHandler(this.bntSoapWrite_Click);
            // 
            // btnXmlRead
            // 
            this.btnXmlRead.Location = new System.Drawing.Point(538, 171);
            this.btnXmlRead.Name = "btnXmlRead";
            this.btnXmlRead.Size = new System.Drawing.Size(96, 51);
            this.btnXmlRead.TabIndex = 7;
            this.btnXmlRead.Text = "Xml Read";
            this.btnXmlRead.UseVisualStyleBackColor = true;
            this.btnXmlRead.Click += new System.EventHandler(this.btnXmlRead_Click);
            // 
            // btnXmlWrite
            // 
            this.btnXmlWrite.Location = new System.Drawing.Point(408, 171);
            this.btnXmlWrite.Name = "btnXmlWrite";
            this.btnXmlWrite.Size = new System.Drawing.Size(96, 51);
            this.btnXmlWrite.TabIndex = 6;
            this.btnXmlWrite.Text = "Xml Write";
            this.btnXmlWrite.UseVisualStyleBackColor = true;
            this.btnXmlWrite.Click += new System.EventHandler(this.btnXmlWrite_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Pname";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(76, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Price";
            // 
            // txtpname
            // 
            this.txtpname.Location = new System.Drawing.Point(151, 138);
            this.txtpname.Name = "txtpname";
            this.txtpname.Size = new System.Drawing.Size(169, 20);
            this.txtpname.TabIndex = 10;
            // 
            // txtprice
            // 
            this.txtprice.Location = new System.Drawing.Point(151, 206);
            this.txtprice.Name = "txtprice";
            this.txtprice.Size = new System.Drawing.Size(169, 20);
            this.txtprice.TabIndex = 11;
            // 
            // btnJsonRead
            // 
            this.btnJsonRead.Location = new System.Drawing.Point(538, 237);
            this.btnJsonRead.Name = "btnJsonRead";
            this.btnJsonRead.Size = new System.Drawing.Size(96, 51);
            this.btnJsonRead.TabIndex = 13;
            this.btnJsonRead.Text = "Json Read";
            this.btnJsonRead.UseVisualStyleBackColor = true;
            this.btnJsonRead.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnJsonWrite
            // 
            this.btnJsonWrite.Location = new System.Drawing.Point(408, 237);
            this.btnJsonWrite.Name = "btnJsonWrite";
            this.btnJsonWrite.Size = new System.Drawing.Size(96, 51);
            this.btnJsonWrite.TabIndex = 12;
            this.btnJsonWrite.Text = "Json Write";
            this.btnJsonWrite.UseVisualStyleBackColor = true;
            this.btnJsonWrite.Click += new System.EventHandler(this.btnJsonWrite_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnJsonRead);
            this.Controls.Add(this.btnJsonWrite);
            this.Controls.Add(this.txtprice);
            this.Controls.Add(this.txtpname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnXmlRead);
            this.Controls.Add(this.btnXmlWrite);
            this.Controls.Add(this.bntSoapRead);
            this.Controls.Add(this.bntSoapWrite);
            this.Controls.Add(this.txtpcode);
            this.Controls.Add(this.btnBinaryRead);
            this.Controls.Add(this.btnBinaryWrite);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Serialization";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBinaryWrite;
        private System.Windows.Forms.Button btnBinaryRead;
        private System.Windows.Forms.TextBox txtpcode;
        private System.Windows.Forms.Button bntSoapRead;
        private System.Windows.Forms.Button bntSoapWrite;
        private System.Windows.Forms.Button btnXmlRead;
        private System.Windows.Forms.Button btnXmlWrite;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtpname;
        private System.Windows.Forms.TextBox txtprice;
        private System.Windows.Forms.Button btnJsonRead;
        private System.Windows.Forms.Button btnJsonWrite;
    }
}

