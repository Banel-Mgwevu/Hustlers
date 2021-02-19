using System;
using System.Collections.Generic;
using System.Text;

namespace Hustlers.Domain.Interfaces.Helpers
{
    public interface IPasswordEncryption
    {
        string HashPassword(string password);
        bool ValidatePassword(string password, string correctHash);
        bool SlowEquals(byte[] a, byte[] b);
        byte[] GetPbkdf2Bytes(string password, byte[] salt, int iterations, int outputBytes);
    }
}
