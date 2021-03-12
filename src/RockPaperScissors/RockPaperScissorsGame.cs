using RockPaperScissors.Data.Enums;

namespace RockPaperScissors
{
    public class RockPaperScissorsGame
    {
        public GameResult Battle(Gesture firstPlayerGesture, Gesture secondPlayerGesture)
        {
            switch (firstPlayerGesture)
            {
                case Gesture.Paper when secondPlayerGesture == Gesture.Rock:
                    return GameResult.PlayerOneWon;

                case Gesture.Paper when secondPlayerGesture == Gesture.Scissors:
                    return GameResult.PlayerTwoWon;

                case Gesture.Scissors when secondPlayerGesture == Gesture.Paper:
                    return GameResult.PlayerOneWon;

                case Gesture.Scissors when secondPlayerGesture == Gesture.Rock:
                    return GameResult.PlayerTwoWon;

                case Gesture.Rock when secondPlayerGesture == Gesture.Paper:
                    return GameResult.PlayerTwoWon;

                case Gesture.Rock when secondPlayerGesture == Gesture.Scissors:
                    return GameResult.PlayerOneWon;

                default:
                    return GameResult.Tie;
            }
        }
    }
}
