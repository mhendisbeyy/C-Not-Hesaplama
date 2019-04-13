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
    public partial class FrmOgrenciDetay : Form
    {
        public FrmOgrenciDetay()
        {
            InitializeComponent();
        }
        public string TC;
        Sqlbaglantisi bgl = new Sqlbaglantisi();
        private void FrmOgrenciDetay_Load(object sender, EventArgs e)
        {
            LblTC.Text = TC;
            SqlCommand cmd = new SqlCommand("Select OgrenciAd,OgrenciSoyad From Tbl_Ogrenciler Where OgrenciTC=@p1",bgl.Baglan());
            cmd.Parameters.AddWithValue("@p1", TC);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                LblAdSoyad.Text = dr[0] + " " + dr[1];
            }
            bgl.Baglan().Close();



            
            
        }
    }
}
