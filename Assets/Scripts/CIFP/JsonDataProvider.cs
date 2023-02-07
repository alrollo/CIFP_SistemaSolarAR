using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using UnityEngine;


namespace Cifp
{
    public class JsonDataProvider : IDataProvider
    {
        public string GetInformacion()
        {
            var _json = Resources.Load("info").ToString();
            var infoJSON = JsonUtility.FromJson<InfoJSON>(_json);
            return infoJSON.Info;
        }

        public List<Planeta> GetPlanetas()
        {
            var _json = Resources.Load("planetas").ToString();
            Planeta[] infoJSON = JsonHelper.GetJsonArray<Planeta>(_json);
            return infoJSON.ToList();
        }
    }
}