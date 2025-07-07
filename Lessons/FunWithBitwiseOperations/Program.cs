using System;

namespace FunWithBitwiseOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            ContactPreferenceEnum emailAndPhone = ContactPreferenceEnum.Email | ContactPreferenceEnum.Phone;
            Console.WriteLine($"None? {(emailAndPhone | ContactPreferenceEnum.None) == emailAndPhone}");
            Console.WriteLine($"Email? {(emailAndPhone | ContactPreferenceEnum.Email) == emailAndPhone}");
            Console.WriteLine($"Phone? {(emailAndPhone | ContactPreferenceEnum.Phone) == emailAndPhone}");
            //Console.WriteLine($"Text? {(emailAndPhone | ContactPreferenceEnum.Text) == emailAndPhone}");
        }
    }
}