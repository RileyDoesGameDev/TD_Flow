using System.Net.NetworkInformation;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour
{
    public bool hasPin;
    public Color pinColor;
    public GameObject pinPrefab;
    private SpriteRenderer spriteRenderer;
    private SpriteRenderer pinRenderer;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        if (hasPin)
        {
            var spawnedPin = Instantiate(pinPrefab, transform);
            spawnedPin.transform.position = transform.position;
            pinRenderer = spawnedPin.GetComponent<SpriteRenderer>();
            pinRenderer.color = pinColor;

        }
        

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseOver()
    {
        
    }


}
