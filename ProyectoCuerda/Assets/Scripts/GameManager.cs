using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private GameObject palancaPrefab;

    [SerializeField]
    private GameObject playerPrefab;

    [SerializeField]
    private GameObject puertaPrefab;

    [SerializeField]
    private MovingPlatform plataformaMovil;

    private void Update()
    {
        ActivarPalanca();
        ActivarPalancaPlataformas();
    }


    private void ActivarPalanca()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            puertaPrefab.SetActive(false);
            Debug.Log("Palanca activada");
        }
    }

    private void ActivarPalancaPlataformas()
{
    if (Input.GetKeyDown(KeyCode.R))
    {
        plataformaMovil.Activate();
        Debug.Log("Plataforma activada");
    }
} 
}
