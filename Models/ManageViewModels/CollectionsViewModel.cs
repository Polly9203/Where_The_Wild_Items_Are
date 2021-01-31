using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace Where_The_Wild_Items_Are.Models.ManageViewModels
{
    public class CollectionsViewModel
    {
        public string UserName { get; set; }
        public List<Collection> UserCollections { get; set; }

        public CollectionsViewModel(string userName, List<Collection> userCollections)
        {
            UserName = userName;
            UserCollections = userCollections;
        }
    }
}
