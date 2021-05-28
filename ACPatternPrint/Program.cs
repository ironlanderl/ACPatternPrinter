using System;
using System.IO;
using System.Net.Sockets;
using System.Text;

namespace ACPatternPrint
{
    internal class Program
    {
        static public int position = 0;
        public static Socket Connection = new Socket(SocketType.Stream, ProtocolType.Tcp);

        private static void SelectColor(char color)
        {
            switch (color)
            {
                case '0':
                    while (position < 0)
                    {
                        position++;
                        Connection.Send(Encoding.ASCII.GetBytes("click R" + '\n' + '\r'));
                    }
                    while (position > 0)
                    {
                        position--;
                        Connection.Send(Encoding.ASCII.GetBytes("click L" + '\n' + '\r'));
                    }
                    Connection.Send(Encoding.ASCII.GetBytes("click A" + '\n' + '\r'));
                    break;

                case '1':
                    while (position < 1)
                    {
                        position++;
                        Connection.Send(Encoding.ASCII.GetBytes("click R" + '\n' + '\r'));
                    }
                    while (position > 1)
                    {
                        position--;
                        Connection.Send(Encoding.ASCII.GetBytes("click L" + '\n' + '\r'));
                    }
                    Connection.Send(Encoding.ASCII.GetBytes("click A" + '\n' + '\r'));
                    break;

                case '2':
                    while (position < 2)
                    {
                        position++;
                        Connection.Send(Encoding.ASCII.GetBytes("click R" + '\n' + '\r'));
                    }
                    while (position > 2)
                    {
                        position--;
                        Connection.Send(Encoding.ASCII.GetBytes("click L" + '\n' + '\r'));
                    }
                    Connection.Send(Encoding.ASCII.GetBytes("click A" + '\n' + '\r'));
                    break;

                case '3':
                    while (position < 3)
                    {
                        position++;
                        Connection.Send(Encoding.ASCII.GetBytes("click R" + '\n' + '\r'));
                    }
                    while (position > 3)
                    {
                        position--;
                        Connection.Send(Encoding.ASCII.GetBytes("click L" + '\n' + '\r'));
                    }
                    Connection.Send(Encoding.ASCII.GetBytes("click A" + '\n' + '\r'));
                    break;

                case '4':
                    while (position < 4)
                    {
                        position++;
                        Connection.Send(Encoding.ASCII.GetBytes("click R" + '\n' + '\r'));
                    }
                    while (position > 4)
                    {
                        position--;
                        Connection.Send(Encoding.ASCII.GetBytes("click L" + '\n' + '\r'));
                    }
                    Connection.Send(Encoding.ASCII.GetBytes("click A" + '\n' + '\r'));
                    break;

                case '5':
                    while (position < 5)
                    {
                        position++;
                        Connection.Send(Encoding.ASCII.GetBytes("click R" + '\n' + '\r'));
                    }
                    while (position > 5)
                    {
                        position--;
                        Connection.Send(Encoding.ASCII.GetBytes("click L" + '\n' + '\r'));
                    }
                    Connection.Send(Encoding.ASCII.GetBytes("click A" + '\n' + '\r'));
                    break;

                case '6':
                    while (position < 6)
                    {
                        position++;
                        Connection.Send(Encoding.ASCII.GetBytes("click R" + '\n' + '\r'));
                    }
                    while (position > 6)
                    {
                        position--;
                        Connection.Send(Encoding.ASCII.GetBytes("click L" + '\n' + '\r'));
                    }
                    Connection.Send(Encoding.ASCII.GetBytes("click A" + '\n' + '\r'));
                    break;

                case '7':
                    while (position < 7)
                    {
                        position++;
                        Connection.Send(Encoding.ASCII.GetBytes("click R" + '\n' + '\r'));
                    }
                    while (position > 7)
                    {
                        position--;
                        Connection.Send(Encoding.ASCII.GetBytes("click L" + '\n' + '\r'));
                    }
                    Connection.Send(Encoding.ASCII.GetBytes("click A" + '\n' + '\r'));
                    break;

                case '8':
                    while (position < 8)
                    {
                        position++;
                        Connection.Send(Encoding.ASCII.GetBytes("click R" + '\n' + '\r'));
                    }
                    while (position > 8)
                    {
                        position--;
                        Connection.Send(Encoding.ASCII.GetBytes("click L" + '\n' + '\r'));
                    }
                    Connection.Send(Encoding.ASCII.GetBytes("click A" + '\n' + '\r'));
                    break;

                case '9':
                    while (position < 9)
                    {
                        position++;
                        Connection.Send(Encoding.ASCII.GetBytes("click R" + '\n' + '\r'));
                    }
                    while (position > 9)
                    {
                        position--;
                        Connection.Send(Encoding.ASCII.GetBytes("click L" + '\n' + '\r'));
                    }
                    Connection.Send(Encoding.ASCII.GetBytes("click A" + '\n' + '\r'));
                    break;

                case 'A':
                    while (position < 10)
                    {
                        position++;
                        Connection.Send(Encoding.ASCII.GetBytes("click R" + '\n' + '\r'));
                    }
                    while (position > 10)
                    {
                        position--;
                        Connection.Send(Encoding.ASCII.GetBytes("click L" + '\n' + '\r'));
                    }
                    Connection.Send(Encoding.ASCII.GetBytes("click A" + '\n' + '\r'));
                    break;

                case 'B':
                    while (position < 11)
                    {
                        position++;
                        Connection.Send(Encoding.ASCII.GetBytes("click R" + '\n' + '\r'));
                    }
                    while (position > 11)
                    {
                        position--;
                        Connection.Send(Encoding.ASCII.GetBytes("click L" + '\n' + '\r'));
                    }
                    Connection.Send(Encoding.ASCII.GetBytes("click A" + '\n' + '\r'));
                    break;

                case 'C':
                    while (position < 12)
                    {
                        position++;
                        Connection.Send(Encoding.ASCII.GetBytes("click R" + '\n' + '\r'));
                    }
                    while (position > 12)
                    {
                        position--;
                        Connection.Send(Encoding.ASCII.GetBytes("click L" + '\n' + '\r'));
                    }
                    Connection.Send(Encoding.ASCII.GetBytes("click A" + '\n' + '\r'));
                    break;

                case 'D':
                    while (position < 13)
                    {
                        position++;
                        Connection.Send(Encoding.ASCII.GetBytes("click R" + '\n' + '\r'));
                    }
                    while (position > 13)
                    {
                        position--;
                        Connection.Send(Encoding.ASCII.GetBytes("click L" + '\n' + '\r'));
                    }
                    Connection.Send(Encoding.ASCII.GetBytes("click A" + '\n' + '\r'));
                    break;

                case 'E':
                    while (position < 14)
                    {
                        position++;
                        Connection.Send(Encoding.ASCII.GetBytes("click R" + '\n' + '\r'));
                    }
                    while (position > 14)
                    {
                        position--;
                        Connection.Send(Encoding.ASCII.GetBytes("click L" + '\n' + '\r'));
                    }
                    Connection.Send(Encoding.ASCII.GetBytes("click A" + '\n' + '\r'));
                    break;

                case 'F':
                    while (position < 15)
                    {
                        position++;
                        Connection.Send(Encoding.ASCII.GetBytes("click R" + '\n' + '\r'));
                    }
                    while (position > 15)
                    {
                        position--;
                        Connection.Send(Encoding.ASCII.GetBytes("click L" + '\n' + '\r'));
                    }
                    Connection.Send(Encoding.ASCII.GetBytes("click A" + '\n' + '\r'));
                    break;

                default:
                    Console.WriteLine(color + "\tERROR");
                    break;
            }
        }

