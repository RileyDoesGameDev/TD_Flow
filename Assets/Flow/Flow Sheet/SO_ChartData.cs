using UnityEngine;

[CreateAssetMenu(fileName = "SO_ChartData", menuName = "Scriptable Objects/SO_ChartData")]
public class SO_ChartData : ScriptableObject
{


    [SerializeField]
    public int[,] Set1_5x5 = new int[5, 5]
    {
        {1,0,1,0,0},
        {0,0,0,0,0},
        {0,0,0,0,0},
        {1,0,1,0,0},
        {0,0,0,0,0}
    };
    [SerializeField] int[,] Set2_5x5 = new int[5,5] ;
    [SerializeField] int[,] Set3_5x5 = new int[5,5] ;
    [SerializeField] int[,] Set4_5x5 = new int[5,5] ;
    [SerializeField] int[,] Set5_5x5 = new int[5,5] ;
    [SerializeField] int[,] Set6_5x5 = new int[5,5] ;
    
}
