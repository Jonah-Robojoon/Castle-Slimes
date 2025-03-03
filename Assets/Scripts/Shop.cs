using UnityEngine;
using UnityEngine.UI;

public class Shop : MonoBehaviour
{
    public int Coin = Slime.coin;
    public Text Coin_Text;
    public Text Selected_Weapon;
    public static string Weapon = "Sword";

    void Start()
    {
        
    }

    public void BuyTest()
    {
        if (Slime.coin >= 100)
        {
            Coin -= 100;
            Coin_Text.text = Coin.ToString();

            Weapon = "TestWeapon";
            Selected_Weapon.text = Weapon;

        }
        else
        {
            print("Not enough Coins");
        }
    }

}
