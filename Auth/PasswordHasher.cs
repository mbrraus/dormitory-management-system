using System.Security.Cryptography;
using System.Text;

namespace DormitoryManagement.Auth;

public static class PasswordHasher
{
    public static string ComputeSha256Hash(string rawData)
    {
        using (var sha256Hash = SHA256.Create())
        {
            byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));

            var builder = new StringBuilder();
            for (int i = 0; i < bytes.Length; i++)
            {
                builder.Append(bytes[i].ToString("x2"));
            }
            return builder.ToString();
        }
    }
}