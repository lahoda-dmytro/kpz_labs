using System;
using ClassLibrary;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            
            // Create HTML structure
            var root = new LightElementNode("div", DisplayType.Block, ClosingType.Double);
            var header = new LightElementNode("header", DisplayType.Block, ClosingType.Double);
            var title = new LightElementNode("h1", DisplayType.Block, ClosingType.Double);
            var titleText = new LightTextNode("Мій HTML документ");
            
            // Command pattern usage
            var commandInvoker = new CommandInvoker();
            
            // Add elements using commands
            var addTitleTextCommand = new AddChildCommand(title, titleText);
            var addTitleCommand = new AddChildCommand(header, title);
            var addHeaderCommand = new AddChildCommand(root, header);
            
            commandInvoker.ExecuteCommand(addTitleTextCommand);
            commandInvoker.ExecuteCommand(addTitleCommand);
            commandInvoker.ExecuteCommand(addHeaderCommand);
            
            // State pattern usage
            Console.WriteLine("=== Демонстрація шаблону State ===");
            header.SetState(new VisibleState());
            Console.WriteLine(header.OuterHTML());
            
            header.SetState(new HiddenState());
            Console.WriteLine(header.OuterHTML());
            
            // Iterator pattern usage
            Console.WriteLine("\n=== Демонстрація шаблону Iterator ===");
            Console.WriteLine("Обхід в глибину:");
            var depthIterator = new DepthFirstIterator(root);
            while (depthIterator.HasNext())
            {
                var node = depthIterator.Next();
                Console.WriteLine($"- {node.GetType().Name}");
            }
            
            Console.WriteLine("\nОбхід в ширину:");
            var breadthIterator = new BreadthFirstIterator(root);
            while (breadthIterator.HasNext())
            {
                var node = breadthIterator.Next();
                Console.WriteLine($"- {node.GetType().Name}");
            }
            
            // Visitor pattern usage
            Console.WriteLine("\n=== Демонстрація шаблону Visitor ===");
            var statsVisitor = new HTMLStatisticsVisitor();
            root.Accept(statsVisitor);
            Console.WriteLine(statsVisitor.ToString());
            
            var minifierVisitor = new HTMLMinifierVisitor();
            root.Accept(minifierVisitor);
            Console.WriteLine("\nМініфікований HTML:");
            Console.WriteLine(minifierVisitor.GetMinifiedHTML());
            
            // Template Method pattern usage
            Console.WriteLine("\n=== Демонстрація шаблону Template Method ===");
            Console.WriteLine("Рендеринг з життєвим циклом:");
            Console.WriteLine(root.Render());
            
            // Demonstrate Undo/Redo
            Console.WriteLine("\n=== Демонстрація Undo/Redo ===");
            Console.WriteLine("Початковий стан:");
            Console.WriteLine(root.OuterHTML());
            
            Console.WriteLine("\nПісля Undo:");
            commandInvoker.Undo(); // Removes header
            Console.WriteLine(root.OuterHTML());
            
            Console.WriteLine("\nПісля Redo:");
            commandInvoker.Redo(); // Adds header back
            Console.WriteLine(root.OuterHTML());

            // створюємо простий html
            var div = new LightElementNode("div", DisplayType.Block, ClosingType.Double);
            var h1 = new LightElementNode("h1", DisplayType.Block, ClosingType.Double);
            var text = new LightTextNode("тест команди");
            
            h1.AddChild(text);
            div.AddChild(h1);
            
            // демонстрація ітератора
            Console.WriteLine("=== демонстрація ітератора ===");
            
            Console.WriteLine("обхід в глибину:");
            var depthIterator = new DepthIterator(div);
            while (depthIterator.HasNext())
            {
                var node = depthIterator.Next();
                Console.WriteLine($"- {node.GetType().Name}");
            }
            
            Console.WriteLine("\nобхід в ширину:");
            var breadthIterator = new BreadthIterator(div);
            while (breadthIterator.HasNext())
            {
                var node = breadthIterator.Next();
                Console.WriteLine($"- {node.GetType().Name}");
            }

            // демонстрація команди
            Console.WriteLine("=== демонстрація шаблону команда ===");
            
            var invoker = new CommandInvoker();
            
            // додаємо клас
            var addClassCommand = new AddClassCommand(div, "container");
            invoker.ExecuteCommand(addClassCommand);
            Console.WriteLine("після додавання класу:");
            Console.WriteLine(div.OuterHTML());
            
            // додаємо текст
            var addTextCommand = new AddChildCommand(h1, text);
            invoker.ExecuteCommand(addTextCommand);
            Console.WriteLine("\nпісля додавання тексту:");
            Console.WriteLine(h1.OuterHTML());
            
            // додаємо заголовок
            var addHeaderCommand = new AddChildCommand(div, h1);
            invoker.ExecuteCommand(addHeaderCommand);
            Console.WriteLine("\nпісля додавання заголовка:");
            Console.WriteLine(div.OuterHTML());
            
            // демонстрація undo/redo
            Console.WriteLine("\nпісля undo:");
            invoker.Undo();
            Console.WriteLine(div.OuterHTML());
            
            Console.WriteLine("\nпісля redo:");
            invoker.Redo();
            Console.WriteLine(div.OuterHTML());
        }
    }
}
