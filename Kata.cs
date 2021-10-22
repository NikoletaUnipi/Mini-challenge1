public class Kata
{
  public static string DuplicateEncode(string word)
  {
    string newWord="";
    char[] array= word;
    for(int j=0;j<array.lengh-1;j++)
      char temp=array[j];
      bool notFound=true;
      for(int i=0;i<array.lengh-1;i++){
        if(i!=j){
          if(array[j].equals(array[i])){
            newWord+=")";
            notFound= false;
            break;
          }
          
        }
        if(notFound){
          newWord+="(";
        }
      }
    }
    word=newWord;
    return word;
  }
}