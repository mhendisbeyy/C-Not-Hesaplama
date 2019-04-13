using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace NotGiris
{
    public partial class FrmOgrenciGiris : Form
    {
        public FrmOgrenciGiris()
        {
            InitializeComponent();
        }
        Sqlbaglantisi bgl = new Sqlbaglantisi();
        
        private void Btn_Giris_Click(object sender, EventArgs e)
        {
            
            SqlCommand cmd = new SqlCommand("Select*From Tbl_Ogrenciler Where OgrenciTC=@p1 and OgrenciSifre=@p2", bgl.Baglan());
            cmd.Parameters.AddWithValue("@p1", mskTC.Text);
            cmd.Parameters.AddWithValue("@p2", txtsifre.Text);

            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read()) 
            {
                FrmOgrenciDetay frmog = new FrmOgrenciDetay();
                frmog.TC = mskTC.Text;
                
                frmog.Show();
                this.Hide();
                
            }
        
            else
            {
                MessageBox.Show("Şifre veya TC Hatalı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            bgl.Baglan().Close();
        }

       
    }
}