        private static void Main(string[] args)
        {
            string fileDirectory = null;
            try
            {
                fileDirectory = args[0];
            }
            catch (Exception)
            {
                Environment.Exit(0);
            }

            FileStream fs = new FileStream(fileDirectory, FileMode.Open);
            int hexIn;
            char[] pattern;
            char[,] pattern2;
            string hex = "";
            string ip;
            //ask for switch ip
            Console.Write("IP: ");
            ip = Console.ReadLine();

            // load hex from file
            for (int i = 0; (hexIn = fs.ReadByte()) != -1; i++)
            {
                hex += string.Format("{0:X2}", hexIn);
            }
            //remove non pattern data
            hex = hex.Substring(216);
            int stringLenght = hex.Length;
            pattern = new char[stringLenght];
            pattern = hex.ToCharArray();

            // invert hex order
            for (int i = 0; i < stringLenght - 3; i += 2)
            {
                char tmp;
                tmp = pattern[i];
                pattern[i] = pattern[i + 1];
                pattern[i + 1] = tmp;
            }
            const int patternDimension = 32;
            pattern2 = new char[patternDimension, patternDimension];
            int tot = 0;

            //divide it in a 32*32 matrix
            for (int i = 0; i < patternDimension; i++)
            {
                for (int j = 0; j < patternDimension; j++)
                {
                    pattern2[i, j] = pattern[tot];
                    tot++;
                }
            }

            //invert every second line for faster printing
            for (int i = 1; i < patternDimension; i += 2)
            {
                for (int j = 0; j < patternDimension / 2; j++)
                {
                    char tmp;
                    tmp = pattern2[i, j];
                    pattern2[i, j] = pattern2[i, patternDimension - j - 1];
                    pattern2[i, patternDimension - j - 1] = tmp;
                }
            }

            //connect to nintendo switch
            try
            {
                Connection.Connect(ip, 6000);
                
            }
            catch (Exception)
            {                
                Console.WriteLine("Could not connect to switch");
                Console.WriteLine("Press enter to exit");
                Console.ReadLine();
                Environment.Exit(0);
            }
            //print if connected, else exit

                for (int i = 0; i < patternDimension; i++)
                {
                    for (int j = 0; j < patternDimension; j++)
                    {
                        SelectColor(pattern2[i, j]);
                        Connection.Send(Encoding.ASCII.GetBytes("click DRIGHT" + '\n' + '\r'));
                        System.Threading.Thread.Sleep(250);
                    }
                    Connection.Send(Encoding.ASCII.GetBytes("click DDOWN" + '\n' + '\r'));
                    i++;
                    for (int j = 0; j < patternDimension; j++)
                    {
                        SelectColor(pattern2[i, j]);
                        Connection.Send(Encoding.ASCII.GetBytes("click DLEFT" + '\n' + '\r'));
                        System.Threading.Thread.Sleep(250);
                    }
                    Connection.Send(Encoding.ASCII.GetBytes("click DDOWN" + '\n' + '\r'));

            }
        }
    }
}