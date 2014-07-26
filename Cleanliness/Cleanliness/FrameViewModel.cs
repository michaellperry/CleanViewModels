using GalaSoft.MvvmLight;

namespace Cleanliness
{
    public class FrameViewModel : ViewModelBase
    {
        private int _firstRoll = 0;
        private int _secondRoll = 0;
        private int _cumulativeScore = 0;

        public int FirstRoll
        {
            get { return _firstRoll; }
            set
            {
                if (_firstRoll == value)
                {
                    return;
                }

                _firstRoll = value;
                CumulativeScore += value;
                RaisePropertyChanged(() => FirstRoll);
            }
        }

        public int SecondRoll
        {
            get { return _secondRoll; }
            set
            {
                if (_secondRoll == value)
                {
                    return;
                }

                _secondRoll = value;
                CumulativeScore += value;
                RaisePropertyChanged(() => SecondRoll);
            }
        }

        public int CumulativeScore
        {
            get { return _cumulativeScore; }
            set
            {
                if (_cumulativeScore == value)
                {
                    return;
                }

                _cumulativeScore = value;
                RaisePropertyChanged(() => CumulativeScore);
            }
        }
    }
}
