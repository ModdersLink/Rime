using RimeLib.Ant.EA.Reflection;
using RimeLib.Frostbite;
using RimeLib.Frostbite.Core;
using RimeLib.IO;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RimeLib.Ant.EA.GenericData
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
