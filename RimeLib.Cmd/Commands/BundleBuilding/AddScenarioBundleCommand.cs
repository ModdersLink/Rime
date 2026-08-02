using System.IO;
using RimeLib.Cmd.Attributes;
using RimeLib.Cmd.Contexts;

namespace RimeLib.Cmd.Commands.BundleBuilding
{
    /// <summary>
    /// Declares a bundle that loads in one particular runtime configuration.
    ///
    /// Where add_dependency_bundle says "this is always there", a scenario says "exactly one of
    /// these situations happens". Call it once per bundle, repeating the scenario name to build up
    /// that scenario's loadout. The closure may then leave out only what every scenario carries, so
    /// the bundle works whichever one occurs.
    ///
    /// Name bundles, not superbundles. A level superbundle holds its gamemode bundles as siblings
    /// and only one of them loads, so the superbundle is never a real runtime state. The level's own
    /// always-loaded bundle shares the superbundle's name, so naming the level costs nothing extra.
    /// </summary>
    [CommandDescription("Adds a bundle loaded in one mutually exclusive scenario. The closure keeps anything not present in every scenario.")]
    internal class AddScenarioBundleCommand : Command
    {
        [CommandArgument(Description = "Name of the scenario this bundle belongs to, e.g. 'skybar_domination'.")]
        public string? Scenario { get; set; }

        [CommandArgument(Description = "The name of the bundle loaded in that scenario.")]
        public string? Name { get; set; }

        public override bool Execute(ref ExecutionContext p_Context, TextWriter p_Writer)
        {
            if (string.IsNullOrWhiteSpace(Scenario))
            {
                p_Writer.WriteLine("The specified scenario name is invalid.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(Name))
            {
                p_Writer.WriteLine("The specified bundle name is invalid.");
                return false;
            }

            ((BundleBuildingContext)p_Context).AddScenarioBundle(Scenario, Name);

            return true;
        }
    }
}
