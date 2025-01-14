class Program
{
    static void Main(string[] args)
    {
        // Default constructor ile nesne oluşturma
        Kitap kitap1 = new Kitap
        {
            Ad = "Adı Aylin",
            YazarAd = "Ayşe",
            YazarSoyad = "Kulin",
            SayfaSayisi = 398,
            Yayınevi = "Remzi Kitabevi"
        };
        Console.WriteLine($"Kitap 1 - Ad: {kitap1.Ad}, Yazar: {kitap1.YazarAd} {kitap1.YazarSoyad}, Sayfa Sayısı: {kitap1.SayfaSayisi}, Yayınevi: {kitap1.Yayınevi}, Kayıt Tarihi: {kitap1.KayitTarihi:yyyy-MM-dd}");

        // Parametreli constructor ile nesne oluşturma
        Kitap kitap2 = new Kitap("Bir Kitap", "Ahmet", "Yılmaz", 320, "Alfa Yayınları");
        Console.WriteLine($"Kitap 2 - Ad: {kitap2.Ad}, Yazar: {kitap2.YazarAd} {kitap2.YazarSoyad}, Sayfa Sayısı: {kitap2.SayfaSayisi}, Yayınevi: {kitap2.Yayınevi}, Kayıt Tarihi: {kitap2.KayitTarihi:yyyy-MM-dd}");
    }
}