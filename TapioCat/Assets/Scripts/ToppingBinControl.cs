using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToppingBinControl : MonoBehaviour
{
    /*************
    Goes on all topping bin objects
    Move topping to plating station
    *************/

    public GameObject toppingPlating;
    
    public Transform iceToppingSP;
    public Transform hotToppingSP;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player")){
            if (GamePlay.plate1Cup == "tea"){       
                Instantiate(toppingPlating, iceToppingSP.position, toppingPlating.transform.rotation); 
                GamePlay.plate1Cup = "full";
                if (gameObject.CompareTag("1")){
                    GamePlay.plate1Topping = 1;
                } else if (gameObject.CompareTag("2")){
                    GamePlay.plate1Topping = 2;
                } else if (gameObject.CompareTag("3")){
                    GamePlay.plate1Topping = 3;
                }
            }
        }        
    }
}
