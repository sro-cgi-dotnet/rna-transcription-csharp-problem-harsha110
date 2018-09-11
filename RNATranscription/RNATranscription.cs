using System;

namespace RNATranscriptionModule
{
    public static class RnaTranscription
    {
        public static string ToRna(string nucleotide)
        {
            Rep obj = new Rep();
            try
            {
                if(nucleotide==null)
                {
                    throw new ArgumentNullException();
                }
                else if(nucleotide=="")
                {
                     throw new ArgumentException();
                }
                int length = nucleotide.Length;
                for (int i = 0; i < length; i++)
                {
                    if(nucleotide[i]=='G')
                    {
                        nucleotide=obj.Replace(i,'C',nucleotide);
                    }
                    else if(nucleotide[i]=='C')
                    {
                       nucleotide=obj.Replace(i,'G',nucleotide);
                    }
                    else if(nucleotide[i]=='T')
                    {
                        nucleotide=obj.Replace(i,'A',nucleotide);
                    }
                    else if(nucleotide[i]=='A')
                    {
                        nucleotide=obj.Replace(i,'U',nucleotide);
                    }
                    else{
                        throw new Exception();
                    }
                }
                
            } 

            catch(ArgumentNullException e)
            {
               Console.WriteLine("DNA format given is null");
            }
            catch(ArgumentException e)
            {
               Console.WriteLine("DNA format given is empty");
            }  
            catch(Exception e)
            {
               Console.WriteLine("DNA format must consist of only G,C,A,T");
            }
             return nucleotide;  

        } 
    }

    public class Rep
    {
    public string Replace(int j, char value,string sentence)
        {
            char[] letters = sentence.ToCharArray();
            letters[j]=value;
            return string.Join("",letters);
        }
    }
} 
