using System;
using RimeLib.IO;

namespace RimeLib.Serialization.Frostbite2_0.Ebx;

public interface IEbxWriter : IDisposable
{
    uint WriteImport(CtrRefBase p_CtrRef);
    uint WriteString(string p_String);
    (RimeWriter, uint) GetArrayWriter(Type p_ArrayType, int p_ElementCount);
}