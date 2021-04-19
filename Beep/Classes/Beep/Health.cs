namespace Beep.Classes.Beep
{
    public class Health
    {
        public int WaterHealth { get; private set; }
        public int ShortBreakHealth { get; private set; }
        public int LongBreakHealth { get; private set; }

        public void ChangeShortBreakHealth(HealthActionEnum action)
        {
            int newHealth = GetNewHealth(action, ShortBreakHealth);
            if(ValidateHealth(newHealth))
            {
                ShortBreakHealth = newHealth;
            }
        }
        
        public void ChangeLongBreakHealth(HealthActionEnum action)
        {
            int newHealth = GetNewHealth(action, LongBreakHealth);
            if(ValidateHealth(newHealth))
            {
                LongBreakHealth = newHealth;
            }
        }
        
        public void ChangeBreakHealth(HealthActionEnum action)
        {
            int newHealth = GetNewHealth(action, WaterHealth);
            if(ValidateHealth(newHealth))
            {
                WaterHealth = newHealth;
            }
        }

        private bool ValidateHealth(int health)
        {
            return health >= 0 && health <= 10;
        }
        
        private int GetNewHealth(HealthActionEnum action, int health)
        {
            if (action.Equals(HealthActionEnum.INCREASE))
            {
                return health + 1;
            }
            else
            {
                return health - 1;
            }
        }
    }
}