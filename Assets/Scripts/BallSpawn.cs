using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BallSpawn : MonoBehaviour
{
    // Start is called before the first frame update
    public List<GameObject> prefabs_ball;
    public Vector3 originalPoint = new Vector3(0,9,5.65f);
    public float interval = 3f;
    private float coolDown = 0f;
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        coolDown -= Time.deltaTime;
        if(coolDown <= 0) {
            coolDown = interval;
            SpawnBall();
        }
    }

    private void SpawnBall() {
        GameObject ball = prefabs_ball[0];
        float gw = GameManager.Instance.gameWidth;
        float off = GameManager.Instance.offset;
        float rand = Random.Range((-gw/2)+off, (gw/2)+off);
        
        Vector3 positionBall = originalPoint + new Vector3(rand, 0, 0);
        Quaternion rotation = ball.transform.rotation;
        Instantiate(ball, positionBall, rotation);
    }
}
