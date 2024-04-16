# Sinema Rezervasyon Uygulaması

Bu uygulama, sinema rezervasyon işlemlerini yönetmek için bir WinForms uygulamasıdır. Kullanıcılar, filmleri ve seansları görüntüleyebilir, rezervasyon yapabilir ve rezervasyonları görüntüleyebilirler.



Gereksinimler
- Visual Studio 2019 veya daha yeni bir sürümü
- .NET Core SDK
- SQLite veritabanı için gerekli paketler

  
Kurulum
- Projeyi bir Visual Studio ortamında açın.
- Projeyi derleyin.
- SQLite veritabanı oluşturmak için DbInitializer.InitializeDatabase() metodunu çağırın.

  
Kullanım
Uygulama başlatıldığında, kullanıcılar ana ekranla karşılaşacaklar. Ana ekran, mevcut filmleri ve seansları listeler. Kullanıcılar bu ekran üzerinden filmlere ve seanslara göz atabilirler.

- Filmler: Tüm filmleri görüntülemek için "Filmler" sekmesine tıklayın. İlgili filmin üzerine tıklayarak ayrıntıları görebilirsiniz.
- Seanslar: Tüm seansları görüntülemek için "Seanslar" sekmesine tıklayın. İlgili seansın üzerine tıklayarak ayrıntıları görebilirsiniz.
- Rezervasyon: Bir seans için rezervasyon yapmak için "Rezervasyon" sekmesine tıklayın. Ardından uygun koltuk numarasını seçin ve rezervasyonu tamamlayın.

  
Servisler
Uygulama, iş mantığını ayrı servisler aracılığıyla gerçekleştirir. Bu servisler, veritabanı işlemlerini yönetir ve gerekli verileri sağlar.

- FilmServis: Filmlerle ilgili işlemleri yönetir.
- SeansServis: Seanslarla ilgili işlemleri yönetir.
- RezervasyonServis: Rezervasyonlarla ilgili işlemleri yönetir.

  
Veritabanı
Uygulama, SQLite veritabanı kullanır. Veritabanı dosyası projenin içinde files klasörü altında bulunur. Gerektiğinde veritabanı dosyasını değiştirmek için AppDbContext.cs dosyasını düzenleyebilirsiniz. 
