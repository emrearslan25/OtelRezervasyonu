using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace OtelProjeDeluxeEdition.DAL
{
    public class OdaDAL
    {
        public List<Oda> TumunuGetir()
        {
            List<Oda> odalar = new List<Oda>();
            using (MySqlConnection connection = DbBaglanti.BaglantiGetir())
            {
                string query = "SELECT * FROM Oda_Tablo";
                MySqlCommand command = new MySqlCommand(query, connection);

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        odalar.Add(new Oda
                        {
                            OdaID = Convert.ToInt32(reader["Oda_ID"]),
                            OdaNumara = reader["Oda_Numara"].ToString(),
                            Fiyat = Convert.ToDecimal(reader["Fiyat"]),
                            OdaTip = reader["Oda_Tip"].ToString(),
                            Musaitlik = reader["Musaitlik"].ToString(),
                            Kat = Convert.ToInt32(reader["Kat"])
                        });
                    }
                }
            }
            return odalar;
        }

        public Oda Getir(string odaNumara)
        {
            using (MySqlConnection connection = DbBaglanti.BaglantiGetir())
            {
                string query = "SELECT * FROM Oda_Tablo WHERE Oda_Numara = @Oda_Numara";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@Oda_Numara", odaNumara);

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new Oda
                        {
                            OdaID = Convert.ToInt32(reader["Oda_ID"]),
                            OdaNumara = reader["Oda_Numara"].ToString(),
                            Fiyat = Convert.ToDecimal(reader["Fiyat"]),
                            OdaTip = reader["Oda_Tip"].ToString(),
                            Musaitlik = reader["Musaitlik"].ToString(),
                            Kat = Convert.ToInt32(reader["Kat"])
                        };
                    }
                }
            }
            return null;
        }

        public void Ekle(Oda oda)
        {
            using (MySqlConnection connection = DbBaglanti.BaglantiGetir())
            {
                string query = "INSERT INTO Oda_Tablo (Oda_Numara, Fiyat, Oda_Tip, Musaitlik, Kat) VALUES (@Oda_Numara, @Fiyat, @Oda_Tip, @Musaitlik, @Kat)";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@Oda_Numara", oda.OdaNumara);
                command.Parameters.AddWithValue("@Fiyat", oda.Fiyat);
                command.Parameters.AddWithValue("@Oda_Tip", oda.OdaTip);
                command.Parameters.AddWithValue("@Musaitlik", oda.Musaitlik);
                command.Parameters.AddWithValue("@Kat", oda.Kat);

                command.ExecuteNonQuery();
            }
        }

        public void Guncelle(Oda oda)
        {
            using (MySqlConnection connection = DbBaglanti.BaglantiGetir())
            {
                string query = "UPDATE Oda_Tablo SET Oda_Numara = @Oda_Numara, Fiyat = @Fiyat, Oda_Tip = @Oda_Tip, Musaitlik = @Musaitlik, Kat = @Kat WHERE Oda_ID = @Oda_ID";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@Oda_ID", oda.OdaID);
                command.Parameters.AddWithValue("@Oda_Numara", oda.OdaNumara);
                command.Parameters.AddWithValue("@Fiyat", oda.Fiyat);
                command.Parameters.AddWithValue("@Oda_Tip", oda.OdaTip);
                command.Parameters.AddWithValue("@Musaitlik", oda.Musaitlik);
                command.Parameters.AddWithValue("@Kat", oda.Kat);

                command.ExecuteNonQuery();
            }
        }

        public void Sil(int odaID)
        {
            using (MySqlConnection connection = DbBaglanti.BaglantiGetir())
            {
                string query = "DELETE FROM Oda_Tablo WHERE Oda_ID = @Oda_ID";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@Oda_ID", odaID);

                command.ExecuteNonQuery();
            }
        }
    }
}