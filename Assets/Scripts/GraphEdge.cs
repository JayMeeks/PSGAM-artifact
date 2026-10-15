using UnityEngine;

public class GraphEdge
{
    public GraphNode node1 { get; }
    public GraphNode node2 { get; }

    public GraphEdge(GraphNode node1, GraphNode node2)
    {
        this.node1 = node1;
        this.node2 = node2;
    }
}
