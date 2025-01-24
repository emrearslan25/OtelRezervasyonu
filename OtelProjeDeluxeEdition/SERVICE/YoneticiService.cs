using System.Collections.Generic;

public class YoneticiService
{
    private YoneticiDAL yoneticiDAL;

    public YoneticiService()
    {
        yoneticiDAL = new YoneticiDAL();
    }

    public List<Yonetici> GetAll()
    {
        return yoneticiDAL.GetAll();
    }

    public void Ekle(Yonetici yonetici)
    {
        yoneticiDAL.Ekle(yonetici);
    }

    public void Guncelle(Yonetici yonetici)
    {
        yoneticiDAL.Guncelle(yonetici);
    }

    public void Sil(int yoneticiId)
    {
        yoneticiDAL.Sil(yoneticiId);
    }
}