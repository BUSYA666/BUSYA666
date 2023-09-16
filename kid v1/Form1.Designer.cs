namespace Дет
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
            this.kit1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.kit2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.kit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kit2)).BeginInit();
            this.SuspendLayout();
            // 
            // kit1
            // 
            this.kit1.Image = global::Дет.Properties.Resources._612873461;
            this.kit1.Location = new System.Drawing.Point(94, 69);
            this.kit1.Name = "kit1";
            this.kit1.Size = new System.Drawing.Size(230, 198);
            this.kit1.TabIndex = 0;
            this.kit1.TabStop = false;
            this.kit1.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(286, 328);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(220, 65);
            this.button1.TabIndex = 1;
            this.button1.Text = "детишки";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // kit2
            // 
            this.kit2.Image = global::Дет.Properties.Resources._000;
            this.kit2.Location = new System.Drawing.Point(436, 69);
            this.kit2.Name = "kit2";
            this.kit2.Size = new System.Drawing.Size(230, 198);
            this.kit2.TabIndex = 2;
            this.kit2.TabStop = false;
            this.kit2.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.kit2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.kit1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.kit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kit2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox kit1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox kit2;
    }
}

