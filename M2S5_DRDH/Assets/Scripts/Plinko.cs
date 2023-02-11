using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plinko : MonoBehaviour
{
    public int score = 0;
    public General gen;
  

    public void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.name == "Pelota")
        {
            score = 100;
            gen.Punt(score);
            Destroy(coll.gameObject);
        }

    }

    // Start is called before the first frame update
    void Start()
    {
        gen = GameObject.Find("Game Manager").GetComponent<General>();
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
