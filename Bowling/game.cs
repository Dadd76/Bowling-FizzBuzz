using System.Collections.Generic;

namespace Bowling
{
    public class Game
    {
        private string _gameScore = string.Empty;

        public Game()
        {
        }
        public Game(string gameScore)
        {
            _gameScore = gameScore;
        }

        public int total()
        {
            int throwCounter = 0;
            int scorefinal = 0;

            for (int currentFrame = 0; currentFrame < 10; currentFrame++)
            {
                if (_gameScore[throwCounter] == 'X')
                {
                    scorefinal += BowlThrowValueConverter.getValue(_gameScore[throwCounter]) + BowlThrowValueConverter.getValue(_gameScore[throwCounter + 1]) + BowlThrowValueConverter.getValue(_gameScore[throwCounter + 2]);
                }

                else
                {
                    scorefinal += BowlThrowValueConverter.getValue(_gameScore[throwCounter]) + BowlThrowValueConverter.getValue(_gameScore[throwCounter + 1]);
                }

                throwCounter++;
            }
            return scorefinal; 
        }
    }

    public static class BowlThrowValueConverter
    {
        public static int getValue(char c)
        {
            if (c == 'X' || c == '/')
            {
                return 10;
            }
            if (c == '-')
            {
                return  0;
            }

            int score;
                int.TryParse(c.ToString(), out score);
            return score;
        }
    }

 
    }
