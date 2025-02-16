using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menufunctions : MonoBehaviour
{
    [SerializeField] private Manager manager;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void toggleRenderer()
    {
        if(this.gameObject.GetComponent<SpriteRenderer>().enabled)
            this.gameObject.GetComponent<SpriteRenderer>().enabled = false;
        else
            this.gameObject.GetComponent<SpriteRenderer>().enabled = true;
    }
    public void loadMainMenuFront()
    {
        Manager.loadMainMenuFront();
    }
}
