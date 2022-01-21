using RockPaperScissors;
using Xunit;

namespace RockPaperScissorsTest
{
    public class Test
    {
        [Fact]
        public void RockBluntsScissorsPlayer1Win()
        {
            // rock blunts scissors
            int result = new Round().Play("Rock", "Scissors");
            Assert.Equal(1, result);
        }

        [Fact]
        public void RockBluntsScissorsPlayer2Win()
        {
            // rock blunts scissors
            int result = new Round().Play("Scissors","Rock");
            Assert.Equal(2, result);
        }
    }
}