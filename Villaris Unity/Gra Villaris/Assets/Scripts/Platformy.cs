using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platformy : MonoBehaviour
{
    public GameObject player;
    private Vector3 posA;
    private Vector3 posB;
    private Vector3 nextpos;
    [SerializeField]
    private float speed;
    [SerializeField]
    private Transform plat;
    [SerializeField]
    private Transform transformB;
    // Start is called before the first frame update
    void Start()
    {
        posA = plat.localPosition;
        posB = transformB.localPosition;
        nextpos = posB;
    }

    // Update is called once per frame
    void Update()
    {
        Movee();  
    }
    private void Movee()
    {
        plat.localPosition = Vector3.MoveTowards(plat.localPosition, nextpos, speed * Time.deltaTime);
        if (Vector3.Distance(plat.localPosition, nextpos) <= 0.1)
        {
            ChangeDestination();
        }
    }
    private void ChangeDestination()
    {
        nextpos = nextpos != posA ? posA : posB;
    }
    private void OnDrawGizmos()
    {
        Gizmos.DrawLine(plat.position, transformB.position);
    }
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("platformy"))
        {
            player.transform.parent = null;
        }
    }
}
