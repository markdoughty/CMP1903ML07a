using System;

namespace CMP1903ML07a
{
    class Program
    {
        static void Main(string[] args)
        {
            csvWriter csvW = new csvWriter();
            txtWriter txtW = new txtWriter();

            LogWrite writer = new LogWrite(csvW);

            try
            {
                writer.Write("Message");

            }catch (ArgumentNullException e)
            {
                Console.WriteLine("Argument shouldn't be null");
               
            }
            catch(LogMessageException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Writing csv message finished");
            }
          

            writer = new LogWrite(txtW);
            writer.Write("Message");
            
        }
    }
}
