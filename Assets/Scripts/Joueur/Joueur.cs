using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Je crée un nouvel objet pour mon joueur du type de la classe 'CLhumanoide'

public class Joueur : MonoBehaviour
{
    public CLhumanoide joueur;

    private void Awake()
    {
        joueur = new CLhumanoide("Joueur", 100, 10, 8f);
    }
}
