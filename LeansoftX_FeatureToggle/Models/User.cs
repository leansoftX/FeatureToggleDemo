using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeansoftX_FeatureToggle.Models
{
    public class User
    {
        public string Name;

    }

    public class Users
    {
        public IList<User> users;
        public Users()
        {
            users = new List<User>
            {
                new User { Name = "jackyzhou" },
                new User { Name = "leixu" },
                new User { Name = "user01" },
                new User { Name = "user02" }
            };
        }
        public User GetUser()
        {
            return users.RandomElement();
        }
    }

    public static class CollectionExtension
    {
        private static Random rng = new Random();

        public static T RandomElement<T>(this IList<T> list)
        {
            return list[rng.Next(list.Count)];
        }

        public static T RandomElement<T>(this T[] array)
        {
            return array[rng.Next(array.Length)];
        }
    }
}
