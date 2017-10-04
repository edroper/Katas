using System;

class MorseCodeDecoder
{
  public static string Decode(string morseCode)
  {
    var words = morseCode.Split(new[]{"   "}, StringSplitOptions.RemoveEmptyEntries);
    var decoded = "";
    
    var i = 0;
    
    for(i=0;i<=words.Length-1;i++){
    
      var letters = words[i].Split(new[]{" "}, StringSplitOptions.RemoveEmptyEntries);
      foreach(string letter in letters) {
        decoded += MorseCode.Get(letter);
      }
      
      decoded += (i + 1 == words.Length) ? "" : " ";
    
    }
    
    return decoded;
  }
}
