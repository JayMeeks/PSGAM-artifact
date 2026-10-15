using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;

public class Graph : MonoBehaviour
{
    List<GraphEdge> edges = new List<GraphEdge>();
    List<GraphNode> nodes = new List<GraphNode>();

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        createGraph();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void createGraph()
    {
        GraphNode node1 = new GraphNode(new Vector3(0, 0, 0));
        GraphNode node2 = new GraphNode(new Vector3(1, 0, 1));

        GraphEdge edge1 = new GraphEdge(node1, node2);

        node1.addConnectingEdge(edge1);
        node2.addConnectingEdge(edge1);

        edges.Add(edge1);
        addNewNode(new Vector3(0, 0, 0));
        addNewNode(new Vector3(1, 0, 1));

        Debug.Log(edges[0].node2.position);
    }

    public void addNewNode(Vector3 newNodePosition)
    {
        for (int i = 0; i < nodes.Count; i++)
        {
            if (nodes[i].position == newNodePosition)
            {
                Debug.Log("node already exists");
                break;
            }
        }
        GraphNode newNode = new GraphNode(newNodePosition);
        nodes.Add(newNode);
    }
}
