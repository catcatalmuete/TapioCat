using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomerOrder : MonoBehaviour
{
    public GameObject[] temp;
    public GameObject[] teaTypes;
    public GameObject[] toppingTypes;
    public string drinkOrdered;
    public AudioClip coins;
    AudioSource _audioSource;


    // Start is called before the first frame update
    void Start()
    {
        //set up audio
        _audioSource = GetComponent<AudioSource>();

        //set all cup variables to no
        temp[0].SetActive(false);
        temp[1].SetActive(false);
        foreach (GameObject teas in teaTypes){
            teas.SetActive(false);
        }
        foreach (GameObject top in toppingTypes){
            top.SetActive(false);
        }
        
        int ice = Random.Range(0,1);
        int tea = Random.Range(0,2);
        int topping = Random.Range(0,2);
        temp[ice].SetActive(true);
        teaTypes[tea].SetActive(true);
        toppingTypes[topping].SetActive(true);
        drinkOrdered = ice.ToString()+tea.ToString()+topping.ToString();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player")){
            if (GamePlay.pickup == true){ //if the player is "carrying something"
                if (GamePlay.pickedDrink == drinkOrdered){ //if it's the thing we want
                    _audioSource.PlayOneShot(coins);
                    GamePlay.totalScore++;
                    gameObject.SetActive(false); //leave lmao
                }
            }
        }
    }
}
