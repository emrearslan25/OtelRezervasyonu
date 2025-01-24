using System;

public class FaturaService
{
    private FaturaDAL faturaDAL;

    public FaturaService()
    {
        faturaDAL = new FaturaDAL();
    }

    public void Ekle(Fatura fatura)
    {
        // İş mantığı eklenebilir
        faturaDAL.Ekle(fatura);
    }

    public Fatura Getir(int id)
    {
        // İş mantığı eklenebilir
        return faturaDAL.Getir(id);
    }

    public void Guncelle(Fatura fatura)
    {
        // İş mantığı eklenebilir
        faturaDAL.Guncelle(fatura);
    }

    public void Sil(int id)
    {
        // İş mantığı eklenebilir
        faturaDAL.Sil(id);
    }
} 