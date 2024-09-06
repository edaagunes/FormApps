# FormApps
Bu repository C# Form kullanılarak oluşturulan projelerdir.

Murat Yücedağ tarafından hazırlanan Udemy'de bulunan "25 Derste 25 Proje" kursundan faydalanarak oluşturulmuştur.

#### [Bilgi Yarışması](#bilgi-yarışması)
#### [Hastane Yönetim Sistemi](#hastane-yönetim-sistemi)
#### [N Katmanlı Mimari Projesi](#n-katmanlı-mimari-projesi)
#### [Öğrenci Not Hesaplama Uygulaması](#öğrenci-not-hesaplama-uygulaması)
#### [Pasta Pişirme Süreç Uygulaması](#pasta-pişirme-süreç-uygulaması)
#### [Sinema/Büfe Satış Projesi](#sinema-büfe-satış-projesi)
#### [Uçak Bileti Rezervasyon Projesi](#uçak-bileti-rezervasyon-projesi)


### Bilgi Yarışması
Form elementleri kullanılarak oluşturuldu. Cevaplara göre doğru/yanlış sayısı hesaplandı. Cevap doğru olduğunda yeşil gif, yanlış olduğunda kırmızı gif ile geri bildirim verildi.

<img width=500 height=400 src="https://github.com/user-attachments/assets/755a1f55-4ba7-4337-8b02-761ce7e3247c"> 
<img width=500 height=400 src="https://github.com/user-attachments/assets/bff97482-81a9-41bd-9cc1-0ce4641079e1">

# Hastane Yönetim Sistemi
**SQL Server** kullanılarak projenin veri tabanı oluşturuldu. Tablolara veri girişleri yapıldı. Veri tabanında bulunan tablolar:
<ol>
    <li>Hasta Tablosu</li>
    <li>Randevu Tablosu</li>
    <li>Doktorlar Tablosu</li>
    <li>Branş Tablosu</li>
    <li>Sekreter Tablosu</li>
  <li>Duyurular Tablosu</li>
</ol>

Sistem **Hasta, Doktor ve Sekreter** panelleri olarak üç farklı formdan oluşmaktadır.

<img align="center" width=600 height=450 src="https://github.com/user-attachments/assets/9482e213-5695-49da-94e1-f1c6ac178ae9">

#### _Hasta Paneli_
Hasta butonu seçildikten sonra bir **Giriş Paneli** açılır. Burada hasta sisteme kayıtlı değil ise **Üye Ol** linki ile sisteme kayıt olur.

<p align="left">
<img  width=500 height=400 src="https://github.com/user-attachments/assets/d8cd3dbf-8808-4a0f-b871-bed856e73865">
<img  width=500 height=400 src="https://github.com/user-attachments/assets/e280e6b6-03e7-43dd-be41-d61c2ccba100">
</p>

Hasta sisteme TC kimlik numarası ve şifresi ile giriş yaptıktan sonra **Hasta Detay Formu** açılır. Bu formda **Branş** seçerek randevu talebi oluşturabilir.
Kişi bilgilerinde hata var ise **Bilgi Düzenle** linki ile bilgi güncelleme yapabilir.

<img width=500 height=400 src="https://github.com/user-attachments/assets/df8f72f4-11e0-4455-b91f-d6f74bd5a7dd">
<img width=500 height=400 src="https://github.com/user-attachments/assets/8e9fa0ef-061a-4ff2-9557-8f1bfab444ef">

Bu formda **Branş** seçerek randevu talebi oluşturabilir. Seçtiği Branştaki aktif randevuları görebilir.

<img width=500 height=400 src="https://github.com/user-attachments/assets/3892b854-5c75-4c9c-a655-7b4e59fc90bf">

#### _Doktor Paneli_
Sisteme Doktor butonu seçildikten sonra **Doktor** için Giriş Paneli açılır. TC kimlik numarası ve şifre ile giriş yapılır.

<img width=500 height=400 src="https://github.com/user-attachments/assets/774ed419-fcfa-43a7-9703-8e96e2693077">

**Doktor Detay Panelinde** oluşturulan Randevular hakkında bilgilere ulaşılabilir. Ayrıca **Bilgi Düzenle** linki ile Doktor bilgilerini güncelleyebilir.

<img width=500 height=400 src="https://github.com/user-attachments/assets/97aed6c3-2622-499f-b34b-663fa454cfcd">
<img width=500 height=400 src="https://github.com/user-attachments/assets/f988f9ad-80ff-4f32-b68a-5af642f2a53f">

**Duyurular** butonu ile Sekreter tarafından oluşturular Duyuruları görebilir.

