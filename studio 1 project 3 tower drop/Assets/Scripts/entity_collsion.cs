using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class entity_collsion : AI_pathing
{
    public int entity_index;
    public AI_pathing AI_P;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "wepon")
        {
            
            AI_P.entitys.RemoveAt(entity_index);
            GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;
            Destroy(gameObject.GetComponent<BoxCollider>());
            
        }
    }
}
