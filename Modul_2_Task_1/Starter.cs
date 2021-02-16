using System;
using System.IO;

namespace Modul_2_Task_1
{
    public class Starter
    {
        private readonly int _minRandomValue = 1;
        private readonly int _maxRandomValue = 4;
        private readonly Random _random = new Random();
        private readonly Actions _actions = new Actions();
        private readonly Logger _logger = Logger.Instance;
        private Result _bufferResult;
        public void Run()
        {
            for (int i = 0; i < 100; i++)
            {
                int rnd = _random.Next(_minRandomValue, _maxRandomValue);
                switch (rnd)
                {
                    case 1:
                        _bufferResult = _actions.Create();
                        break;
                    case 2:
                        _bufferResult = _actions.Update();
                        break;
                    case 3:
                        _bufferResult = _actions.Remove();
                        break;
                }

                if (!_bufferResult.Status)
                {
                    _logger.Log(LogType.Error, $"Action failed by a reason: {_bufferResult.ErrorMessage}");
                }
            }

            File.WriteAllText("log.txt", Logger.Instance.GetLogs());
        }
    }
}
