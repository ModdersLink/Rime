using RimeLib.IO;
using RimeLib.Serialization.Ebx;

namespace RimeLib.Serialization
{
    public interface IEbxParser
    {
        CtrRefBase GetImportAtIndex(uint p_Index);
        string GetStringAtOffset(uint p_Offset);
        (RimeReader, uint) GetArrayReaderAndElementCount(uint p_Index);
    }
}
