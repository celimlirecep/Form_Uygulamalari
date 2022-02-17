using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje_rehber_class_17_02_2022
{
    class veritabani
    {
        SqlConnection baglanti;
        SqlCommand komut;
        SqlDataAdapter adapter;
        string baglantiadresi = @"Server=RECEP-CELIMLI\SQLEXPRESS;Database=sHastane;User=sa;Pwd=123";
        string sqlkomutlari;
        DataTable dt;
        public SqlConnection baglan()
        {
            baglanti = new SqlConnection(baglantiadresi);
            sqlkomutlari = "SELECT * FROM tblHastalar";
            komut = new SqlCommand(sqlkomutlari, baglanti);
            if (baglanti.State == ConnectionState.Closed)//*****************************
            {
                baglanti.Open();
            }
            return baglanti;
        }

        public void baglantikes()
        {
            if (baglanti.State == ConnectionState.Open)//*****************************
            {
                baglanti.Close();
            }
        }

        public DataTable DataGoster(string sorgucumlesi)
        {
            adapter = new SqlDataAdapter(sorgucumlesi, baglan());
            dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }

        public string yeniKayitEkle(string tc, string ad, string soyad, string cinsiyet, string adres , string telefon, string mail)
        {
           
            sqlkomutlari = $"INSERT INTO tblHastalar VALUES ('{tc}','{ad}','{soyad}','{cinsiyet}','{adres}','{telefon}','{mail}')";
            komut = new SqlCommand(sqlkomutlari, baglan());
            komut.ExecuteNonQuery();
            baglantikes();
            return  " Yeni İsim Başarıyla Kaydedildi...";
        }

        public bool kayitkontrol(params string[] e)//********************************************************************
        {
            bool donus = true;
            foreach (var item in e)
            {
                
                if (item == "")
                {
                    donus= false;
                    break;
                }
            }
            return donus;
        }

        public void duzenle(string ID,string tc, string ad, string soyad, string cinsiyet, string adres, string telefon, string mail)
        {
            sqlkomutlari = $"UPDATE tblHastalar SET tcno='{tc}',ad='{ad}',soyad='{soyad}',cinsiyet='{cinsiyet}', adres='{adres}', telefon='{telefon}', mail='{mail}' WHERE ID='{ID}'";
            komut = new SqlCommand(sqlkomutlari, baglan());
            komut.ExecuteNonQuery();
            baglantikes();
            
        }

        public void dataSil(string ID)
        {
            sqlkomutlari = $"DELETE FROM tblHastalar WHERE ID='{ID}'";
            komut = new SqlCommand(sqlkomutlari, baglan());
            komut.ExecuteNonQuery();
            baglantikes();
        }
     
       













    }
}
