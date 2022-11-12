using System.Text;

namespace ConsoleApp1
{
    public class OnpClass
    {
        public static void Onp(string input)
        {
            var stack = new Stack<char>();
            input = input.Replace(" ", string.Empty);
            var stringBuilder = new StringBuilder();

            for (int i = 0; i < input.Length; i++)
            {
                char character = input[i];
                if (character == '(')
                    stack.Push(character);
                else if (character == ')')
                {
                    while (stack.Count > 0 && stack.Peek() != '(')
                        stringBuilder.Append(stack.Pop());
                    stack.Pop();
                }
                else if (IsNum(character))
                {
                    stringBuilder.Append(character);
                }
                else if (IsOperator(character))
                {
                    while (stack.Count > 0 && stack.Peek() != '(' && Prior(character) <= Prior(stack.Peek()))
                        stringBuilder.Append(stack.Pop());
                    stack.Push(character);
                }
                else
                {
                    if (stack.Pop() != '(')
                        stringBuilder.Append(stack.Pop());
                }
            }
            while (stack.Count > 0)
            {
                stringBuilder.Append(stack.Pop());
            }

            Console.WriteLine(stringBuilder.ToString());
        }
        static bool IsOperator(char c)
        {
            return (c == '-' || c == '+' || c == '*' || c == '/');
        }
        static bool IsNum(char c)
        {
            return (c >= '0' && c <= '9' || c == '.');
        }
        static int Prior(char c)
        {
            switch (c)
            {
                case '+':
                    return 1;
                case '-':
                    return 1;
                case '*':
                    return 2;
                case '/':
                    return 2;
                default:
                    throw new Exception("Invalid input");
            }
        }
    }
}
