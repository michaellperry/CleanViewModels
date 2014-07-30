using AssisticantCollections.Models;
using System;

namespace AssisticantCollections.ViewModels
{
    public interface IParentHeader
    {
        Item Item { get; }
        string Name { get; }
    }
}
