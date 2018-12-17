using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EF
{
    public partial class Form1 : Form
    {
        Table model = new Table();
        public Form1()
        {
            InitializeComponent();
        }

        private void commentButton_Click(object sender, EventArgs e)
        {
            //var context = new CommentDBEntities();
            //var table = new Table()
            //{
            //    comment = commentTextBox.Text
            //};

            //context.Tables.Add(table);
            //context.SaveChanges();
            model.comment = commentTextBox.Text.Trim();
            using (CommentDBEntities db = new CommentDBEntities())
            {
                //if (model.Id == 0) db.Tables.Add(model);
                //else db.Entry(model).State = System.Data.Entity.EntityState.Modified;
                db.Tables.Add(model);
                db.SaveChanges();
            }
            Clear();
            FillDataGridView();

        }

        void Clear()
        {
            commentTextBox.Text = "";
            model.Id = 0;
        }

        void FillDataGridView()
        {
            using (CommentDBEntities db = new CommentDBEntities())
            {
                dataGridView.DataSource = db.Tables.ToList<Table>();
            }
        }
    }
}
