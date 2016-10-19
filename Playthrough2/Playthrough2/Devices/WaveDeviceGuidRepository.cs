using System;
using System.Collections.Generic;
using System.Linq;

namespace Playthrough2
{
    internal static class WaveDeviceGuidRepository
    {
        private const int GuidCount = 32;

        private static List<Guid> _inputGuids;
        private static List<Guid> _outputGuids;

        public static IList<Guid> InputGuids
        {
            get
            {
                if (_inputGuids == null)
                    _inputGuids = Enumerable.Range(0, GuidCount).Select(i => Guid.NewGuid()).ToList();
                return new List<Guid>(_inputGuids);
            }
        }

        public static IList<Guid> OutputGuids
        {
            get
            {
                if (_outputGuids == null)
                    _outputGuids = Enumerable.Range(0, GuidCount).Select(i => Guid.NewGuid()).ToList();
                return new List<Guid>(_outputGuids);
            }
        }
    }
}
