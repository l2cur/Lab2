namespace lab2
{
    public class Programm
    {
        static void Main()
        {
            Console.Write("Ключ активации: ");
            string key = Console.ReadLine();

            switch (key)
            {
                case "pro":
                    ProDocumentWorker proDocument = new ProDocumentWorker();
                    Console.WriteLine("\nPro версия\n");
                    proDocument.OpenDocument();
                    proDocument.EditDocument();
                    proDocument.SaveDocument();
                    break;
                case "exp":
                    ExpertDocumentWorker expDocument = new ExpertDocumentWorker();
                    Console.WriteLine("\nExpert версия\n");
                    expDocument.OpenDocument();
                    expDocument.EditDocument();
                    expDocument.SaveDocument();
                    break;
                default:
                    DocumentWorker document = new DocumentWorker();
                    Console.WriteLine("\nDefault версия\n");
                    document.OpenDocument();
                    document.EditDocument();
                    document.SaveDocument();
                    break;
            }
        }
    }
    public class ExpertDocumentWorker : ProDocumentWorker
    {
        public override void SaveDocument() { Console.WriteLine("Документ сохранен в новом формате"); }
    }
    public class ProDocumentWorker : DocumentWorker
    {
        public override void EditDocument() { Console.WriteLine("Документ отредактирован"); }
        public override void SaveDocument() { Console.WriteLine("Документ сохранен в старом формате, сохранение в остальных форматах доступно в версии Expert"); }
    }
    public class DocumentWorker
    {
        public void OpenDocument() { Console.WriteLine("Документ открыт"); }
        public virtual void EditDocument() { Console.WriteLine("Редактирование документа доступно в версии Pro"); }
        public virtual void SaveDocument() { Console.WriteLine("Сохранение документа доступно в версии Pro"); }

    }
}