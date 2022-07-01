namespace MyGame
{
    public class Enemy
    {
        private string name;
        private float health, shield;

        public Enemy(string name)
        {
            this.name = name;
            health = 100;
            shield = 0;
        }   
    }
}