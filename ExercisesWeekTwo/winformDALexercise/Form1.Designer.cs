using MyDal.DAL;
using MyDal.Models;

namespace winformDALexercise
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
            this.AuthorGridView = new System.Windows.Forms.DataGridView();
            this.txtbox_AuthorIDtoDelete = new System.Windows.Forms.TextBox();
            this.lbl_authorDelete = new System.Windows.Forms.Label();
            this.btn_Delete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.AuthorGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // AuthorGridView
            // 
            this.AuthorGridView.AllowUserToAddRows = false;
            this.AuthorGridView.AllowUserToDeleteRows = false;
            this.AuthorGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AuthorGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AuthorGridView.Location = new System.Drawing.Point(31, 13);
            this.AuthorGridView.Name = "AuthorGridView";
            this.AuthorGridView.ReadOnly = true;
            this.AuthorGridView.Size = new System.Drawing.Size(397, 150);
            this.AuthorGridView.TabIndex = 0;
            // 
            // txtbox_AuthorIDtoDelete
            // 
            this.txtbox_AuthorIDtoDelete.Location = new System.Drawing.Point(138, 169);
            this.txtbox_AuthorIDtoDelete.Name = "txtbox_AuthorIDtoDelete";
            this.txtbox_AuthorIDtoDelete.Size = new System.Drawing.Size(112, 20);
            this.txtbox_AuthorIDtoDelete.TabIndex = 1;
            // 
            // lbl_authorDelete
            // 
            this.lbl_authorDelete.AutoSize = true;
            this.lbl_authorDelete.Location = new System.Drawing.Point(40, 172);
            this.lbl_authorDelete.Name = "lbl_authorDelete";
            this.lbl_authorDelete.Size = new System.Drawing.Size(92, 13);
            this.lbl_authorDelete.TabIndex = 2;
            this.lbl_authorDelete.Text = "Enter ID to Delete";
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(256, 169);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(75, 23);
            this.btn_Delete.TabIndex = 3;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 261);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.lbl_authorDelete);
            this.Controls.Add(this.txtbox_AuthorIDtoDelete);
            this.Controls.Add(this.AuthorGridView);
            this.Name = "Form1";
            this.Text = "Authors";
            ((System.ComponentModel.ISupportInitialize)(this.AuthorGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView AuthorGridView;
        private System.Windows.Forms.TextBox txtbox_AuthorIDtoDelete;
        private System.Windows.Forms.Label lbl_authorDelete;
        private System.Windows.Forms.Button btn_Delete;
    }
}

