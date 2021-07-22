namespace _2048WindowsFormsApp
{
    partial class RatingForm
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
            this.usersScoreDataGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.usersScoreDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // usersScoreDataGridView
            // 
            this.usersScoreDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usersScoreDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.usersScoreDataGridView.Location = new System.Drawing.Point(12, 12);
            this.usersScoreDataGridView.Name = "usersScoreDataGridView";
            this.usersScoreDataGridView.Size = new System.Drawing.Size(244, 223);
            this.usersScoreDataGridView.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Имя";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Рейтинг";
            this.Column2.Name = "Column2";
            // 
            // RatingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 247);
            this.Controls.Add(this.usersScoreDataGridView);
            this.Name = "RatingForm";
            this.Text = "RatingForm";
            this.Load += new System.EventHandler(this.RatingForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.usersScoreDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView usersScoreDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}