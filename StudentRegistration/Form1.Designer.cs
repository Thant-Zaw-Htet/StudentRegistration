namespace StudentRegistration
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
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.radWeb = new System.Windows.Forms.RadioButton();
            this.radJava = new System.Windows.Forms.RadioButton();
            this.radCsharp = new System.Windows.Forms.RadioButton();
            this.radPhp = new System.Windows.Forms.RadioButton();
            this.radPython = new System.Windows.Forms.RadioButton();
            this.radAndroid = new System.Windows.Forms.RadioButton();
            this.radIos = new System.Windows.Forms.RadioButton();
            this.radReactiveNative = new System.Windows.Forms.RadioButton();
            this.txtFee = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(468, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(333, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student Registration";
            // 
            // dgv1
            // 
            this.dgv1.AllowUserToAddRows = false;
            this.dgv1.AllowUserToDeleteRows = false;
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.Location = new System.Drawing.Point(423, 127);
            this.dgv1.Name = "dgv1";
            this.dgv1.ReadOnly = true;
            this.dgv1.RowHeadersWidth = 62;
            this.dgv1.RowTemplate.Height = 28;
            this.dgv1.Size = new System.Drawing.Size(908, 812);
            this.dgv1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 27);
            this.label2.TabIndex = 2;
            this.label2.Text = "Student Name";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(89, 228);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(300, 26);
            this.txtName.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 317);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 27);
            this.label3.TabIndex = 4;
            this.label3.Text = "Courses";
            // 
            // radWeb
            // 
            this.radWeb.AutoSize = true;
            this.radWeb.Location = new System.Drawing.Point(38, 389);
            this.radWeb.Name = "radWeb";
            this.radWeb.Size = new System.Drawing.Size(165, 24);
            this.radWeb.TabIndex = 5;
            this.radWeb.TabStop = true;
            this.radWeb.Text = "Web Development";
            this.radWeb.UseVisualStyleBackColor = true;
            // 
            // radJava
            // 
            this.radJava.AutoSize = true;
            this.radJava.Location = new System.Drawing.Point(220, 389);
            this.radJava.Name = "radJava";
            this.radJava.Size = new System.Drawing.Size(117, 24);
            this.radJava.TabIndex = 6;
            this.radJava.TabStop = true;
            this.radJava.Text = "Java/Spring";
            this.radJava.UseVisualStyleBackColor = true;
            // 
            // radCsharp
            // 
            this.radCsharp.AutoSize = true;
            this.radCsharp.Location = new System.Drawing.Point(38, 460);
            this.radCsharp.Name = "radCsharp";
            this.radCsharp.Size = new System.Drawing.Size(81, 24);
            this.radCsharp.TabIndex = 7;
            this.radCsharp.TabStop = true;
            this.radCsharp.Text = "C#.net";
            this.radCsharp.UseVisualStyleBackColor = true;
            // 
            // radPhp
            // 
            this.radPhp.AutoSize = true;
            this.radPhp.Location = new System.Drawing.Point(220, 460);
            this.radPhp.Name = "radPhp";
            this.radPhp.Size = new System.Drawing.Size(121, 24);
            this.radPhp.TabIndex = 8;
            this.radPhp.TabStop = true;
            this.radPhp.Text = "PHP/Laravel";
            this.radPhp.UseVisualStyleBackColor = true;
            // 
            // radPython
            // 
            this.radPython.AutoSize = true;
            this.radPython.Location = new System.Drawing.Point(38, 522);
            this.radPython.Name = "radPython";
            this.radPython.Size = new System.Drawing.Size(83, 24);
            this.radPython.TabIndex = 9;
            this.radPython.TabStop = true;
            this.radPython.Text = "Python";
            this.radPython.UseVisualStyleBackColor = true;
            // 
            // radAndroid
            // 
            this.radAndroid.AutoSize = true;
            this.radAndroid.Location = new System.Drawing.Point(220, 522);
            this.radAndroid.Name = "radAndroid";
            this.radAndroid.Size = new System.Drawing.Size(187, 24);
            this.radAndroid.TabIndex = 10;
            this.radAndroid.TabStop = true;
            this.radAndroid.Text = "Android Development";
            this.radAndroid.UseVisualStyleBackColor = true;
            // 
            // radIos
            // 
            this.radIos.AutoSize = true;
            this.radIos.Location = new System.Drawing.Point(38, 591);
            this.radIos.Name = "radIos";
            this.radIos.Size = new System.Drawing.Size(160, 24);
            this.radIos.TabIndex = 11;
            this.radIos.TabStop = true;
            this.radIos.Text = "IOS Development";
            this.radIos.UseVisualStyleBackColor = true;
            // 
            // radReactiveNative
            // 
            this.radReactiveNative.AutoSize = true;
            this.radReactiveNative.Location = new System.Drawing.Point(220, 591);
            this.radReactiveNative.Name = "radReactiveNative";
            this.radReactiveNative.Size = new System.Drawing.Size(125, 24);
            this.radReactiveNative.TabIndex = 12;
            this.radReactiveNative.TabStop = true;
            this.radReactiveNative.Text = "React Native";
            this.radReactiveNative.UseVisualStyleBackColor = true;
            // 
            // txtFee
            // 
            this.txtFee.Location = new System.Drawing.Point(89, 706);
            this.txtFee.Name = "txtFee";
            this.txtFee.Size = new System.Drawing.Size(300, 26);
            this.txtFee.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(33, 662);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 27);
            this.label4.TabIndex = 13;
            this.label4.Text = "Fee";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(38, 805);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(125, 77);
            this.btnSave.TabIndex = 15;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(220, 805);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(125, 77);
            this.btnClear.TabIndex = 16;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(1213, 72);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(118, 49);
            this.btnRefresh.TabIndex = 17;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1343, 951);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtFee);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.radReactiveNative);
            this.Controls.Add(this.radIos);
            this.Controls.Add(this.radAndroid);
            this.Controls.Add(this.radPython);
            this.Controls.Add(this.radPhp);
            this.Controls.Add(this.radCsharp);
            this.Controls.Add(this.radJava);
            this.Controls.Add(this.radWeb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgv1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radWeb;
        private System.Windows.Forms.RadioButton radJava;
        private System.Windows.Forms.RadioButton radCsharp;
        private System.Windows.Forms.RadioButton radPhp;
        private System.Windows.Forms.RadioButton radPython;
        private System.Windows.Forms.RadioButton radAndroid;
        private System.Windows.Forms.RadioButton radIos;
        private System.Windows.Forms.RadioButton radReactiveNative;
        private System.Windows.Forms.TextBox txtFee;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnRefresh;
    }
}

