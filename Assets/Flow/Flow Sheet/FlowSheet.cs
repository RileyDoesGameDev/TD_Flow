using NUnit.Framework;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class FlowSheet : MonoBehaviour
{
    public SO_FlowSheet data;

    private int[,] flowGird;

   // List<Vector2> FlowGrid = new List<Vector2>();

   
   
    void Start()
    {
        gameObject.transform.localScale = Vector3.one * data.Scale;
        flowGird = new int[data.CellCount,data.CellCount];
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnPostRender()
    {


        
    }
}
