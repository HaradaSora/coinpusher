using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinDouw : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
       Destroy(collision.gameObject);
    }
}