using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerItem : MonoBehaviour
{
    [SerializeField] int nItems;
    [SerializeField] TMP_Text txtItems;
    // Start is called before the first frame update
    void Start()
    {
        txtItems.text = "0";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public  void SumaItems(int items) {
        nItems +=  items;
        txtItems.text = nItems.ToString();
    }
}