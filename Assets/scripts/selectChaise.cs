using UnityEngine;

public class selectChaise : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public spawnItem spawnItem;
    [SerializeField] private GameObject chaise;
    void Start()
    {
        spawnItem.table = chaise;
    }
}
