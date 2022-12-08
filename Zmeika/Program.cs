namespace Zmeika
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // перенос в код
            Snake snake = new Snake();
            while(true)
            {
                snake.Gran();
                snake.retr();
                snake.kvadrat();
             }
        }
        internal void Finaly()
        {
            // возврат доделать в ИС 2 Х
            // само в себя Х
            Console.Clear();
            Console.Write("Конец игры");
        }
    }
}
