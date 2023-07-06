using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserScript : MonoBehaviour
{
    public AnimationCurve curve;
    public float time_multiplyer;
    public SpriteRenderer spriteRenderer;
    public BoxCollider2D collider;
    private float timer;
    private float cycletime;
    // Start is called before the first frame update
    void Start()
    {
        cycletime = 1;
        Debug.Log(cycletime);
    }

    // Update is called once per frame
    void Update()
    {
        timer = (timer + Time.deltaTime*time_multiplyer)%cycletime;
        Debug.Log(curve.Evaluate(timer));
        if (curve.Evaluate(timer) > 0.5)
        { LaserOn(); } else { LaserOff(); }
    }

    void LaserOn()
    {
        //Debug.Log("LaserOn");
        spriteRenderer.enabled = true;
        collider.enabled = true;
    }

    void LaserOff()
    {
        //Debug.Log("LaserOff");
        spriteRenderer.enabled = false;
        collider.enabled = false;
    }
}
