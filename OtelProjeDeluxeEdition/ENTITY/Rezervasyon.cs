using System;

public class Rezervasyon
{
    public int RezervID { get; set; }
    public string MusteriTCKimlik { get; set; }
    public string OdaNumara { get; set; }
    public DateTime GirisTarihi { get; set; }
    public DateTime CikisTarihi { get; set; }
    public string Durum { get; set; }
} 