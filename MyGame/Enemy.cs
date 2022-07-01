namespace MyGame
{
    public class Enemy
    {
        private string name;
        private float health, shield;

        public Enemy(string name)
        {
            this.name = SetName(name);
            health = 100;
            shield = 0;
        }   

        public string GetName() => name;
        public float GetHealth() => health;
        public float GetShield() => shield;

        public void TakeDamage(float damage)
        {
            shield -= damage;
            if (shield < 0)
            {
                float damageStillToInflict = -shield;
                shield = 0;
                health -= damageStillToInflict;
                if (health < 0) health = 0;
            }
        }

        public string SetName(string name)
        {
            this.name = name.Trim(); 
            return name;
        }

        public void PickPowerUp(PowerUp powerUp, float value)
        {
            if (powerUp == PowerUp.Health)
            {
                health += value;
                if (health > 100) health = 100;
            }
            else
            {
                shield += value;
                if (shield > 100) shield = 100;
            }
        }

    }
}