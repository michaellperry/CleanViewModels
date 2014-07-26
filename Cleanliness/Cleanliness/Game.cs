using System.Linq;

namespace Cleanliness
{
    public class Game
    {
        private Frame[] _frames = new Frame[10];

        public Frame GetFrame(int frameIndex)
        {
            return _frames[frameIndex];
        }

        public int GetCumulativeScore(int frameIndex)
        {
            return _frames
                .Take(frameIndex)
                .Sum(f => f.Score);
        }
    }
}
