using UnityEngine;
using UnityEngine.UI;

public class IdleMobile : MonoBehaviour
{
    public Text coinsText;
    public double coins;

    public void Start()
    {
        coins = 0;
    }

    public void Update()
    {
        coinsText.text = "Coins: " + coins;
    }

    public void Click()
    {
        coins += 1;
    }

}
