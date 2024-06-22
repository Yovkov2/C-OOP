using NUnit.Framework;

namespace Skeleton.Tests
{
    [TestFixture]
    public class AxeTests
    {
        private class Dummy
        {
            public int Health { get; set; }

            public Dummy(int health)
            {
                Health = health;
            }

            public void TakeDamage(int damage)
            {
                Health -= damage;
            }
        }
    }
}