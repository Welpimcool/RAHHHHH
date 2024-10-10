using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class attack : MonoBehaviour
{
    private BoxCollider hitbox;

    // Start is called before the first frame update
    void Start()
    {
        hitbox = GetComponent<BoxCollider>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("Space"))
        {

        }
    }
}
