using System.Collections.Generic;
using UnityEngine;

public class ChartDataStorage 
{
    private Dictionary<int, int[,]> ChartDataList;
    private Dictionary<int, int[,]> ChartDataSolutionList;
    SO_ChartData ChartData;


    public (int[,], int[,]) GenerateRandomPattern()
    {
        ChartDataList = new Dictionary<int, int[,]>();
        ChartDataSolutionList = new Dictionary<int, int[,]>();

        ChartDataList.Add(1, ChartData.Set1_5x5);
        ChartDataList.Add(2, ChartData.Set2_5x5);
        ChartDataList.Add(3, ChartData.Set3_5x5);
        ChartDataList.Add(4, ChartData.Set4_5x5);
        ChartDataList.Add(5, ChartData.Set5_5x5);
        ChartDataList.Add(6, ChartData.Set6_5x5);

        ChartDataSolutionList.Add(1, ChartData.Set1_5x5_Solution);
        ChartDataSolutionList.Add(2, ChartData.Set2_5x5_Solution);
        ChartDataSolutionList.Add(3, ChartData.Set3_5x5_Solution);
        ChartDataSolutionList.Add(4, ChartData.Set4_5x5_Solution);
        ChartDataSolutionList.Add(5, ChartData.Set5_5x5_Solution);
        ChartDataSolutionList.Add(6, ChartData.Set6_5x5_Solution);

        int rNum = Random.Range(1, ChartDataList.Count);
        return (ChartDataList[rNum], ChartDataSolutionList[rNum]);
    }





    
}
