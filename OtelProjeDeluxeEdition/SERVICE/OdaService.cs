using System;
using System.Collections.Generic;
using OtelProjeDeluxeEdition.DAL;

namespace OtelProjeDeluxeEdition.Business
{
    public class OdaService
    {
        private readonly OdaDAL _odaDAL;

        public OdaService()
        {
            _odaDAL = new OdaDAL();
        }

        public void Ekle(Oda oda)
        {
            // İş mantığı eklenebilir
            _odaDAL.Ekle(oda);
        }

        public Oda Getir(string odaNumara)  // int yerine string parametre
        {
            // İş mantığı eklenebilir
            return _odaDAL.Getir(odaNumara);
        }

        public void Guncelle(Oda oda)
        {
            // İş mantığı eklenebilir
            _odaDAL.Guncelle(oda);
        }

        public void Sil(int id)
        {
            // İş mantığı eklenebilir
            _odaDAL.Sil(id);
        }

        public List<Oda> TumunuGetir()
        {
            // İş mantığı eklenebilir
            return _odaDAL.TumunuGetir();
        }
    }
}