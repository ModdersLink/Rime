using System.Collections.Generic;
using FBCC.Containers;

namespace FBCC.Generators
{
    interface IGenerator
    {
        string Name { get; }

        Dictionary<string, string> Generate(FrostbiteContainer p_Container);
    }
}
