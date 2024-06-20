using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace aplikasi_penjualan.Kelas
{
    internal class Items
    {
        string code;
        string name;
        int prize;
        int stock;
        string unit;

        protected const String consString = "server=localhost;database=db_penjualan_app;uid=root;pwd=;";


        public Items(string code, string name, int prize, int stock, string unit) {
            this.code = code;
            this.name = name;
            this.prize = prize;
            this.stock = stock;
            this.unit = unit;
        }

        

        public static DataTable SelectAll()
        {
            DataTable dt = new DataTable();
            MySqlConnection connect = new MySqlConnection(consString);
            using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM items", connect))
            {

                try
                {
                    connect.Open();
                    MySqlDataReader rdr = cmd.ExecuteReader();
                    dt.Load(rdr);
                } catch (Exception e)
                {
                    string error = e.Message;

                }
                finally
                {
                    if (connect.State == ConnectionState.Open)
                    {
                        connect.Close();
                    }
                }
            }
            return dt;

        }
        public int insert()
        {
            int result = 0;
            MySqlConnection connect = new MySqlConnection(consString);
            MySqlCommand cmd = new MySqlCommand("INSERT INTO items (code,name_item,prize,stock,unit) VALUES(@code,@name,@prize,@stock,@unit)");
            cmd.Parameters.AddWithValue("@code", code);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@prize", prize);
            cmd.Parameters.AddWithValue("@stock", stock);
            cmd.Parameters.AddWithValue("@unit", unit);
            cmd.CommandType = CommandType.Text;
            cmd.Connection = connect;
            try
            {
                connect.Open();
                result = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (connect.State == ConnectionState.Open)
                {
                    connect.Close();
                }
            }
            return result;
        }
        public int delete()
        {
            int result = 0;
            MySqlConnection connect = new MySqlConnection(consString);
            MySqlCommand cmd = new MySqlCommand("DELETE FROM items WHERE code = @code");
            cmd.Parameters.AddWithValue("@code", code);
            cmd.CommandType = CommandType.Text;
            cmd.Connection = connect;
            try
            {
                connect.Open();
                result = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (connect.State == ConnectionState.Open)
                {
                    connect.Close();
                }
            }
            return result;
        }

        public int update()
        {
            int result = 0;
            MySqlConnection connect = new MySqlConnection(consString);
            MySqlCommand cmd = new MySqlCommand("UPDATE items SET name_item = @name, prize = @prize, stock = @stock, unit = @unit WHERE code = @code");
            cmd.Parameters.AddWithValue("@code", code);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@prize", prize);
            cmd.Parameters.AddWithValue("@stock", stock);
            cmd.Parameters.AddWithValue("@unit", unit);
            cmd.CommandType = CommandType.Text;
            cmd.Connection = connect;
            try
            {
                connect.Open();
                result = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (connect.State == ConnectionState.Open)
                {
                    connect.Close();
                }
            }
            return result;
        }

    }



}
