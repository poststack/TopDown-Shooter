


    public interface IDamagable
    {
    
        UnitBattleIdentity BattleIdentity { get; }

	    void GetHit(IDamageDealer damageDealer);

    }


    public enum UnitBattleIdentity
    {
        Neutral,
        Ally,
        Enemy
    }



