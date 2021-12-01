using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BinControl : MonoBehaviour
{
    public GameObject Obj1C;        // tea 1/topping 1 cooking prefab
    public GameObject Obj1P;        // tea 1/topping 1 plating prefab
    public Transform SP1C;          // tea 1/topping 1 cooking spawn point

    public GameObject Obj2C;        // tea 2/topping2  cooking prefab
    public GameObject Obj2P;        // tea 2/topping 2 plating prefab
    public Transform SP2C;          // tea 2/topping 2 cooking spawn point

    public GameObject Obj3C;        // tea 3/topping 3 cooking prefab
    public GameObject Obj3P;        // tea 3/topping 3 plating prefab
    public Transform SP3C;          // tea 3/topping 3 cooking spawn point

    public Transform SPP1_top;          // plate 1 topping spawn point
    public Transform SPP1_tea;          // plate 1 tea spawn point
    public Transform SPP2_top;          // plate 2 topping spawn point
    public Transform SPP2_tea;          // plate 2 tea spawn point

    void OnTriggerEnter2D(Collider2D other)
    {
        // TODO: implement switch from cooking to full
         if (other.CompareTag("Player")){


             if (gameObject.CompareTag("1")){         // topping 1/tea 1

                // TODO: MAKE SURE THIS DIFFERENTIATES BETWEEN TOPPING AND TEA
                if (GamePlay.topping1Cook == "empty"){          // empty; start cooking
                    Instantiate(Obj1C, SP1C.position, Obj1C.transform.rotation);
                    GamePlay.topping1Cook = "cooking";

                } else if (GamePlay.topping1Cook == "full"){    // full; grab
                    // TODO: grab; add some notif that it is full; MAKE SURE THIS IS RIGHT
                    ObjectType thisObj = gameObject.GetComponent<ObjectType>();
                    // object is tea1
                    if (thisObj.isTea){             
                        if (GamePlay.plate1Tea == "empty"){         // checking plate 1
                            Destroy(Obj1C);                                 // destroy cooking tea 1
                            Instantiate(Obj1P, SPP1_tea.position, Obj1P.transform.rotation);                   // place tea 1 on plate 1
                            GamePlay.plate1Tea = "full";
                            GamePlay.topping1Cook = "empty";
                        } else if (GamePlay.plate2Tea == "empty"){      // checking plate 2
                            Destroy(Obj1C);                                 // destroy cooking tea 1
                            Instantiate(Obj1P, SPP2_tea.position, Obj1P.transform.rotation);                   // place tea 1 on plate 2
                            GamePlay.plate2Tea = "full";
                            GamePlay.topping1Cook = "empty";
                        }   // if neither available, do nothing
                    } 
                    // object is topping1
                    else {
                        if (GamePlay.plate1Topping == "empty"){         // checking plate 1
                            Destroy(Obj1C);                                 // destroy cooking topping 1
                            Instantiate(Obj1P, SPP1_top.position, Obj1P.transform.rotation);                   // place topping 1 on plate 1
                            GamePlay.plate1Topping = "full";
                            GamePlay.topping1Cook = "empty";
                        } else if (GamePlay.plate2Topping == "empty"){  // checking plate 2
                            Destroy(Obj1C);                                 // destroy cooking topping 1
                            Instantiate(Obj1P, SPP2_top.position, Obj1P.transform.rotation);                   // place topping 1 on plate 2
                            GamePlay.plate2Topping = "full";
                            GamePlay.topping1Cook = "empty";
                        }   // if neither available, do nothing
                    }
                }   // cooking; do nothing


             } else if (gameObject.CompareTag("2")){        // Topping 2/tea 2

                if (GamePlay.topping2Cook == "empty"){          // empty; start cooking
                    Instantiate(Obj2C, SP2C.position, Obj2C.transform.rotation);
                    GamePlay.topping2Cook = "cooking";

                } else if (GamePlay.topping2Cook == "full"){    // full; grab
                    // TODO: grab; add some notif that it is full; MAKE SURE THIS IS RIGHT
                    ObjectType thisObj = gameObject.GetComponent<ObjectType>();
                    // object is tea2
                    if (thisObj.isTea){             
                        if (GamePlay.plate1Tea == "empty"){         // checking plate 1
                            Destroy(Obj2C);                                 // destroy cooking tea 2
                            Instantiate(Obj2P, SPP1_tea.position, Obj2P.transform.rotation);                   // place tea 2 on plate 1
                            GamePlay.plate1Tea = "full";
                            GamePlay.topping1Cook = "empty";
                        } else if (GamePlay.plate2Tea == "empty"){      // checking plate 2
                            Destroy(Obj2C);                                 // destroy cooking tea 2
                            Instantiate(Obj2P, SPP2_tea.position, Obj2P.transform.rotation);                   // place tea 2 on plate 2
                            GamePlay.plate2Tea = "full";
                            GamePlay.topping1Cook = "empty";
                        }   // if neither available, do nothing
                    } 
                    // object is topping2
                    else {
                        if (GamePlay.plate1Topping == "empty"){         // checking plate 1
                            Destroy(Obj2C);                                 // destroy cooking topping 2
                            Instantiate(Obj2P, SPP1_top.position, Obj2P.transform.rotation);                   // place topping 2 on plate 1
                            GamePlay.plate1Topping = "full";
                            GamePlay.topping1Cook = "empty";
                        } else if (GamePlay.plate2Topping == "empty"){  // checking plate 2
                            Destroy(Obj2C);                                 // destroy cooking topping 2
                            Instantiate(Obj2P, SPP2_top.position, Obj2P.transform.rotation);                   // place topping 2 on plate 2
                            GamePlay.plate2Topping = "full";
                            GamePlay.topping1Cook = "empty";
                        }   // if neither available, do nothing
                    }
                } 


             } else if (gameObject.CompareTag("3")){        // Topping 3/tea 3

                if (GamePlay.topping3Cook == "empty"){          // empty; start cooking
                    Instantiate(Obj3C, SP3C.position, Obj3C.transform.rotation);
                    GamePlay.topping3Cook = "cooking";

                } else if (GamePlay.topping3Cook == "full"){    // full; grab
                    // TODO: grab; add some notif that it is full; MAKE SURE THIS IS RIGHT
                    ObjectType thisObj = gameObject.GetComponent<ObjectType>();
                    // object is tea3
                    if (thisObj.isTea){             
                        if (GamePlay.plate1Tea == "empty"){         // checking plate 1
                            Destroy(Obj3C);                                 // destroy cooking tea 3
                            Instantiate(Obj3P, SPP1_tea.position, Obj3P.transform.rotation);                   // place tea 3 on plate 1
                            GamePlay.plate1Tea = "full";
                            GamePlay.topping1Cook = "empty";
                        } else if (GamePlay.plate2Tea == "empty"){      // checking plate 2
                            Destroy(Obj3C);                                 // destroy cooking tea 3
                            Instantiate(Obj3P, SPP2_tea.position, Obj3P.transform.rotation);                   // place tea 3 on plate 2
                            GamePlay.plate2Tea = "full";
                            GamePlay.topping1Cook = "empty";
                        }   // if neither available, do nothing
                    } 
                    // object is topping3
                    else {
                        if (GamePlay.plate1Topping == "empty"){         // checking plate 1
                            Destroy(Obj3C);                                 // destroy cooking topping 3
                            Instantiate(Obj3P, SPP1_top.position, Obj3P.transform.rotation);                   // place topping 3 on plate 1
                            GamePlay.plate1Topping = "full";
                        } else if (GamePlay.plate2Topping == "empty"){  // checking plate 2
                            Destroy(Obj3C);                                 // destroy cooking topping 3
                            Instantiate(Obj3P, SPP2_top.position, Obj3P.transform.rotation);                   // place topping 3 on plate 2
                            GamePlay.plate2Topping = "full";
                            GamePlay.topping1Cook = "empty";
                        }   // if neither available, do nothing
                    }
                } 
             }
        }       
    }
}
