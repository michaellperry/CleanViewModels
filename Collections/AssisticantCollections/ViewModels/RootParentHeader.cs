using AssisticantCollections.Models;

namespace AssisticantCollections.ViewModels
{
    public class RootParentHeader : IParentHeader
    {
        public Item Item
        {
            get { return null; }
        }

        public string Name
        {
            get { return "<Root>"; }
        }

        public override bool Equals(object obj)
        {
            return obj is RootParentHeader;
        }

        public override int GetHashCode()
        {
            return 0;
        }
    }
}
