using System;

namespace Cleanliness
{
    public class FrameViewModel
    {
        private readonly Game _game;
        private readonly int _frameIndex;
        
        public FrameViewModel(Game game, int frameIndex)
        {
            _game = game;
            _frameIndex = frameIndex;
        }

        public int FirstRoll
        {
            get { return _game.GetFrame(_frameIndex).FirstRoll; }
            set { _game.GetFrame(_frameIndex).FirstRoll = value; }
        }

        public int SecondRoll
        {
            get { return _game.GetFrame(_frameIndex).SecondRoll; }
            set { _game.GetFrame(_frameIndex).SecondRoll = value; }
        }

        public int CumulativeScore
        {
            get { return _game.GetCumulativeScore(_frameIndex); }
        }
    }
}