<img width=500 height=400 src="https://github.com/user-attachments/assets/1da9afcc-57b7-4a27-b19d-26801cf96078">

#### _Sekreter Paneli_
Sisteme Sekreter butonu seçildikten sonra **Sekreter** Giriş Paneli açılır. TC kimlik numarası ve şifre ile giriş yapılır.

<img width=500 height=400 src="https://github.com/user-attachments/assets/0003a467-7495-4272-9a3a-858ec944fbc3">

**Sekreter Panelinde** *Hasta Randevusu*, *Duyuru* oluşturabilir, *Branşlar* ve *Doktorlar* listeleyebilir.

<img width=500 height=400 src="https://github.com/user-attachments/assets/7276001f-013b-4172-89a7-d4a39f9aff1b">

**Hızlı Erişim** menüsünden Doktor ve Branş *Ekle/Sil/Güncelleme* yapabilir.

<img width=500 height=400 src="https://github.com/user-attachments/assets/c364696e-c892-4d6b-ad90-1b1c275dd441">

<img width=500 height=400 src="https://github.com/user-attachments/assets/08c763c0-b9f9-4fa3-b261-94209ee840c5">

*Randevu Listesini* ve Duyuruları görüntüleyebilir.

<img width=500 height=400 src="https://github.com/user-attachments/assets/d072686a-669b-408f-b658-6599f57e522e">

### N Katmanlı Mimari Projesi

Bu projede Personel *Ekle/Sil/Güncelleme* işlemleri gerçekleştirildi. **SQL Server** kullanılarak veri tabanı oluşturuldu. Personel Bilgi ve Departman tabloları eklendi.

<img width=500 height=400 src="https://github.com/user-attachments/assets/f2592cd6-bd18-4575-ab56-a78e82bf663b">

CRUD işlemleri *Data Access Layer, Entity Layer, Logic Layer* arasında gerçekleştirildi.

**Entity Layer** projede kullanılacak varlıklar burada *Property* olarak tanımlandı.
```cs
 public class EntityPersonel
 {
     private int id;
     private string ad;
     private string soyad;
     private string sehir;
     private string gorev;
     private short maas;

     public int Id { get => id; set => id = value; }
     public string Ad { get => ad; set => ad = value; }
     public string Soyad { get => soyad; set => soyad = value; }
     public string Sehir { get => sehir; set => sehir = value; }
     public string Gorev { get => gorev; set => gorev = value; }
     public short Maas { get => maas; set => maas = value; }
 }
```

**Data Access Layer** veritabanı bağlantısı için gereklidir.
```cs
 public class DALPersonel
 {
     public static List<EntityPersonel> PersonelListesi()
     {
         List<EntityPersonel> degerler = new List<EntityPersonel>();
         SqlCommand komut1 = new SqlCommand("Select *from Tbl_PersonelBilgi", Baglanti.bgl);
         if (komut1.Connection.State != ConnectionState.Open)
         {
             komut1.Connection.Open();
         }

         SqlDataReader dr = komut1.ExecuteReader();
         while (dr.Read())
         {
             EntityPersonel ent = new EntityPersonel();
             ent.Id = int.Parse(dr["ID"].ToString());
             ent.Ad = dr["Ad"].ToString();
             ent.Soyad = dr["Soyad"].ToString();
             ent.Gorev = dr["Gorev"].ToString();
             ent.Sehir = dr["Sehir"].ToString();
             ent.Maas = short.Parse(dr["Maas"].ToString());
             degerler.Add(ent);
         }
         dr.Close();
         return degerler;
     }

     public static int PersonelEkle(EntityPersonel p)
     {
         SqlCommand komut2 = new SqlCommand("insert into Tbl_PersonelBilgi(Ad,Soyad,Gorev,Sehir,Maas) values (@p1,@p2,@p3,@p4,@p5)", Baglanti.bgl);

         if (komut2.Connection.State != ConnectionState.Open)
         {
             komut2.Connection.Open();
         }


         komut2.Parameters.AddWithValue("@p1", p.Ad);
         komut2.Parameters.AddWithValue("@p2", p.Soyad);
         komut2.Parameters.AddWithValue("@p3", p.Gorev);
         komut2.Parameters.AddWithValue("@p4", p.Sehir);
         komut2.Parameters.AddWithValue("@p5", p.Maas);

         return komut2.ExecuteNonQuery();

     }

     public static bool PersonelSil(int p)
     {
         SqlCommand komut3 = new SqlCommand("Delete from Tbl_PersonelBilgi where ID=@p1", Baglanti.bgl);
         if (komut3.Connection.State != ConnectionState.Open)
         {
             komut3.Connection.Open();
         }

         komut3.Parameters.AddWithValue("@p1", p);
         return komut3.ExecuteNonQuery() > 0;

     }
 
     public static bool PersonelGuncelle(EntityPersonel ent)
     {
         SqlCommand komut4 = new SqlCommand("Update Tbl_PersonelBilgi set Ad=@p1,Soyad=@p2,Maas=@p3,Sehir=@p4,Gorev=@p5 where ID=@p6",Baglanti.bgl);

         if (komut4.Connection.State != ConnectionState.Open)
         {
             komut4.Connection.Open();
         }

         komut4.Parameters.AddWithValue("@p1", ent.Ad);
         komut4.Parameters.AddWithValue("@p2", ent.Soyad);
         komut4.Parameters.AddWithValue("@p3", ent.Maas);
         komut4.Parameters.AddWithValue("@p4", ent.Sehir);
         komut4.Parameters.AddWithValue("@p5", ent.Gorev);
         komut4.Parameters.AddWithValue("@p6", ent.Id);
         return komut4.ExecuteNonQuery() > 0;
     }
     
 }
```

