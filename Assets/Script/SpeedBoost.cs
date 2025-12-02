using UnityEngine;

public class SpeedBoost : PowerUpBase
{
    public override void ApplyEffect(Player player)
    {
        if(!IsEffectActive)
        {
            player.SetMoveSpeed(player.MoveSpeed * 2);
            IsEffectActive = true;
            Destroy(this.gameObject);
        }
        else
        {
            Debug.Log($"Player already have a powerup");
        }
    }
}
