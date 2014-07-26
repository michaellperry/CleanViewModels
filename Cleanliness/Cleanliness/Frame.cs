using Assisticant.Fields;

namespace Cleanliness
{
    public class Frame
    {
        private Observable<int> _secondRoll = new Observable<int>();
        private Observable<int> _firstRoll = new Observable<int>();

        public int FirstRoll
        {
            get { return _firstRoll; }
            set { _firstRoll.Value = value; }
        }

        public int SecondRoll
        {
            get { return _secondRoll; }
            set { _secondRoll.Value = value; }
        }

        public int Score
        {
            get { return FirstRoll + SecondRoll; }
        }
    }
}
