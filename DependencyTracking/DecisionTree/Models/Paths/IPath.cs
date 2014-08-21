using DecisionTree.Models.Nodes;

namespace DecisionTree.Models.Paths
{
    public interface IPath
    {
        Node Child { get; }
    }
}
