namespace WeaponShopV20
{
    /// <summary>
    /// This class represents a Axe. An Axe is 
    /// considered to be a weapon.
    /// </summary>
    public class Sword : Weapon
    {
        public const int InitialSwordMinDamage = 20;
        public const int InitialSwordMaxDamage = 50;

        #region Constructor
        public Sword(string description) : base(description, InitialSwordMinDamage, InitialSwordMaxDamage)
        {
        }
        #endregion

        #region Methods
        /// <summary>
        /// Returns the damage dealt by the Axe. Also lowers the
        /// minimum and maximum damage dealt by three points.
        /// </summary>
        public override int DealDamage()
        {
            int damage = base.DealDamage();

            MinDamage = MinDamage < 3 ? 0 : MinDamage - 3;
            MaxDamage = MaxDamage < 3 ? 0 : MaxDamage - 3;

            return damage;
        }

        /// <summary>
        /// Resets the minimum and maximum damage dealt by 
        /// the Axe to its original values.
        /// </summary>
        public void Sharpen()
        {
            MinDamage = InitialSwordMinDamage;
            MaxDamage = InitialSwordMaxDamage;
        } 
        #endregion
    }
}