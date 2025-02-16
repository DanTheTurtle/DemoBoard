using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scrollerScript : MonoBehaviour
{
    public GameObject uback;
    public GameObject lback;
    public GameObject arms;
    public GameObject legs;
    private GameObject currentScroll;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void loadUBack(){

        // Set its local position after parenting
        uback.transform.SetSiblingIndex(1);
    }
    public void loadLBack(){
        // Set its local position after parenting
        lback.transform.SetSiblingIndex(1);
        }
    public void loadArms(){
        arms.transform.SetSiblingIndex(1);
        }
    public void loadLegs(){
        legs.transform.SetSiblingIndex(1);
        }

    // Update is called once per frame
    void Update()
    {
        
    }
}
