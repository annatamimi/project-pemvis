using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aplikasi_reservasi.Kelas
{
    internal class Reservasi
    {
        int kode_pemesanan;
        string nama_pelanggan;
        string email;
        int nomor_meja;
        DateTime tanggal;
       
        protected const String consString = "server=localhost;database=db_reservasi_app;uid=root;pwd=;";

       


        public Reservasi(int kode_pemesanan, string nama_pelanggan, string email, int nomor_meja, DateTime tanggal)
        {
            this.kode_pemesanan = kode_pemesanan;
            this.nama_pelanggan = nama_pelanggan;
            this.email = email;
            this.nomor_meja = nomor_meja;
            this.tanggal = tanggal;
        }

        

        public static DataTable SelectAll()
        {
            DataTable dt = new DataTable();
            MySqlConnection connect = new MySqlConnection(consString);
            using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM data_pelanggan", connect))
            {

                try
                {
                    connect.Open();
                    MySqlDataReader rdr = cmd.ExecuteReader();
                    dt.Load(rdr);
                }
                catch (Exception e)
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
            MySqlCommand cmd = new MySqlCommand("INSERT INTO data_pelanggan (kode_pemesanan,nama_pelanggan,email,nomor_meja,tanggal) VALUES(@kode_pemesanan,@nama_pelanggan,@email,@nomor_meja,@tanggal)");
            cmd.Parameters.AddWithValue("@kode_pemesanan", kode_pemesanan);
            cmd.Parameters.AddWithValue("@nama_pelanggan", nama_pelanggan);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@nomor_meja", nomor_meja);
            cmd.Parameters.AddWithValue("@tanggal", tanggal);
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
            MySqlCommand cmd = new MySqlCommand("DELETE FROM data_pelanggan WHERE kode_pemesanan = @kode_pemesanan");
            cmd.Parameters.AddWithValue("@kode_pemesanan", kode_pemesanan);
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
            MySqlCommand cmd = new MySqlCommand("UPDATE data_pelanggan SET nama_pelanggan = @nama_pelanggan, email = @email, nomor_meja = @nomor_meja, tanggal = @tanggal WHERE kode_pemesanan = @kode_pemesanan");
            cmd.Parameters.AddWithValue("@kode_pemesanan", kode_pemesanan);
            cmd.Parameters.AddWithValue("@nama_pelanggan", nama_pelanggan);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@nomor_meja", nomor_meja);
            cmd.Parameters.AddWithValue("@tanggal", tanggal);
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

