using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Backgroundslider : MonoBehaviour
{

    public float speed = 0.1f;

    [SerializeField]
    private Renderer bgRenderer;

    void Start()
    {
        // Call the MethodToCall every 3 seconds, starting after 0 seconds.
        InvokeRepeating("SpeedIncrease", 0f, 10f);
    }

    void Update()
    {
        bgRenderer.material.mainTextureOffset += new Vector2(speed * Time.deltaTime, 0);
    }

    void SpeedIncrease(){
        speed += 0.1f;
    }
}
