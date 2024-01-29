using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BucketController : MonoBehaviour
{
    public string msg = "Hello, from: ";
    public float speed = 15f;

    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log(msg + gameObject.name);
    }

    // Update is called once per frame
    void Update()
    {
        float gw = GameManager.Instance.gameWidth;
        float off = GameManager.Instance.offset;
        bool flagLeft = Input.GetKey(KeyCode.LeftArrow) | Input.GetKey(KeyCode.A);
        bool flagRight = Input.GetKey(KeyCode.RightArrow) | Input.GetKey(KeyCode.D);
        float movement = 0f;

        if(flagLeft == flagRight) {
            return;
        }

        if(flagRight) {
            if(transform.position.x <= (gw/2)+off) {
                movement = speed * Time.deltaTime;
            }
        } else {
            if(transform.position.x >= (-gw/2)+off) {
                movement = (-1) * speed * Time.deltaTime;
            }
        }
        transform.position += new Vector3(movement, 0, 0); 
    }
}
