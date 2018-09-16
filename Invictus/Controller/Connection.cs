using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Invictus.Controller
{
    class Connection
    {
        private string user = "vitor";
        private string pswd = "root";
        private string bd = "invictus";

        public void con()
        {
            string connetionString = null;
            SqlConnection cnn;
            connetionString = @"Data Source=.\SQLEXPRESS;Initial Catalog="+bd+";User ID="+user+";Password="+pswd;
            cnn = new SqlConnection(connetionString);
            try
            {
                MessageBox.Show("Connection Open ! ");
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection ! ");
            }
        }

    }
}
