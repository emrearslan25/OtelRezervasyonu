using System;

public class RezervasyonService
{
    private RezervasyonDAL rezervasyonDAL;

    public RezervasyonService()
    {
        rezervasyonDAL = new RezervasyonDAL();
    }

    public void Ekle(Rezervasyon rezervasyon)
    {
        // İş mantığı eklenebilir
        rezervasyonDAL.Ekle(rezervasyon);
    }

    public Rezervasyon Getir(int id)
    {
        // İş mantığı eklenebilir
        return rezervasyonDAL.Getir(id);
    }

    public void Guncelle(Rezervasyon rezervasyon)
    {
        // İş mantığı eklenebilir
        rezervasyonDAL.Guncelle(rezervasyon);
    }

    public void Sil(int id)
    {
        // İş mantığı eklenebilir
        rezervasyonDAL.Sil(id);
    }
} 