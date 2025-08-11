using System.Net.NetworkInformation;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour
{
    public bool hasPin;
    public Color pinColor;
    public GameObject pinPrefab;
    public GameObject fillPrefab;
    private SpriteRenderer spriteRenderer;
    private SpriteRenderer pinRenderer;
    private SpriteRenderer filledRenderer;
    public GameObject spawnedFill;
    public GameObject spawnedPin;
    public string tileColor;
   

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        if (hasPin)
        {
            spawnedPin = Instantiate(pinPrefab, transform);
            spawnedPin.transform.position = transform.position;
            pinRenderer = spawnedPin.GetComponent<SpriteRenderer>();
            pinRenderer.color = pinColor;

        }
        else
        {
            spawnedFill = Instantiate(fillPrefab, transform);
            filledRenderer = spawnedFill.GetComponent<SpriteRenderer>();
            //spawnedFill.transform.position = transform.position;
            spawnedFill.transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + -0.1f);
            spawnedFill.SetActive(false);
        }
        

    }


    public void DrawFill(Color Color, string tileColor)
    {
        if (spawnedFill != null)
        {
            filledRenderer.color = Color;
            spawnedFill.SetActive(true);
            this.tileColor = tileColor;
        }
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }




}
