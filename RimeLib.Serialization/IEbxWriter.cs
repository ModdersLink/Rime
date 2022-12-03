using System;
using RimeLib.IO;

namespace RimeLib.Serialization;

public interface IEbxWriter : IDisposable
{
    uint WriteImport(CtrRefBase p_CtrRef);
    uint WriteString(string p_String);
    (RimeWriter, uint) GetArrayWriter(Type p_ArrayType, int p_ElementCount);
}