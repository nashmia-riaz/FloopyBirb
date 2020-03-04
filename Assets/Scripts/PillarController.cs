using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PillarController : MonoBehaviour
{
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position - new Vector3(speed, 0, 0);
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        Destroy(this.gameObject);
    }
}
