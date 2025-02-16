using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class hideOnStartContent : MonoBehaviour
{
    // Start is called before the first frame update
    CanvasRenderer canvasRenderer;
    public GameObject content;
    private Button[] buttons;
    public hideOnStartContent(){
    }
    void Start()
    {
        canvasRenderer = gameObject.GetComponent<CanvasRenderer>();
        canvasRenderer.SetAlpha(0);

        buttons = content.GetComponents<Button>();
        Hide();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void UnHide()
    {
        canvasRenderer.SetAlpha(1);
        foreach (Button b in buttons)
        {
            b.interactable = true;
        }
    }
    private void Hide()
    {
        canvasRenderer.SetAlpha(0);
        foreach (Button b in buttons)
        {
            b.interactable = false;
        }
    }
}
