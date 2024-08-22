using RimeLib.Animation.EA.Reflection;
using RimeLib.Frostbite;
using RimeLib.Frostbite.Core;
using RimeLib.IO;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;

namespace RimeLib.Animation.EA.GenericData
{
    public class Reflection : IFbSerializable
    {

        public LayoutHeader[] Layouts { get; set; } = new LayoutHeader[0];


        public Reflection(RimeReader p_Reader)
        {
            Deserialize(p_Reader);
        }



        public bool Serialize(RimeWriter p_Writer)
        {
            var s_LayoutList = new List<long>();

            var s_LayoutStream = new MemoryStream();
            var s_LayoutWriter = new RimeWriter(s_LayoutStream);

            foreach(var s_Layout in Layouts)
            {
                s_LayoutList.Add(s_LayoutWriter.Position);
                s_Layout.Serialize(s_LayoutWriter);
            }


            var s_BaseOffset = s_LayoutList.Count * 0x8;

            foreach (var s_LayotOffset in s_LayoutList)
                p_Writer.Write(s_LayotOffset + s_BaseOffset);

            s_LayoutStream.Seek(0, SeekOrigin.Begin);
            s_LayoutStream.CopyTo(p_Writer);


            throw new NotImplementedException();
        }

        public void Deserialize(RimeReader p_Reader)
        {


            var s_Count = p_Reader.ReadUInt64();


            Layouts = new LayoutHeader[s_Count];
            for (var i = 0; i < Layouts.Length; i++)
            {
                var s_Reloc = new RelocPtr<LayoutHeader>(p_Reader);

                Layouts[i] = s_Reloc.Object;
            }

            Array.Sort(Layouts, (x, y) => (int)(x.Hash - y.Hash));
            //Layouts.Sort((x,y) => (int)(x.Hash - y.Hash));

            foreach (var s_Layout in Layouts)
            {
                foreach( var s_Field in s_Layout.Fields)
                {
                    if (s_Field.LayoutOffset == 0)
                        continue;

                    var s_ResolvedLayout = Layouts.Where(x => x.Position == (long)s_Field.LayoutOffset).First();

                    s_Field.Layout = s_ResolvedLayout;
                }
            }

        }




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
    }
}
