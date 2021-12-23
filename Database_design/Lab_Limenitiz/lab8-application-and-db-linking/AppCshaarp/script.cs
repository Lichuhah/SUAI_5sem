

MySqlConnectionStringBuilder mysqlCSB;
mysqlCSB = new MySqlConnectionStringBuilder();
mysqlCSB.Server = "127.0.0.1";
mysqlCSB.Database = "database_design_course";
mysqlCSB.UserID = "root_user";
mysqlCSB.Password = "root_user";

string queryString = 
@"SELECT * FROM authors 
WHERE comment_date >= CURDATE()";


DataTable dt = new DataTable();


using(MySqlConnection con = new MySqlConnection())
{
    con.ConnectionString = mysqlCSB.ConnectionString;
    con.Open();
    using(MySqlDataReader dr = com.ExecuteReader())
    {
        //есть записи?
        if (dr.HasRows)
        {
            //заполняем объект DataTable
            dt.Load(dr);
        }
    }
}

private void button1_Click(object sender, EventArgs e)
{
    dataGridView1.DataSource = GetComments();
}

