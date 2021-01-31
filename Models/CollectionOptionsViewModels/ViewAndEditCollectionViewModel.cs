using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Where_The_Wild_Items_Are.Models.CollectionOptionsViewModels
{
    public class ViewAndEditCollectionViewModel
    {
        public Collection Item { get; set; }
        public List<Comment> ItemComments { get; set; }

        public ViewAndEditCollectionViewModel(Collection collection, List<Comment> comments)
        {
            Item = collection;
            ItemComments = comments;
        }
    }
}
