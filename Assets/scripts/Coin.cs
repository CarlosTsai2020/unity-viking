using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public float RotateSpeed = 90f;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name != "Viking")
        {
            return;
        }
        
        Destroy(gameObject);
        gu.AddCollectAmount();
    }

    // Start is called before the first frame update
    GameUI gu;

    void Start()
    {
        gu = GameObject.FindObjectOfType<GameUI>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, RotateSpeed * Time.deltaTime, Time.deltaTime);
    }
}
