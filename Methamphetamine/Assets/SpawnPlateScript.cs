using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPlateScript : MonoBehaviour
{
    public float PlateHeight = 10;
    public GameObject Plate;
    public float StartPlateHeight = 3.17f;

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(Plate, transform.position + Vector3.down * StartPlateHeight, transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
      // Instantiate(Plate, transform.position + Vector3.up * PlateHeight, transform.rotation); 
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(Plate);
        Instantiate(Plate, transform.position + Vector3.up * PlateHeight, transform.rotation);
    }

}
