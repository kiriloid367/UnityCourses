using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private float speed = 3f;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
           
        if (Input.GetKey(KeyCode.W))
        {
            if(transform.position.z<=-1)
            Move(Vector3.forward);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            if (transform.position.z >= -19)
                Move(Vector3.back);
        }
        if (Input.GetKey(KeyCode.A))
        {
            if (transform.position.x >= -9)
                Move(Vector3.left);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            if (transform.position.x <= 8.9)
                Move(Vector3.right);
        }

    }

    private void Move(Vector3 direction)
    {
        transform.Translate(direction * speed * Time.deltaTime);

    }

}
