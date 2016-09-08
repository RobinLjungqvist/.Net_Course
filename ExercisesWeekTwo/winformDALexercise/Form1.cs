using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyDal.DAL;

namespace winformDALexercise
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Populate();
            BindGrid();
            
        }
        public void BindGrid()
        {
            var dal = new DAL_Author();
            dal.OpenConnection(@"Data Source=(local);Initial Catalog=books;User ID=Ropplon; Password=robin;Integrated Security = True");
            var authorTable = dal.GetAllAuthorsToDataTable();
            AuthorGridView.DataSource = authorTable;
            dal.CloseConnection();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            var dal = new DAL_Author();
            try
            {
                dal.OpenConnection(@"Data Source=(local);Initial Catalog=books;User ID=Ropplon; Password=robin;Integrated Security = True");
                var id = int.Parse(txtbox_AuthorIDtoDelete.Text);
                dal.DeleteAuthor(id);
                BindGrid();
                dal.CloseConnection();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.Message);
            }

        }

        private void Populate()
        {
            var dal = new DAL_Author();
            dal.OpenConnection(@"Data Source=(local);Initial Catalog=books;User ID=Ropplon; Password=robin;Integrated Security = True");
            dal.InsertAuthor("Astrid", "Lindgren");
            dal.InsertAuthor("David", "Eddings");
            dal.InsertAuthor("J.K", "Rowling");
            dal.CloseConnection();

        }
    }
}
