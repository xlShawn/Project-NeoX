using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonCamera : MonoBehaviour {
    public Vector3 cameraOffset;
    public float damping;

    Transform cameraLookTarget;
    Player localPlayer;


    void Awake() {
        GameManager.Instance.OnLocalPlayerJoined += handleLocalPlayerJoined;
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    void handleLocalPlayerJoined(Player player) {
        localPlayer = player;
        cameraLookTarget = localPlayer.transform.Find("cameraLookTarget");

        if (cameraLookTarget == null) {
            cameraLookTarget = localPlayer.transform;
        }
    }

    void Update() {
        Vector3 targetPosition = cameraLookTarget.position + localPlayer.transform.forward * cameraOffset.z +
            localPlayer.transform.up * cameraOffset.y +
            localPlayer.transform.right * cameraOffset.x;

        Quaternion targetRotation = Quaternion.LookRotation(cameraLookTarget.position - targetPosition, Vector3.up);

        transform.position = Vector3.Lerp(transform.position, targetPosition, damping * Time.deltaTime);
        transform.rotation = Quaternion.Lerp(transform.rotation, targetRotation, damping * Time.deltaTime);

        print(Input.mousePosition.x + "   " + Input.mousePosition.y);
    }
}
