namespace Cars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Invoker invoker = new Invoker();
            FirstCommand firstCommand = new FirstCommand();
            SecondCommand secondCommand = new SecondCommand();
            invoker.SetFirstCommand(firstCommand);
            invoker.SetSecondCommand(secondCommand);
            invoker.DoFirstOrSecondCommand();
        }
    }
}
