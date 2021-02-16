namespace Modul_2_Task_1
{
    internal class Actions
    {
        private readonly Logger _logger = Logger.Instance;
        internal Result Create()
        {
            _logger.Log(LogType.Info, $"Start method: {nameof(Create)}");
            return new Result() { Status = true };
        }

        internal Result Update()
        {
            _logger.Log(LogType.Warning, $"Skipped logic in method: {nameof(Update)}");
            return new Result() { Status = true };
        }

        internal Result Remove()
        {
            return new Result() { Status = false, ErrorMessage = "I broke a logic" };
        }
    }
}
