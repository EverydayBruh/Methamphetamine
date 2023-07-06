using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemovePlateScript : MonoBehaviour
{
    public GameObject Slime;
    public float RemoveHeight = 4;
    // Start is called before the first frame update
    void Start()
    {
        Slime = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if((Slime.transform.position.y - transform.position.y) > RemoveHeight)
        {
            Destroy(gameObject);
        }
    }
}

