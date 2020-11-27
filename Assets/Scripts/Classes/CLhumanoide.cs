using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Je crée une classe Humanoide utilisable par tous avec son constructeur pour ne jamais travailler sur la classe via un autre script.

public class CLhumanoide
{
    public string nomEntite;
    public int vieEntite;
    public int degatsEntite;
    public float vitesseEntite;

    public CLhumanoide(string nomEntite, int vieEntite, int degatsEntite, float vitesseEntite)
    {
        this.nomEntite = nomEntite;
        this.vieEntite = vieEntite;
        this.degatsEntite = degatsEntite;
        this.vitesseEntite = vitesseEntite;
    }
}
