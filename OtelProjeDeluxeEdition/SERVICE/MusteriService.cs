using System;

public class MusteriService
{
    private MusteriDAL musteriDAL;

    public MusteriService()
    {
        musteriDAL = new MusteriDAL();
    }

    public void Ekle(Musteri musteri)
    {
        // İş mantığı eklenebilir
        musteriDAL.Ekle(musteri);
    }

    public Musteri Getir(int id)
    {
        // İş mantığı eklenebilir
        return musteriDAL.Getir(id);
    }

    public void Guncelle(Musteri musteri)
    {
        // İş mantığı eklenebilir
        musteriDAL.Guncelle(musteri);
    }

    public void Sil(int id)
    {
        // İş mantığı eklenebilir
        musteriDAL.Sil(id);
    }
} 