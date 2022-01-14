using System;
using RimeLib.IO;
using RimeLib.Serialization.Ebx;

namespace RimeLib.Serialization.Frostbite2_0.Ebx
{
    public interface IEbxWriter
    {
        uint WriteImport(CtrRefBase p_CtrRef);
        uint WriteString(string p_String);
        (RimeWriter, uint) GetArrayWriter(Type p_ArrayType, int p_ElementCount);
    }
}
