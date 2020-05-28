using UnityEngine;
using System.Collections;

public class DestroyThisGameObject : MonoBehaviour
{
    public void Destroy()
    {
        Destroy(gameObject);
    }
}
