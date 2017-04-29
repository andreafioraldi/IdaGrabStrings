namespace IdaGrabStringsView
{
    partial class GrabStringsForm
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
            this.grabStringsBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.offsetColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valueColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.asciiBox = new System.Windows.Forms.RadioButton();
            this.extAsciiBox = new System.Windows.Forms.RadioButton();
            this.alphanumAsciiBox = new System.Windows.Forms.RadioButton();
            this.strMinimumBox = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.genStructBtn = new System.Windows.Forms.Button();
            this.notNulBox = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.strMinimumBox)).BeginInit();
            this.SuspendLayout();
            // 
            // grabStringsBtn
            // 
            this.grabStringsBtn.Location = new System.Drawing.Point(0, 0);
            this.grabStringsBtn.Name = "grabStringsBtn";
            this.grabStringsBtn.Size = new System.Drawing.Size(75, 23);
            this.grabStringsBtn.TabIndex = 0;
            this.grabStringsBtn.Text = "Grab strings";
            this.grabStringsBtn.UseVisualStyleBackColor = true;
            this.grabStringsBtn.Click += new System.EventHandler(this.grabStringsBtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.offsetColumn,
            this.valueColumn});
            this.dataGridView1.Location = new System.Drawing.Point(0, 57);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 50;
            this.dataGridView1.Size = new System.Drawing.Size(499, 317);
            this.dataGridView1.TabIndex = 1;
            // 
            // offsetColumn
            // 
            this.offsetColumn.HeaderText = "Offset";
            this.offsetColumn.Name = "offsetColumn";
            this.offsetColumn.ReadOnly = true;
            // 
            // valueColumn
            // 
            this.valueColumn.HeaderText = "Value";
            this.valueColumn.Name = "valueColumn";
            this.valueColumn.ReadOnly = true;
            // 
            // asciiBox
            // 
            this.asciiBox.AutoSize = true;
            this.asciiBox.Checked = true;
            this.asciiBox.Location = new System.Drawing.Point(5, 34);
            this.asciiBox.Name = "asciiBox";
            this.asciiBox.Size = new System.Drawing.Size(52, 17);
            this.asciiBox.TabIndex = 2;
            this.asciiBox.TabStop = true;
            this.asciiBox.Text = "ASCII";
            this.asciiBox.UseVisualStyleBackColor = true;
            // 
            // extAsciiBox
            // 
            this.extAsciiBox.AutoSize = true;
            this.extAsciiBox.Location = new System.Drawing.Point(72, 34);
            this.extAsciiBox.Name = "extAsciiBox";
            this.extAsciiBox.Size = new System.Drawing.Size(100, 17);
            this.extAsciiBox.TabIndex = 3;
            this.extAsciiBox.Text = "Extended ASCII";
            this.extAsciiBox.UseVisualStyleBackColor = true;
            // 
            // alphanumAsciiBox
            // 
            this.alphanumAsciiBox.AutoSize = true;
            this.alphanumAsciiBox.Location = new System.Drawing.Point(182, 34);
            this.alphanumAsciiBox.Name = "alphanumAsciiBox";
            this.alphanumAsciiBox.Size = new System.Drawing.Size(87, 17);
            this.alphanumAsciiBox.TabIndex = 4;
            this.alphanumAsciiBox.Text = "[a-zA-z0-9_]+";
            this.alphanumAsciiBox.UseVisualStyleBackColor = true;
            // 
            // strMinimumBox
            // 
            this.strMinimumBox.Location = new System.Drawing.Point(195, 3);
            this.strMinimumBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.strMinimumBox.Name = "strMinimumBox";
            this.strMinimumBox.Size = new System.Drawing.Size(88, 20);
            this.strMinimumBox.TabIndex = 5;
            this.strMinimumBox.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Strings min length:";
            // 
            // genStructBtn
            // 
            this.genStructBtn.Location = new System.Drawing.Point(300, 0);
            this.genStructBtn.Name = "genStructBtn";
            this.genStructBtn.Size = new System.Drawing.Size(121, 23);
            this.genStructBtn.TabIndex = 7;
            this.genStructBtn.Text = "Generate C struct";
            this.genStructBtn.UseVisualStyleBackColor = true;
            this.genStructBtn.Click += new System.EventHandler(this.genStructBtn_Click);
            // 
            // notNulBox
            // 
            this.notNulBox.AutoSize = true;
            this.notNulBox.Location = new System.Drawing.Point(275, 34);
            this.notNulBox.Name = "notNulBox";
            this.notNulBox.Size = new System.Drawing.Size(65, 17);
            this.notNulBox.TabIndex = 8;
            this.notNulBox.Text = "not NUL";
            this.notNulBox.UseVisualStyleBackColor = true;
            // 
            // GrabStringsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 374);
            this.Controls.Add(this.notNulBox);
            this.Controls.Add(this.genStructBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.strMinimumBox);
            this.Controls.Add(this.alphanumAsciiBox);
            this.Controls.Add(this.extAsciiBox);
            this.Controls.Add(this.asciiBox);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.grabStringsBtn);
            this.MinimumSize = new System.Drawing.Size(437, 339);
            this.Name = "GrabStringsForm";
            this.ShowIcon = false;
            this.Text = "IdaGrabStrings";
            this.Load += new System.EventHandler(this.GrabStringsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.strMinimumBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button grabStringsBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn offsetColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valueColumn;
        private System.Windows.Forms.RadioButton asciiBox;
        private System.Windows.Forms.RadioButton extAsciiBox;
        private System.Windows.Forms.RadioButton alphanumAsciiBox;
        private System.Windows.Forms.NumericUpDown strMinimumBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button genStructBtn;
        private System.Windows.Forms.RadioButton notNulBox;
    }
}