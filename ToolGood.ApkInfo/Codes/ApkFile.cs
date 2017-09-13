using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using Iteedee.ApkReader;
using SharpCompress.Archives;

namespace ToolGood.ApkInfo.Codes
{
    public class ApkFile
    {
        public static ApkFile OpenFile(string apkPath)
        {
            byte[] manifestData = null;
            byte[] resourcesData = null;
            byte[] certData = null;
            int count = 0;

            var archive = ArchiveFactory.Open(apkPath);
            foreach (var entry in archive.Entries) {
                if (!entry.IsDirectory) {
                    var fileName = entry.Key.ToLower();
                    if (fileName == "androidmanifest.xml") {
                        var ms = new MemoryStream();
                        entry.WriteTo(ms);
                        manifestData = ms.ToArray();
                        if (++count == 3) { break; }
                    } else if (fileName == "resources.arsc") {
                        var ms = new MemoryStream();
                        entry.WriteTo(ms);
                        resourcesData = ms.ToArray();
                        if (++count == 3) { break; }
                    } else if (fileName == "meta-inf/cert.rsa") {
                        var ms = new MemoryStream();
                        entry.WriteTo(ms);
                        certData = ms.ToArray();
                        if (++count == 3) { break; }
                    }
                }
            }
            archive.Dispose();
            ApkReader apkReader = new ApkReader();
            ApkFile af = new ApkFile();
            af.ApkInfo = apkReader.extractInfo(manifestData, resourcesData);
            af.Certificate = new X509Certificate2(certData);
            return af;
        }

        public Iteedee.ApkReader.ApkInfo ApkInfo;
        public X509Certificate2 Certificate;

        public string GetThumbprintMd5()
        {
            var bs = Certificate.RawData;
            System.Security.Cryptography.MD5 md5 = new System.Security.Cryptography.MD5CryptoServiceProvider();
            byte[] retVal = md5.ComputeHash(bs);
            md5.Dispose();
            return BitConverter.ToString(retVal).Replace("-", "");
        }

        public string GetThumbprintSha1()
        {
            var bs = Certificate.RawData;
            System.Security.Cryptography.SHA1CryptoServiceProvider osha1 = new System.Security.Cryptography.SHA1CryptoServiceProvider();
            byte[] retVal = osha1.ComputeHash(bs);
            osha1.Dispose();
            return BitConverter.ToString(retVal).Replace("-", "");
        }

        public string GetThumbprintSha256()
        {
            var bs = Certificate.RawData;
            System.Security.Cryptography.SHA256CryptoServiceProvider osha1 = new System.Security.Cryptography.SHA256CryptoServiceProvider();
            byte[] retVal = osha1.ComputeHash(bs);
            osha1.Dispose();
            return BitConverter.ToString(retVal).Replace("-", "");
        }


    }
}
