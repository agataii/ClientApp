namespace Maket
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
            this.label1 = new System.Windows.Forms.Label();
            this.url = new System.Windows.Forms.TextBox();
            this.Add_Click = new System.Windows.Forms.Button();
            this.textBox = new System.Windows.Forms.TextBox();
            this._btnSend = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(124, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "URL";
            // 
            // url
            // 
            this.url.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.url.Location = new System.Drawing.Point(124, 48);
            this.url.Name = "url";
            this.url.Size = new System.Drawing.Size(507, 21);
            this.url.TabIndex = 1;
            this.url.TextChanged += new System.EventHandler(this.URL_TextChanged);
            // 
            // Add_Click
            // 
            this.Add_Click.BackColor = System.Drawing.Color.SkyBlue;
            this.Add_Click.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Add_Click.ForeColor = System.Drawing.Color.Honeydew;
            this.Add_Click.Location = new System.Drawing.Point(394, 96);
            this.Add_Click.Name = "Add_Click";
            this.Add_Click.Size = new System.Drawing.Size(50, 50);
            this.Add_Click.TabIndex = 3;
            this.Add_Click.Text = "+";
            this.Add_Click.UseVisualStyleBackColor = false;
            this.Add_Click.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // textBox
            // 
            this.textBox.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox.Location = new System.Drawing.Point(124, 96);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(200, 21);
            this.textBox.TabIndex = 4;
            // 
            // _btnSend
            // 
            this._btnSend.BackColor = System.Drawing.Color.SkyBlue;
            this._btnSend.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this._btnSend.ForeColor = System.Drawing.Color.Honeydew;
            this._btnSend.Location = new System.Drawing.Point(522, 96);
            this._btnSend.Name = "_btnSend";
            this._btnSend.Size = new System.Drawing.Size(109, 50);
            this._btnSend.TabIndex = 5;
            this._btnSend.Text = "Send";
            this._btnSend.UseVisualStyleBackColor = false;
            this._btnSend.Click += new System.EventHandler(this.BtnSend_ClickAsync);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(124, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Departaments";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this._btnSend);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.Add_Click);
            this.Controls.Add(this.url);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox url;
        private Button Add_Click;
        private TextBox textBox;
        private Button _btnSend;
        private Label label2;
    }
}