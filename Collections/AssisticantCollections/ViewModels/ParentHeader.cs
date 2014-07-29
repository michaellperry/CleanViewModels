using AssisticantCollections.Models;

namespace AssisticantCollections.ViewModels
{
    public class ParentHeader
    {
        private readonly Item _item;

        public ParentHeader(Item item)
        {
            _item = item;            
        }

        public string Name
        {
            get { return _item.Name; }
        }
    }
}
