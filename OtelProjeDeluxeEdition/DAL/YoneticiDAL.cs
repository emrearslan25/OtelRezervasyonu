using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

public class YoneticiDAL
{
    public List<Yonetici> GetAll()
    {
        List<Yonetici> yoneticiler = new List<Yonetici>();
        using (MySqlConnection connection = DbBaglanti.BaglantiGetir())  // GetConnection -> BaglantiGetir
        {
            string query = "SELECT Yonetici_ID, Yonetici_Adi, Yonetici_Sifre FROM Yonetici_Tablo";
            MySqlCommand command = new MySqlCommand(query, connection);  // SqlCommand -> MySqlCommand
            using (MySqlDataReader reader = command.ExecuteReader())  // SqlDataReader -> MySqlDataReader
            {
                while (reader.Read())
                {
                    Yonetici yonetici = new Yonetici
                    {
                        YoneticiID = Convert.ToInt32(reader[0]),
                        YoneticiAdi = reader[1].ToString(),
                        YoneticiSifre = reader[2].ToString()
                    };
                    yoneticiler.Add(yonetici);
                }
            }
        }
        return yoneticiler;
    }

    public void Ekle(Yonetici yonetici)
    {
        using (MySqlConnection connection = DbBaglanti.BaglantiGetir())
        {
            string query = "INSERT INTO Yonetici_Tablo (Yonetici_Adi, Yonetici_Sifre) VALUES (@Yonetici_Adi, @Yonetici_Sifre)";
            MySqlCommand command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("@Yonetici_Adi", yonetici.YoneticiAdi);
            command.Parameters.AddWithValue("@Yonetici_Sifre", yonetici.YoneticiSifre);

            command.ExecuteNonQuery();
        }
    }

    public Yonetici Getir(int id)
    {
        using (MySqlConnection connection = DbBaglanti.BaglantiGetir())
        {
            string query = "SELECT * FROM Yonetici_Tablo WHERE Yonetici_ID = @Yonetici_ID";
            MySqlCommand command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("@Yonetici_ID", id);

            using (MySqlDataReader reader = command.ExecuteReader())
            {
                if (reader.Read())
                {
                    return new Yonetici
                    {
                        YoneticiID = Convert.ToInt32(reader["Yonetici_ID"]),
                        YoneticiAdi = reader["Yonetici_Adi"].ToString(),
                        YoneticiSifre = reader["Yonetici_Sifre"].ToString()
                    };
                }
            }
        }
        return null;
    }

    public void Guncelle(Yonetici yonetici)
    {
        using (MySqlConnection connection = DbBaglanti.BaglantiGetir())
        {
            string query = "UPDATE Yonetici_Tablo SET Yonetici_Adi = @Yonetici_Adi, Yonetici_Sifre = @Yonetici_Sifre WHERE Yonetici_ID = @Yonetici_ID";
            MySqlCommand command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("@Yonetici_Adi", yonetici.YoneticiAdi);
            command.Parameters.AddWithValue("@Yonetici_Sifre", yonetici.YoneticiSifre);
            command.Parameters.AddWithValue("@Yonetici_ID", yonetici.YoneticiID);

            command.ExecuteNonQuery();
        }
    }

    public void Sil(int id)
    {
        using (MySqlConnection connection = DbBaglanti.BaglantiGetir())
        {
            string query = "DELETE FROM Yonetici_Tablo WHERE Yonetici_ID = @Yonetici_ID";
            MySqlCommand command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("@Yonetici_ID", id);

            command.ExecuteNonQuery();
        }
    }
}