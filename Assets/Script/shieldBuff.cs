using UnityEngine;

public class ShieldBuff : PowerUpBase
{
    public override void ApplyEffect(Player player)
    {
        if (!IsEffectActive)
        {
            player.SetInvulnereble(true);
            IsEffectActive = true;
            Destroy(this.gameObject);
        }
        else
        {
            Debug.Log($"Player already have a powerup");
        }
    }
}
