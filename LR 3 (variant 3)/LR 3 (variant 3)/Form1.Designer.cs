namespace LR_3__variant_3_
{
    partial class Form1
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
            this.cmbFilms = new System.Windows.Forms.ComboBox();
            this.listGenres = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelCost = new System.Windows.Forms.Label();
            this.labelDirector = new System.Windows.Forms.Label();
            this.labelRoles = new System.Windows.Forms.Label();
            this.labelExpiry = new System.Windows.Forms.Label();
            this.numQuantity = new System.Windows.Forms.NumericUpDown();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonReport = new System.Windows.Forms.Button();
            this.listOrder = new System.Windows.Forms.ListBox();
            this.textReport = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbFilms
            // 
            this.cmbFilms.FormattingEnabled = true;
            this.cmbFilms.Location = new System.Drawing.Point(31, 63);
            this.cmbFilms.Name = "cmbFilms";
            this.cmbFilms.Size = new System.Drawing.Size(121, 21);
            this.cmbFilms.TabIndex = 0;
            // 
            // listGenres
            // 
            this.listGenres.FormattingEnabled = true;
            this.listGenres.Location = new System.Drawing.Point(69, 168);
            this.listGenres.Name = "listGenres";
            this.listGenres.Size = new System.Drawing.Size(120, 95);
            this.listGenres.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(117, 289);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // labelCost
            // 
            this.labelCost.AutoSize = true;
            this.labelCost.Location = new System.Drawing.Point(117, 340);
            this.labelCost.Name = "labelCost";
            this.labelCost.Size = new System.Drawing.Size(35, 13);
            this.labelCost.TabIndex = 3;
            this.labelCost.Text = "label2";
            // 
            // labelDirector
            // 
            this.labelDirector.AutoSize = true;
            this.labelDirector.Location = new System.Drawing.Point(120, 376);
            this.labelDirector.Name = "labelDirector";
            this.labelDirector.Size = new System.Drawing.Size(35, 13);
            this.labelDirector.TabIndex = 4;
            this.labelDirector.Text = "label2";
            // 
            // labelRoles
            // 
            this.labelRoles.AutoSize = true;
            this.labelRoles.Location = new System.Drawing.Point(120, 405);
            this.labelRoles.Name = "labelRoles";
            this.labelRoles.Size = new System.Drawing.Size(35, 13);
            this.labelRoles.TabIndex = 5;
            this.labelRoles.Text = "label2";
            // 
            // labelExpiry
            // 
            this.labelExpiry.AutoSize = true;
            this.labelExpiry.Location = new System.Drawing.Point(237, 354);
            this.labelExpiry.Name = "labelExpiry";
            this.labelExpiry.Size = new System.Drawing.Size(35, 13);
            this.labelExpiry.TabIndex = 6;
            this.labelExpiry.Text = "label2";
            // 
            // numQuantity
            // 
            this.numQuantity.Location = new System.Drawing.Point(482, 281);
            this.numQuantity.Name = "numQuantity";
            this.numQuantity.Size = new System.Drawing.Size(120, 20);
            this.numQuantity.TabIndex = 7;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(493, 343);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 8;
            this.buttonAdd.Text = "Свойства";
            this.buttonAdd.UseVisualStyleBackColor = true;
            // 
            // buttonReport
            // 
            this.buttonReport.Location = new System.Drawing.Point(493, 385);
            this.buttonReport.Name = "buttonReport";
            this.buttonReport.Size = new System.Drawing.Size(75, 23);
            this.buttonReport.TabIndex = 9;
            this.buttonReport.Text = "Отчет";
            this.buttonReport.UseVisualStyleBackColor = true;
            // 
            // listOrder
            // 
            this.listOrder.FormattingEnabled = true;
            this.listOrder.Location = new System.Drawing.Point(641, 215);
            this.listOrder.Name = "listOrder";
            this.listOrder.Size = new System.Drawing.Size(120, 95);
            this.listOrder.TabIndex = 10;
            // 
            // textReport
            // 
            this.textReport.Location = new System.Drawing.Point(641, 332);
            this.textReport.Name = "textReport";
            this.textReport.Size = new System.Drawing.Size(100, 20);
            this.textReport.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textReport);
            this.Controls.Add(this.listOrder);
            this.Controls.Add(this.buttonReport);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.numQuantity);
            this.Controls.Add(this.labelExpiry);
            this.Controls.Add(this.labelRoles);
            this.Controls.Add(this.labelDirector);
            this.Controls.Add(this.labelCost);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listGenres);
            this.Controls.Add(this.cmbFilms);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbFilms;
        private System.Windows.Forms.ListBox listGenres;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelCost;
        private System.Windows.Forms.Label labelDirector;
        private System.Windows.Forms.Label labelRoles;
        private System.Windows.Forms.Label labelExpiry;
        private System.Windows.Forms.NumericUpDown numQuantity;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonReport;
        private System.Windows.Forms.ListBox listOrder;
        private System.Windows.Forms.TextBox textReport;
    }
}