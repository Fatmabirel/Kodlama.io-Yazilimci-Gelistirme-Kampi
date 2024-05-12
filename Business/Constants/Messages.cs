using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün eklendi";
        public static string ProductNameInvalid = "Ürün ismi geçersiz";
        public static string MaintenanceTime = "Sistem bakımı";
        public static string ProductsListed = "Ürünler listelendi";
        public static string ProductCountOfCategoryError = "10'dan fazla ürün olamaz";

        public static string ProductNameAlreadyExists = "Böyle bir ürün ismi zaten var!";
        public static string CategoryLimitExceded = "15'ten fazla kategori girilmez";

        public static string? AuthorizationDenied = "Yetkiniz yok";

        public static string UserRegistered = "Kullanıcı Kayıt Oldu";
        public static string UserNotFound = "Kullanıcı bulunamadı";
        public static string PasswordError = "Şifre yanlış";
        public static string SuccessfulLogin = "Başarıyla giriş yaptınız";
        public static string UserAlreadyExists = "Böyle bir kullanıcı zaten var";
        public static string AccessTokenCreated = "Token oluşturuldu";
    }
}
