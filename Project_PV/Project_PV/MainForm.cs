using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;
using System.Data.OleDb;

namespace Project_PV
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		MySqlConnection co = new MySqlConnection("Server=localhost; Database=projectpv; Uid=root");
		MySqlCommand mycommand = new MySqlCommand();
		MySqlDataAdapter myadapter = new MySqlDataAdapter();
		
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			readData();
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		
		public void readData(){
			try{
				mycommand.Connection = co;
				myadapter.SelectCommand = mycommand;
				mycommand.CommandText = "select * from hotelpv";
				DataSet ds = new DataSet();
				
				if (myadapter.Fill(ds,"dftpesan")>0){
				dataGridView1.DataSource = ds;
				dataGridView1.DataMember = "dftpesan";
				}
			}
			catch (Exception ex){
				 MessageBox.Show(ex.ToString());
			}
		}
		
		
		public void insertData(){
			try{
				co.Open();
				mycommand.Connection=co;
				mycommand.CommandText="insert into hotelpv values('"+IdPesanan.Text+"','"+Nama.Text+"','"+NoID.Text+"','"+TTL.Text+"','"+Alamat.Text+"','"+NoTelepon.Text+"','"+JenisKelamin.Text+"','"+TipeKamar.Text+"','"+NoKamar.Text+"','"+Harga.Text+"','"+CheckIn.Text+"','"+CheckOut.Text+"')";
				myadapter.SelectCommand= mycommand;
				if (mycommand.ExecuteNonQuery()==1){
					MessageBox.Show("Data berhasil dimasukkan", "Informasi", MessageBoxButtons.OK,MessageBoxIcon.Information);
					readData();
				}
				co.Close();
			}
			catch (Exception ex){
				MessageBox.Show(ex.ToString());
 			}
		}
		
		
		public void updateData(){
			try{
				co.Open();
				mycommand.CommandText = "update hotelpv set IdPesanan='"+IdPesanan.Text+"',Nama='"+Nama.Text+"',NoIdentitas='"+NoID.Text+"',TTL='"+TTL.Text+"',Alamat='"+Alamat.Text+"',NoTelepon='"+NoTelepon.Text+"',JenisKelamin='"+JenisKelamin.Text+"',TipeKamar='"+TipeKamar.Text+"',NoKamar='"+NoKamar.Text+"',Harga='"+Harga.Text+"',CheckIn='"+CheckIn.Text+"',CheckOut='"+CheckOut.Text+"' where IdPesanan ='"+IdPesanan.Text+"'";
				myadapter.SelectCommand = mycommand;
				if (mycommand.ExecuteNonQuery()==1){
					MessageBox.Show("Data berhasil diupdate","Informasi",MessageBoxButtons.OK,MessageBoxIcon.Information);
					readData();
				}
				co.Close();
			}
			catch (Exception ex){
				MessageBox.Show(ex.ToString());
 			}
		}
		
		public void deleteData(){
			try{
				co.Open();
				mycommand.CommandText="delete from hotelpv where IdPesanan='"+IdPesanan.Text+"'";
				myadapter.SelectCommand = mycommand;
				if (mycommand.ExecuteNonQuery()==1){
					MessageBox.Show("Data berhasil dihapus","Informasi",MessageBoxButtons.OK,MessageBoxIcon.Information);
					readData();
				}
				co.Close();
			}
			catch(Exception ex){
				MessageBox.Show(ex.ToString());
			}
		}
		
		
		public void kosongkan(){
			IdPesanan.Text =  "";
			Nama.Text =  "";
			NoID.Text =  "";
			TTL.Text =  "";
			Alamat.Text =  "";
			NoTelepon.Text =  "";
			JenisKelamin.Text =  "";
			TipeKamar.Text =  "";
			NoKamar.Text =  "";
			Harga.Text =  "";
			CheckIn.Text =  "";
			CheckOut.Text =  "";
			readData();
		}
		
		public void CariData(){
			try{
				mycommand.Connection = co;
				myadapter.SelectCommand = mycommand;
				mycommand.CommandText = "select * from hotelpv where IdPesanan like '%"+search.Text+"%' or Nama like '%"+search.Text+"%' ";
				DataSet ds = new DataSet();

				if (myadapter.Fill(ds,"dftpesan") > 0){
					dataGridView1.DataSource = ds;
					dataGridView1.DataMember = "dftpesan";
				}
				co.Close();
			}
			catch (Exception ex){
				MessageBox.Show(ex.ToString());
			}
		}
		
		
		void DataGridView1CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			IdPesanan.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
			Nama.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
			NoID.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
			TTL.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
			Alamat.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
			NoTelepon.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
			JenisKelamin.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
			TipeKamar.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
			NoKamar.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
			Harga.Text = dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();
			CheckIn.Text = dataGridView1.Rows[e.RowIndex].Cells[10].Value.ToString();
			CheckOut.Text = dataGridView1.Rows[e.RowIndex].Cells[11].Value.ToString();
		}
		
		void TambahBtnClick(object sender, EventArgs e)
		{
			insertData();
			kosongkan();
		}
		
		
		void UpdateBtnClick(object sender, EventArgs e)
		{
			updateData();
			kosongkan();
		}
		
		void HapusBtnClick(object sender, EventArgs e)
		{
			deleteData();
			kosongkan();
		}
		
		
		void JenisKelaminSelectedIndexChanged(object sender, EventArgs e)
		{
			JenisKelamin.Items.Add("Laki-laki");
			JenisKelamin.Items.Add("Perempuan");			
		}
		
		void TipeKamarSelectedIndexChanged(object sender, EventArgs e)
		{
			TipeKamar.Items.Add("Single Room");
			TipeKamar.Items.Add("Twin Room");
			TipeKamar.Items.Add("Double Room");
			TipeKamar.Items.Add("Standart Room");
			TipeKamar.Items.Add("Deluxe Room");
			TipeKamar.Items.Add("Suite");
		}
		
		void searchChanged(object sender, EventArgs e)
		{
			CariData();
		}
		
		void RefreshBtnClick(object sender, EventArgs e)
		{
			kosongkan();
		}
		
		void Harga_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled= !char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back;			
		}
		
		void NoKamar_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled= !char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back;			
		}
		
		void NoTelepon_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled= !char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back;
		}
		
		
	}
}
