using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

public class RezervasyonDAL
{
    public void Ekle(Rezervasyon rezervasyon)
    {
        using (MySqlConnection connection = DbBaglanti.BaglantiGetir())  // GetConnection -> BaglantiGetir
        {
            string query = "INSERT INTO Rezervasyon_Tablo (Musteri_TCKimlik, Oda_Numara, Giris_Tarihi, Cikis_Tarihi, Durum) VALUES (@Musteri_TCKimlik, @Oda_Numara, @Giris_Tarihi, @Cikis_Tarihi, @Durum)";
            MySqlCommand command = new MySqlCommand(query, connection);  // SqlCommand -> MySqlCommand
            command.Parameters.AddWithValue("@Musteri_TCKimlik", rezervasyon.MusteriTCKimlik);
            command.Parameters.AddWithValue("@Oda_Numara", rezervasyon.OdaNumara);
            command.Parameters.AddWithValue("@Giris_Tarihi", rezervasyon.GirisTarihi);
            command.Parameters.AddWithValue("@Cikis_Tarihi", rezervasyon.CikisTarihi);
            command.Parameters.AddWithValue("@Durum", rezervasyon.Durum);

            command.ExecuteNonQuery();
        }
    }

    public Rezervasyon Getir(int id)
    {
        using (MySqlConnection connection = DbBaglanti.BaglantiGetir())
        {
            string query = "SELECT * FROM Rezervasyon_Tablo WHERE Rezerv_ID = @Rezerv_ID";
            MySqlCommand command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("@Rezerv_ID", id);

            using (MySqlDataReader reader = command.ExecuteReader())  // SqlDataReader -> MySqlDataReader
            {
                if (reader.Read())
                {
                    return new Rezervasyon
                    {
                        RezervID = Convert.ToInt32(reader["Rezerv_ID"]),
                        MusteriTCKimlik = reader["Musteri_TCKimlik"].ToString(),
                        OdaNumara = reader["Oda_Numara"].ToString(),
                        GirisTarihi = Convert.ToDateTime(reader["Giris_Tarihi"]),
                        CikisTarihi = Convert.ToDateTime(reader["Cikis_Tarihi"]),
                        Durum = reader["Durum"].ToString()
                    };
                }
            }
        }
        return null;
    }

    public List<Rezervasyon> TumunuGetir()
    {
        List<Rezervasyon> rezervasyonlar = new List<Rezervasyon>();

        using (MySqlConnection connection = DbBaglanti.BaglantiGetir())
        {
            string query = "SELECT * FROM Rezervasyon_Tablo ORDER BY Rezerv_ID";
            MySqlCommand command = new MySqlCommand(query, connection);

            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    rezervasyonlar.Add(new Rezervasyon
                    {
                        RezervID = Convert.ToInt32(reader["Rezerv_ID"]),
                        MusteriTCKimlik = reader["Musteri_TCKimlik"].ToString(),
                        OdaNumara = reader["Oda_Numara"].ToString(),
                        GirisTarihi = Convert.ToDateTime(reader["Giris_Tarihi"]),
                        CikisTarihi = Convert.ToDateTime(reader["Cikis_Tarihi"]),
                        Durum = reader["Durum"].ToString()
                    });
                }
            }
        }

        return rezervasyonlar;
    }

    public void Guncelle(Rezervasyon rezervasyon)
    {
        using (MySqlConnection connection = DbBaglanti.BaglantiGetir())
        {
            string query = "UPDATE Rezervasyon_Tablo SET Musteri_TCKimlik = @Musteri_TCKimlik, Oda_Numara = @Oda_Numara, Giris_Tarihi = @Giris_Tarihi, Cikis_Tarihi = @Cikis_Tarihi, Durum = @Durum WHERE Rezerv_ID = @Rezerv_ID";
            MySqlCommand command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("@Musteri_TCKimlik", rezervasyon.MusteriTCKimlik);
            command.Parameters.AddWithValue("@Oda_Numara", rezervasyon.OdaNumara);
            command.Parameters.AddWithValue("@Giris_Tarihi", rezervasyon.GirisTarihi);
            command.Parameters.AddWithValue("@Cikis_Tarihi", rezervasyon.CikisTarihi);
            command.Parameters.AddWithValue("@Durum", rezervasyon.Durum);
            command.Parameters.AddWithValue("@Rezerv_ID", rezervasyon.RezervID);

            command.ExecuteNonQuery();
        }
    }

    public void Sil(int id)
    {
        using (MySqlConnection connection = DbBaglanti.BaglantiGetir())
        {
            string query = "DELETE FROM Rezervasyon_Tablo WHERE Rezerv_ID = @Rezerv_ID";
            MySqlCommand command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("@Rezerv_ID", id);

            command.ExecuteNonQuery();
        }
    }
}