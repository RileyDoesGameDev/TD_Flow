using UnityEngine;

[CreateAssetMenu(fileName = "SO_ChartData", menuName = "Scriptable Objects/SO_ChartData")]
public class SO_ChartData : ScriptableObject
{


    [SerializeField]
    public int[,] Set1_5x5 = new int[5, 5]
    {
        {0,0,0,0,1},
        {1,3,0,0,0},
        {2,0,0,2,3},
        {5,4,0,0,0},
        {0,0,0,5,4}
    };

    [SerializeField]
    public int[,] Set1_5x5_Solution = new int[5, 5]
    {
        {1,1,1,1,1},
        {1,3,3,3,3},
        {2,2,2,2,3},
        {5,4,4,4,4},
        {5,5,5,5,4}
    };


    [SerializeField] int[,] Set2_5x5 = new int[5,5] ;
    [SerializeField] int[,] Set3_5x5 = new int[5,5] ;
    [SerializeField] int[,] Set4_5x5 = new int[5,5] ;
    [SerializeField] int[,] Set5_5x5 = new int[5,5] ;
    [SerializeField] int[,] Set6_5x5 = new int[5,5] ;
    
}
