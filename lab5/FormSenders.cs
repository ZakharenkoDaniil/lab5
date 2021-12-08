using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab5
{
    public partial class FormSenders : Form
    {
        public FormSenders()
        {
            InitializeComponent();
        }

        private void FormSenders_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "testdbDataSet.Otproviteliy1". При необходимости она может быть перемещена или удалена.
            this.otproviteliy1TableAdapter.Fill(this.testdbDataSet.Otproviteliy1);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String connectionString = @"Data Source=localhost;Initial Catalog=testdb;User ID=sa;Password=Uqwerty333Q;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlConnection cnn = new SqlConnection(connectionString);
            cnn.Open();
            SqlCommand cmd = cnn.CreateCommand();
            cmd.CommandText = @"SELECT Трек_номер FROM Otproviteliy1 INNER JOIN Korrespondenshin1 ON Otproviteliy1.Код_отправителя = Korrespondenshin1.код_отправителя WHERE Паспортные_данные = " + this.textBox8.Text;
            String res = "";
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                res += reader[0].ToString()+" ";
            }
            reader.Close();
            this.textBox9.Text = res;
            cnn.Close();
        }
    }
}
