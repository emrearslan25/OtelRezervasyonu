using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

public class MusteriDAL
{
    public void Ekle(Musteri musteri)
    {
        using (MySqlConnection connection = DbBaglanti.BaglantiGetir())  // dbBaglanti. yerine DbBaglanti.
        {
            string query = "INSERT INTO Musteri_Tablo (Musteri_Adsoyad, Musteri_Telefon, Musteri_Cinsiyet, Musteri_TCKimlik) VALUES (@Musteri_Adsoyad, @Musteri_Telefon, @Musteri_Cinsiyet, @Musteri_TCKimlik)";
            MySqlCommand command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("@Musteri_Adsoyad", musteri.MusteriAdsoyad);
            command.Parameters.AddWithValue("@Musteri_Telefon", musteri.MusteriTelefon);
            command.Parameters.AddWithValue("@Musteri_Cinsiyet", musteri.MusteriCinsiyet);
            command.Parameters.AddWithValue("@Musteri_TCKimlik", musteri.MusteriTCKimlik);

            command.ExecuteNonQuery();
        }
    }

    public Musteri TCyeGoreGetir(string TC)
    {
        using (MySqlConnection connection = DbBaglanti.BaglantiGetir())
        {
            string query = "SELECT * FROM Musteri_Tablo WHERE Musteri_TCKimlik = @TC";
            MySqlCommand command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("@TC", TC);

            using (MySqlDataReader reader = command.ExecuteReader())
            {
                if (reader.Read())
                {
                    return new Musteri
                    {
                        MusteriID = Convert.ToInt32(reader["Musteri_ID"]),
                        MusteriAdsoyad = reader["Musteri_Adsoyad"].ToString(),
                        MusteriTCKimlik = reader["Musteri_TCKimlik"].ToString(),
                        MusteriTelefon = reader["Musteri_Telefon"].ToString(),
                        MusteriCinsiyet = reader["Musteri_Cinsiyet"].ToString()
                    };
                }
            }
        }
        return null;
    }

    public Musteri Getir(int id)
    {
        using (MySqlConnection connection = DbBaglanti.BaglantiGetir())  // dbBaglanti. yerine DbBaglanti.
        {
            string query = "SELECT * FROM Musteri_Tablo WHERE Musteri_ID = @Musteri_ID";
            MySqlCommand command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("@Musteri_ID", id);

            using (MySqlDataReader reader = command.ExecuteReader())
            {
                if (reader.Read())
                {
                    return new Musteri
                    {
                        MusteriID = Convert.ToInt32(reader["Musteri_ID"]),
                        MusteriAdsoyad = reader["Musteri_Adsoyad"].ToString(),
                        MusteriTelefon = reader["Musteri_Telefon"].ToString(),
                        MusteriCinsiyet = reader["Musteri_Cinsiyet"].ToString(),
                        MusteriTCKimlik = reader["Musteri_TCKimlik"].ToString()
                    };
                }
            }
        }
        return null;
    }

    public void Guncelle(Musteri musteri)
    {
        using (MySqlConnection connection = DbBaglanti.BaglantiGetir())  // dbBaglanti. yerine DbBaglanti.
        {
            string query = "UPDATE Musteri_Tablo SET Musteri_Adsoyad = @Musteri_Adsoyad, Musteri_Telefon = @Musteri_Telefon, Musteri_Cinsiyet = @Musteri_Cinsiyet, Musteri_TCKimlik = @Musteri_TCKimlik WHERE Musteri_ID = @Musteri_ID";
            MySqlCommand command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("@Musteri_Adsoyad", musteri.MusteriAdsoyad);
            command.Parameters.AddWithValue("@Musteri_Telefon", musteri.MusteriTelefon);
            command.Parameters.AddWithValue("@Musteri_Cinsiyet", musteri.MusteriCinsiyet);
            command.Parameters.AddWithValue("@Musteri_TCKimlik", musteri.MusteriTCKimlik);
            command.Parameters.AddWithValue("@Musteri_ID", musteri.MusteriID);

            command.ExecuteNonQuery();
        }
    }

    public void Sil(int id)
    {
        using (MySqlConnection connection = DbBaglanti.BaglantiGetir())  // dbBaglanti. yerine DbBaglanti.
        {
            string query = "DELETE FROM Musteri_Tablo WHERE Musteri_ID = @Musteri_ID";
            MySqlCommand command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("@Musteri_ID", id);

            command.ExecuteNonQuery();
        }
    }

    public List<Musteri> TumunuGetir()
    {
        List<Musteri> musteriler = new List<Musteri>();

        using (MySqlConnection connection = DbBaglanti.BaglantiGetir())  // dbBaglanti. yerine DbBaglanti.
        {
            string query = "SELECT * FROM Musteri_Tablo ORDER BY Musteri_ID";
            MySqlCommand command = new MySqlCommand(query, connection);

            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    musteriler.Add(new Musteri
                    {
                        MusteriID = Convert.ToInt32(reader["Musteri_ID"]),
                        MusteriAdsoyad = reader["Musteri_Adsoyad"].ToString(),
                        MusteriTelefon = reader["Musteri_Telefon"].ToString(),
                        MusteriCinsiyet = reader["Musteri_Cinsiyet"].ToString(),
                        MusteriTCKimlik = reader["Musteri_TCKimlik"].ToString()
                    });
                }
            }
        }

        return musteriler;
    }
}