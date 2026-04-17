using UnityEngine;

public class selectTable : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public spawnItem spawnItem;
    [SerializeField] private GameObject table;
    void Start()
    {   
        spawnItem.table = table;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
