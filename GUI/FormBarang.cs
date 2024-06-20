using aplikasi_reservasi.Kelas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aplikasi_penjualan.GUI
{
    public partial class FormBarang : Form
    {
        bool _stateItem = false;


        public FormBarang()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvPelanggan.Rows[e.RowIndex].Cells[0].Value != null)
            {
                textBoxKode.Text = dgvPelanggan.Rows[e.RowIndex].Cells[0].Value.ToString();
                textBoxNama.Text = dgvPelanggan.Rows[e.RowIndex].Cells[1].Value.ToString();
                textBoxNomor.Text = dgvPelanggan.Rows[e.RowIndex].Cells[2].Value.ToString();
                textBoxEmail.Text = dgvPelanggan.Rows[e.RowIndex].Cells[3].Value.ToString();
                dateTime.Text = dgvPelanggan.Rows[e.RowIndex].Cells[4].Value.ToString();


            }
            buttonUpdate.Enabled = true;
            buttonDelete.Enabled = true;


        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void buttonNew_Click(object sender, EventArgs e)
        {

            textBoxKode.Enabled = true;
            textBoxNama.Enabled = true;
            textBoxEmail.Enabled = true;
            textBoxNomor.Enabled = true;
            dateTime.Enabled = true;

            textBoxKode.Text = string.Empty;
            textBoxNama.Text = string.Empty;
            textBoxEmail.Text = string.Empty;
            textBoxNomor.Text = string.Empty;
            dateTime.Text = string.Empty;

            buttonSave.Enabled = true;
            buttonUpdate.Enabled = false;
            buttonDelete.Enabled = false;
            _stateItem = true;


        }

        private void FormPelanggan_Load(object sender, EventArgs e)
        {
            LoadReservasi();
        }

        public void LoadReservasi()
        {
            DataTable dt = new DataTable();
            dt = Reservasi.SelectAll();
            dgvPelanggan.AutoGenerateColumns = false;
            dgvPelanggan.DataSource = dt;
            dgvPelanggan.Show();
        }

        public void ResetEnable()
        {
            textBoxKode.Enabled = false;
            textBoxNama.Enabled = false;
            textBoxEmail.Enabled = false;
            textBoxNomor.Enabled = false;
            dateTime.Enabled = false;

            textBoxKode.Text = string.Empty;
            textBoxNama.Text = string.Empty;
            textBoxEmail.Text = string.Empty;
            textBoxNomor.Text = string.Empty;
            dateTime.Text = string.Empty;

            buttonSave.Enabled = false;
            buttonUpdate.Enabled = false;
            buttonDelete.Enabled = false;
            _stateItem = false;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            Reservasi reservasi = new Reservasi(Convert.ToInt16(textBoxKode.Text), textBoxNama.Text, textBoxEmail.Text , Convert.ToInt16(textBoxNomor.Text), Convert.ToDateTime(dateTime.Text));
            if (_stateItem)
            {
                if (reservasi.insert() == 1)
                {
                    MessageBox.Show("Insert pelanggan sukses");
                }
                else
                {
                    MessageBox.Show("Insert pelanggan gagal");
                }
            }
            else
            {
                if (reservasi.update() == 1)
                {
                    MessageBox.Show("Update pelanggan sukses");
                }
                else
                {
                    MessageBox.Show("Update pelanggan gagal");
                }
            }

            LoadReservasi();
            ResetEnable();

        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            textBoxKode.Enabled = true;
            textBoxNama.Enabled = true;
            textBoxEmail.Enabled = true;
            textBoxNomor.Enabled = true;
            dateTime.Enabled = true;

            buttonSave.Enabled = true;
            buttonNew.Enabled = false;
            buttonDelete.Enabled = false;

            _stateItem = false;

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            Reservasi reservasi = new Reservasi(Convert.ToInt16(textBoxKode.Text), textBoxNama.Text, textBoxEmail.Text, Convert.ToInt16(textBoxNomor.Text), Convert.ToDateTime(dateTime.Text));
            if (reservasi.delete()==1)
            {
                MessageBox.Show("delete pelanggan sukses");
            }
            else
            {
                MessageBox.Show("delete pelanggan gagal");
            }
            LoadReservasi();
            ResetEnable();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
