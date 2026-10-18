using System.Numerics;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    public GameObject player;
    private UnityEngine.Vector3 offset = new UnityEngine.Vector3(0,6,-9);
    void LateUpdate()
    {

        transform.position = player.transform.position + offset;
    }
}
