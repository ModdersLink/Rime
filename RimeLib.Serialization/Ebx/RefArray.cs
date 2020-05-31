using RimeLib.Serialization.Containers;
using System.Collections.Generic;

namespace RimeLib.Serialization.Ebx
{
    /// <summary>
    /// An array of instance references
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class RefArray<T> : List<CtrRef<T>>
        where T : DataContainer
    {
    }
}
