namespace WS
{
    partial class runnerMenu
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
            this.logout = new System.Windows.Forms.Button();
            this.toBack = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.contacts = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.becomeRunner = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(350, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 29);
            this.label1.TabIndex = 39;
            this.label1.Text = "Меню бегуна";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // logout
            // 
            this.logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.logout.Location = new System.Drawing.Point(769, 12);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(93, 35);
            this.logout.TabIndex = 38;
            this.logout.Text = "Logout";
            this.logout.UseVisualStyleBackColor = true;
            // 
            // toBack
            // 
            this.toBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toBack.Location = new System.Drawing.Point(12, 12);
            this.toBack.Name = "toBack";
            this.toBack.Size = new System.Drawing.Size(93, 35);
            this.toBack.TabIndex = 37;
            this.toBack.Text = "Назад";
            this.toBack.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(451, 244);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(401, 104);
            this.button4.TabIndex = 44;
            this.button4.Text = "Мой спонсор";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(451, 118);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(401, 104);
            this.button2.TabIndex = 43;
            this.button2.Text = "Мои результаты";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // contacts
            // 
            this.contacts.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.contacts.Location = new System.Drawing.Point(22, 368);
            this.contacts.Name = "contacts";
            this.contacts.Size = new System.Drawing.Size(401, 104);
            this.contacts.TabIndex = 42;
            this.contacts.Text = "Контакты";
            this.contacts.UseVisualStyleBackColor = true;
            this.contacts.Click += new System.EventHandler(this.contacts_Click);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button7.Location = new System.Drawing.Point(22, 244);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(401, 104);
            this.button7.TabIndex = 41;
            this.button7.Text = "Редактирование профиля";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // becomeRunner
            // 
            this.becomeRunner.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.becomeRunner.Location = new System.Drawing.Point(22, 118);
            this.becomeRunner.Name = "becomeRunner";
            this.becomeRunner.Size = new System.Drawing.Size(401, 104);
            this.becomeRunner.TabIndex = 40;
            this.becomeRunner.Text = "Регистрация на марафон";
            this.becomeRunner.UseVisualStyleBackColor = true;
            // 
            // runnerMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 591);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.contacts);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.becomeRunner);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.logout);
            this.Controls.Add(this.toBack);
            this.Name = "runnerMenu";
            this.Text = "Marathon Skills 2016 - Runner menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button logout;
        private System.Windows.Forms.Button toBack;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button contacts;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button becomeRunner;
    }
}