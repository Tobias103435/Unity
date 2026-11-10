using UnityEngine;

public class draaien : MonoBehaviour
{
    [SerializeField] private float snelheid = 100f;
    void Update()
    {
        Debug.Log("Hoi");
        spinme(snelheid);
    }
    
    void spinme(float spinspeed)
    {
        transform.Rotate(new Vector3(0, spinspeed * Time.deltaTime, 0));
    }
}
