
using System.Collections.Generic;

namespace Cifp {
    public interface IDataProvider
    {
        public string GetInformacion();
        public List<Planeta> GetPlanetas();
    }
}