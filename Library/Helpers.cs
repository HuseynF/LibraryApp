using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
   public static class Helpers
    {
        public static bool IsMail(this string email)
        {
			try
			{
				MailAddress address = new MailAddress(email);
				return true;
			}
			catch (Exception)
			{
				return false;
			}
        }
		public static string HashPassword(this string password)
		{
			byte[] pass = Encoding.ASCII.GetBytes(password);
			SHA256Managed manager = new SHA256Managed();
			byte[] passw = manager.ComputeHash(pass);
			return Encoding.ASCII.GetString(passw);
		}
    }
}
