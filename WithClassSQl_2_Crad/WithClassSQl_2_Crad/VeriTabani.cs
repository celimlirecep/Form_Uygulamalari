using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WithClassSQl_2_Crad
{
    class VeriTabani
    {
        // 1 veri tabanı bağlantisi yapacak metod
        SqlConnection baglanti;
        SqlCommand komut;
        SqlDataAdapter adaptor;//açıp kapatmada sorun yok yazılmasına gerek yok servere
        string sorguCumlesi;
        DataTable dt;
        public SqlConnection baglan()
        {
            string baglantiAdresi = @"Server=RECEP-CELIMLI\SQLEXPRESS;Database=sHastane;User=sa;Pwd=123";
            baglanti = new SqlConnection(baglantiAdresi);
            if (baglanti.State==ConnectionState.Closed)
            {
                baglanti.Open();//kapalıysa aç
            }
          
            return baglanti;
        }

        public void kapat()
        {
            if (baglanti.State!=ConnectionState.Closed)
            {
                baglanti.Close();//açıksa kapat
            }
        }

        public DataTable hastalariListele()
        {
            sorguCumlesi = $"SELECT * FROM tblhastalar";
            adaptor = new SqlDataAdapter(sorguCumlesi, baglan());
            dt = new DataTable();
            adaptor.Fill(dt);
            return dt;

        }

        public string Ekle(string tcno, string ad, string soyad, string cinsiyet, string adres, string telefon, string mail)
        {
            string durum;
            if (kontrol(tcno,ad,soyad,cinsiyet))
            {
                sorguCumlesi = $"INSERT INTO tblHastalar  VALUES ('{tcno}', '{ad}', '{soyad}', '{cinsiyet}','{adres}','{telefon}','{mail}')";
                komut = new SqlCommand(sorguCumlesi, baglan());
                komut.ExecuteNonQuery();
                kapat();
                return durum = "kaydedildi";
            }
            else
            {
               return  durum = "kaydedilemedi";
                System.Windows.Forms.MessageBox.Show("eksik girdiniz");
            }

        }
        public bool kontrol(string tcno, string ad, string soyad, string cinsiyet)
        {
            if ( tcno==""||  ad==""||  soyad==""||  cinsiyet=="")
            {
                return false;
            }
            return true;

            
        }
        public void duzenle(string ID,string tcno, string ad, string soyad, string cinsiyet, string adres, string telefon, string mail)
        {
            
            sorguCumlesi = $"UPDATE  tblHastalar  SET tcNo='{tcno}',ad= '{ad}',soyad= '{soyad}',cinsiyet= '{cinsiyet}',adres='{adres}',telefon='{telefon}',mail='{mail}' WHERE ID='{ID}' ";
            komut = new SqlCommand(sorguCumlesi, baglan());
            komut.ExecuteNonQuery();
            kapat();
            
        }
    }
}
