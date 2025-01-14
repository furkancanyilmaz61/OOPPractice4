using System;

class Kitap
{
    public string Ad { get; set; }
    public string YazarAd { get; set; }
    public string YazarSoyad { get; set; }
    public int SayfaSayisi { get; set; }
    public string Yayınevi { get; set; }
    public DateTime KayitTarihi { get; set; }

    // Default Constructor
    public Kitap()
    {
        KayitTarihi = DateTime.Now; // Kayıt tarihi o anki tarih olarak atanır.
    }

    // Parametreli Constructor
    public Kitap(string ad, string yazarAd, string yazarSoyad, int sayfaSayisi, string yayinevi)
    {
        Ad = ad;
        YazarAd = yazarAd;
        YazarSoyad = yazarSoyad;
        SayfaSayisi = sayfaSayisi;
        Yayınevi = yayinevi;
        KayitTarihi = DateTime.Now; // Kayıt tarihi o anki tarih olarak atanır.
    }
}