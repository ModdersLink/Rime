using RimeLib.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RimeLib.Animation.EA
{
    public interface IAssetBankLoader
    {
        void ParseData(RimeReader p_Reader, GenericData.Data p_Data);

    }
}
