namespace Adresbuch
{
    partial class Startseite
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
            this.btnHunzufuegen = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnHunzufuegen
            // 
            this.btnHunzufuegen.Location = new System.Drawing.Point(175, 326);
            this.btnHunzufuegen.Name = "btnHunzufuegen";
            this.btnHunzufuegen.Size = new System.Drawing.Size(75, 23);
            this.btnHunzufuegen.TabIndex = 0;
            this.btnHunzufuegen.Text = "Hunzufuegen";
            this.btnHunzufuegen.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(400, 325);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Startseite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnHunzufuegen);
            this.Name = "Startseite";
            this.Text = "Startseite";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnHunzufuegen;
        private System.Windows.Forms.Button button2;
    }
}

