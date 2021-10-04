using System.Collections;
using System.Collections.Generic;
using Kuhpik;
using UnityEngine;
using UnityEngine.UI;

public class CoinController : GameSystem, IIniting
{
    [SerializeField] private Text textCoins;

    private int countCoins;
    
    // Start is called before the first frame update
    void IIniting.OnInit()
    {
        countCoins = 0;
        textCoins.text = "COINS:" + countCoins;
    }

    public void UpdateCoins(Vector3 pos)
    {
        countCoins++;
        textCoins.text = "COINS:" + countCoins;
    }

    
}
