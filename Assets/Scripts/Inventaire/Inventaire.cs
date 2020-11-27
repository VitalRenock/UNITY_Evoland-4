using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventaire : MonoBehaviour
{
    #region SINGLETON
    // Création d'une variable SINGLETON du type du script lui-même.
    public static Inventaire instanceInv;

    private void Awake()
    {
        if(instanceInv != null)
        {
            Debug.LogWarning("Trop d'instance trouvée pour" + this.name);
            return;
        }
        // Assignation de la variable SINGLETON au script lui-même.
        instanceInv = this;
    }
    #endregion

    // UI ???
    public delegate void ChangementItem();
    public ChangementItem changementItemCallback;

    public List<SOItem> inventaire = new List<SOItem>();
    public int espaceInv = 20;

    public bool AjoutItem(SOItem item)
    {
        // Si ca n'est pas un item par défaut...
        if(!item.itemParDefaut)
        {
            if(inventaire.Count >= espaceInv)
            {
                Debug.Log("Pas assez d'espace dans l'inventaire!");
                return false;
            }

            inventaire.Add(item);

            // UI ???
            if(changementItemCallback != null) { changementItemCallback.Invoke(); }
            
        }
        return true;
    }

    public void RetraitItem(SOItem item)
    {
        inventaire.Remove(item);

        // UI ???
        if (changementItemCallback != null) { changementItemCallback.Invoke(); }
    }
}
