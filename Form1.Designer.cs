namespace WP_2020_01_HW01_3A713133
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.rich = new System.Windows.Forms.RichTextBox();
            this.btn1 = new System.Windows.Forms.Button();
            this.tex = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // rich
            // 
            this.rich.Location = new System.Drawing.Point(61, 236);
            this.rich.Name = "rich";
            this.rich.Size = new System.Drawing.Size(163, 150);
            this.rich.TabIndex = 0;
            this.rich.Text = "";
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(61, 107);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(163, 100);
            this.btn1.TabIndex = 1;
            this.btn1.Text = "輸入";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // tex
            // 
            this.tex.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tex.Location = new System.Drawing.Point(61, 51);
            this.tex.Name = "tex";
            this.tex.Size = new System.Drawing.Size(163, 36);
            this.tex.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 449);
            this.Controls.Add(this.tex);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.rich);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rich;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.TextBox tex;
    }
}

