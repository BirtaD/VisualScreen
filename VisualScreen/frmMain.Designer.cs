
namespace VisualScreen
{
    partial class frmMain
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
            panel1 = new System.Windows.Forms.Panel();
            buttonAddList = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            panel2 = new System.Windows.Forms.Panel();
            txtLoading = new System.Windows.Forms.Label();
            btnUpdate = new System.Windows.Forms.Button();
            buttonUnselect = new System.Windows.Forms.Button();
            buttonSelect = new System.Windows.Forms.Button();
            listBox2 = new System.Windows.Forms.ListBox();
            listBox1 = new System.Windows.Forms.ListBox();
            button2 = new System.Windows.Forms.Button();
            comboBox1 = new System.Windows.Forms.ComboBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(buttonAddList);
            panel1.Controls.Add(label1);
            panel1.Location = new System.Drawing.Point(3, 4);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(206, 118);
            panel1.TabIndex = 0;
            // 
            // buttonAddList
            // 
            buttonAddList.Location = new System.Drawing.Point(66, 88);
            buttonAddList.Name = "buttonAddList";
            buttonAddList.Size = new System.Drawing.Size(64, 23);
            buttonAddList.TabIndex = 2;
            buttonAddList.Text = "Add List";
            buttonAddList.UseVisualStyleBackColor = true;
            buttonAddList.Click += buttonAddList_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(5, 8);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(45, 15);
            label1.TabIndex = 0;
            label1.Text = "IP-cím:";
            label1.Click += label1_Click;
            // 
            // panel2
            // 
            panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            panel2.Controls.Add(txtLoading);
            panel2.Controls.Add(btnUpdate);
            panel2.Controls.Add(buttonUnselect);
            panel2.Controls.Add(buttonSelect);
            panel2.Controls.Add(listBox2);
            panel2.Controls.Add(listBox1);
            panel2.Location = new System.Drawing.Point(215, 4);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(380, 348);
            panel2.TabIndex = 1;
            // 
            // txtLoading
            // 
            txtLoading.AutoSize = true;
            txtLoading.Location = new System.Drawing.Point(164, 72);
            txtLoading.Name = "txtLoading";
            txtLoading.Size = new System.Drawing.Size(38, 15);
            txtLoading.TabIndex = 4;
            txtLoading.Text = "label2";
            txtLoading.Visible = false;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new System.Drawing.Point(146, 35);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new System.Drawing.Size(75, 23);
            btnUpdate.TabIndex = 3;
            btnUpdate.Text = "Frissítés";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += button1_Click;
            // 
            // buttonUnselect
            // 
            buttonUnselect.Location = new System.Drawing.Point(146, 199);
            buttonUnselect.Name = "buttonUnselect";
            buttonUnselect.Size = new System.Drawing.Size(75, 23);
            buttonUnselect.TabIndex = 3;
            buttonUnselect.Text = "Unselect";
            buttonUnselect.UseVisualStyleBackColor = true;
            buttonUnselect.Click += buttonUnselect_Click;
            // 
            // buttonSelect
            // 
            buttonSelect.Location = new System.Drawing.Point(146, 158);
            buttonSelect.Name = "buttonSelect";
            buttonSelect.Size = new System.Drawing.Size(75, 23);
            buttonSelect.TabIndex = 2;
            buttonSelect.Text = "Select";
            buttonSelect.UseVisualStyleBackColor = true;
            buttonSelect.Click += buttonSelect_Click;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 15;
            listBox2.Location = new System.Drawing.Point(242, 6);
            listBox2.Name = "listBox2";
            listBox2.Size = new System.Drawing.Size(127, 334);
            listBox2.TabIndex = 1;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new System.Drawing.Point(3, 6);
            listBox1.Name = "listBox1";
            listBox1.Size = new System.Drawing.Size(127, 334);
            listBox1.TabIndex = 0;
            // 
            // button2
            // 
            button2.Location = new System.Drawing.Point(520, 408);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(75, 23);
            button2.TabIndex = 2;
            button2.Text = "Indítás";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new System.Drawing.Point(56, 5);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new System.Drawing.Size(121, 23);
            comboBox1.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(601, 434);
            Controls.Add(button2);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Visual Screen";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonUnselect;
        private System.Windows.Forms.Button buttonSelect;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button buttonAddList;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label txtLoading;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

