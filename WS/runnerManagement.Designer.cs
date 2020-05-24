namespace WS
{
    partial class runnerManagement
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
            this.runnersTable = new System.Windows.Forms.DataGridView();
            this.totalRunners = new System.Windows.Forms.Label();
            this.toBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.runnersTable)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(302, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Управление бегунами";
            // 
            // runnersTable
            // 
            this.runnersTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.runnersTable.Location = new System.Drawing.Point(12, 238);
            this.runnersTable.Name = "runnersTable";
            this.runnersTable.RowHeadersWidth = 51;
            this.runnersTable.RowTemplate.Height = 24;
            this.runnersTable.Size = new System.Drawing.Size(850, 341);
            this.runnersTable.TabIndex = 3;
            // 
            // totalRunners
            // 
            this.totalRunners.AutoSize = true;
            this.totalRunners.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.totalRunners.Location = new System.Drawing.Point(349, 195);
            this.totalRunners.Name = "totalRunners";
            this.totalRunners.Size = new System.Drawing.Size(161, 29);
            this.totalRunners.TabIndex = 4;
            this.totalRunners.Text = "Total runners:";
            // 
            // toBack
            // 
            this.toBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toBack.Location = new System.Drawing.Point(12, 12);
            this.toBack.Name = "toBack";
            this.toBack.Size = new System.Drawing.Size(93, 35);
            this.toBack.TabIndex = 29;
            this.toBack.Text = "Назад";
            this.toBack.UseVisualStyleBackColor = true;
            this.toBack.Click += new System.EventHandler(this.toBack_Click);
            // 
            // runnerManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 591);
            this.Controls.Add(this.toBack);
            this.Controls.Add(this.totalRunners);
            this.Controls.Add(this.runnersTable);
            this.Controls.Add(this.label1);
            this.Name = "runnerManagement";
            this.Text = "Marathon Skills 2016 - Runner management";
            this.Load += new System.EventHandler(this.runnerManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.runnersTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView runnersTable;
        private System.Windows.Forms.Label totalRunners;
        private System.Windows.Forms.Button toBack;
    }
}