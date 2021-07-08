using System;
using System.Collections.Generic;
using GMD.THREE_LAYER.Entities;
using GMD.THREE_LAYER.DAL.Interfaces;
using System.IO;
using System.Linq;
using Newtonsoft.Json;

namespace GMD.THREE_LAYER.JsonDAL
{
    public class UsersJsonDAO : IUsersDAO
    {
        public string JsonFile = @"C:\papka\Users.json";
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

        private List<User> Deserialize()
        {
            Start();
            List<User> users = JsonConvert.DeserializeObject<List<User>>(File.ReadAllText(JsonFile));
            return users;
        }

        private string Serialize(object users)
        {
            var convertJSON = JsonConvert.SerializeObject(users, Formatting.Indented);
            return convertJSON;
        }

        public void Create(User user)
        {
            List<User> users = Deserialize();

            users.Add(user);

            var sorted = users.OrderBy(o => o.Name).ToList();

            RewriteFile(Serialize(sorted));
        }

        public void Delete(Guid id)
        {
            List<User> users = Deserialize();
            for (int i = 0; i < users.Count; ++i)
                if (users[i].ID == id)
                    users.RemoveAt(i);

            RewriteFile(Serialize(users));
        }

        public IEnumerable<User> GetAll()
        {
            List<User> users = Deserialize();
            return users;
        }

        public void Update(User user)
        {
            List<User> users = Deserialize();
            for (int i = 0; i < users.Count; ++i)
                if (users[i].ID == user.ID)
                    users[i] = user;

            RewriteFile(Serialize(users));
        }

        public User GetById(Guid id)
        {
            List<User> users = Deserialize();
            User newUser = new User();
            for (int i = 0; i < users.Count; ++i)
                if (users[i].ID == id)
                    newUser = (users[i]);
            return newUser;

        }
    }
}
