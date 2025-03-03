using UnityEngine;
using System.Collections;


public class gate : MonoBehaviour
{
    public static int gatehealt = 10;
    public static int gatedamage = 0;
    public static bool defeat = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (gatedamage > 0)
        {
            TakeDamage(12);
            gatedamage -= 1;
        }
    }
    public void TakeDamage(int damageAmount)
    {
        gatehealt -= damageAmount;
        if (gatehealt < 0)
        {
            death();
            defeat = true;
        }
    }
    private void death()
    {
        Destroy(gameObject);
    }
}
    
