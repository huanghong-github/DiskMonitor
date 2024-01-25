using Newtonsoft.Json.Linq;
using System.IO;

namespace DiskMonitor
{
    internal class JsonUtil
    {
        private string saveFile = "config.json";
        private JObject jobj;
        private static JsonUtil jsonUtil;
        private JsonUtil(string dir)
        {
            jobj = new JObject();
            saveFile = Path.Combine(dir, saveFile);
            if (File.Exists(saveFile))
            {
                jobj.Merge(Read());
            }
        }
        internal static JsonUtil GetSingleton(string dir)
        {
            if (jsonUtil is null)
            {
                jsonUtil = new JsonUtil(dir);
            }
            return jsonUtil;
        }
        internal static JsonUtil GetSingleton()
        {
            return jsonUtil;
        }

        internal JObject Read()
        {
            string json = File.ReadAllText(saveFile);
            return JObject.Parse(json);
        }

        internal void Write()
        {
            File.WriteAllText(saveFile, jobj.ToString());
        }

        internal bool Contains(string key)
        {
            return jobj.ContainsKey(key);
        }

        internal JToken Get(string key)
        {
            return jobj.GetValue(key);
        }

        internal void SetAndSave(JObject obj)
        {
            jobj.Merge(obj);
            Write();
        }
    }
}
