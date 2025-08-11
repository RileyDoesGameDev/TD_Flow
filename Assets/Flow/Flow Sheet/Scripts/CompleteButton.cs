using UnityEngine;

public class CompleteButton : MonoBehaviour
{
    public SO_ChartData ChartData;
    public FlowGrid flowGrid;


    
    void Start()
    {
       

      
        
    }

    
    void Update()
    {
        
    }

    private void OnMouseEnter()
    {

       
       
  
        
    }

    void OnMouseDown()
    {
        if (flowGrid.CheckGridValid(flowGrid.ReadFlowChart(), flowGrid.FlowSolution))
        {
            Destroy(transform.parent.gameObject);
        }
        else
        {
            flowGrid.ResetGrid();
        }
    }
}
