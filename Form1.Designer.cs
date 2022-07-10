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
            this.SuspendLayout();
            // 
            // txtSQL
            // 
            this.txtSQL.Location = new System.Drawing.Point(21, 38);
            this.txtSQL.Multiline = true;
            this.txtSQL.Name = "txtSQL";
            this.txtSQL.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtSQL.Size = new System.Drawing.Size(544, 311);
            this.txtSQL.TabIndex = 0;
            this.txtSQL.TextChanged += new System.EventHandler(this.txtSQL_TextChanged);
            // 
            // txtStringBuilder
            // 
            this.txtStringBuilder.Location = new System.Drawing.Point(645, 38);
            this.txtStringBuilder.Multiline = true;
            this.txtStringBuilder.Name = "txtStringBuilder";
            this.txtStringBuilder.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtStringBuilder.Size = new System.Drawing.Size(544, 311);
            this.txtStringBuilder.TabIndex = 2;
            // 
            // lblTextBox1
            // 
            this.lblTextBox1.AutoSize = true;
            this.lblTextBox1.Location = new System.Drawing.Point(256, 20);
            this.lblTextBox1.Name = "lblTextBox1";
            this.lblTextBox1.Size = new System.Drawing.Size(28, 15);
            this.lblTextBox1.TabIndex = 3;
            this.lblTextBox1.Text = "SQL";
            this.lblTextBox1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTextBox2
            // 
            this.lblTextBox2.AutoSize = true;
            this.lblTextBox2.Location = new System.Drawing.Point(868, 20);
            this.lblTextBox2.Name = "lblTextBox2";
            this.lblTextBox2.Size = new System.Drawing.Size(75, 15);
            this.lblTextBox2.TabIndex = 4;
            this.lblTextBox2.Text = "StringBuilder";
            this.lblTextBox2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(237, 355);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnCopy
            // 
            this.btnCopy.Location = new System.Drawing.Point(843, 355);
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
            this.btnSwap.Location = new System.Drawing.Point(568, 239);
            this.btnSwap.Name = "btnSwap";
            this.btnSwap.Size = new System.Drawing.Size(75, 23);
            this.btnSwap.TabIndex = 7;
            this.btnSwap.Text = "<-Swap->";
            this.btnSwap.UseVisualStyleBackColor = true;
            this.btnSwap.Click += new System.EventHandler(this.btnSwap_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(568, 191);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Convert";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.txtSQL_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1215, 388);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSwap);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblTextBox2);
            this.Controls.Add(this.lblTextBox1);
            this.Controls.Add(this.txtStringBuilder);
            this.Controls.Add(this.txtSQL);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "SQL to StringBuilder";
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}