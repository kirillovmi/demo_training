namespace WS
{
    partial class Main
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
            this.becomeRunner = new System.Windows.Forms.Button();
            this.becomeSponsor = new System.Windows.Forms.Button();
            this.eventInfo = new System.Windows.Forms.Button();
            this.Login = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // becomeRunner
            // 
            this.becomeRunner.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.becomeRunner.Location = new System.Drawing.Point(232, 109);
            this.becomeRunner.Name = "becomeRunner";
            this.becomeRunner.Size = new System.Drawing.Size(401, 104);
            this.becomeRunner.TabIndex = 0;
            this.becomeRunner.Text = "Я хочу стать бегуном";
            this.becomeRunner.UseVisualStyleBackColor = true;
            this.becomeRunner.Click += new System.EventHandler(this.becomeRunner_Click);
            // 
            // becomeSponsor
            // 
            this.becomeSponsor.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.becomeSponsor.Location = new System.Drawing.Point(232, 228);
            this.becomeSponsor.Name = "becomeSponsor";
            this.becomeSponsor.Size = new System.Drawing.Size(401, 104);
            this.becomeSponsor.TabIndex = 1;
            this.becomeSponsor.Text = "Я хочу стать спонсором бегуна";
            this.becomeSponsor.UseVisualStyleBackColor = true;
            this.becomeSponsor.Click += new System.EventHandler(this.becomeSponsor_Click);
            // 
            // eventInfo
            // 
            this.eventInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.eventInfo.Location = new System.Drawing.Point(232, 350);
            this.eventInfo.Name = "eventInfo";
            this.eventInfo.Size = new System.Drawing.Size(401, 104);
            this.eventInfo.TabIndex = 2;
            this.eventInfo.Text = "Я хочу узнать больше о событии";
            this.eventInfo.UseVisualStyleBackColor = true;
            this.eventInfo.Click += new System.EventHandler(this.eventInfo_Click);
            // 
            // Login
            // 
            this.Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Login.Location = new System.Drawing.Point(707, 428);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(128, 58);
            this.Login.TabIndex = 3;
            this.Login.Text = "Login";
            this.Login.UseVisualStyleBackColor = true;
            this.Login.Click += new System.EventHandler(this.Login_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 591);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.eventInfo);
            this.Controls.Add(this.becomeSponsor);
            this.Controls.Add(this.becomeRunner);
            this.Name = "Main";
            this.Text = "Marathon Skills 2016";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button becomeRunner;
        private System.Windows.Forms.Button becomeSponsor;
        private System.Windows.Forms.Button eventInfo;
        private System.Windows.Forms.Button Login;
    }
}

