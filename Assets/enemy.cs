using UnityEngine;
using System.Collections;

public class enemy : MonoBehaviour {

    public GameObject explosion;

    void OnTriggerEnter(Collider RollerBall)
    {
        Debug.Log("HELP");
        GameObject expl = Instantiate(explosion, transform.position, Quaternion.identity) as GameObject;
        
        Destroy(RollerBall.gameObject);
        Destroy(expl, 3);
        Debug.Log("HELP");
    }
	
}
