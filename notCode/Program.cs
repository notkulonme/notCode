using System;

namespace NotCode
{
    public static class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine(IndexToLetter(87));
            Console.WriteLine("the program strated");
            End();
        }

        
        static void Decode(string text, string alphabet)
        {
            Char egyenjel = '=';
            Char kettpont = ':';
            string output;
            output = " ";
            int szam = 0;
            if (text[0].Equals(kettpont))
            {
                text = text.Remove(0,1);
                int kör = 1;
                for (int i = 0; i <= alphabet.Length - 1; i++)
                {

                    if(kör.IsEven())
                    {
                        Console.WriteLine(text[i].GetIndexFromAlphabet() - 34 + alphabet.Length);
                        szam = text[i].GetIndexFromAlphabet() - 34 + alphabet.Length;
                        output += szam.IndexToLetter();
                        kör++;
                    }
                    else if(!kör.IsEven())
                    {
                        Console.WriteLine(text[i].GetIndexFromAlphabet() - 13 + alphabet.Length);
                        szam = (text[i].GetIndexFromAlphabet() - 13 + alphabet.Length);
                        output += szam.IndexToLetter();
                        kör++;
                    }

                }
            }
            else if (text[0].Equals(egyenjel))
            {
                text = text.Remove(0, 1);
                int kör = 1;
                for (int i = 0; i <= text.Length - 1; i++)
                {
                    if (kör.IsEven())
                    {
                        Console.WriteLine(text[i].GetIndexFromAlphabet() - 7 + alphabet.Length);
                        szam = (text[i].GetIndexFromAlphabet() - 7 + alphabet.Length);
                        output += szam.IndexToLetter();
                        kör++;
                    }
                    else if (!kör.IsEven())
                    {
                        Console.WriteLine(text[i].GetIndexFromAlphabet() - 20 + alphabet.Length);
                        szam = (text[i].GetIndexFromAlphabet() - 20 + alphabet.Length);
                        output += szam.IndexToLetter();
                        kör++;
                    }
                }
            }
            else
            {
                output = " The input wasnt Encoded in notCode";
            }
            output = output.Remove(0, 1);
            Console.WriteLine(output);
            End();
        }


        static void Encode(string text, string alphabet)
        {
            string output;
            if (text[0].GetIndexFromAlphabet().IsEven())
            {
                int kör = 1;
                output = ":";
                for (int i = 0; i <= text.Length - 1; i++)
                {
                    if (kör.IsEven())
                    {
                        output += (text[i].GetIndexFromAlphabet() + 34).IndexToLetter();
                        kör++;
                    }
                    else if (!kör.IsEven())
                    {
                        output += (text[i].GetIndexFromAlphabet() + 13).IndexToLetter();
                        kör++;
                    }

                }

            }
            else if (!text[0].GetIndexFromAlphabet().IsEven())
            {
                output = "=";
                int kör = 1;
                for(int i = 0; i <= text.Length - 1; i++)
                {
                    if (kör.IsEven())
                    {
                        output += (text[i].GetIndexFromAlphabet() + 7).IndexToLetter();
                        kör++;
                    }
                    else if (!kör.IsEven())
                    { 
                        output += (text[i].GetIndexFromAlphabet() + 20).IndexToLetter(); ;
                    }
                }
            }
            else
            { 
                Console.WriteLine("Something is wrong here");
                output = "0";
            }
            Console.WriteLine(output);
            End();
        }


        static void End()
        {
            string alphabet = "0389chdŰVWábXelmnoqaiíjkrHIÍJstuúüűTéfgUÚÜvwxyz1ÁBCDEÉFGK62Aóöőp7OÓÖŐP5QRSYZ!?.+-LMN4% ";
            Console.WriteLine(alphabet.Length);
            Console.WriteLine("choose from decode: 1\n" +
                              "         or encode: 2\n" +
                              "           or exit: 3");
            string choosed = Console.ReadLine();

            if (choosed.Equals("1"))
            {
                Console.WriteLine("insert the text here");
                string readed = Console.ReadLine();
                Decode(readed, alphabet);
            }
            else if (choosed.Equals("2"))
            {
                Console.WriteLine("insert the text here");
                string readed = Console.ReadLine();
                Encode(readed, alphabet);
            }
            else if (choosed.Equals("3")) { }
            else 
            {
                if ( choosed[0].Equals(':') | choosed[0].Equals('=') )
                {
                    string readed = choosed;
                    Decode(readed, alphabet);
                }
                else 
                {
                    string readed = choosed;
                    Encode(readed, alphabet);
                }
            }   
        }

        static bool IsEven(this int value)
        {
            return value % 2 == 0;
        }

        static int GetIndexFromAlphabet(this Char betű) 
        {
            string alphabet = "0389chdŰVWábXelmnoqaiíjkrHIÍJstuúüűTéfgUÚÜvwxyz1ÁBCDEÉFGK62Aóöőp7OÓÖŐP5QRSYZ!?.+-LMN4% ";
            for (int x = 0; x <= alphabet.Length - 1; x++)
            {
                if (alphabet[x].Equals(betű))
                {
                    return x;
                }
            }
            return alphabet.Length-1;
        }

        static char IndexToLetter(this int index)
        {
            string alphabet = "0389chdŰVWábXelmnoqaiíjkrHIÍJstuúüűTéfgUÚÜvwxyz1ÁBCDEÉFGK62Aóöőp7OÓÖŐP5QRSYZ!?.+-LMN4% 0389chdŰVWábXelmnoqaiíjkrHIÍJstuúüűTéfgUÚÜvwxyz1ÁBCDEÉFGK62Aóöőp7OÓÖŐP5QRSYZ!?.+-LMN4% 0389chdŰVWábXelmnoqaiíjkrHIÍJstuúüűTéfgUÚÜvwxyz1ÁBCDEÉFGK62Aóöőp7OÓÖŐP5QRSYZ!?.+-LMN4% 0389chdŰVWábXelmnoqaiíjkrHIÍJstuúüűTéfgUÚÜvwxyz1ÁBCDEÉFGK62Aóöőp7OÓÖŐP5QRSYZ!?.+-LMN4% ";
            Console.WriteLine(alphabet.Length);
            Console.WriteLine(index);
            return alphabet[index];
        }
        
     
    }
}