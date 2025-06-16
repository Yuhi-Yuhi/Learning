namespace ExceptionsLearning
{
    internal class ExceptionsLearning
    {
        public void Check()
        {
            try
            {
                Exception o = new DivideByZeroException("Its my exceptions");
                var pos = o is OutOfMemoryException; // Оператор is проверяет совместим ли результат выражения с указанным типом 
                var kok = o as OutOfMemoryException; // Меняет тип
                var sos = kok as Exception;
                //var bob = o as String;  // не рабоет, не связанные типы 
                throw o;
            }
            catch(OutOfMemoryException lol)
            {
                Console.WriteLine("OutOfMemoryException");
                Console.WriteLine(lol.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Its finally block");
            }
        }
    }
}
