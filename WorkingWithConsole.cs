using System;

namespace HangMan_games
{
    public class WorkingWithConsole
    {
        private string ConvertString(string[] arg)
        {
            string detsckoeporno = null;
            for (int i = 0; i < arg.Length; i++)
            {
                detsckoeporno = detsckoeporno + Convert.ToString(arg[i]);
            }

            return detsckoeporno;
        }

        public string ConvertStr(string[] arg)
        {
            return ConvertString(arg);
        }
        private void HelloWorld()
        {
            Logic nw = new Logic();
            Console.WriteLine("Hello World, ВЫ НЕ ЖДАЛИ А Я ПРИШЕЛ, так что введи количество своих попыток: ");
            nw.Quantitytryes(Convert.ToInt32(Console.ReadLine()));
            while (true)
            {
                string b = Convert.ToString(Console.ReadLine());
                string detsckoeporno = ConvertString(nw.CallCompare(b));
                Console.WriteLine(detsckoeporno);
            }
        }
        public void ds()
        {
            HelloWorld();
        }
    }
}