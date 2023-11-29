
using System.Data;
using SyncroSim.Core;

namespace LinkModels
{
    public class Main : Transformer
    {
        public override void Transform()
        {
            DataRow dr1 = this.ResultScenario.GetDataSheet("dgsim_RunControl").GetDataRow();
            DataRow dr2 = this.ResultScenario.GetDataSheet("demosales_RunControl").GetDataRow();

            dr1["MinimumIteration"] = dr2["MinimumIteration"];
            dr1["MaximumIteration"] = dr2["MaximumIteration"];
            dr1["MinimumTimestep"] = dr2["MinimumTimestep"];
            dr1["MaximumTimestep"] = dr2["MaximumTimestep"];
        }
    }
}
