

namespace PrintApp.Objs
{
    public class SimplePrinter : IPrint
    {
        public void Print(Document document)
        {
            // Implementación de la impresión
        }

        public void Scan(Document document)
        {
            throw new NotImplementedException();
        }
    }
}
