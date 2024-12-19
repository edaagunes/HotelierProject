# Hotelier Api Project

# Genel Bakış

🏨 Bu projede, bir otel için dinamik bir web sitesi ve admin paneli geliştirilmiştir. Projenin tüm backend altyapısı API olarak yazılmış ve frontend tarafında bu API'ler tüketilerek (consume edilerek) kullanıma hazır hale getirilmiştir. Kullanıcıların otel hakkında bilgi alabileceği, rezervasyon yapabileceği ve adminlerin otel yönetimini kolaylıkla gerçekleştirebileceği bir sistem oluşturulmuştur.

## 🌍 [Web Site](#-web-site-1)

Kullanıcılar, web sitesi üzerinden otelle ilgili kapsamlı bilgilere erişebilir ve çeşitli işlemleri kolayca gerçekleştirebilir. 

&nbsp;&nbsp; 🛏️ **Oda ve Hizmet Bilgileri**: Kullanıcılar otelin sunduğu oda seçeneklerini, hizmet detaylarını ve diğer kullanıcıların referans yorumlarını inceleyebilir.  
  
&nbsp;&nbsp; 📧 **Mail Bülteni Kaydı**: İlgilenen kullanıcılar, e-posta bültenine kayıt olarak otelden güncel bilgiler alabilir.  
 
&nbsp;&nbsp; 📅 **Rezervasyon İşlemleri**: Rezervasyon menüsü aracılığıyla istenen bilgileri girerek hızlı ve kolay bir şekilde rezervasyon yapılabilir.  
 
&nbsp;&nbsp; ✉️ **İletişim**: Kullanıcılar iletişim menüsünü kullanarak mesajlarını otel yönetimine iletebilir.  


## 🖥️ [Admin Paneli](#%EF%B8%8F-admin-paneli-1)

Admin paneli üzerinden site üzerindeki tüm alanlar dinamik olarak güncellenebilir ve yönetilebilir. İşte yönetim özelliklerinin detaylı açıklamaları:  

&nbsp;&nbsp;&nbsp;&nbsp; 📊 **Dashboard**: Sayısal veriler görselleştirilerek kullanıcılara sunuldu. Sosyal medya takipçi sayıları Rapid API üzerinden entegrasyon yapılarak &nbsp;&nbsp; dinamik bir şekilde çekildi.  

&nbsp;&nbsp;&nbsp;&nbsp; 📅 **Rezervasyonlar**: Kullanıcıların yaptığı rezervasyonlar listelenebilir ve güncellenebilir. Rezervasyon durumları butonlar aracılığıyla kolaylıkla &nbsp;&nbsp; değiştirilebilir.  

&nbsp;&nbsp;&nbsp;&nbsp; 👨‍💼 **Personeller**: Personel bilgileri detaylı bir şekilde listelenir.  

&nbsp;&nbsp;&nbsp;&nbsp; 📝 **Referanslar**: Otel hakkında referans bilgileri listelenir ve gerektiğinde güncellenebilir.  

&nbsp;&nbsp;&nbsp;&nbsp; 🛎️ **Hizmetler**: Otelin sunduğu hizmetler listelenebilir ve istenirse güncellenebilir.  

&nbsp;&nbsp;&nbsp;&nbsp; 🏨 **Hakkımızda**: Otelin "Hakkımızda" bilgisi listelenir ve düzenlenebilir.  

&nbsp;&nbsp;&nbsp;&nbsp; 🛌 **Odalar**: Oda bilgileri listelenebilir, güncellenebilir ve yeni odalar eklenebilir.  

&nbsp;&nbsp;&nbsp;&nbsp; 👥 **Misafirler**: Otel misafirlerinin bilgileri görüntülenebilir ve gerektiğinde güncellenebilir.  

&nbsp;&nbsp;&nbsp;&nbsp; 📩 **Mesajlar**: Kullanıcıların iletişim formu üzerinden gönderdiği mesajlar listelenir. Admin, mesajlara cevap olarak kullanıcılara e-posta  &nbsp;&nbsp;&nbsp;&nbsp;gönderebilir.  

