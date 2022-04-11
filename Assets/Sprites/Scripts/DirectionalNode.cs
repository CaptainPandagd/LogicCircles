using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Directiional : MonoBehaviour
{
    public Sprite none;
    public Sprite left;
    public Sprite right;
    public string Current;
    SpriteRenderer sr;

    // Start is called before the first frame update
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        sr.sprite = left;
        SwitchSprite();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SwitchSprite()
    {
        if(Current == "left")
        {
            Debug.Log("Choose Left");
            sr.sprite = left;
        }
        else if(Current == "right")
        {
            Debug.Log("Choose Right");
            sr.sprite = right;
        }
        else
        {
            Debug.Log("Choose None");
            sr.sprite = none;
        }
    }
}
