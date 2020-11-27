using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interaction : MonoBehaviour
{
    [SerializeField] private float rayonInteraction;
    [SerializeField] private Transform joueur;
    public bool peutInteragir = false;


    private void Update()
    {
        if(Vector3.Distance(this.transform.position, joueur.position) <= rayonInteraction)
        {
            peutInteragir = true;
            Interagir();
        }
        else { peutInteragir = false; }
    }

    public virtual void Interagir()
    {
        Debug.Log("Interaction avec " + joueur.name);
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.cyan;
        Gizmos.DrawWireSphere(this.transform.position, rayonInteraction);
    }
}
