using TMPro;
using UnityEngine;

public class CompteurDePiece : MonoBehaviour
{
    [SerializeField, Tooltip("texte du compteur de pièces")] private TMP_Text compteur;
    [SerializeField, Tooltip("l'objet boule")] private Boule boule;

    private void Update()
    {
        compteur.text = "Nombre de Pièces : " + boule.GetNbPieces().ToString();
    }
}
