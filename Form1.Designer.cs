namespace SQLStringBuilder
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtSQL = new System.Windows.Forms.TextBox();
            this.txtStringBuilder = new System.Windows.Forms.TextBox();
            this.lblTextBox1 = new System.Windows.Forms.Label();
            this.lblTextBox2 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnCopy = new System.Windows.Forms.Button();
            this.notifyTextCopied = new System.Windows.Forms.NotifyIcon(this.components);
            this.btnSwap = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.StringBuilder = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTableName = new System.Windows.Forms.TextBox();
            this.txtInsertData = new System.Windows.Forms.TextBox();
            this.btnCopyInsert = new System.Windows.Forms.Button();
            this.txtInsertSQL = new System.Windows.Forms.TextBox();
            this.btnClearInsert = new System.Windows.Forms.Button();
            this.btnConvertInsert = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.StringBuilder.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSQL
            // 
            this.txtSQL.Location = new System.Drawing.Point(17, 24);
            this.txtSQL.Multiline = true;
            this.txtSQL.Name = "txtSQL";
            this.txtSQL.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtSQL.Size = new System.Drawing.Size(544, 311);
            this.txtSQL.TabIndex = 0;
            this.txtSQL.TextChanged += new System.EventHandler(this.txtSQL_TextChanged);
            // 
            // txtStringBuilder
            // 
            this.txtStringBuilder.Location = new System.Drawing.Point(661, 24);
            this.txtStringBuilder.Multiline = true;
            this.txtStringBuilder.Name = "txtStringBuilder";
            this.txtStringBuilder.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtStringBuilder.Size = new System.Drawing.Size(544, 311);
            this.txtStringBuilder.TabIndex = 2;
            // 
            // lblTextBox1
            // 
            this.lblTextBox1.AutoSize = true;
            this.lblTextBox1.Location = new System.Drawing.Point(238, 9);
            this.lblTextBox1.Name = "lblTextBox1";
            this.lblTextBox1.Size = new System.Drawing.Size(28, 15);
            this.lblTextBox1.TabIndex = 3;
            this.lblTextBox1.Text = "SQL";
            this.lblTextBox1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTextBox2
            // 
            this.lblTextBox2.AutoSize = true;
            this.lblTextBox2.Location = new System.Drawing.Point(883, 8);
            this.lblTextBox2.Name = "lblTextBox2";
            this.lblTextBox2.Size = new System.Drawing.Size(75, 15);
            this.lblTextBox2.TabIndex = 4;
            this.lblTextBox2.Text = "StringBuilder";
            this.lblTextBox2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(218, 341);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnCopy
            // 
            this.btnCopy.Location = new System.Drawing.Point(856, 341);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(131, 23);
            this.btnCopy.TabIndex = 6;
            this.btnCopy.Text = "Copy to Clipboard";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // notifyTextCopied
            // 
            this.notifyTextCopied.BalloonTipText = "StringBuilder Copied!";
            this.notifyTextCopied.Text = "StringBuilder Copied!";
            this.notifyTextCopied.Visible = true;
            // 
            // btnSwap
            // 
            this.btnSwap.Location = new System.Drawing.Point(567, 194);
            this.btnSwap.Name = "btnSwap";
            this.btnSwap.Size = new System.Drawing.Size(75, 23);
            this.btnSwap.TabIndex = 7;
            this.btnSwap.Text = "<-Swap->";
            this.btnSwap.UseVisualStyleBackColor = true;
            this.btnSwap.Click += new System.EventHandler(this.btnSwap_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(567, 125);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Convert";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.txtSQL_TextChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.StringBuilder);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1218, 441);
            this.tabControl1.TabIndex = 10;
            // 
            // StringBuilder
            // 
            this.StringBuilder.Controls.Add(this.txtSQL);
            this.StringBuilder.Controls.Add(this.btnCopy);
            this.StringBuilder.Controls.Add(this.txtStringBuilder);
            this.StringBuilder.Controls.Add(this.btnClear);
            this.StringBuilder.Controls.Add(this.btnSwap);
            this.StringBuilder.Controls.Add(this.button1);
            this.StringBuilder.Controls.Add(this.lblTextBox1);
            this.StringBuilder.Controls.Add(this.lblTextBox2);
            this.StringBuilder.Location = new System.Drawing.Point(4, 24);
            this.StringBuilder.Name = "StringBuilder";
            this.StringBuilder.Padding = new System.Windows.Forms.Padding(3);
            this.StringBuilder.Size = new System.Drawing.Size(1210, 413);
            this.StringBuilder.TabIndex = 0;
            this.StringBuilder.Text = "StringBuilder";
            this.StringBuilder.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.txtTableName);
            this.tabPage2.Controls.Add(this.txtInsertData);
            this.tabPage2.Controls.Add(this.btnCopyInsert);
            this.tabPage2.Controls.Add(this.txtInsertSQL);
            this.tabPage2.Controls.Add(this.btnClearInsert);
            this.tabPage2.Controls.Add(this.btnConvertInsert);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1210, 413);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Insert Data";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 15);
            this.label3.TabIndex = 18;
            this.label3.Text = "Table Name:";
            // 
            // txtTableName
            // 
            this.txtTableName.Location = new System.Drawing.Point(110, 17);
            this.txtTableName.Name = "txtTableName";
            this.txtTableName.Size = new System.Drawing.Size(146, 23);
            this.txtTableName.TabIndex = 17;
            // 
            // txtInsertData
            // 
            this.txtInsertData.Location = new System.Drawing.Point(22, 64);
            this.txtInsertData.Multiline = true;
            this.txtInsertData.Name = "txtInsertData";
            this.txtInsertData.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtInsertData.Size = new System.Drawing.Size(544, 311);
            this.txtInsertData.TabIndex = 9;
            // 
            // btnCopyInsert
            // 
            this.btnCopyInsert.Location = new System.Drawing.Point(861, 381);
            this.btnCopyInsert.Name = "btnCopyInsert";
            this.btnCopyInsert.Size = new System.Drawing.Size(131, 23);
            this.btnCopyInsert.TabIndex = 14;
            this.btnCopyInsert.Text = "Copy to Clipboard";
            this.btnCopyInsert.UseVisualStyleBackColor = true;
            this.btnCopyInsert.Click += new System.EventHandler(this.btnCopyInsert_Click);
            // 
            // txtInsertSQL
            // 
            this.txtInsertSQL.Location = new System.Drawing.Point(666, 64);
            this.txtInsertSQL.Multiline = true;
            this.txtInsertSQL.Name = "txtInsertSQL";
            this.txtInsertSQL.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtInsertSQL.Size = new System.Drawing.Size(544, 311);
            this.txtInsertSQL.TabIndex = 10;
            // 
            // btnClearInsert
            // 
            this.btnClearInsert.Location = new System.Drawing.Point(223, 381);
            this.btnClearInsert.Name = "btnClearInsert";
            this.btnClearInsert.Size = new System.Drawing.Size(75, 23);
            this.btnClearInsert.TabIndex = 13;
            this.btnClearInsert.Text = "Clear";
            this.btnClearInsert.UseVisualStyleBackColor = true;
            this.btnClearInsert.Click += new System.EventHandler(this.btnClearInsert_Click);
            // 
            // btnConvertInsert
            // 
            this.btnConvertInsert.Location = new System.Drawing.Point(579, 219);
            this.btnConvertInsert.Name = "btnConvertInsert";
            this.btnConvertInsert.Size = new System.Drawing.Size(75, 23);
            this.btnConvertInsert.TabIndex = 16;
            this.btnConvertInsert.Text = "Convert";
            this.btnConvertInsert.UseVisualStyleBackColor = true;
            this.btnConvertInsert.Click += new System.EventHandler(this.btnConvertInsert_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(243, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "Data";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(888, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 15);
            this.label2.TabIndex = 12;
            this.label2.Text = "SQL";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1242, 465);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "SQL to StringBuilder";
            this.tabControl1.ResumeLayout(false);
            this.StringBuilder.ResumeLayout(false);
            this.StringBuilder.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TextBox txtSQL;
        private TextBox txtStringBuilder;
        private Label lblTextBox1;
        private Label lblTextBox2;
        private Button btnClear;
        private Button btnCopy;
        private NotifyIcon notifyTextCopied;
        private Button btnSwap;
        private Button button1;
        private TabControl tabControl1;
        private TabPage StringBuilder;
        private TabPage tabPage2;
        private TextBox txtInsertData;
        private Button btnCopyInsert;
        private TextBox txtInsertSQL;
        private Button btnClearInsert;
        private Button btnConvertInsert;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtTableName;
    }
}