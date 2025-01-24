using MySql.Data.MySqlClient;

public class DbBaglanti
{
    public static MySqlConnection BaglantiGetir()
    {
        MySqlConnection baglanti = new MySqlConnection("Server=172.21.54.253;Database=25_132330111;User=25_132330111;Password=!nif.ogr11AR;");
        baglanti.Open();
        return baglanti;
    }
}