&nbsp;&nbsp;&nbsp;&nbsp; ✉️ **Mail İşlemleri**: MailKit kullanılarak gerçek zamanlı e-posta gönderimi sağlandı.  

&nbsp;&nbsp;&nbsp;&nbsp; 📂 **Görsel ve Dosya İşlemleri**: Sistem üzerinde görsel ve dosya yükleme işlemleri gerçekleştirilebilir.  

&nbsp;&nbsp;&nbsp;&nbsp; 👤 **Kullanıcılar**: Sisteme kayıtlı çalışanlar veya kullanıcılar listelenir. Kullanıcıların bulundukları lokasyonlar da görüntülenir.  

&nbsp;&nbsp;&nbsp;&nbsp; 📍 **Otel Lokasyonları**: Otelin faaliyet gösterdiği lokasyonlar listelenebilir.  

&nbsp;&nbsp;&nbsp;&nbsp; 🔒 **Roller**: Kullanıcılara atanabilecek roller listelenir. Yeni roller eklenebilir.  

&nbsp;&nbsp;&nbsp;&nbsp; 🔑 **Rol Atamaları**: Kullanıcılara birden fazla rol atanabilir.  

&nbsp;&nbsp;&nbsp;&nbsp; ⚙️ **Ayarlar**: Giriş yapan adminin bilgileri görüntülenebilir ve güncellenebilir.  


