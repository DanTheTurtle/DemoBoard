using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class hideOnStart : MonoBehaviour
{
    // Start is called before the first frame update
    CanvasRenderer canvasRenderer;
    private float startx;
    private float starty;
    private bool hidden = false;
    public bool hide = true;
    public hideOnStart(){
    }
        void Start()
        {
            canvasRenderer = gameObject.GetComponent<CanvasRenderer>();
            startx = transform.position.x;
            starty = transform.position.y;
            if(hide)
                Hide();
        }

    // Update is called once per frame
        void Update()
        {
        
        }
        public void UnHide()
        {
            hidden = false;
            transform.position = new Vector3(startx,starty,0);
        }
        public void Hide()
        {
            hidden = true;
            transform.position = new Vector3(4000,4000,0);
        }
        public void ToggleHide()
        {
            if(hidden)
                UnHide();
            else    
                Hide();
        }
}
