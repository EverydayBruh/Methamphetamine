using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SpawnPlateScript : MonoBehaviour
{
    public float PlateHeight = 10;
    public GameObject Plate;
    public float hight_offset = 10;
    public float spawn_radius = 100;
    public float StartPlateHeight = 3.17f;
    public float randomness = 1;

    private float max_hight = 0;
    private float next_spawn;
    private int k = 0;
    private float timer;
    private float spawntime = 0;

    // Start is called before the first frame update
    void Start()
    {
        next_spawn = StartPlateHeight;
        SpawnPlate();
    }

    // Update is called once per frame
    void Update()
    {
        max_hight = Mathf.Max(max_hight, transform.position.y + spawn_radius);
        if(next_spawn < max_hight )
        {
            SpawnPlate();
        }
      // Instantiate(Plate, transform.position + Vector3.up * PlateHeight, transform.rotation); 
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(collision.gameObject);
    }
    
    void SpawnPlate()
    {
        Instantiate(Plate,new Vector3(transform.position.x, next_spawn + Random.Range(-randomness, randomness), -0.8802159f), transform.rotation);
        next_spawn += hight_offset;
        timer = 0;
    }

}
