using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace School.DataAccess
{
    public class Verification
    {

        private const string Login = "Admin";
        
        private const string HeshAdmin = "2a4409796b6f78797ed4def9bcc9a033";
        
        private bool isLoggedIn = false;

        public bool Сheck(string login, string pass)
        {
            if (Login == login && HeshAdmin == GetHashString(pass))
            {
                isLoggedIn = true;
                return true;
            }
            
            return false;
        }

        public void SetIsLoggedIn(bool newValue)
        {
            isLoggedIn = newValue;
        }

        public bool IsAuthorization()
        {
            return isLoggedIn;
        }

        public string GetHashString(string s)
        {
            //переводим строку в байт-массим  
            byte[] bytes = Encoding.Unicode.GetBytes(s);

            //создаем объект для получения средст шифрования  
            MD5CryptoServiceProvider CSP =
                new MD5CryptoServiceProvider();

            //вычисляем хеш-представление в байтах  
            byte[] byteHash = CSP.ComputeHash(bytes);

            string hash = string.Empty;

            //формируем одну цельную строку из массива  
            foreach (byte b in byteHash)
                hash += string.Format("{0:x2}", b);

            return hash;
        }
    }
}
