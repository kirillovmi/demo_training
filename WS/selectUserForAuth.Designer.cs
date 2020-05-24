namespace WS
{
    partial class selectUserForAuth
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
            this.label2 = new System.Windows.Forms.Label();
            this.runner = new System.Windows.Forms.Button();
            this.coordinator = new System.Windows.Forms.Button();
            this.administrator = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(77, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(321, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Только для тестирования!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(69, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(350, 48);
            this.label2.TabIndex = 3;
            this.label2.Text = "Под каким пользователем вы хотите \r\nвойти в систему?";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // runner
            // 
            this.runner.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.runner.Location = new System.Drawing.Point(155, 240);
            this.runner.Name = "runner";
            this.runner.Size = new System.Drawing.Size(171, 35);
            this.runner.TabIndex = 27;
            this.runner.Text = "Бегун";
            this.runner.UseVisualStyleBackColor = true;
            // 
            // coordinator
            // 
            this.coordinator.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.coordinator.Location = new System.Drawing.Point(155, 290);
            this.coordinator.Name = "coordinator";
            this.coordinator.Size = new System.Drawing.Size(171, 35);
            this.coordinator.TabIndex = 28;
            this.coordinator.Text = "Координатор";
            this.coordinator.UseVisualStyleBackColor = true;
            // 
            // administrator
            // 
            this.administrator.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.administrator.Location = new System.Drawing.Point(155, 341);
            this.administrator.Name = "administrator";
            this.administrator.Size = new System.Drawing.Size(171, 35);
            this.administrator.TabIndex = 29;
            this.administrator.Text = "Администротор";
            this.administrator.UseVisualStyleBackColor = true;
            // 
            // close
            // 
            this.close.FlatAppearance.BorderSize = 0;
            this.close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.close.ForeColor = System.Drawing.Color.Red;
            this.close.Location = new System.Drawing.Point(450, 2);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(39, 31);
            this.close.TabIndex = 30;
            this.close.Text = "X";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // selectUserForAuth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 518);
            this.Controls.Add(this.close);
            this.Controls.Add(this.administrator);
            this.Controls.Add(this.coordinator);
            this.Controls.Add(this.runner);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "selectUserForAuth";
            this.Text = "selectUserForAuth";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button runner;
        private System.Windows.Forms.Button coordinator;
        private System.Windows.Forms.Button administrator;
        private System.Windows.Forms.Button close;
    }
}