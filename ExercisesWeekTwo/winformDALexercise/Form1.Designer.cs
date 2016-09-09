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
            this.lbl_Enter_firstname = new System.Windows.Forms.Label();
            this.txtbox_fName = new System.Windows.Forms.TextBox();
            this.lbl_Enter_Lastname = new System.Windows.Forms.Label();
            this.txtbox_lastName = new System.Windows.Forms.TextBox();
            this.btn_Add = new System.Windows.Forms.Button();
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
            this.txtbox_AuthorIDtoDelete.Size = new System.Drawing.Size(45, 20);
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
            this.btn_Delete.Location = new System.Drawing.Point(189, 167);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(75, 23);
            this.btn_Delete.TabIndex = 3;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // lbl_Enter_firstname
            // 
            this.lbl_Enter_firstname.AutoSize = true;
            this.lbl_Enter_firstname.Location = new System.Drawing.Point(40, 199);
            this.lbl_Enter_firstname.Name = "lbl_Enter_firstname";
            this.lbl_Enter_firstname.Size = new System.Drawing.Size(83, 13);
            this.lbl_Enter_firstname.TabIndex = 4;
            this.lbl_Enter_firstname.Text = "Enter first name:";
            // 
            // txtbox_fName
            // 
            this.txtbox_fName.Location = new System.Drawing.Point(138, 199);
            this.txtbox_fName.Name = "txtbox_fName";
            this.txtbox_fName.Size = new System.Drawing.Size(112, 20);
            this.txtbox_fName.TabIndex = 5;
            // 
            // lbl_Enter_Lastname
            // 
            this.lbl_Enter_Lastname.AutoSize = true;
            this.lbl_Enter_Lastname.Location = new System.Drawing.Point(40, 227);
            this.lbl_Enter_Lastname.Name = "lbl_Enter_Lastname";
            this.lbl_Enter_Lastname.Size = new System.Drawing.Size(86, 13);
            this.lbl_Enter_Lastname.TabIndex = 6;
            this.lbl_Enter_Lastname.Text = "Enter last name: ";
            // 
            // txtbox_lastName
            // 
            this.txtbox_lastName.Location = new System.Drawing.Point(138, 227);
            this.txtbox_lastName.Name = "txtbox_lastName";
            this.txtbox_lastName.Size = new System.Drawing.Size(112, 20);
            this.txtbox_lastName.TabIndex = 7;
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(257, 223);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(75, 23);
            this.btn_Add.TabIndex = 8;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 261);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.txtbox_lastName);
            this.Controls.Add(this.lbl_Enter_Lastname);
            this.Controls.Add(this.txtbox_fName);
            this.Controls.Add(this.lbl_Enter_firstname);
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
        private System.Windows.Forms.Label lbl_Enter_firstname;
        private System.Windows.Forms.TextBox txtbox_fName;
        private System.Windows.Forms.Label lbl_Enter_Lastname;
        private System.Windows.Forms.TextBox txtbox_lastName;
        private System.Windows.Forms.Button btn_Add;
    }
}

