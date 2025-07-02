...2D Android Araba Oyunu...

Proje Hakkında : 
Bu proje, Unity kullanılarak geliştirilmiş 2D bir Android araba oyunudur.
Oyuncu ekranın ortasında sabit duran bir arabayı kontrol eder ve ekranda aşağı doğru rastgele diğer arabalar gelir. Oyunun temel amacı, bu gelen arabalardan kaçınmaktır.

....Oynanış....

Oyuncu Kontrolü:
Oyuncu, ekranın sağ veya sol tarafına dokunarak arabanın X ekseninde sağa veya sola hareket etmesini sağlar.

Arka Plan Hareketi:
Arka plan sürekli aşağı doğru hareket eder, bu sayede oyuncunun arabanın ileri doğru hareket ettiği hissi yaratılır.

Araçların Oluşumu:
Ekranın üst kısmından rastgele konumlarda farklı arabalar belirir ve aşağı doğru hareket eder.

Çarpışma Algılama:
Oyuncunun arabası diğer arabalara çarptığında oyun durur ve bir “Restart” butonu görünür.

Restart Butonu:
Oyuncu restart butonuna basarak oyunu baştan başlatabilir.

Skor Sistemi:
Oyun süreklidir ve oyuncunun hayatta kalma süresine göre skor artar. Skor, ekranda gerçek zamanlı gösterilir.

.....Teknik Detaylar....
Car_Spawner:
Rastgele konumlarda yeni arabalar oluşturur ve onları belirli aralıklarla sahneye ekler.

Car_Movement:
Oluşturulan arabalar sahnede aşağı doğru hareket eder, sahne dışına çıkınca yok edilirler.

Player_Movement:
Oyuncunun arabasını ekranın sağ-sol dokunmatik bölgeleriyle kontrol eder. Çarpışmayı algılar, çarpma durumunda oyunu durdurur ve restart panelini aktif eder.

Road_Movement:
Arka planın aşağı doğru sürekli kaymasını sağlar, böylece hareket efekti oluşturur.

Score_Manager:
Zamanla artan skoru hesaplar ve UI’da gösterir.

Game_Controller:
Oyunun temel kontrol mekanizmasını sağlar, restart fonksiyonunu içerir.

Kurulum ve Kullanım: 
Projeyi Unity Editor ile açın.

Android cihazınıza bağlanarak derleyin.

Oyunu oynarken ekranın sağ veya sol tarafına dokunarak arabanızı hareket ettirin.

Gelen araçlara çarpmamaya çalışın.

Çarptığınızda restart butonu ile oyunu yeniden başlatabilirsiniz.
