using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    [SerializeField] Shooter gun;

    void Update() {
        if (GameManager.Instance.inputController.Fire1) {
            gun.Fire();
        }
    }
}
