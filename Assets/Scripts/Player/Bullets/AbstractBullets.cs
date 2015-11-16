using UnityEngine;
using System.Collections;

public abstract class AbstractBullets : MonoBehaviour {
    [SerializeField]
    float fireRate;
    [SerializeField]
    int damage;
    public abstract void Fire ();
}
