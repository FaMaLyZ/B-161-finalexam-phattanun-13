using UnityEngine;

public class JumpBoost : PowerUpBase
{
    public override void ApplyEffect(Player player)
    {
        if (!IsEffectActive)
        {
            player.SetJumpForce(30);
            IsEffectActive = true;
            Destroy(this.gameObject);
        }
        else
        {
            Debug.Log($"Player already have a powerup");
        }
    }
}
