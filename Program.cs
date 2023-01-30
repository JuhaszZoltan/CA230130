using System.Security.Cryptography;
using System.Text;

string password = "PassWord123";

using SHA256 sha2 = SHA256.Create();

byte[] buffer = Encoding.UTF8.GetBytes(password);
byte[] hashValue = sha2.ComputeHash(buffer);

Console.WriteLine($"input:  {password}");
Console.WriteLine($"output: {GetHashValueString(hashValue)}");

string GetHashValueString(byte[] hv)
{
    string hvs = string.Empty;
	for (int i = 0; i < hv.Length; i++)
	{
		hvs += $"{hv[i]:X}";
		if ((i + 1) % 4 == 0) hvs += " ";
	}
	return hvs.TrimEnd(' ');
}