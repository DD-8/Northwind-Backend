using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities.Concrete;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün eklendi.";
        public static string ProductNameInvalid = "Ürün ismi geçersiz.";
        public static string ProductsListed = "Ürünler listelendi.";
        public static string MaintenanceTime = "Sistem bakımda";
        public static string ProductCountOfCategoryError = "10 üründen fazla ürün olamaz";
        public static string ProductUpdated = "Ürün güncellendi.";
        public static string ProductNameAlreadyExists = "Aynı isimde ürün var.";
        public static string CategoryLimitExceeded = "Kategori limiti aşıldı.";
        public static string AuthorizationDenied = "Yetkilendirme reddedildi.";
        public static string UserRegistered = "Kayıt olundu.";
        public static string UserNotFound = "Kullanıcı bulunamadı.";
        public static string PasswordError = "Hatalı paralo.";
        public static string SuccessfulLogin = "Başarılı giriş.";
        public static string UserAlreadyExists = "Zaten böyle bir kullanıcı var.";
        public static string AccessTokenCreated = "Token oluşturuldu.";
        public static string UserAdded = "Kullanıcı eklendi.";
    }
}
