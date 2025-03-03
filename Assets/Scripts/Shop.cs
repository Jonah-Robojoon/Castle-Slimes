using UnityEngine;
using UnityEngine.UI;

public class Shop : MonoBehaviour
{
    public int Coin = Slime.coin;
    
    void Start()
    {
        
    }

    public void BuyTest()
    {
        if (Slime.coin >= 100)
        {
            Coin -= 100
        }
        else
        {
            print("Not enough Coins")
        }
    }

}
