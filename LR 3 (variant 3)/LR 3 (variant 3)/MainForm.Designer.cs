namespace LR_3__variant_3_
{
    partial class MainForm
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
            this.ReportButton = new System.Windows.Forms.Button();
            this.FilmImagePictureBox = new System.Windows.Forms.PictureBox();
            this.RentalPriceLabel = new System.Windows.Forms.Label();
            this.DirectorLabel = new System.Windows.Forms.Label();
            this.MainRolesLabel = new System.Windows.Forms.Label();
            this.RentalDateLabel = new System.Windows.Forms.Label();
            this.GenresListBox = new System.Windows.Forms.ListBox();
            this.FilmesComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.FilmImagePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // ReportButton
            // 
            this.ReportButton.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReportButton.Location = new System.Drawing.Point(40, 22);
            this.ReportButton.Name = "ReportButton";
            this.ReportButton.Size = new System.Drawing.Size(111, 49);
            this.ReportButton.TabIndex = 1;
            this.ReportButton.Text = "Отчет";
            this.ReportButton.UseVisualStyleBackColor = true;
            // 
            // FilmImagePictureBox
            // 
            this.FilmImagePictureBox.Location = new System.Drawing.Point(311, 22);
            this.FilmImagePictureBox.Name = "FilmImagePictureBox";
            this.FilmImagePictureBox.Size = new System.Drawing.Size(333, 311);
            this.FilmImagePictureBox.TabIndex = 2;
            this.FilmImagePictureBox.TabStop = false;
            // 
            // RentalPriceLabel
            // 
            this.RentalPriceLabel.AutoSize = true;
            this.RentalPriceLabel.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RentalPriceLabel.Location = new System.Drawing.Point(307, 356);
            this.RentalPriceLabel.Name = "RentalPriceLabel";
            this.RentalPriceLabel.Size = new System.Drawing.Size(149, 21);
            this.RentalPriceLabel.TabIndex = 3;
            this.RentalPriceLabel.Text = "Стоимость проката";
            // 
            // DirectorLabel
            // 
            this.DirectorLabel.AutoSize = true;
            this.DirectorLabel.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DirectorLabel.Location = new System.Drawing.Point(307, 413);
            this.DirectorLabel.Name = "DirectorLabel";
            this.DirectorLabel.Size = new System.Drawing.Size(79, 21);
            this.DirectorLabel.TabIndex = 4;
            this.DirectorLabel.Text = "Режиссер\r\n";
            // 
            // MainRolesLabel
            // 
            this.MainRolesLabel.AutoSize = true;
            this.MainRolesLabel.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainRolesLabel.Location = new System.Drawing.Point(307, 466);
            this.MainRolesLabel.Name = "MainRolesLabel";
            this.MainRolesLabel.Size = new System.Drawing.Size(110, 21);
            this.MainRolesLabel.TabIndex = 5;
            this.MainRolesLabel.Text = "Главные роли";
            // 
            // RentalDateLabel
            // 
            this.RentalDateLabel.AutoSize = true;
            this.RentalDateLabel.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RentalDateLabel.Location = new System.Drawing.Point(307, 513);
            this.RentalDateLabel.Name = "RentalDateLabel";
            this.RentalDateLabel.Size = new System.Drawing.Size(195, 21);
            this.RentalDateLabel.TabIndex = 6;
            this.RentalDateLabel.Text = "Срок завершения проката";
            // 
            // GenresListBox
            // 
            this.GenresListBox.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenresListBox.FormattingEnabled = true;
            this.GenresListBox.ItemHeight = 21;
            this.GenresListBox.Location = new System.Drawing.Point(40, 106);
            this.GenresListBox.Name = "GenresListBox";
            this.GenresListBox.Size = new System.Drawing.Size(120, 88);
            this.GenresListBox.TabIndex = 7;
            // 
            // FilmesComboBox
            // 
            this.FilmesComboBox.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FilmesComboBox.FormattingEnabled = true;
            this.FilmesComboBox.Location = new System.Drawing.Point(40, 244);
            this.FilmesComboBox.Name = "FilmesComboBox";
            this.FilmesComboBox.Size = new System.Drawing.Size(121, 29);
            this.FilmesComboBox.TabIndex = 8;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 562);
            this.Controls.Add(this.FilmesComboBox);
            this.Controls.Add(this.GenresListBox);
            this.Controls.Add(this.RentalDateLabel);
            this.Controls.Add(this.MainRolesLabel);
            this.Controls.Add(this.DirectorLabel);
            this.Controls.Add(this.RentalPriceLabel);
            this.Controls.Add(this.FilmImagePictureBox);
            this.Controls.Add(this.ReportButton);
            this.Name = "MainForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.FilmImagePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ReportButton;
        private System.Windows.Forms.PictureBox FilmImagePictureBox;
        private System.Windows.Forms.Label RentalPriceLabel;
        private System.Windows.Forms.Label DirectorLabel;
        private System.Windows.Forms.Label MainRolesLabel;
        private System.Windows.Forms.Label RentalDateLabel;
        private System.Windows.Forms.ListBox GenresListBox;
        private System.Windows.Forms.ComboBox FilmesComboBox;
    }
}

