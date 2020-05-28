using UnityEngine;
using System.Collections;

public class PlayerEmitter : MonoBehaviour
{
    [System.Serializable]
    public struct PlayerEmitterInfo
    {
        [Tooltip("Prefab to instantiate as the emitted object")]
        public GameObject prefab;
        [Tooltip("Speed the object travels when emitted")]
        public float travelSpeed;
    }

    // VARIABLES

    [SerializeField]
    [Tooltip("Reference to the emitter the Player uses to emit the bullets")]
    private Emitter2D emitter;

    [SerializeField]
    [Tooltip("Info on player's attacking bullet")]
    private PlayerEmitterInfo attackBulletInfo;

    [SerializeField]
    [Tooltip("Info on the player's healing bullet")]
    private PlayerEmitterInfo healBulletInfo;

    [SerializeField]
    [Tooltip("Minimum time between player attacks")]
    private float fireRate;

    private float timeSinceLastShot;

    private void Awake()
    {
        timeSinceLastShot = -fireRate;
    }

    private void Update()
    {
        if(Time.time > timeSinceLastShot + fireRate)
        {
            if(Input.GetButton("Attack"))
            {
                Emit(attackBulletInfo);
            }
            else if(Input.GetButton("Heal"))
            {
                Emit(healBulletInfo);
            }
        }
    }

    private void Emit(PlayerEmitterInfo info)
    {
        emitter.Emit(info.prefab, transform.position, Vector2.right, info.travelSpeed);
        timeSinceLastShot = Time.time;
    }
}
