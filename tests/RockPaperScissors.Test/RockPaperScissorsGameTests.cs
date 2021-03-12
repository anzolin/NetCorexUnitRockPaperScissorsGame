using FluentAssertions;
using RockPaperScissors.Data.Enums;
using Xunit;

namespace RockPaperScissors.Test
{
    public class RockPaperScissorsGameTests
    {
        [Fact(DisplayName = "Player one won when paper verus rock")]
        public void Battle_PaperAndRock_PlayerOneWon()
        {
            var game = new RockPaperScissorsGame();

            var actual = game.Battle(Gesture.Paper, Gesture.Rock);

            actual.Should().Be(GameResult.PlayerOneWon);
        }

        [Fact(DisplayName = "Player two won when paper verus scissors")]
        public void Battle_PaperAndScissors_PlayerTwoWon()
        {
            var game = new RockPaperScissorsGame();

            var actual = game.Battle(Gesture.Paper, Gesture.Scissors);

            actual.Should().Be(GameResult.PlayerTwoWon);
        }

        [Fact(DisplayName = "Player one won when scissors verus paper")]
        public void Battle_ScissorsAndPaper_PlayerOneWon()
        {
            var game = new RockPaperScissorsGame();

            var actual = game.Battle(Gesture.Scissors, Gesture.Paper);

            actual.Should().Be(GameResult.PlayerOneWon);
        }

        [Fact(DisplayName = "Player two won when scissors verus rock")]
        public void Battle_ScissorsAndRock_PlayerTwoWon()
        {
            var game = new RockPaperScissorsGame();

            var actual = game.Battle(Gesture.Scissors, Gesture.Rock);

            actual.Should().Be(GameResult.PlayerTwoWon);
        }

        [Fact(DisplayName = "Player one won when rock verus paper")]
        public void Battle_RockAndPaper_PlayerOneWon()
        {
            var game = new RockPaperScissorsGame();

            var actual = game.Battle(Gesture.Rock, Gesture.Paper);

            actual.Should().Be(GameResult.PlayerTwoWon);
        }

        [Fact(DisplayName = "Player two won when rock verus scissors")]
        public void Battle_RockAndSicssors_PlayerOneWon()
        {
            var game = new RockPaperScissorsGame();

            var actual = game.Battle(Gesture.Rock, Gesture.Scissors);

            actual.Should().Be(GameResult.PlayerOneWon);
        }

        [Fact(DisplayName = "Tie when paper verus paper")]
        public void Battle_PaperAndPaper_Tien()
        {
            var game = new RockPaperScissorsGame();

            var actual = game.Battle(Gesture.Paper, Gesture.Paper);

            actual.Should().Be(GameResult.Tie);
        }

        [Fact(DisplayName = "Tie when scissors verus scissors")]
        public void Battle_ScissorsAndScissors_Tie()
        {
            var game = new RockPaperScissorsGame();

            var actual = game.Battle(Gesture.Scissors, Gesture.Scissors);

            actual.Should().Be(GameResult.Tie);
        }

        [Fact(DisplayName = "Tie when rock verus rock")]
        public void Battle_RockAndRock_Tie()
        {
            var game = new RockPaperScissorsGame();

            var actual = game.Battle(Gesture.Rock, Gesture.Rock);

            actual.Should().Be(GameResult.Tie);
        }
    }
}
