using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ghost : MonoBehaviour
{
    [SerializeField] private LayerMask playerLayerMask;
    [SerializeField] private float checkRadius = 10f;

    private void Update()
    {
        if (Physics.CheckSphere(transform.position, checkRadius, playerLayerMask))
        {
            Debug.Log("Interacted with player");
            gameObject.SetActive(false);
        }
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawWireSphere(transform.position, checkRadius);
    }
}