## ✍️ Giriş Yap ve Kayıt Ol Sayfaları
![2](https://github.com/user-attachments/assets/9a7d3036-dad2-4145-9b9b-fdb962398aaa)
![1](https://github.com/user-attachments/assets/ef4dffd8-0411-4abc-aa60-484bcf42d1b5)

## 💡 Kullanılan Teknolojiler

<table>
  <tr>
    <td>🎉 Asp.Net Core (5.0) ile hazırlanmıştır.</td>
    <td>📚 Entity Framework kullanılmıştır.</td>
  </tr>
  <tr>
    <td>🏢 N Katmanlı Mimari ile oluşturuldu.</td>
    <td>🔐 Identity kütüphanesi kullanıldı.</td>
  </tr>
  <tr>
    <td>⚙️ Validation Rules uygulandı.</td>
    <td>🔨 CodeFirst yaklaşımı uygulanmıştır.</td>
  </tr>
  <tr>
    <td>📂 Mapper entegrasyonu yapıldı.</td>
    <td>📝 Data Annotations kullanıldı.</td>
  </tr>
  <tr>
    <td>📧 Mail Gönderimi yapıldı.</td>
    <td>🔒 Authentication ve Authorization işlemleri uygulandı.</td>
  </tr>
  <tr>
    <td>📘 Repository Design Pattern kullanıldı.</td>
    <td>📈 CRUD işlemleri yapılmıştır.</td>
  </tr>
  <tr>
    <td>⚠️ Rapid API üzerinden dinamik veri çekme işlemi gerçekleştirildi.</td>
    <td>📖 Tamamen API kullanılarak gerçekleştirildi.</td>
  </tr>
  <tr>
    <td>📧 Rolleme yapıldı.</td>
    <td>🔑 JWT kullanarak token üretildi ve Postman üzerinden bu token ile işlemler gerçekleştirildi.</td>
  </tr>
  <tr>
    <td>💾 MSSQL veri tabanı kullanılmıştır.</td>
    <td>🏗️ DTO Layer kullanıldı.</td>
  </tr>
    <tr>
  <td>🔄 MSSQL veritabanında Trigger kullanılarak veri güncelleme işlemi gerçekleştirildi.</td>
      <td>🛠️AutoMapper, Fluent Validation, MailKit paketleri kullanıldı.</td>
  </tr>
</table>

## 🌍 Web Site
![default1](https://github.com/user-attachments/assets/a4dfdee6-e0c1-4a0d-b3cd-3385b5689b83)
![default2](https://github.com/user-attachments/assets/5c6cbfff-5c89-43b3-862e-f1924257d61b)
![default3](https://github.com/user-attachments/assets/3c800976-7642-4c2d-956f-2a8bc52f3da4)
![default4](https://github.com/user-attachments/assets/010d876a-657a-45cd-844d-07b1cb1fa1f8)
![default5](https://github.com/user-attachments/assets/6ca4bbd5-f890-4c0c-9808-53dc48b74ed3)
![default6](https://github.com/user-attachments/assets/dd7c9efb-a9c7-49d3-9d49-e8d8e31692a7)
![default7](https://github.com/user-attachments/assets/bf55c529-acaf-4834-a065-89e625b2dc44)
![default8](https://github.com/user-attachments/assets/098e5ad1-fb22-41c9-8930-44acf10df551)
![defaultbooking](https://github.com/user-attachments/assets/65c5c0e8-484e-428a-ab7a-f89224d619bb)
![defaultcontact](https://github.com/user-attachments/assets/1c132736-1a1d-4e3c-8063-ee5587b8272c)

## 🖥️ Admin Paneli
![admin1](https://github.com/user-attachments/assets/54973153-00ba-4dc5-a625-ddd5ff41ef14)
![admin2](https://github.com/user-attachments/assets/de229c15-ebb6-4ac5-8670-435d5fa942ac)
![admin3](https://github.com/user-attachments/assets/9d14ce70-d705-4d92-af29-d2c956e43614)
![admin4](https://github.com/user-attachments/assets/2c144d4d-149b-4b62-ac5b-1191636870f4)
![admin5](https://github.com/user-attachments/assets/44b6cb4a-dd5c-4b55-ae86-3804bb57e52a)
![admin6](https://github.com/user-attachments/assets/8653f37a-2ebf-4396-a169-9b39c1ebd3b5)
![admin7](https://github.com/user-attachments/assets/c50a84a9-cec2-42cd-a88d-03343818dabf)
![admin8](https://github.com/user-attachments/assets/9acdc179-4535-4ca0-a977-aebafc0a367f)
![admin9](https://github.com/user-attachments/assets/058f275a-c0dc-4e98-ba19-6a4674358ad9)
![admin10](https://github.com/user-attachments/assets/bd90d438-eb30-4642-9cd2-3386d886fb4f)
![admin11](https://github.com/user-attachments/assets/b515ac3c-436e-4f15-ac99-8ea03044728e)
![admin12](https://github.com/user-attachments/assets/df9031ae-c765-4fc3-a783-8d4c7ae0e19c)
![admin13](https://github.com/user-attachments/assets/0eae756b-8489-44d6-924f-8ed1e68ee0b7)
![admin14](https://github.com/user-attachments/assets/8b09d9ac-df49-4ea5-83bb-e86c8c3d1eb5)
![admin15](https://github.com/user-attachments/assets/7a15ce30-61b6-433c-b5c0-7b5167d20645)
![admin16](https://github.com/user-attachments/assets/7c9af976-b26b-41e0-aa6a-27626e215a3f)
![admin17](https://github.com/user-attachments/assets/3ed8a961-9fd5-44f2-a068-75e39d1c3f98)
![admin18](https://github.com/user-attachments/assets/1c6b6ac0-a4a8-4e87-af69-04351fc0f8d9)
![admin19](https://github.com/user-attachments/assets/c000c717-ed91-4b71-a92a-0c29cfcb3af7)
![admin20](https://github.com/user-attachments/assets/7da35c5d-0925-46f0-b218-92f86cdd3cfd)
![admin21](https://github.com/user-attachments/assets/f4a3d7cd-096f-45ce-95b6-be0ef1f0d8ad)
![admin22](https://github.com/user-attachments/assets/1a98983f-f27e-4d29-8be8-420c2c979c04)
![admin23](https://github.com/user-attachments/assets/29da64ea-1f93-400d-b8b9-7b68eac7b67c)
![admin24](https://github.com/user-attachments/assets/d9f54dba-e867-4536-a3f4-5e2713e3a8bc)
![errorpage](https://github.com/user-attachments/assets/6b985467-6d3a-40d9-a6ac-d5a4be6a3b55)

![swaggerr](https://github.com/user-attachments/assets/6b326711-b623-4060-870d-245b82734c7b)


