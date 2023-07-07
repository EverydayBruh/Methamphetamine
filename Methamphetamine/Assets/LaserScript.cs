using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserScript : MonoBehaviour
{
    public AnimationCurve[] curves;
    private AnimationCurve curve;
    public float time_multiplyer;
    public SpriteRenderer spriteRenderer;
    public BoxCollider2D collider;

    private GameObject player;
    private float timer;
    private float cycletime;
    private SlimeJump player_script;
    // Start is called before the first frame update
    void Start()
    {
        cycletime = 1;
        Debug.Log(cycletime);
        curve = curves[Random.Range(0, curves.Length)];
        player_script = GameObject.FindGameObjectWithTag("Player").GetComponent<SlimeJump>();
    }

    // Update is called once per frame
    void Update()
    {
        timer = (timer + Time.deltaTime*time_multiplyer)%cycletime;
       // Debug.Log(curve.Evaluate(timer));
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

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            player_script.death();
        }
    }
}
