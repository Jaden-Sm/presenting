using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FCammera : MonoBehaviour
{
    public Transform player;
    void Update()
    {
        transform.position = new Vector3(player.transform.position.x, player.transform.position.y, -10);
    }
}
