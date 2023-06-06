using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//teste alteração
namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int teste123 = 0;
            int op;
            string str;
            Menu();
            do
            {
                
                int x = 0;
                op = int.Parse(Console.ReadLine());
                Menu2(op);
                if (op != 0 && op<13)
                {
                    str = Console.ReadLine();
              
                    Menu3();
                    switch (op)
                    {
                        case 0: break;
                        case 1:
                            Console.WriteLine("PASSO 1: Converter Decimal para Binário: ");
                            Console.WriteLine("Resultado: " + Convertdecto(str, 2));
                            break;
                        case 2:
                            Console.WriteLine("PASSO 1: Converter Binário para Decimal: ");
                            Console.WriteLine("Resultado: " + Converttodec(str, 2));
                            break;
                        case 3:
                            Console.WriteLine("PASSO 1: Converter Decimal para Octal: ");
                            Console.WriteLine("Resultado: " + Convertdecto(str, 8));
                            break;
                        case 4:
                            Console.WriteLine("PASSO 1: Converter Octal para Decimal: ");
                            Console.WriteLine("Resultado: " + Converttodec(str, 8));
                            break;
                        case 5:
                            Console.WriteLine("PASSO 1: Converter Decimal para Hexadecimal: ");
                            Console.WriteLine("Resultado: " + Convertdecto(str, 16));
                            break;
                        case 6:
                            Console.WriteLine("PASSO 1: Converter Hexadecimal para Decimal: ");
                            Console.WriteLine("Resultado: " + Converttodec(str, 16));
                            break;
                        case 7:
                            Console.WriteLine("PASSO 1: Converter Binario para Decimal: ");
                            x = Converttodec(str, 2);
                            Console.WriteLine("Resultado: " + x);
                            Console.WriteLine("PASSO 2: Converter Decimal para Octal: ");
                            Console.WriteLine("Resultado final: " + Convertdecto(x.ToString(), 8));
                            break;
                        case 8:
                            Console.WriteLine("PASSO 1: Converter Octal para Decimal: ");
                            x = Converttodec(str, 8);
                            Console.WriteLine("Resultado: " + x);
                            Console.WriteLine("PASSO 2: Converter Decimal para Binário: ");
                            Console.WriteLine("Resultado final: " + Convertdecto(x.ToString(), 2));
                            break;
                        case 9:
                            Console.WriteLine("PASSO 1: Converter Binario para Decimal: ");
                            x = Converttodec(str, 2);
                            Console.WriteLine("Resultado: " + x);
                            Console.WriteLine("PASSO 2: Converter Decimal para Hexadecimal: ");
                            Console.WriteLine("Resultado final: " + Convertdecto(x.ToString(), 16));
                            break;
                        case 10:
                            Console.WriteLine("PASSO 1: Converter Hexadecimal para Decimal: ");
                            x = Converttodec(str, 16);
                            Console.WriteLine("Resultado: " + x);
                            Console.WriteLine("PASSO 2: Converter Decimal para Binario: ");
                            Console.WriteLine("Resultado final: " + Convertdecto(x.ToString(), 2));
                            break;
                        case 11:
                            Console.WriteLine("PASSO 1: Converter Octal para Decimal: ");
                            x = Converttodec(str, 8);
                            Console.WriteLine("Resultado: " + x);
                            Console.WriteLine("PASSO 2: Converter Decimal para Hexadecimal: ");
                            Console.WriteLine("Resultado final: " + Convertdecto(x.ToString(), 16));
                            break;
                        case 12:
                            Console.WriteLine("PASSO 1: Converter Hexadecimal para Decimal: ");
                            x = Converttodec(str, 16);
                            Console.WriteLine("Resultado: " + x);
                            Console.WriteLine("PASSO 2: Converter Decimal para Octal: ");
                            Console.WriteLine("Resultado final: " + Convertdecto(x.ToString(), 8));
                            break;
                        

                    }

                    
                    Console.Write("Selecione nova conversão: ");
                }else if(op >= 13)
                {
                    Console.WriteLine("nmero invalido");
                    Console.Write("Selecione nova conversão: ");
                }
                

            }while(op!=0);
            
        }
        

        public static void Menu()
        {
            Console.WriteLine("|------------------------------------------------------------------|");
            Console.WriteLine("| Menu de conversão de base:                                       |");
            Console.WriteLine("| 1. Decimal -> Binario--------------------------------------------|");
            Console.WriteLine("| 2. Binário -> Decimal--------------------------------------------|");
            Console.WriteLine("| 3. Decimal -> Octal----------------------------------------------|");
            Console.WriteLine("| 4. Octal -> Decimal----------------------------------------------|");
            Console.WriteLine("| 5. Decimal -> Hexadecimal----------------------------------------|");
            Console.WriteLine("| 6. Hexadecimal -> Decimal----------------------------------------|");
            Console.WriteLine("| 7. Binario -> Octal----------------------------------------------|");
            Console.WriteLine("| 8. Octal -> Binario----------------------------------------------|");
            Console.WriteLine("| 9. Binario -> Hexadecimal----------------------------------------|");
            Console.WriteLine("| 10. Hexadecimal -> Binario---------------------------------------|");
            Console.WriteLine("| 11. Octal -> Hexadecimal-----------------------------------------|");
            Console.WriteLine("| 12. Hexadecimal -> Octal-----------------------------------------|");
            Console.WriteLine("|------------------------------------------------------------------|");
            Console.WriteLine("| 0. Sair----------------------------------------------------------|");
            Console.WriteLine("|------------------------------------------------------------------|");
            Console.Write("| opção: ");


        }

        public static void Menu3()
        {
            Console.WriteLine("|------------------------------------------------------------------|");
        }

        public static void Menu2(int i)
        {
            if (i != 0 && i<13)
            {
                i--;
                string[] s2 = new string[12] { "Binario", "Decimal", "Octal", "Decimal", "Hexadecimal", "Decimal", "Octal",
             "Binario", "Hexadecimal", "Binario", "Hexadecimal", "Octal" };
                string[] s1 = new string[12] { "Decimal", "Binário", "Decimal", "Octal", "Decimal", "Hexadecimal", "Binario",
             "Octal", "Binario", "Hexadecimal", "Octal", "Hexadecimal" };
                Console.Write($"| Informe um número {s1[i]} para ser convertido para {s2[i]}: ");
            }
      

        }



        public static int Converttodec(string txt, int bas) 
        {
            string str = "";
            int soma = 0;
            int num = 0;
            int index = txt.Length;
            foreach (char element in txt)
            {
                index--;
                switch (element)
                {
                    case 'A':
                        soma = soma + 10*(int) Math.Pow(bas, index);
                        str =  $"10*({bas}^{index}) + " + str;
                        break;

                    case 'B':
                        soma = soma + 11 * (int)Math.Pow(bas, index);
                        str = $"11*({bas}^{index}) + " + str;
                        break;
                    
                    case 'C':
                        soma = soma + 12 * (int)Math.Pow(bas, index);
                        str = $"12*({bas}^{index}) + " + str;
                        break;
                   
                    case 'D':
                        soma = soma + 13 * (int)Math.Pow(bas, index);
                        str = $"13*({bas}^{index}) + " + str;
                        break;
                    
                    case 'E':
                        soma = soma + 14 * (int)Math.Pow(bas, index);
                        str = $"14*({bas}^{index}) + " + str;
                        break;

                    case 'F':
                        soma = soma + 15 * (int)Math.Pow(bas, index);
                        str = $"15*({bas}^{index}) + " + str;
                        break;
                        default:
                        num = (int)Char.GetNumericValue(element);   
                        soma = soma + num* (int)Math.Pow(bas, index);
                        str = $"{num}*({bas}^{index}) + " + str;
                        break;
                }



                
            }
            Console.Write(str + "= ");
            return soma;


        }


        public static string Convertdecto(string xs, int y)
        {
            int x = int.Parse(xs);
            string result = "";
            int r = 0;
            while (x > 0)
            {
                Console.Write($"{x}/{y}--> ");
                r = x % y;
                x = x / y;
                
                switch (r)
                {
                    case 10:
                        result = "A" + result;
                        Console.Write("resto: " + "A" + " ");
                        Console.WriteLine("quociente: " + x);
                        break;
                    case 11:
                        result = 'B' + result;
                        Console.Write("resto: " + "B" + " ");
                        Console.WriteLine("quociente: " + x);
                        break;
                    case 12:
                        result = 'C' + result ;
                        Console.Write("resto: " + "C" + " ");
                        Console.WriteLine("quociente: " + x);
                        break;
                    case 13:
                        result = 'D' + result;
                        Console.Write("resto: " + "D" + " ");
                        Console.WriteLine("quociente: " + x);
                        break;
                    case 14:
                        result = 'E' + result;
                        Console.Write("resto: " + "E" + " ");
                        Console.WriteLine("quociente: " + x);
                        break;
                    case 15:
                        result = 'F' + result;
                        Console.Write("resto: " + "F" + " ");
                        Console.WriteLine("quociente: " + x);
                        break;
                    default:
                        result = r.ToString() + result;
                        Console.Write("resto: "+ r + " ");
                        Console.WriteLine("quociente: " + x);
                        break;
                }




               
                
            }
            Console.WriteLine("Junte os restos na ordem");
            return result;
        }

    }
}
    
