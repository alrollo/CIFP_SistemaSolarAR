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
            string path = "Assets/Data/info.json";

            if (File.Exists(path) == false)
                return "File not found";

            StreamReader reader = new StreamReader(path);
            var _json = reader.ReadToEnd();
            reader.Close();

            var infoJSON = JsonUtility.FromJson<InfoJSON>(_json);
            return infoJSON.Info;
        }

        public List<Planeta> GetPlanetas()
        {
            string path = "Assets/Data/planetas.json";

            if (File.Exists(path) == false)
                return null;

            StreamReader reader = new StreamReader(path);
            var _json = reader.ReadToEnd();
            reader.Close();



            Planeta[] infoJSON = JsonHelper.GetJsonArray<Planeta>(_json);
            return infoJSON.ToList();
        }
    }
}