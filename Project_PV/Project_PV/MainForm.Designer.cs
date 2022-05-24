/*
 * Created by SharpDevelop.
 * User: ASUS
 * Date: 16/5/2022
 * Time: 4:56 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Project_PV
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.TambahBtn = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.NoKamar = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.Alamat = new System.Windows.Forms.TextBox();
			this.TTL = new System.Windows.Forms.TextBox();
			this.NoID = new System.Windows.Forms.TextBox();
			this.Nama = new System.Windows.Forms.TextBox();
			this.IdPesanan = new System.Windows.Forms.TextBox();
			this.UpdateBtn = new System.Windows.Forms.Button();
			this.HapusBtn = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.label12 = new System.Windows.Forms.Label();
			this.search = new System.Windows.Forms.TextBox();
			this.JenisKelamin = new System.Windows.Forms.ComboBox();
			this.TipeKamar = new System.Windows.Forms.ComboBox();
			this.RefreshBtn = new System.Windows.Forms.Button();
			this.label13 = new System.Windows.Forms.Label();
			this.NoTelepon = new System.Windows.Forms.TextBox();
			this.Harga = new System.Windows.Forms.TextBox();
			this.label14 = new System.Windows.Forms.Label();
			this.CheckIn = new System.Windows.Forms.TextBox();
			this.CheckOut = new System.Windows.Forms.TextBox();
			this.label15 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Algerian", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(346, 22);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(217, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "BLABLA Hotel";
			// 
			// TambahBtn
			// 
			this.TambahBtn.BackColor = System.Drawing.Color.CadetBlue;
			this.TambahBtn.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TambahBtn.Location = new System.Drawing.Point(920, 75);
			this.TambahBtn.Name = "TambahBtn";
			this.TambahBtn.Size = new System.Drawing.Size(98, 35);
			this.TambahBtn.TabIndex = 1;
			this.TambahBtn.Text = "Tambah";
			this.TambahBtn.UseVisualStyleBackColor = false;
			this.TambahBtn.Click += new System.EventHandler(this.TambahBtnClick);
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Lucida Fax", 9F);
			this.label2.Location = new System.Drawing.Point(27, 110);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(119, 23);
			this.label2.TabIndex = 2;
			this.label2.Text = "Nama Lengkap";
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Lucida Fax", 8.5F);
			this.label3.Location = new System.Drawing.Point(27, 150);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(170, 23);
			this.label3.TabIndex = 4;
			this.label3.Text = "No Identitas (NIK/Pasport)";
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Lucida Fax", 8.5F);
			this.label4.Location = new System.Drawing.Point(27, 190);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(145, 23);
			this.label4.TabIndex = 5;
			this.label4.Text = "Tempat, Tanggal Lahir";
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Lucida Fax", 9F);
			this.label5.Location = new System.Drawing.Point(448, 152);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 23);
			this.label5.TabIndex = 6;
			this.label5.Text = "No Kamar";
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Lucida Fax", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(27, 73);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(100, 23);
			this.label6.TabIndex = 10;
			this.label6.Text = "ID Pesanan";
			// 
			// label7
			// 
			this.label7.Font = new System.Drawing.Font("Lucida Fax", 9F);
			this.label7.Location = new System.Drawing.Point(448, 225);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(136, 23);
			this.label7.TabIndex = 12;
			this.label7.Text = "Tanggal Check In";
			// 
			// label8
			// 
			this.label8.Font = new System.Drawing.Font("Lucida Fax", 9F);
			this.label8.Location = new System.Drawing.Point(448, 262);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(136, 23);
			this.label8.TabIndex = 13;
			this.label8.Text = "Tanggal Check Out";
			// 
			// label10
			// 
			this.label10.Font = new System.Drawing.Font("Lucida Fax", 9F);
			this.label10.Location = new System.Drawing.Point(448, 111);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(100, 23);
			this.label10.TabIndex = 15;
			this.label10.Text = "Tipe Kamar";
			// 
			// NoKamar
			// 
			this.NoKamar.Location = new System.Drawing.Point(612, 153);
			this.NoKamar.Name = "NoKamar";
			this.NoKamar.Size = new System.Drawing.Size(200, 20);
			this.NoKamar.TabIndex = 16;
			this.NoKamar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NoKamar_KeyPress);
			// 
			// label9
			// 
			this.label9.Font = new System.Drawing.Font("Lucida Fax", 9F);
			this.label9.Location = new System.Drawing.Point(27, 230);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(100, 23);
			this.label9.TabIndex = 21;
			this.label9.Text = "Alamat";
			// 
			// label11
			// 
			this.label11.Font = new System.Drawing.Font("Lucida Fax", 9F);
			this.label11.Location = new System.Drawing.Point(448, 75);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(136, 23);
			this.label11.TabIndex = 22;
			this.label11.Text = "Jenis Kelamin";
			// 
			// Alamat
			// 
			this.Alamat.Location = new System.Drawing.Point(199, 230);
			this.Alamat.Name = "Alamat";
			this.Alamat.Size = new System.Drawing.Size(200, 20);
			this.Alamat.TabIndex = 25;
			// 
			// TTL
			// 
			this.TTL.Location = new System.Drawing.Point(199, 190);
			this.TTL.Name = "TTL";
			this.TTL.Size = new System.Drawing.Size(200, 20);
			this.TTL.TabIndex = 26;
			// 
			// NoID
			// 
			this.NoID.Location = new System.Drawing.Point(199, 149);
			this.NoID.Name = "NoID";
			this.NoID.Size = new System.Drawing.Size(200, 20);
			this.NoID.TabIndex = 27;
			// 
			// Nama
			// 
			this.Nama.Location = new System.Drawing.Point(199, 112);
			this.Nama.Name = "Nama";
			this.Nama.Size = new System.Drawing.Size(200, 20);
			this.Nama.TabIndex = 28;
			// 
			// IdPesanan
			// 
			this.IdPesanan.Location = new System.Drawing.Point(199, 72);
			this.IdPesanan.Name = "IdPesanan";
			this.IdPesanan.Size = new System.Drawing.Size(200, 20);
			this.IdPesanan.TabIndex = 29;
			// 
			// UpdateBtn
			// 
			this.UpdateBtn.BackColor = System.Drawing.Color.CadetBlue;
			this.UpdateBtn.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Bold);
			this.UpdateBtn.Location = new System.Drawing.Point(920, 134);
			this.UpdateBtn.Name = "UpdateBtn";
			this.UpdateBtn.Size = new System.Drawing.Size(98, 35);
			this.UpdateBtn.TabIndex = 30;
			this.UpdateBtn.Text = "Update";
			this.UpdateBtn.UseVisualStyleBackColor = false;
			this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtnClick);
			// 
			// HapusBtn
			// 
			this.HapusBtn.BackColor = System.Drawing.Color.CadetBlue;
			this.HapusBtn.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Bold);
			this.HapusBtn.Location = new System.Drawing.Point(920, 190);
			this.HapusBtn.Name = "HapusBtn";
			this.HapusBtn.Size = new System.Drawing.Size(98, 35);
			this.HapusBtn.TabIndex = 31;
			this.HapusBtn.Text = "Hapus";
			this.HapusBtn.UseVisualStyleBackColor = false;
			this.HapusBtn.Click += new System.EventHandler(this.HapusBtnClick);
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(27, 362);
			this.dataGridView1.Margin = new System.Windows.Forms.Padding(5);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(1056, 271);
			this.dataGridView1.TabIndex = 32;
			this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1CellContentClick);
			this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1CellContentClick);
			// 
			// label12
			// 
			this.label12.Font = new System.Drawing.Font("Lucida Fax", 9F);
			this.label12.Location = new System.Drawing.Point(685, 333);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(88, 23);
			this.label12.TabIndex = 33;
			this.label12.Text = "Pencarian";
			// 
			// search
			// 
			this.search.Location = new System.Drawing.Point(759, 333);
			this.search.Name = "search";
			this.search.Size = new System.Drawing.Size(324, 20);
			this.search.TabIndex = 34;
			this.search.TextChanged += new System.EventHandler(this.searchChanged);
			// 
			// JenisKelamin
			// 
			this.JenisKelamin.FormattingEnabled = true;
			this.JenisKelamin.Items.AddRange(new object[] {
									"Laki-laki",
									"Perempuan"});
			this.JenisKelamin.Location = new System.Drawing.Point(612, 72);
			this.JenisKelamin.Name = "JenisKelamin";
			this.JenisKelamin.Size = new System.Drawing.Size(200, 21);
			this.JenisKelamin.TabIndex = 35;
			this.JenisKelamin.SelectedIndexChanged += new System.EventHandler(this.JenisKelaminSelectedIndexChanged);
			// 
			// TipeKamar
			// 
			this.TipeKamar.FormattingEnabled = true;
			this.TipeKamar.Items.AddRange(new object[] {
									"Single Room",
									"Twin Room",
									"Double Room",
									"Standart Room",
									"Deluxe Room",
									"Suite"});
			this.TipeKamar.Location = new System.Drawing.Point(612, 112);
			this.TipeKamar.Name = "TipeKamar";
			this.TipeKamar.Size = new System.Drawing.Size(200, 21);
			this.TipeKamar.TabIndex = 36;
			this.TipeKamar.SelectedIndexChanged += new System.EventHandler(this.TipeKamarSelectedIndexChanged);
			// 
			// RefreshBtn
			// 
			this.RefreshBtn.BackColor = System.Drawing.Color.CadetBlue;
			this.RefreshBtn.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Bold);
			this.RefreshBtn.Location = new System.Drawing.Point(920, 245);
			this.RefreshBtn.Name = "RefreshBtn";
			this.RefreshBtn.Size = new System.Drawing.Size(98, 35);
			this.RefreshBtn.TabIndex = 37;
			this.RefreshBtn.Text = "Refresh";
			this.RefreshBtn.UseVisualStyleBackColor = false;
			this.RefreshBtn.Click += new System.EventHandler(this.RefreshBtnClick);
			// 
			// label13
			// 
			this.label13.Font = new System.Drawing.Font("Lucida Fax", 9F);
			this.label13.Location = new System.Drawing.Point(27, 267);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(119, 23);
			this.label13.TabIndex = 38;
			this.label13.Text = "No Telepon";
			// 
			// NoTelepon
			// 
			this.NoTelepon.Location = new System.Drawing.Point(199, 265);
			this.NoTelepon.Name = "NoTelepon";
			this.NoTelepon.Size = new System.Drawing.Size(200, 20);
			this.NoTelepon.TabIndex = 39;
			this.NoTelepon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NoTelepon_KeyPress);
			// 
			// Harga
			// 
			this.Harga.Location = new System.Drawing.Point(612, 190);
			this.Harga.Name = "Harga";
			this.Harga.Size = new System.Drawing.Size(200, 20);
			this.Harga.TabIndex = 40;
			this.Harga.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Harga_KeyPress);
			// 
			// label14
			// 
			this.label14.Font = new System.Drawing.Font("Lucida Fax", 9F);
			this.label14.Location = new System.Drawing.Point(448, 192);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(136, 23);
			this.label14.TabIndex = 41;
			this.label14.Text = "Harga";
			// 
			// CheckIn
			// 
			this.CheckIn.Location = new System.Drawing.Point(612, 223);
			this.CheckIn.Name = "CheckIn";
			this.CheckIn.Size = new System.Drawing.Size(200, 20);
			this.CheckIn.TabIndex = 42;
			// 
			// CheckOut
			// 
			this.CheckOut.Location = new System.Drawing.Point(612, 260);
			this.CheckOut.Name = "CheckOut";
			this.CheckOut.Size = new System.Drawing.Size(200, 20);
			this.CheckOut.TabIndex = 43;
			// 
			// label15
			// 
			this.label15.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.label15.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label15.Location = new System.Drawing.Point(27, 334);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(351, 23);
			this.label15.TabIndex = 44;
			this.label15.Text = "Data Tamu Blabla Hotel";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.ClientSize = new System.Drawing.Size(1119, 668);
			this.Controls.Add(this.label15);
			this.Controls.Add(this.CheckOut);
			this.Controls.Add(this.CheckIn);
			this.Controls.Add(this.label14);
			this.Controls.Add(this.Harga);
			this.Controls.Add(this.NoTelepon);
			this.Controls.Add(this.label13);
			this.Controls.Add(this.RefreshBtn);
			this.Controls.Add(this.TipeKamar);
			this.Controls.Add(this.JenisKelamin);
			this.Controls.Add(this.search);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.HapusBtn);
			this.Controls.Add(this.UpdateBtn);
			this.Controls.Add(this.IdPesanan);
			this.Controls.Add(this.Nama);
			this.Controls.Add(this.NoID);
			this.Controls.Add(this.TTL);
			this.Controls.Add(this.Alamat);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.NoKamar);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.TambahBtn);
			this.Controls.Add(this.label1);
			this.Name = "MainForm";
			this.Text = "Data Tamu Blabla Hotel";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.TextBox Harga;
		private System.Windows.Forms.TextBox NoTelepon;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Button RefreshBtn;
		private System.Windows.Forms.ComboBox TipeKamar;
		private System.Windows.Forms.ComboBox JenisKelamin;
		private System.Windows.Forms.TextBox search;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button HapusBtn;
		private System.Windows.Forms.Button UpdateBtn;
		private System.Windows.Forms.TextBox Alamat;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox CheckIn;
		private System.Windows.Forms.TextBox CheckOut;
		private System.Windows.Forms.TextBox NoKamar;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox IdPesanan;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox TTL;
		private System.Windows.Forms.TextBox NoID;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox Nama;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button TambahBtn;
		private System.Windows.Forms.Label label1;
	}
}
