using System;
public class Fatura
{
    public int FaturaID { get; set; }
    public string MusteriTCKimlik { get; set; }
    public string MusteriAdsoyad { get; set; }
    public DateTime GirisTarihi { get; set; }
    public DateTime CikisTarihi { get; set; }
    public int GunSayisi { get; set; }
    public decimal SonFiyat { get; set; }
} 