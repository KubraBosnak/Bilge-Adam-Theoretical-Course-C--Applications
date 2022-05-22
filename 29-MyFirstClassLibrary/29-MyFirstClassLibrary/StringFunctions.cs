using System;

namespace _29_MyFirstClassLibrary.StringOperations
{
    public partial class StringFunctions
    {
        /// <summary>
        /// Bu metot ile iki metni bir ayıraç kullanarak yada kullanmayarak birleştirme işlemini yapabilirsiniz.
        /// </summary>
        /// <param name="metin1">Metin 1</param>
        /// <param name="metin2">Metin 2</param>
        /// <param name="ayirac">Ayıraç </param>
        /// <returns>Geriye birleştirilmiş metni döndürür.</returns>
        public string Birlestir(string metin1, string metin2, string ayirac="")
        {
            return metin1 + ayirac + metin2;
        }
        public string Birlestir(string ayirac = "", params string[] metinler)
        {
            string result = string.Empty; // "" 
            int index = 0;

            foreach (string item in metinler)
            {
                if (index==metinler.Length-1)
                {
                    result += item;
                }
                else
                {
                    result += item + ayirac;
                }
                index++;
            }
            return result;
        }
    }
}
