namespace WS
{
    partial class runnerRegistration
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
            this.oldMember = new System.Windows.Forms.Button();
            this.newMember = new System.Windows.Forms.Button();
            this.Login = new System.Windows.Forms.Button();
            this.toBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // oldMember
            // 
            this.oldMember.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.oldMember.Location = new System.Drawing.Point(232, 154);
            this.oldMember.Name = "oldMember";
            this.oldMember.Size = new System.Drawing.Size(401, 104);
            this.oldMember.TabIndex = 1;
            this.oldMember.Text = "Я участвовал ранее";
            this.oldMember.UseVisualStyleBackColor = true;
            // 
            // newMember
            // 
            this.newMember.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.newMember.Location = new System.Drawing.Point(232, 276);
            this.newMember.Name = "newMember";
            this.newMember.Size = new System.Drawing.Size(401, 104);
            this.newMember.TabIndex = 2;
            this.newMember.Text = "Я новый участник";
            this.newMember.UseVisualStyleBackColor = true;
            this.newMember.Click += new System.EventHandler(this.newMember_Click);
            // 
            // Login
            // 
            this.Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Login.Location = new System.Drawing.Point(707, 428);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(128, 58);
            this.Login.TabIndex = 4;
            this.Login.Text = "Login";
            this.Login.UseVisualStyleBackColor = true;
            // 
            // toBack
            // 
            this.toBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toBack.Location = new System.Drawing.Point(12, 12);
            this.toBack.Name = "toBack";
            this.toBack.Size = new System.Drawing.Size(93, 35);
            this.toBack.TabIndex = 30;
            this.toBack.Text = "Назад";
            this.toBack.UseVisualStyleBackColor = true;
            this.toBack.Click += new System.EventHandler(this.toBack_Click);
            // 
            // runnerRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 591);
            this.Controls.Add(this.toBack);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.newMember);
            this.Controls.Add(this.oldMember);
            this.Name = "runnerRegistration";
            this.Text = "Marathon Skills 2016 - Register as a runner";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button oldMember;
        private System.Windows.Forms.Button newMember;
        private System.Windows.Forms.Button Login;
        private System.Windows.Forms.Button toBack;
    }
}