int resultat;
if(!int.TryParse(Console.ReadLine(), out resultat))
   Console.WriteLine("Skriv in en siffra");

    static bool TryParse(string s, out int result)
   {
       char[] characters = s.ToCharArray();

       foreach(char c in characters)
       {
          if(!char.IsDigit(c))
          {
            result = 0;
            return false;
          }
       }
       result = int.Parse(s);
       return true;
   }