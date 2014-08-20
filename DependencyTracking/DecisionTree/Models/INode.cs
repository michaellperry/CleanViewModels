using System.Collections.Generic;

namespace DecisionTree.Models
{
    public interface INode
    {
        float ExpectedValue { get; }
        IEnumerable<IPath> Children { get; }
    }
}
