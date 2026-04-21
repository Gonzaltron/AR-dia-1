using UnityEngine;
using TMPro;
using UnityEngine.XR.ARFoundation.Samples;
using UnityEngine.UI;
using UnityEngine.XR.ARFoundation;

public class GameManager : MonoBehaviour
{
    [SerializeField] TMP_Text counterText;
    [SerializeField] PlaceOnPlane placeOnPlane;
    [SerializeField] GameObject prefab1;
    [SerializeField] GameObject prefab2;
    [SerializeField] TMP_Dropdown dropdown;
    [SerializeField] ARPlaneManager trackables;
    int counter = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        counterText.text = "Numero de planos: " + counter.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        counter = trackables.trackables.count;
        counterText.text = "Numero de planos: " + counter.ToString();
    }

    public void ChangePrefab()
    {
        if (dropdown.value == 0)
        {
            placeOnPlane.placedPrefab = prefab1;
            Debug.Log("1");
        }
        else if (dropdown.value == 1)
        {
            placeOnPlane.placedPrefab = prefab2;
            Debug.Log("2");
        }
    }
}
