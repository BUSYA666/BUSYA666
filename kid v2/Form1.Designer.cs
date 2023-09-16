namespace Дет2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.kit4 = new System.Windows.Forms.PictureBox();
            this.kit3 = new System.Windows.Forms.PictureBox();
            this.kit2 = new System.Windows.Forms.PictureBox();
            this.kit1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.kit4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kit3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kit1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(162, 320);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(170, 60);
            this.button1.TabIndex = 5;
            this.button1.Text = "Дети";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(781, 320);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(170, 60);
            this.button2.TabIndex = 6;
            this.button2.Text = "Школа";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // kit4
            // 
            this.kit4.Image = global::Дет2.Properties.Resources._000;
            this.kit4.Location = new System.Drawing.Point(905, 48);
            this.kit4.Name = "kit4";
            this.kit4.Size = new System.Drawing.Size(230, 198);
            this.kit4.TabIndex = 4;
            this.kit4.TabStop = false;
            this.kit4.Visible = false;
            // 
            // kit3
            // 
            this.kit3.Image = global::Дет2.Properties.Resources._6128734611;
            this.kit3.Location = new System.Drawing.Point(614, 48);
            this.kit3.Name = "kit3";
            this.kit3.Size = new System.Drawing.Size(230, 198);
            this.kit3.TabIndex = 3;
            this.kit3.TabStop = false;
            this.kit3.Visible = false;
            // 
            // kit2
            // 
            this.kit2.Image = global::Дет2.Properties.Resources._000;
            this.kit2.Location = new System.Drawing.Point(344, 48);
            this.kit2.Name = "kit2";
            this.kit2.Size = new System.Drawing.Size(230, 198);
            this.kit2.TabIndex = 2;
            this.kit2.TabStop = false;
            this.kit2.Visible = false;
            // 
            // kit1
            // 
            this.kit1.Image = global::Дет2.Properties.Resources._612873461;
            this.kit1.Location = new System.Drawing.Point(38, 48);
            this.kit1.Name = "kit1";
            this.kit1.Size = new System.Drawing.Size(230, 198);
            this.kit1.TabIndex = 1;
            this.kit1.TabStop = false;
            this.kit1.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1162, 441);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.kit4);
            this.Controls.Add(this.kit3);
            this.Controls.Add(this.kit2);
            this.Controls.Add(this.kit1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.kit4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kit3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kit1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox kit1;
        private System.Windows.Forms.PictureBox kit2;
        private System.Windows.Forms.PictureBox kit3;
        private System.Windows.Forms.PictureBox kit4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

