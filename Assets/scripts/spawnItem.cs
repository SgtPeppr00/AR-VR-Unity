using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.InputSystem;

public class spawnItem : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField] public GameObject table;
    [SerializeField] private Transform startPos;
    [SerializeField] private InputAction inputMenu;
    [SerializeField] private InputAction action;
    [SerializeField] private GameObject canvas;

    private bool isMenuOpen = true;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (action.triggered)
        {
            Instantiate(table,startPos.position + new Vector3(0,0,1.5f),Quaternion.identity);
        }
        if (inputMenu.triggered)
        {
            isMenuOpen = !isMenuOpen;
            canvas.SetActive(isMenuOpen);
        }
    }

    public void OnEnable()
    {
        action.Enable();
        inputMenu.Enable();
    }

    public void OnDisable()
    {
        action.Disable();
        inputMenu.Disable();
    }
}