**Logic Layer** verilerin işlendiği, kullanıcı isteklerini işlememize ve kurallar uygulayabilmemizi sağlar.
```cs
   public class LogicPersonel
   {
       public static List<EntityPersonel> LLPersonelListesi()
       {
           return DALPersonel.PersonelListesi();
       }

       public static int LLPersonelEkle(EntityPersonel p)
       {
           if (p.Ad != "" && p.Soyad != "" && p.Maas >= 3500 && p.Ad.Length >= 3)
           {
               return DALPersonel.PersonelEkle(p);
           }
           else
           {
               return -1;
           }

       }
   
       public static bool LLPersonelSil(int per)
       {
           if (per>=1)
           {
               return DALPersonel.PersonelSil(per);
           }
           else
           {
               return false;
           }
       }
   
       public static bool LLPersonelGuncelle(EntityPersonel ent)
       {
           if (ent.Ad.Length>=3 && ent.Ad !="" && ent.Maas>=4500)
           {
               return DALPersonel.PersonelGuncelle(ent);
           }
           else
           {
               return false;
           }
       }
   }
```

### Öğrenci Not Hesaplama Uygulaması
Girilen verilere göre öğrencinin **not ortalamasını** hesaplayıp, yazdıran bir form uygulamasıdır.

<img width=600 height=400 src="https://github.com/user-attachments/assets/5eeabd75-bc02-4eb0-828f-c29d7ef2b460">

### Pasta Pişirme Süreç Uygulaması
Bu projede Form uygulamasının **Timer** özelliği kullanılarak oluşturulmuştur. 

<img width=700 height=500 src="https://github.com/user-attachments/assets/e327781b-cbc1-4f82-ac89-8109befc1e6a">

4 farklı Timer kullanıldı. Pastanın bir aşaması bitmeden diğerine geçilemez. Her aşamanın kendine ait bir süresi vardır. Progress Bar ile takip edilebilir.

```cs
 private void timer3_Tick(object sender, EventArgs e)
 {
     progressBar3.Value += 20;

     if (progressBar3.Value % 40 == 0)
     {
         label3.BackColor = Color.LightPink;
     }

     if (progressBar3.Value % 40 == 20)
     {
         label3.BackColor = Color.White;
     }

     if (progressBar3.Value == 100)
     {
         timer3.Stop();
         timer4.Start();
     }
 }

 private void timer4_Tick(object sender, EventArgs e)
 {
     progressBar4.Value += 1;

     if (progressBar4.Value % 2 == 0)
     {
         label4.BackColor = Color.LightPink;
     }

     if (progressBar4.Value % 2 == 1)
     {
         label4.BackColor = Color.White;
     }

     if (progressBar4.Value == 100)
     {
         timer4.Stop();
         MessageBox.Show("Pasta Hazır :) ");
        
     }
```

### Sinema/Büfe Satış Projesi
Büfeden alınan ürünlerin toplam ücretini ve kasada biriken toplam tutarı hesaplayan bir uygulamadır.

<img width=700 height=500 src="https://github.com/user-attachments/assets/b80467b9-355e-42eb-8ea6-9595c2a86612">

### Uçak/Bilet Rezervasyon Projesi
Seçilen şehirler arası Uçak Rezervasyonu oluşturur ve ListBox'a yazar. **<>** butonu ile nereden/nereye rotası ters çevrilebilir. 

<img width=700 height=500 src="https://github.com/user-attachments/assets/b47bfd80-3865-4db5-a1d7-3502094cb056">


