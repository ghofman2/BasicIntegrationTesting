using System;
using System.Runtime.InteropServices;
using System.Security;

namespace CommonLibrary
{
  public static class SecureStringExtensions
  {
    public static SecureString ToSecureString(this string s)
    {

      if (string.IsNullOrWhiteSpace(s))
      {
        return null;
      }
      else
      {
        SecureString Result = new SecureString();
        foreach (char c in s.ToCharArray())
        {
          Result.AppendChar(c);
        }
        return Result;
      }
    }
    public static SecureString ToSecurePassword(this string s)
    {

      if (string.IsNullOrWhiteSpace(s))
      {
        return null;
      }
      else
      {
        SecureString Result = new SecureString();
        foreach (char c in s.ToCharArray())
        {
          Result.AppendChar(c);
        }
        Result.MakeReadOnly();
        return Result;
      }
    }

    public static SecureString SecureString(string s)
    {
      return s.ToSecureString();
    }

    public static string ToUnsecureString(this SecureString securePassword)
    {
      if (securePassword == null)
        throw new ArgumentNullException("securePassword");

      IntPtr unmanagedString = IntPtr.Zero;
      try
      {
        unmanagedString = Marshal.SecureStringToGlobalAllocUnicode(securePassword);
        return Marshal.PtrToStringUni(unmanagedString);
      }
      finally
      {
        Marshal.ZeroFreeGlobalAllocUnicode(unmanagedString);
      }
    }
  }
}
