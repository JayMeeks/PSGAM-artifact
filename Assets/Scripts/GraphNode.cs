using UnityEngine;
using System.Collections.Generic;

public class GraphNode
{
    public Vector3 position { get; }

    private List<GraphEdge> connectedEdges = new List<GraphEdge>();

    public GraphNode(Vector3 position)
    {
        this.position = position;
    }

    public void addConnectingEdge(GraphEdge newEdge)
    {
        connectedEdges.Add(newEdge);
    }
}
