using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

public class FaturaDAL
{
    public void Ekle(Fatura fatura)
    {
        using (MySqlConnection connection = DbBaglanti.BaglantiGetir())
        {
            string query = "INSERT INTO Fatura_Tablo (Musteri_TCKimlik, Musteri_Adsoyad, Giris_Tarihi, Cikis_Tarihi, Gun_Sayisi, Son_Fiyat) VALUES (@Musteri_TCKimlik, @Musteri_Adsoyad, @Giris_Tarihi, @Cikis_Tarihi, @Gun_Sayisi, @Son_Fiyat)";
            MySqlCommand command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("@Musteri_TCKimlik", fatura.MusteriTCKimlik);
            command.Parameters.AddWithValue("@Musteri_Adsoyad", fatura.MusteriAdsoyad);
            command.Parameters.AddWithValue("@Giris_Tarihi", fatura.GirisTarihi);
            command.Parameters.AddWithValue("@Cikis_Tarihi", fatura.CikisTarihi);
            command.Parameters.AddWithValue("@Gun_Sayisi", fatura.GunSayisi);
            command.Parameters.AddWithValue("@Son_Fiyat", fatura.SonFiyat);

            command.ExecuteNonQuery();
        }
    }

    public Fatura Getir(int id)
    {
        using (MySqlConnection connection = DbBaglanti.BaglantiGetir())
        {
            string query = "SELECT * FROM Fatura_Tablo WHERE Fatura_ID = @Fatura_ID";
            MySqlCommand command = new MySqlCommand(query, connection);  // SqlCommand -> MySqlCommand
            command.Parameters.AddWithValue("@Fatura_ID", id);

            using (MySqlDataReader reader = command.ExecuteReader())  // SqlDataReader -> MySqlDataReader
            {
                if (reader.Read())
                {
                    return new Fatura
                    {
                        FaturaID = Convert.ToInt32(reader["Fatura_ID"]),
                        MusteriTCKimlik = reader["Musteri_TCKimlik"].ToString(),
                        MusteriAdsoyad = reader["Musteri_Adsoyad"].ToString(),
                        GirisTarihi = Convert.ToDateTime(reader["Giris_Tarihi"]),
                        CikisTarihi = Convert.ToDateTime(reader["Cikis_Tarihi"]),
                        GunSayisi = Convert.ToInt32(reader["Gun_Sayisi"]),
                        SonFiyat = Convert.ToDecimal(reader["Son_Fiyat"])
                    };
                }
            }
        }
        return null;
    }

    public List<Fatura> TumunuGetir()
    {
        List<Fatura> faturalar = new List<Fatura>();
        using (MySqlConnection connection = DbBaglanti.BaglantiGetir())
        {
            string query = "SELECT * FROM Fatura_Tablo";
            MySqlCommand command = new MySqlCommand(query, connection);

            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    faturalar.Add(new Fatura
                    {
                        FaturaID = Convert.ToInt32(reader["Fatura_ID"]),
                        MusteriTCKimlik = reader["Musteri_TCKimlik"].ToString(),
                        MusteriAdsoyad = reader["Musteri_Adsoyad"].ToString(),
                        GirisTarihi = Convert.ToDateTime(reader["Giris_Tarihi"]),
                        CikisTarihi = Convert.ToDateTime(reader["Cikis_Tarihi"]),
                        GunSayisi = Convert.ToInt32(reader["Gun_Sayisi"]),
                        SonFiyat = Convert.ToDecimal(reader["Son_Fiyat"])
                    });
                }
            }
        }
        return faturalar;
    }

    public void Guncelle(Fatura fatura)
    {
        using (MySqlConnection connection = DbBaglanti.BaglantiGetir())
        {
            string query = "UPDATE Fatura_Tablo SET Musteri_TCKimlik = @Musteri_TCKimlik, Musteri_Adsoyad = @Musteri_Adsoyad, Giris_Tarihi = @Giris_Tarihi, Cikis_Tarihi = @Cikis_Tarihi, Gun_Sayisi = @Gun_Sayisi, Son_Fiyat = @Son_Fiyat WHERE Fatura_ID = @Fatura_ID";
            MySqlCommand command = new MySqlCommand(query, connection);  // SqlCommand -> MySqlCommand
            command.Parameters.AddWithValue("@Musteri_TCKimlik", fatura.MusteriTCKimlik);
            command.Parameters.AddWithValue("@Musteri_Adsoyad", fatura.MusteriAdsoyad);
            command.Parameters.AddWithValue("@Giris_Tarihi", fatura.GirisTarihi);
            command.Parameters.AddWithValue("@Cikis_Tarihi", fatura.CikisTarihi);
            command.Parameters.AddWithValue("@Gun_Sayisi", fatura.GunSayisi);
            command.Parameters.AddWithValue("@Son_Fiyat", fatura.SonFiyat);
            command.Parameters.AddWithValue("@Fatura_ID", fatura.FaturaID);

            command.ExecuteNonQuery();
        }
    }

    public void Sil(int id)
    {
        using (MySqlConnection connection = DbBaglanti.BaglantiGetir())
        {
            string query = "DELETE FROM Fatura_Tablo WHERE Fatura_ID = @Fatura_ID";
            MySqlCommand command = new MySqlCommand(query, connection);  // SqlCommand -> MySqlCommand
            command.Parameters.AddWithValue("@Fatura_ID", id);

            command.ExecuteNonQuery();
        }
    }
}