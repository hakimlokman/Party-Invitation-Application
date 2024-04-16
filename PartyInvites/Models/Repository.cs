using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PartyInvites.Models
{
    public class Repository
    {
        private static Dictionary<string, GuestRseponse> response;

        static Repository()
        {
            response = new Dictionary<string, GuestRseponse>();
            response.Add("Shovon", new GuestRseponse { Name = "Shovon", Email = "shovon@gmail.com", WillAttend = true });
            response.Add("Johurul", new GuestRseponse { Name = "Johurul", Email = "johurul@gmail.com", WillAttend = true });
            response.Add("Rakib", new GuestRseponse { Name = "Rakib", Email = "rakib@gmail.com", WillAttend = true });

        }
        public static void Add(GuestRseponse newResponse)
        {
            string key = newResponse.Name.ToLowerInvariant();
            if(response.ContainsKey(key))
            {
                response[key] = newResponse;
            }
            else
            {
                response.Add(key, newResponse);
            }
        }
        public static IEnumerable<GuestRseponse> Rseponses {
            get { return response.Values;}
                }
    }
}