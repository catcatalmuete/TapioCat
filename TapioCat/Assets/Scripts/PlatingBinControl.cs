using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatingBinControl : MonoBehaviour
{
    // TODO: make order deliverable
    // TODO: make cups dispense

    /*****************
    Goes on all ice/hot bin objects
    Eventually deliver the order to customer
    *****************/

    public GameObject thisCup;

    private void Start() {
        thisCup.SetActive(false);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player")){
            if (GamePlay.plate1Cup == "none"){
                thisCup.SetActive(true);
                GamePlay.plate1Cup = "empty";
            }
        }
    }
}
