using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Dialog : MonoBehaviour
{
    public GameObject dialogBox;
    public Text dialogText;
    public string dialog;
    public bool playerinRange;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Input.GetKeyDown(KeyCode.O) &&
        if ( playerinRange)
        {
            if (dialogBox.activeInHierarchy)
           // {
             //   dialogBox.SetActive(false);
            //}
            //else
            {
                dialogBox.SetActive(true);
                dialogText.text = dialog;
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D mmm)
    {
        if (mmm.CompareTag("Player"))
        {
            playerinRange = true;
            dialogBox.SetActive(true);
        }
    }
    private void OnTriggerExit2D(Collider2D mmm)
    {
        if (mmm.CompareTag("Player"))
        {
            playerinRange = false;
            dialogBox.SetActive(false);
        }
    }

}
