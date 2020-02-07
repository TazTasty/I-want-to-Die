using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonController : MonoBehaviour
{

    private SpriteRenderer theSR;
    public Sprite defaultImage;
    public Sprite pressedImage;
    //public KeyCode;

    void Start()
    {
        theSR = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Keypad0))
        {
            theSR.sprite = pressedImage;
        }

        if (Input.GetKeyUp(KeyCode.Keypad0))
        {
            theSR.sprite = defaultImage;
        }
    }
}
