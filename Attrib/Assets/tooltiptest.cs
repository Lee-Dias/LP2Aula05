using UnityEngine;

public class tooltiptest : MonoBehaviour
{
    [Tooltip("this variable is good")]
    [Range(0, 500)]
    [SerializeField]
    private int thing;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
