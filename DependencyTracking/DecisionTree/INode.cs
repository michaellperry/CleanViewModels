using System.Collections.Generic;

namespace DecisionTree
{
    public interface INode
    {
        float ExpectedValue { get; }
        IEnumerable<INode> Children { get; }
    }
}
