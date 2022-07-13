using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoWIUTGallery
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            getMaxId();
        }

        string imgLocation = "";
        string pathString = Path.Combine("db"); // creating folder for db file  

        SqliteConnection connection = new SqliteConnection("Data Source=db/WIUTGalleryDb.db;Cache=Shared;Mode=ReadWriteCreate;");
        SqliteCommand cmd;
        int i = 1;
        int max_id = 0;

        private void getMaxId()
        {
            try
            {
                connection.Open();
                string sqlQuery = "select ifnull(max(id),0) from WIUTGallery";
                cmd = new SqliteCommand(sqlQuery, connection);
                SqliteDataReader DataRead2 = cmd.ExecuteReader();
                DataRead2.Read();
                max_id = DataRead2.GetInt32(0);
                connection.Close();
            }
            catch (Exception)
            {
                max_id = 0;
            }
            //MessageBox.Show("max_id = " + max_id);
        }

        private void browseBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "png files(*.png)|*.png|jpg files(*.jpg)|*.jpg|all files(*.*)|*.*";
            nameTextBox.Text = null;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                //nameTextBox.Text = null;
                imgLocation = dialog.FileName.ToString();
                pictureBox1.ImageLocation = imgLocation;
                idTextBox1.Text = null;
            }
        }

        private void connDbBtn_Click(object sender, EventArgs e)
        {
            Directory.CreateDirectory(pathString);
            connection.Open();
            try
            {
                SqliteCommand command = new SqliteCommand(@"CREATE TABLE [WIUTGallery] (
                      [id] integer PRIMARY KEY AUTOINCREMENT NOT NULL,
                      [name] varchar2(50),
                      [Image] image);", connection);

                command.ExecuteNonQuery();
                MessageBox.Show("Connected and created table!");
            }
            catch (SqliteException sqliteException)
            {
                SqliteCommand command = new SqliteCommand(@"DROP TABLE [WIUTGallery];", connection);
                MessageBox.Show("Connected, table already exists, so we have dropped table, please click again, " + sqliteException.Message);

                command.ExecuteNonQuery();
            }
            connection.Close();
            pictureBox1.Image = null;
            nameTextBox.Text = null;
            idTextBox1.Text = null;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                if (idTextBox1.Text.Length == 0 && imgLocation.Length > 0)
                {
                    byte[] images = null;
                    FileStream Stream = new FileStream(imgLocation, FileMode.Open, FileAccess.Read);
                    BinaryReader bnr = new BinaryReader(Stream);
                    images = bnr.ReadBytes((int)Stream.Length);

                    string sqlQuery = "insert into WIUTGallery(name, image) values (" + "'" + nameTextBox.Text + "' ,@images)";
                    cmd = new SqliteCommand(sqlQuery, connection);
                    cmd.Parameters.Add(new SqliteParameter("@images", images));
                    int N = cmd.ExecuteNonQuery();
                    imgLocation = null;
                    MessageBox.Show(N.ToString() + " Photo added successfully!");
                }
                else if (idTextBox1.Text.Length > 0 && nameTextBox.Text.Length > 0)
                {
                    string sqlQuery = "update WIUTGallery set name = " + "'" + nameTextBox.Text + "' where id = " + idTextBox1.Text;
                    cmd = new SqliteCommand(sqlQuery, connection);
                    int N2 = cmd.ExecuteNonQuery();
                    MessageBox.Show(N2.ToString() + " Name of photo changed successfully!");
                }
                connection.Close();
            }
            catch (Exception)
            {
                return;
            }
            getMaxId();
        }

        private void viewingData(int a)
        {
        getPhoto:
            string sqlQuery = "select t.id, t.name, t.image from WIUTGallery t where t.id >= " + a + " and t.id = (select min(id) from WIUTGallery where id >= " + a + ")";
            cmd = new SqliteCommand(sqlQuery, connection);
            SqliteDataReader DataRead2 = cmd.ExecuteReader();
            DataRead2.Read();

            if (DataRead2.HasRows)
            {
                idTextBox1.Text = DataRead2[0].ToString();
                nameTextBox.Text = DataRead2[1].ToString();
                i = DataRead2.GetInt32(0);

                if (DataRead2[2].ToString().Length == 0)
                {
                    pictureBox1.Image = null;
                    MessageBox.Show(" No photos found, please add photos!");
                }
                else
                {
                    byte[] images = ((byte[])DataRead2[2]);

                    if (images == null)
                    {
                        pictureBox1.Image = null;
                    }
                    else
                    {
                        MemoryStream mstream = new MemoryStream(images);
                        pictureBox1.Image = Image.FromStream(mstream);
                    }
                    /*
                    if (this.i > (int)DataRead.FieldCount)
                    {
                        this.i = 1;
                    }*/
                    i = i + 1;
                }

            }
            else
            {
                i = 0;
                goto getPhoto;
                // MessageBox.Show("Photos not found!");
            }
        }

        private void viewBtn_Click(object sender, EventArgs e)
        {
            if (max_id == 0)
            {
                MessageBox.Show(" No photos found, please add photos!");
                return;
            }
            connection.Open();
            try
            {
                if (i > max_id)
                {
                    i = 1;
                }
                viewingData(i);
            }
            catch (SqliteException)
            {
                pictureBox1.Image = null;
                MessageBox.Show(" No photos found, please add photos!");
            }
            connection.Close();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (idTextBox1.Text.Length == 0)
            {
                MessageBox.Show("Photo not selected for deleting, press the view button for selecting photo!");
            }
            else
            {
                connection.Open();
                string sqlQuery = "delete from WIUTGallery where id = " + idTextBox1.Text;
                cmd = new SqliteCommand(sqlQuery, connection);
                int N = cmd.ExecuteNonQuery();
                connection.Close();
                //i = i + 1;
                getMaxId();
                pictureBox1.Image = null;
                nameTextBox.Text = null;
                idTextBox1.Text = null;
                MessageBox.Show(N.ToString() + " Photo deleted successfully!");
                //goto getPhoto;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
