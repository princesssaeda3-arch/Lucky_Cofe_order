namespace Lucky_Cafe_Order
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkStudent = new System.Windows.Forms.CheckBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.groupBox_drink = new System.Windows.Forms.GroupBox();
            this.rbtnJuice = new System.Windows.Forms.RadioButton();
            this.rbncofee = new System.Windows.Forms.RadioButton();
            this.rbTea = new System.Windows.Forms.RadioButton();
            this.lbl_Customer_Name = new System.Windows.Forms.Label();
            this.lbl_information = new System.Windows.Forms.Label();
            this.btn_clear = new System.Windows.Forms.Button();
            this.listbx_Order = new System.Windows.Forms.ListBox();
            this.lbl_order = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.btn_save_file = new System.Windows.Forms.Button();
            this.btn_calculate = new System.Windows.Forms.Button();
            this.btn_load_file = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox_drink.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkStudent);
            this.groupBox1.Controls.Add(this.txtQuantity);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.lblQuantity);
            this.groupBox1.Controls.Add(this.groupBox_drink);
            this.groupBox1.Controls.Add(this.lbl_Customer_Name);
            this.groupBox1.Controls.Add(this.lbl_information);
            this.groupBox1.Location = new System.Drawing.Point(1, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(459, 326);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // chkStudent
            // 
            this.chkStudent.AutoSize = true;
            this.chkStudent.Location = new System.Drawing.Point(142, 282);
            this.chkStudent.Name = "chkStudent";
            this.chkStudent.Size = new System.Drawing.Size(226, 24);
            this.chkStudent.TabIndex = 6;
            this.chkStudent.Text = "Student Member (10% Off)";
            this.chkStudent.UseVisualStyleBackColor = true;
            this.chkStudent.CheckedChanged += new System.EventHandler(this.chkStudent_CheckedChanged);
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(85, 279);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(36, 26);
            this.txtQuantity.TabIndex = 5;
            this.txtQuantity.TextChanged += new System.EventHandler(this.txtQuantity_TextChanged);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(22, 86);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(346, 37);
            this.txtName.TabIndex = 4;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(22, 282);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(65, 20);
            this.lblQuantity.TabIndex = 3;
            this.lblQuantity.Text = "Quality :";
            // 
            // groupBox_drink
            // 
            this.groupBox_drink.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox_drink.Controls.Add(this.rbtnJuice);
            this.groupBox_drink.Controls.Add(this.rbncofee);
            this.groupBox_drink.Controls.Add(this.rbTea);
            this.groupBox_drink.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBox_drink.Location = new System.Drawing.Point(22, 129);
            this.groupBox_drink.Name = "groupBox_drink";
            this.groupBox_drink.Size = new System.Drawing.Size(397, 146);
            this.groupBox_drink.TabIndex = 2;
            this.groupBox_drink.TabStop = false;
            this.groupBox_drink.Text = "Drink Type";
            this.groupBox_drink.Enter += new System.EventHandler(this.groupBox_drink_Enter);
            // 
            // rbtnJuice
            // 
            this.rbtnJuice.AutoSize = true;
            this.rbtnJuice.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rbtnJuice.Location = new System.Drawing.Point(22, 86);
            this.rbtnJuice.Name = "rbtnJuice";
            this.rbtnJuice.Size = new System.Drawing.Size(103, 24);
            this.rbtnJuice.TabIndex = 2;
            this.rbtnJuice.TabStop = true;
            this.rbtnJuice.Text = "Juice ($3)";
            this.rbtnJuice.UseVisualStyleBackColor = true;
            this.rbtnJuice.CheckedChanged += new System.EventHandler(this.rbtnJuice_CheckedChanged);
            // 
            // rbncofee
            // 
            this.rbncofee.AutoSize = true;
            this.rbncofee.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rbncofee.Location = new System.Drawing.Point(22, 56);
            this.rbncofee.Name = "rbncofee";
            this.rbncofee.Size = new System.Drawing.Size(110, 24);
            this.rbncofee.TabIndex = 1;
            this.rbncofee.TabStop = true;
            this.rbncofee.Text = "Coffee($2)";
            this.rbncofee.UseVisualStyleBackColor = true;
            this.rbncofee.CheckedChanged += new System.EventHandler(this.rbncofee_CheckedChanged);
            // 
            // rbTea
            // 
            this.rbTea.AutoSize = true;
            this.rbTea.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rbTea.Location = new System.Drawing.Point(22, 26);
            this.rbTea.Name = "rbTea";
            this.rbTea.Size = new System.Drawing.Size(89, 24);
            this.rbTea.TabIndex = 0;
            this.rbTea.Text = "Tea($1)";
            this.rbTea.UseVisualStyleBackColor = true;
            this.rbTea.CheckedChanged += new System.EventHandler(this.rbTea_CheckedChanged);
            // 
            // lbl_Customer_Name
            // 
            this.lbl_Customer_Name.AutoSize = true;
            this.lbl_Customer_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Customer_Name.Location = new System.Drawing.Point(26, 61);
            this.lbl_Customer_Name.Name = "lbl_Customer_Name";
            this.lbl_Customer_Name.Size = new System.Drawing.Size(144, 22);
            this.lbl_Customer_Name.TabIndex = 1;
            this.lbl_Customer_Name.Text = "Customer Name:";
            // 
            // lbl_information
            // 
            this.lbl_information.AutoSize = true;
            this.lbl_information.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_information.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbl_information.Location = new System.Drawing.Point(18, 22);
            this.lbl_information.Name = "lbl_information";
            this.lbl_information.Size = new System.Drawing.Size(242, 26);
            this.lbl_information.TabIndex = 0;
            this.lbl_information.Text = "Customer Information";
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(591, 342);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(134, 35);
            this.btn_clear.TabIndex = 4;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // listbx_Order
            // 
            this.listbx_Order.FormattingEnabled = true;
            this.listbx_Order.ItemHeight = 20;
            this.listbx_Order.Location = new System.Drawing.Point(487, 49);
            this.listbx_Order.Name = "listbx_Order";
            this.listbx_Order.Size = new System.Drawing.Size(301, 264);
            this.listbx_Order.TabIndex = 5;
            this.listbx_Order.SelectedIndexChanged += new System.EventHandler(this.listbx_Order_SelectedIndexChanged);
            // 
            // lbl_order
            // 
            this.lbl_order.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_order.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_order.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbl_order.Location = new System.Drawing.Point(487, 20);
            this.lbl_order.Name = "lbl_order";
            this.lbl_order.Size = new System.Drawing.Size(301, 26);
            this.lbl_order.TabIndex = 6;
            this.lbl_order.Text = "Order List";
            // 
            // lblResult
            // 
            this.lblResult.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblResult.Location = new System.Drawing.Point(12, 384);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(746, 80);
            this.lblResult.TabIndex = 7;
            this.lblResult.Click += new System.EventHandler(this.lblResult_Click);
            // 
            // btn_save_file
            // 
            this.btn_save_file.Location = new System.Drawing.Point(235, 340);
            this.btn_save_file.Name = "btn_save_file";
            this.btn_save_file.Size = new System.Drawing.Size(119, 38);
            this.btn_save_file.TabIndex = 8;
            this.btn_save_file.Text = "Save to File";
            this.btn_save_file.UseVisualStyleBackColor = true;
            this.btn_save_file.Click += new System.EventHandler(this.btn_save_file_Click);
            // 
            // btn_calculate
            // 
            this.btn_calculate.Location = new System.Drawing.Point(45, 342);
            this.btn_calculate.Name = "btn_calculate";
            this.btn_calculate.Size = new System.Drawing.Size(116, 34);
            this.btn_calculate.TabIndex = 9;
            this.btn_calculate.Text = "Calculate";
            this.btn_calculate.UseVisualStyleBackColor = true;
            this.btn_calculate.Click += new System.EventHandler(this.btn_calculate_Click);
            // 
            // btn_load_file
            // 
            this.btn_load_file.Location = new System.Drawing.Point(418, 342);
            this.btn_load_file.Name = "btn_load_file";
            this.btn_load_file.Size = new System.Drawing.Size(141, 34);
            this.btn_load_file.TabIndex = 10;
            this.btn_load_file.Text = "Load from File";
            this.btn_load_file.UseVisualStyleBackColor = true;
            this.btn_load_file.Click += new System.EventHandler(this.btn_load_file_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 473);
            this.Controls.Add(this.btn_load_file);
            this.Controls.Add(this.btn_calculate);
            this.Controls.Add(this.btn_save_file);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lbl_order);
            this.Controls.Add(this.listbx_Order);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox_drink.ResumeLayout(false);
            this.groupBox_drink.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_Customer_Name;
        private System.Windows.Forms.Label lbl_information;
        private System.Windows.Forms.GroupBox groupBox_drink;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.RadioButton rbncofee;
        private System.Windows.Forms.RadioButton rbTea;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.CheckBox chkStudent;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.ListBox listbx_Order;
        private System.Windows.Forms.Label lbl_order;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btn_save_file;
        private System.Windows.Forms.Button btn_calculate;
        private System.Windows.Forms.Button btn_load_file;
        private System.Windows.Forms.RadioButton rbtnJuice;
    }
}

