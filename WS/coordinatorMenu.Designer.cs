namespace WS
{
    partial class coordinatorMenu
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
            this.sponsors = new System.Windows.Forms.Button();
            this.runners = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.logout = new System.Windows.Forms.Button();
            this.toBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // sponsors
            // 
            this.sponsors.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sponsors.Location = new System.Drawing.Point(450, 118);
            this.sponsors.Name = "sponsors";
            this.sponsors.Size = new System.Drawing.Size(401, 104);
            this.sponsors.TabIndex = 51;
            this.sponsors.Text = "Спонсоры";
            this.sponsors.UseVisualStyleBackColor = true;
            // 
            // runners
            // 
            this.runners.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.runners.Location = new System.Drawing.Point(21, 118);
            this.runners.Name = "runners";
            this.runners.Size = new System.Drawing.Size(401, 104);
            this.runners.TabIndex = 48;
            this.runners.Text = "Бегуны";
            this.runners.UseVisualStyleBackColor = true;
            this.runners.Click += new System.EventHandler(this.runners_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(349, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 29);
            this.label1.TabIndex = 47;
            this.label1.Text = "Меню координатора";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // logout
            // 
            this.logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.logout.Location = new System.Drawing.Point(768, 12);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(93, 35);
            this.logout.TabIndex = 46;
            this.logout.Text = "Logout";
            this.logout.UseVisualStyleBackColor = true;
            // 
            // toBack
            // 
            this.toBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toBack.Location = new System.Drawing.Point(11, 12);
            this.toBack.Name = "toBack";
            this.toBack.Size = new System.Drawing.Size(93, 35);
            this.toBack.TabIndex = 45;
            this.toBack.Text = "Назад";
            this.toBack.UseVisualStyleBackColor = true;
            // 
            // coordinatorMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 591);
            this.Controls.Add(this.sponsors);
            this.Controls.Add(this.runners);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.logout);
            this.Controls.Add(this.toBack);
            this.Name = "coordinatorMenu";
            this.Text = "Marathon Skills 2016 - Coordinator menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button sponsors;
        private System.Windows.Forms.Button runners;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button logout;
        private System.Windows.Forms.Button toBack;
    }
}