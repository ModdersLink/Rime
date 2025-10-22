using System.Collections.Generic;

namespace RimeLib.Serialization;

public class RefArray<T> : List<CtrRef<T>>
    where T : DataContainerBase
{
    public void AddRef(CtrRefBase p_Ref)
    {
        var s_Ref = new CtrRef<T>();
        s_Ref.SetValue(p_Ref);
        Add(s_Ref);
    }
}