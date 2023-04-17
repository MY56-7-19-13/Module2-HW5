namespace Homework5
{
    public class Starter
    {
        public void Run()
        {
            Logger logger = new Logger();
            Actions actions = new Actions(logger);
            Random rand = new Random();
            for (int i = 1; i < 100; i++)
            {
                int action = rand.Next(1, 4);
                switch (action)
                {
                    case 1:
                        actions.StartMethod();

                        break;
                    case 2:
                        try
                        {
                            actions.SkippedLogicInMethod();
                        }
                        catch (BusinessExeption busiEx)
                        {
                            logger.LoggerWarning($"Action got this custom Exeption: {busiEx.Message}");
                        }

                        break;
                    case 3:
                        try
                        {
                            actions.BrokeMethod();
                        }
                        catch (Exception e)
                        {
                            logger.LoggerError($"Action failed by reason:\n" + e);
                        }

                        break;
                }
            }
        }
    }
}
