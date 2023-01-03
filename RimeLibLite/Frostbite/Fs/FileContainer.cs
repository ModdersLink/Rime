using RimeLib.Frostbite.Db;
using RimeLib.IO;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Security.Cryptography;

namespace RimeLib.Frostbite.Fs
{
    public class FileContainer
        : IFbSerializable
    {
        public class Container
            : DbObjectSerializable
        {
            [DbObjectField("encrypted")]
            public byte[] Encrypted { get; set; } = new byte[0];
        }

        public byte[]? Key { get; set; } = null;

        public byte[] Data { get; set; } = new byte[0];

        public FileContainer(RimeReader p_Reader, byte[]? p_Key = null)
        {
            Key = p_Key;
            Deserialize(p_Reader);
        }


        public bool Serialize(RimeWriter p_Writer)
        {
            using var s_Aes = Aes.Create();
            s_Aes.Mode = CipherMode.CBC;

            //TODO: check if you need to copy this.Key so it doesnt get overwritten
            s_Aes.Key = Key;

            var s_EncrypedData = s_Aes.EncryptCbc(Data, Key);


            var s_Container = new Container()
            {
                Encrypted = s_EncrypedData
            };

            DbObjectConverter.ToDbObjectWriter(s_Container, p_Writer);
            return true;
        }

        

        public void Deserialize(RimeReader p_Reader)
        {
            (var s_Container, _) = DbObjectConverter.FromDbObjectReader<Container>(p_Reader);

            if (Key == null)
                return;

            using var s_Aes = Aes.Create();
            s_Aes.Mode = CipherMode.CBC;

            //TODO: check if you need to copy this.Key so it doesnt get overwritten
            s_Aes.Key = Key;

            Data = s_Aes.DecryptCbc(s_Container.Encrypted, Key);
        }


        #region defaults
        public bool Serialize([NotNullWhen(true)] out byte[]? p_Data)
        {
            var s_Stream = new MemoryStream();
            using var s_Writer = new RimeWriter(s_Stream);

            if (Serialize(s_Writer))
            {
                p_Data = s_Stream.ToArray();
                return true;
            }

            p_Data = null;
            return false;
        }

        public void Deserialize(byte[] p_Data)
        {
            using var s_Reader = new RimeReader(new MemoryStream(p_Data));
            Deserialize(s_Reader);
        }

        #endregion
    }
}
