using System;
using System.Collections.Generic;
using GMD.THREE_LAYER.Entities;
using GMD.THREE_LAYER.DAL.Interfaces;
using System.IO;
using System.Linq;
using Newtonsoft.Json;

namespace GMD.THREE_LAYER.JsonDAL
{
    public class AwardsJsonDAO : IAwardsDAO
    {
        public string JsonFile = @"C:\papka\Awards.json";

        private void Start()
        {
            if (!File.Exists(JsonFile))
            {
                try
                {
                    File.WriteAllText(JsonFile, "[]");
                }
                catch
                {
                    throw;
                }

            }
        }

        private void RewriteFile(string json)
        {
            File.WriteAllText(JsonFile, json);
        }

        private List<Award> Deserialize()
        {
            Start();
            if (File.Exists(JsonFile))
            {
                List<Award> awards = JsonConvert.DeserializeObject<List<Award>>(File.ReadAllText(JsonFile));
                return awards;
            }
            else
                return null;
        }

        private string Serialize(object users)
        {
            var convertJSON = JsonConvert.SerializeObject(users, Formatting.Indented);
            return convertJSON;
        }

        public void Create(Award award)
        {
            List<Award> awards = Deserialize();

            awards.Add(award);

            var sorted = awards.OrderBy(o => o.Title).ToList();

            RewriteFile(Serialize(sorted));
        }

        public void Delete(Guid id)
        {
            List<Award> awards = Deserialize();
            for (int i = 0; i < awards.Count; ++i)
                if (awards[i].ID == id)
                    awards.RemoveAt(i);

            RewriteFile(Serialize(awards));
        }

        public IEnumerable<Award> GetAll()
        {
            List<Award> awards = Deserialize();
            return awards;
        }

        public void Update(Award award)
        {
            List<Award> awards = Deserialize();
            for (int i = 0; i < awards.Count; ++i)
                if (awards[i].ID == award.ID)
                    awards[i] = award;

            RewriteFile(Serialize(awards));
        }
        public Award GetById(Guid id)
        {
            List<Award> awards = Deserialize();
            Award newAward = new Award();
            for (int i = 0; i < awards.Count; ++i)
                if (awards[i].ID == id)
                    newAward = awards[i];
            return newAward;
        }

    }
}
