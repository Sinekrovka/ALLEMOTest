using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    [SerializeField] private CoinController coins;

    private void OnTriggerEnter(Collider other)
    {
        if (!other.transform.name.Contains("Cube") || !other.transform.name.Contains("Cube"))
        {
            coins.UpdateCoins(transform.position);
            GetComponent<MeshRenderer>().enabled = false;
            GetComponent<Collider>().enabled = false;
        }
    }
}
