using System;
using System.Collections.Generic;
using System.Text;

namespace Elementalist.Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün başarıyla eklendi";
        public static string ProductUpdated = "Ürün başarıyla güncellendi";
        public static string ProductDeleted = "Ürün başarıyla silindi";
        public static string ProductNotEmpty = "Ürün boş olamaz";

        public static string CategoryAdded = "Kategory başarıyla eklendi";
        public static string CategoryUpdated = "Kategory başarıyla güncellendi";
        public static string CategoryDeleted = "Kategory başarıyla silindi";

        public static string UserNotFound = "Kullanıcı bulunamadı";
        public static string UserAdded = "Kullanıcı başarıyla eklendi";
        public static string UserUpdated = "Kullanıcı başarıyla güncellendi";
        public static string UserDeleted= "Kullanıcı başarıyla silindi";

        public static string PasswordError = "Şifre hatalı";
        public static string SuccessfulLogin = "Giriş başarılı";
        public static string UserAllreadyExists = "Kullanıcı zaten mevcut";
        internal static string AccessTokenCreated = "Access Token başarıyla oluşturuldu";
    }
}
