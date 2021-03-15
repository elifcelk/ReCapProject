using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string MaintenanceTime = "Sistem bakımda";

        public static string CarAdded = "Araç sisteme eklendi.";
        public static string CarPriceInvalid = "Araç fiyatı geçersiz.Lütfen 0'dan büyük bir fiyat giriniz.";
        public static string CarDeleted = "Araç sistemden silindi.";
        public static string CarsListed = "Araçlar listelendi.";
        public static string CarUpdated = "Araç güncellendi.";

        public static string BrandAdded = "Marka sisteme eklendi.";
        public static string BrandNameInvalid = "Marka ismi geçersiz.Lütfen en az 2 karakter olacak şekilde giriniz.";
        public static string BrandDeleted = "Marka sistemden silindi.";
        public static string BrandsListed = "Markalar listelendi.";
        public static string BrandUpdated = "Marka güncellendi.";

        public static string ColorAdded = "Renk sisteme eklendi.";
        public static string ColorNameInValid = "Renk ismi geçersiz.Lütfen en az 2 karakter olacak şekilde giriniz.";
        public static string ColorDeleted = "Renk sistemden silindi.";
        public static string ColorsListed = "Renkler listelendi.";
        public static string ColorUpdated = "Renk güncellendi.";

        public static string UserAdded = "Kullanıcı sisteme eklendi.";
        public static string UserDeleted = "Kullanıcı sistemden silindi.";
        public static string UsersListed = "Kullanıcılar listelendi.";
        public static string UserUpdated = "Kullanıcı güncellendi.";

        public static string CustomerAdded = "Müşteri sisteme eklendi.";
        public static string CustomerDeleted = "Müşteri sistemden silindi.";
        public static string CustomersListed = "Müşteriler listelendi.";
        public static string CustomerUpdated = "Müşteri güncellendi.";

        public static string RentalAdded = "Araç kiralandı.";
        public static string ErrorAddRental = "Araç teslim edilmedği için kiralanamaz.";
        public static string RentalDeleted = "Araç kiralama iptal edildi.";
        public static string RentalsListed = "Araç kiralamalar listelendi.";
        public static string RentalUpdated = "Araç kiralama güncellendi.";

        public static string ErrorAddCarImage="Bu araca eklenebilecek resim limiti dolmuştur.";
        public static string CarImageAdded="Resim eklendi";
        public static string CarImageDeleted="Resim silindi";
        public static string CarImageUpdated="Resim güncellendi";
        public static string CarImagesListed="Resimler listelendi";

        public static string AuthorizationDenied="Yetkiniz yok";
        public static string UserRegistered="Kayıt oldu";
        public static string UserNotFound="Kullanıcı bulunamadı";
        public static string PasswordError="Parola hatası";
        public static string SuccessfulLogin="Başarılı giriş";
        public static string UserAlreadyExists="Kullanıcı mevcut";
        public static string AccessTokenCreated="Token oluşturuldu";
    }
}
